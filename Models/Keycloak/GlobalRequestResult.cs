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
  public class GlobalRequestResult {
    /// <summary>
    /// Gets or Sets FailedRequests
    /// </summary>
    [DataMember(Name="failedRequests", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failedRequests")]
    public List<string> FailedRequests { get; set; }

    /// <summary>
    /// Gets or Sets SuccessRequests
    /// </summary>
    [DataMember(Name="successRequests", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "successRequests")]
    public List<string> SuccessRequests { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GlobalRequestResult {\n");
      sb.Append("  FailedRequests: ").Append(FailedRequests).Append("\n");
      sb.Append("  SuccessRequests: ").Append(SuccessRequests).Append("\n");
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
