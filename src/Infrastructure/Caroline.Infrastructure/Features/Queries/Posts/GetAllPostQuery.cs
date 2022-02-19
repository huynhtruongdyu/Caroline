using Caroline.Shared.Models.Post;
using MediatR;

namespace Caroline.Infrastructure.Features.Queries.Posts
{
    public class GetAllPostQuery : IRequest<List<PostModel>> { };
}