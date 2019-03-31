using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BestProductFindsApi.Migrations
{
    public partial class PopulateData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateDate", "Description", "Name", "Price", "SellerId", "URL" },
                values: new object[,]
                {
                    { 8, 2, new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nine West Çanta", "Nine West Çanta", 459m, 3, "https://www.morhipo.com/nine-west-canta/22312953/detay" },
                    { 9, 3, new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huawei Mate 10 Lite (Huawei Türkiye Garantili)", "Huawei Mate 10 Lite", 1799.90m, 1, "https://www.hepsiburada.com/huawei-mate-10-lite-huawei-turkiye-garantili-p-HBV0000093BZC" },
                    { 10, 3, new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huawei Watch GT Classic Akıllı Saat - Kahverengi", "Huawei Watch GT Classic Akıllı Saat - Kahverengi", 1299m, 1, "https://www.hepsiburada.com/huawei-watch-gt-classic-akilli-saat-kahverengi-p-HBV00000FSSWW" },
                    { 11, 4, new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salcano Ng 650 27.5 Jant Hd Bisiklet 18 inç Kadro, Siyah - Kırmızı", "Salcano Ng 650 27.5 Jant Hd Bisiklet 18 inç Kadro", 1840m, 1, "https://www.hepsiburada.com/salcano-ng-650-27-5-jant-hd-bisiklet-18-inc-kadro-siyah-kirmizi-p-HBV00000BH262" },
                    { 12, 4, new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The North Face - Mountain 25 - 2 kişilik Çadır Sarı", "The North Face - Mountain 25 - 2 kişilik Çadır Sarı", 3801.85m, 1, "https://www.hepsiburada.com/the-north-face-mountain-25-2-kisilik-cadir-sari-p-HBV0000021PGK?magaza=NORADRENAL%C4%B0N" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 24, 18, 26, 14, 186, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 24, 18, 26, 14, 187, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2019, 3, 24, 18, 26, 14, 187, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2019, 3, 24, 18, 26, 14, 187, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2019, 3, 24, 18, 26, 14, 187, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2019, 3, 24, 18, 26, 14, 187, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2019, 3, 24, 18, 26, 14, 187, DateTimeKind.Local).AddTicks(3290));
        }
    }
}
