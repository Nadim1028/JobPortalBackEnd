using Microsoft.EntityFrameworkCore.Migrations;

namespace JobPortalBackEnd.Migrations
{
    public partial class all : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_JobSeekers",
                table: "JobSeekers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobSeekerAuthTable",
                table: "JobSeekerAuthTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employers",
                table: "Employers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployerAuthTable",
                table: "EmployerAuthTable");

            migrationBuilder.DropColumn(
                name: "JobSeekerId",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "JobSeekerId",
                table: "JobSeekerAuthTable");

            migrationBuilder.DropColumn(
                name: "EmployerId",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "EmployerId",
                table: "EmployerAuthTable");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "JobSeekers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "JobSeekerAuthTable",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Employers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "EmployerAuthTable",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobSeekers",
                table: "JobSeekers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobSeekerAuthTable",
                table: "JobSeekerAuthTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employers",
                table: "Employers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployerAuthTable",
                table: "EmployerAuthTable",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_JobSeekers",
                table: "JobSeekers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobSeekerAuthTable",
                table: "JobSeekerAuthTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employers",
                table: "Employers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployerAuthTable",
                table: "EmployerAuthTable");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "JobSeekerAuthTable");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EmployerAuthTable");

            migrationBuilder.AddColumn<int>(
                name: "JobSeekerId",
                table: "JobSeekers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "JobSeekerId",
                table: "JobSeekerAuthTable",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "EmployerId",
                table: "Employers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "EmployerId",
                table: "EmployerAuthTable",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobSeekers",
                table: "JobSeekers",
                column: "JobSeekerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobSeekerAuthTable",
                table: "JobSeekerAuthTable",
                column: "JobSeekerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employers",
                table: "Employers",
                column: "EmployerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployerAuthTable",
                table: "EmployerAuthTable",
                column: "EmployerId");
        }
    }
}
