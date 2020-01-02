using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Chord.IO.Service.Dto;
using Chord.IO.Service.Models.User;
using Chord.IO.Service.Services;
using IO.Swagger.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Chord.IO.Service.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly KeyCloakService _keyCloakService;
        private readonly ProjectService _projectService;

        public UsersController(KeyCloakService keyCloakService, ProjectService projectService)
        {
            this._keyCloakService = keyCloakService;
            this._projectService = projectService;
        }

        [HttpPost]
        [SwaggerOperation(OperationId = "Create")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<User>> Create([FromBody] UserDto dto)
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

        [Authorize]
        [HttpPut("{id}")]
        [SwaggerOperation(OperationId = "Update")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(string), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Update(string id, [FromBody] UserDto dto)
        {
            var currentUser = await this.GetUser(this._keyCloakService);

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

            if (currentUser.Id != id)
            {
                return this.Unauthorized("authenticated user trying to update another user");
            }

            var result = await this._keyCloakService.UpdateUser(id, user);

            if (result.IsSuccessStatusCode)
            {
                return this.NoContent();
            }

            return this.StatusCode((int)StatusCodes.Status403Forbidden, "cannot update user");
        }

        [Authorize]
        [HttpDelete("{id}")]
        [SwaggerOperation(OperationId = "Delete")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(string), StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult> Delete(string id)
        {
            var currentUser = await this.GetUser(this._keyCloakService);

            if (currentUser.Id != id)
            {
                return this.Unauthorized("authenticated user trying to delete another user");
            }

            var result = await this._keyCloakService.DeleteUser(id);

            if (result.IsSuccessStatusCode)
            {
                await this._projectService.DeleteAllByAuthor(id);
                return this.NoContent();
            }

            return this.StatusCode((int)StatusCodes.Status403Forbidden, "cannot delete user");
        }
    }
}
