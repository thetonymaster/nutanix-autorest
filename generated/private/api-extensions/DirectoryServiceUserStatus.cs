namespace Nutanix.Powershell.Models
{

    /// <summary>A Directory Service user.</summary>
    [System.ComponentModel.TypeConverter(typeof(DirectoryServiceUserStatusTypeConverter))]
    public partial class DirectoryServiceUserStatus
    {

        /// <summary>
        /// Creates a new instance of <see cref="DirectoryServiceUserStatus" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IDirectoryServiceUserStatus FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// A Directory Service user.
    [System.ComponentModel.TypeConverter(typeof(DirectoryServiceUserStatusTypeConverter))]
    public partial interface IDirectoryServiceUserStatus {

    }
}