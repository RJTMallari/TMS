using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TMS.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddLRT2Stations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "Latitude", "Longitude", "Name", "RailLineId", "SequenceNumber" },
                values: new object[,]
                {
                    { 17, 14.603899999999999, 120.983, "Recto", 2, 1 },
                    { 18, 14.601800000000001, 120.9928, "Legarda", 2, 2 },
                    { 19, 14.601000000000001, 121.0056, "Pureza", 2, 3 },
                    { 20, 14.604200000000001, 121.017, "V. Mapa", 2, 4 },
                    { 21, 14.610300000000001, 121.0198, "J. Ruiz", 2, 5 },
                    { 22, 14.6137, 121.0228, "Gilmore", 2, 6 },
                    { 23, 14.618499999999999, 121.02809999999999, "Betty Go-Belmonte", 2, 7 },
                    { 24, 14.6227, 121.04389999999999, "Araneta Center-Cubao", 2, 8 },
                    { 25, 14.6287, 121.0643, "Anonas", 2, 9 },
                    { 26, 14.630699999999999, 121.0722, "Katipunan", 2, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 26);
        }
    }
}
