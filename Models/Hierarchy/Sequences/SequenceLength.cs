using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy.Sequences
{
    public class SequenceLength : IValidatableObject
    {
        [Range(0, uint.MaxValue, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("bar", Required = Required.Always)]
        public uint Bar { get; set; }

        [Range(0, 1, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("start", Required = Required.Always)]
        public double Start { get; set; }

        [Range(0, 1, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("end", Required = Required.Always)]
        public double End { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            if (this.Start >= this.End)
            {
                results.Add(new ValidationResult(
                    "start position cannot be equal or greater than end position", 
                    new[] { nameof(this.Start), nameof(this.End)}
                ));
            }

            return results;
        }
    }
}
