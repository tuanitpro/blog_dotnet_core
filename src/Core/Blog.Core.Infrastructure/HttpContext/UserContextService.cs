using Blog.Core.Infrastructure.Model;
using Microsoft.AspNetCore.Http;

namespace Blog.Core.Infrastructure.HttpContext
{
    public class UserContextService : IUserContextService
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public UserContextService(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public UserContextModel CurrentUser => httpContextAccessor.HttpContext.Items["CurrentUser"] as UserContextModel;

        public string AccessToken => httpContextAccessor.HttpContext.Items["AccessToken"] is not null ? httpContextAccessor.HttpContext.Items["AccessToken"] as string : null;
    }
}