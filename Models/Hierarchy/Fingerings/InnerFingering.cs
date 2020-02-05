using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy.Fingerings
{
    public class InnerFingering
    {
        [MaxLength(50, ErrorMessage = "Value {0} require a maximum length of {1} entries")]
        public List<FingeringEntry> Entries { get; set; }
    }
}
