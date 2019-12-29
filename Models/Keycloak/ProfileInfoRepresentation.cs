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
  public class ProfileInfoRepresentation {
    /// <summary>
    /// Gets or Sets DisabledFeatures
    /// </summary>
    [DataMember(Name="disabledFeatures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disabledFeatures")]
    public List<string> DisabledFeatures { get; set; }

    /// <summary>
    /// Gets or Sets ExperimentalFeatures
    /// </summary>
    [DataMember(Name="experimentalFeatures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "experimentalFeatures")]
    public List<string> ExperimentalFeatures { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets PreviewFeatures
    /// </summary>
    [DataMember(Name="previewFeatures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previewFeatures")]
    public List<string> PreviewFeatures { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProfileInfoRepresentation {\n");
      sb.Append("  DisabledFeatures: ").Append(DisabledFeatures).Append("\n");
      sb.Append("  ExperimentalFeatures: ").Append(ExperimentalFeatures).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PreviewFeatures: ").Append(PreviewFeatures).Append("\n");
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
