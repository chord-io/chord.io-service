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
  public class AuthenticationExecutionExportRepresentation {
    /// <summary>
    /// Gets or Sets Authenticator
    /// </summary>
    [DataMember(Name="authenticator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticator")]
    public string Authenticator { get; set; }

    /// <summary>
    /// Gets or Sets AuthenticatorConfig
    /// </summary>
    [DataMember(Name="authenticatorConfig", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticatorConfig")]
    public string AuthenticatorConfig { get; set; }

    /// <summary>
    /// Gets or Sets AuthenticatorFlow
    /// </summary>
    [DataMember(Name="authenticatorFlow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticatorFlow")]
    public bool? AuthenticatorFlow { get; set; }

    /// <summary>
    /// Gets or Sets AutheticatorFlow
    /// </summary>
    [DataMember(Name="autheticatorFlow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "autheticatorFlow")]
    public bool? AutheticatorFlow { get; set; }

    /// <summary>
    /// Gets or Sets FlowAlias
    /// </summary>
    [DataMember(Name="flowAlias", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "flowAlias")]
    public string FlowAlias { get; set; }

    /// <summary>
    /// Gets or Sets Priority
    /// </summary>
    [DataMember(Name="priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// Gets or Sets Requirement
    /// </summary>
    [DataMember(Name="requirement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requirement")]
    public string Requirement { get; set; }

    /// <summary>
    /// Gets or Sets UserSetupAllowed
    /// </summary>
    [DataMember(Name="userSetupAllowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userSetupAllowed")]
    public bool? UserSetupAllowed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthenticationExecutionExportRepresentation {\n");
      sb.Append("  Authenticator: ").Append(Authenticator).Append("\n");
      sb.Append("  AuthenticatorConfig: ").Append(AuthenticatorConfig).Append("\n");
      sb.Append("  AuthenticatorFlow: ").Append(AuthenticatorFlow).Append("\n");
      sb.Append("  AutheticatorFlow: ").Append(AutheticatorFlow).Append("\n");
      sb.Append("  FlowAlias: ").Append(FlowAlias).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      sb.Append("  Requirement: ").Append(Requirement).Append("\n");
      sb.Append("  UserSetupAllowed: ").Append(UserSetupAllowed).Append("\n");
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
