using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoRad.Migrations
{
    public partial class AddStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Ocorrencia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatusId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ocorrencia_StatusId",
                table: "Ocorrencia",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ocorrencia_Status_StatusId",
                table: "Ocorrencia",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ocorrencia_Status_StatusId",
                table: "Ocorrencia");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Ocorrencia_StatusId",
                table: "Ocorrencia");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Ocorrencia");
        }
    }
}
