using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TMS.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedRailLines : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Color",
                table: "RailLines",
                newName: "ShortName");

            migrationBuilder.AddColumn<string>(
                name: "PrimaryColor",
                table: "RailLines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "RailLines",
                columns: new[] { "Id", "Name", "PrimaryColor", "ShortName" },
                values: new object[,]
                {
                    { 1, "Light Rail Transit Line 1", "#009639", "LRT-1" },
                    { 2, "Light Rail Transit Line 2", "#7B1FA2", "LRT-2" },
                    { 3, "Metro Rail Transit Line 3", "#005EB8", "MRT-3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stations_RailLineId",
                table: "Stations",
                column: "RailLineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stations_RailLines_RailLineId",
                table: "Stations",
                column: "RailLineId",
                principalTable: "RailLines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stations_RailLines_RailLineId",
                table: "Stations");

            migrationBuilder.DropIndex(
                name: "IX_Stations_RailLineId",
                table: "Stations");

            migrationBuilder.DeleteData(
                table: "RailLines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RailLines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RailLines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "PrimaryColor",
                table: "RailLines");

            migrationBuilder.RenameColumn(
                name: "ShortName",
                table: "RailLines",
                newName: "Color");
        }
    }
}
