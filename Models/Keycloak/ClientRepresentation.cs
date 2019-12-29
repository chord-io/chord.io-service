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
  public class ClientRepresentation {
    /// <summary>
    /// Gets or Sets Access
    /// </summary>
    [DataMember(Name="access", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "access")]
    public Dictionary<string, Object> Access { get; set; }

    /// <summary>
    /// Gets or Sets AdminUrl
    /// </summary>
    [DataMember(Name="adminUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adminUrl")]
    public string AdminUrl { get; set; }

    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [DataMember(Name="attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributes")]
    public Dictionary<string, Object> Attributes { get; set; }

    /// <summary>
    /// Gets or Sets AuthenticationFlowBindingOverrides
    /// </summary>
    [DataMember(Name="authenticationFlowBindingOverrides", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticationFlowBindingOverrides")]
    public Dictionary<string, Object> AuthenticationFlowBindingOverrides { get; set; }

    /// <summary>
    /// Gets or Sets AuthorizationServicesEnabled
    /// </summary>
    [DataMember(Name="authorizationServicesEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authorizationServicesEnabled")]
    public bool? AuthorizationServicesEnabled { get; set; }

    /// <summary>
    /// Gets or Sets AuthorizationSettings
    /// </summary>
    [DataMember(Name="authorizationSettings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authorizationSettings")]
    public ResourceServerRepresentation AuthorizationSettings { get; set; }

    /// <summary>
    /// Gets or Sets BaseUrl
    /// </summary>
    [DataMember(Name="baseUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseUrl")]
    public string BaseUrl { get; set; }

    /// <summary>
    /// Gets or Sets BearerOnly
    /// </summary>
    [DataMember(Name="bearerOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bearerOnly")]
    public bool? BearerOnly { get; set; }

    /// <summary>
    /// Gets or Sets ClientAuthenticatorType
    /// </summary>
    [DataMember(Name="clientAuthenticatorType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientAuthenticatorType")]
    public string ClientAuthenticatorType { get; set; }

    /// <summary>
    /// Gets or Sets ClientId
    /// </summary>
    [DataMember(Name="clientId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientId")]
    public string ClientId { get; set; }

    /// <summary>
    /// Gets or Sets ConsentRequired
    /// </summary>
    [DataMember(Name="consentRequired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "consentRequired")]
    public bool? ConsentRequired { get; set; }

    /// <summary>
    /// Gets or Sets DefaultClientScopes
    /// </summary>
    [DataMember(Name="defaultClientScopes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultClientScopes")]
    public List<string> DefaultClientScopes { get; set; }

    /// <summary>
    /// Gets or Sets DefaultRoles
    /// </summary>
    [DataMember(Name="defaultRoles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultRoles")]
    public List<string> DefaultRoles { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets DirectAccessGrantsEnabled
    /// </summary>
    [DataMember(Name="directAccessGrantsEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "directAccessGrantsEnabled")]
    public bool? DirectAccessGrantsEnabled { get; set; }

    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets FrontchannelLogout
    /// </summary>
    [DataMember(Name="frontchannelLogout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "frontchannelLogout")]
    public bool? FrontchannelLogout { get; set; }

    /// <summary>
    /// Gets or Sets FullScopeAllowed
    /// </summary>
    [DataMember(Name="fullScopeAllowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullScopeAllowed")]
    public bool? FullScopeAllowed { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets ImplicitFlowEnabled
    /// </summary>
    [DataMember(Name="implicitFlowEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "implicitFlowEnabled")]
    public bool? ImplicitFlowEnabled { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets NodeReRegistrationTimeout
    /// </summary>
    [DataMember(Name="nodeReRegistrationTimeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeReRegistrationTimeout")]
    public int? NodeReRegistrationTimeout { get; set; }

    /// <summary>
    /// Gets or Sets NotBefore
    /// </summary>
    [DataMember(Name="notBefore", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notBefore")]
    public int? NotBefore { get; set; }

    /// <summary>
    /// Gets or Sets OptionalClientScopes
    /// </summary>
    [DataMember(Name="optionalClientScopes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "optionalClientScopes")]
    public List<string> OptionalClientScopes { get; set; }

    /// <summary>
    /// Gets or Sets Origin
    /// </summary>
    [DataMember(Name="origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin")]
    public string Origin { get; set; }

    /// <summary>
    /// Gets or Sets Protocol
    /// </summary>
    [DataMember(Name="protocol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protocol")]
    public string Protocol { get; set; }

    /// <summary>
    /// Gets or Sets ProtocolMappers
    /// </summary>
    [DataMember(Name="protocolMappers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protocolMappers")]
    public List<ProtocolMapperRepresentation> ProtocolMappers { get; set; }

    /// <summary>
    /// Gets or Sets PublicClient
    /// </summary>
    [DataMember(Name="publicClient", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publicClient")]
    public bool? PublicClient { get; set; }

    /// <summary>
    /// Gets or Sets RedirectUris
    /// </summary>
    [DataMember(Name="redirectUris", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redirectUris")]
    public List<string> RedirectUris { get; set; }

    /// <summary>
    /// Gets or Sets RegisteredNodes
    /// </summary>
    [DataMember(Name="registeredNodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registeredNodes")]
    public Dictionary<string, Object> RegisteredNodes { get; set; }

    /// <summary>
    /// Gets or Sets RegistrationAccessToken
    /// </summary>
    [DataMember(Name="registrationAccessToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registrationAccessToken")]
    public string RegistrationAccessToken { get; set; }

    /// <summary>
    /// Gets or Sets RootUrl
    /// </summary>
    [DataMember(Name="rootUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rootUrl")]
    public string RootUrl { get; set; }

    /// <summary>
    /// Gets or Sets Secret
    /// </summary>
    [DataMember(Name="secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secret")]
    public string Secret { get; set; }

    /// <summary>
    /// Gets or Sets ServiceAccountsEnabled
    /// </summary>
    [DataMember(Name="serviceAccountsEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceAccountsEnabled")]
    public bool? ServiceAccountsEnabled { get; set; }

    /// <summary>
    /// Gets or Sets StandardFlowEnabled
    /// </summary>
    [DataMember(Name="standardFlowEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "standardFlowEnabled")]
    public bool? StandardFlowEnabled { get; set; }

    /// <summary>
    /// Gets or Sets SurrogateAuthRequired
    /// </summary>
    [DataMember(Name="surrogateAuthRequired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "surrogateAuthRequired")]
    public bool? SurrogateAuthRequired { get; set; }

    /// <summary>
    /// Gets or Sets WebOrigins
    /// </summary>
    [DataMember(Name="webOrigins", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webOrigins")]
    public List<string> WebOrigins { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClientRepresentation {\n");
      sb.Append("  Access: ").Append(Access).Append("\n");
      sb.Append("  AdminUrl: ").Append(AdminUrl).Append("\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
      sb.Append("  AuthenticationFlowBindingOverrides: ").Append(AuthenticationFlowBindingOverrides).Append("\n");
      sb.Append("  AuthorizationServicesEnabled: ").Append(AuthorizationServicesEnabled).Append("\n");
      sb.Append("  AuthorizationSettings: ").Append(AuthorizationSettings).Append("\n");
      sb.Append("  BaseUrl: ").Append(BaseUrl).Append("\n");
      sb.Append("  BearerOnly: ").Append(BearerOnly).Append("\n");
      sb.Append("  ClientAuthenticatorType: ").Append(ClientAuthenticatorType).Append("\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  ConsentRequired: ").Append(ConsentRequired).Append("\n");
      sb.Append("  DefaultClientScopes: ").Append(DefaultClientScopes).Append("\n");
      sb.Append("  DefaultRoles: ").Append(DefaultRoles).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DirectAccessGrantsEnabled: ").Append(DirectAccessGrantsEnabled).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  FrontchannelLogout: ").Append(FrontchannelLogout).Append("\n");
      sb.Append("  FullScopeAllowed: ").Append(FullScopeAllowed).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ImplicitFlowEnabled: ").Append(ImplicitFlowEnabled).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  NodeReRegistrationTimeout: ").Append(NodeReRegistrationTimeout).Append("\n");
      sb.Append("  NotBefore: ").Append(NotBefore).Append("\n");
      sb.Append("  OptionalClientScopes: ").Append(OptionalClientScopes).Append("\n");
      sb.Append("  Origin: ").Append(Origin).Append("\n");
      sb.Append("  Protocol: ").Append(Protocol).Append("\n");
      sb.Append("  ProtocolMappers: ").Append(ProtocolMappers).Append("\n");
      sb.Append("  PublicClient: ").Append(PublicClient).Append("\n");
      sb.Append("  RedirectUris: ").Append(RedirectUris).Append("\n");
      sb.Append("  RegisteredNodes: ").Append(RegisteredNodes).Append("\n");
      sb.Append("  RegistrationAccessToken: ").Append(RegistrationAccessToken).Append("\n");
      sb.Append("  RootUrl: ").Append(RootUrl).Append("\n");
      sb.Append("  Secret: ").Append(Secret).Append("\n");
      sb.Append("  ServiceAccountsEnabled: ").Append(ServiceAccountsEnabled).Append("\n");
      sb.Append("  StandardFlowEnabled: ").Append(StandardFlowEnabled).Append("\n");
      sb.Append("  SurrogateAuthRequired: ").Append(SurrogateAuthRequired).Append("\n");
      sb.Append("  WebOrigins: ").Append(WebOrigins).Append("\n");
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
