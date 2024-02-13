using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class Repository
    {
        [Key] 
        public int RepositoryId { get; set; }
        [Required]
        public string RepositoryName { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
    }
}
