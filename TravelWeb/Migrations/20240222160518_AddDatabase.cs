using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelWeb.Migrations
{
    public partial class AddDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryFoods",
                columns: table => new
                {
                    CateFoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCateFood = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryFoods", x => x.CateFoodId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryTakeAways",
                columns: table => new
                {
                    CategoryTakeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryTakeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTakeAways", x => x.CategoryTakeId);
                });

            migrationBuilder.CreateTable(
                name: "Cuisines",
                columns: table => new
                {
                    CuisineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CuisineName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuisines", x => x.CuisineId);
                });

            migrationBuilder.CreateTable(
                name: "Homestays",
                columns: table => new
                {
                    HomestayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryHome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Extention = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    People = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homestays", x => x.HomestayId);
                });

            migrationBuilder.CreateTable(
                name: "TouristAttractions",
                columns: table => new
                {
                    TouristId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TouristName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceTicketTourist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryTourist = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TouristAttractions", x => x.TouristId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryFoodCuisine",
                columns: table => new
                {
                    CategoryFoodsCateFoodId = table.Column<int>(type: "int", nullable: false),
                    CuisinesCuisineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryFoodCuisine", x => new { x.CategoryFoodsCateFoodId, x.CuisinesCuisineId });
                    table.ForeignKey(
                        name: "FK_CategoryFoodCuisine_CategoryFoods_CategoryFoodsCateFoodId",
                        column: x => x.CategoryFoodsCateFoodId,
                        principalTable: "CategoryFoods",
                        principalColumn: "CateFoodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryFoodCuisine_Cuisines_CuisinesCuisineId",
                        column: x => x.CuisinesCuisineId,
                        principalTable: "Cuisines",
                        principalColumn: "CuisineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryTakeAwayCuisine",
                columns: table => new
                {
                    CategoryTakeAwaysCategoryTakeId = table.Column<int>(type: "int", nullable: false),
                    CuisinesCuisineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTakeAwayCuisine", x => new { x.CategoryTakeAwaysCategoryTakeId, x.CuisinesCuisineId });
                    table.ForeignKey(
                        name: "FK_CategoryTakeAwayCuisine_CategoryTakeAways_CategoryTakeAwaysCategoryTakeId",
                        column: x => x.CategoryTakeAwaysCategoryTakeId,
                        principalTable: "CategoryTakeAways",
                        principalColumn: "CategoryTakeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryTakeAwayCuisine_Cuisines_CuisinesCuisineId",
                        column: x => x.CuisinesCuisineId,
                        principalTable: "Cuisines",
                        principalColumn: "CuisineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Histories",
                columns: table => new
                {
                    HistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CuisineId = table.Column<int>(type: "int", nullable: false),
                    TouristId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Histories", x => x.HistoryId);
                    table.ForeignKey(
                        name: "FK_Histories_Cuisines_CuisineId",
                        column: x => x.CuisineId,
                        principalTable: "Cuisines",
                        principalColumn: "CuisineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Histories_TouristAttractions_TouristId",
                        column: x => x.TouristId,
                        principalTable: "TouristAttractions",
                        principalColumn: "TouristId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    PhotoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CuisineId = table.Column<int>(type: "int", nullable: true),
                    HomestayId = table.Column<int>(type: "int", nullable: true),
                    TouristAttractionTouristId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.PhotoId);
                    table.ForeignKey(
                        name: "FK_Photos_Cuisines_CuisineId",
                        column: x => x.CuisineId,
                        principalTable: "Cuisines",
                        principalColumn: "CuisineId");
                    table.ForeignKey(
                        name: "FK_Photos_Homestays_HomestayId",
                        column: x => x.HomestayId,
                        principalTable: "Homestays",
                        principalColumn: "HomestayId");
                    table.ForeignKey(
                        name: "FK_Photos_TouristAttractions_TouristAttractionTouristId",
                        column: x => x.TouristAttractionTouristId,
                        principalTable: "TouristAttractions",
                        principalColumn: "TouristId");
                });

            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    RateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RateStar = table.Column<int>(type: "int", nullable: false),
                    IsRateed = table.Column<bool>(type: "bit", nullable: false),
                    CuisineId = table.Column<int>(type: "int", nullable: true),
                    HomestayId = table.Column<int>(type: "int", nullable: true),
                    TouristAttractionTouristId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates", x => x.RateId);
                    table.ForeignKey(
                        name: "FK_Rates_Cuisines_CuisineId",
                        column: x => x.CuisineId,
                        principalTable: "Cuisines",
                        principalColumn: "CuisineId");
                    table.ForeignKey(
                        name: "FK_Rates_Homestays_HomestayId",
                        column: x => x.HomestayId,
                        principalTable: "Homestays",
                        principalColumn: "HomestayId");
                    table.ForeignKey(
                        name: "FK_Rates_TouristAttractions_TouristAttractionTouristId",
                        column: x => x.TouristAttractionTouristId,
                        principalTable: "TouristAttractions",
                        principalColumn: "TouristId");
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_Accounts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AirlineTickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirlineTickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_AirlineTickets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ForumPosts",
                columns: table => new
                {
                    ForumPostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumPosts", x => x.ForumPostId);
                    table.ForeignKey(
                        name: "FK_ForumPosts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Repositories",
                columns: table => new
                {
                    RepositoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RepositoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repositories", x => x.RepositoryId);
                    table.ForeignKey(
                        name: "FK_Repositories_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirlineTicketTicketId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                    table.ForeignKey(
                        name: "FK_Brands_AirlineTickets_AirlineTicketTicketId",
                        column: x => x.AirlineTicketTicketId,
                        principalTable: "AirlineTickets",
                        principalColumn: "TicketId");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CuisineId = table.Column<int>(type: "int", nullable: true),
                    ForumPostId = table.Column<int>(type: "int", nullable: true),
                    TouristAttractionTouristId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Cuisines_CuisineId",
                        column: x => x.CuisineId,
                        principalTable: "Cuisines",
                        principalColumn: "CuisineId");
                    table.ForeignKey(
                        name: "FK_Comments_ForumPosts_ForumPostId",
                        column: x => x.ForumPostId,
                        principalTable: "ForumPosts",
                        principalColumn: "ForumPostId");
                    table.ForeignKey(
                        name: "FK_Comments_TouristAttractions_TouristAttractionTouristId",
                        column: x => x.TouristAttractionTouristId,
                        principalTable: "TouristAttractions",
                        principalColumn: "TouristId");
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketId = table.Column<int>(type: "int", nullable: false),
                    RepositoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillId);
                    table.ForeignKey(
                        name: "FK_Bills_AirlineTickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "AirlineTickets",
                        principalColumn: "TicketId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_Repositories_RepositoryId",
                        column: x => x.RepositoryId,
                        principalTable: "Repositories",
                        principalColumn: "RepositoryId");
                });

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
                    ForumPostsForumPostId = table.Column<int>(type: "int", nullable: false),
                    RepositoriesRepositoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumPostRepository", x => new { x.ForumPostsForumPostId, x.RepositoriesRepositoryId });
                    table.ForeignKey(
                        name: "FK_ForumPostRepository_ForumPosts_ForumPostsForumPostId",
                        column: x => x.ForumPostsForumPostId,
                        principalTable: "ForumPosts",
                        principalColumn: "ForumPostId",
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

            migrationBuilder.CreateTable(
                name: "CategoryTickets",
                columns: table => new
                {
                    CateTicketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CateTicketName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTickets", x => x.CateTicketId);
                    table.ForeignKey(
                        name: "FK_CategoryTickets_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    VoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsGood = table.Column<bool>(type: "bit", nullable: false),
                    CommentId = table.Column<int>(type: "int", nullable: true),
                    ForumPostId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => x.VoteId);
                    table.ForeignKey(
                        name: "FK_Votes_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "CommentId");
                    table.ForeignKey(
                        name: "FK_Votes_ForumPosts_ForumPostId",
                        column: x => x.ForumPostId,
                        principalTable: "ForumPosts",
                        principalColumn: "ForumPostId");
                    table.ForeignKey(
                        name: "FK_Votes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_UserId",
                table: "Accounts",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AirlineTickets_UserId",
                table: "AirlineTickets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_RepositoryId",
                table: "Bills",
                column: "RepositoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_TicketId",
                table: "Bills",
                column: "TicketId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Brands_AirlineTicketTicketId",
                table: "Brands",
                column: "AirlineTicketTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryFoodCuisine_CuisinesCuisineId",
                table: "CategoryFoodCuisine",
                column: "CuisinesCuisineId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTakeAwayCuisine_CuisinesCuisineId",
                table: "CategoryTakeAwayCuisine",
                column: "CuisinesCuisineId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTickets_BrandId",
                table: "CategoryTickets",
                column: "BrandId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CuisineId",
                table: "Comments",
                column: "CuisineId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ForumPostId",
                table: "Comments",
                column: "ForumPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TouristAttractionTouristId",
                table: "Comments",
                column: "TouristAttractionTouristId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CuisineRepository_RepositoriesRepositoryId",
                table: "CuisineRepository",
                column: "RepositoriesRepositoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumPostRepository_RepositoriesRepositoryId",
                table: "ForumPostRepository",
                column: "RepositoriesRepositoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumPosts_UserId",
                table: "ForumPosts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Histories_CuisineId",
                table: "Histories",
                column: "CuisineId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Histories_TouristId",
                table: "Histories",
                column: "TouristId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HomestayRepository_RepositoriesRepositoryId",
                table: "HomestayRepository",
                column: "RepositoriesRepositoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_CuisineId",
                table: "Photos",
                column: "CuisineId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_HomestayId",
                table: "Photos",
                column: "HomestayId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_TouristAttractionTouristId",
                table: "Photos",
                column: "TouristAttractionTouristId");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_CuisineId",
                table: "Rates",
                column: "CuisineId");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_HomestayId",
                table: "Rates",
                column: "HomestayId");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_TouristAttractionTouristId",
                table: "Rates",
                column: "TouristAttractionTouristId");

            migrationBuilder.CreateIndex(
                name: "IX_Repositories_UserId",
                table: "Repositories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RepositoryTouristAttraction_TouristAttractionsTouristId",
                table: "RepositoryTouristAttraction",
                column: "TouristAttractionsTouristId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_CommentId",
                table: "Votes",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_ForumPostId",
                table: "Votes",
                column: "ForumPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_UserId",
                table: "Votes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "CategoryFoodCuisine");

            migrationBuilder.DropTable(
                name: "CategoryTakeAwayCuisine");

            migrationBuilder.DropTable(
                name: "CategoryTickets");

            migrationBuilder.DropTable(
                name: "CuisineRepository");

            migrationBuilder.DropTable(
                name: "ForumPostRepository");

            migrationBuilder.DropTable(
                name: "Histories");

            migrationBuilder.DropTable(
                name: "HomestayRepository");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Rates");

            migrationBuilder.DropTable(
                name: "RepositoryTouristAttraction");

            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.DropTable(
                name: "CategoryFoods");

            migrationBuilder.DropTable(
                name: "CategoryTakeAways");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Homestays");

            migrationBuilder.DropTable(
                name: "Repositories");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "AirlineTickets");

            migrationBuilder.DropTable(
                name: "Cuisines");

            migrationBuilder.DropTable(
                name: "ForumPosts");

            migrationBuilder.DropTable(
                name: "TouristAttractions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
