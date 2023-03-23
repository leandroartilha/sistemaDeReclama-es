using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoRad.Migrations
{
    public partial class AddEnvolvidoToContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Envolvido");
        }
    }
}
