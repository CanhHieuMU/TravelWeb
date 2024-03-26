using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelWeb.Migrations
{
    public partial class AddCateHomestay_27_2_2024 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryHomestays",
                columns: table => new
                {
                    CategoryHomeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryHomestays", x => x.CategoryHomeId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryHomestayHomestay",
                columns: table => new
                {
                    CategoryHomestaysCategoryHomeId = table.Column<int>(type: "int", nullable: false),
                    HomestaysHomestayId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryHomestayHomestay", x => new { x.CategoryHomestaysCategoryHomeId, x.HomestaysHomestayId });
                    table.ForeignKey(
                        name: "FK_CategoryHomestayHomestay_CategoryHomestays_CategoryHomestaysCategoryHomeId",
                        column: x => x.CategoryHomestaysCategoryHomeId,
                        principalTable: "CategoryHomestays",
                        principalColumn: "CategoryHomeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryHomestayHomestay_Homestays_HomestaysHomestayId",
                        column: x => x.HomestaysHomestayId,
                        principalTable: "Homestays",
                        principalColumn: "HomestayId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryHomestayHomestay_HomestaysHomestayId",
                table: "CategoryHomestayHomestay",
                column: "HomestaysHomestayId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryHomestayHomestay");

            migrationBuilder.DropTable(
                name: "CategoryHomestays");
        }
    }
}
