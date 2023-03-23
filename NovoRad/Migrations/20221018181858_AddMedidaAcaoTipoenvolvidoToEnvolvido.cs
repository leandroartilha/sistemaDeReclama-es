using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoRad.Migrations
{
    public partial class AddMedidaAcaoTipoenvolvidoToEnvolvido : Migration
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

            migrationBuilder.AddForeignKey(
                name: "FK_Envolvido_AcaoTomada_AcaoTomadaId",
                table: "Envolvido",
                column: "AcaoTomadaId",
                principalTable: "AcaoTomada",
                principalColumn: "AcaoTomadaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Envolvido_MedidaDisciplinar_MedidaDisciplinarId",
                table: "Envolvido",
                column: "MedidaDisciplinarId",
                principalTable: "MedidaDisciplinar",
                principalColumn: "MedidaDisciplinarId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Envolvido_TipoEnvolvimento_TipoEnvolvimentoId",
                table: "Envolvido",
                column: "TipoEnvolvimentoId",
                principalTable: "TipoEnvolvimento",
                principalColumn: "TipoEnvolvimentoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Envolvido_AcaoTomada_AcaoTomadaId",
                table: "Envolvido");

            migrationBuilder.DropForeignKey(
                name: "FK_Envolvido_MedidaDisciplinar_MedidaDisciplinarId",
                table: "Envolvido");

            migrationBuilder.DropForeignKey(
                name: "FK_Envolvido_TipoEnvolvimento_TipoEnvolvimentoId",
                table: "Envolvido");

            migrationBuilder.DropTable(
                name: "AcaoTomada");

            migrationBuilder.DropTable(
                name: "MedidaDisciplinar");

            migrationBuilder.DropTable(
                name: "TipoEnvolvimento");

            migrationBuilder.DropIndex(
                name: "IX_Envolvido_AcaoTomadaId",
                table: "Envolvido");

            migrationBuilder.DropIndex(
                name: "IX_Envolvido_MedidaDisciplinarId",
                table: "Envolvido");

            migrationBuilder.DropIndex(
                name: "IX_Envolvido_TipoEnvolvimentoId",
                table: "Envolvido");
        }
    }
}
