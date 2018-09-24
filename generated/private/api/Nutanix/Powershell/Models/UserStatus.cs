namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// The status of a REST API call. Only used when there is a failure to
    /// report.
    /// </summary>
    public partial class UserStatus : Nutanix.Powershell.Models.IUserStatus, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for ApiVersion property</summary>
        private string _apiVersion;

        public string ApiVersion
        {
            get
            {
                return this._apiVersion;
            }
            internal set
            {
                this._apiVersion = value;
            }
        }
        /// <summary>Backing field for Code property</summary>
        private int? _code;

        /// <summary>The HTTP error code.</summary>
        public int? Code
        {
            get
            {
                return this._code;
            }
            internal set
            {
                this._code = value;
            }
        }
        /// <summary>Backing field for Kind property</summary>
        private string _kind;

        /// <summary>The kind name</summary>
        public string Kind
        {
            get
            {
                return this._kind;
            }
            internal set
            {
                this._kind = value;
            }
        }
        /// <summary>Backing field for MessageList property</summary>
        private Nutanix.Powershell.Models.IMessageResource[] _messageList;

        public Nutanix.Powershell.Models.IMessageResource[] MessageList
        {
            get
            {
                return this._messageList;
            }
            internal set
            {
                this._messageList = value;
            }
        }
        /// <summary>Backing field for State property</summary>
        private string _state;

        public string State
        {
            get
            {
                return this._state;
            }
            internal set
            {
                this._state = value;
            }
        }
        /// <summary>Creates an new <see cref="UserStatus" /> instance.</summary>
        public UserStatus()
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
            if (MessageList != null ) {
                    for (int __i = 0; __i < MessageList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"MessageList[{__i}]", MessageList[__i]);
                    }
                  }
        }
    }
    /// The status of a REST API call. Only used when there is a failure to
    /// report.
    public partial interface IUserStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get;  }
        int? Code { get;  }
        string Kind { get;  }
        Nutanix.Powershell.Models.IMessageResource[] MessageList { get;  }
        string State { get;  }
    }
}