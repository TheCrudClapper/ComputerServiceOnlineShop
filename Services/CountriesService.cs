﻿using ComputerServiceOnlineShop.Abstractions;
using ComputerServiceOnlineShop.Entities.Contexts;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ComputerServiceOnlineShop.Services
{
    public class CountriesService : ICountriesService
    {
        private readonly DatabaseContext _databaseContext;
        public CountriesService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<List<SelectListItem>> GetCountriesSelectionList()
        {
            return await _databaseContext.Countries
                .Where(item => item.IsActive)
                .Select(item => new SelectListItem { Text = item.CountryName, Value = item.Id.ToString() })
                .ToListAsync();
        }
    }
}
