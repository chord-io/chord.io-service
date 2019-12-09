﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy
{
    public class ProjectData
    {
        [MinLength(5, ErrorMessage = "Value {0} require a minimum length of {1} character")]
        [MaxLength(30, ErrorMessage = "Value {0} require a maximum length of {1} character")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [MinLength(24, ErrorMessage = "Value {0} require a minimum length of {1} character")]
        [MaxLength(24, ErrorMessage = "Value {0} require a maximum length of {1} character")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("author_id", Required = Required.Always)]
        public string AuthorId { get; set; }

        [Range(30, 360, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("tempo", Required = Required.Always)]
        public uint Tempo { get; set; }

        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("is_private", Required = Required.Always)]
        public bool IsPrivate { get; set; }

        [MaxLength(16, ErrorMessage = "Value {0} require a maximum length of {1} tracks")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("tracks", Required = Required.Always)]
        public List<Track> Tracks { get; set; }

        [MaxLength(50, ErrorMessage = "Value {0} require a maximum length of {1} themes")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("themes", Required = Required.Always)]
        public List<Theme> Themes { get; set; }
    }
}
