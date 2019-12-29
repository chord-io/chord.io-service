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
  public class AccessToken {
    /// <summary>
    /// Gets or Sets Acr
    /// </summary>
    [DataMember(Name="acr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acr")]
    public string Acr { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public AddressClaimSet Address { get; set; }

    /// <summary>
    /// Gets or Sets AllowedOrigins
    /// </summary>
    [DataMember(Name="allowed-origins", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowed-origins")]
    public List<string> AllowedOrigins { get; set; }

    /// <summary>
    /// Gets or Sets AtHash
    /// </summary>
    [DataMember(Name="at_hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "at_hash")]
    public string AtHash { get; set; }

    /// <summary>
    /// Gets or Sets AuthTime
    /// </summary>
    [DataMember(Name="auth_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "auth_time")]
    public int? AuthTime { get; set; }

    /// <summary>
    /// Gets or Sets Authorization
    /// </summary>
    [DataMember(Name="authorization", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authorization")]
    public AccessTokenAuthorization Authorization { get; set; }

    /// <summary>
    /// Gets or Sets Azp
    /// </summary>
    [DataMember(Name="azp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "azp")]
    public string Azp { get; set; }

    /// <summary>
    /// Gets or Sets Birthdate
    /// </summary>
    [DataMember(Name="birthdate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "birthdate")]
    public string Birthdate { get; set; }

    /// <summary>
    /// Gets or Sets CHash
    /// </summary>
    [DataMember(Name="c_hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "c_hash")]
    public string CHash { get; set; }

    /// <summary>
    /// Gets or Sets Category
    /// </summary>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; }

    /// <summary>
    /// Gets or Sets ClaimsLocales
    /// </summary>
    [DataMember(Name="claims_locales", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "claims_locales")]
    public string ClaimsLocales { get; set; }

    /// <summary>
    /// Gets or Sets Cnf
    /// </summary>
    [DataMember(Name="cnf", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cnf")]
    public AccessTokenCertConf Cnf { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets EmailVerified
    /// </summary>
    [DataMember(Name="email_verified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email_verified")]
    public bool? EmailVerified { get; set; }

    /// <summary>
    /// Gets or Sets Exp
    /// </summary>
    [DataMember(Name="exp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exp")]
    public int? Exp { get; set; }

    /// <summary>
    /// Gets or Sets FamilyName
    /// </summary>
    [DataMember(Name="family_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "family_name")]
    public string FamilyName { get; set; }

    /// <summary>
    /// Gets or Sets Gender
    /// </summary>
    [DataMember(Name="gender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gender")]
    public string Gender { get; set; }

    /// <summary>
    /// Gets or Sets GivenName
    /// </summary>
    [DataMember(Name="given_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "given_name")]
    public string GivenName { get; set; }

    /// <summary>
    /// Gets or Sets Iat
    /// </summary>
    [DataMember(Name="iat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iat")]
    public int? Iat { get; set; }

    /// <summary>
    /// Gets or Sets Iss
    /// </summary>
    [DataMember(Name="iss", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iss")]
    public string Iss { get; set; }

    /// <summary>
    /// Gets or Sets Jti
    /// </summary>
    [DataMember(Name="jti", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jti")]
    public string Jti { get; set; }

    /// <summary>
    /// Gets or Sets Locale
    /// </summary>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }

    /// <summary>
    /// Gets or Sets MiddleName
    /// </summary>
    [DataMember(Name="middle_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "middle_name")]
    public string MiddleName { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Nickname
    /// </summary>
    [DataMember(Name="nickname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nickname")]
    public string Nickname { get; set; }

    /// <summary>
    /// Gets or Sets Nonce
    /// </summary>
    [DataMember(Name="nonce", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nonce")]
    public string Nonce { get; set; }

    /// <summary>
    /// Gets or Sets OtherClaims
    /// </summary>
    [DataMember(Name="otherClaims", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "otherClaims")]
    public Dictionary<string, Object> OtherClaims { get; set; }

    /// <summary>
    /// Gets or Sets PhoneNumber
    /// </summary>
    [DataMember(Name="phone_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone_number")]
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Gets or Sets PhoneNumberVerified
    /// </summary>
    [DataMember(Name="phone_number_verified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone_number_verified")]
    public bool? PhoneNumberVerified { get; set; }

    /// <summary>
    /// Gets or Sets Picture
    /// </summary>
    [DataMember(Name="picture", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "picture")]
    public string Picture { get; set; }

    /// <summary>
    /// Gets or Sets PreferredUsername
    /// </summary>
    [DataMember(Name="preferred_username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "preferred_username")]
    public string PreferredUsername { get; set; }

    /// <summary>
    /// Gets or Sets Profile
    /// </summary>
    [DataMember(Name="profile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profile")]
    public string Profile { get; set; }

    /// <summary>
    /// Gets or Sets RealmAccess
    /// </summary>
    [DataMember(Name="realm_access", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "realm_access")]
    public AccessTokenAccess RealmAccess { get; set; }

    /// <summary>
    /// Gets or Sets SHash
    /// </summary>
    [DataMember(Name="s_hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "s_hash")]
    public string SHash { get; set; }

    /// <summary>
    /// Gets or Sets Scope
    /// </summary>
    [DataMember(Name="scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scope")]
    public string Scope { get; set; }

    /// <summary>
    /// Gets or Sets SessionState
    /// </summary>
    [DataMember(Name="session_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "session_state")]
    public string SessionState { get; set; }

    /// <summary>
    /// Gets or Sets Sub
    /// </summary>
    [DataMember(Name="sub", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sub")]
    public string Sub { get; set; }

    /// <summary>
    /// Gets or Sets TrustedCerts
    /// </summary>
    [DataMember(Name="trusted-certs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trusted-certs")]
    public List<string> TrustedCerts { get; set; }

    /// <summary>
    /// Gets or Sets Typ
    /// </summary>
    [DataMember(Name="typ", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "typ")]
    public string Typ { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedAt
    /// </summary>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public long? UpdatedAt { get; set; }

    /// <summary>
    /// Gets or Sets Website
    /// </summary>
    [DataMember(Name="website", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "website")]
    public string Website { get; set; }

    /// <summary>
    /// Gets or Sets Zoneinfo
    /// </summary>
    [DataMember(Name="zoneinfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zoneinfo")]
    public string Zoneinfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccessToken {\n");
      sb.Append("  Acr: ").Append(Acr).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  AllowedOrigins: ").Append(AllowedOrigins).Append("\n");
      sb.Append("  AtHash: ").Append(AtHash).Append("\n");
      sb.Append("  AuthTime: ").Append(AuthTime).Append("\n");
      sb.Append("  Authorization: ").Append(Authorization).Append("\n");
      sb.Append("  Azp: ").Append(Azp).Append("\n");
      sb.Append("  Birthdate: ").Append(Birthdate).Append("\n");
      sb.Append("  CHash: ").Append(CHash).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  ClaimsLocales: ").Append(ClaimsLocales).Append("\n");
      sb.Append("  Cnf: ").Append(Cnf).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  EmailVerified: ").Append(EmailVerified).Append("\n");
      sb.Append("  Exp: ").Append(Exp).Append("\n");
      sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      sb.Append("  GivenName: ").Append(GivenName).Append("\n");
      sb.Append("  Iat: ").Append(Iat).Append("\n");
      sb.Append("  Iss: ").Append(Iss).Append("\n");
      sb.Append("  Jti: ").Append(Jti).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Nickname: ").Append(Nickname).Append("\n");
      sb.Append("  Nonce: ").Append(Nonce).Append("\n");
      sb.Append("  OtherClaims: ").Append(OtherClaims).Append("\n");
      sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
      sb.Append("  PhoneNumberVerified: ").Append(PhoneNumberVerified).Append("\n");
      sb.Append("  Picture: ").Append(Picture).Append("\n");
      sb.Append("  PreferredUsername: ").Append(PreferredUsername).Append("\n");
      sb.Append("  Profile: ").Append(Profile).Append("\n");
      sb.Append("  RealmAccess: ").Append(RealmAccess).Append("\n");
      sb.Append("  SHash: ").Append(SHash).Append("\n");
      sb.Append("  Scope: ").Append(Scope).Append("\n");
      sb.Append("  SessionState: ").Append(SessionState).Append("\n");
      sb.Append("  Sub: ").Append(Sub).Append("\n");
      sb.Append("  TrustedCerts: ").Append(TrustedCerts).Append("\n");
      sb.Append("  Typ: ").Append(Typ).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Website: ").Append(Website).Append("\n");
      sb.Append("  Zoneinfo: ").Append(Zoneinfo).Append("\n");
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
