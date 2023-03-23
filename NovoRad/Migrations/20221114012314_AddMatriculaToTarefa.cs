using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoRad.Migrations
{
    public partial class AddMatriculaToTarefa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MatriculaUsuarioId",
                table: "Tarefa",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tarefa_MatriculaUsuarioId",
                table: "Tarefa",
                column: "MatriculaUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefa_Usuario_MatriculaUsuarioId",
                table: "Tarefa",
                column: "MatriculaUsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefa_Usuario_MatriculaUsuarioId",
                table: "Tarefa");

            migrationBuilder.DropIndex(
                name: "IX_Tarefa_MatriculaUsuarioId",
                table: "Tarefa");

            migrationBuilder.DropColumn(
                name: "MatriculaUsuarioId",
                table: "Tarefa");
        }
    }
}
