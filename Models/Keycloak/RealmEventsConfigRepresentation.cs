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
  public class RealmEventsConfigRepresentation {
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RealmEventsConfigRepresentation {\n");
      sb.Append("  AdminEventsDetailsEnabled: ").Append(AdminEventsDetailsEnabled).Append("\n");
      sb.Append("  AdminEventsEnabled: ").Append(AdminEventsEnabled).Append("\n");
      sb.Append("  EnabledEventTypes: ").Append(EnabledEventTypes).Append("\n");
      sb.Append("  EventsEnabled: ").Append(EventsEnabled).Append("\n");
      sb.Append("  EventsExpiration: ").Append(EventsExpiration).Append("\n");
      sb.Append("  EventsListeners: ").Append(EventsListeners).Append("\n");
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
