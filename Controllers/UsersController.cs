using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Chord.IO.Service.Attributes;
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
    [Authorize]
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

        [HttpPut("{id}")]
        [SwaggerOperation(OperationId = "Update")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(string), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Update([NotEmpty] Guid id, [FromBody] UserDto dto)
        {
            var currentUser = await this.GetUser(this._keyCloakService);
            var idString = id.ToString();

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

            if (currentUser.Id != idString)
            {
                return this.Unauthorized("authenticated user trying to update another user");
            }

            var result = await this._keyCloakService.UpdateUser(idString, user);

            if (result.IsSuccessStatusCode)
            {
                return this.NoContent();
            }

            return this.StatusCode((int)StatusCodes.Status403Forbidden, "cannot update user");
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(OperationId = "Delete")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(string), StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult> Delete([NotEmpty] Guid id)
        {
            var currentUser = await this.GetUser(this._keyCloakService);
            var idString = id.ToString();

            if (currentUser.Id != idString)
            {
                return this.Unauthorized("authenticated user trying to delete another user");
            }

            var result = await this._keyCloakService.DeleteUser(idString);

            if (result.IsSuccessStatusCode)
            {
                await this._projectService.DeleteAllByAuthor(idString);
                return this.NoContent();
            }

            return this.StatusCode((int)StatusCodes.Status403Forbidden, "cannot delete user");
        }
    }
}
