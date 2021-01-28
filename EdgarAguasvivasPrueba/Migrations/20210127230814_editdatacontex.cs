using Microsoft.EntityFrameworkCore.Migrations;

namespace EdgarAguasvivasPrueba.Migrations
{
    public partial class editdatacontex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_Personas_PersonasId",
                table: "Solicitudes");

            migrationBuilder.RenameColumn(
                name: "PersonasId",
                table: "Solicitudes",
                newName: "PersonaId1");

            migrationBuilder.RenameIndex(
                name: "IX_Solicitudes_PersonasId",
                table: "Solicitudes",
                newName: "IX_Solicitudes_PersonaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_Personas_PersonaId1",
                table: "Solicitudes",
                column: "PersonaId1",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_Personas_PersonaId1",
                table: "Solicitudes");

            migrationBuilder.RenameColumn(
                name: "PersonaId1",
                table: "Solicitudes",
                newName: "PersonasId");

            migrationBuilder.RenameIndex(
                name: "IX_Solicitudes_PersonaId1",
                table: "Solicitudes",
                newName: "IX_Solicitudes_PersonasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_Personas_PersonasId",
                table: "Solicitudes",
                column: "PersonasId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
