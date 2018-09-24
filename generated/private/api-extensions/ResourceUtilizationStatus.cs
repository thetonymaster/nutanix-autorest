namespace Nutanix.Powershell.Models
{

    /// <summary>stores resource utilization and limits for a domain</summary>
    [System.ComponentModel.TypeConverter(typeof(ResourceUtilizationStatusTypeConverter))]
    public partial class ResourceUtilizationStatus
    {

        /// <summary>
        /// Creates a new instance of <see cref="ResourceUtilizationStatus" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IResourceUtilizationStatus FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// stores resource utilization and limits for a domain
    [System.ComponentModel.TypeConverter(typeof(ResourceUtilizationStatusTypeConverter))]
    public partial interface IResourceUtilizationStatus {

    }
}