using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelWeb.Migrations
{
    public partial class AddRelationship_Manytomany_19_2_2024 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CuisineRepository",
                columns: table => new
                {
                    CuisinesCuisineId = table.Column<int>(type: "int", nullable: false),
                    RepositoriesRepositoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuisineRepository", x => new { x.CuisinesCuisineId, x.RepositoriesRepositoryId });
                    table.ForeignKey(
                        name: "FK_CuisineRepository_Cuisines_CuisinesCuisineId",
                        column: x => x.CuisinesCuisineId,
                        principalTable: "Cuisines",
                        principalColumn: "CuisineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CuisineRepository_Repositories_RepositoriesRepositoryId",
                        column: x => x.RepositoriesRepositoryId,
                        principalTable: "Repositories",
                        principalColumn: "RepositoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ForumPostRepository",
                columns: table => new
                {
                    ForumPostsPostId = table.Column<int>(type: "int", nullable: false),
                    RepositoriesRepositoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumPostRepository", x => new { x.ForumPostsPostId, x.RepositoriesRepositoryId });
                    table.ForeignKey(
                        name: "FK_ForumPostRepository_ForumPosts_ForumPostsPostId",
                        column: x => x.ForumPostsPostId,
                        principalTable: "ForumPosts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumPostRepository_Repositories_RepositoriesRepositoryId",
                        column: x => x.RepositoriesRepositoryId,
                        principalTable: "Repositories",
                        principalColumn: "RepositoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomestayRepository",
                columns: table => new
                {
                    HomestaysHomestayId = table.Column<int>(type: "int", nullable: false),
                    RepositoriesRepositoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomestayRepository", x => new { x.HomestaysHomestayId, x.RepositoriesRepositoryId });
                    table.ForeignKey(
                        name: "FK_HomestayRepository_Homestays_HomestaysHomestayId",
                        column: x => x.HomestaysHomestayId,
                        principalTable: "Homestays",
                        principalColumn: "HomestayId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HomestayRepository_Repositories_RepositoriesRepositoryId",
                        column: x => x.RepositoriesRepositoryId,
                        principalTable: "Repositories",
                        principalColumn: "RepositoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RepositoryTouristAttraction",
                columns: table => new
                {
                    RepositoriesRepositoryId = table.Column<int>(type: "int", nullable: false),
                    TouristAttractionsTouristId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepositoryTouristAttraction", x => new { x.RepositoriesRepositoryId, x.TouristAttractionsTouristId });
                    table.ForeignKey(
                        name: "FK_RepositoryTouristAttraction_Repositories_RepositoriesRepositoryId",
                        column: x => x.RepositoriesRepositoryId,
                        principalTable: "Repositories",
                        principalColumn: "RepositoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RepositoryTouristAttraction_TouristAttractions_TouristAttractionsTouristId",
                        column: x => x.TouristAttractionsTouristId,
                        principalTable: "TouristAttractions",
                        principalColumn: "TouristId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CuisineRepository_RepositoriesRepositoryId",
                table: "CuisineRepository",
                column: "RepositoriesRepositoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumPostRepository_RepositoriesRepositoryId",
                table: "ForumPostRepository",
                column: "RepositoriesRepositoryId");

            migrationBuilder.CreateIndex(
                name: "IX_HomestayRepository_RepositoriesRepositoryId",
                table: "HomestayRepository",
                column: "RepositoriesRepositoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RepositoryTouristAttraction_TouristAttractionsTouristId",
                table: "RepositoryTouristAttraction",
                column: "TouristAttractionsTouristId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CuisineRepository");

            migrationBuilder.DropTable(
                name: "ForumPostRepository");

            migrationBuilder.DropTable(
                name: "HomestayRepository");

            migrationBuilder.DropTable(
                name: "RepositoryTouristAttraction");
        }
    }
}
