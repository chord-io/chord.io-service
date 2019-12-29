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
  public class UserFederationMapperRepresentation {
    /// <summary>
    /// Gets or Sets Config
    /// </summary>
    [DataMember(Name="config", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "config")]
    public Dictionary<string, Object> Config { get; set; }

    /// <summary>
    /// Gets or Sets FederationMapperType
    /// </summary>
    [DataMember(Name="federationMapperType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "federationMapperType")]
    public string FederationMapperType { get; set; }

    /// <summary>
    /// Gets or Sets FederationProviderDisplayName
    /// </summary>
    [DataMember(Name="federationProviderDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "federationProviderDisplayName")]
    public string FederationProviderDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserFederationMapperRepresentation {\n");
      sb.Append("  Config: ").Append(Config).Append("\n");
      sb.Append("  FederationMapperType: ").Append(FederationMapperType).Append("\n");
      sb.Append("  FederationProviderDisplayName: ").Append(FederationProviderDisplayName).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
