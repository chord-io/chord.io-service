using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Chord.IO.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy.Tracks
{
    public class DrumTrack : MidiTrack, IValidatableObject
    {
        [StringLength(24, ErrorMessage = "Value {0} require a length of {1} character")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("drum_map", Required = Required.Always)]
        public string DrumMapId { get; set; }

        public new IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = base.Validate(validationContext).ToList();
            var service = validationContext.GetService<DrumMapService>();

            var count = service.CountBy(x => x.Id == this.DrumMapId).Result;

            if (count == 0)
            {
                results.Add(new ValidationResult(
                    "drum map must be exist",
                    new[] { nameof(this.DrumMapId) }
                ));
            }

            if (this.Channel != 10)
            {
                results.Add(new ValidationResult(
                    "drum track channel must be set to 10",
                    new[] { nameof(this.Name) }
                ));
            }

            return results;
        }
    }
}
