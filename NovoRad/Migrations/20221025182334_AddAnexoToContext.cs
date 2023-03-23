using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoRad.Migrations
{
    public partial class AddAnexoToContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoAnexo",
                columns: table => new
                {
                    TipoAnexoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTipoAnexoUpload = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAnexo", x => x.TipoAnexoId);
                });

            migrationBuilder.CreateTable(
                name: "Anexo",
                columns: table => new
                {
                    AnexoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAnexoUpload = table.Column<string>(type: "varchar(100)", nullable: true),
                    DataAnexo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Autor = table.Column<string>(type: "varchar(15)", nullable: true),
                    DescricaoAnexo = table.Column<string>(type: "varchar(300)", nullable: true),
                    ContentType = table.Column<string>(type: "varchar(200)", nullable: true),
                    Bytes = table.Column<byte[]>(type: "varbinary(MAX)", nullable: true),
                    TipoAnexoUploadId = table.Column<int>(type: "int", nullable: true),
                    TipoAnexoId = table.Column<int>(type: "int", nullable: true),
                    OcorrenciaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anexo", x => x.AnexoId);
                    table.ForeignKey(
                        name: "FK_Anexo_Ocorrencia_OcorrenciaId",
                        column: x => x.OcorrenciaId,
                        principalTable: "Ocorrencia",
                        principalColumn: "OcorrenciaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Anexo_TipoAnexo_TipoAnexoId",
                        column: x => x.TipoAnexoId,
                        principalTable: "TipoAnexo",
                        principalColumn: "TipoAnexoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anexo_OcorrenciaId",
                table: "Anexo",
                column: "OcorrenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Anexo_TipoAnexoId",
                table: "Anexo",
                column: "TipoAnexoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anexo");

            migrationBuilder.DropTable(
                name: "TipoAnexo");
        }
    }
}
