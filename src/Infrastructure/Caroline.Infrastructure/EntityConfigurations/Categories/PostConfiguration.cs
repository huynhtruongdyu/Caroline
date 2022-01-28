using Caroline.Domain.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Caroline.Infrastructure.EntityConfigurations.Categories
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts");
            builder.HasKey(t => t.Id);
            builder.HasData(new Post { Id = 1, Title = "Test 1", Content = "This is some content" });
        }
    }
}