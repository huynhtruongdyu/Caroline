using Caroline.Infrastructure.Features.Queries.Post;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Caroline.API.Controllers
{
    public class TestController : BaseController
    {
        private readonly IMediator _mediator;

        public TestController(IMediator mediator)
        {
            _mediator = mediator;
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
    }
}