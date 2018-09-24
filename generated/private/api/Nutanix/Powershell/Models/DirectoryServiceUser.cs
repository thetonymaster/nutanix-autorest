namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>A Directory Service user.</summary>
    public partial class DirectoryServiceUser : Nutanix.Powershell.Models.IDirectoryServiceUser, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for DirectoryServiceReference property</summary>
        private Nutanix.Powershell.Models.IDirectoryServiceReference _directoryServiceReference;

        /// <summary>
        /// Directory service reference if the user type is directory service.
        /// </summary>
        public Nutanix.Powershell.Models.IDirectoryServiceReference DirectoryServiceReference
        {
            get
            {
                return this._directoryServiceReference;
            }
            set
            {
                this._directoryServiceReference = value;
            }
        }
        /// <summary>Backing field for UserPrincipalName property</summary>
        private string _userPrincipalName;

        /// <summary>
        /// The UserPrincipalName of the user from the directory service.
        /// </summary>
        public string UserPrincipalName
        {
            get
            {
                return this._userPrincipalName;
            }
            set
            {
                this._userPrincipalName = value;
            }
        }
        /// <summary>Creates an new <see cref="DirectoryServiceUser" /> instance.</summary>
        public DirectoryServiceUser()
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
            await eventListener.AssertObjectIsValid(nameof(DirectoryServiceReference), DirectoryServiceReference);
            await eventListener.AssertMaximumLength(nameof(UserPrincipalName),UserPrincipalName,104);
        }
    }
    /// A Directory Service user.
    public partial interface IDirectoryServiceUser : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IDirectoryServiceReference DirectoryServiceReference { get; set; }
        string UserPrincipalName { get; set; }
    }
}