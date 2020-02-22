using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy.Sequences
{
    public abstract class Sequence
    {
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("length", Required = Required.Always)]
        public SequenceLength Length { get; set; }
    }
}
