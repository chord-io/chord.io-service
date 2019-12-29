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
  public class AuthenticationExecutionInfoRepresentation {
    /// <summary>
    /// Gets or Sets Alias
    /// </summary>
    [DataMember(Name="alias", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alias")]
    public string Alias { get; set; }

    /// <summary>
    /// Gets or Sets AuthenticationConfig
    /// </summary>
    [DataMember(Name="authenticationConfig", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticationConfig")]
    public string AuthenticationConfig { get; set; }

    /// <summary>
    /// Gets or Sets AuthenticationFlow
    /// </summary>
    [DataMember(Name="authenticationFlow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticationFlow")]
    public bool? AuthenticationFlow { get; set; }

    /// <summary>
    /// Gets or Sets Configurable
    /// </summary>
    [DataMember(Name="configurable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configurable")]
    public bool? Configurable { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets FlowId
    /// </summary>
    [DataMember(Name="flowId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "flowId")]
    public string FlowId { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Index
    /// </summary>
    [DataMember(Name="index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "index")]
    public int? Index { get; set; }

    /// <summary>
    /// Gets or Sets Level
    /// </summary>
    [DataMember(Name="level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "level")]
    public int? Level { get; set; }

    /// <summary>
    /// Gets or Sets ProviderId
    /// </summary>
    [DataMember(Name="providerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerId")]
    public string ProviderId { get; set; }

    /// <summary>
    /// Gets or Sets Requirement
    /// </summary>
    [DataMember(Name="requirement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requirement")]
    public string Requirement { get; set; }

    /// <summary>
    /// Gets or Sets RequirementChoices
    /// </summary>
    [DataMember(Name="requirementChoices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requirementChoices")]
    public List<string> RequirementChoices { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthenticationExecutionInfoRepresentation {\n");
      sb.Append("  Alias: ").Append(Alias).Append("\n");
      sb.Append("  AuthenticationConfig: ").Append(AuthenticationConfig).Append("\n");
      sb.Append("  AuthenticationFlow: ").Append(AuthenticationFlow).Append("\n");
      sb.Append("  Configurable: ").Append(Configurable).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  FlowId: ").Append(FlowId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Index: ").Append(Index).Append("\n");
      sb.Append("  Level: ").Append(Level).Append("\n");
      sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
      sb.Append("  Requirement: ").Append(Requirement).Append("\n");
      sb.Append("  RequirementChoices: ").Append(RequirementChoices).Append("\n");
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
