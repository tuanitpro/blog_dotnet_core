using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Module.Categories.Domain;
using Blog.Modules.Shared;

namespace Blog.Module.Categories.Services
{
    public class BlogQueryService : IBlogQueryService
    {
        public Task<IEnumerable<CategoryModel>> GetAllCategories(int blogId, ParamQueryModel queryModel)
        {
            throw new NotImplementedException();
        }

        public Task<BlogModel> GetBlogByIdAsync(int blogId)
        {
            throw new NotImplementedException();
        }

        public Task<BlogModel> GetBlogByUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryModel> GetCategoryModelByBlogId(int blogId)
        {
            throw new NotImplementedException();
        }
    }
}