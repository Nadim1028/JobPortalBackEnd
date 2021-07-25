using Microsoft.EntityFrameworkCore.Migrations;

namespace JobPortalBackEnd.Migrations
{
    public partial class abc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_JobSeekers",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "JobSeekers");

            migrationBuilder.AddColumn<int>(
                name: "JobSeekerId",
                table: "JobSeekers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobSeekers",
                table: "JobSeekers",
                column: "JobSeekerId");

            migrationBuilder.CreateTable(
                name: "EmployerAuthTable",
                columns: table => new
                {
                    EmployerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployerAuthTable", x => x.EmployerId);
                });

            migrationBuilder.CreateTable(
                name: "Employers",
                columns: table => new
                {
                    EmployerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    CompanyAddress = table.Column<string>(nullable: true),
                    IndustryType = table.Column<string>(nullable: true),
                    CompanyEmail = table.Column<string>(nullable: true),
                    CompanyContactNo = table.Column<string>(nullable: true),
                    YearOfEstablishment = table.Column<string>(nullable: true),
                    TradeLicenseNo = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    ConfirmationPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employers", x => x.EmployerId);
                });

            migrationBuilder.CreateTable(
                name: "JobSeekerAuthTable",
                columns: table => new
                {
                    JobSeekerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekerAuthTable", x => x.JobSeekerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployerAuthTable");

            migrationBuilder.DropTable(
                name: "Employers");

            migrationBuilder.DropTable(
                name: "JobSeekerAuthTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobSeekers",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "JobSeekerId",
                table: "JobSeekers");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "JobSeekers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobSeekers",
                table: "JobSeekers",
                column: "Id");
        }
    }
}
