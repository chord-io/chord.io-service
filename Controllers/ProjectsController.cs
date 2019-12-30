using Chord.IO.Service.Dto;
using Chord.IO.Service.Models.Hierarchy;
using Chord.IO.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
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

        private bool IsInvalidModel(Project model)
        {
            return !TryValidateModel(model, nameof(Project));
        }

        private async Task<bool> IsOwner(string id)
        {
            return await this._projectService.IsOwner(id, await this.GetUser(this._keycloakService));
        }

        private BadRequestObjectResult ProcessInvalidModelState(Project model)
        {
            var errors = this.ModelState
                .Where(x => x.Value.Errors.Count > 0)
                .SelectMany(x => x.Value.Errors)
                .ToList();

            return this.BadRequest(errors);
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
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public async Task<ActionResult> Create([FromBody] ProjectDto dto)
        {
            var model = dto.ToModelObject();

            if (this.IsInvalidModel(model))
            {
                return this.ProcessInvalidModelState(model);
            }

            if (await this.IsProjectExist(model))
            {
                return this.Conflict($"project <{model.Name}> is already exist");
            }

            var user = await this.GetUser(this._keycloakService);
            model.AuthorId = user.Id;

            await this._projectService.Create(model);
            return this.CreatedAtAction("GetById", new {id = model.Id}, model);
        }

        [HttpPut("{id:length(24)}")]
        [SwaggerOperation(OperationId = "Update")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Update(string id, [FromBody] ProjectDto dto)
        {
            var model = dto.ToModelObject();

            if (this.IsInvalidModel(model))
            {
                return this.ProcessInvalidModelState(model);
            }

            var isExist = await this._projectService.IsExist(x => x.Id == id);

            if (isExist == false)
            {
                return this.NotFound($"project <{id}> not found");
            }

            if (!await this.IsOwner(id))
            {
                return this.Forbid($"user is not related to this project <{id}>");
            }

            var user = await this.GetUser(this._keycloakService);
            model.AuthorId = user.Id;

            await this._projectService.Update(id, model);
            return this.NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        [SwaggerOperation(OperationId = "Delete")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Project>> Delete(string id)
        {
            var isExist = await this._projectService.IsExist(x => x.Id == id);

            if (isExist == false)
            {
                return this.NotFound($"project <{id}> not found");
            }

            if (!await this.IsOwner(id))
            {
                return this.Forbid($"user is not related to this project <{id}>");
            }

            await this._projectService.Delete(id);
            return this.NoContent();
        }

        [HttpGet("by-id/{id:length(24)}")]
        [SwaggerOperation(OperationId = "GetById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Project>> GetById(string id)
        {
            var model = await this._projectService.GetBy(x => x.Id == id);

            if (model is null)
            {
                return this.NotFound($"project <{id}> not found");
            }

            if (!await this.IsOwner(id))
            {
                return this.Forbid($"user is not related to this project <{id}>");
            }

            return this.Ok(model);
        }

        [HttpGet("all/by-author/{authorId:length(24)}")]
        [SwaggerOperation(OperationId = "GetAllByAuthor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<Project>>> GetAllByAuthor()
        {
            var user = await this.GetUser(this._keycloakService);

            var models = await this._projectService.GetAllBy(x => x.AuthorId == user.Id);

            if (models is null)
            {
                return this.NotFound($"projects related to author <{user.Id}> not found");
            }

            return this.Ok(models);
        }

    }
}