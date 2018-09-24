namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Response object for intentful operations on a user</summary>
    public partial class UserIntentResponse : Nutanix.Powershell.Models.IUserIntentResponse, Microsoft.Rest.ClientRuntime.IValidates
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
        /// <summary>Backing field for Metadata property</summary>
        private Nutanix.Powershell.Models.IUserMetadata _metadata;

        /// <summary>The user kind metadata</summary>
        public Nutanix.Powershell.Models.IUserMetadata Metadata
        {
            get
            {
                return this._metadata;
            }
            set
            {
                this._metadata = value;
            }
        }
        /// <summary>Backing field for Spec property</summary>
        private Nutanix.Powershell.Models.IUser _spec;

        /// <summary>User Input Definition.</summary>
        public Nutanix.Powershell.Models.IUser Spec
        {
            get
            {
                return this._spec;
            }
            set
            {
                this._spec = value;
            }
        }
        /// <summary>Backing field for Status property</summary>
        private Nutanix.Powershell.Models.IUserDefStatus _status;

        /// <summary>User status definition.</summary>
        public Nutanix.Powershell.Models.IUserDefStatus Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        /// <summary>Creates an new <see cref="UserIntentResponse" /> instance.</summary>
        public UserIntentResponse()
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
            await eventListener.AssertNotNull(nameof(Metadata), Metadata);
            await eventListener.AssertObjectIsValid(nameof(Metadata), Metadata);
            await eventListener.AssertObjectIsValid(nameof(Spec), Spec);
            await eventListener.AssertObjectIsValid(nameof(Status), Status);
        }
    }
    /// Response object for intentful operations on a user
    public partial interface IUserIntentResponse : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        Nutanix.Powershell.Models.IUserMetadata Metadata { get; set; }
        Nutanix.Powershell.Models.IUser Spec { get; set; }
        Nutanix.Powershell.Models.IUserDefStatus Status { get; set; }
    }
}