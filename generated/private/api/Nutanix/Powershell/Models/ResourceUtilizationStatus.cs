namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>stores resource utilization and limits for a domain</summary>
    public partial class ResourceUtilizationStatus : Nutanix.Powershell.Models.IResourceUtilizationStatus, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Limit property</summary>
        private int? _limit;

        /// <summary>The resource consumption limit (unspecified is unlimited)</summary>
        public int? Limit
        {
            get
            {
                return this._limit;
            }
            set
            {
                this._limit = value;
            }
        }
        /// <summary>Backing field for ResourceType property</summary>
        private string _resourceType;

        /// <summary>The type of resource (for example storage, CPUs)</summary>
        public string ResourceType
        {
            get
            {
                return this._resourceType;
            }
            set
            {
                this._resourceType = value;
            }
        }
        /// <summary>Backing field for Units property</summary>
        private string _units;

        /// <summary>The units of the resource type</summary>
        public string Units
        {
            get
            {
                return this._units;
            }
            set
            {
                this._units = value;
            }
        }
        /// <summary>Backing field for Value property</summary>
        private int _value;

        /// <summary>The amount of resource consumed</summary>
        public int Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        /// <summary>Creates an new <see cref="ResourceUtilizationStatus" /> instance.</summary>
        public ResourceUtilizationStatus()
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
            await eventListener.AssertNotNull(nameof(ResourceType),ResourceType);
            await eventListener.AssertNotNull(nameof(Units),Units);
        }
    }
    /// stores resource utilization and limits for a domain
    public partial interface IResourceUtilizationStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        int? Limit { get; set; }
        string ResourceType { get; set; }
        string Units { get; set; }
        int Value { get; set; }
    }
}