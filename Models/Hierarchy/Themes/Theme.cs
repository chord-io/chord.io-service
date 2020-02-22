using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Chord.IO.Service.Models.Hierarchy.Sequences;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy.Themes
{
    public class Theme
    {
        [MinLength(5, ErrorMessage = "Value {0} require a minimum length of {1} character")]
        [MaxLength(30, ErrorMessage = "Value {0} require a maximum length of {1} character")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [MaxLength(50, ErrorMessage = "Value {0} require a maximum length of {1} sequences")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("sequences", Required = Required.Always)]
        public List<Sequence> Sequences { get; set; }
    }
}
