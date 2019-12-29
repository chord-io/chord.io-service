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
  public class ClientMappingsRepresentation {
    /// <summary>
    /// Gets or Sets Client
    /// </summary>
    [DataMember(Name="client", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client")]
    public string Client { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Mappings
    /// </summary>
    [DataMember(Name="mappings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mappings")]
    public List<RoleRepresentation> Mappings { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClientMappingsRepresentation {\n");
      sb.Append("  Client: ").Append(Client).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Mappings: ").Append(Mappings).Append("\n");
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
