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
  public class AdminEventRepresentation {
    /// <summary>
    /// Gets or Sets AuthDetails
    /// </summary>
    [DataMember(Name="authDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authDetails")]
    public AuthDetailsRepresentation AuthDetails { get; set; }

    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    [DataMember(Name="error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error")]
    public string Error { get; set; }

    /// <summary>
    /// Gets or Sets OperationType
    /// </summary>
    [DataMember(Name="operationType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operationType")]
    public string OperationType { get; set; }

    /// <summary>
    /// Gets or Sets RealmId
    /// </summary>
    [DataMember(Name="realmId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "realmId")]
    public string RealmId { get; set; }

    /// <summary>
    /// Gets or Sets Representation
    /// </summary>
    [DataMember(Name="representation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "representation")]
    public string Representation { get; set; }

    /// <summary>
    /// Gets or Sets ResourcePath
    /// </summary>
    [DataMember(Name="resourcePath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resourcePath")]
    public string ResourcePath { get; set; }

    /// <summary>
    /// Gets or Sets ResourceType
    /// </summary>
    [DataMember(Name="resourceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resourceType")]
    public string ResourceType { get; set; }

    /// <summary>
    /// Gets or Sets Time
    /// </summary>
    [DataMember(Name="time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "time")]
    public long? Time { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdminEventRepresentation {\n");
      sb.Append("  AuthDetails: ").Append(AuthDetails).Append("\n");
      sb.Append("  Error: ").Append(Error).Append("\n");
      sb.Append("  OperationType: ").Append(OperationType).Append("\n");
      sb.Append("  RealmId: ").Append(RealmId).Append("\n");
      sb.Append("  Representation: ").Append(Representation).Append("\n");
      sb.Append("  ResourcePath: ").Append(ResourcePath).Append("\n");
      sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
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
