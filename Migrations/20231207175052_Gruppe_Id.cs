using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FDFLodsedler.Migrations
{
    public partial class Gruppe_Id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Børns_BørnGruppes_Gruppe_Id",
                table: "Børns");

            migrationBuilder.DropIndex(
                name: "IX_Børns_Gruppe_Id",
                table: "Børns");

            migrationBuilder.AlterColumn<int>(
                name: "Gruppe_Id",
                table: "Børns",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Gruppe_Id",
                table: "Børns",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Børns_Gruppe_Id",
                table: "Børns",
                column: "Gruppe_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Børns_BørnGruppes_Gruppe_Id",
                table: "Børns",
                column: "Gruppe_Id",
                principalTable: "BørnGruppes",
                principalColumn: "Gruppe_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
