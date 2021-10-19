using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekat1.Migrations
{
    public partial class AddRacun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RacunId",
                table: "Stavke",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Racun",
                columns: table => new
                {
                    RacunId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racun", x => x.RacunId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stavke_RacunId",
                table: "Stavke",
                column: "RacunId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stavke_Racun_RacunId",
                table: "Stavke",
                column: "RacunId",
                principalTable: "Racun",
                principalColumn: "RacunId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stavke_Racun_RacunId",
                table: "Stavke");

            migrationBuilder.DropTable(
                name: "Racun");

            migrationBuilder.DropIndex(
                name: "IX_Stavke_RacunId",
                table: "Stavke");

            migrationBuilder.DropColumn(
                name: "RacunId",
                table: "Stavke");
        }
    }
}
