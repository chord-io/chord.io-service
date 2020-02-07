using Chord.IO.Service.Services;
using Chord.IO.Service.Settings;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Converters;
using Swashbuckle.AspNetCore.Filters;
using System;
using Chord.IO.Service.Extensions;
using Chord.IO.Service.Models.Hierarchy.Sequences;
using Chord.IO.Service.Models.Hierarchy.Tracks;

namespace Chord.IO.Service
{
    public class Startup
    {
        public Startup(IHostEnvironment environment)
        {
            

            var builder = new ConfigurationBuilder()
                .SetBasePath(environment.ContentRootPath)
                .AddEnvironmentVariables();

            if (environment.IsDevelopment())
            {
                builder.AddJsonFile("appsettings.Development.json", true, true);
            }
            else
            {
                builder.AddJsonFile("appsettings.json", true, true);
            }
            Configuration = builder.Build();
            Environment = environment;
        }

        public IConfiguration Configuration { get; }
        public IHostEnvironment Environment { get; }

        public void ConfigurationBuilder(IConfigurationBuilder builder)
        {
            builder.AddEnvironmentVariables();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("cors_policy",
                    builder =>
                    {
                        builder
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .AllowAnyOrigin();
                    });
            });

            services
                .AddControllers()
                .ConfigureApiBehaviorOptions(options =>
                {
                    options.InvalidModelStateResponseFactory = context =>
                    {
                        var errors = new ValidationProblemDetails(context.ModelState);
                        return new BadRequestObjectResult(errors);
                    };
                })
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.Converters.Add(new StringEnumConverter());
                });

            services.AddSwaggerGen(options =>
            {
                var endpoints = OAuthEndpointSettings.Configure(Configuration);
                options.SwaggerDoc("1.0", new OpenApiInfo
                {
                    Title = "chord.io",
                    Version = "1.0",
                });
                options.EnableAnnotations();
                options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.OAuth2,
                    Flows = new OpenApiOAuthFlows()
                    {
                        Password = new OpenApiOAuthFlow
                        {
                            AuthorizationUrl = new Uri(endpoints.AuthorizeEndpoint),
                            TokenUrl = new Uri(endpoints.TokenEndpoint),
                            RefreshUrl = new Uri(endpoints.RefreshEndpoint)
                        }
                    }
                });
                options.OperationFilter<SecurityRequirementsOperationFilter>();
                options.AddTypes(new[]
                {
                    typeof(Track),
                    typeof(Sequence)
                });
            });

            services.AddSwaggerGenNewtonsoftSupport();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.Authority = Configuration.GetSection("jwt").GetSection("authority").Value;
                options.Audience = Configuration.GetSection("jwt").GetSection("audience").Value;
                options.RequireHttpsMetadata = false;
                options.Events = new JwtBearerEvents()
                {
                    OnAuthenticationFailed = context =>
                    {
                        context.NoResult();
                        context.Response.StatusCode = 500;
                        context.Response.ContentType = "text/plain";
                        if (Environment.IsDevelopment())
                        {
                            return context.Response.WriteAsync(context.Exception.ToString());
                        }
                        return context.Response.WriteAsync("An error occured processing your authentication.");
                    }
                };
            });

            MongoConnectionSettings.Configure(Configuration, services);
            KeycloakSettings.Configure(Configuration, services);

            services.AddSingleton<MongoClient>();
            services.AddSingleton<ProjectService>();
            services.AddSingleton<KeyCloakService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors("cors_policy");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger(options =>
            {
                options.RouteTemplate = "/help/{documentName}/swagger.json";
                options.SerializeAsV2 = false;
            });

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/help/1.0/swagger.json", "chord.io");
                options.RoutePrefix = "help";
            });

            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
