using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy
{
    public class Theme
    {
        [MinLength(5, ErrorMessage = "Value {0} require a minimum length of {1} character")]
        [MaxLength(30, ErrorMessage = "Value {0} require a maximum length of {1} character")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [MaxLength(50, ErrorMessage = "Value {0} require a maximum length of {1} chords")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("chords", Required = Required.Always)]
        public List<Chord> Chords { get; set; }
    }
}
