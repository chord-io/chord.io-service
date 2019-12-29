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
        public string AuthorizeEndpoint { get; set; }
        public string TokenEndpoint { get; set; }
        public string RefreshEndpoint { get; set; }

        public static OAuthEndpointSettings Configure(IConfiguration configuration)
        {
            var settings = new OAuthEndpointSettings();
            var section = configuration.GetSection("oauth_endpoint_settings");
            settings.BaseUrl = section.GetSection("base_url").Value;
            settings.AuthorizeEndpoint = Path.Combine(settings.BaseUrl, section.GetSection("authorize_endpoint").Value);
            settings.TokenEndpoint = Path.Combine(settings.BaseUrl, section.GetSection("token_endpoint").Value);
            settings.RefreshEndpoint = Path.Combine(settings.BaseUrl, section.GetSection("refresh_endpoint").Value);
            return settings;
        }
        
        public static void Configure(IConfiguration configuration, IServiceCollection services)
        {
            services.Configure<OAuthEndpointSettings>(options => Configure(configuration));
        }
    }
}
