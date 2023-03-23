using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoRad.Migrations
{
    public partial class AddPrioridadeToOcorrencia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrioridadeId",
                table: "Ocorrencia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Prioridade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroPrioridade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prioridade", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ocorrencia_PrioridadeId",
                table: "Ocorrencia",
                column: "PrioridadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ocorrencia_Prioridade_PrioridadeId",
                table: "Ocorrencia",
                column: "PrioridadeId",
                principalTable: "Prioridade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ocorrencia_Prioridade_PrioridadeId",
                table: "Ocorrencia");

            migrationBuilder.DropTable(
                name: "Prioridade");

            migrationBuilder.DropIndex(
                name: "IX_Ocorrencia_PrioridadeId",
                table: "Ocorrencia");

            migrationBuilder.DropColumn(
                name: "PrioridadeId",
                table: "Ocorrencia");
        }
    }
}
