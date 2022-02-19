using Caroline.Infrastructure.Features.Commands.Posts;
using Caroline.Infrastructure.Features.Queries.Posts;
using Caroline.Shared.Models.Post;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Caroline.API.Controllers
{
    public class TestController : BaseController
    {
        public TestController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("GetPosts")]
        public async Task<IActionResult> GetPosts()
        {
            var posts = await _mediator.Send(new GetAllPostQuery());
            if (posts == null)
                return BadRequest("Not Found");
            return Ok(posts);
        }

        [HttpGet("GetPostById")]
        public async Task<IActionResult> GetPostById(int id)
        {
            var post = await _mediator.Send(new GetPostByIdQuery(id));
            if (post == null)
                return BadRequest("Not Found");
            return Ok(post);
        }

        [HttpPost("CreatePost")]
        public async Task<IActionResult> CreatePost(PostCreateModel model)
        {
            var result = await _mediator.Send(new CreatePostCommand(model));
            if (result.IsSuccess)
            {
                return Ok("created");
            }
            return BadRequest(result.Message);
        }

        [HttpGet("/error")]
        public IActionResult HandleError() => Problem();
    }
}