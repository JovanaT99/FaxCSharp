using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekat1.Migrations
{
    public partial class ChangeStavkaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stavke",
                columns: table => new
                {
                    StavkaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArtikalId = table.Column<int>(type: "INTEGER", nullable: false),
                    KategorijaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Kolicna = table.Column<float>(type: "REAL", nullable: false),
                    Cena = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stavke", x => x.StavkaId);
                    table.ForeignKey(
                        name: "FK_Stavke_Artikli_ArtikalId",
                        column: x => x.ArtikalId,
                        principalTable: "Artikli",
                        principalColumn: "ArtikalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stavke_Kategorije_KategorijaId",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorije",
                        principalColumn: "KategorijaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stavke_ArtikalId",
                table: "Stavke",
                column: "ArtikalId");

            migrationBuilder.CreateIndex(
                name: "IX_Stavke_KategorijaId",
                table: "Stavke",
                column: "KategorijaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stavke");
        }
    }
}
