using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual CategoryTicket CategoryTicket { get; set; }
        public AirlineTicket AirlineTicket { get; set; }
    }
}
