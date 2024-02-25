using Microsoft.EntityFrameworkCore;
using TravelWeb.Models;

namespace TravelWeb.Data
{
    public class TravelDbContext : DbContext
    {
        public TravelDbContext(DbContextOptions<TravelDbContext> options) : base(options)
        {

        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AirlineTicket> AirlineTickets { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CategoryFood> CategoryFoods { get; set; }
        public DbSet<CategoryTakeAway> CategoryTakeAways { get; set; }
        public DbSet<CategoryTicket> CategoryTickets { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Cuisine> Cuisines { get; set;}
        public DbSet<Rate> Rates { get; set; }
        public DbSet<ForumPost> ForumPosts { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Homestay> Homestays { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Repository> Repositories { get; set; }
        public DbSet<TouristAttraction> TouristAttractions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User and Account relationship one to one
            modelBuilder.Entity<User>()
                .HasOne(a => a.Account)
                .WithOne(u => u.User)
                .HasForeignKey<Account>(u => u.UserId)
                .IsRequired();

            
            // Cuisine and Histories relationship one to one
            modelBuilder.Entity<Cuisine>()
                .HasOne(h => h.History)
                .WithOne(u => u.Cuisine)
                .HasForeignKey<History>(u => u.CuisineId)
                .IsRequired();

            // Tourist and Histories relationship one to one
            modelBuilder.Entity<TouristAttraction>()
                .HasOne(h => h.History)
                .WithOne(t => t.TouristAttraction)
                .HasForeignKey<History>(t => t.TouristId)
                .IsRequired();

            // AirlineTicket and Bill relationship one to one
            modelBuilder.Entity<AirlineTicket>()
                .HasOne(b => b.Bill)
                .WithOne(t => t.AirlineTicket)
                .HasForeignKey<Bill>(t => t.TicketId)
                .IsRequired();

            // Relationship many to many
            base.OnModelCreating(modelBuilder);

        }

    }
}
