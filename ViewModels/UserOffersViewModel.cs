﻿namespace ComputerServiceOnlineShop.ViewModels
{
    public class UserOffersViewModel 
    {
        public string ImageUrl { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string ProductCategory { get; set; } = null!;
        public string ProductCondition { get; set; } = null!;
        public bool ProductStatus { get; set; }
        public int StockQuantity;
        public decimal Price;
        public DateTime DateCreated { get; set; }
        public DateTime? DateEdited { get; set; }
    }
}
