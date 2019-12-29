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
  public class ScopeMappingRepresentation {
    /// <summary>
    /// Gets or Sets Client
    /// </summary>
    [DataMember(Name="client", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client")]
    public string Client { get; set; }

    /// <summary>
    /// Gets or Sets ClientScope
    /// </summary>
    [DataMember(Name="clientScope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientScope")]
    public string ClientScope { get; set; }

    /// <summary>
    /// Gets or Sets Roles
    /// </summary>
    [DataMember(Name="roles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roles")]
    public List<string> Roles { get; set; }

    /// <summary>
    /// Gets or Sets Self
    /// </summary>
    [DataMember(Name="self", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "self")]
    public string Self { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ScopeMappingRepresentation {\n");
      sb.Append("  Client: ").Append(Client).Append("\n");
      sb.Append("  ClientScope: ").Append(ClientScope).Append("\n");
      sb.Append("  Roles: ").Append(Roles).Append("\n");
      sb.Append("  Self: ").Append(Self).Append("\n");
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
