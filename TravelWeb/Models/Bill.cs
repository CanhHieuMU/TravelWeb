using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelWeb.Models
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }
        [Required]
        public string BillName { get; set;}
        public virtual AirlineTicket AirlineTicket { get; set; }
        public int TicketId { get; set; }
        public Repository Repository { get; set; }
    }
}
