using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TMS.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreMRT3Stations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "Latitude", "Longitude", "Name", "RailLineId", "SequenceNumber" },
                values: new object[,]
                {
                    { 4, 14.622, 121.05670000000001, "Araneta Center-Cubao", 3, 4 },
                    { 5, 14.610900000000001, 121.0561, "Santolan-Annapolis", 3, 5 },
                    { 6, 14.586600000000001, 121.056, "Ortigas", 3, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
