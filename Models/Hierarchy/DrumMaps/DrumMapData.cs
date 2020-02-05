using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Chord.IO.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy.DrumMaps
{
    public class DrumMapData : IValidatableObject
    {
        [MinLength(5, ErrorMessage = "Value {0} require a minimum length of {1} character")]
        [MaxLength(30, ErrorMessage = "Value {0} require a maximum length of {1} character")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("map", Required = Required.Always)]
        public Dictionary<uint, string> Map { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            var service = validationContext.GetService<DrumMapService>();
            var httpContext = validationContext.GetService<IHttpContextAccessor>().HttpContext;

            var isExist = service.IsExist(x => x.Name == this.Name).Result;

            if (isExist == true && httpContext.Request.Method == HttpMethods.Post)
            {
                results.Add(new ValidationResult(
                    "drum map name must be unique",
                    new[] { nameof(this.Name) }
                ));
            }

            var pitchs = this.Map.Keys
                .Distinct()
                .Where(x => x > 127)
                .ToList();

            if (pitchs.Count > 0)
            {
                results.Add(new ValidationResult(
                    "drum map key must be between 0 and 127",
                    new[] { nameof(this.Map) }
                ));
            }

            return results;
        }
    }
}
