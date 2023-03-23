using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoRad.Migrations
{
    public partial class AddConclusaoToContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resultado",
                columns: table => new
                {
                    ResultadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeResultado = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resultado", x => x.ResultadoId);
                });

            migrationBuilder.CreateTable(
                name: "Conclusao",
                columns: table => new
                {
                    ConclusaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResultadoId = table.Column<int>(type: "int", nullable: false),
                    TextoJustificativo = table.Column<string>(type: "varchar(300)", nullable: true),
                    ConsultivoJuridico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DesligamentoSJC = table.Column<bool>(type: "bit", nullable: false),
                    DesligamentoCJC = table.Column<bool>(type: "bit", nullable: false),
                    AdvertenciaVerbal = table.Column<bool>(type: "bit", nullable: false),
                    AdvertenciaEscrita = table.Column<bool>(type: "bit", nullable: false),
                    Suspensao = table.Column<bool>(type: "bit", nullable: false),
                    AfastamentoTerceiro = table.Column<bool>(type: "bit", nullable: false),
                    AdvertencuaTerceiro = table.Column<bool>(type: "bit", nullable: false),
                    NA = table.Column<bool>(type: "bit", nullable: false),
                    OcorrenciaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conclusao", x => x.ConclusaoId);
                    table.ForeignKey(
                        name: "FK_Conclusao_Ocorrencia_OcorrenciaId",
                        column: x => x.OcorrenciaId,
                        principalTable: "Ocorrencia",
                        principalColumn: "OcorrenciaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Conclusao_Resultado_ResultadoId",
                        column: x => x.ResultadoId,
                        principalTable: "Resultado",
                        principalColumn: "ResultadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conclusao_OcorrenciaId",
                table: "Conclusao",
                column: "OcorrenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Conclusao_ResultadoId",
                table: "Conclusao",
                column: "ResultadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conclusao");

            migrationBuilder.DropTable(
                name: "Resultado");
        }
    }
}
