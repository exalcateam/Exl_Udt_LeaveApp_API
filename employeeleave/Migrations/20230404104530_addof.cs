using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace leaverequest.Migrations
{
    public partial class addof : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateofBirth",
                table: "Login",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmailId",
                table: "Login",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Login",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Login",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Login",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateofBirth",
                table: "Login");

            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "Login");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Login");

            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Login");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Login");
        }
    }
}
