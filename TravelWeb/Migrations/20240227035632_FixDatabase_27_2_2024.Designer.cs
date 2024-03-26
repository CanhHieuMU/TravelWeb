﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelWeb.Data;

#nullable disable

namespace TravelWeb.Migrations
{
    [DbContext(typeof(TravelDbContext))]
    [Migration("20240227035632_FixDatabase_27_2_2024")]
    partial class FixDatabase_27_2_2024
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CategoryFoodCuisine", b =>
                {
                    b.Property<int>("CategoryFoodsCateFoodId")
                        .HasColumnType("int");

                    b.Property<int>("CuisinesCuisineId")
                        .HasColumnType("int");

                    b.HasKey("CategoryFoodsCateFoodId", "CuisinesCuisineId");

                    b.HasIndex("CuisinesCuisineId");

                    b.ToTable("CategoryFoodCuisine");
                });

            modelBuilder.Entity("CategoryHomestayHomestay", b =>
                {
                    b.Property<int>("CategoryHomestaysCategoryHomeId")
                        .HasColumnType("int");

                    b.Property<int>("HomestaysHomestayId")
                        .HasColumnType("int");

                    b.HasKey("CategoryHomestaysCategoryHomeId", "HomestaysHomestayId");

                    b.HasIndex("HomestaysHomestayId");

                    b.ToTable("CategoryHomestayHomestay");
                });

            modelBuilder.Entity("CategoryTakeAwayCuisine", b =>
                {
                    b.Property<int>("CategoryTakeAwaysCategoryTakeId")
                        .HasColumnType("int");

                    b.Property<int>("CuisinesCuisineId")
                        .HasColumnType("int");

                    b.HasKey("CategoryTakeAwaysCategoryTakeId", "CuisinesCuisineId");

                    b.HasIndex("CuisinesCuisineId");

                    b.ToTable("CategoryTakeAwayCuisine");
                });

            modelBuilder.Entity("CuisineRepository", b =>
                {
                    b.Property<int>("CuisinesCuisineId")
                        .HasColumnType("int");

                    b.Property<int>("RepositoriesRepositoryId")
                        .HasColumnType("int");

                    b.HasKey("CuisinesCuisineId", "RepositoriesRepositoryId");

                    b.HasIndex("RepositoriesRepositoryId");

                    b.ToTable("CuisineRepository");
                });

            modelBuilder.Entity("ForumPostRepository", b =>
                {
                    b.Property<int>("ForumPostsForumPostId")
                        .HasColumnType("int");

                    b.Property<int>("RepositoriesRepositoryId")
                        .HasColumnType("int");

                    b.HasKey("ForumPostsForumPostId", "RepositoriesRepositoryId");

                    b.HasIndex("RepositoriesRepositoryId");

                    b.ToTable("ForumPostRepository");
                });

            modelBuilder.Entity("HomestayRepository", b =>
                {
                    b.Property<int>("HomestaysHomestayId")
                        .HasColumnType("int");

                    b.Property<int>("RepositoriesRepositoryId")
                        .HasColumnType("int");

                    b.HasKey("HomestaysHomestayId", "RepositoriesRepositoryId");

                    b.HasIndex("RepositoriesRepositoryId");

                    b.ToTable("HomestayRepository");
                });

            modelBuilder.Entity("RepositoryTouristAttraction", b =>
                {
                    b.Property<int>("RepositoriesRepositoryId")
                        .HasColumnType("int");

                    b.Property<int>("TouristAttractionsTouristId")
                        .HasColumnType("int");

                    b.HasKey("RepositoriesRepositoryId", "TouristAttractionsTouristId");

                    b.HasIndex("TouristAttractionsTouristId");

                    b.ToTable("RepositoryTouristAttraction");
                });

            modelBuilder.Entity("TravelWeb.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("TravelWeb.Models.AirlineTicket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("TicketName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TicketId");

                    b.HasIndex("UserId");

                    b.ToTable("AirlineTickets");
                });

            modelBuilder.Entity("TravelWeb.Models.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillId"), 1L, 1);

                    b.Property<string>("BillName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RepositoryId")
                        .HasColumnType("int");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.HasKey("BillId");

                    b.HasIndex("RepositoryId");

                    b.HasIndex("TicketId")
                        .IsUnique();

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("TravelWeb.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandId"), 1L, 1);

                    b.Property<int?>("AirlineTicketTicketId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId");

                    b.HasIndex("AirlineTicketTicketId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("TravelWeb.Models.CategoryFood", b =>
                {
                    b.Property<int>("CateFoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CateFoodId"), 1L, 1);

                    b.Property<string>("NameCateFood")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CateFoodId");

                    b.ToTable("CategoryFoods");
                });

            modelBuilder.Entity("TravelWeb.Models.CategoryHomestay", b =>
                {
                    b.Property<int>("CategoryHomeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryHomeId"), 1L, 1);

                    b.Property<string>("NameCate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryHomeId");

                    b.ToTable("CategoryHomestays");
                });

            modelBuilder.Entity("TravelWeb.Models.CategoryTakeAway", b =>
                {
                    b.Property<int>("CategoryTakeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryTakeId"), 1L, 1);

                    b.Property<string>("CategoryTakeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryTakeId");

                    b.ToTable("CategoryTakeAways");
                });

            modelBuilder.Entity("TravelWeb.Models.CategoryTicket", b =>
                {
                    b.Property<int>("CateTicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CateTicketId"), 1L, 1);

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("CateTicketName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CateTicketId");

                    b.HasIndex("BrandId");

                    b.ToTable("CategoryTickets");
                });

            modelBuilder.Entity("TravelWeb.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CuisineId")
                        .HasColumnType("int");

                    b.Property<int?>("ForumPostId")
                        .HasColumnType("int");

                    b.Property<int?>("TouristAttractionTouristId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("CuisineId");

                    b.HasIndex("ForumPostId");

                    b.HasIndex("TouristAttractionTouristId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("TravelWeb.Models.Cuisine", b =>
                {
                    b.Property<int>("CuisineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CuisineId"), 1L, 1);

                    b.Property<string>("CuisineName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CuisineId");

                    b.ToTable("Cuisines");
                });

            modelBuilder.Entity("TravelWeb.Models.ForumPost", b =>
                {
                    b.Property<int>("ForumPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ForumPostId"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ForumPostId");

                    b.HasIndex("UserId");

                    b.ToTable("ForumPosts");
                });

            modelBuilder.Entity("TravelWeb.Models.History", b =>
                {
                    b.Property<int>("HistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HistoryId"), 1L, 1);

                    b.Property<int>("CuisineId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TouristId")
                        .HasColumnType("int");

                    b.HasKey("HistoryId");

                    b.HasIndex("CuisineId")
                        .IsUnique();

                    b.HasIndex("TouristId")
                        .IsUnique();

                    b.ToTable("Histories");
                });

            modelBuilder.Entity("TravelWeb.Models.Homestay", b =>
                {
                    b.Property<int>("HomestayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HomestayId"), 1L, 1);

                    b.Property<string>("Extention")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameHome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("People")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HomestayId");

                    b.ToTable("Homestays");
                });

            modelBuilder.Entity("TravelWeb.Models.Photo", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhotoId"), 1L, 1);

                    b.Property<int?>("CuisineId")
                        .HasColumnType("int");

                    b.Property<int?>("HomestayId")
                        .HasColumnType("int");

                    b.Property<string>("NamePhoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TouristAttractionTouristId")
                        .HasColumnType("int");

                    b.HasKey("PhotoId");

                    b.HasIndex("CuisineId");

                    b.HasIndex("HomestayId");

                    b.HasIndex("TouristAttractionTouristId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("TravelWeb.Models.Rate", b =>
                {
                    b.Property<int>("RateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RateId"), 1L, 1);

                    b.Property<int?>("CuisineId")
                        .HasColumnType("int");

                    b.Property<int?>("HomestayId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsRateed")
                        .HasColumnType("bit");

                    b.Property<int>("RateStar")
                        .HasColumnType("int");

                    b.Property<int?>("TouristAttractionTouristId")
                        .HasColumnType("int");

                    b.HasKey("RateId");

                    b.HasIndex("CuisineId");

                    b.HasIndex("HomestayId");

                    b.HasIndex("TouristAttractionTouristId");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("TravelWeb.Models.Repository", b =>
                {
                    b.Property<int>("RepositoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RepositoryId"), 1L, 1);

                    b.Property<string>("RepositoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RepositoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Repositories");
                });

            modelBuilder.Entity("TravelWeb.Models.TouristAttraction", b =>
                {
                    b.Property<int>("TouristId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TouristId"), 1L, 1);

                    b.Property<string>("CategoryTourist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PriceTicketTourist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TouristName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TouristId");

                    b.ToTable("TouristAttractions");
                });

            modelBuilder.Entity("TravelWeb.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TravelWeb.Models.Vote", b =>
                {
                    b.Property<int>("VoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VoteId"), 1L, 1);

                    b.Property<int?>("CommentId")
                        .HasColumnType("int");

                    b.Property<int?>("ForumPostId")
                        .HasColumnType("int");

                    b.Property<bool>("IsGood")
                        .HasColumnType("bit");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("VoteId");

                    b.HasIndex("CommentId");

                    b.HasIndex("ForumPostId");

                    b.HasIndex("UserId");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("CategoryFoodCuisine", b =>
                {
                    b.HasOne("TravelWeb.Models.CategoryFood", null)
                        .WithMany()
                        .HasForeignKey("CategoryFoodsCateFoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelWeb.Models.Cuisine", null)
                        .WithMany()
                        .HasForeignKey("CuisinesCuisineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CategoryHomestayHomestay", b =>
                {
                    b.HasOne("TravelWeb.Models.CategoryHomestay", null)
                        .WithMany()
                        .HasForeignKey("CategoryHomestaysCategoryHomeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelWeb.Models.Homestay", null)
                        .WithMany()
                        .HasForeignKey("HomestaysHomestayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CategoryTakeAwayCuisine", b =>
                {
                    b.HasOne("TravelWeb.Models.CategoryTakeAway", null)
                        .WithMany()
                        .HasForeignKey("CategoryTakeAwaysCategoryTakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelWeb.Models.Cuisine", null)
                        .WithMany()
                        .HasForeignKey("CuisinesCuisineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CuisineRepository", b =>
                {
                    b.HasOne("TravelWeb.Models.Cuisine", null)
                        .WithMany()
                        .HasForeignKey("CuisinesCuisineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelWeb.Models.Repository", null)
                        .WithMany()
                        .HasForeignKey("RepositoriesRepositoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ForumPostRepository", b =>
                {
                    b.HasOne("TravelWeb.Models.ForumPost", null)
                        .WithMany()
                        .HasForeignKey("ForumPostsForumPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelWeb.Models.Repository", null)
                        .WithMany()
                        .HasForeignKey("RepositoriesRepositoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HomestayRepository", b =>
                {
                    b.HasOne("TravelWeb.Models.Homestay", null)
                        .WithMany()
                        .HasForeignKey("HomestaysHomestayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelWeb.Models.Repository", null)
                        .WithMany()
                        .HasForeignKey("RepositoriesRepositoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RepositoryTouristAttraction", b =>
                {
                    b.HasOne("TravelWeb.Models.Repository", null)
                        .WithMany()
                        .HasForeignKey("RepositoriesRepositoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelWeb.Models.TouristAttraction", null)
                        .WithMany()
                        .HasForeignKey("TouristAttractionsTouristId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TravelWeb.Models.Account", b =>
                {
                    b.HasOne("TravelWeb.Models.User", "User")
                        .WithOne("Account")
                        .HasForeignKey("TravelWeb.Models.Account", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TravelWeb.Models.AirlineTicket", b =>
                {
                    b.HasOne("TravelWeb.Models.User", null)
                        .WithMany("AirlineTickets")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("TravelWeb.Models.Bill", b =>
                {
                    b.HasOne("TravelWeb.Models.Repository", null)
                        .WithMany("Bills")
                        .HasForeignKey("RepositoryId");

                    b.HasOne("TravelWeb.Models.AirlineTicket", "AirlineTicket")
                        .WithOne("Bill")
                        .HasForeignKey("TravelWeb.Models.Bill", "TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AirlineTicket");
                });

            modelBuilder.Entity("TravelWeb.Models.Brand", b =>
                {
                    b.HasOne("TravelWeb.Models.AirlineTicket", null)
                        .WithMany("Brands")
                        .HasForeignKey("AirlineTicketTicketId");
                });

            modelBuilder.Entity("TravelWeb.Models.CategoryTicket", b =>
                {
                    b.HasOne("TravelWeb.Models.Brand", null)
                        .WithMany("CategoryTickets")
                        .HasForeignKey("BrandId");
                });

            modelBuilder.Entity("TravelWeb.Models.Comment", b =>
                {
                    b.HasOne("TravelWeb.Models.Cuisine", null)
                        .WithMany("Comments")
                        .HasForeignKey("CuisineId");

                    b.HasOne("TravelWeb.Models.ForumPost", null)
                        .WithMany("Comments")
                        .HasForeignKey("ForumPostId");

                    b.HasOne("TravelWeb.Models.TouristAttraction", null)
                        .WithMany("Comments")
                        .HasForeignKey("TouristAttractionTouristId");

                    b.HasOne("TravelWeb.Models.User", null)
                        .WithMany("Comments")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("TravelWeb.Models.ForumPost", b =>
                {
                    b.HasOne("TravelWeb.Models.User", null)
                        .WithMany("ForumPosts")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("TravelWeb.Models.History", b =>
                {
                    b.HasOne("TravelWeb.Models.Cuisine", "Cuisine")
                        .WithOne("History")
                        .HasForeignKey("TravelWeb.Models.History", "CuisineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelWeb.Models.TouristAttraction", "TouristAttraction")
                        .WithOne("History")
                        .HasForeignKey("TravelWeb.Models.History", "TouristId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cuisine");

                    b.Navigation("TouristAttraction");
                });

            modelBuilder.Entity("TravelWeb.Models.Photo", b =>
                {
                    b.HasOne("TravelWeb.Models.Cuisine", null)
                        .WithMany("Photos")
                        .HasForeignKey("CuisineId");

                    b.HasOne("TravelWeb.Models.Homestay", null)
                        .WithMany("Photos")
                        .HasForeignKey("HomestayId");

                    b.HasOne("TravelWeb.Models.TouristAttraction", null)
                        .WithMany("Photos")
                        .HasForeignKey("TouristAttractionTouristId");
                });

            modelBuilder.Entity("TravelWeb.Models.Rate", b =>
                {
                    b.HasOne("TravelWeb.Models.Cuisine", null)
                        .WithMany("Rates")
                        .HasForeignKey("CuisineId");

                    b.HasOne("TravelWeb.Models.Homestay", null)
                        .WithMany("Rates")
                        .HasForeignKey("HomestayId");

                    b.HasOne("TravelWeb.Models.TouristAttraction", null)
                        .WithMany("Rates")
                        .HasForeignKey("TouristAttractionTouristId");
                });

            modelBuilder.Entity("TravelWeb.Models.Repository", b =>
                {
                    b.HasOne("TravelWeb.Models.User", null)
                        .WithMany("Repositories")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("TravelWeb.Models.Vote", b =>
                {
                    b.HasOne("TravelWeb.Models.Comment", null)
                        .WithMany("Votes")
                        .HasForeignKey("CommentId");

                    b.HasOne("TravelWeb.Models.ForumPost", null)
                        .WithMany("Votes")
                        .HasForeignKey("ForumPostId");

                    b.HasOne("TravelWeb.Models.User", null)
                        .WithMany("Votes")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("TravelWeb.Models.AirlineTicket", b =>
                {
                    b.Navigation("Bill")
                        .IsRequired();

                    b.Navigation("Brands");
                });

            modelBuilder.Entity("TravelWeb.Models.Brand", b =>
                {
                    b.Navigation("CategoryTickets");
                });

            modelBuilder.Entity("TravelWeb.Models.Comment", b =>
                {
                    b.Navigation("Votes");
                });

            modelBuilder.Entity("TravelWeb.Models.Cuisine", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("History")
                        .IsRequired();

                    b.Navigation("Photos");

                    b.Navigation("Rates");
                });

            modelBuilder.Entity("TravelWeb.Models.ForumPost", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Votes");
                });

            modelBuilder.Entity("TravelWeb.Models.Homestay", b =>
                {
                    b.Navigation("Photos");

                    b.Navigation("Rates");
                });

            modelBuilder.Entity("TravelWeb.Models.Repository", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("TravelWeb.Models.TouristAttraction", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("History")
                        .IsRequired();

                    b.Navigation("Photos");

                    b.Navigation("Rates");
                });

            modelBuilder.Entity("TravelWeb.Models.User", b =>
                {
                    b.Navigation("Account")
                        .IsRequired();

                    b.Navigation("AirlineTickets");

                    b.Navigation("Comments");

                    b.Navigation("ForumPosts");

                    b.Navigation("Repositories");

                    b.Navigation("Votes");
                });
#pragma warning restore 612, 618
        }
    }
}
