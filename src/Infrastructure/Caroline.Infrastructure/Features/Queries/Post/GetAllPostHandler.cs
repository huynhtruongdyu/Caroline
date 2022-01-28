using Caroline.Infrastructure.Contexts;
using Caroline.Infrastructure.Models.Post;
using MediatR;

namespace Caroline.Infrastructure.Features.Queries.Post
{
    public class GetAllPostHandler : IRequestHandler<GetAllPostQuery, List<PostModel>>
    {
        private readonly AppDbContext _context;

        public GetAllPostHandler(AppDbContext context)
        {
            _context = context;
        }

        public Task<List<PostModel>> Handle(GetAllPostQuery request, CancellationToken cancellationToken)
        {
            var postsFromDB = _context.Posts.ToList();
            var postsModel = postsFromDB.Select(post => new PostModel { Id = post.Id, Title = post.Title, Content = post.Content, ThumbnailURL = post.Thumbnail, CreatedDate = post.CreatedDate, CreatedBy = post.CreatedBy }).ToList();
            return Task.FromResult(postsModel);
        }
    }
}