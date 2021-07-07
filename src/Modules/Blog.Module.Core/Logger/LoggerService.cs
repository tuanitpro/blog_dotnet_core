using System.Linq;
using System.Threading.Tasks;
using Blog.Core.Infrastructure.HttpContext;

namespace Blog.Module.Core.Logger
{
    public class LoggerService : ILoggerService
    {
        private readonly IUserContextService userContextService;

        public LoggerService(IUserContextService userContextService)
        {
            this.userContextService = userContextService;
        }

        public Task Log(ILogActivity logActivity)
        {
            var userName = userContextService.CurrentUser?.UserName;
            var objectModel = logActivity.GetType().GetCustomAttributes(typeof(LogObjectAttribute), true).FirstOrDefault() as LogObjectAttribute;
            var objectName = objectModel.ObjectName;

            throw new System.NotImplementedException();
        }
    }
}