using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TMS.Server.Migrations
{
    /// <inheritdoc />
    public partial class CompleteLRT2LRT1Stations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "Latitude", "Longitude", "Name", "RailLineId", "SequenceNumber" },
                values: new object[,]
                {
                    { 34, 14.603300000000001, 120.98220000000001, "Doroteo Jose", 1, 11 },
                    { 35, 14.6106, 120.982, "Bambang", 1, 12 },
                    { 36, 14.617000000000001, 120.9825, "Tayuman", 1, 13 },
                    { 37, 14.6227, 120.98220000000001, "Blumentritt", 1, 14 },
                    { 38, 14.6302, 120.98180000000001, "Abad Santos", 1, 15 },
                    { 39, 14.6388, 120.98220000000001, "R. Papa", 1, 16 },
                    { 40, 14.6449, 120.9825, "5th Avenue", 1, 17 },
                    { 41, 14.6548, 120.983, "Monumento", 1, 18 },
                    { 42, 14.6576, 120.98350000000001, "Balintawak", 1, 19 },
                    { 43, 14.6578, 121.0, "Fernando Poe Jr.", 1, 20 },
                    { 44, 14.6228, 121.0792, "Santolan", 2, 11 },
                    { 45, 14.6206, 121.1018, "Marikina-Pasig", 2, 12 },
                    { 46, 14.6258, 121.121, "Antipolo", 2, 13 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 46);
        }
    }
}
