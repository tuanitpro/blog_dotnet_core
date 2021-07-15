using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Module.Posts.Domain;

namespace Blog.Module.Posts.Services
{
    public class PostQueryService : IPostQueryService
    {
        public Task<PostModel> GetPostByUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PostModel>> GetPostsByIdAsync(int blogId)
        {
            throw new NotImplementedException();
        }
    }
}