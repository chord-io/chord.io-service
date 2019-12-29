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
  public class Permission {
    /// <summary>
    /// Gets or Sets Claims
    /// </summary>
    [DataMember(Name="claims", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "claims")]
    public Dictionary<string, Object> Claims { get; set; }

    /// <summary>
    /// Gets or Sets Rsid
    /// </summary>
    [DataMember(Name="rsid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rsid")]
    public string Rsid { get; set; }

    /// <summary>
    /// Gets or Sets Rsname
    /// </summary>
    [DataMember(Name="rsname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rsname")]
    public string Rsname { get; set; }

    /// <summary>
    /// Gets or Sets Scopes
    /// </summary>
    [DataMember(Name="scopes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scopes")]
    public List<string> Scopes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Permission {\n");
      sb.Append("  Claims: ").Append(Claims).Append("\n");
      sb.Append("  Rsid: ").Append(Rsid).Append("\n");
      sb.Append("  Rsname: ").Append(Rsname).Append("\n");
      sb.Append("  Scopes: ").Append(Scopes).Append("\n");
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
