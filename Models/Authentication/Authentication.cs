using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chord.IO.Service.Models.Keycloak;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Authentication
{
    public class Authentication
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("refresh_expires_in")]
        public int RefreshExpiresIn { get; set; }

        [JsonProperty("expiration_date")]
        public DateTime ExpirationDate { get; set; }

        [JsonProperty("refresh_expiration_date")]
        public DateTime RefreshExpirationDate { get; set; }

        public static Authentication FromRepresentation(AuthenticationRepresentation authentication)
        {
            return new Authentication
            {
                AccessToken = authentication.AccessToken,
                RefreshToken = authentication.RefreshToken,
                ExpiresIn = authentication.ExpiresIn,
                RefreshExpiresIn = authentication.RefreshExpiresIn,
                ExpirationDate = authentication.ExpirationDate,
                RefreshExpirationDate = authentication.RefreshExpirationDate
            };
        }
    }
}
