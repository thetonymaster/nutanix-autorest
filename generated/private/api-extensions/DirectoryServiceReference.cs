namespace Nutanix.Powershell.Models
{

    /// <summary>The reference to a directory_service</summary>
    [System.ComponentModel.TypeConverter(typeof(DirectoryServiceReferenceTypeConverter))]
    public partial class DirectoryServiceReference
    {

        /// <summary>
        /// Creates a new instance of <see cref="DirectoryServiceReference" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IDirectoryServiceReference FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The reference to a directory_service
    [System.ComponentModel.TypeConverter(typeof(DirectoryServiceReferenceTypeConverter))]
    public partial interface IDirectoryServiceReference {

    }
}