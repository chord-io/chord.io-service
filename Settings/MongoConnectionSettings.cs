using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace Chord.IO.Service.Settings
{
    public class MongoConnectionSettings
    {
        public string Hostname { get; set; }

        public ushort Port { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Database { get; set; }

        public static void Configure(IConfiguration configuration, IServiceCollection services)
        {
            services.Configure<MongoConnectionSettings>(options =>
            {
                var section = configuration.GetSection("mongo_connection_settings");
                options.Hostname = section.GetSection("hostname").Value;
                options.Port = ushort.Parse(section.GetSection("port").Value);
                options.Username = section.GetSection("username").Value;
                options.Password = section.GetSection("password").Value;
                options.Database = section.GetSection("database").Value;
            });
        }
    }
}
