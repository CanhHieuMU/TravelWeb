using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public virtual Account Account { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<AirlineTicket> AirlineTickets { get; set; }
        public ICollection<ForumPost> ForumPosts { get; set; }
        public ICollection<Repository> Repositories { get; set; }
        public ICollection<Vote> Votes { get; set; }
    }
}
