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
using Microsoft.AspNetCore.Authorization;
using Swashbuckle.AspNetCore.Annotations;

namespace Chord.IO.Service.Controllers
{
    [Authorize]
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ProjectService _projectService;
        private readonly KeyCloakService _keycloakService;

        public ProjectsController(ProjectService projectService, KeyCloakService keycloakService)
        {
            this._projectService = projectService;
            this._keycloakService = keycloakService;
        }

        private async Task<bool> IsOwner(string id)
        {
            return await this._projectService.IsOwner(id, await this.GetUser(this._keycloakService));
        }

        private async Task<bool> IsProjectExist(Project model)
        {
            var isExist = await this._projectService.IsExist(x => x.Name == model.Name && x.AuthorId == model.AuthorId);

            return isExist switch
            {
                true => true,
                false => false,
                null => false
            };
        }

        [HttpPost]
        [SwaggerOperation(OperationId = "Create")]
        [ProducesResponseType(typeof(Project), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(string), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Project>> Create([FromBody] ProjectDto dto)
        {
            var user = await this.GetUser(this._keycloakService);
            var model = dto.ToModelObject();
            model.AuthorId = user.Id;

            if (await this.IsProjectExist(model))
            {
                return this.Conflict($"project is already exist");
            }

            await this._projectService.Create(model);
            return model;
        }

        [HttpPut("{id:length(24)}")]
        [SwaggerOperation(OperationId = "Update")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Update(string id, [FromBody] ProjectDto dto)
        { 

            var user = await this.GetUser(this._keycloakService);
            var model = dto.ToModelObject();
            model.AuthorId = user.Id;

            if (!await this.IsProjectExist(model))
            {
                return this.NotFound("project not found");
            }

            if (!await this.IsOwner(id))
            {
                return this.StatusCode(StatusCodes.Status403Forbidden, "user is not related to this project");
            }

            await this._projectService.Update(id, model);
            return this.NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        [SwaggerOperation(OperationId = "Delete")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Project>> Delete(string id)
        {
            var isExist = await this._projectService.IsExist(x => x.Id == id);

            if (isExist == false)
            {
                return this.NotFound($"project not found");
            }

            if (!await this.IsOwner(id))
            {
                return this.StatusCode(StatusCodes.Status403Forbidden, "user is not related to this project");
            }

            await this._projectService.Delete(id);
            return this.NoContent();
        }

        [HttpGet("by-id/{id:length(24)}")]
        [SwaggerOperation(OperationId = "GetById")]
        [ProducesResponseType(typeof(Project), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Project>> GetById(string id)
        {
            var model = await this._projectService.GetBy(x => x.Id == id);

            if (model is null)
            {
                return this.NotFound("project not found");
            }

            if (!await this.IsOwner(id))
            {
                return this.StatusCode(StatusCodes.Status403Forbidden, "user is not related to this project");
            }

            return this.Ok(model);
        }

        [HttpGet("all/by-author")]
        [SwaggerOperation(OperationId = "GetAllByAuthor")]
        [ProducesResponseType(typeof(List<Project>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<Project>>> GetAllByAuthor()
        {
            var user = await this.GetUser(this._keycloakService);

            var models = await this._projectService.GetAllBy(x => x.AuthorId == user.Id);

            if (models is null || models.Count == 0)
            {
                return this.NotFound("projects related to author not found");
            }

            return this.Ok(models);
        }

    }
}