using Chord.IO.Service.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Chord.IO.Service.Models.Hierarchy;
using Chord.IO.Service.Models.Hierarchy.DrumMaps;
using Chord.IO.Service.Models.User;
using IO.Swagger.Model;

namespace Chord.IO.Service.Services
{
    public class DrumMapService
    {
        private readonly IMongoCollection<DrumMap> _drumMaps;

        public DrumMapService(MongoClient client)
        {
            this._drumMaps = client.Database.GetCollection<DrumMap>("drum_maps");
        }

        public async Task Create(DrumMap document)
        {
            document.Id = ObjectId.GenerateNewId().ToString();
            await this._drumMaps.InsertOneAsync(document);
        }

        public async Task<bool> Update(string id, DrumMap document)
        {
            document.Id = id;
            var result = await this._drumMaps.ReplaceOneAsync(x => x.Id == id, document);
            return result.ModifiedCount == 1;
        }

        public async Task<DrumMap> GetBy(Expression<Func<DrumMap, bool>> filter)
        {
            var result = await this._drumMaps.FindAsync(filter);
            return await result.SingleOrDefaultAsync();
        }

        public async Task<List<DrumMap>> GetAllBy(Expression<Func<DrumMap, bool>> filter)
        {
            var result = await this._drumMaps.FindAsync(filter);
            return await result.ToListAsync();
        }

        public async Task<List<DrumMap>> GetAll()
        {
            return await this._drumMaps.AsQueryable().ToListAsync();
        }

        public async Task<bool> Delete(string id)
        {
            var result = await this._drumMaps.DeleteOneAsync(x => x.Id == id);
            return result.DeletedCount == 1;
        }

        public async Task<bool?> IsExist(Expression<Func<DrumMap, bool>> filter)
        {
            var result = await this._drumMaps.CountDocumentsAsync(filter);

            return result switch
            {
                0 => false,
                1 => true,
                _ => (bool?)null
            };
        }

        public async Task<long> CountBy(Expression<Func<DrumMap, bool>> filter)
        {
            return await this._drumMaps.CountDocumentsAsync(filter);
        }
    }
}
