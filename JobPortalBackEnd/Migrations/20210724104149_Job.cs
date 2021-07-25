using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobPortalBackEnd.Migrations
{
    public partial class Job : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.CreateTable(
                name: "JobApplications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<int>(nullable: true),
                    JobSeekerId = table.Column<int>(nullable: true),
                    EmployerId = table.Column<int>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    JobTitle = table.Column<string>(nullable: true),
                    JobType = table.Column<string>(nullable: true),
                    Filepath = table.Column<string>(nullable: true),
                    JobLocation = table.Column<string>(nullable: true),
                    Deadline = table.Column<DateTime>(nullable: true),
                    ApplicationDeadline = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobDetails = table.Column<string>(nullable: true),
                    JobType = table.Column<string>(nullable: true),
                    Vacancy = table.Column<string>(nullable: true),
                    EmploymentStatus = table.Column<string>(nullable: true),
                    Experience = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Age = table.Column<string>(nullable: true),
                    JobLocation = table.Column<string>(nullable: true),
                    Salary = table.Column<string>(nullable: true),
                    Deadline = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobApplications");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Session = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });
        }
    }
}
