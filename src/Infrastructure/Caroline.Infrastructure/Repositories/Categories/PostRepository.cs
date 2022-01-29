using Caroline.Application.Interfaces.Repositories.Categories;
using Caroline.Domain.Categories;
using Caroline.Infrastructure.Contexts;

namespace Caroline.Infrastructure.Repositories.Categories
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(AppDbContext context) : base(context)
        {
        }
    }
}