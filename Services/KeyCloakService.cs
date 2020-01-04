using System;
using System.Collections.Generic;
using System.Reactive;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reactive.Threading.Tasks;
using System.Threading;
using System.Threading.Tasks;
using Chord.IO.Service.Models.Keycloak;
using Chord.IO.Service.Settings;
using IO.Swagger.Model;
using Microsoft.Extensions.Options;
using Refit;

namespace Chord.IO.Service.Services
{
    public class KeyCloakService
    {
        private readonly KeycloakSettings _settings;

        private readonly IKeycloakApi _client;

        private AuthenticationRepresentation _authentication;

        public string Token { get; set; }

        public KeyCloakService(IOptions<KeycloakSettings> settings)
        {
            this._settings = settings.Value;

            this._client = RestService.For<IKeycloakApi>(this._settings.BaseUrl, new RefitSettings
            {
                AuthorizationHeaderValueGetter = this.GetToken
            });
        }

        private void SetExpirationDates(AuthenticationRepresentation authentication)
        {
            authentication.ExpirationDate = DateTime.Now.AddSeconds(authentication.ExpiresIn);
            authentication.RefreshExpirationDate = DateTime.Now.AddSeconds(authentication.RefreshExpiresIn);
        }

        private async Task<string> GetToken()
        {
            if (this._authentication is null)
            {
                this._authentication = await this.AuthenticateAsAdmin();
            }
            else if (DateTime.Now > this._authentication.ExpirationDate)
            {
                this._authentication = await this.Refresh(this._authentication.RefreshToken);
            }

            return this._authentication.AccessToken;
        }


        public async Task<AuthenticationRepresentation> Authenticate(string username, string password)
        {
            var authentication = await this._client.Authenticate(this._settings.Realm, new Dictionary<string, object>
            {
                {"client_id", this._settings.ClientId},
                {"client_secret", this._settings.ClientSecret},
                {"username", username},
                {"password", password},
                {"grant_type", "password"},
            });

            this.SetExpirationDates(authentication);

            return authentication;
        }

        public async Task<AuthenticationRepresentation> AuthenticateAsAdmin()
        {
            var authentication = await this._client.Authenticate(this._settings.Realm, new Dictionary<string, object>
            {
                {"client_id", this._settings.ClientId},
                {"client_secret", this._settings.ClientSecret},
                {"username", this._settings.Username},
                {"password", this._settings.Password},
                {"grant_type", "password"},
            });

            this.SetExpirationDates(authentication);

            return authentication;
        }

        public async Task<AuthenticationRepresentation> Refresh(string token)
        {
            var authentication = await this._client.Refresh(this._settings.Realm, new Dictionary<string, object>
            {
                {"client_id", this._settings.ClientId},
                {"client_secret", this._settings.ClientSecret},
                {"refresh_token", token},
                {"grant_type", "refresh_token"},
            });

            this.SetExpirationDates(authentication);

            return authentication;
        }

        public async Task<HttpResponseMessage> Logout(string token)
        {
            return await this._client.Logout(this._settings.Realm, new Dictionary<string, object>
            {
                {"client_id", this._settings.ClientId},
                {"client_secret", this._settings.ClientSecret},
                {"refresh_token", token},
            });
        }

        public async Task<UserRepresentation> GetUser(string id)
        {
            return await this._client.GetUser(this._settings.Realm, id);
        }

        public async Task<List<UserRepresentation>> GetUserByEmail(string email)
        {
            return await this._client.GetUserByEmail(this._settings.Realm, email);
        }

        public async Task<List<UserRepresentation>> GetUserByUsername(string username)
        {
            return await this._client.GetUserByUsername(this._settings.Realm, username);
        }

        public async Task<HttpResponseMessage> CreateUser(UserRepresentation user)
        {
            return await this._client.CreateUser(this._settings.Realm, user);
        }

        public async Task<HttpResponseMessage> UpdateUser(string id, [Body] UserRepresentation user)
        {
            return await this._client.UpdateUser(this._settings.Realm, id, user);
        }

        public async Task<HttpResponseMessage> DeleteUser(string id)
        {
            return await this._client.DeleteUser(this._settings.Realm, id);

        }
    }
}
