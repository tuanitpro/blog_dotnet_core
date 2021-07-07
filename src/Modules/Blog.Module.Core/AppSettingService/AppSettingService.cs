using Microsoft.Extensions.Options;

namespace Blog.Module.Core.AppSettingService
{
    public class AppSettingService : IAppSettingService
    {
        private readonly AppSettings appSettings;

        public AppSettingService(IOptions<AppSettings> options)
        {
            this.appSettings = options.Value;
        }

        public EmailSettings EmailSettings => appSettings.EmailSettings;
    }
}