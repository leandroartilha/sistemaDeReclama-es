using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoRad.Migrations
{
    public partial class AddUsuarioToTarefa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId1",
                table: "Tarefa",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tarefa_UsuarioId1",
                table: "Tarefa",
                column: "UsuarioId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefa_Usuario_UsuarioId1",
                table: "Tarefa",
                column: "UsuarioId1",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefa_Usuario_UsuarioId1",
                table: "Tarefa");

            migrationBuilder.DropIndex(
                name: "IX_Tarefa_UsuarioId1",
                table: "Tarefa");

            migrationBuilder.DropColumn(
                name: "UsuarioId1",
                table: "Tarefa");
        }
    }
}
