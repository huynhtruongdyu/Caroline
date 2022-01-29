using Caroline.Shared.Models.Post;
using MediatR;

namespace Caroline.Infrastructure.Features.Queries.Post
{
    public record GetPostByIdQuery(int Id) : IRequest<PostModel>;
}