using AubReviews.Models;
using Microsoft.EntityFrameworkCore;

namespace AubReviews.Data{
    public class AubReviewsContext : DbContext
    {
        public AubReviewsContext (DbContextOptions<AubReviewsContext> options) : base(options){

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Review> Reviews {get;set;}
        public DbSet<User> Users {get;set;}

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Review>().ToTable("Review");
            modelBuilder.Entity<User>().ToTable("User");
        }

    }
}