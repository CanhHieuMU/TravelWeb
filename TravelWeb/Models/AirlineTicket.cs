using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class AirlineTicket
    {
        [Key] 
        public int TicketId { get; set; }
        [Required]
        public string TicketName { get; set; }
        public DateTime Date { get; set; }
        public virtual Bill Bill { get; set; }
        public User User { get; set; }
    }
}
