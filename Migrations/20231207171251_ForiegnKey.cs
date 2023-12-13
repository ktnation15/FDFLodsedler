using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FDFLodsedler.Migrations
{
    public partial class ForiegnKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BørnGruppes_Leders_Leder_Id",
                table: "BørnGruppes");

            migrationBuilder.DropIndex(
                name: "IX_BørnGruppes_Leder_Id",
                table: "BørnGruppes");

            migrationBuilder.AlterColumn<int>(
                name: "Leder_Id",
                table: "BørnGruppes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Leder_Id",
                table: "BørnGruppes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BørnGruppes_Leder_Id",
                table: "BørnGruppes",
                column: "Leder_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BørnGruppes_Leders_Leder_Id",
                table: "BørnGruppes",
                column: "Leder_Id",
                principalTable: "Leders",
                principalColumn: "Leder_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
