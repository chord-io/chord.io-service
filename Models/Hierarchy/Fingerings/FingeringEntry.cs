using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy.Fingerings
{
    public class FingeringEntry
    {
        [Range(0, 1, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("position", Required = Required.Always)]
        public double Position { get; set; }

        [Range(0, 1, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("length", Required = Required.Always)]
        public double Length { get; set; }

        [Range(0, 127, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("pitch", Required = Required.Always)]
        public uint Pitch { get; set; }
    }
}
