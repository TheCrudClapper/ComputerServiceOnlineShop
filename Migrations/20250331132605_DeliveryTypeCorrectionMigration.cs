﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComputerServiceOnlineShop.Migrations
{
    /// <inheritdoc />
    public partial class DeliveryTypeCorrectionMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryTypes_Offers_OfferId",
                table: "ParcelLockerDeliveries");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "ParcelLockerDeliveries",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "OfferId",
                table: "ParcelLockerDeliveries",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ParcelLockerDeliveries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryTypes_Offers_OfferId",
                table: "ParcelLockerDeliveries",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryTypes_Offers_OfferId",
                table: "ParcelLockerDeliveries");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ParcelLockerDeliveries");

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "ParcelLockerDeliveries",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<int>(
                name: "OfferId",
                table: "ParcelLockerDeliveries",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryTypes_Offers_OfferId",
                table: "ParcelLockerDeliveries",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
