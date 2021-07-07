using System.Threading.Tasks;
using Blog.Module.Categories.Domain;
using Blog.Module.Categories.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Module.Categories.Controllers
{
    [Route("api/[Controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IBlogQueryService blogQueryService;
        private readonly IBlogCommandService blogCommandService;

        public CategoryController(IBlogQueryService blogQueryService, IBlogCommandService blogCommandService)
        {
            this.blogQueryService = blogQueryService;
            this.blogCommandService = blogCommandService;
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
        public async Task<IActionResult> Post([FromBody] CategoryModel model)
        {
            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CategoryModel model)
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