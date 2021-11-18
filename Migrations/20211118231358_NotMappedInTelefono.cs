using Microsoft.EntityFrameworkCore.Migrations;

namespace GestorApp.Migrations
{
    public partial class NotMappedInTelefono : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SensoresTelefonos");

            migrationBuilder.AddColumn<int>(
                name: "AppsId",
                table: "Instalaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OperariosId",
                table: "Instalaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TelefonosID",
                table: "Instalaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Instalaciones_AppsId",
                table: "Instalaciones",
                column: "AppsId");

            migrationBuilder.CreateIndex(
                name: "IX_Instalaciones_OperariosId",
                table: "Instalaciones",
                column: "OperariosId");

            migrationBuilder.CreateIndex(
                name: "IX_Instalaciones_TelefonosID",
                table: "Instalaciones",
                column: "TelefonosID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instalaciones_Apps_AppsId",
                table: "Instalaciones",
                column: "AppsId",
                principalTable: "Apps",
                principalColumn: "AppsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instalaciones_Operarios_OperariosId",
                table: "Instalaciones",
                column: "OperariosId",
                principalTable: "Operarios",
                principalColumn: "OperariosId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instalaciones_Telefonos_TelefonosID",
                table: "Instalaciones",
                column: "TelefonosID",
                principalTable: "Telefonos",
                principalColumn: "TelefonosId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instalaciones_Apps_AppsId",
                table: "Instalaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Instalaciones_Operarios_OperariosId",
                table: "Instalaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Instalaciones_Telefonos_TelefonosID",
                table: "Instalaciones");

            migrationBuilder.DropIndex(
                name: "IX_Instalaciones_AppsId",
                table: "Instalaciones");

            migrationBuilder.DropIndex(
                name: "IX_Instalaciones_OperariosId",
                table: "Instalaciones");

            migrationBuilder.DropIndex(
                name: "IX_Instalaciones_TelefonosID",
                table: "Instalaciones");

            migrationBuilder.DropColumn(
                name: "AppsId",
                table: "Instalaciones");

            migrationBuilder.DropColumn(
                name: "OperariosId",
                table: "Instalaciones");

            migrationBuilder.DropColumn(
                name: "TelefonosID",
                table: "Instalaciones");

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
    }
}
