using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class Homestay
    {
        
        [Key]
        public int HomestayId { get; set; }
        [Required]
        public string CategoryHome { get; set; }
        public string Extention { get; set; }
        public string People { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Repository> Repositories { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<Rate> Rates { get; set; }
    }
}
