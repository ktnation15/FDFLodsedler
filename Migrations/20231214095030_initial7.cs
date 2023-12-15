using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FDFLodsedler.Migrations
{
    /// <inheritdoc />
    public partial class initial7 : Migration
    {
        /// <inheritdoc />
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
                name: "BørnGruppes",
                columns: table => new
                {
                    Gruppe_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Leder_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BørnGruppes", x => x.Gruppe_Id);
                });

            migrationBuilder.CreateTable(
                name: "Børns",
                columns: table => new
                {
                    Børn_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gruppe_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Børns", x => x.Børn_Id);
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
                name: "Lodsedlers",
                columns: table => new
                {
                    Lod_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AntalUdleveret = table.Column<int>(type: "int", nullable: false),
                    Børn_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lodsedlers", x => x.Lod_Id);
                });

            migrationBuilder.CreateTable(
                name: "Salgs",
                columns: table => new
                {
                    Salg_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AntalSolgt = table.Column<int>(type: "int", nullable: false),
                    AntalReturneret = table.Column<int>(type: "int", nullable: false),
                    Børn_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salgs", x => x.Salg_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bestyrelses");

            migrationBuilder.DropTable(
                name: "Betalings");

            migrationBuilder.DropTable(
                name: "BørnGruppes");

            migrationBuilder.DropTable(
                name: "Børns");

            migrationBuilder.DropTable(
                name: "Leders");

            migrationBuilder.DropTable(
                name: "Lodsedlers");

            migrationBuilder.DropTable(
                name: "Salgs");
        }
    }
}
