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
  public class UserRepresentation {
    /// <summary>
    /// Gets or Sets Access
    /// </summary>
    [DataMember(Name="access", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "access")]
    public Dictionary<string, Object> Access { get; set; }

    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [DataMember(Name="attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributes")]
    public Dictionary<string, Object> Attributes { get; set; }

    /// <summary>
    /// Gets or Sets ClientConsents
    /// </summary>
    [DataMember(Name="clientConsents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientConsents")]
    public List<UserConsentRepresentation> ClientConsents { get; set; }

    /// <summary>
    /// Gets or Sets ClientRoles
    /// </summary>
    [DataMember(Name="clientRoles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientRoles")]
    public Dictionary<string, Object> ClientRoles { get; set; }

    /// <summary>
    /// Gets or Sets CreatedTimestamp
    /// </summary>
    [DataMember(Name="createdTimestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdTimestamp")]
    public long? CreatedTimestamp { get; set; }

    /// <summary>
    /// Gets or Sets Credentials
    /// </summary>
    [DataMember(Name="credentials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credentials")]
    public List<CredentialRepresentation> Credentials { get; set; }

    /// <summary>
    /// Gets or Sets DisableableCredentialTypes
    /// </summary>
    [DataMember(Name="disableableCredentialTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disableableCredentialTypes")]
    public List<string> DisableableCredentialTypes { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets EmailVerified
    /// </summary>
    [DataMember(Name="emailVerified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailVerified")]
    public bool? EmailVerified { get; set; }

    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets FederatedIdentities
    /// </summary>
    [DataMember(Name="federatedIdentities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "federatedIdentities")]
    public List<FederatedIdentityRepresentation> FederatedIdentities { get; set; }

    /// <summary>
    /// Gets or Sets FederationLink
    /// </summary>
    [DataMember(Name="federationLink", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "federationLink")]
    public string FederationLink { get; set; }

    /// <summary>
    /// Gets or Sets FirstName
    /// </summary>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or Sets Groups
    /// </summary>
    [DataMember(Name="groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groups")]
    public List<string> Groups { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets LastName
    /// </summary>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// Gets or Sets NotBefore
    /// </summary>
    [DataMember(Name="notBefore", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notBefore")]
    public int? NotBefore { get; set; }

    /// <summary>
    /// Gets or Sets Origin
    /// </summary>
    [DataMember(Name="origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin")]
    public string Origin { get; set; }

    /// <summary>
    /// Gets or Sets RealmRoles
    /// </summary>
    [DataMember(Name="realmRoles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "realmRoles")]
    public List<string> RealmRoles { get; set; }

    /// <summary>
    /// Gets or Sets RequiredActions
    /// </summary>
    [DataMember(Name="requiredActions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requiredActions")]
    public List<string> RequiredActions { get; set; }

    /// <summary>
    /// Gets or Sets Self
    /// </summary>
    [DataMember(Name="self", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "self")]
    public string Self { get; set; }

    /// <summary>
    /// Gets or Sets ServiceAccountClientId
    /// </summary>
    [DataMember(Name="serviceAccountClientId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceAccountClientId")]
    public string ServiceAccountClientId { get; set; }

    /// <summary>
    /// Gets or Sets Username
    /// </summary>
    [DataMember(Name="username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserRepresentation {\n");
      sb.Append("  Access: ").Append(Access).Append("\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
      sb.Append("  ClientConsents: ").Append(ClientConsents).Append("\n");
      sb.Append("  ClientRoles: ").Append(ClientRoles).Append("\n");
      sb.Append("  CreatedTimestamp: ").Append(CreatedTimestamp).Append("\n");
      sb.Append("  Credentials: ").Append(Credentials).Append("\n");
      sb.Append("  DisableableCredentialTypes: ").Append(DisableableCredentialTypes).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  EmailVerified: ").Append(EmailVerified).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  FederatedIdentities: ").Append(FederatedIdentities).Append("\n");
      sb.Append("  FederationLink: ").Append(FederationLink).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  NotBefore: ").Append(NotBefore).Append("\n");
      sb.Append("  Origin: ").Append(Origin).Append("\n");
      sb.Append("  RealmRoles: ").Append(RealmRoles).Append("\n");
      sb.Append("  RequiredActions: ").Append(RequiredActions).Append("\n");
      sb.Append("  Self: ").Append(Self).Append("\n");
      sb.Append("  ServiceAccountClientId: ").Append(ServiceAccountClientId).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
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
