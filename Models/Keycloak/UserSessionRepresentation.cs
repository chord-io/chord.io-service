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
  public class UserSessionRepresentation {
    /// <summary>
    /// Gets or Sets Clients
    /// </summary>
    [DataMember(Name="clients", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clients")]
    public Dictionary<string, Object> Clients { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets IpAddress
    /// </summary>
    [DataMember(Name="ipAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ipAddress")]
    public string IpAddress { get; set; }

    /// <summary>
    /// Gets or Sets LastAccess
    /// </summary>
    [DataMember(Name="lastAccess", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastAccess")]
    public long? LastAccess { get; set; }

    /// <summary>
    /// Gets or Sets Start
    /// </summary>
    [DataMember(Name="start", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start")]
    public long? Start { get; set; }

    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [DataMember(Name="userId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userId")]
    public string UserId { get; set; }

    /// <summary>
    /// Gets or Sets Username
    /// </summary>
    [DataMember(Name="username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserSessionRepresentation {\n");
      sb.Append("  Clients: ").Append(Clients).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
      sb.Append("  LastAccess: ").Append(LastAccess).Append("\n");
      sb.Append("  Start: ").Append(Start).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
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
