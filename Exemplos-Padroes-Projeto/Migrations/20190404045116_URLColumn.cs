using Microsoft.EntityFrameworkCore.Migrations;

namespace ExemplosPadroesProjeto.Migrations
{
    public partial class URLColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Moveis",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "URL",
                table: "Moveis");
        }
    }
}
