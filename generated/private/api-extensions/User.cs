namespace Nutanix.Powershell.Models
{

    /// <summary>User Input Definition.</summary>
    [System.ComponentModel.TypeConverter(typeof(UserTypeConverter))]
    public partial class User
    {

        /// <summary>
        /// Creates a new instance of <see cref="User" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IUser FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// User Input Definition.
    [System.ComponentModel.TypeConverter(typeof(UserTypeConverter))]
    public partial interface IUser {

    }
}