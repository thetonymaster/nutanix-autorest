namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>User Input Definition.</summary>
    public partial class User : Nutanix.Powershell.Models.IUser, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Resources property</summary>
        private Nutanix.Powershell.Models.IUserInputResource _resources;

        /// <summary>User Resource Definition.</summary>
        public Nutanix.Powershell.Models.IUserInputResource Resources
        {
            get
            {
                return this._resources;
            }
            set
            {
                this._resources = value;
            }
        }
        /// <summary>Creates an new <see cref="User" /> instance.</summary>
        public User()
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
            await eventListener.AssertNotNull(nameof(Resources), Resources);
            await eventListener.AssertObjectIsValid(nameof(Resources), Resources);
        }
    }
    /// User Input Definition.
    public partial interface IUser : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IUserInputResource Resources { get; set; }
    }
}