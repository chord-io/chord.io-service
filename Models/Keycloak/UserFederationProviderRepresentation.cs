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
  public class UserFederationProviderRepresentation {
    /// <summary>
    /// Gets or Sets ChangedSyncPeriod
    /// </summary>
    [DataMember(Name="changedSyncPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "changedSyncPeriod")]
    public int? ChangedSyncPeriod { get; set; }

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
    /// Gets or Sets FullSyncPeriod
    /// </summary>
    [DataMember(Name="fullSyncPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullSyncPeriod")]
    public int? FullSyncPeriod { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets LastSync
    /// </summary>
    [DataMember(Name="lastSync", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastSync")]
    public int? LastSync { get; set; }

    /// <summary>
    /// Gets or Sets Priority
    /// </summary>
    [DataMember(Name="priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// Gets or Sets ProviderName
    /// </summary>
    [DataMember(Name="providerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerName")]
    public string ProviderName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserFederationProviderRepresentation {\n");
      sb.Append("  ChangedSyncPeriod: ").Append(ChangedSyncPeriod).Append("\n");
      sb.Append("  Config: ").Append(Config).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  FullSyncPeriod: ").Append(FullSyncPeriod).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LastSync: ").Append(LastSync).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
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
