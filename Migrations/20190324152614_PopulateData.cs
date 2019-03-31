using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BestProductFindsApi.Migrations
{
    public partial class PopulateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Men's" },
                    { 2, "Women's" },
                    { 3, "Electronics" },
                    { 4, "Outdoors" }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "Name", "WebSite" },
                values: new object[,]
                {
                    { 1, "Hepsiburada", "www.hepsiburada.com" },
                    { 2, "Trendyol", "www.trendyol.com" },
                    { 3, "Morhipo", "www.morhipo.com" },
                    { 4, "ModaCruz", "www.modacruz.com" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateDate", "Description", "Name", "Price", "SellerId", "URL" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 3, 24, 18, 26, 14, 186, DateTimeKind.Local).AddTicks(370), "Koton Erkek Slim Pantolon", "Koton Erkek Slim Pantolon", 70.39m, 1, "https://www.hepsiburada.com/koton-erkek-slim-pantolon-p-HBV00000DI558" },
                    { 2, 1, new DateTime(2019, 3, 24, 18, 26, 14, 187, DateTimeKind.Local).AddTicks(3260), "Lc Waikiki Erkek Polo Yaka Tshirt", "Lc Waikiki Erkek Polo Yaka Tshirt", 29.99m, 1, "https://www.hepsiburada.com/lc-waikiki-erkek-polo-yaka-tshirt-p-HBV00000GR2VA" },
                    { 7, 3, new DateTime(2019, 3, 24, 18, 26, 14, 187, DateTimeKind.Local).AddTicks(3290), "Samsung 40J5270 40\" 102 Ekran Uydu Alıcılı Full HD Smart LED TV", "Samsung 40J5270 40\" 102 Ekran Uydu Alıcılı Full HD Smart LED TV", 2191.50m, 1, "https://www.hepsiburada.com/samsung-40j5270-40-102-ekran-uydu-alicili-full-hd-smart-led-tv-p-EVTVSAM40J5270" },
                    { 3, 2, new DateTime(2019, 3, 24, 18, 26, 14, 187, DateTimeKind.Local).AddTicks(3280), "Kadın Siyah Pantolon IW6180003108 IW6180003108", "Kadın Siyah Pantolon", 164.50m, 2, "https://www.trendyol.com/ipekyol/kadin-siyah-pantolon-iw6180003108-p-3603675?boutiqueId=309730&merchantId=968" },
                    { 4, 2, new DateTime(2019, 3, 24, 18, 26, 14, 187, DateTimeKind.Local).AddTicks(3280), "Kadın Bej Etek (18805)", "Kadın Bej Etek", 420.00m, 2, "https://www.trendyol.com/burberry/kadin-bej-etek-18805-p-3224783?boutiqueId=307783&merchantId=4421" },
                    { 5, 2, new DateTime(2019, 3, 24, 18, 26, 14, 187, DateTimeKind.Local).AddTicks(3280), "Jean Pantolon | Sophie - Skinny", "Jean Pantolon", 149.90m, 3, "https://www.morhipo.com/kampanya/detay/15359570/80621/tommy-hilfiger-jean-pantolon-sophie-skinny" },
                    { 6, 2, new DateTime(2019, 3, 24, 18, 26, 14, 187, DateTimeKind.Local).AddTicks(3280), "Ceket", "Ceket", 904.90m, 3, "https://www.morhipo.com/kampanya/detay/20712902/80613/emporio-armani-ss1600001979-ceket" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
