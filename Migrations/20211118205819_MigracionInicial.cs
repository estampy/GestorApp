using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace GestorApp.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apps",
                columns: table => new
                {
                    AppsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apps", x => x.AppsId);
                });

            migrationBuilder.CreateTable(
                name: "Instalaciones",
                columns: table => new
                {
                    InstalacionesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Exitosa = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instalaciones", x => x.InstalacionesId);
                });

            migrationBuilder.CreateTable(
                name: "Operarios",
                columns: table => new
                {
                    OperariosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "text", nullable: true),
                    Apellido = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operarios", x => x.OperariosId);
                });

            migrationBuilder.CreateTable(
                name: "Sensores",
                columns: table => new
                {
                    SensoresId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensores", x => x.SensoresId);
                });

            migrationBuilder.CreateTable(
                name: "Telefonos",
                columns: table => new
                {
                    TelefonosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(type: "text", nullable: true),
                    Modelo = table.Column<string>(type: "text", nullable: true),
                    Precio = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefonos", x => x.TelefonosId);
                });

            migrationBuilder.CreateTable(
                name: "SensoresTelefonos",
                columns: table => new
                {
                    SensoresId = table.Column<int>(type: "int", nullable: false),
                    TelefonosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SensoresTelefonos", x => new { x.SensoresId, x.TelefonosId });
                    table.ForeignKey(
                        name: "FK_SensoresTelefonos_Sensores_SensoresId",
                        column: x => x.SensoresId,
                        principalTable: "Sensores",
                        principalColumn: "SensoresId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SensoresTelefonos_Telefonos_TelefonosId",
                        column: x => x.TelefonosId,
                        principalTable: "Telefonos",
                        principalColumn: "TelefonosId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SensoresTelefonos_TelefonosId",
                table: "SensoresTelefonos",
                column: "TelefonosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apps");

            migrationBuilder.DropTable(
                name: "Instalaciones");

            migrationBuilder.DropTable(
                name: "Operarios");

            migrationBuilder.DropTable(
                name: "SensoresTelefonos");

            migrationBuilder.DropTable(
                name: "Sensores");

            migrationBuilder.DropTable(
                name: "Telefonos");
        }
    }
}
