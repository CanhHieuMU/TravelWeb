using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class Vote
    {
        [Key]
        public int VoteId { get; set; }
        [Required]
        public bool IsGood { get; set; }
        public ForumPost ForumPost { get; set; }
        public User User { get; set; }
        public Comment Comment { get; set; }
    }
}
