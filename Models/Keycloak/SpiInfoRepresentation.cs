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
  public class SpiInfoRepresentation {
    /// <summary>
    /// Gets or Sets Internal
    /// </summary>
    [DataMember(Name="internal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "internal")]
    public bool? Internal { get; set; }

    /// <summary>
    /// Gets or Sets Providers
    /// </summary>
    [DataMember(Name="providers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providers")]
    public Dictionary<string, Object> Providers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SpiInfoRepresentation {\n");
      sb.Append("  Internal: ").Append(Internal).Append("\n");
      sb.Append("  Providers: ").Append(Providers).Append("\n");
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
