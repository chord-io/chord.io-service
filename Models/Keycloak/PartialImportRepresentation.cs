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
  public class PartialImportRepresentation {
    /// <summary>
    /// Gets or Sets Clients
    /// </summary>
    [DataMember(Name="clients", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clients")]
    public List<ClientRepresentation> Clients { get; set; }

    /// <summary>
    /// Gets or Sets Groups
    /// </summary>
    [DataMember(Name="groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groups")]
    public List<GroupRepresentation> Groups { get; set; }

    /// <summary>
    /// Gets or Sets IdentityProviders
    /// </summary>
    [DataMember(Name="identityProviders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identityProviders")]
    public List<IdentityProviderRepresentation> IdentityProviders { get; set; }

    /// <summary>
    /// Gets or Sets IfResourceExists
    /// </summary>
    [DataMember(Name="ifResourceExists", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ifResourceExists")]
    public string IfResourceExists { get; set; }

    /// <summary>
    /// Gets or Sets Policy
    /// </summary>
    [DataMember(Name="policy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "policy")]
    public string Policy { get; set; }

    /// <summary>
    /// Gets or Sets Roles
    /// </summary>
    [DataMember(Name="roles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roles")]
    public RolesRepresentation Roles { get; set; }

    /// <summary>
    /// Gets or Sets Users
    /// </summary>
    [DataMember(Name="users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "users")]
    public List<UserRepresentation> Users { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartialImportRepresentation {\n");
      sb.Append("  Clients: ").Append(Clients).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
      sb.Append("  IdentityProviders: ").Append(IdentityProviders).Append("\n");
      sb.Append("  IfResourceExists: ").Append(IfResourceExists).Append("\n");
      sb.Append("  Policy: ").Append(Policy).Append("\n");
      sb.Append("  Roles: ").Append(Roles).Append("\n");
      sb.Append("  Users: ").Append(Users).Append("\n");
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
