using Caroline.Application.Interfaces.Repositories.Posts;
using Caroline.Domain.Categories;
using Caroline.Infrastructure.Contexts;

namespace Caroline.Infrastructure.Repositories.Posts
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(AppDbContext context) : base(context)
        {
        }
    }
}