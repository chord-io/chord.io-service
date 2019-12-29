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
  public class CredentialRepresentation {
    /// <summary>
    /// Gets or Sets CreatedDate
    /// </summary>
    [DataMember(Name="createdDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdDate")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// Gets or Sets CredentialData
    /// </summary>
    [DataMember(Name="credentialData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credentialData")]
    public string CredentialData { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Priority
    /// </summary>
    [DataMember(Name="priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// Gets or Sets SecretData
    /// </summary>
    [DataMember(Name="secretData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secretData")]
    public string SecretData { get; set; }

    /// <summary>
    /// Gets or Sets Temporary
    /// </summary>
    [DataMember(Name="temporary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "temporary")]
    public bool? Temporary { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets UserLabel
    /// </summary>
    [DataMember(Name="userLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userLabel")]
    public string UserLabel { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CredentialRepresentation {\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CredentialData: ").Append(CredentialData).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      sb.Append("  SecretData: ").Append(SecretData).Append("\n");
      sb.Append("  Temporary: ").Append(Temporary).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  UserLabel: ").Append(UserLabel).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
