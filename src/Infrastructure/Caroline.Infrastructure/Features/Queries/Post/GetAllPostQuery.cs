using Caroline.Shared.Models.Post;
using MediatR;

namespace Caroline.Infrastructure.Features.Queries.Post
{
    public record GetAllPostQuery : IRequest<List<PostModel>>;
}