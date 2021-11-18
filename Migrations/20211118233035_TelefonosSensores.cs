using Microsoft.EntityFrameworkCore.Migrations;

namespace GestorApp.Migrations
{
    public partial class TelefonosSensores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "SensoresTelefonos");
        }
    }
}
