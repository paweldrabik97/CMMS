using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMMS_Shared.Migrations
{
    /// <inheritdoc />
    public partial class addingItemCycles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemCycles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    Cycles = table.Column<int>(type: "int", nullable: false),
                    WhereUsedId = table.Column<int>(type: "int", nullable: true),
                    MaxCycles = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCycles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemCycles_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemCycles_Equipments_WhereUsedId",
                        column: x => x.WhereUsedId,
                        principalTable: "Equipments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemCycles_EquipmentId",
                table: "ItemCycles",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCycles_WhereUsedId",
                table: "ItemCycles",
                column: "WhereUsedId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemCycles");
        }
    }
}
