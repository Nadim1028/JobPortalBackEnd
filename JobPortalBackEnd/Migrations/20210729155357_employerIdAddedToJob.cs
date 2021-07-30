using Microsoft.EntityFrameworkCore.Migrations;

namespace JobPortalBackEnd.Migrations
{
    public partial class employerIdAddedToJob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobDetails",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "JobType",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "EmployerAuthTable");

            migrationBuilder.RenameColumn(
                name: "publishedDate",
                table: "Jobs",
                newName: "PublishedDate");

            migrationBuilder.AddColumn<int>(
                name: "EmployerId",
                table: "Jobs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "JobDetailsFilePath",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobType",
                table: "Jobs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployerId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "JobDetailsFilePath",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "JobType",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "PublishedDate",
                table: "Jobs",
                newName: "publishedDate");

            migrationBuilder.AddColumn<string>(
                name: "JobDetails",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "JobApplications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobType",
                table: "JobApplications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "EmployerAuthTable",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
