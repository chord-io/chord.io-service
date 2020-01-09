using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy
{
    public class Track : IValidatableObject
    {
        public static readonly string DuplicateEntryKeyword = "duplicate-entry";

        [MinLength(5, ErrorMessage = "Value {0} require a minimum length of {1} character")]
        [MaxLength(30, ErrorMessage = "Value {0} require a maximum length of {1} character")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [Range(1, 16, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("channel", Required = Required.Always)]
        public uint Channel { get; set; }

        [MaxLength(50, ErrorMessage = "Value {0} require a maximum length of {1} themes")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("themes", Required = Required.Always)]
        public List<Theme> Themes { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            var duplicatesThemes = this.Themes
                .GroupBy(x => x.Name)
                .Where(x => x.Count() > 1)
                .Select(x => x.Key)
                .ToList();

            if (duplicatesThemes.Count > 0)
            {
                results.AddRange(duplicatesThemes.Select(entry => new ValidationResult(entry, new[] { $"{nameof(this.Themes)}.{DuplicateEntryKeyword}" })));
            }

            return results;
        }
    }
}
