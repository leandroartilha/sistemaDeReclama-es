using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoRad.Migrations
{
    public partial class AddEnvolvidoToOcorrencia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OcorrenciaId",
                table: "Envolvido",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Envolvido_OcorrenciaId",
                table: "Envolvido",
                column: "OcorrenciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Envolvido_Ocorrencia_OcorrenciaId",
                table: "Envolvido",
                column: "OcorrenciaId",
                principalTable: "Ocorrencia",
                principalColumn: "OcorrenciaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Envolvido_Ocorrencia_OcorrenciaId",
                table: "Envolvido");

            migrationBuilder.DropIndex(
                name: "IX_Envolvido_OcorrenciaId",
                table: "Envolvido");

            migrationBuilder.DropColumn(
                name: "OcorrenciaId",
                table: "Envolvido");
        }
    }
}
