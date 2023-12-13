using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FDFLodsedler.Migrations
{
    public partial class id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Gruppe_Id",
                table: "Lodsedlers",
                newName: "Børn_Id");

            migrationBuilder.AddColumn<int>(
                name: "Børn_Id1",
                table: "Lodsedlers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Lodsedlers_Børn_Id1",
                table: "Lodsedlers",
                column: "Børn_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Lodsedlers_Børns_Børn_Id1",
                table: "Lodsedlers",
                column: "Børn_Id1",
                principalTable: "Børns",
                principalColumn: "Børn_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lodsedlers_Børns_Børn_Id1",
                table: "Lodsedlers");

            migrationBuilder.DropIndex(
                name: "IX_Lodsedlers_Børn_Id1",
                table: "Lodsedlers");

            migrationBuilder.DropColumn(
                name: "Børn_Id1",
                table: "Lodsedlers");

            migrationBuilder.RenameColumn(
                name: "Børn_Id",
                table: "Lodsedlers",
                newName: "Gruppe_Id");
        }
    }
}
