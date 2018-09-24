namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Response object for intentful operation of access_control_policys</summary>
    public partial class AccessControlPolicyListIntentResponse : Nutanix.Powershell.Models.IAccessControlPolicyListIntentResponse, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for ApiVersion property</summary>
        private string _apiVersion;

        public string ApiVersion
        {
            get
            {
                return this._apiVersion;
            }
            set
            {
                this._apiVersion = value;
            }
        }
        /// <summary>Backing field for Entities property</summary>
        private string _entities;

        public string Entities
        {
            get
            {
                return this._entities;
            }
            set
            {
                this._entities = value;
            }
        }
        /// <summary>Creates an new <see cref="AccessControlPolicyListIntentResponse" /> instance.</summary>
        public AccessControlPolicyListIntentResponse()
        {
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(ApiVersion),ApiVersion);
        }
    }
    /// Response object for intentful operation of access_control_policys
    public partial interface IAccessControlPolicyListIntentResponse : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        string Entities { get; set; }
    }
}