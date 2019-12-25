using Chord.IO.Service.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Chord.IO.Service.Models.Hierarchy;

namespace Chord.IO.Service.Services
{
    public class ProjectService
    {
        private readonly IMongoCollection<Project> _projects;

        public ProjectService(MongoClient client)
        {
            this._projects = client.Database.GetCollection<Project>("projects");
        }

        public async Task Create(Project document)
        {
            await this._projects.InsertOneAsync(document);
        }

        public async Task<bool> Update(string id, Project document)
        {
            var bsonDocument = document.ToBsonDocument();
            bsonDocument.Remove("Id");
            var filter = Builders<Project>.Filter.Eq(x => x.Id, id);
            var result = await this._projects.UpdateOneAsync(filter, bsonDocument);
            return result.ModifiedCount == 1;
        }

        public async Task<Project> GetBy(Expression<Func<Project, bool>> filter)
        {
            var result = await this._projects.FindAsync(filter);
            return await result.SingleOrDefaultAsync();
        }

        public async Task<List<Project>> GetAllBy(Expression<Func<Project, bool>> filter)
        {
            var result = await this._projects.FindAsync(filter);
            return await result.ToListAsync();
        }

        public async Task<bool> Delete(string id)
        {
            var result = await this._projects.DeleteOneAsync(x => x.Id == id);
            return result.DeletedCount == 1;
        }

        public async Task<bool?> IsExist(Expression<Func<Project, bool>> filter)
        {
            var result = await this._projects.CountDocumentsAsync(filter);

            return result switch
            {
                0 => false,
                1 => true,
                _ => (bool?)null
            };
        }
    }
}
