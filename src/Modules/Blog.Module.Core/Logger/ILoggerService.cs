using System.Threading.Tasks;

namespace Blog.Module.Core.Logger
{
    public interface ILoggerService
    {
        Task Log(ILogActivity logActivity);
    }
}