namespace Nutanix.Powershell.Models
{

    /// <summary>The reference to a access_control_policy</summary>
    [System.ComponentModel.TypeConverter(typeof(AccessControlPolicyReferenceTypeConverter))]
    public partial class AccessControlPolicyReference
    {

        /// <summary>
        /// Creates a new instance of <see cref="AccessControlPolicyReference" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IAccessControlPolicyReference FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The reference to a access_control_policy
    [System.ComponentModel.TypeConverter(typeof(AccessControlPolicyReferenceTypeConverter))]
    public partial interface IAccessControlPolicyReference {

    }
}