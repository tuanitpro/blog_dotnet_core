using Blog.Core.DataProvider;

namespace Blog.Module.Posts.Repository
{
    public interface IBlogRepository<T> : IRepository<T> where T : class
    {
    }
}