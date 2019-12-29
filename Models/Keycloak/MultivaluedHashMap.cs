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
  public class MultivaluedHashMap {
    /// <summary>
    /// Gets or Sets Empty
    /// </summary>
    [DataMember(Name="empty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "empty")]
    public bool? Empty { get; set; }

    /// <summary>
    /// Gets or Sets LoadFactor
    /// </summary>
    [DataMember(Name="loadFactor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loadFactor")]
    public float? LoadFactor { get; set; }

    /// <summary>
    /// Gets or Sets Threshold
    /// </summary>
    [DataMember(Name="threshold", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "threshold")]
    public int? Threshold { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MultivaluedHashMap {\n");
      sb.Append("  Empty: ").Append(Empty).Append("\n");
      sb.Append("  LoadFactor: ").Append(LoadFactor).Append("\n");
      sb.Append("  Threshold: ").Append(Threshold).Append("\n");
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
