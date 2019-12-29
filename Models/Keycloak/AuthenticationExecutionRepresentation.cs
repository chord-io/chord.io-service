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
  public class AuthenticationExecutionRepresentation {
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
    /// Gets or Sets FlowId
    /// </summary>
    [DataMember(Name="flowId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "flowId")]
    public string FlowId { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets ParentFlow
    /// </summary>
    [DataMember(Name="parentFlow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentFlow")]
    public string ParentFlow { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthenticationExecutionRepresentation {\n");
      sb.Append("  Authenticator: ").Append(Authenticator).Append("\n");
      sb.Append("  AuthenticatorConfig: ").Append(AuthenticatorConfig).Append("\n");
      sb.Append("  AuthenticatorFlow: ").Append(AuthenticatorFlow).Append("\n");
      sb.Append("  AutheticatorFlow: ").Append(AutheticatorFlow).Append("\n");
      sb.Append("  FlowId: ").Append(FlowId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ParentFlow: ").Append(ParentFlow).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      sb.Append("  Requirement: ").Append(Requirement).Append("\n");
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
