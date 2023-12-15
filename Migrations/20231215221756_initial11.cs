using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FDFLodsedler.Migrations
{
    /// <inheritdoc />
    public partial class initial11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Gruppe_Id",
                table: "Børns",
                newName: "GruppeId");

            migrationBuilder.AlterColumn<int>(
                name: "GruppeId",
                table: "Børns",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Børn_Id",
                table: "Betalings",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Børn_Id",
                table: "Betalings");

            migrationBuilder.RenameColumn(
                name: "GruppeId",
                table: "Børns",
                newName: "Gruppe_Id");

            migrationBuilder.AlterColumn<int>(
                name: "Gruppe_Id",
                table: "Børns",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
