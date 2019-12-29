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
  public class KeyStoreConfig {
    /// <summary>
    /// Gets or Sets Format
    /// </summary>
    [DataMember(Name="format", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "format")]
    public string Format { get; set; }

    /// <summary>
    /// Gets or Sets KeyAlias
    /// </summary>
    [DataMember(Name="keyAlias", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "keyAlias")]
    public string KeyAlias { get; set; }

    /// <summary>
    /// Gets or Sets KeyPassword
    /// </summary>
    [DataMember(Name="keyPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "keyPassword")]
    public string KeyPassword { get; set; }

    /// <summary>
    /// Gets or Sets RealmAlias
    /// </summary>
    [DataMember(Name="realmAlias", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "realmAlias")]
    public string RealmAlias { get; set; }

    /// <summary>
    /// Gets or Sets RealmCertificate
    /// </summary>
    [DataMember(Name="realmCertificate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "realmCertificate")]
    public bool? RealmCertificate { get; set; }

    /// <summary>
    /// Gets or Sets StorePassword
    /// </summary>
    [DataMember(Name="storePassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storePassword")]
    public string StorePassword { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class KeyStoreConfig {\n");
      sb.Append("  Format: ").Append(Format).Append("\n");
      sb.Append("  KeyAlias: ").Append(KeyAlias).Append("\n");
      sb.Append("  KeyPassword: ").Append(KeyPassword).Append("\n");
      sb.Append("  RealmAlias: ").Append(RealmAlias).Append("\n");
      sb.Append("  RealmCertificate: ").Append(RealmCertificate).Append("\n");
      sb.Append("  StorePassword: ").Append(StorePassword).Append("\n");
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
