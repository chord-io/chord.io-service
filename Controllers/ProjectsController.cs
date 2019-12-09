using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chord.IO.Service.Dto;
using Chord.IO.Service.Models;
using Chord.IO.Service.Models.Hierarchy;
using Chord.IO.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chord.IO.Service.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ProjectService _service;

        public ProjectsController(ProjectService service)
        {
            this._service = service;
        }

        private bool IsInvalidModel(Project model)
        {
            return !TryValidateModel(model, nameof(Project));
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
            var isExist = await this._service.IsExist(x => x.Name == model.Name && x.AuthorId == model.AuthorId);

            return isExist switch
            {
                true => true,
                false => false,
                null => false
            };
        }

        [HttpPost]
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

            await this._service.Create(model);
            return this.CreatedAtAction("GetById", new {id = model.Id}, model);
        }

        [HttpPut("{id:length(24)}")]
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

            var isExist = await this._service.IsExist(x => x.Id == id);

            if (isExist == false)
            {
                return this.NotFound($"project <{id}> not found");
            }

            await this._service.Update(id, model);
            return this.NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Project>> Delete(string id)
        {
            var isExist = await this._service.IsExist(x => x.Id == id);

            if (isExist == false)
            {
                return this.NotFound($"project <{id}> not found");
            }

            await this._service.Delete(id);
            return this.NoContent();
        }

        [HttpGet("by-id/{id:length(24)}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Project>> GetById(string id)
        {
            var model = await this._service.GetBy(x => x.Id == id);

            if (model is null)
            {
                return this.NotFound($"project <{id}> not found");
            }

            return this.Ok(model);
        }

        [HttpGet("all/by-author-id/{authorId:length(24)}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<Project>>> GetAllByAuthorId(string authorId)
        {
            var models = await this._service.GetAllBy(x => x.AuthorId == authorId);

            if (models is null)
            {
                return this.NotFound($"projects related to author <{authorId}> not found");
            }

            return this.Ok(models);
        }

    }
}