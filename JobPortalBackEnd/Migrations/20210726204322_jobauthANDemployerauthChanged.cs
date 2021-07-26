using Microsoft.EntityFrameworkCore.Migrations;

namespace JobPortalBackEnd.Migrations
{
    public partial class jobauthANDemployerauthChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RePassword",
                table: "JobSeekerAuthTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "JobSeekerAuthTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RePassword",
                table: "EmployerAuthTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "EmployerAuthTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RePassword",
                table: "JobSeekerAuthTable");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "JobSeekerAuthTable");

            migrationBuilder.DropColumn(
                name: "RePassword",
                table: "EmployerAuthTable");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "EmployerAuthTable");
        }
    }
}
