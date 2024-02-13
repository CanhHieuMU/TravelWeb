using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }
        [Required]
        public string BillName { get; set;}
    }
}
