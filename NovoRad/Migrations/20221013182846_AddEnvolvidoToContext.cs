using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoRad.Migrations
{
    public partial class AddEnvolvidoToContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcaoTomada",
                columns: table => new
                {
                    AcaoTomadaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAcaoTomada = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcaoTomada", x => x.AcaoTomadaId);
                });

            migrationBuilder.CreateTable(
                name: "MedidaDisciplinar",
                columns: table => new
                {
                    MedidaDisciplinarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeMedidaDisciplinar = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedidaDisciplinar", x => x.MedidaDisciplinarId);
                });

            migrationBuilder.CreateTable(
                name: "TipoEnvolvimento",
                columns: table => new
                {
                    TipoEnvolvimentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTipoEnvolvimento = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEnvolvimento", x => x.TipoEnvolvimentoId);
                });

            migrationBuilder.CreateTable(
                name: "Envolvido",
                columns: table => new
                {
                    EnvolvidoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoEnvolvimentoId = table.Column<int>(type: "int", nullable: true),
                    CPF_CNPJ = table.Column<string>(type: "varchar(25)", nullable: true),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: true),
                    RG = table.Column<string>(type: "varchar(25)", nullable: true),
                    Emissor = table.Column<string>(type: "varchar(20)", nullable: true),
                    UF = table.Column<string>(type: "varchar(2)", nullable: true),
                    PPE = table.Column<bool>(type: "bit", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NomeMae = table.Column<string>(type: "varchar(200)", nullable: true),
                    NomePai = table.Column<string>(type: "varchar(200)", nullable: true),
                    Perfil = table.Column<string>(type: "varchar(200)", nullable: true),
                    NumeroSAP = table.Column<string>(type: "varchar(15)", nullable: true),
                    Login = table.Column<string>(type: "varchar(15)", nullable: true),
                    AcaoTomadaId = table.Column<int>(type: "int", nullable: true),
                    MedidaDisciplinarId = table.Column<int>(type: "int", nullable: true),
                    EmpresaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Envolvido", x => x.EnvolvidoId);
                    table.ForeignKey(
                        name: "FK_Envolvido_AcaoTomada_AcaoTomadaId",
                        column: x => x.AcaoTomadaId,
                        principalTable: "AcaoTomada",
                        principalColumn: "AcaoTomadaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Envolvido_MedidaDisciplinar_MedidaDisciplinarId",
                        column: x => x.MedidaDisciplinarId,
                        principalTable: "MedidaDisciplinar",
                        principalColumn: "MedidaDisciplinarId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Envolvido_TipoEnvolvimento_TipoEnvolvimentoId",
                        column: x => x.TipoEnvolvimentoId,
                        principalTable: "TipoEnvolvimento",
                        principalColumn: "TipoEnvolvimentoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Envolvido_AcaoTomadaId",
                table: "Envolvido",
                column: "AcaoTomadaId");

            migrationBuilder.CreateIndex(
                name: "IX_Envolvido_MedidaDisciplinarId",
                table: "Envolvido",
                column: "MedidaDisciplinarId");

            migrationBuilder.CreateIndex(
                name: "IX_Envolvido_TipoEnvolvimentoId",
                table: "Envolvido",
                column: "TipoEnvolvimentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Envolvido");

            migrationBuilder.DropTable(
                name: "AcaoTomada");

            migrationBuilder.DropTable(
                name: "MedidaDisciplinar");

            migrationBuilder.DropTable(
                name: "TipoEnvolvimento");
        }
    }
}
