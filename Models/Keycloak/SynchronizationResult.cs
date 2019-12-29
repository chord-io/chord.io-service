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
  public class SynchronizationResult {
    /// <summary>
    /// Gets or Sets Added
    /// </summary>
    [DataMember(Name="added", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "added")]
    public int? Added { get; set; }

    /// <summary>
    /// Gets or Sets Failed
    /// </summary>
    [DataMember(Name="failed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failed")]
    public int? Failed { get; set; }

    /// <summary>
    /// Gets or Sets Ignored
    /// </summary>
    [DataMember(Name="ignored", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ignored")]
    public bool? Ignored { get; set; }

    /// <summary>
    /// Gets or Sets Removed
    /// </summary>
    [DataMember(Name="removed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "removed")]
    public int? Removed { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets Updated
    /// </summary>
    [DataMember(Name="updated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated")]
    public int? Updated { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SynchronizationResult {\n");
      sb.Append("  Added: ").Append(Added).Append("\n");
      sb.Append("  Failed: ").Append(Failed).Append("\n");
      sb.Append("  Ignored: ").Append(Ignored).Append("\n");
      sb.Append("  Removed: ").Append(Removed).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Updated: ").Append(Updated).Append("\n");
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
