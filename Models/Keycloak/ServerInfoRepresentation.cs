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
  public class ServerInfoRepresentation {
    /// <summary>
    /// Gets or Sets BuiltinProtocolMappers
    /// </summary>
    [DataMember(Name="builtinProtocolMappers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "builtinProtocolMappers")]
    public Dictionary<string, Object> BuiltinProtocolMappers { get; set; }

    /// <summary>
    /// Gets or Sets ClientImporters
    /// </summary>
    [DataMember(Name="clientImporters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientImporters")]
    public List<Dictionary<string, Object>> ClientImporters { get; set; }

    /// <summary>
    /// Gets or Sets ClientInstallations
    /// </summary>
    [DataMember(Name="clientInstallations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientInstallations")]
    public Dictionary<string, Object> ClientInstallations { get; set; }

    /// <summary>
    /// Gets or Sets ComponentTypes
    /// </summary>
    [DataMember(Name="componentTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "componentTypes")]
    public Dictionary<string, Object> ComponentTypes { get; set; }

    /// <summary>
    /// Gets or Sets Enums
    /// </summary>
    [DataMember(Name="enums", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enums")]
    public Dictionary<string, Object> Enums { get; set; }

    /// <summary>
    /// Gets or Sets IdentityProviders
    /// </summary>
    [DataMember(Name="identityProviders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identityProviders")]
    public List<Dictionary<string, Object>> IdentityProviders { get; set; }

    /// <summary>
    /// Gets or Sets MemoryInfo
    /// </summary>
    [DataMember(Name="memoryInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "memoryInfo")]
    public MemoryInfoRepresentation MemoryInfo { get; set; }

    /// <summary>
    /// Gets or Sets PasswordPolicies
    /// </summary>
    [DataMember(Name="passwordPolicies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passwordPolicies")]
    public List<PasswordPolicyTypeRepresentation> PasswordPolicies { get; set; }

    /// <summary>
    /// Gets or Sets ProfileInfo
    /// </summary>
    [DataMember(Name="profileInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profileInfo")]
    public ProfileInfoRepresentation ProfileInfo { get; set; }

    /// <summary>
    /// Gets or Sets ProtocolMapperTypes
    /// </summary>
    [DataMember(Name="protocolMapperTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protocolMapperTypes")]
    public Dictionary<string, Object> ProtocolMapperTypes { get; set; }

    /// <summary>
    /// Gets or Sets Providers
    /// </summary>
    [DataMember(Name="providers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providers")]
    public Dictionary<string, Object> Providers { get; set; }

    /// <summary>
    /// Gets or Sets SocialProviders
    /// </summary>
    [DataMember(Name="socialProviders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "socialProviders")]
    public List<Dictionary<string, Object>> SocialProviders { get; set; }

    /// <summary>
    /// Gets or Sets SystemInfo
    /// </summary>
    [DataMember(Name="systemInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "systemInfo")]
    public SystemInfoRepresentation SystemInfo { get; set; }

    /// <summary>
    /// Gets or Sets Themes
    /// </summary>
    [DataMember(Name="themes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "themes")]
    public Dictionary<string, Object> Themes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServerInfoRepresentation {\n");
      sb.Append("  BuiltinProtocolMappers: ").Append(BuiltinProtocolMappers).Append("\n");
      sb.Append("  ClientImporters: ").Append(ClientImporters).Append("\n");
      sb.Append("  ClientInstallations: ").Append(ClientInstallations).Append("\n");
      sb.Append("  ComponentTypes: ").Append(ComponentTypes).Append("\n");
      sb.Append("  Enums: ").Append(Enums).Append("\n");
      sb.Append("  IdentityProviders: ").Append(IdentityProviders).Append("\n");
      sb.Append("  MemoryInfo: ").Append(MemoryInfo).Append("\n");
      sb.Append("  PasswordPolicies: ").Append(PasswordPolicies).Append("\n");
      sb.Append("  ProfileInfo: ").Append(ProfileInfo).Append("\n");
      sb.Append("  ProtocolMapperTypes: ").Append(ProtocolMapperTypes).Append("\n");
      sb.Append("  Providers: ").Append(Providers).Append("\n");
      sb.Append("  SocialProviders: ").Append(SocialProviders).Append("\n");
      sb.Append("  SystemInfo: ").Append(SystemInfo).Append("\n");
      sb.Append("  Themes: ").Append(Themes).Append("\n");
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
