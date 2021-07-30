using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobPortalBackEnd.Migrations
{
    public partial class JobInfoJobSeekerInfoClassNotUsed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "JobSeekerAuthTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "JobSeekerAuthTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "JobSeekerAuthTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "JobSeekerAuthTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobileNum",
                table: "JobSeekerAuthTable",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "publishedDate",
                table: "Jobs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CompanyAddress",
                table: "EmployerAuthTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyContactNo",
                table: "EmployerAuthTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyEmail",
                table: "EmployerAuthTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "EmployerAuthTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IndustryType",
                table: "EmployerAuthTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TradeLicenseNo",
                table: "EmployerAuthTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YearOfEstablishment",
                table: "EmployerAuthTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "JobSeekerAuthTable");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "JobSeekerAuthTable");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "JobSeekerAuthTable");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "JobSeekerAuthTable");

            migrationBuilder.DropColumn(
                name: "MobileNum",
                table: "JobSeekerAuthTable");

            migrationBuilder.DropColumn(
                name: "publishedDate",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "CompanyAddress",
                table: "EmployerAuthTable");

            migrationBuilder.DropColumn(
                name: "CompanyContactNo",
                table: "EmployerAuthTable");

            migrationBuilder.DropColumn(
                name: "CompanyEmail",
                table: "EmployerAuthTable");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "EmployerAuthTable");

            migrationBuilder.DropColumn(
                name: "IndustryType",
                table: "EmployerAuthTable");

            migrationBuilder.DropColumn(
                name: "TradeLicenseNo",
                table: "EmployerAuthTable");

            migrationBuilder.DropColumn(
                name: "YearOfEstablishment",
                table: "EmployerAuthTable");
        }
    }
}
