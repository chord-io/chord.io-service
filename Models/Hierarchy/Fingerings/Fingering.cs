using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Chord.IO.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy.Fingerings
{
    public class Fingering : FingeringData
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfDefault]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }
    }
}
