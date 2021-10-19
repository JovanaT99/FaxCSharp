using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekat1.Migrations
{
    public partial class AddStavke : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ArtikalID",
                table: "Artikli",
                newName: "ArtikalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ArtikalId",
                table: "Artikli",
                newName: "ArtikalID");
        }
    }
}
