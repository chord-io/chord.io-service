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
  public class RoleRepresentation {
    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [DataMember(Name="attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributes")]
    public Dictionary<string, Object> Attributes { get; set; }

    /// <summary>
    /// Gets or Sets ClientRole
    /// </summary>
    [DataMember(Name="clientRole", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientRole")]
    public bool? ClientRole { get; set; }

    /// <summary>
    /// Gets or Sets Composite
    /// </summary>
    [DataMember(Name="composite", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "composite")]
    public bool? Composite { get; set; }

    /// <summary>
    /// Gets or Sets Composites
    /// </summary>
    [DataMember(Name="composites", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "composites")]
    public RoleRepresentationComposites Composites { get; set; }

    /// <summary>
    /// Gets or Sets ContainerId
    /// </summary>
    [DataMember(Name="containerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "containerId")]
    public string ContainerId { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RoleRepresentation {\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
      sb.Append("  ClientRole: ").Append(ClientRole).Append("\n");
      sb.Append("  Composite: ").Append(Composite).Append("\n");
      sb.Append("  Composites: ").Append(Composites).Append("\n");
      sb.Append("  ContainerId: ").Append(ContainerId).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
