using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Loja.Migrations
{
    public partial class PrimeiraMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(80)", nullable: false),
                    CPF = table.Column<string>(type: "VARCHAR(11)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefone = table.Column<string>(type: "VARCHAR(11)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(80)", nullable: true),
                    Estado = table.Column<string>(type: "VARCHAR(2)", nullable: false),
                    Cidade = table.Column<string>(type: "VARCHAR(80)", nullable: false),
                    CEP = table.Column<string>(type: "VARCHAR(8)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionários",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salario = table.Column<float>(type: "real", nullable: false),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(80)", nullable: false),
                    CPF = table.Column<string>(type: "VARCHAR(11)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefone = table.Column<string>(type: "VARCHAR(11)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(80)", nullable: true),
                    Estado = table.Column<string>(type: "VARCHAR(2)", nullable: false),
                    Cidade = table.Column<string>(type: "VARCHAR(80)", nullable: false),
                    CEP = table.Column<string>(type: "VARCHAR(8)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionários", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Funcionários");
        }
    }
}
