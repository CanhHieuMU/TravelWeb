﻿using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class CategoryTakeAway
    {
        [Key]
        public int CategoryTakeId { get; set; }
        [Required]
        public string CategoryTakeName { get; set;}
        public virtual ICollection<Cuisine> Cuisines { get; set; }
    }
}
