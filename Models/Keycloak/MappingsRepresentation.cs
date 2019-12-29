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
  public class MappingsRepresentation {
    /// <summary>
    /// Gets or Sets ClientMappings
    /// </summary>
    [DataMember(Name="clientMappings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientMappings")]
    public Dictionary<string, Object> ClientMappings { get; set; }

    /// <summary>
    /// Gets or Sets RealmMappings
    /// </summary>
    [DataMember(Name="realmMappings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "realmMappings")]
    public List<RoleRepresentation> RealmMappings { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MappingsRepresentation {\n");
      sb.Append("  ClientMappings: ").Append(ClientMappings).Append("\n");
      sb.Append("  RealmMappings: ").Append(RealmMappings).Append("\n");
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
