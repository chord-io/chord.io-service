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
  public class ManagementPermissionReference {
    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets Resource
    /// </summary>
    [DataMember(Name="resource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resource")]
    public string Resource { get; set; }

    /// <summary>
    /// Gets or Sets ScopePermissions
    /// </summary>
    [DataMember(Name="scopePermissions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scopePermissions")]
    public Dictionary<string, Object> ScopePermissions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ManagementPermissionReference {\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  Resource: ").Append(Resource).Append("\n");
      sb.Append("  ScopePermissions: ").Append(ScopePermissions).Append("\n");
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
