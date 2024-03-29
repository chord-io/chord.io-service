﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text.Json.Serialization;
using Chord.IO.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy
{
    public class Project : ProjectData, IValidatableObject
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfDefault]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }
    }
}
