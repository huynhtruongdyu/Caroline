using Caroline.Shared.Models.Mediator;
using Caroline.Shared.Models.Post;
using MediatR;

namespace Caroline.Infrastructure.Features.Commands.Posts
{
    public record CreatePostCommand(PostCreateModel model) : IRequest<RequestResponse>;
}