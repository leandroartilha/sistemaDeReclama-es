using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoRad.Migrations
{
    public partial class AddTipoAnexoToContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoAnexo",
                columns: table => new
                {
                    TipoAnexoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTipoAnexo = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAnexo", x => x.TipoAnexoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anexo_TipoAnexoId",
                table: "Anexo",
                column: "TipoAnexoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Anexo_TipoAnexo_TipoAnexoId",
                table: "Anexo",
                column: "TipoAnexoId",
                principalTable: "TipoAnexo",
                principalColumn: "TipoAnexoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anexo_TipoAnexo_TipoAnexoId",
                table: "Anexo");

            migrationBuilder.DropTable(
                name: "TipoAnexo");

            migrationBuilder.DropIndex(
                name: "IX_Anexo_TipoAnexoId",
                table: "Anexo");
        }
    }
}
