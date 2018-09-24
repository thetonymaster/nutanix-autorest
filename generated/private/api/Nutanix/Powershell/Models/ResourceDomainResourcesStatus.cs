namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>The status for a resource domain (limits and values)</summary>
    public partial class ResourceDomainResourcesStatus : Nutanix.Powershell.Models.IResourceDomainResourcesStatus, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Resources property</summary>
        private Nutanix.Powershell.Models.IResourceUtilizationStatus[] _resources;

        /// <summary>The utilization/limit for resource types</summary>
        public Nutanix.Powershell.Models.IResourceUtilizationStatus[] Resources
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
        /// <summary>Creates an new <see cref="ResourceDomainResourcesStatus" /> instance.</summary>
        public ResourceDomainResourcesStatus()
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
            if (Resources != null ) {
                    for (int __i = 0; __i < Resources.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"Resources[{__i}]", Resources[__i]);
                    }
                  }
        }
    }
    /// The status for a resource domain (limits and values)
    public partial interface IResourceDomainResourcesStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IResourceUtilizationStatus[] Resources { get; set; }
    }
}