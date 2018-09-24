namespace Nutanix.Powershell.Models
{

    /// <summary>
    /// All api calls that return a list will have this metadata block as input
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(AccessControlPolicyListMetadataTypeConverter))]
    public partial class AccessControlPolicyListMetadata
    {

        /// <summary>
        /// Creates a new instance of <see cref="AccessControlPolicyListMetadata" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IAccessControlPolicyListMetadata FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// All api calls that return a list will have this metadata block as input
    [System.ComponentModel.TypeConverter(typeof(AccessControlPolicyListMetadataTypeConverter))]
    public partial interface IAccessControlPolicyListMetadata {

    }
}