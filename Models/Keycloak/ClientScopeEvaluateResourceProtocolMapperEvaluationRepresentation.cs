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
  public class ClientScopeEvaluateResourceProtocolMapperEvaluationRepresentation {
    /// <summary>
    /// Gets or Sets ContainerId
    /// </summary>
    [DataMember(Name="containerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "containerId")]
    public string ContainerId { get; set; }

    /// <summary>
    /// Gets or Sets ContainerName
    /// </summary>
    [DataMember(Name="containerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "containerName")]
    public string ContainerName { get; set; }

    /// <summary>
    /// Gets or Sets ContainerType
    /// </summary>
    [DataMember(Name="containerType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "containerType")]
    public string ContainerType { get; set; }

    /// <summary>
    /// Gets or Sets MapperId
    /// </summary>
    [DataMember(Name="mapperId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mapperId")]
    public string MapperId { get; set; }

    /// <summary>
    /// Gets or Sets MapperName
    /// </summary>
    [DataMember(Name="mapperName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mapperName")]
    public string MapperName { get; set; }

    /// <summary>
    /// Gets or Sets ProtocolMapper
    /// </summary>
    [DataMember(Name="protocolMapper", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protocolMapper")]
    public string ProtocolMapper { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClientScopeEvaluateResourceProtocolMapperEvaluationRepresentation {\n");
      sb.Append("  ContainerId: ").Append(ContainerId).Append("\n");
      sb.Append("  ContainerName: ").Append(ContainerName).Append("\n");
      sb.Append("  ContainerType: ").Append(ContainerType).Append("\n");
      sb.Append("  MapperId: ").Append(MapperId).Append("\n");
      sb.Append("  MapperName: ").Append(MapperName).Append("\n");
      sb.Append("  ProtocolMapper: ").Append(ProtocolMapper).Append("\n");
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
