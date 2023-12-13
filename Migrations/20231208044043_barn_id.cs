using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FDFLodsedler.Migrations
{
    public partial class barn_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lodsedlers_Børns_Børn_Id",
                table: "Lodsedlers");

            migrationBuilder.DropForeignKey(
                name: "FK_Salgs_Børns_Børn_Id",
                table: "Salgs");

            migrationBuilder.DropIndex(
                name: "IX_Salgs_Børn_Id",
                table: "Salgs");

            migrationBuilder.DropIndex(
                name: "IX_Lodsedlers_Børn_Id",
                table: "Lodsedlers");

            migrationBuilder.DropColumn(
                name: "Børn_Id",
                table: "Salgs");

            migrationBuilder.DropColumn(
                name: "Børn_Id",
                table: "Lodsedlers");

            migrationBuilder.AddColumn<int>(
                name: "Gruppe_Id",
                table: "Salgs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gruppe_Id",
                table: "Lodsedlers",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gruppe_Id",
                table: "Salgs");

            migrationBuilder.DropColumn(
                name: "Gruppe_Id",
                table: "Lodsedlers");

            migrationBuilder.AddColumn<int>(
                name: "Børn_Id",
                table: "Salgs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Børn_Id",
                table: "Lodsedlers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Salgs_Børn_Id",
                table: "Salgs",
                column: "Børn_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Lodsedlers_Børn_Id",
                table: "Lodsedlers",
                column: "Børn_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lodsedlers_Børns_Børn_Id",
                table: "Lodsedlers",
                column: "Børn_Id",
                principalTable: "Børns",
                principalColumn: "Børn_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Salgs_Børns_Børn_Id",
                table: "Salgs",
                column: "Børn_Id",
                principalTable: "Børns",
                principalColumn: "Børn_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
