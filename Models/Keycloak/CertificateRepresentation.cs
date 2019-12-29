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
  public class CertificateRepresentation {
    /// <summary>
    /// Gets or Sets Certificate
    /// </summary>
    [DataMember(Name="certificate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "certificate")]
    public string Certificate { get; set; }

    /// <summary>
    /// Gets or Sets Kid
    /// </summary>
    [DataMember(Name="kid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kid")]
    public string Kid { get; set; }

    /// <summary>
    /// Gets or Sets PrivateKey
    /// </summary>
    [DataMember(Name="privateKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "privateKey")]
    public string PrivateKey { get; set; }

    /// <summary>
    /// Gets or Sets PublicKey
    /// </summary>
    [DataMember(Name="publicKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publicKey")]
    public string PublicKey { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CertificateRepresentation {\n");
      sb.Append("  Certificate: ").Append(Certificate).Append("\n");
      sb.Append("  Kid: ").Append(Kid).Append("\n");
      sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
      sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
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
