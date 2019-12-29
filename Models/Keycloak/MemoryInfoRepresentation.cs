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
  public class MemoryInfoRepresentation {
    /// <summary>
    /// Gets or Sets Free
    /// </summary>
    [DataMember(Name="free", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "free")]
    public long? Free { get; set; }

    /// <summary>
    /// Gets or Sets FreeFormated
    /// </summary>
    [DataMember(Name="freeFormated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "freeFormated")]
    public string FreeFormated { get; set; }

    /// <summary>
    /// Gets or Sets FreePercentage
    /// </summary>
    [DataMember(Name="freePercentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "freePercentage")]
    public long? FreePercentage { get; set; }

    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public long? Total { get; set; }

    /// <summary>
    /// Gets or Sets TotalFormated
    /// </summary>
    [DataMember(Name="totalFormated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalFormated")]
    public string TotalFormated { get; set; }

    /// <summary>
    /// Gets or Sets Used
    /// </summary>
    [DataMember(Name="used", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "used")]
    public long? Used { get; set; }

    /// <summary>
    /// Gets or Sets UsedFormated
    /// </summary>
    [DataMember(Name="usedFormated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "usedFormated")]
    public string UsedFormated { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MemoryInfoRepresentation {\n");
      sb.Append("  Free: ").Append(Free).Append("\n");
      sb.Append("  FreeFormated: ").Append(FreeFormated).Append("\n");
      sb.Append("  FreePercentage: ").Append(FreePercentage).Append("\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
      sb.Append("  TotalFormated: ").Append(TotalFormated).Append("\n");
      sb.Append("  Used: ").Append(Used).Append("\n");
      sb.Append("  UsedFormated: ").Append(UsedFormated).Append("\n");
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
