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
  public class AddressClaimSet {
    /// <summary>
    /// Gets or Sets Country
    /// </summary>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or Sets Formatted
    /// </summary>
    [DataMember(Name="formatted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "formatted")]
    public string Formatted { get; set; }

    /// <summary>
    /// Gets or Sets Locality
    /// </summary>
    [DataMember(Name="locality", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locality")]
    public string Locality { get; set; }

    /// <summary>
    /// Gets or Sets PostalCode
    /// </summary>
    [DataMember(Name="postal_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postal_code")]
    public string PostalCode { get; set; }

    /// <summary>
    /// Gets or Sets Region
    /// </summary>
    [DataMember(Name="region", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "region")]
    public string Region { get; set; }

    /// <summary>
    /// Gets or Sets StreetAddress
    /// </summary>
    [DataMember(Name="street_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "street_address")]
    public string StreetAddress { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AddressClaimSet {\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  Formatted: ").Append(Formatted).Append("\n");
      sb.Append("  Locality: ").Append(Locality).Append("\n");
      sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
      sb.Append("  Region: ").Append(Region).Append("\n");
      sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
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
