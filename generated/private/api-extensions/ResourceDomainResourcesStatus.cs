namespace Nutanix.Powershell.Models
{

    /// <summary>The status for a resource domain (limits and values)</summary>
    [System.ComponentModel.TypeConverter(typeof(ResourceDomainResourcesStatusTypeConverter))]
    public partial class ResourceDomainResourcesStatus
    {

        /// <summary>
        /// Creates a new instance of <see cref="ResourceDomainResourcesStatus" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IResourceDomainResourcesStatus FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The status for a resource domain (limits and values)
    [System.ComponentModel.TypeConverter(typeof(ResourceDomainResourcesStatusTypeConverter))]
    public partial interface IResourceDomainResourcesStatus {

    }
}