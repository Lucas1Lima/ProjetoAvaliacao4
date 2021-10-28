using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class Yes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entradas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorEntrada = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NomeEntrada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoraEntrada = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entradas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Saidas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorSaida = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NomeSaida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoraSaida = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saidas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Verificar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorEntrada = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorSaida = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verificar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Verificar_Entradas_ID",
                        column: x => x.ID,
                        principalTable: "Entradas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Verificar_Saidas_ID",
                        column: x => x.ID,
                        principalTable: "Saidas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Verificar");

            migrationBuilder.DropTable(
                name: "Entradas");

            migrationBuilder.DropTable(
                name: "Saidas");
        }
    }
}
