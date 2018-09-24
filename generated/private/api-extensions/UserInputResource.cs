namespace Nutanix.Powershell.Models
{

    /// <summary>User Resource Definition.</summary>
    [System.ComponentModel.TypeConverter(typeof(UserInputResourceTypeConverter))]
    public partial class UserInputResource
    {

        /// <summary>
        /// Creates a new instance of <see cref="UserInputResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IUserInputResource FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// User Resource Definition.
    [System.ComponentModel.TypeConverter(typeof(UserInputResourceTypeConverter))]
    public partial interface IUserInputResource {

    }
}