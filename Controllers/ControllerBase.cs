using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        protected ValidationProblemDetails ProcessArgumentException(ArgumentException exception, string paramName)
        {
            var parameterName = string.IsNullOrEmpty(paramName) ? exception.ParamName : paramName;

            return new ValidationProblemDetails(new Dictionary<string, string[]>
            {
                {parameterName, new []{exception.Message}}
            });
        }

        protected ValidationProblemDetails ProcessArithmeticException(ArithmeticException exception, string paramName)
        {
            return new ValidationProblemDetails(new Dictionary<string, string[]>
            {
                {paramName, new []{exception.Message}}
            });
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