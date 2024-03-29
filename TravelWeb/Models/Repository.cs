﻿    using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class Repository
    {
        [Key] 
        public int RepositoryId { get; set; }
        [Required]
        public string RepositoryName { get; set; }
        public ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Homestay> Homestays { get; set; }
        public virtual ICollection<TouristAttraction> TouristAttractions { get; set; } 
        public virtual ICollection<Cuisine> Cuisines { get; set; }
        public virtual ICollection<ForumPost> ForumPosts { get; set; }
    }
}
