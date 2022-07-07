using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Burger.DAL.Migrations
{
    public partial class Login_fields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mail",
                table: "Kullanicilar",
                newName: "UserName");

            migrationBuilder.AddColumn<string>(
                name: "EMail",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EMail",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Kullanicilar");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Kullanicilar",
                newName: "Mail");
        }
    }
}
