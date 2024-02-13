using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class Rate
    {
        [Key]
        public int RateId { get; set; }
        [Required]
        public int RateStar { get; set; }
        public bool IsRateed { get; set; }
    }
}
