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
  public class GroupRepresentation {
    /// <summary>
    /// Gets or Sets Access
    /// </summary>
    [DataMember(Name="access", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "access")]
    public Dictionary<string, Object> Access { get; set; }

    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [DataMember(Name="attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributes")]
    public Dictionary<string, Object> Attributes { get; set; }

    /// <summary>
    /// Gets or Sets ClientRoles
    /// </summary>
    [DataMember(Name="clientRoles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientRoles")]
    public Dictionary<string, Object> ClientRoles { get; set; }

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
    /// Gets or Sets Path
    /// </summary>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// Gets or Sets RealmRoles
    /// </summary>
    [DataMember(Name="realmRoles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "realmRoles")]
    public List<string> RealmRoles { get; set; }

    /// <summary>
    /// Gets or Sets SubGroups
    /// </summary>
    [DataMember(Name="subGroups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subGroups")]
    public List<GroupRepresentation> SubGroups { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupRepresentation {\n");
      sb.Append("  Access: ").Append(Access).Append("\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
      sb.Append("  ClientRoles: ").Append(ClientRoles).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  RealmRoles: ").Append(RealmRoles).Append("\n");
      sb.Append("  SubGroups: ").Append(SubGroups).Append("\n");
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
