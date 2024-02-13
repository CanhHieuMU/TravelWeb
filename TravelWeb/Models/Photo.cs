using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }
        [Required]
        public string NamePhoto { get; set; }
        public string Path { get; set; }
    }
}
