namespace Nutanix.Powershell.Models
{

    /// <summary>Response object for intentful operation of access_control_policys</summary>
    [System.ComponentModel.TypeConverter(typeof(AccessControlPolicyListIntentResponseTypeConverter))]
    public partial class AccessControlPolicyListIntentResponse
    {

        /// <summary>
        /// Creates a new instance of <see cref="AccessControlPolicyListIntentResponse" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IAccessControlPolicyListIntentResponse FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Response object for intentful operation of access_control_policys
    [System.ComponentModel.TypeConverter(typeof(AccessControlPolicyListIntentResponseTypeConverter))]
    public partial interface IAccessControlPolicyListIntentResponse {

    }
}