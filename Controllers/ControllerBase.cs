using Microsoft.AspNetCore.Mvc;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Chord.IO.Service.Models.User;
using Chord.IO.Service.Services;
using IO.Swagger.Model;
using Microsoft.AspNetCore.Authentication;

namespace Chord.IO.Service.Controllers
{
    [ApiController]
    public class ControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        #region Utils
        protected string ProcessArgumentException(ArgumentException exception, string paramName)
        {
            var exceptionMessage = $"{exception.ParamName} {exception.Message}";

            if (string.IsNullOrEmpty(paramName))
            {
                return exceptionMessage;
            }

            return exception.ParamName != paramName ?
                exceptionMessage :
                $"{nameof(paramName)} {exception.Message}";
        }

        protected async Task<UserRepresentation> GetUser(KeyCloakService service)
        {
            var tokenString = await HttpContext.GetTokenAsync("Bearer", "access_token");
            var token = new JwtSecurityTokenHandler().ReadJwtToken(tokenString);
            var user = await service.GetUser(token.Subject);
            return user;
        }
        #endregion
    }
}