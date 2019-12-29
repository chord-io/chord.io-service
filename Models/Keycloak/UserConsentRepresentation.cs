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
  public class UserConsentRepresentation {
    /// <summary>
    /// Gets or Sets ClientId
    /// </summary>
    [DataMember(Name="clientId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientId")]
    public string ClientId { get; set; }

    /// <summary>
    /// Gets or Sets CreatedDate
    /// </summary>
    [DataMember(Name="createdDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdDate")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// Gets or Sets GrantedClientScopes
    /// </summary>
    [DataMember(Name="grantedClientScopes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "grantedClientScopes")]
    public List<string> GrantedClientScopes { get; set; }

    /// <summary>
    /// Gets or Sets LastUpdatedDate
    /// </summary>
    [DataMember(Name="lastUpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastUpdatedDate")]
    public long? LastUpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserConsentRepresentation {\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  GrantedClientScopes: ").Append(GrantedClientScopes).Append("\n");
      sb.Append("  LastUpdatedDate: ").Append(LastUpdatedDate).Append("\n");
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
