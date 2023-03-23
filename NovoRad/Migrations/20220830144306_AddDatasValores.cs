using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoRad.Migrations
{
    public partial class AddDatasValores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataConclusao",
                table: "Ocorrencia",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFim",
                table: "Ocorrencia",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInicio",
                table: "Ocorrencia",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "NomeAmbiente",
                table: "Ocorrencia",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OperacaoPolicial",
                table: "Ocorrencia",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "ValorPerda",
                table: "Ocorrencia",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ValorRecuperado",
                table: "Ocorrencia",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataConclusao",
                table: "Ocorrencia");

            migrationBuilder.DropColumn(
                name: "DataFim",
                table: "Ocorrencia");

            migrationBuilder.DropColumn(
                name: "DataInicio",
                table: "Ocorrencia");

            migrationBuilder.DropColumn(
                name: "NomeAmbiente",
                table: "Ocorrencia");

            migrationBuilder.DropColumn(
                name: "OperacaoPolicial",
                table: "Ocorrencia");

            migrationBuilder.DropColumn(
                name: "ValorPerda",
                table: "Ocorrencia");

            migrationBuilder.DropColumn(
                name: "ValorRecuperado",
                table: "Ocorrencia");
        }
    }
}
