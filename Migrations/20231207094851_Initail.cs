using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FDFLodsedler.Migrations
{
    public partial class Initail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bestyrelses",
                columns: table => new
                {
                    Bestyrelse_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bestyrelses", x => x.Bestyrelse_Id);
                });

            migrationBuilder.CreateTable(
                name: "Betalings",
                columns: table => new
                {
                    Betal_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Betalings", x => x.Betal_Id);
                });

            migrationBuilder.CreateTable(
                name: "Leders",
                columns: table => new
                {
                    Leder_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BrugerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leders", x => x.Leder_Id);
                });

            migrationBuilder.CreateTable(
                name: "BørnGruppes",
                columns: table => new
                {
                    Gruppe_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Leder_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BørnGruppes", x => x.Gruppe_Id);
                    table.ForeignKey(
                        name: "FK_BørnGruppes_Leders_Leder_Id",
                        column: x => x.Leder_Id,
                        principalTable: "Leders",
                        principalColumn: "Leder_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Børns",
                columns: table => new
                {
                    Børn_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gruppe_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Børns", x => x.Børn_Id);
                    table.ForeignKey(
                        name: "FK_Børns_BørnGruppes_Gruppe_Id",
                        column: x => x.Gruppe_Id,
                        principalTable: "BørnGruppes",
                        principalColumn: "Gruppe_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lodsedlers",
                columns: table => new
                {
                    Lod_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AntalUdleveret = table.Column<int>(type: "int", nullable: false),
                    Børn_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lodsedlers", x => x.Lod_Id);
                    table.ForeignKey(
                        name: "FK_Lodsedlers_Børns_Børn_Id",
                        column: x => x.Børn_Id,
                        principalTable: "Børns",
                        principalColumn: "Børn_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Salgs",
                columns: table => new
                {
                    Salg_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AntalSolgt = table.Column<int>(type: "int", nullable: false),
                    AntalReturneret = table.Column<int>(type: "int", nullable: false),
                    Børn_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salgs", x => x.Salg_Id);
                    table.ForeignKey(
                        name: "FK_Salgs_Børns_Børn_Id",
                        column: x => x.Børn_Id,
                        principalTable: "Børns",
                        principalColumn: "Børn_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BørnGruppes_Leder_Id",
                table: "BørnGruppes",
                column: "Leder_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Børns_Gruppe_Id",
                table: "Børns",
                column: "Gruppe_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Lodsedlers_Børn_Id",
                table: "Lodsedlers",
                column: "Børn_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Salgs_Børn_Id",
                table: "Salgs",
                column: "Børn_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bestyrelses");

            migrationBuilder.DropTable(
                name: "Betalings");

            migrationBuilder.DropTable(
                name: "Lodsedlers");

            migrationBuilder.DropTable(
                name: "Salgs");

            migrationBuilder.DropTable(
                name: "Børns");

            migrationBuilder.DropTable(
                name: "BørnGruppes");

            migrationBuilder.DropTable(
                name: "Leders");
        }
    }
}
