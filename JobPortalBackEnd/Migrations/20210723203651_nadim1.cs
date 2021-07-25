using Microsoft.EntityFrameworkCore.Migrations;

namespace JobPortalBackEnd.Migrations
{
    public partial class nadim1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_Employers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employers");
        }
    }
}
