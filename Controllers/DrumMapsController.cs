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
using Chord.IO.Service.Models.Hierarchy.DrumMaps;
using Chord.IO.Service.Models.Hierarchy.Fingerings;
using Microsoft.AspNetCore.Authorization;
using Swashbuckle.AspNetCore.Annotations;

namespace Chord.IO.Service.Controllers
{
    [Authorize]
    [Route("api/drum-maps")]
    [ApiController]
    public class DrumMapsController : ControllerBase
    {
        private readonly KeyCloakService _keycloakService;
        private readonly DrumMapService _drumMapService;

        public DrumMapsController(KeyCloakService keycloakService, DrumMapService drumMapService)
        {
            this._keycloakService = keycloakService;
            this._drumMapService = drumMapService;
        }

        private async Task<bool> IsDrumMapExist(DrumMap model)
        {
            var isExist = await this._drumMapService.IsExist(x => x.Name == model.Name);

            return isExist switch
            {
                true => true,
                false => false,
                null => false
            };
        }

        [HttpPost]
        [SwaggerOperation(OperationId = "Create")]
        [ProducesResponseType(typeof(DrumMap), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(string), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<DrumMap>> Create([FromBody] DrumMapDto dto)
        {
            var model = dto.ToModelObject();

            if (await this.IsDrumMapExist(model))
            {
                return this.Conflict("drum map is already exist");
            }

            await this._drumMapService.Create(model);
            return model;
        }

        [HttpPut("{id:length(24)}")]
        [SwaggerOperation(OperationId = "Update")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Update(string id, [FromBody] DrumMapDto dto)
        {
            var model = dto.ToModelObject();

            var isExist = await this._drumMapService.IsExist(x => x.Id == id);

            if (isExist == false)
            {
                return this.NotFound("drum map not found");
            }

            await this._drumMapService.Update(id, model);
            return this.NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        [SwaggerOperation(OperationId = "Delete")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Delete(string id)
        {
            var isExist = await this._drumMapService.IsExist(x => x.Id == id);

            if (isExist == false)
            {
                return this.NotFound("drum map not found");
            }

            await this._drumMapService.Delete(id);
            return this.NoContent();
        }

        [HttpGet("by-id/{id:length(24)}")]
        [SwaggerOperation(OperationId = "GetById")]
        [ProducesResponseType(typeof(Fingering), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Fingering>> GetById(string id)
        {
            var model = await this._drumMapService.GetBy(x => x.Id == id);

            if (model is null)
            {
                return this.NotFound("drum map not found");
            }

            return this.Ok(model);
        }

        [HttpGet("all/by-author")]
        [SwaggerOperation(OperationId = "GetAll")]
        [ProducesResponseType(typeof(List<DrumMap>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<DrumMap>>> GetAll()
        {
            var models = await this._drumMapService.GetAll();
            return this.Ok(models);
        }

    }
}