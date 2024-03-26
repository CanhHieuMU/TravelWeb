using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelWeb.Migrations
{
    public partial class DeleteCateHome_27_2_2024 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryHome",
                table: "Homestays");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryHome",
                table: "Homestays",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
