using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoRad.Migrations
{
    public partial class AddAmbiente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AmbienteId",
                table: "Ocorrencia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Ambiente",
                columns: table => new
                {
                    AmbienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: true),
                    Inativo = table.Column<bool>(type: "bit", nullable: false),
                    Prazo = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ambiente", x => x.AmbienteId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ocorrencia_AmbienteId",
                table: "Ocorrencia",
                column: "AmbienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ocorrencia_Ambiente_AmbienteId",
                table: "Ocorrencia",
                column: "AmbienteId",
                principalTable: "Ambiente",
                principalColumn: "AmbienteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ocorrencia_Ambiente_AmbienteId",
                table: "Ocorrencia");

            migrationBuilder.DropTable(
                name: "Ambiente");

            migrationBuilder.DropIndex(
                name: "IX_Ocorrencia_AmbienteId",
                table: "Ocorrencia");

            migrationBuilder.DropColumn(
                name: "AmbienteId",
                table: "Ocorrencia");
        }
    }
}
