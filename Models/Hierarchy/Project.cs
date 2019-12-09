using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy
{
    public class Project : ProjectData, IValidatableObject
    {
        public static readonly string DuplicateEntryKeyword = "duplicate-entry";

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            var duplicateTracks = this.Tracks
                .GroupBy(x => x.Name)
                .Where(x => x.Count() > 1)
                .Select(x => x.Key)
                .ToList();

            if (duplicateTracks.Count > 0)
            {
                results.AddRange(duplicateTracks.Select(entry => new ValidationResult(entry, new[] {$"{nameof(this.Tracks)}.{DuplicateEntryKeyword}"})));
            }

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
