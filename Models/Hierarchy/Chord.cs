using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Chord.IO.Service.Models.Arithmetic;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy
{
    public class Chord : IValidatableObject
    {
        [Range(0, 127, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("root", Required = Required.Always)]
        public uint Root { get; set; }

        [MaxLength(25, ErrorMessage = "Value {0} require a maximum length of {1} intervals")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("intervals", Required = Required.Always)]
        public List<string> Intervals { get; set; }

        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("length", Required = Required.Always)]
        public ChordLength Length { get; set; }

        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("fingering", Required = Required.Always)]
        public Fingering Fingering { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            var intervals = new List<Interval>();

            foreach (var interval in this.Intervals)
            {
                try
                {
                    intervals.Add(Interval.FromString(interval));
                }
                catch (Exception exception) when (exception is ArgumentException || exception is InvalidOperationException)
                {
                    results.Add(new ValidationResult(exception.Message, new[] { interval }));
                }
            }
            
            var inputIntervals = intervals
                .Select(x => x.ToIntegral())
                .ToList();
            var expectedIntervals = new List<uint>(inputIntervals).OrderBy(x => x);

            if (!expectedIntervals.SequenceEqual(inputIntervals))
            {
                results.Add(new ValidationResult("must be ordered", new[] { nameof(this.Intervals) }));
            }

            return results;
        }
    }
}
