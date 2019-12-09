using System;
using System.Threading.Tasks;
using Chord.IO.Service.Dto;
using Chord.IO.Service.Models;
using Chord.IO.Service.Models.Arithmetic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chord.IO.Service.Controllers
{
    [Route("api/arithmetic/note")]
    [ApiController]
    public class ArithmeticNoteController : ControllerBase
    {
        #region Creations
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<NoteDto>> Create([FromBody] NoteDto dto)
        {
            return await Task<ActionResult<NoteDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var note = dto.ToModelObject();
                    return this.Ok(NoteDto.FromModelObject(note));
                }
                catch (ArgumentException exception)
                {
                    return this.BadRequest(this.ProcessArgumentException(exception, null));
                }
            });
        }
        #endregion

        #region Representations
        [HttpPost("from-string/{note}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<NoteDto>> FromString(string note)
        {
            return await Task<ActionResult<NoteDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var model = Note.FromString(note);
                    return this.Ok(NoteDto.FromModelObject(model));
                }
                catch (ArgumentException exception)
                {
                    return this.BadRequest(this.ProcessArgumentException(exception, null));
                }
            });
        }

        [HttpPost("to-string")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<string>> ToString([FromBody] NoteDto dto)
        {
            return await Task<ActionResult<string>>.Factory.StartNew(() =>
            {
                try
                {
                    var note = dto.ToModelObject();
                    var str = note.ToString();
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
        [HttpPost("from-midi/{index}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<NoteDto>> FromMidi(uint index)
        {
            return await Task<ActionResult<NoteDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var note = Note.FromMidi(index);
                    return this.Ok(NoteDto.FromModelObject(note));
                }
                catch (ArgumentException exception)
                {
                    return this.BadRequest(this.ProcessArgumentException(exception, nameof(index)));
                }
            });
        }

        [HttpPost("to-midi")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<uint>> ToMidi([FromBody] NoteDto dto)
        {
            return await Task<ActionResult<uint>>.Factory.StartNew(() =>
            {
                try
                {
                    var note = dto.ToModelObject();
                    var index = note.ToMidi();
                    return this.Ok(index);
                }
                catch (ArgumentException exception)
                {
                    return this.BadRequest(this.ProcessArgumentException(exception, null));
                }
            });
        }

        [HttpPost("from-integral/{index}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<NoteDto>> FromIntegral(uint index)
        {
            return await Task<ActionResult<NoteDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var note = Note.FromIntegral(index);
                    return this.Ok(NoteDto.FromModelObject(note));
                }
                catch (ArgumentException exception)
                {
                    return this.BadRequest(this.ProcessArgumentException(exception, nameof(index)));
                }
            });
        }

        [HttpPost("to-integral")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<uint>> ToIntegral([FromBody] NoteDto dto)
        {
            return await Task<ActionResult<uint>>.Factory.StartNew(() =>
            {
                try
                {
                    var note = dto.ToModelObject();
                    var index = note.ToIntegral();
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
        [HttpPost("interval/{degree}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<NoteDto>> GetInterval([FromBody] NoteDto dto, uint degree)
        {
            return await Task<ActionResult<NoteDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var note = dto.ToModelObject();
                    note = note.GetInterval(degree);
                    return this.Ok(NoteDto.FromModelObject(note));
                }
                catch (ArgumentException exception)
                {
                    return this.BadRequest(this.ProcessArgumentException(exception, nameof(degree)));
                }
            });
        }

        [HttpPost("shift/to-right/{distance}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<NoteDto>> ShiftToRight([FromBody] NoteDto dto, uint distance)
        {
            return await Task<ActionResult<NoteDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var note = dto.ToModelObject();
                    note = note.ShiftToRight(distance);
                    return this.Ok(NoteDto.FromModelObject(note));
                }
                catch (ArgumentException exception)
                {
                    return this.BadRequest(this.ProcessArgumentException(exception, nameof(distance)));
                }
            });
        }

        [HttpPost("shift/to-left/{distance}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<NoteDto>> ShiftToLeft([FromBody] NoteDto dto, uint distance)
        {
            return await Task<ActionResult<NoteDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var note = dto.ToModelObject();
                    note = note.ShiftToLeft(distance);
                    return this.Ok(NoteDto.FromModelObject(note));
                }
                catch (ArgumentException exception)
                {
                    return this.BadRequest(this.ProcessArgumentException(exception, nameof(distance)));
                }
            });
        }

        [HttpPost("alter/upward/{semitones}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<NoteDto>> AlterUpward([FromBody] NoteDto dto, int semitones)
        {
            return await Task<ActionResult<NoteDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var note = dto.ToModelObject();
                    note = note.AlterUpward(semitones);
                    return this.Ok(NoteDto.FromModelObject(note));
                }
                catch (ArgumentException exception)
                {
                    return this.BadRequest(this.ProcessArgumentException(exception, nameof(semitones)));
                }
            });
        }

        [HttpPost("alter/downward/{semitones}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<NoteDto>> AlterDownward([FromBody] NoteDto dto, int semitones)
        {
            return await Task<ActionResult<NoteDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var note = dto.ToModelObject();
                    note = note.AlterDownward(semitones);
                    return this.Ok(NoteDto.FromModelObject(note));
                }
                catch (ArgumentException exception)
                {
                    return this.BadRequest(this.ProcessArgumentException(exception, nameof(semitones)));
                }
            });
        }

        [HttpPost("simplify")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<NoteDto>> Simplify([FromBody] NoteDto dto)
        {
            return await Task<ActionResult<NoteDto>>.Factory.StartNew(() =>
            {
                try
                {
                    var note = dto.ToModelObject();
                    note = note.Simplify();
                    return this.Ok(NoteDto.FromModelObject(note));
                }
                catch (ArithmeticException exception)
                {
                    return this.BadRequest(exception.Message);
                }
            });
        }
        #endregion
    }
}