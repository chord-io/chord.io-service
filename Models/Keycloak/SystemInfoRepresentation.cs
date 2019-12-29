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
  public class SystemInfoRepresentation {
    /// <summary>
    /// Gets or Sets FileEncoding
    /// </summary>
    [DataMember(Name="fileEncoding", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileEncoding")]
    public string FileEncoding { get; set; }

    /// <summary>
    /// Gets or Sets JavaHome
    /// </summary>
    [DataMember(Name="javaHome", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "javaHome")]
    public string JavaHome { get; set; }

    /// <summary>
    /// Gets or Sets JavaRuntime
    /// </summary>
    [DataMember(Name="javaRuntime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "javaRuntime")]
    public string JavaRuntime { get; set; }

    /// <summary>
    /// Gets or Sets JavaVendor
    /// </summary>
    [DataMember(Name="javaVendor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "javaVendor")]
    public string JavaVendor { get; set; }

    /// <summary>
    /// Gets or Sets JavaVersion
    /// </summary>
    [DataMember(Name="javaVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "javaVersion")]
    public string JavaVersion { get; set; }

    /// <summary>
    /// Gets or Sets JavaVm
    /// </summary>
    [DataMember(Name="javaVm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "javaVm")]
    public string JavaVm { get; set; }

    /// <summary>
    /// Gets or Sets JavaVmVersion
    /// </summary>
    [DataMember(Name="javaVmVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "javaVmVersion")]
    public string JavaVmVersion { get; set; }

    /// <summary>
    /// Gets or Sets OsArchitecture
    /// </summary>
    [DataMember(Name="osArchitecture", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "osArchitecture")]
    public string OsArchitecture { get; set; }

    /// <summary>
    /// Gets or Sets OsName
    /// </summary>
    [DataMember(Name="osName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "osName")]
    public string OsName { get; set; }

    /// <summary>
    /// Gets or Sets OsVersion
    /// </summary>
    [DataMember(Name="osVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "osVersion")]
    public string OsVersion { get; set; }

    /// <summary>
    /// Gets or Sets ServerTime
    /// </summary>
    [DataMember(Name="serverTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serverTime")]
    public string ServerTime { get; set; }

    /// <summary>
    /// Gets or Sets Uptime
    /// </summary>
    [DataMember(Name="uptime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uptime")]
    public string Uptime { get; set; }

    /// <summary>
    /// Gets or Sets UptimeMillis
    /// </summary>
    [DataMember(Name="uptimeMillis", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uptimeMillis")]
    public long? UptimeMillis { get; set; }

    /// <summary>
    /// Gets or Sets UserDir
    /// </summary>
    [DataMember(Name="userDir", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userDir")]
    public string UserDir { get; set; }

    /// <summary>
    /// Gets or Sets UserLocale
    /// </summary>
    [DataMember(Name="userLocale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userLocale")]
    public string UserLocale { get; set; }

    /// <summary>
    /// Gets or Sets UserName
    /// </summary>
    [DataMember(Name="userName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userName")]
    public string UserName { get; set; }

    /// <summary>
    /// Gets or Sets UserTimezone
    /// </summary>
    [DataMember(Name="userTimezone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userTimezone")]
    public string UserTimezone { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SystemInfoRepresentation {\n");
      sb.Append("  FileEncoding: ").Append(FileEncoding).Append("\n");
      sb.Append("  JavaHome: ").Append(JavaHome).Append("\n");
      sb.Append("  JavaRuntime: ").Append(JavaRuntime).Append("\n");
      sb.Append("  JavaVendor: ").Append(JavaVendor).Append("\n");
      sb.Append("  JavaVersion: ").Append(JavaVersion).Append("\n");
      sb.Append("  JavaVm: ").Append(JavaVm).Append("\n");
      sb.Append("  JavaVmVersion: ").Append(JavaVmVersion).Append("\n");
      sb.Append("  OsArchitecture: ").Append(OsArchitecture).Append("\n");
      sb.Append("  OsName: ").Append(OsName).Append("\n");
      sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
      sb.Append("  ServerTime: ").Append(ServerTime).Append("\n");
      sb.Append("  Uptime: ").Append(Uptime).Append("\n");
      sb.Append("  UptimeMillis: ").Append(UptimeMillis).Append("\n");
      sb.Append("  UserDir: ").Append(UserDir).Append("\n");
      sb.Append("  UserLocale: ").Append(UserLocale).Append("\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
      sb.Append("  UserTimezone: ").Append(UserTimezone).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
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
