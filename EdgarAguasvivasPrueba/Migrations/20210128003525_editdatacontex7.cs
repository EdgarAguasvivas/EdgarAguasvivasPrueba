using Microsoft.EntityFrameworkCore.Migrations;

namespace EdgarAguasvivasPrueba.Migrations
{
    public partial class editdatacontex7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_Estados_EstadoId",
                table: "Solicitudes");

            migrationBuilder.AlterColumn<int>(
                name: "EstadoId",
                table: "Solicitudes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_Estados_EstadoId",
                table: "Solicitudes",
                column: "EstadoId",
                principalTable: "Estados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_Estados_EstadoId",
                table: "Solicitudes");

            migrationBuilder.AlterColumn<int>(
                name: "EstadoId",
                table: "Solicitudes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_Estados_EstadoId",
                table: "Solicitudes",
                column: "EstadoId",
                principalTable: "Estados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
