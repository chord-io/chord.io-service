using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class KeysMetadataRepresentation {
    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public Dictionary<string, Object> Active { get; set; }

    /// <summary>
    /// Gets or Sets Keys
    /// </summary>
    [DataMember(Name="keys", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "keys")]
    public List<KeysMetadataRepresentationKeyMetadataRepresentation> Keys { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class KeysMetadataRepresentation {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  Keys: ").Append(Keys).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
