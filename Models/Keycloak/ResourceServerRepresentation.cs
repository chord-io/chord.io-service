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
  public class ResourceServerRepresentation {
    /// <summary>
    /// Gets or Sets AllowRemoteResourceManagement
    /// </summary>
    [DataMember(Name="allowRemoteResourceManagement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowRemoteResourceManagement")]
    public bool? AllowRemoteResourceManagement { get; set; }

    /// <summary>
    /// Gets or Sets ClientId
    /// </summary>
    [DataMember(Name="clientId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientId")]
    public string ClientId { get; set; }

    /// <summary>
    /// Gets or Sets DecisionStrategy
    /// </summary>
    [DataMember(Name="decisionStrategy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "decisionStrategy")]
    public string DecisionStrategy { get; set; }

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
    /// Gets or Sets Policies
    /// </summary>
    [DataMember(Name="policies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "policies")]
    public List<PolicyRepresentation> Policies { get; set; }

    /// <summary>
    /// Gets or Sets PolicyEnforcementMode
    /// </summary>
    [DataMember(Name="policyEnforcementMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "policyEnforcementMode")]
    public string PolicyEnforcementMode { get; set; }

    /// <summary>
    /// Gets or Sets Resources
    /// </summary>
    [DataMember(Name="resources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resources")]
    public List<ResourceRepresentation> Resources { get; set; }

    /// <summary>
    /// Gets or Sets Scopes
    /// </summary>
    [DataMember(Name="scopes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scopes")]
    public List<ScopeRepresentation> Scopes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResourceServerRepresentation {\n");
      sb.Append("  AllowRemoteResourceManagement: ").Append(AllowRemoteResourceManagement).Append("\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  DecisionStrategy: ").Append(DecisionStrategy).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Policies: ").Append(Policies).Append("\n");
      sb.Append("  PolicyEnforcementMode: ").Append(PolicyEnforcementMode).Append("\n");
      sb.Append("  Resources: ").Append(Resources).Append("\n");
      sb.Append("  Scopes: ").Append(Scopes).Append("\n");
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
