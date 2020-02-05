using System;
using Chord.IO.Service.Dto;
using Chord.IO.Service.Models.Hierarchy;
using Chord.IO.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Chord.IO.Service.Models.Hierarchy.Fingerings;
using Microsoft.AspNetCore.Authorization;
using Swashbuckle.AspNetCore.Annotations;

namespace Chord.IO.Service.Controllers
{
    [Authorize]
    [Route("api/fingerings")]
    [ApiController]
    public class FingeringsController : ControllerBase
    {
        private readonly KeyCloakService _keycloakService;
        private readonly FingeringService _fingeringService;

        public FingeringsController(KeyCloakService keycloakService, FingeringService projectService)
        {
            this._keycloakService = keycloakService;
            this._fingeringService = projectService;
        }

        private async Task<bool> IsOwner(string id)
        {
            return await this._fingeringService.IsOwner(id, await this.GetUser(this._keycloakService));
        }

        private async Task<bool> IsFingeringExist(Fingering model)
        {
            var isExist = await this._fingeringService.IsExist(x => x.Name == model.Name);

            return isExist switch
            {
                true => true,
                false => false,
                null => false
            };
        }

        [HttpPost]
        [SwaggerOperation(OperationId = "Create")]
        [ProducesResponseType(typeof(Fingering), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(string), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Fingering>> Create([FromBody] FingeringDto dto)
        {
            var user = await this.GetUser(this._keycloakService);
            var model = dto.ToModelObject();
            model.AuthorId = user.Id;

            if (await this.IsFingeringExist(model))
            {
                return this.Conflict("fingering is already exist");
            }

            await this._fingeringService.Create(model);
            return model;
        }

        [HttpPut("{id:length(24)}")]
        [SwaggerOperation(OperationId = "Update")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Update(string id, [FromBody] FingeringDto dto)
        {
            var user = await this.GetUser(this._keycloakService);
            var model = dto.ToModelObject();
            model.AuthorId = user.Id;

            var isExist = await this._fingeringService.IsExist(x => x.Id == id);

            if (isExist == false)
            {
                return this.NotFound("fingering not found");
            }

            if (!await this.IsOwner(id))
            {
                return this.StatusCode(StatusCodes.Status403Forbidden, "user is not related to this fingering");
            }

            await this._fingeringService.Update(id, model);
            return this.NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        [SwaggerOperation(OperationId = "Delete")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Delete(string id)
        {
            var isExist = await this._fingeringService.IsExist(x => x.Id == id);

            if (isExist == false)
            {
                return this.NotFound("fingering not found");
            }

            if (!await this.IsOwner(id))
            {
                return this.StatusCode(StatusCodes.Status403Forbidden, "user is not related to this fingering");
            }

            await this._fingeringService.Delete(id);
            return this.NoContent();
        }

        [HttpGet("by-id/{id:length(24)}")]
        [SwaggerOperation(OperationId = "GetById")]
        [ProducesResponseType(typeof(Fingering), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Fingering>> GetById(string id)
        {
            var model = await this._fingeringService.GetBy(x => x.Id == id);

            if (model is null)
            {
                return this.NotFound("fingering not found");
            }

            if (!await this.IsOwner(id))
            {
                return this.StatusCode(StatusCodes.Status403Forbidden, "user is not related to this fingering");
            }

            return this.Ok(model);
        }

        [HttpGet("all/by-author")]
        [SwaggerOperation(OperationId = "GetAllByAuthor")]
        [ProducesResponseType(typeof(List<Fingering>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<Fingering>>> GetAllByAuthor()
        {
            var user = await this.GetUser(this._keycloakService);

            var models = await this._fingeringService.GetAllBy(x => x.AuthorId == user.Id);

            if (models is null || models.Count == 0)
            {
                return this.NotFound("fingerings related to author not found");
            }

            return this.Ok(models);
        }

    }
}