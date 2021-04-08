using Microsoft.EntityFrameworkCore.Migrations;

namespace GuitarSystem.Migrations
{
    public partial class SegundoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Situacao",
                table: "Guitarras",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Situacao",
                table: "Guitarras");
        }
    }
}
