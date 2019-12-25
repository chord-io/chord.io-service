using System.ComponentModel;
using System.Text.Json.Serialization;
using Chord.IO.Service.Services;
using Chord.IO.Service.Settings;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Converters;
using Swashbuckle.AspNetCore.Swagger;

namespace Chord.IO.Service
{
    public class Startup
    {
        public Startup(IHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        public void ConfigurationBuilder(IConfigurationBuilder builder)
        {
            builder.AddEnvironmentVariables();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddControllers()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.Converters.Add(new StringEnumConverter());
                });

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("1.0", new OpenApiInfo
                {
                    Title = "chord.io",
                    Version = "1.0",
                });
                options.EnableAnnotations();
            });

            services.AddSwaggerGenNewtonsoftSupport();

            MongoConnectionSettings.Configure(context, services);

            services.AddSingleton<MongoClient>();
            services.AddSingleton<ProjectService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger(options =>
            {
                options.RouteTemplate = "/help/{documentName}/swagger.json";
                options.SerializeAsV2 = true;
            });

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/help/1.0/swagger.json", "chord.io");
                options.RoutePrefix = "help";
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
