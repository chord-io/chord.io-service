using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy.Themes
{
    public class ThemeEntry
    {
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("index", Required = Required.Always)]
        public uint Index { get; set; }

        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("length", Required = Required.Always)]
        public ThemeLength Length { get; set; }
    }
}
