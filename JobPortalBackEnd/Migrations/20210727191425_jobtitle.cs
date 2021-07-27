using Microsoft.EntityFrameworkCore.Migrations;

namespace JobPortalBackEnd.Migrations
{
    public partial class jobtitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobType",
                table: "Jobs");

            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "Jobs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "Jobs");

            migrationBuilder.AddColumn<string>(
                name: "JobType",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
