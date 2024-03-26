using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class CategoryHomestay
    {
        [Key]
        public int CategoryHomeId { get; set; }
        [Required]
        public string NameCate { get; set; }
        public virtual ICollection<Homestay> Homestays { get; set; }
    }
}
