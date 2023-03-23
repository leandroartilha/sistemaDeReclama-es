using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoRad.Migrations
{
    public partial class AddAnexoArquivo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoAnexoArquivo",
                columns: table => new
                {
                    TipoAnexoArquivoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTipoAnexoArquivo = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAnexoArquivo", x => x.TipoAnexoArquivoId);
                });

            migrationBuilder.CreateTable(
                name: "AnexoArquivo",
                columns: table => new
                {
                    AnexoArquivoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAnexo = table.Column<string>(type: "varchar(100)", nullable: true),
                    DataAnexo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Autor = table.Column<string>(type: "varchar(15)", nullable: true),
                    DescricaoAnexo = table.Column<string>(type: "varchar(300)", nullable: true),
                    TipoAnexoId = table.Column<int>(type: "int", nullable: false),
                    TipoAnexoArquivoId = table.Column<int>(type: "int", nullable: true),
                    ContentType = table.Column<string>(type: "varchar(200)", nullable: true),
                    OcorrenciaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnexoArquivo", x => x.AnexoArquivoId);
                    table.ForeignKey(
                        name: "FK_AnexoArquivo_Ocorrencia_OcorrenciaId",
                        column: x => x.OcorrenciaId,
                        principalTable: "Ocorrencia",
                        principalColumn: "OcorrenciaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnexoArquivo_TipoAnexoArquivo_TipoAnexoArquivoId",
                        column: x => x.TipoAnexoArquivoId,
                        principalTable: "TipoAnexoArquivo",
                        principalColumn: "TipoAnexoArquivoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnexoArquivo_OcorrenciaId",
                table: "AnexoArquivo",
                column: "OcorrenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_AnexoArquivo_TipoAnexoArquivoId",
                table: "AnexoArquivo",
                column: "TipoAnexoArquivoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnexoArquivo");

            migrationBuilder.DropTable(
                name: "TipoAnexoArquivo");

            migrationBuilder.CreateTable(
                name: "TipoAnexo",
                columns: table => new
                {
                    TipoAnexoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTipoAnexo = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAnexo", x => x.TipoAnexoId);
                });

        }
    }
}
