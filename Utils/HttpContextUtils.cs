using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;

namespace Chord.IO.Service.Utils
{
    public static class HttpContextUtils
    {
        public static async Task<JwtSecurityToken> GetToken(HttpContext context)
        {
            var tokenString = await context.GetTokenAsync("Bearer", "access_token");
            return new JwtSecurityTokenHandler().ReadJwtToken(tokenString);
        }

        public static async Task<string> GetUserId(HttpContext context)
        {
            var token = await GetToken(context);
            return token.Subject;
        }
    }
}
