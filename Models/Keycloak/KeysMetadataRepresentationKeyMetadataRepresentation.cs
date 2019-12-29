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
  public class KeysMetadataRepresentationKeyMetadataRepresentation {
    /// <summary>
    /// Gets or Sets Algorithm
    /// </summary>
    [DataMember(Name="algorithm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "algorithm")]
    public string Algorithm { get; set; }

    /// <summary>
    /// Gets or Sets Certificate
    /// </summary>
    [DataMember(Name="certificate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "certificate")]
    public string Certificate { get; set; }

    /// <summary>
    /// Gets or Sets Kid
    /// </summary>
    [DataMember(Name="kid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kid")]
    public string Kid { get; set; }

    /// <summary>
    /// Gets or Sets ProviderId
    /// </summary>
    [DataMember(Name="providerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerId")]
    public string ProviderId { get; set; }

    /// <summary>
    /// Gets or Sets ProviderPriority
    /// </summary>
    [DataMember(Name="providerPriority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerPriority")]
    public long? ProviderPriority { get; set; }

    /// <summary>
    /// Gets or Sets PublicKey
    /// </summary>
    [DataMember(Name="publicKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publicKey")]
    public string PublicKey { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class KeysMetadataRepresentationKeyMetadataRepresentation {\n");
      sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
      sb.Append("  Certificate: ").Append(Certificate).Append("\n");
      sb.Append("  Kid: ").Append(Kid).Append("\n");
      sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
      sb.Append("  ProviderPriority: ").Append(ProviderPriority).Append("\n");
      sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
