using Microsoft.EntityFrameworkCore;
using QuizProject.Models;

namespace QuizProject.Data
{
    public class QuizContext : DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> options) : base(options)
        {
        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Score> Scores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configure category table
            modelBuilder.Entity<Category>()
                .HasKey(c => c.CategoryId);


            SeedData.AddRecords(modelBuilder);
        }
    }
}
