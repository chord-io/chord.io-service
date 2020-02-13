using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using Chord.IO.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy.Tracks
{
    public abstract class Track : IValidatableObject
    {
        [MinLength(5, ErrorMessage = "Value {0} require a minimum length of {1} character")]
        [MaxLength(30, ErrorMessage = "Value {0} require a maximum length of {1} character")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("color", Required = Required.Always)]
        public uint Color { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            var service = validationContext.GetService<ProjectService>();

            var count = service.CountBy(x => x.Tracks.Any(y => y.Name == this.Name)).Result;

            if (count == 1)
            {
                results.Add(new ValidationResult(
                    "track name must be unique", 
                    new[] { nameof(this.Name) }
                ));
            }

            return results;
        }
    }
}
