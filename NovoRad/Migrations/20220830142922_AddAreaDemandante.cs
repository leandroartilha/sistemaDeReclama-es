using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoRad.Migrations
{
    public partial class AddAreaDemandante : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AreaDemandanteId",
                table: "Ocorrencia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AreaDemandante",
                columns: table => new
                {
                    AreaDemandanteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: true),
                    Inativo = table.Column<bool>(type: "bit", nullable: false),
                    Prazo = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaDemandante", x => x.AreaDemandanteId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ocorrencia_AreaDemandanteId",
                table: "Ocorrencia",
                column: "AreaDemandanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ocorrencia_AreaDemandante_AreaDemandanteId",
                table: "Ocorrencia",
                column: "AreaDemandanteId",
                principalTable: "AreaDemandante",
                principalColumn: "AreaDemandanteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ocorrencia_AreaDemandante_AreaDemandanteId",
                table: "Ocorrencia");

            migrationBuilder.DropTable(
                name: "AreaDemandante");

            migrationBuilder.DropIndex(
                name: "IX_Ocorrencia_AreaDemandanteId",
                table: "Ocorrencia");

            migrationBuilder.DropColumn(
                name: "AreaDemandanteId",
                table: "Ocorrencia");
        }
    }
}
