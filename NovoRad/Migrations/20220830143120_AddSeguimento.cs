using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoRad.Migrations
{
    public partial class AddSeguimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeguimentoId",
                table: "Ocorrencia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Seguimento",
                columns: table => new
                {
                    SeguimentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeSeguimento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguimento", x => x.SeguimentoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ocorrencia_SeguimentoId",
                table: "Ocorrencia",
                column: "SeguimentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ocorrencia_Seguimento_SeguimentoId",
                table: "Ocorrencia",
                column: "SeguimentoId",
                principalTable: "Seguimento",
                principalColumn: "SeguimentoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ocorrencia_Seguimento_SeguimentoId",
                table: "Ocorrencia");

            migrationBuilder.DropTable(
                name: "Seguimento");

            migrationBuilder.DropIndex(
                name: "IX_Ocorrencia_SeguimentoId",
                table: "Ocorrencia");

            migrationBuilder.DropColumn(
                name: "SeguimentoId",
                table: "Ocorrencia");
        }
    }
}
