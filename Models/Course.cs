using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AubReviews.Models
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public int courseID {get;set;}

        [Required]
        [Column("CourseName")]
        [StringLength(4,MinimumLength =4)]
        public string? Cname {get;set;}

        [Required]
        [Column("CourseNumber")]
        [Range(100,999)]
        public int Cnumber {get;set;}

        public List<Review>? reviews {get;set;}
    }
}