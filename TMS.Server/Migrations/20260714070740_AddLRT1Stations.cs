using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TMS.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddLRT1Stations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "Latitude", "Longitude", "Name", "RailLineId", "SequenceNumber" },
                values: new object[,]
                {
                    { 7, 14.5176, 120.9971, "Baclaran", 1, 1 },
                    { 8, 14.524900000000001, 120.99250000000001, "EDSA", 1, 2 },
                    { 9, 14.5535, 120.9975, "Libertad", 1, 3 },
                    { 10, 14.5587, 120.9945, "Gil Puyat", 1, 4 },
                    { 11, 14.5624, 120.994, "Vito Cruz", 1, 5 },
                    { 12, 14.5702, 120.9918, "Quirino", 1, 6 },
                    { 13, 14.5768, 120.98869999999999, "Pedro Gil", 1, 7 },
                    { 14, 14.582700000000001, 120.9847, "United Nations", 1, 8 },
                    { 15, 14.5891, 120.9817, "Central Terminal", 1, 9 },
                    { 16, 14.599399999999999, 120.9798, "Carriedo", 1, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
