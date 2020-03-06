using Microsoft.EntityFrameworkCore.Migrations;

namespace EncurtadorDeLinks.Migrations
{
    public partial class PrimeiroTeste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "URLS",
                columns: table => new
                {
                    _URL = table.Column<string>(nullable: false),
                    Time_URL = table.Column<int>(nullable: false),
                    Short_URL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_URLS", x => x._URL);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "URLS");
        }
    }
}
