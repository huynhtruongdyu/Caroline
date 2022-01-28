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
            var data = await _mediator.Send(new GetAllPostQuery());
            return Ok(data);
        }
    }
}