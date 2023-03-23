using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoRad.Migrations
{
    public partial class AddUsuarioFuncionalidadeToContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    AreaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeArea = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.AreaId);
                });

            migrationBuilder.CreateTable(
                name: "Funcionalidade",
                columns: table => new
                {
                    FuncionalidadeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFuncionalidade = table.Column<string>(type: "varchar(100)", nullable: true),
                    NomeObjetoFuncionalidade = table.Column<string>(type: "varchar(50)", nullable: true),
                    DescricaoFuncionalidade = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionalidade", x => x.FuncionalidadeId);
                });

            migrationBuilder.CreateTable(
                name: "Regional",
                columns: table => new
                {
                    RegionalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeRegional = table.Column<string>(type: "varchar(20)", nullable: true),
                    NomeTerritorio = table.Column<string>(type: "varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regional", x => x.RegionalId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeUsuario = table.Column<string>(type: "varchar(100)", nullable: true),
                    RegionalId = table.Column<int>(type: "int", nullable: false),
                    UF = table.Column<string>(type: "varchar(2)", nullable: true),
                    Telefone = table.Column<string>(type: "varchar(15)", nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", nullable: true),
                    Cpf = table.Column<string>(type: "varchar(15)", nullable: true),
                    Inativo = table.Column<bool>(type: "bit", nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuario_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "AreaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuario_Regional_RegionalId",
                        column: x => x.RegionalId,
                        principalTable: "Regional",
                        principalColumn: "RegionalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_AreaId",
                table: "Usuario",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_RegionalId",
                table: "Usuario",
                column: "RegionalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionalidade");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "Regional");
        }
    }
}
