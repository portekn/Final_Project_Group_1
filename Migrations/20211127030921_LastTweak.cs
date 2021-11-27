using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project_Group_1.Migrations
{
    public partial class LastTweak : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YOD",
                table: "Members");

            migrationBuilder.AlterColumn<string>(
                name: "BirthDate",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "Year" },
                values: new object[] { "11/29/2001", "Freshman" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Year",
                table: "Members");

            migrationBuilder.AlterColumn<int>(
                name: "BirthDate",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YOD",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "YOD" },
                values: new object[] { 2001, 2025 });
        }
    }
}
