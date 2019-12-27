using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chord.IO.Service.Models.Hierarchy;
using Chord.IO.Service.Models.User;
using MongoDB.Driver;

namespace Chord.IO.Service.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(MongoClient client)
        {
            this._users = client.Database.GetCollection<User>("users");
        }

        public async Task<User> GetOrCreate(string id)
        {
            var user = await this._users.FindAsync(x => x.KeycloakId == id);

            if (user.Any())
            {
                return user.Single();
            }

            var userToCreate = new User
            {
                KeycloakId = id
            };

            this._users.InsertOne(userToCreate);

            return userToCreate;
        }
    }
}
