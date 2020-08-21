using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class SeedStateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Nationals",
                keyColumn: "NationalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nationals",
                keyColumn: "NationalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nationals",
                keyColumn: "NationalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Nationals",
                keyColumn: "NationalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Nationals",
                keyColumn: "NationalId",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "StateId", "StateName", "StateParkName", "StateParkYear" },
                values: new object[,]
                {
                    { 1, "New York", "Niagara Falls State Park", 1885 },
                    { 2, "Michigan", "Porcupine Mountains Wilderness State Park", 1944 },
                    { 3, "Oregon", "Ecola State Park", 1932 },
                    { 4, "Minnesota", "Tettegouche State Park", 1979 },
                    { 5, "Nevada", "Valley of Fire State Park", 1935 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Nationals",
                columns: new[] { "NationalId", "NationalName", "NationalParkName", "NationalParkYear" },
                values: new object[,]
                {
                    { 1, "USA", "Glacier National Park", 1910 },
                    { 2, "USA", "Grand Canyon National Park", 1919 },
                    { 3, "USA", "Crater Lake National Park", 1902 },
                    { 4, "USA", "Yellowstone National Park", 1872 },
                    { 5, "USA", "Yosemite National Park", 1890 }
                });
        }
    }
}
