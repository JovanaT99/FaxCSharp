using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekat1.Migrations
{
    public partial class AddStavkeVreme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Vreme",
                table: "Stavke",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vreme",
                table: "Stavke");
        }
    }
}
