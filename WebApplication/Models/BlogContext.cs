using Microsoft.EntityFrameworkCore;

namespace WebApplication.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public BlogContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}