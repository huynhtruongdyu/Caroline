using Caroline.Domain.Categories;
using Caroline.Infrastructure.EntityConfigurations.Categories;
using Microsoft.EntityFrameworkCore;

namespace Caroline.Infrastructure.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions opt) : base(opt)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PostConfiguration());
        }

        public virtual DbSet<Post> Posts { get; set; }
    }
}