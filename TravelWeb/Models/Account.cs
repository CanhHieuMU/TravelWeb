using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
    }
}
