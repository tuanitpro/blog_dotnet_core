using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Module.Categories.Domain;

namespace Blog.Module.Posts.Services
{
    public interface IPostQueryService
    {
        Task<PostModel> GetPostByUserAsync();

        Task<IEnumerable<PostModel>> GetPostsByIdAsync(int blogId);
    }
}