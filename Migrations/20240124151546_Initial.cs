using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NobelDij.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tipusok",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipusok", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dijak",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ev = table.Column<int>(type: "int", nullable: false),
                    TipusId = table.Column<int>(type: "int", nullable: false),
                    KeresztNev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VezetekNev = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dijak", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dijak_Tipusok_TipusId",
                        column: x => x.TipusId,
                        principalTable: "Tipusok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dijak_TipusId",
                table: "Dijak",
                column: "TipusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dijak");

            migrationBuilder.DropTable(
                name: "Tipusok");
        }
    }
}
