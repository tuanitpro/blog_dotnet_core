using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Blog.Core.Infrastructure.HttpContext;
using Blog.Module.Core;
using Blog.Module.Core.Logger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Blog.Core.Web
{
    public class Startup
    {
        

        

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore()
              .AddAuthorization();
            services.AddHttpContextAccessor();
            services.AddTransient<IUserContextService, UserContextService>();
            services.AddTransient<ILoggerService, LoggerService>();
            // services.AddRazorPages();
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            foreach (var dll in Directory.GetFiles(path, "Blog.Module.*"))
            {
                if (dll.EndsWith(".dll"))
                {
                    var assemblyName = AssemblyName.GetAssemblyName(dll);
                    var moduleInfo = new ModuleInfo
                    {
                        Assembly = Assembly.Load(assemblyName)
                    };
                    GlobalConfiguration.Modules.Add(moduleInfo);
                }
            }
            foreach (var module in GlobalConfiguration.Modules)
            {
                var moduleInitializerType = module.Assembly.GetTypes()
                   .FirstOrDefault(t => typeof(IModuleInitializer).IsAssignableFrom(t));
                if ((moduleInitializerType != null) && (moduleInitializerType != typeof(IModuleInitializer)))
                {
                    var moduleInitializer = (IModuleInitializer)Activator.CreateInstance(moduleInitializerType);

                    moduleInitializer.ConfigureServices(services, Configuration);
                }
            }
            services.AddControllers();
            services.AddHealthChecks();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger(c =>
            {
                c.SerializeAsV2 = true;
            });
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(url: $"/swagger/v1/swagger.json", name: "APIs");
                c.RoutePrefix = string.Empty;
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHealthChecks("/health");
                endpoints.MapControllers();
            });
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapRazorPages();
            //});
        }
    }
}
