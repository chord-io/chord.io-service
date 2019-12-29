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
    class AuthenticatedHttpClientHandler : HttpClientHandler
    {
        private readonly Func<Task<string>> getToken;

        public AuthenticatedHttpClientHandler(Func<Task<string>> getToken)
        {
            this.getToken = getToken ?? throw new ArgumentNullException(nameof(getToken));
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var auth = request.Headers.Authorization;
            
            if (auth != null)
            {
                var token = await getToken().ConfigureAwait(false);
                request.Headers.Authorization = new AuthenticationHeaderValue(auth.Scheme, token);
            }

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }

    public class KeyCloakService
    {
        private readonly KeycloakSettings _settings;

        private readonly IKeycloakApi _client;

        private TokenRepresentation _token;

        public KeyCloakService(IOptions<KeycloakSettings> settings)
        {
            this._settings = settings.Value;

            var httpClient = new HttpClient(new AuthenticatedHttpClientHandler(this.GetToken))
                {BaseAddress = new Uri(this._settings.BaseUrl)};


            this._client = RestService.For<IKeycloakApi>(this._settings.BaseUrl, new RefitSettings
            {
                AuthorizationHeaderValueGetter = this.GetToken
            });
        }

        private void SetToken(TokenRepresentation token)
        {
            token.ExpirationDate = DateTime.Now.AddSeconds(token.ExpiresIn);
            token.RefreshExpirationDate = DateTime.Now.AddSeconds(token.RefreshExpiresIn);
            this._token = token;
        }

        private async Task<string> GetToken()
        {
            if (this._token is null)
            {
                this.SetToken(await this.Authenticate());
            }
            else if (DateTime.Now > this._token.ExpirationDate)
            {
                this.SetToken(await this.Refresh());
            }

            return this._token.AccessToken;
        }

        private async Task<TokenRepresentation> Authenticate()
        {
            return await this._client.Authenticate(this._settings.Realm, new Dictionary<string, object>
            {
                {"client_id", this._settings.ClientId},
                {"username", this._settings.Username},
                {"password", this._settings.Password},
                {"grant_type", "password"},
            });
        }

        private async Task<TokenRepresentation> Refresh()
        {
            return await this._client.Refresh(this._settings.Realm, new Dictionary<string, object>
            {
                {"client_id", this._settings.ClientId},
                {"client_secret", this._settings.ClientSecret},
                {"refresh_token", this._token.RefreshToken},
                {"grant_type", "refresh_token"},
            });
        }

        private async Task<HttpResponseMessage> Logout()
        {
            return await this._client.Logout(this._settings.Realm, new Dictionary<string, object>
            {
                {"client_id", this._settings.ClientId},
                {"client_secret", this._settings.ClientSecret},
                {"refresh_token", this._token.RefreshToken},
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
