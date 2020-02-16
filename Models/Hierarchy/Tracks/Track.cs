using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using Chord.IO.Service.Services;
using JsonSubTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy.Tracks
{
    [JsonConverter(typeof(JsonSubtypes))]
    [JsonSubtypes.KnownSubTypeWithProperty(typeof(MidiTrack), nameof(MidiTrack.Channel))]
    [JsonSubtypes.KnownSubTypeWithProperty(typeof(DrumTrack), nameof(DrumTrack.DrumMapId))]
    public abstract class Track : IValidatableObject
    {
        [MinLength(5, ErrorMessage = "Value {0} require a minimum length of {1} character")]
        [MaxLength(30, ErrorMessage = "Value {0} require a maximum length of {1} character")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("color", Required = Required.Always)]
        public int Color { get; set; }
    }
}
