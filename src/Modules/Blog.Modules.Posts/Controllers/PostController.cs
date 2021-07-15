using System.Threading.Tasks;
using Blog.Module.Posts.Domain;
using Blog.Module.Posts.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Module.Posts.Controllers
{
    [Route("api/[Controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class PostController : ControllerBase
    {
        private readonly IPostQueryService postQueryService;
        private readonly IPostCommandService postCommandService;

        public PostController(IPostQueryService postQueryService, IPostCommandService postCommandService)
        {
            this.postQueryService = postQueryService;
            this.postCommandService = postCommandService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PostModel model)
        {
            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] PostModel model)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok();
        }
    }
}