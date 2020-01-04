using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Chord.IO.Service.Models.Keycloak;
using IO.Swagger.Model;
using Refit;

namespace Chord.IO.Service.Services
{
    [Headers("Content-Type: application/json")]
    interface IKeycloakApi
    {
        [Headers("Content-Type: application/x-www-form-urlencoded")]
        [Post("/realms/{realm}/protocol/openid-connect/token")]
        Task<AuthenticationRepresentation> Authenticate(string realm, [Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, object> data);

        [Headers("Content-Type: application/x-www-form-urlencoded")]
        [Post("/realms/{realm}/protocol/openid-connect/token")]
        Task<AuthenticationRepresentation> Refresh(string realm, [Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, object> data);

        [Headers("Content-Type: application/x-www-form-urlencoded", "Authorization: Bearer")]
        [Post("/realms/{realm}/protocol/openid-connect/logout")]
        Task<HttpResponseMessage> Logout(string realm, [Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, object> data);

        [Headers("Authorization: Bearer")]
        [Get("/admin/realms/{realm}/users/{id}")]
        Task<UserRepresentation> GetUser(string realm, string id);

        [Headers("Authorization: Bearer")]
        [Get("/admin/realms/{realm}/users")]
        Task<List<UserRepresentation>> GetUserByEmail(string realm, string email);

        [Headers("Authorization: Bearer")]
        [Get("/admin/realms/{realm}/users")]
        Task<List<UserRepresentation>> GetUserByUsername(string realm, string username);

        [Headers("Authorization: Bearer")]
        [Post("/admin/realms/{realm}/users")]
        Task<HttpResponseMessage> CreateUser(string realm, [Body] UserRepresentation user);

        [Headers("Authorization: Bearer")]
        [Put("/admin/realms/{realm}/users/{id}")]
        Task<HttpResponseMessage> UpdateUser(string realm, string id, [Body] UserRepresentation user);

        [Headers("Authorization: Bearer")]
        [Delete("/admin/realms/{realm}/users/{id}")]
        Task<HttpResponseMessage> DeleteUser(string realm, string id);
    }
}
