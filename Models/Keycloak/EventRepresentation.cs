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
  public class EventRepresentation {
    /// <summary>
    /// Gets or Sets ClientId
    /// </summary>
    [DataMember(Name="clientId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientId")]
    public string ClientId { get; set; }

    /// <summary>
    /// Gets or Sets Details
    /// </summary>
    [DataMember(Name="details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "details")]
    public Dictionary<string, Object> Details { get; set; }

    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    [DataMember(Name="error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error")]
    public string Error { get; set; }

    /// <summary>
    /// Gets or Sets IpAddress
    /// </summary>
    [DataMember(Name="ipAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ipAddress")]
    public string IpAddress { get; set; }

    /// <summary>
    /// Gets or Sets RealmId
    /// </summary>
    [DataMember(Name="realmId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "realmId")]
    public string RealmId { get; set; }

    /// <summary>
    /// Gets or Sets SessionId
    /// </summary>
    [DataMember(Name="sessionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sessionId")]
    public string SessionId { get; set; }

    /// <summary>
    /// Gets or Sets Time
    /// </summary>
    [DataMember(Name="time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "time")]
    public long? Time { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [DataMember(Name="userId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userId")]
    public string UserId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EventRepresentation {\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  Details: ").Append(Details).Append("\n");
      sb.Append("  Error: ").Append(Error).Append("\n");
      sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
      sb.Append("  RealmId: ").Append(RealmId).Append("\n");
      sb.Append("  SessionId: ").Append(SessionId).Append("\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
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
