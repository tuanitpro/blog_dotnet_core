using Blog.Core.Infrastructure.Model;

namespace Blog.Core.Infrastructure.HttpContext
{
    public interface IUserContextService
    {
        UserContextModel CurrentUser { get; }

        string AccessToken { get; }
    }
}