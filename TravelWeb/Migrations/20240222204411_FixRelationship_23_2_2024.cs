using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelWeb.Migrations
{
    public partial class FixRelationship_23_2_2024 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryTickets_Brands_BrandId",
                table: "CategoryTickets");

            migrationBuilder.DropIndex(
                name: "IX_CategoryTickets_BrandId",
                table: "CategoryTickets");

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "CategoryTickets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTickets_BrandId",
                table: "CategoryTickets",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryTickets_Brands_BrandId",
                table: "CategoryTickets",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "BrandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryTickets_Brands_BrandId",
                table: "CategoryTickets");

            migrationBuilder.DropIndex(
                name: "IX_CategoryTickets_BrandId",
                table: "CategoryTickets");

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "CategoryTickets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTickets_BrandId",
                table: "CategoryTickets",
                column: "BrandId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryTickets_Brands_BrandId",
                table: "CategoryTickets",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
