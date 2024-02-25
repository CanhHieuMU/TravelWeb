using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class Vote
    {
        [Key]
        public int VoteId { get; set; }
        [Required]
        public bool IsGood { get; set; }
    }
}
