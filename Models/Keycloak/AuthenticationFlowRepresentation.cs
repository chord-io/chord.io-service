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
  public class AuthenticationFlowRepresentation {
    /// <summary>
    /// Gets or Sets Alias
    /// </summary>
    [DataMember(Name="alias", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alias")]
    public string Alias { get; set; }

    /// <summary>
    /// Gets or Sets AuthenticationExecutions
    /// </summary>
    [DataMember(Name="authenticationExecutions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticationExecutions")]
    public List<AuthenticationExecutionExportRepresentation> AuthenticationExecutions { get; set; }

    /// <summary>
    /// Gets or Sets BuiltIn
    /// </summary>
    [DataMember(Name="builtIn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "builtIn")]
    public bool? BuiltIn { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets ProviderId
    /// </summary>
    [DataMember(Name="providerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerId")]
    public string ProviderId { get; set; }

    /// <summary>
    /// Gets or Sets TopLevel
    /// </summary>
    [DataMember(Name="topLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "topLevel")]
    public bool? TopLevel { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthenticationFlowRepresentation {\n");
      sb.Append("  Alias: ").Append(Alias).Append("\n");
      sb.Append("  AuthenticationExecutions: ").Append(AuthenticationExecutions).Append("\n");
      sb.Append("  BuiltIn: ").Append(BuiltIn).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
      sb.Append("  TopLevel: ").Append(TopLevel).Append("\n");
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
