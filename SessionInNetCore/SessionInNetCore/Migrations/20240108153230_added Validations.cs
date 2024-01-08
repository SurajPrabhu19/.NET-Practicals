using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SessionInNetCore.Migrations
{
    public partial class addedValidations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(name: "User");
            //migrationBuilder.CreateTable(
            //    name: "Employee",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Employee", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Student",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        dept = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
            //        rollNo = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Student", x => x.id);
            //    });


            //migrationBuilder.CreateTable(
            //    name: "User",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        phone = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
            //        password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        gender = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_User", x => x.id);
            //    }) ;
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Employee");

            //migrationBuilder.DropTable(
            //    name: "Student");

            //migrationBuilder.DropTable(
            //    name: "User");
        }
    }
}
