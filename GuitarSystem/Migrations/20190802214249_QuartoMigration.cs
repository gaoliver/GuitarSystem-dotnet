using Microsoft.EntityFrameworkCore.Migrations;

namespace GuitarSystem.Migrations
{
    public partial class QuartoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Captacao",
                table: "Guitarras",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cor",
                table: "Guitarras",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MadeiraBraco",
                table: "Guitarras",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MadeiraCorpo",
                table: "Guitarras",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ponte",
                table: "Guitarras",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Captacao",
                table: "Guitarras");

            migrationBuilder.DropColumn(
                name: "Cor",
                table: "Guitarras");

            migrationBuilder.DropColumn(
                name: "MadeiraBraco",
                table: "Guitarras");

            migrationBuilder.DropColumn(
                name: "MadeiraCorpo",
                table: "Guitarras");

            migrationBuilder.DropColumn(
                name: "Ponte",
                table: "Guitarras");
        }
    }
}
