using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chord.IO.Service.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Chord.IO.Service.Services
{
    public class MongoClient
    {
        private readonly MongoConnectionSettings _settings;

        public IMongoDatabase Database { get; private set; }

        public MongoClient(IOptions<MongoConnectionSettings> settings)
        {
            this._settings = settings.Value;

            var url = new MongoUrlBuilder
            {
                Server = new MongoServerAddress(this._settings.Hostname, this._settings.Port),
                Username = this._settings.Username,
                Password = this._settings.Password,
                DatabaseName = this._settings.Database
            }.ToMongoUrl();

            this.Database = new MongoDB.Driver.MongoClient(url).GetDatabase(this._settings.Database);
        }
    }
}
