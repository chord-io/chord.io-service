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
  public class IdentityProviderRepresentation {
    /// <summary>
    /// Gets or Sets AddReadTokenRoleOnCreate
    /// </summary>
    [DataMember(Name="addReadTokenRoleOnCreate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addReadTokenRoleOnCreate")]
    public bool? AddReadTokenRoleOnCreate { get; set; }

    /// <summary>
    /// Gets or Sets Alias
    /// </summary>
    [DataMember(Name="alias", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alias")]
    public string Alias { get; set; }

    /// <summary>
    /// Gets or Sets Config
    /// </summary>
    [DataMember(Name="config", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "config")]
    public Dictionary<string, Object> Config { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets FirstBrokerLoginFlowAlias
    /// </summary>
    [DataMember(Name="firstBrokerLoginFlowAlias", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstBrokerLoginFlowAlias")]
    public string FirstBrokerLoginFlowAlias { get; set; }

    /// <summary>
    /// Gets or Sets InternalId
    /// </summary>
    [DataMember(Name="internalId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "internalId")]
    public string InternalId { get; set; }

    /// <summary>
    /// Gets or Sets LinkOnly
    /// </summary>
    [DataMember(Name="linkOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkOnly")]
    public bool? LinkOnly { get; set; }

    /// <summary>
    /// Gets or Sets PostBrokerLoginFlowAlias
    /// </summary>
    [DataMember(Name="postBrokerLoginFlowAlias", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postBrokerLoginFlowAlias")]
    public string PostBrokerLoginFlowAlias { get; set; }

    /// <summary>
    /// Gets or Sets ProviderId
    /// </summary>
    [DataMember(Name="providerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerId")]
    public string ProviderId { get; set; }

    /// <summary>
    /// Gets or Sets StoreToken
    /// </summary>
    [DataMember(Name="storeToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storeToken")]
    public bool? StoreToken { get; set; }

    /// <summary>
    /// Gets or Sets TrustEmail
    /// </summary>
    [DataMember(Name="trustEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trustEmail")]
    public bool? TrustEmail { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IdentityProviderRepresentation {\n");
      sb.Append("  AddReadTokenRoleOnCreate: ").Append(AddReadTokenRoleOnCreate).Append("\n");
      sb.Append("  Alias: ").Append(Alias).Append("\n");
      sb.Append("  Config: ").Append(Config).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  FirstBrokerLoginFlowAlias: ").Append(FirstBrokerLoginFlowAlias).Append("\n");
      sb.Append("  InternalId: ").Append(InternalId).Append("\n");
      sb.Append("  LinkOnly: ").Append(LinkOnly).Append("\n");
      sb.Append("  PostBrokerLoginFlowAlias: ").Append(PostBrokerLoginFlowAlias).Append("\n");
      sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
      sb.Append("  StoreToken: ").Append(StoreToken).Append("\n");
      sb.Append("  TrustEmail: ").Append(TrustEmail).Append("\n");
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
