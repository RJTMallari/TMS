using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TMS.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddStationSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "Latitude", "Longitude", "Name", "RailLineId", "SequenceNumber" },
                values: new object[,]
                {
                    { 1, 14.6549, 121.0304, "North Avenue", 3, 1 },
                    { 2, 14.6426, 121.0389, "Quezon Avenue", 3, 2 },
                    { 3, 14.6348, 121.0438, "GMA Kamuning", 3, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
