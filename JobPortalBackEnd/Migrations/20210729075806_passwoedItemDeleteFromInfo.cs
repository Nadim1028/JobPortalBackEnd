using Microsoft.EntityFrameworkCore.Migrations;

namespace JobPortalBackEnd.Migrations
{
    public partial class passwoedItemDeleteFromInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmationPassword",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "ConfirmationPassword",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Employers");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "JobSeekers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "JobSeekers");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmationPassword",
                table: "JobSeekers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "JobSeekers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConfirmationPassword",
                table: "Employers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Employers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
