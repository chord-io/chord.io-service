using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.User
{
    public class User
    {
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [MinLength(5, ErrorMessage = "Value {0} require a minimum length of {1} character")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("username", Required = Required.Always)]
        public string Username { get; set; }

        [EmailAddress(ErrorMessage = "Value {0} is not a valid email address")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("email", Required = Required.Always)]
        public string Email { get; set; }
    }
}
