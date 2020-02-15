using Chord.IO.Service.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Chord.IO.Service.Models.Hierarchy;
using Chord.IO.Service.Models.User;
using IO.Swagger.Model;

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
            document.Id = ObjectId.GenerateNewId().ToString();
            await this._projects.InsertOneAsync(document);
        }

        public async Task<bool> Update(string id, Project document)
        {
            document.Id = id;
            var result = await this._projects.ReplaceOneAsync(x => x.Id == id, document);
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

        public async Task<bool> DeleteAllByAuthor(string id)
        {
            var count = await this._projects.CountDocumentsAsync(x => x.AuthorId == id);
            var result = await this._projects.DeleteManyAsync(x => x.AuthorId == id);
            return result.DeletedCount == count;
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

        public async Task<bool> IsOwner(string id, UserRepresentation user)
        {
            var projects = await this._projects.FindAsync(x => x.Id == id && x.AuthorId == user.Id);
            return projects.Any();
        }

        public async Task<long> CountBy(Expression<Func<Project, bool>> filter)
        {
            return await this._projects.CountDocumentsAsync(filter);
        }
    }
}
