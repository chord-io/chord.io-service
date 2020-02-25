using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using Chord.IO.Service.Models.Hierarchy.Themes;
using Chord.IO.Service.Services;
using JsonSubTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy.Tracks
{
    [JsonConverter(typeof(JsonSubtypes))]
    [JsonSubtypes.KnownSubTypeWithProperty(typeof(MidiTrack), nameof(MidiTrack.Channel))]
    [JsonSubtypes.KnownSubTypeWithProperty(typeof(DrumTrack), nameof(DrumTrack.DrumMapId))]
    [BsonKnownTypes(typeof(MidiTrack))]
    [BsonKnownTypes(typeof(DrumTrack))]
    public abstract class Track : IValidatableObject
    {
        [MinLength(3, ErrorMessage = "Value {0} require a minimum length of {1} character")]
        [MaxLength(30, ErrorMessage = "Value {0} require a maximum length of {1} character")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("color", Required = Required.Always)]
        public int Color { get; set; }

        [MaxLength(50, ErrorMessage = "Value {0} require a maximum length of {1} themes")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("themes", Required = Required.Always)]
        public List<Theme> Themes { get; set; }

        [MaxLength(50, ErrorMessage = "Value {0} require a maximum length of {1} themes")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("entries", Required = Required.Always)]
        public List<ThemeEntry> Entries { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            var isThemeNameUnique = this.Themes
                .GroupBy(x => x.Name)
                .Any(x => x.Count() > 1);

            if (isThemeNameUnique)
            {
                results.Add(new ValidationResult(
                    "name must be unique",
                    new[] { nameof(Theme.Name) }
                ));
            }

            var isThemesNotExist = this.Entries.Any(x => x.Index >= this.Themes.Count);

            if (isThemesNotExist)
            {
                results.Add(new ValidationResult("theme entries must be has a valid index", new[] { nameof(ThemeEntry.Index) }));
            }

            return results;
        }
    }
}
