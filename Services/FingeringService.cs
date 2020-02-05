using Chord.IO.Service.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Chord.IO.Service.Models.Hierarchy;
using Chord.IO.Service.Models.Hierarchy.DrumMaps;
using Chord.IO.Service.Models.Hierarchy.Fingerings;
using Chord.IO.Service.Models.User;
using IO.Swagger.Model;

namespace Chord.IO.Service.Services
{
    public class FingeringService
    {
        private readonly IMongoCollection<Fingering> _fingerings;

        public FingeringService(MongoClient client)
        {
            this._fingerings = client.Database.GetCollection<Fingering>("fingerings");
        }

        public async Task Create(Fingering document)
        {
            await this._fingerings.InsertOneAsync(document);
        }

        public async Task<bool> Update(string id, Fingering document)
        {
            document.Id = id;
            var result = await this._fingerings.ReplaceOneAsync(x => x.Id == id, document);
            return result.ModifiedCount == 1;
        }

        public async Task<Fingering> GetBy(Expression<Func<Fingering, bool>> filter)
        {
            var result = await this._fingerings.FindAsync(filter);
            return await result.SingleOrDefaultAsync();
        }

        public async Task<List<Fingering>> GetAllBy(Expression<Func<Fingering, bool>> filter)
        {
            var result = await this._fingerings.FindAsync(filter);
            return await result.ToListAsync();
        }

        public async Task<bool> Delete(string id)
        {
            var result = await this._fingerings.DeleteOneAsync(x => x.Id == id);
            return result.DeletedCount == 1;
        }

        public async Task<bool?> IsExist(Expression<Func<Fingering, bool>> filter)
        {
            var result = await this._fingerings.CountDocumentsAsync(filter);

            return result switch
            {
                0 => false,
                1 => true,
                _ => (bool?)null
            };
        }

        public async Task<bool> IsOwner(string id, UserRepresentation user)
        {
            var fingerings = await this._fingerings.FindAsync(x => x.Id == id && x.AuthorId == user.Id);
            return fingerings.Any();
        }

        public async Task<long> CountBy(Expression<Func<Fingering, bool>> filter)
        {
            return await this._fingerings.CountDocumentsAsync(filter);
        }

        public async Task UpdateAllWhenAuthorIsDeleted(string id)
        {
            var definition = Builders<Fingering>.Update.Set(x => x.Id, ObjectId.Empty.ToString());
            await this._fingerings.UpdateManyAsync(x => x.AuthorId == id, definition);
        }
    }
}
