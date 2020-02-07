using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Chord.IO.Service.Enums;
using Chord.IO.Service.Services;
using Chord.IO.Service.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy.Fingerings
{
    public class FingeringData : IValidatableObject
    {
        [JsonIgnore]
        public string AuthorId { get; set; }

        [JsonProperty("edited_from", Required = Required.AllowNull)]
        public string EditedFrom { get; set; }

        [MinLength(5, ErrorMessage = "Value {0} require a minimum length of {1} character")]
        [MaxLength(30, ErrorMessage = "Value {0} require a maximum length of {1} character")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("type", Required = Required.Always)]
        public FingeringType Type { get; set; }

        [MaxLength(10, ErrorMessage = "Value {0} require a maximum length of {1} tags")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("tags", Required = Required.Always)]
        public List<string> Tags { get; set; }

        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("evaluations", Required = Required.Always)]
        public Dictionary<string, uint> Evaluations { get; set; }

        [MaxLength(50, ErrorMessage = "Value {0} require a maximum length of {1} entries")]
        [JsonProperty("entries", Required = Required.Always)]
        public List<FingeringEntry> Entries { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            var service = validationContext.GetService<FingeringService>();
            var httpContext = validationContext.GetService<IHttpContextAccessor>().HttpContext;

            var isExist = service.IsExist(x => x.Name == this.Name).Result;

            if (isExist == true && httpContext.Request.Method == HttpMethods.Post)
            {
                results.Add(new ValidationResult(
                    "fingering name must be unique",
                    new[] { nameof(this.Name) }
                ));
            }

            var isEvaluationInRange = this.Evaluations
                .Where(x => x.Value > 10)
                .ToList();

            if (isEvaluationInRange.Count > 0)
            {
                results.Add(new ValidationResult(
                    "evaluation must be between 0 and 10",
                    new[] { nameof(this.Evaluations) }
                ));
            }

            var isEvaluatedOnce = this.Evaluations
                .GroupBy(x => x.Key)
                .Where(x => x.Count() > 1)
                .ToList();

            if (isEvaluatedOnce.Count > 0)
            {
                results.Add(new ValidationResult(
                    "user cannot evaluate a fingering twice",
                    new[] { nameof(this.Evaluations) }
                ));
            }

            if (this.EditedFrom != null)
            {
                var isExistEditedFrom = service.IsExist(x => x.Id == this.EditedFrom).Result;

                if (isExistEditedFrom == false)
                {
                    results.Add(new ValidationResult(
                        "commit a new version of a fingering must reference a previous fingering",
                        new[] { nameof(this.EditedFrom) }
                    ));
                }
            }

            var positions = this.Entries
                .Select(x => x.Position)
                .ToList();
            var expectedPositions = new List<double>(positions).OrderBy(x => x);

            if (!expectedPositions.SequenceEqual(positions))
            {
                results.Add(new ValidationResult(
                    "entries positions must be ordered",
                    new[] { nameof(this.Entries) }
                ));
            }

            return results;
        }
    }
}
