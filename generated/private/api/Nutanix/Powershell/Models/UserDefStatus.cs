namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>User status definition.</summary>
    public partial class UserDefStatus : Nutanix.Powershell.Models.IUserDefStatus, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for MessageList property</summary>
        private Nutanix.Powershell.Models.IMessageResource[] _messageList;

        public Nutanix.Powershell.Models.IMessageResource[] MessageList
        {
            get
            {
                return this._messageList;
            }
            set
            {
                this._messageList = value;
            }
        }
        /// <summary>Backing field for Name property</summary>
        private string _name;

        /// <summary>Name of the User.</summary>
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>Backing field for Resources property</summary>
        private Nutanix.Powershell.Models.IUserStatusResource _resources;

        /// <summary>User Resource Definition.</summary>
        public Nutanix.Powershell.Models.IUserStatusResource Resources
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
        /// <summary>Backing field for State property</summary>
        private string _state;

        /// <summary>The state of the entity.</summary>
        public string State
        {
            get
            {
                return this._state;
            }
            set
            {
                this._state = value;
            }
        }
        /// <summary>Creates an new <see cref="UserDefStatus" /> instance.</summary>
        public UserDefStatus()
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
            await eventListener.AssertNotNull(nameof(Name),Name);
            if (MessageList != null ) {
                    for (int __i = 0; __i < MessageList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"MessageList[{__i}]", MessageList[__i]);
                    }
                  }
            await eventListener.AssertNotNull(nameof(Resources), Resources);
            await eventListener.AssertObjectIsValid(nameof(Resources), Resources);
        }
    }
    /// User status definition.
    public partial interface IUserDefStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IMessageResource[] MessageList { get; set; }
        string Name { get; set; }
        Nutanix.Powershell.Models.IUserStatusResource Resources { get; set; }
        string State { get; set; }
    }
}