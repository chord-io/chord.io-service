using Chord.IO.Service.Dto;
using Chord.IO.Service.Enums;
using Chord.IO.Service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Chord.IO.Service.Models.Arithmetic;
using Swashbuckle.AspNetCore;
using Swashbuckle.AspNetCore.Annotations;

namespace Chord.IO.Service.Controllers
{
    [Route("api/arithmetic/interval")]
    [ApiController]
    public class ArithmeticIntervalController : ControllerBase
    {
        #region Utils
        [HttpGet("look-up-table")]
        [SwaggerOperation(OperationId = "GetLookUpTable")]
        [ProducesResponseType(typeof(IReadOnlyDictionary<uint, IReadOnlyDictionary<uint, IntervalQuality>>),StatusCodes.Status200OK)]
        public async Task<ActionResult<IReadOnlyDictionary<uint, IReadOnlyDictionary<uint, IntervalQuality>>>> GetLookUpTable()
        {
            return await Task<ActionResult<IReadOnlyDictionary<uint, IReadOnlyDictionary<uint, IntervalQuality>>>>.Factory.StartNew(() => this.Ok(Interval.LookUpTable));
        }
        #endregion

        #region Creations
        [HttpPost("from-degree-and-quality")]
        [SwaggerOperation(OperationId = "FromDegreeAndQuality")]
        [ProducesResponseType(typeof(IntervalDto),StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IntervalDto>> FromDegreeAndQuality([FromBody] DegreeAndQualityIntervalDto dto)
        {
            return await Task<ActionResult<IntervalDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var interval = Interval.FromDegreeAndQuality(dto.Degree, dto.Quality);
                    return this.Ok(IntervalDto.FromModelObject(interval));
                }
                catch (ArgumentException exception)
                {
                    return this.BadRequest(this.ProcessArgumentException(exception, null));
                }
            });
        }

        [HttpPost("from-semitones-and-quality")]
        [SwaggerOperation(OperationId = "FromSemitonesAndQuality")]
        [ProducesResponseType(typeof(IntervalDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IntervalDto>> FromSemitonesAndQuality([FromBody] SemitonesAndQualityIntervalDto dto)
        {
            return await Task<ActionResult<IntervalDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var interval = Interval.FromSemitonesAndQuality(dto.Semitones, dto.Quality);
                    return this.Ok(IntervalDto.FromModelObject(interval));
                }
                catch (ArgumentException exception)
                {
                    return this.BadRequest(this.ProcessArgumentException(exception, null));
                }
            });
        }

        [HttpPost("from-degree-and-semitones")]
        [SwaggerOperation(OperationId = "FromDegreeAndSemitones")]
        [ProducesResponseType(typeof(IntervalDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IntervalDto>> FromDegreeAndSemitones([FromBody] DegreeAndSemitonesIntervalDto dto)
        {
            return await Task<ActionResult<IntervalDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var interval = Interval.FromDegreeAndSemitones(dto.Degree, dto.Semitones);
                    return this.Ok(IntervalDto.FromModelObject(interval));
                }
                catch (ArgumentException exception)
                {
                    return this.BadRequest(this.ProcessArgumentException(exception, null));
                }
            });
        }

        [HttpPost("from-notes")]
        [SwaggerOperation(OperationId = "FromNotes")]
        [ProducesResponseType(typeof(IntervalDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IntervalDto>> FromNotes([FromBody] NotePairDto dto)
        {
            return await Task<ActionResult<IntervalDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var interval = Interval.FromNotes(dto.A.ToModelObject(), dto.B.ToModelObject());
                    return this.Ok(IntervalDto.FromModelObject(interval));
                }
                catch (ArgumentException exception)
                {
                    return this.BadRequest(this.ProcessArgumentException(exception, null));
                }
            });
        }
        #endregion

        #region Representations
        [HttpPost("from-string/{interval}")]
        [SwaggerOperation(OperationId = "FromString")]
        [ProducesResponseType(typeof(IntervalDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IntervalDto>> FromString(string interval)
        {
            return await Task<ActionResult<IntervalDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var model = Interval.FromString(interval);
                    return this.Ok(IntervalDto.FromModelObject(model));
                }
                catch (ArgumentException exception)
                {
                    return this.BadRequest(this.ProcessArgumentException(exception, interval));
                }
            });
        }

        [HttpPost("to-string/{format}")]
        [SwaggerOperation(OperationId = "ToString")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<string>> ToString([FromBody] IntervalDto dto, IntervalFormat format)
        {
            return await Task<ActionResult<string>>.Factory.StartNew(() =>
            {
                try
                {
                    var interval = dto.ToModelObject();
                    var str = interval.ToString(format);
                    return this.Ok(str);
                }
                catch (ArgumentException exception)
                {
                    return this.BadRequest(this.ProcessArgumentException(exception, null));
                }
            });
        }
        #endregion

        #region Conversions
        [HttpPost("from-integral/{index}")]
        [SwaggerOperation(OperationId = "FromIntegral")]
        [ProducesResponseType(typeof(IntervalDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IntervalDto>> FromIntegral(uint index)
        {
            return await Task<ActionResult<IntervalDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var interval = Interval.FromIntegral(index);
                    return this.Ok(IntervalDto.FromModelObject(interval));
                }
                catch (ArgumentException exception)
                {
                    return this.BadRequest(this.ProcessArgumentException(exception, null));
                }
            });
        }

        [HttpPost("to-integral")]
        [SwaggerOperation(OperationId = "ToIntegral")]
        [ProducesResponseType(typeof(uint), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<uint>> ToIntegral([FromBody] IntervalDto dto)
        {
            return await Task<ActionResult<uint>>.Factory.StartNew(() =>
            {
                try
                {
                    var interval = dto.ToModelObject();
                    var index = interval.ToIntegral();
                    return this.Ok(index);
                }
                catch (ArgumentException exception)
                {
                    return this.BadRequest(this.ProcessArgumentException(exception, null));
                }
            });
        }
        #endregion

        #region Transformations
        [HttpPost("invert")]
        [SwaggerOperation(OperationId = "Invert")]
        [ProducesResponseType(typeof(IntervalDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IntervalDto>> Invert([FromBody] IntervalDto dto)
        {
            return await Task<ActionResult<IntervalDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var interval = dto.ToModelObject();
                    interval = interval.Invert();
                    return this.Ok(IntervalDto.FromModelObject(interval));
                }
                catch (ArgumentException exception)
                {
                    return this.BadRequest(this.ProcessArgumentException(exception, null));
                }
            });
        }

        [HttpPost("to-note/{root}")]
        [SwaggerOperation(OperationId = "ToNote")]
        [ProducesResponseType(typeof(NoteDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<NoteDto>> ToNote([FromBody] IntervalDto dto, string root)
        {
            return await Task<ActionResult<NoteDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var interval = dto.ToModelObject();
                    var note = interval.ToNote(Note.FromString(root));
                    return this.Ok(NoteDto.FromModelObject(note));
                }
                catch (ArgumentException exception)
                {
                    return this.BadRequest(this.ProcessArgumentException(exception, null));
                }
                catch (Exception exception)
                {
                    return this.BadRequest(exception.Message);
                }
            });
        }
        #endregion
    }
}