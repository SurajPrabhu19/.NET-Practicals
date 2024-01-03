using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityCoreFrameworkImplementation.Migrations
{
    public partial class UpdatedDatabaseColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gender",
                table: "Student");

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "Student");

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
