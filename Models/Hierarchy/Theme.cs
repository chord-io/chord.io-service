﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Chord.IO.Service.Models.Hierarchy.Sequences;
using Chord.IO.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy
{
    public class Theme : IValidatableObject
    {
        public static readonly string NonUniqueRelationKeyword = "non-unique-relation";

        [MinLength(5, ErrorMessage = "Value {0} require a minimum length of {1} character")]
        [MaxLength(30, ErrorMessage = "Value {0} require a maximum length of {1} character")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("track_index", Required = Required.Always)]
        public int TrackIndex { get; set; }

        [MaxLength(50, ErrorMessage = "Value {0} require a maximum length of {1} sequences")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("sequences", Required = Required.Always)]
        public List<Sequence> Sequences { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            var service = validationContext.GetService<ProjectService>();

            var count = service.CountBy(x => x.Themes.Any(y => y.Name == this.Name && y.TrackIndex == this.TrackIndex)).Result;

            if (count == 1)
            {
                results.Add(new ValidationResult(
                    "relation between a track and a theme must be unique",
                    new[] { NonUniqueRelationKeyword }
                ));
            }

            return results;
        }
    }
}
