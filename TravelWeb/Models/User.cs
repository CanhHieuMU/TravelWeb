using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public virtual Account Account { get; set; }
        public virtual Repository Repository { get; set; }
    }
}
