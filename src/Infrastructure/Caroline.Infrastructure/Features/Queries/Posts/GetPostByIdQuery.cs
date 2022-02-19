using Caroline.Shared.Models.Post;
using MediatR;

namespace Caroline.Infrastructure.Features.Queries.Posts
{
    public record GetPostByIdQuery(int Id) : IRequest<PostModel>;
}