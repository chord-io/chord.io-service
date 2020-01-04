using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chord.IO.Service.Dto;
using Chord.IO.Service.Models.Authentication;
using Chord.IO.Service.Models.Keycloak;
using Chord.IO.Service.Models.User;
using Chord.IO.Service.Services;
using IO.Swagger.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Chord.IO.Service.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly KeyCloakService _keyCloakService;

        public AuthenticationController(KeyCloakService keyCloakService)
        {
            this._keyCloakService = keyCloakService;
        }

        [HttpPost("sign-in")]
        [SwaggerOperation(OperationId = "SignIn")]
        [ProducesResponseType(typeof(Authentication), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<AuthenticationRepresentation>> SignIn([FromBody] SignInDto dto)
        {
            var user = await this._keyCloakService.GetUserByUsername(dto.Username);

            if (!user.Any())
            {
                var validationError = new ValidationProblemDetails(new Dictionary<string, string[]>
                {
                    {"Username", new []{"username does not exist"}}
                });

                return this.BadRequest(validationError);
            }

            return this.Ok(await this._keyCloakService.Authenticate(dto.Username, dto.Password));
        }

        [HttpPost("sign-up")]
        [SwaggerOperation(OperationId = "SignUp")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<User>> SignUp([FromBody] UserDto dto)
        {
            var user = new UserRepresentation
            {
                Username = dto.Username,
                Email = dto.Email,
                Enabled = true,
                Credentials = new List<CredentialRepresentation>
                {
                    new CredentialRepresentation
                    {
                        Value = dto.Password,
                        Type = "password"
                    }
                }
            };

            var result = await this._keyCloakService.CreateUser(user);

            if (!result.IsSuccessStatusCode)
            {
                return this.StatusCode((int)result.StatusCode, result.ReasonPhrase);
            }

            var result2 = await this._keyCloakService.GetUserByEmail(user.Email);

            if (!result2.Any())
            {
                return this.NotFound("user created but cannot be found");
            }

            user = result2.Single();

            return this.Ok(new User
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email
            });
        }

        [HttpGet("sign-out")]
        [SwaggerOperation(OperationId = "SignOut")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> SignOut([FromHeader(Name = "refresh_token")] string token)
        {
            var response = await this._keyCloakService.Logout(token);

            if (response.IsSuccessStatusCode)
            {
                return this.NoContent();
            }

            return this.StatusCode((int)response.StatusCode, response.ReasonPhrase);
        }

        [HttpGet("refresh")]
        [SwaggerOperation(OperationId = "Refresh")]
        [ProducesResponseType(typeof(Authentication),StatusCodes.Status200OK)]
        public async Task<ActionResult<Authentication>> Refresh([FromHeader(Name = "refresh_token")] string token)
        {
            return this.Ok(await this._keyCloakService.Refresh(token));
        }
    }
}
