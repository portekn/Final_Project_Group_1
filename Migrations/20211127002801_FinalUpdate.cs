using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project_Group_1.Migrations
{
    public partial class FinalUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "interest",
                table: "Interests",
                newName: "InterestName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InterestName",
                table: "Interests",
                newName: "interest");
        }
    }
}
