using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Chord.IO.Service.Dto
{
    public class UserDto
    {
        [EmailAddress(ErrorMessage = "Value {0} is not a valid email address")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("email", Required = Required.Always)]
        public string Email { get; set; }

        [MinLength(8, ErrorMessage = "Value {0} require a minimum length of {1} character")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("password", Required = Required.Always)]
        public string Password { get; set; }
    }
}
