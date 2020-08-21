using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class SeedNationalData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
