using System.ComponentModel.DataAnnotations;
using Chord.IO.Service.Models.Hierarchy.Fingerings;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy.Sequences
{
    public class MidiSequence : Sequence
    {
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("fingering", Required = Required.Always)]
        public InnerFingering Fingering { get; set; }
    }
}
