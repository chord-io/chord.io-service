using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Chord.IO.Service.Dto
{
    public class SignInDto
    {
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("username", Required = Required.Always)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("password", Required = Required.Always)]
        public string Password { get; set; }
    }
}
