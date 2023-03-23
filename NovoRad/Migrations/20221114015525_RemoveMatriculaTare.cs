using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoRad.Migrations
{
    public partial class RemoveMatriculaTare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefa_Usuario_MatriculaUsuarioUsuarioId",
                table: "Tarefa");

            migrationBuilder.DropIndex(
                name: "IX_Tarefa_MatriculaUsuarioUsuarioId",
                table: "Tarefa");

            migrationBuilder.DropColumn(
                name: "MatriculaUsuarioId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "MatriculaUsuarioId",
                table: "Tarefa");

            migrationBuilder.DropColumn(
                name: "MatriculaUsuarioUsuarioId",
                table: "Tarefa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MatriculaUsuarioId",
                table: "Usuario",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatriculaUsuarioId",
                table: "Tarefa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MatriculaUsuarioUsuarioId",
                table: "Tarefa",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tarefa_MatriculaUsuarioUsuarioId",
                table: "Tarefa",
                column: "MatriculaUsuarioUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefa_Usuario_MatriculaUsuarioUsuarioId",
                table: "Tarefa",
                column: "MatriculaUsuarioUsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
