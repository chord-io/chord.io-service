﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Chord.IO.Service.Models.Hierarchy.Sequences;
using Chord.IO.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy
{
    public class Theme
    {
        public static readonly string NonUniqueRelationKeyword = "non-unique-relation";

        [MinLength(5, ErrorMessage = "Value {0} require a minimum length of {1} character")]
        [MaxLength(30, ErrorMessage = "Value {0} require a maximum length of {1} character")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("length", Required = Required.AllowNull)]
        public ThemeLength Length { get; set; }

        [MaxLength(50, ErrorMessage = "Value {0} require a maximum length of {1} sequences")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("sequences", Required = Required.Always)]
        public List<Sequence> Sequences { get; set; }
    }
}
