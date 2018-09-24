namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>message.</summary>
    public partial class MessageResource : Nutanix.Powershell.Models.IMessageResource, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Details property</summary>
        private System.Collections.Generic.IDictionary<string,string> _details;

        /// <summary>Custom key-value details relevant to the status.</summary>
        public System.Collections.Generic.IDictionary<string,string> Details
        {
            get
            {
                return this._details;
            }
            internal set
            {
                this._details = value;
            }
        }
        /// <summary>Backing field for Message property</summary>
        private string _message;

        /// <summary>If state is ERROR, a message describing the error.</summary>
        public string Message
        {
            get
            {
                return this._message;
            }
            set
            {
                this._message = value;
            }
        }
        /// <summary>Backing field for Reason property</summary>
        private string _reason;

        /// <summary>If state is ERROR, a machine-readable snake-cased string.</summary>
        public string Reason
        {
            get
            {
                return this._reason;
            }
            set
            {
                this._reason = value;
            }
        }
        /// <summary>Creates an new <see cref="MessageResource" /> instance.</summary>
        public MessageResource()
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
            await eventListener.AssertNotNull(nameof(Message),Message);
            await eventListener.AssertNotNull(nameof(Reason),Reason);
        }
    }
    /// message.
    public partial interface IMessageResource : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        System.Collections.Generic.IDictionary<string,string> Details { get;  }
        string Message { get; set; }
        string Reason { get; set; }
    }
}