using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AubReviews.Models
{
    [Table("Review")]
    public class Review
    {
        [Key]
        public int ID {get;set;}
        
        [Required]
        [Range(0,5)]
        public int rating{get;set;}

        [Column("ReviewText")]
        [DataType(DataType.Text)]
        [Required]
        public string? rText {get;set;}

        [Required]
        public string? tag {get;set;}

        [ForeignKey("User")]
        [Required]
        public int userID { get; set; }

        [Required]
        public User user { get; set; } = default!;

        [ForeignKey("Course")]
        [Required]
        public int courseID { get; set; }

        [Required]
        public Course course {get;set;} = default!;

    }
}