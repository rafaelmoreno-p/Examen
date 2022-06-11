using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Prueba.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    CodCliente = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NombreCompleto = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NombreCorto = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Abreviatura = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    RUC = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    GrupoFacturacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    InactivoDesde = table.Column<DateTime>(type: "datetime", nullable: true),
                    CodigoSAP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.CodCliente);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
