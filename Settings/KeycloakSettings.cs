using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace Chord.IO.Service.Settings
{
    public class KeycloakSettings
    {
        public string BaseUrl { get; set; }
        public string Realm { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public static void Configure(IConfiguration configuration, IServiceCollection services)
        {
            services.Configure<KeycloakSettings>(options =>
            {
                var section = configuration.GetSection("keycloak_settings");
                options.BaseUrl = section.GetSection("base_url").Value;
                options.Realm = section.GetSection("realm").Value;
                options.ClientId = section.GetSection("client_id").Value;
                options.ClientSecret = section.GetSection("client_secret").Value;
                options.Username = section.GetSection("username").Value;
                options.Password = section.GetSection("password").Value;
            });
        }
    }
}
