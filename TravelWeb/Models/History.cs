using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class History
    {
        [Key]
        public int HistoryId { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
