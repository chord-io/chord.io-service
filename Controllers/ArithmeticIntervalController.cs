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
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IReadOnlyDictionary<uint, IReadOnlyDictionary<uint, IntervalQuality>>>> GetLookUpTable()
        {
            return await Task<ActionResult<IReadOnlyDictionary<uint, IReadOnlyDictionary<uint, IntervalQuality>>>>.Factory.StartNew(() => this.Ok(Interval.LookUpTable));
        }
        #endregion

        #region Creations
        [HttpPost("from-degree-and-quality")]
        [SwaggerOperation(OperationId = "FromDegreeAndQuality")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IntervalDto>> FromDegreeAndQuality([FromBody] IntervalDto dto)
        {
            return await Task<ActionResult<IntervalDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var interval = Interval.FromDegreeAndQuality(dto.Degree, dto.Quality);
                    return this.Ok(IntervalDto.FromModelObject(interval));
                }
                catch (Exception exception)
                {
                    return this.BadRequest(exception.Message);
                }
            });
        }

        [HttpPost("from-semitones-and-quality")]
        [SwaggerOperation(OperationId = "FromSemitonesAndQuality")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IntervalDto>> FromSemitonesAndQuality([FromBody] IntervalDto dto)
        {
            return await Task<ActionResult<IntervalDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var interval = Interval.FromSemitonesAndQuality(dto.Semitones, dto.Quality);
                    return this.Ok(IntervalDto.FromModelObject(interval));
                }
                catch (Exception exception)
                {
                    return this.BadRequest(exception.Message);
                }
            });
        }

        [HttpPost("from-degree-and-semitones")]
        [SwaggerOperation(OperationId = "FromDegreeAndSemitones")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IntervalDto>> FromDegreeAndSemitones([FromBody] IntervalDto dto)
        {
            return await Task<ActionResult<IntervalDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var interval = Interval.FromDegreeAndSemitones(dto.Degree, dto.Semitones);
                    return this.Ok(IntervalDto.FromModelObject(interval));
                }
                catch (Exception exception)
                {
                    return this.BadRequest(exception.Message);
                }
            });
        }

        [HttpPost("from-notes")]
        [SwaggerOperation(OperationId = "FromNotes")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IntervalDto>> FromNotes([FromBody] NotePairDto dto)
        {
            return await Task<ActionResult<IntervalDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var interval = Interval.FromNotes(dto.A.ToModelObject(), dto.B.ToModelObject());
                    return this.Ok(IntervalDto.FromModelObject(interval));
                }
                catch (Exception exception)
                {
                    return this.BadRequest(exception.Message);
                }
            });
        }
        #endregion

        #region Representations
        [HttpPost("from-string/{interval}")]
        [SwaggerOperation(OperationId = "FromString")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
                    return this.BadRequest(this.ProcessArgumentException(exception, null));
                }
            });
        }

        [HttpPost("to-string/{format}")]
        [SwaggerOperation(OperationId = "ToString")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<string>> ToString([FromBody] IntervalDto dto, IntervalFormat format)
        {
            return await Task<ActionResult<string>>.Factory.StartNew(() =>
            {
                try
                {
                    var Interval = dto.ToModelObject();
                    var str = Interval.ToString(format);
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
                    return this.BadRequest(this.ProcessArgumentException(exception, nameof(index)));
                }
            });
        }

        [HttpPost("to-integral")]
        [SwaggerOperation(OperationId = "ToIntegral")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
                catch (Exception exception)
                {
                    return this.BadRequest(exception.Message);
                }
            });
        }

        [HttpPost("to-note/{root}")]
        [SwaggerOperation(OperationId = "ToNote")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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