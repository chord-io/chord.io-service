using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Chord.IO.Service.Models;
using Chord.IO.Service.Models.Arithmetic;
using Newtonsoft.Json;

namespace Chord.IO.Service.Dto
{
    public class NoteDto : IValidatableObject
    {
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("key", Required = Required.Always)]
        public char Key { get; set; }

        [Range(-2, 8, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("picth", Required = Required.Always)]
        public int Pitch { get; set; }

        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("alteration", Required = Required.Always)]
        public int Alteration { get; set; }

        public Note ToModelObject()
        {
            return new Note(this.Key, this.Pitch, this.Alteration);
        }

        public static NoteDto FromModelObject(Note model)
        {
            return new NoteDto
            {
                Key = model.Key,
                Pitch = model.Pitch,
                Alteration = model.Alteration
            };
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            if (!Note.LookUpTable.Contains(this.Key))
            {
                results.Add(new ValidationResult("is not a valid note name", new[] { nameof(this.Key) }));
            }

            return results;
        }
    }
}
