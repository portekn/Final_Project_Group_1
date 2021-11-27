using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project_Group_1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    interest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterestYears = table.Column<int>(type: "int", nullable: false),
                    Expensive = table.Column<bool>(type: "bit", nullable: false),
                    TimeConsumption = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Expensive", "InterestYears", "TimeConsumption", "interest" },
                values: new object[] { 1, true, 3, 2, "Studies" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "City", "State", "StreetName", "ZipCode" },
                values: new object[] { 1, "Cusco", "Test", "Los Saucos", 8000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
