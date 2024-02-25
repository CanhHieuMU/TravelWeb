using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class CategoryTicket
    {
        [Key]
        public int CateTicketId { get; set; }
        [Required]
        public string CateTicketName { get; set;}
        public string Price { get; set; }
    }
}
