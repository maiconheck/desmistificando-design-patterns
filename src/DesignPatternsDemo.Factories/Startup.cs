using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using DesignPatternsDemo.Factories.CommandResult;
using DesignPatternsDemo.Factories.Fake.Application;
using DesignPatternsDemo.Factories.CommandResult.Basic;
using DesignPatternsDemo.Factories.CommandResult.Default;

namespace DesignPatternsDemo.Factories
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICommandResultFactory, DefaultCommandResultFactory>();
            services.AddScoped<CategoryApplicationService>();

            services.AddCors();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(policy => policy
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());

            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
