using Blog.Core.DataProvider;

namespace Blog.Module.Categories.Repository
{
    public interface IBlogRepository<T> : IRepository<T> where T : class
    {
    }
}