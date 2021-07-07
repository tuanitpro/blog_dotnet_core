using System;
using Blog.Module.Categories.Repository;
using Blog.Module.Posts.Services;
using Blog.Module.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Blog.Module.Posts
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            throw new NotImplementedException();
        }

        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient(typeof(IBlogRepository<>), typeof(BlogRepository<>));
            services.AddTransient<IPostQueryService, PostQueryService>();
            services.AddTransient<IPostCommandService, PostCommandService>();
        }
    }
}