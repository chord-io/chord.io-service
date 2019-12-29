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
  public class RealmRepresentation {
    /// <summary>
    /// Gets or Sets AccessCodeLifespan
    /// </summary>
    [DataMember(Name="accessCodeLifespan", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accessCodeLifespan")]
    public int? AccessCodeLifespan { get; set; }

    /// <summary>
    /// Gets or Sets AccessCodeLifespanLogin
    /// </summary>
    [DataMember(Name="accessCodeLifespanLogin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accessCodeLifespanLogin")]
    public int? AccessCodeLifespanLogin { get; set; }

    /// <summary>
    /// Gets or Sets AccessCodeLifespanUserAction
    /// </summary>
    [DataMember(Name="accessCodeLifespanUserAction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accessCodeLifespanUserAction")]
    public int? AccessCodeLifespanUserAction { get; set; }

    /// <summary>
    /// Gets or Sets AccessTokenLifespan
    /// </summary>
    [DataMember(Name="accessTokenLifespan", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accessTokenLifespan")]
    public int? AccessTokenLifespan { get; set; }

    /// <summary>
    /// Gets or Sets AccessTokenLifespanForImplicitFlow
    /// </summary>
    [DataMember(Name="accessTokenLifespanForImplicitFlow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accessTokenLifespanForImplicitFlow")]
    public int? AccessTokenLifespanForImplicitFlow { get; set; }

    /// <summary>
    /// Gets or Sets AccountTheme
    /// </summary>
    [DataMember(Name="accountTheme", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountTheme")]
    public string AccountTheme { get; set; }

    /// <summary>
    /// Gets or Sets ActionTokenGeneratedByAdminLifespan
    /// </summary>
    [DataMember(Name="actionTokenGeneratedByAdminLifespan", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actionTokenGeneratedByAdminLifespan")]
    public int? ActionTokenGeneratedByAdminLifespan { get; set; }

    /// <summary>
    /// Gets or Sets ActionTokenGeneratedByUserLifespan
    /// </summary>
    [DataMember(Name="actionTokenGeneratedByUserLifespan", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actionTokenGeneratedByUserLifespan")]
    public int? ActionTokenGeneratedByUserLifespan { get; set; }

    /// <summary>
    /// Gets or Sets AdminEventsDetailsEnabled
    /// </summary>
    [DataMember(Name="adminEventsDetailsEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adminEventsDetailsEnabled")]
    public bool? AdminEventsDetailsEnabled { get; set; }

    /// <summary>
    /// Gets or Sets AdminEventsEnabled
    /// </summary>
    [DataMember(Name="adminEventsEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adminEventsEnabled")]
    public bool? AdminEventsEnabled { get; set; }

    /// <summary>
    /// Gets or Sets AdminTheme
    /// </summary>
    [DataMember(Name="adminTheme", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adminTheme")]
    public string AdminTheme { get; set; }

    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [DataMember(Name="attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributes")]
    public Dictionary<string, Object> Attributes { get; set; }

    /// <summary>
    /// Gets or Sets AuthenticationFlows
    /// </summary>
    [DataMember(Name="authenticationFlows", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticationFlows")]
    public List<AuthenticationFlowRepresentation> AuthenticationFlows { get; set; }

    /// <summary>
    /// Gets or Sets AuthenticatorConfig
    /// </summary>
    [DataMember(Name="authenticatorConfig", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticatorConfig")]
    public List<AuthenticatorConfigRepresentation> AuthenticatorConfig { get; set; }

    /// <summary>
    /// Gets or Sets BrowserFlow
    /// </summary>
    [DataMember(Name="browserFlow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "browserFlow")]
    public string BrowserFlow { get; set; }

    /// <summary>
    /// Gets or Sets BrowserSecurityHeaders
    /// </summary>
    [DataMember(Name="browserSecurityHeaders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "browserSecurityHeaders")]
    public Dictionary<string, Object> BrowserSecurityHeaders { get; set; }

    /// <summary>
    /// Gets or Sets BruteForceProtected
    /// </summary>
    [DataMember(Name="bruteForceProtected", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bruteForceProtected")]
    public bool? BruteForceProtected { get; set; }

    /// <summary>
    /// Gets or Sets ClientAuthenticationFlow
    /// </summary>
    [DataMember(Name="clientAuthenticationFlow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientAuthenticationFlow")]
    public string ClientAuthenticationFlow { get; set; }

    /// <summary>
    /// Gets or Sets ClientScopeMappings
    /// </summary>
    [DataMember(Name="clientScopeMappings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientScopeMappings")]
    public Dictionary<string, Object> ClientScopeMappings { get; set; }

    /// <summary>
    /// Gets or Sets ClientScopes
    /// </summary>
    [DataMember(Name="clientScopes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientScopes")]
    public List<ClientScopeRepresentation> ClientScopes { get; set; }

    /// <summary>
    /// Gets or Sets Clients
    /// </summary>
    [DataMember(Name="clients", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clients")]
    public List<ClientRepresentation> Clients { get; set; }

    /// <summary>
    /// Gets or Sets Components
    /// </summary>
    [DataMember(Name="components", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "components")]
    public MultivaluedHashMap Components { get; set; }

    /// <summary>
    /// Gets or Sets DefaultDefaultClientScopes
    /// </summary>
    [DataMember(Name="defaultDefaultClientScopes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultDefaultClientScopes")]
    public List<string> DefaultDefaultClientScopes { get; set; }

    /// <summary>
    /// Gets or Sets DefaultGroups
    /// </summary>
    [DataMember(Name="defaultGroups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultGroups")]
    public List<string> DefaultGroups { get; set; }

    /// <summary>
    /// Gets or Sets DefaultLocale
    /// </summary>
    [DataMember(Name="defaultLocale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultLocale")]
    public string DefaultLocale { get; set; }

    /// <summary>
    /// Gets or Sets DefaultOptionalClientScopes
    /// </summary>
    [DataMember(Name="defaultOptionalClientScopes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultOptionalClientScopes")]
    public List<string> DefaultOptionalClientScopes { get; set; }

    /// <summary>
    /// Gets or Sets DefaultRoles
    /// </summary>
    [DataMember(Name="defaultRoles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultRoles")]
    public List<string> DefaultRoles { get; set; }

    /// <summary>
    /// Gets or Sets DefaultSignatureAlgorithm
    /// </summary>
    [DataMember(Name="defaultSignatureAlgorithm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultSignatureAlgorithm")]
    public string DefaultSignatureAlgorithm { get; set; }

    /// <summary>
    /// Gets or Sets DirectGrantFlow
    /// </summary>
    [DataMember(Name="directGrantFlow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "directGrantFlow")]
    public string DirectGrantFlow { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets DisplayNameHtml
    /// </summary>
    [DataMember(Name="displayNameHtml", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayNameHtml")]
    public string DisplayNameHtml { get; set; }

    /// <summary>
    /// Gets or Sets DockerAuthenticationFlow
    /// </summary>
    [DataMember(Name="dockerAuthenticationFlow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dockerAuthenticationFlow")]
    public string DockerAuthenticationFlow { get; set; }

    /// <summary>
    /// Gets or Sets DuplicateEmailsAllowed
    /// </summary>
    [DataMember(Name="duplicateEmailsAllowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duplicateEmailsAllowed")]
    public bool? DuplicateEmailsAllowed { get; set; }

    /// <summary>
    /// Gets or Sets EditUsernameAllowed
    /// </summary>
    [DataMember(Name="editUsernameAllowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "editUsernameAllowed")]
    public bool? EditUsernameAllowed { get; set; }

    /// <summary>
    /// Gets or Sets EmailTheme
    /// </summary>
    [DataMember(Name="emailTheme", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailTheme")]
    public string EmailTheme { get; set; }

    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets EnabledEventTypes
    /// </summary>
    [DataMember(Name="enabledEventTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabledEventTypes")]
    public List<string> EnabledEventTypes { get; set; }

    /// <summary>
    /// Gets or Sets EventsEnabled
    /// </summary>
    [DataMember(Name="eventsEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventsEnabled")]
    public bool? EventsEnabled { get; set; }

    /// <summary>
    /// Gets or Sets EventsExpiration
    /// </summary>
    [DataMember(Name="eventsExpiration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventsExpiration")]
    public long? EventsExpiration { get; set; }

    /// <summary>
    /// Gets or Sets EventsListeners
    /// </summary>
    [DataMember(Name="eventsListeners", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventsListeners")]
    public List<string> EventsListeners { get; set; }

    /// <summary>
    /// Gets or Sets FailureFactor
    /// </summary>
    [DataMember(Name="failureFactor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failureFactor")]
    public int? FailureFactor { get; set; }

    /// <summary>
    /// Gets or Sets FederatedUsers
    /// </summary>
    [DataMember(Name="federatedUsers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "federatedUsers")]
    public List<UserRepresentation> FederatedUsers { get; set; }

    /// <summary>
    /// Gets or Sets Groups
    /// </summary>
    [DataMember(Name="groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groups")]
    public List<GroupRepresentation> Groups { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets IdentityProviderMappers
    /// </summary>
    [DataMember(Name="identityProviderMappers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identityProviderMappers")]
    public List<IdentityProviderMapperRepresentation> IdentityProviderMappers { get; set; }

    /// <summary>
    /// Gets or Sets IdentityProviders
    /// </summary>
    [DataMember(Name="identityProviders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identityProviders")]
    public List<IdentityProviderRepresentation> IdentityProviders { get; set; }

    /// <summary>
    /// Gets or Sets InternationalizationEnabled
    /// </summary>
    [DataMember(Name="internationalizationEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "internationalizationEnabled")]
    public bool? InternationalizationEnabled { get; set; }

    /// <summary>
    /// Gets or Sets KeycloakVersion
    /// </summary>
    [DataMember(Name="keycloakVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "keycloakVersion")]
    public string KeycloakVersion { get; set; }

    /// <summary>
    /// Gets or Sets LoginTheme
    /// </summary>
    [DataMember(Name="loginTheme", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loginTheme")]
    public string LoginTheme { get; set; }

    /// <summary>
    /// Gets or Sets LoginWithEmailAllowed
    /// </summary>
    [DataMember(Name="loginWithEmailAllowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loginWithEmailAllowed")]
    public bool? LoginWithEmailAllowed { get; set; }

    /// <summary>
    /// Gets or Sets MaxDeltaTimeSeconds
    /// </summary>
    [DataMember(Name="maxDeltaTimeSeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxDeltaTimeSeconds")]
    public int? MaxDeltaTimeSeconds { get; set; }

    /// <summary>
    /// Gets or Sets MaxFailureWaitSeconds
    /// </summary>
    [DataMember(Name="maxFailureWaitSeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxFailureWaitSeconds")]
    public int? MaxFailureWaitSeconds { get; set; }

    /// <summary>
    /// Gets or Sets MinimumQuickLoginWaitSeconds
    /// </summary>
    [DataMember(Name="minimumQuickLoginWaitSeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimumQuickLoginWaitSeconds")]
    public int? MinimumQuickLoginWaitSeconds { get; set; }

    /// <summary>
    /// Gets or Sets NotBefore
    /// </summary>
    [DataMember(Name="notBefore", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notBefore")]
    public int? NotBefore { get; set; }

    /// <summary>
    /// Gets or Sets OfflineSessionIdleTimeout
    /// </summary>
    [DataMember(Name="offlineSessionIdleTimeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offlineSessionIdleTimeout")]
    public int? OfflineSessionIdleTimeout { get; set; }

    /// <summary>
    /// Gets or Sets OfflineSessionMaxLifespan
    /// </summary>
    [DataMember(Name="offlineSessionMaxLifespan", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offlineSessionMaxLifespan")]
    public int? OfflineSessionMaxLifespan { get; set; }

    /// <summary>
    /// Gets or Sets OfflineSessionMaxLifespanEnabled
    /// </summary>
    [DataMember(Name="offlineSessionMaxLifespanEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offlineSessionMaxLifespanEnabled")]
    public bool? OfflineSessionMaxLifespanEnabled { get; set; }

    /// <summary>
    /// Gets or Sets OtpPolicyAlgorithm
    /// </summary>
    [DataMember(Name="otpPolicyAlgorithm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "otpPolicyAlgorithm")]
    public string OtpPolicyAlgorithm { get; set; }

    /// <summary>
    /// Gets or Sets OtpPolicyDigits
    /// </summary>
    [DataMember(Name="otpPolicyDigits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "otpPolicyDigits")]
    public int? OtpPolicyDigits { get; set; }

    /// <summary>
    /// Gets or Sets OtpPolicyInitialCounter
    /// </summary>
    [DataMember(Name="otpPolicyInitialCounter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "otpPolicyInitialCounter")]
    public int? OtpPolicyInitialCounter { get; set; }

    /// <summary>
    /// Gets or Sets OtpPolicyLookAheadWindow
    /// </summary>
    [DataMember(Name="otpPolicyLookAheadWindow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "otpPolicyLookAheadWindow")]
    public int? OtpPolicyLookAheadWindow { get; set; }

    /// <summary>
    /// Gets or Sets OtpPolicyPeriod
    /// </summary>
    [DataMember(Name="otpPolicyPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "otpPolicyPeriod")]
    public int? OtpPolicyPeriod { get; set; }

    /// <summary>
    /// Gets or Sets OtpPolicyType
    /// </summary>
    [DataMember(Name="otpPolicyType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "otpPolicyType")]
    public string OtpPolicyType { get; set; }

    /// <summary>
    /// Gets or Sets OtpSupportedApplications
    /// </summary>
    [DataMember(Name="otpSupportedApplications", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "otpSupportedApplications")]
    public List<string> OtpSupportedApplications { get; set; }

    /// <summary>
    /// Gets or Sets PasswordPolicy
    /// </summary>
    [DataMember(Name="passwordPolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passwordPolicy")]
    public string PasswordPolicy { get; set; }

    /// <summary>
    /// Gets or Sets PermanentLockout
    /// </summary>
    [DataMember(Name="permanentLockout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permanentLockout")]
    public bool? PermanentLockout { get; set; }

    /// <summary>
    /// Gets or Sets ProtocolMappers
    /// </summary>
    [DataMember(Name="protocolMappers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protocolMappers")]
    public List<ProtocolMapperRepresentation> ProtocolMappers { get; set; }

    /// <summary>
    /// Gets or Sets QuickLoginCheckMilliSeconds
    /// </summary>
    [DataMember(Name="quickLoginCheckMilliSeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quickLoginCheckMilliSeconds")]
    public long? QuickLoginCheckMilliSeconds { get; set; }

    /// <summary>
    /// Gets or Sets Realm
    /// </summary>
    [DataMember(Name="realm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "realm")]
    public string Realm { get; set; }

    /// <summary>
    /// Gets or Sets RefreshTokenMaxReuse
    /// </summary>
    [DataMember(Name="refreshTokenMaxReuse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refreshTokenMaxReuse")]
    public int? RefreshTokenMaxReuse { get; set; }

    /// <summary>
    /// Gets or Sets RegistrationAllowed
    /// </summary>
    [DataMember(Name="registrationAllowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registrationAllowed")]
    public bool? RegistrationAllowed { get; set; }

    /// <summary>
    /// Gets or Sets RegistrationEmailAsUsername
    /// </summary>
    [DataMember(Name="registrationEmailAsUsername", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registrationEmailAsUsername")]
    public bool? RegistrationEmailAsUsername { get; set; }

    /// <summary>
    /// Gets or Sets RegistrationFlow
    /// </summary>
    [DataMember(Name="registrationFlow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registrationFlow")]
    public string RegistrationFlow { get; set; }

    /// <summary>
    /// Gets or Sets RememberMe
    /// </summary>
    [DataMember(Name="rememberMe", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rememberMe")]
    public bool? RememberMe { get; set; }

    /// <summary>
    /// Gets or Sets RequiredActions
    /// </summary>
    [DataMember(Name="requiredActions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requiredActions")]
    public List<RequiredActionProviderRepresentation> RequiredActions { get; set; }

    /// <summary>
    /// Gets or Sets ResetCredentialsFlow
    /// </summary>
    [DataMember(Name="resetCredentialsFlow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resetCredentialsFlow")]
    public string ResetCredentialsFlow { get; set; }

    /// <summary>
    /// Gets or Sets ResetPasswordAllowed
    /// </summary>
    [DataMember(Name="resetPasswordAllowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resetPasswordAllowed")]
    public bool? ResetPasswordAllowed { get; set; }

    /// <summary>
    /// Gets or Sets RevokeRefreshToken
    /// </summary>
    [DataMember(Name="revokeRefreshToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revokeRefreshToken")]
    public bool? RevokeRefreshToken { get; set; }

    /// <summary>
    /// Gets or Sets Roles
    /// </summary>
    [DataMember(Name="roles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roles")]
    public RolesRepresentation Roles { get; set; }

    /// <summary>
    /// Gets or Sets ScopeMappings
    /// </summary>
    [DataMember(Name="scopeMappings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scopeMappings")]
    public List<ScopeMappingRepresentation> ScopeMappings { get; set; }

    /// <summary>
    /// Gets or Sets SmtpServer
    /// </summary>
    [DataMember(Name="smtpServer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "smtpServer")]
    public Dictionary<string, Object> SmtpServer { get; set; }

    /// <summary>
    /// Gets or Sets SslRequired
    /// </summary>
    [DataMember(Name="sslRequired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sslRequired")]
    public string SslRequired { get; set; }

    /// <summary>
    /// Gets or Sets SsoSessionIdleTimeout
    /// </summary>
    [DataMember(Name="ssoSessionIdleTimeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ssoSessionIdleTimeout")]
    public int? SsoSessionIdleTimeout { get; set; }

    /// <summary>
    /// Gets or Sets SsoSessionIdleTimeoutRememberMe
    /// </summary>
    [DataMember(Name="ssoSessionIdleTimeoutRememberMe", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ssoSessionIdleTimeoutRememberMe")]
    public int? SsoSessionIdleTimeoutRememberMe { get; set; }

    /// <summary>
    /// Gets or Sets SsoSessionMaxLifespan
    /// </summary>
    [DataMember(Name="ssoSessionMaxLifespan", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ssoSessionMaxLifespan")]
    public int? SsoSessionMaxLifespan { get; set; }

    /// <summary>
    /// Gets or Sets SsoSessionMaxLifespanRememberMe
    /// </summary>
    [DataMember(Name="ssoSessionMaxLifespanRememberMe", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ssoSessionMaxLifespanRememberMe")]
    public int? SsoSessionMaxLifespanRememberMe { get; set; }

    /// <summary>
    /// Gets or Sets SupportedLocales
    /// </summary>
    [DataMember(Name="supportedLocales", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supportedLocales")]
    public List<string> SupportedLocales { get; set; }

    /// <summary>
    /// Gets or Sets UserFederationMappers
    /// </summary>
    [DataMember(Name="userFederationMappers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userFederationMappers")]
    public List<UserFederationMapperRepresentation> UserFederationMappers { get; set; }

    /// <summary>
    /// Gets or Sets UserFederationProviders
    /// </summary>
    [DataMember(Name="userFederationProviders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userFederationProviders")]
    public List<UserFederationProviderRepresentation> UserFederationProviders { get; set; }

    /// <summary>
    /// Gets or Sets UserManagedAccessAllowed
    /// </summary>
    [DataMember(Name="userManagedAccessAllowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userManagedAccessAllowed")]
    public bool? UserManagedAccessAllowed { get; set; }

    /// <summary>
    /// Gets or Sets Users
    /// </summary>
    [DataMember(Name="users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "users")]
    public List<UserRepresentation> Users { get; set; }

    /// <summary>
    /// Gets or Sets VerifyEmail
    /// </summary>
    [DataMember(Name="verifyEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verifyEmail")]
    public bool? VerifyEmail { get; set; }

    /// <summary>
    /// Gets or Sets WaitIncrementSeconds
    /// </summary>
    [DataMember(Name="waitIncrementSeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "waitIncrementSeconds")]
    public int? WaitIncrementSeconds { get; set; }

    /// <summary>
    /// Gets or Sets WebAuthnPolicyAcceptableAaguids
    /// </summary>
    [DataMember(Name="webAuthnPolicyAcceptableAaguids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webAuthnPolicyAcceptableAaguids")]
    public List<string> WebAuthnPolicyAcceptableAaguids { get; set; }

    /// <summary>
    /// Gets or Sets WebAuthnPolicyAttestationConveyancePreference
    /// </summary>
    [DataMember(Name="webAuthnPolicyAttestationConveyancePreference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webAuthnPolicyAttestationConveyancePreference")]
    public string WebAuthnPolicyAttestationConveyancePreference { get; set; }

    /// <summary>
    /// Gets or Sets WebAuthnPolicyAuthenticatorAttachment
    /// </summary>
    [DataMember(Name="webAuthnPolicyAuthenticatorAttachment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webAuthnPolicyAuthenticatorAttachment")]
    public string WebAuthnPolicyAuthenticatorAttachment { get; set; }

    /// <summary>
    /// Gets or Sets WebAuthnPolicyAvoidSameAuthenticatorRegister
    /// </summary>
    [DataMember(Name="webAuthnPolicyAvoidSameAuthenticatorRegister", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webAuthnPolicyAvoidSameAuthenticatorRegister")]
    public bool? WebAuthnPolicyAvoidSameAuthenticatorRegister { get; set; }

    /// <summary>
    /// Gets or Sets WebAuthnPolicyCreateTimeout
    /// </summary>
    [DataMember(Name="webAuthnPolicyCreateTimeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webAuthnPolicyCreateTimeout")]
    public int? WebAuthnPolicyCreateTimeout { get; set; }

    /// <summary>
    /// Gets or Sets WebAuthnPolicyRequireResidentKey
    /// </summary>
    [DataMember(Name="webAuthnPolicyRequireResidentKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webAuthnPolicyRequireResidentKey")]
    public string WebAuthnPolicyRequireResidentKey { get; set; }

    /// <summary>
    /// Gets or Sets WebAuthnPolicyRpEntityName
    /// </summary>
    [DataMember(Name="webAuthnPolicyRpEntityName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webAuthnPolicyRpEntityName")]
    public string WebAuthnPolicyRpEntityName { get; set; }

    /// <summary>
    /// Gets or Sets WebAuthnPolicyRpId
    /// </summary>
    [DataMember(Name="webAuthnPolicyRpId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webAuthnPolicyRpId")]
    public string WebAuthnPolicyRpId { get; set; }

    /// <summary>
    /// Gets or Sets WebAuthnPolicySignatureAlgorithms
    /// </summary>
    [DataMember(Name="webAuthnPolicySignatureAlgorithms", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webAuthnPolicySignatureAlgorithms")]
    public List<string> WebAuthnPolicySignatureAlgorithms { get; set; }

    /// <summary>
    /// Gets or Sets WebAuthnPolicyUserVerificationRequirement
    /// </summary>
    [DataMember(Name="webAuthnPolicyUserVerificationRequirement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webAuthnPolicyUserVerificationRequirement")]
    public string WebAuthnPolicyUserVerificationRequirement { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RealmRepresentation {\n");
      sb.Append("  AccessCodeLifespan: ").Append(AccessCodeLifespan).Append("\n");
      sb.Append("  AccessCodeLifespanLogin: ").Append(AccessCodeLifespanLogin).Append("\n");
      sb.Append("  AccessCodeLifespanUserAction: ").Append(AccessCodeLifespanUserAction).Append("\n");
      sb.Append("  AccessTokenLifespan: ").Append(AccessTokenLifespan).Append("\n");
      sb.Append("  AccessTokenLifespanForImplicitFlow: ").Append(AccessTokenLifespanForImplicitFlow).Append("\n");
      sb.Append("  AccountTheme: ").Append(AccountTheme).Append("\n");
      sb.Append("  ActionTokenGeneratedByAdminLifespan: ").Append(ActionTokenGeneratedByAdminLifespan).Append("\n");
      sb.Append("  ActionTokenGeneratedByUserLifespan: ").Append(ActionTokenGeneratedByUserLifespan).Append("\n");
      sb.Append("  AdminEventsDetailsEnabled: ").Append(AdminEventsDetailsEnabled).Append("\n");
      sb.Append("  AdminEventsEnabled: ").Append(AdminEventsEnabled).Append("\n");
      sb.Append("  AdminTheme: ").Append(AdminTheme).Append("\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
      sb.Append("  AuthenticationFlows: ").Append(AuthenticationFlows).Append("\n");
      sb.Append("  AuthenticatorConfig: ").Append(AuthenticatorConfig).Append("\n");
      sb.Append("  BrowserFlow: ").Append(BrowserFlow).Append("\n");
      sb.Append("  BrowserSecurityHeaders: ").Append(BrowserSecurityHeaders).Append("\n");
      sb.Append("  BruteForceProtected: ").Append(BruteForceProtected).Append("\n");
      sb.Append("  ClientAuthenticationFlow: ").Append(ClientAuthenticationFlow).Append("\n");
      sb.Append("  ClientScopeMappings: ").Append(ClientScopeMappings).Append("\n");
      sb.Append("  ClientScopes: ").Append(ClientScopes).Append("\n");
      sb.Append("  Clients: ").Append(Clients).Append("\n");
      sb.Append("  Components: ").Append(Components).Append("\n");
      sb.Append("  DefaultDefaultClientScopes: ").Append(DefaultDefaultClientScopes).Append("\n");
      sb.Append("  DefaultGroups: ").Append(DefaultGroups).Append("\n");
      sb.Append("  DefaultLocale: ").Append(DefaultLocale).Append("\n");
      sb.Append("  DefaultOptionalClientScopes: ").Append(DefaultOptionalClientScopes).Append("\n");
      sb.Append("  DefaultRoles: ").Append(DefaultRoles).Append("\n");
      sb.Append("  DefaultSignatureAlgorithm: ").Append(DefaultSignatureAlgorithm).Append("\n");
      sb.Append("  DirectGrantFlow: ").Append(DirectGrantFlow).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  DisplayNameHtml: ").Append(DisplayNameHtml).Append("\n");
      sb.Append("  DockerAuthenticationFlow: ").Append(DockerAuthenticationFlow).Append("\n");
      sb.Append("  DuplicateEmailsAllowed: ").Append(DuplicateEmailsAllowed).Append("\n");
      sb.Append("  EditUsernameAllowed: ").Append(EditUsernameAllowed).Append("\n");
      sb.Append("  EmailTheme: ").Append(EmailTheme).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  EnabledEventTypes: ").Append(EnabledEventTypes).Append("\n");
      sb.Append("  EventsEnabled: ").Append(EventsEnabled).Append("\n");
      sb.Append("  EventsExpiration: ").Append(EventsExpiration).Append("\n");
      sb.Append("  EventsListeners: ").Append(EventsListeners).Append("\n");
      sb.Append("  FailureFactor: ").Append(FailureFactor).Append("\n");
      sb.Append("  FederatedUsers: ").Append(FederatedUsers).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IdentityProviderMappers: ").Append(IdentityProviderMappers).Append("\n");
      sb.Append("  IdentityProviders: ").Append(IdentityProviders).Append("\n");
      sb.Append("  InternationalizationEnabled: ").Append(InternationalizationEnabled).Append("\n");
      sb.Append("  KeycloakVersion: ").Append(KeycloakVersion).Append("\n");
      sb.Append("  LoginTheme: ").Append(LoginTheme).Append("\n");
      sb.Append("  LoginWithEmailAllowed: ").Append(LoginWithEmailAllowed).Append("\n");
      sb.Append("  MaxDeltaTimeSeconds: ").Append(MaxDeltaTimeSeconds).Append("\n");
      sb.Append("  MaxFailureWaitSeconds: ").Append(MaxFailureWaitSeconds).Append("\n");
      sb.Append("  MinimumQuickLoginWaitSeconds: ").Append(MinimumQuickLoginWaitSeconds).Append("\n");
      sb.Append("  NotBefore: ").Append(NotBefore).Append("\n");
      sb.Append("  OfflineSessionIdleTimeout: ").Append(OfflineSessionIdleTimeout).Append("\n");
      sb.Append("  OfflineSessionMaxLifespan: ").Append(OfflineSessionMaxLifespan).Append("\n");
      sb.Append("  OfflineSessionMaxLifespanEnabled: ").Append(OfflineSessionMaxLifespanEnabled).Append("\n");
      sb.Append("  OtpPolicyAlgorithm: ").Append(OtpPolicyAlgorithm).Append("\n");
      sb.Append("  OtpPolicyDigits: ").Append(OtpPolicyDigits).Append("\n");
      sb.Append("  OtpPolicyInitialCounter: ").Append(OtpPolicyInitialCounter).Append("\n");
      sb.Append("  OtpPolicyLookAheadWindow: ").Append(OtpPolicyLookAheadWindow).Append("\n");
      sb.Append("  OtpPolicyPeriod: ").Append(OtpPolicyPeriod).Append("\n");
      sb.Append("  OtpPolicyType: ").Append(OtpPolicyType).Append("\n");
      sb.Append("  OtpSupportedApplications: ").Append(OtpSupportedApplications).Append("\n");
      sb.Append("  PasswordPolicy: ").Append(PasswordPolicy).Append("\n");
      sb.Append("  PermanentLockout: ").Append(PermanentLockout).Append("\n");
      sb.Append("  ProtocolMappers: ").Append(ProtocolMappers).Append("\n");
      sb.Append("  QuickLoginCheckMilliSeconds: ").Append(QuickLoginCheckMilliSeconds).Append("\n");
      sb.Append("  Realm: ").Append(Realm).Append("\n");
      sb.Append("  RefreshTokenMaxReuse: ").Append(RefreshTokenMaxReuse).Append("\n");
      sb.Append("  RegistrationAllowed: ").Append(RegistrationAllowed).Append("\n");
      sb.Append("  RegistrationEmailAsUsername: ").Append(RegistrationEmailAsUsername).Append("\n");
      sb.Append("  RegistrationFlow: ").Append(RegistrationFlow).Append("\n");
      sb.Append("  RememberMe: ").Append(RememberMe).Append("\n");
      sb.Append("  RequiredActions: ").Append(RequiredActions).Append("\n");
      sb.Append("  ResetCredentialsFlow: ").Append(ResetCredentialsFlow).Append("\n");
      sb.Append("  ResetPasswordAllowed: ").Append(ResetPasswordAllowed).Append("\n");
      sb.Append("  RevokeRefreshToken: ").Append(RevokeRefreshToken).Append("\n");
      sb.Append("  Roles: ").Append(Roles).Append("\n");
      sb.Append("  ScopeMappings: ").Append(ScopeMappings).Append("\n");
      sb.Append("  SmtpServer: ").Append(SmtpServer).Append("\n");
      sb.Append("  SslRequired: ").Append(SslRequired).Append("\n");
      sb.Append("  SsoSessionIdleTimeout: ").Append(SsoSessionIdleTimeout).Append("\n");
      sb.Append("  SsoSessionIdleTimeoutRememberMe: ").Append(SsoSessionIdleTimeoutRememberMe).Append("\n");
      sb.Append("  SsoSessionMaxLifespan: ").Append(SsoSessionMaxLifespan).Append("\n");
      sb.Append("  SsoSessionMaxLifespanRememberMe: ").Append(SsoSessionMaxLifespanRememberMe).Append("\n");
      sb.Append("  SupportedLocales: ").Append(SupportedLocales).Append("\n");
      sb.Append("  UserFederationMappers: ").Append(UserFederationMappers).Append("\n");
      sb.Append("  UserFederationProviders: ").Append(UserFederationProviders).Append("\n");
      sb.Append("  UserManagedAccessAllowed: ").Append(UserManagedAccessAllowed).Append("\n");
      sb.Append("  Users: ").Append(Users).Append("\n");
      sb.Append("  VerifyEmail: ").Append(VerifyEmail).Append("\n");
      sb.Append("  WaitIncrementSeconds: ").Append(WaitIncrementSeconds).Append("\n");
      sb.Append("  WebAuthnPolicyAcceptableAaguids: ").Append(WebAuthnPolicyAcceptableAaguids).Append("\n");
      sb.Append("  WebAuthnPolicyAttestationConveyancePreference: ").Append(WebAuthnPolicyAttestationConveyancePreference).Append("\n");
      sb.Append("  WebAuthnPolicyAuthenticatorAttachment: ").Append(WebAuthnPolicyAuthenticatorAttachment).Append("\n");
      sb.Append("  WebAuthnPolicyAvoidSameAuthenticatorRegister: ").Append(WebAuthnPolicyAvoidSameAuthenticatorRegister).Append("\n");
      sb.Append("  WebAuthnPolicyCreateTimeout: ").Append(WebAuthnPolicyCreateTimeout).Append("\n");
      sb.Append("  WebAuthnPolicyRequireResidentKey: ").Append(WebAuthnPolicyRequireResidentKey).Append("\n");
      sb.Append("  WebAuthnPolicyRpEntityName: ").Append(WebAuthnPolicyRpEntityName).Append("\n");
      sb.Append("  WebAuthnPolicyRpId: ").Append(WebAuthnPolicyRpId).Append("\n");
      sb.Append("  WebAuthnPolicySignatureAlgorithms: ").Append(WebAuthnPolicySignatureAlgorithms).Append("\n");
      sb.Append("  WebAuthnPolicyUserVerificationRequirement: ").Append(WebAuthnPolicyUserVerificationRequirement).Append("\n");
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
