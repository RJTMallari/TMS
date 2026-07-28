using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMS.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddStationDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstTrain",
                table: "Stations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastTrain",
                table: "Stations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Transfer",
                table: "Stations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "FirstTrain", "LastTrain", "Transfer" },
                values: new object[] { null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstTrain",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "LastTrain",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "Transfer",
                table: "Stations");
        }
    }
}
