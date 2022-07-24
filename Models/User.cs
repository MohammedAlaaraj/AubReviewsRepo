using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AubReviews.Models
{
    public class User
    {
        [Key]
        public int userID { get; set; }

        [Required]
        public string fullName { get; set; } = default!;

        [Required]
        public string email { get; set; } = default!;
    }
}