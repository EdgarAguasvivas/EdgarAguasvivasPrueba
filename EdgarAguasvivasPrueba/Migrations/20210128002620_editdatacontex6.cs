using Microsoft.EntityFrameworkCore.Migrations;

namespace EdgarAguasvivasPrueba.Migrations
{
    public partial class editdatacontex6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_Personas_PersonaId",
                table: "Solicitudes");

            migrationBuilder.AlterColumn<int>(
                name: "PersonaId",
                table: "Solicitudes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_Personas_PersonaId",
                table: "Solicitudes",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_Personas_PersonaId",
                table: "Solicitudes");

            migrationBuilder.AlterColumn<int>(
                name: "PersonaId",
                table: "Solicitudes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_Personas_PersonaId",
                table: "Solicitudes",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
