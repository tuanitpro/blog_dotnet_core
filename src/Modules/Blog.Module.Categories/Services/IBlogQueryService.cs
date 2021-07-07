using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Module.Categories.Domain;
using Blog.Modules.Shared;

namespace Blog.Module.Categories.Services
{
    public interface IBlogQueryService
    {
        Task<BlogModel> GetBlogByUserAsync();

        Task<BlogModel> GetBlogByIdAsync(int blogId);

        Task<CategoryModel> GetCategoryModelByBlogId(int blogId);

        Task<IEnumerable<CategoryModel>> GetAllCategories(int blogId, ParamQueryModel queryModel);
    }
}