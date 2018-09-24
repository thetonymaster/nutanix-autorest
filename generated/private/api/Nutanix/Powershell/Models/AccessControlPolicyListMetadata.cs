namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// All api calls that return a list will have this metadata block as input
    /// </summary>
    public partial class AccessControlPolicyListMetadata : Nutanix.Powershell.Models.IAccessControlPolicyListMetadata, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Filter property</summary>
        private string _filter;

        /// <summary>The filter in FIQL syntax used for the results.</summary>
        public string Filter
        {
            get
            {
                return this._filter;
            }
            set
            {
                this._filter = value;
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
            set
            {
                this._kind = value;
            }
        }
        /// <summary>Backing field for Length property</summary>
        private int? _length;

        /// <summary>The number of records to retrieve relative to the offset</summary>
        public int? Length
        {
            get
            {
                return this._length;
            }
            set
            {
                this._length = value;
            }
        }
        /// <summary>Backing field for Offset property</summary>
        private int? _offset;

        /// <summary>Offset from the start of the entity list</summary>
        public int? Offset
        {
            get
            {
                return this._offset;
            }
            set
            {
                this._offset = value;
            }
        }
        /// <summary>Backing field for SortAttribute property</summary>
        private string _sortAttribute;

        /// <summary>The attribute to perform sort on</summary>
        public string SortAttribute
        {
            get
            {
                return this._sortAttribute;
            }
            set
            {
                this._sortAttribute = value;
            }
        }
        /// <summary>Creates an new <see cref="AccessControlPolicyListMetadata" /> instance.</summary>
        public AccessControlPolicyListMetadata()
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
            await eventListener.AssertIsGreaterThanOrEqual(nameof(Length),Length,1);
        }
    }
    /// All api calls that return a list will have this metadata block as input
    public partial interface IAccessControlPolicyListMetadata : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Filter { get; set; }
        string Kind { get; set; }
        int? Length { get; set; }
        int? Offset { get; set; }
        string SortAttribute { get; set; }
    }
}