namespace Nutanix.Powershell.Models
{

    /// <summary>FIXME: Class UserStatusResourceResourceUsageSummary is MISSING DESCRIPTION</summary>
    [System.ComponentModel.TypeConverter(typeof(UserStatusResourceResourceUsageSummaryTypeConverter))]
    public partial class UserStatusResourceResourceUsageSummary
    {

        /// <summary>
        /// Creates a new instance of <see cref="UserStatusResourceResourceUsageSummary" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IUserStatusResourceResourceUsageSummary FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// FIXME: Interface IUserStatusResourceResourceUsageSummary is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(UserStatusResourceResourceUsageSummaryTypeConverter))]
    public partial interface IUserStatusResourceResourceUsageSummary {

    }
}