namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// The status of a REST API call. Only used when there is a failure to
    /// report.
    /// </summary>
    public partial class AccessControlPolicyStatus : Nutanix.Powershell.Models.IAccessControlPolicyStatus
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
        /// <summary>Creates an new <see cref="AccessControlPolicyStatus" /> instance.</summary>
        public AccessControlPolicyStatus()
        {
        }
    }
    /// The status of a REST API call. Only used when there is a failure to
    /// report.
    public partial interface IAccessControlPolicyStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get;  }
        int? Code { get;  }
        string Kind { get;  }
        string State { get;  }
    }
}