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
    public class OAuthEndpointSettings
    {
        public string BaseUrl { get; set; }
        public string Authorize { get; set; }
        public string Token { get; set; }
        public string Refresh { get; set; }

        public static OAuthEndpointSettings Configure(IConfiguration configuration)
        {
            var settings = new OAuthEndpointSettings();
            var section = configuration.GetSection("oauth_endpoint_settings");
            settings.BaseUrl = section.GetSection("base_url").Value;
            settings.Authorize = Path.Combine(settings.BaseUrl, section.GetSection("authorize").Value);
            settings.Token = Path.Combine(settings.BaseUrl, section.GetSection("token").Value);
            settings.Refresh = Path.Combine(settings.BaseUrl, section.GetSection("refresh").Value);
            return settings;
        }
        
        public static void Configure(IConfiguration configuration, IServiceCollection services)
        {
            services.Configure<OAuthEndpointSettings>(options => Configure(configuration));
        }
    }
}
