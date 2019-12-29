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
  public class AuthDetailsRepresentation {
    /// <summary>
    /// Gets or Sets ClientId
    /// </summary>
    [DataMember(Name="clientId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientId")]
    public string ClientId { get; set; }

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
      sb.Append("class AuthDetailsRepresentation {\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
      sb.Append("  RealmId: ").Append(RealmId).Append("\n");
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
