using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Chord.IO.Service.Dto
{
    public class NotePairDto
    {
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("a", Required = Required.Always)]
        public NoteDto A { get; set; }

        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("b", Required = Required.Always)]
        public NoteDto B { get; set; }
    }
}
