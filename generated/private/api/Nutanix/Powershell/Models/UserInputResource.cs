namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>User Resource Definition.</summary>
    public partial class UserInputResource : Nutanix.Powershell.Models.IUserInputResource, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for DirectoryServiceUser property</summary>
        private Nutanix.Powershell.Models.IDirectoryServiceUser _directoryServiceUser;

        /// <summary>A Directory Service user.</summary>
        public Nutanix.Powershell.Models.IDirectoryServiceUser DirectoryServiceUser
        {
            get
            {
                return this._directoryServiceUser;
            }
            set
            {
                this._directoryServiceUser = value;
            }
        }
        /// <summary>Creates an new <see cref="UserInputResource" /> instance.</summary>
        public UserInputResource()
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
            await eventListener.AssertObjectIsValid(nameof(DirectoryServiceUser), DirectoryServiceUser);
        }
    }
    /// User Resource Definition.
    public partial interface IUserInputResource : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IDirectoryServiceUser DirectoryServiceUser { get; set; }
    }
}