namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    public partial class UserStatusResourceResourceUsageSummary : Nutanix.Powershell.Models.IUserStatusResourceResourceUsageSummary, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for ResourceDomain property</summary>
        private Nutanix.Powershell.Models.IResourceDomainResourcesStatus _resourceDomain;

        /// <summary>The status for a resource domain (limits and values)</summary>
        public Nutanix.Powershell.Models.IResourceDomainResourcesStatus ResourceDomain
        {
            get
            {
                return this._resourceDomain;
            }
            set
            {
                this._resourceDomain = value;
            }
        }
        /// <summary>Creates an new <see cref="UserStatusResourceResourceUsageSummary" /> instance.</summary>
        public UserStatusResourceResourceUsageSummary()
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
            await eventListener.AssertObjectIsValid(nameof(ResourceDomain), ResourceDomain);
        }
    }
    public partial interface IUserStatusResourceResourceUsageSummary : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IResourceDomainResourcesStatus ResourceDomain { get; set; }
    }
}