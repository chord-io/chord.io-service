using System.ComponentModel.DataAnnotations;
using Chord.IO.Service.Enums;
using Chord.IO.Service.Models;
using Chord.IO.Service.Models.Arithmetic;
using Newtonsoft.Json;

namespace Chord.IO.Service.Dto
{
    public class IntervalDto
    {
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("degree", Required = Required.Always)]
        public uint Degree { get; set; }

        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("semitones", Required = Required.Always)]
        public uint Semitones { get; set; }

        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("quality", Required = Required.Always)]
        public IntervalQuality Quality { get; set; }

        public Interval ToModelObject()
        {
            return new Interval(this.Degree, this.Semitones, this.Quality);
        }

        public static IntervalDto FromModelObject(Interval model)
        {
            return new IntervalDto
            {
                Degree = model.Degree,
                Semitones = model.Semitones,
                Quality = model.Quality
            };
        }
    }
}
