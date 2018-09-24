namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="AccessControlPolicyListMetadata" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"AccessControlPolicyListMetadataObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.IAccessControlPolicyListMetadata))]
    public class NewAccessControlPolicyListMetadataObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="AccessControlPolicyListMetadata" /></summary>
        private Nutanix.Powershell.Models.IAccessControlPolicyListMetadata _accessControlPolicyListMetadata = new Nutanix.Powershell.Models.AccessControlPolicyListMetadata();
        /// <summary>The filter in FIQL syntax used for the results.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The filter in FIQL syntax used for the results.")]
        public string Filter
        {
            set
            {
                _accessControlPolicyListMetadata.Filter = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The kind name")]
        public string Kind
        {
            set
            {
                _accessControlPolicyListMetadata.Kind = value;
            }
        }
        /// <summary>The number of records to retrieve relative to the offset</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The number of records to retrieve relative to the offset")]
        public int Length
        {
            set
            {
                _accessControlPolicyListMetadata.Length = value;
            }
        }
        /// <summary>Offset from the start of the entity list</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Offset from the start of the entity list")]
        public int Offset
        {
            set
            {
                _accessControlPolicyListMetadata.Offset = value;
            }
        }
        /// <summary>The attribute to perform sort on</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The attribute to perform sort on")]
        public string SortAttribute
        {
            set
            {
                _accessControlPolicyListMetadata.SortAttribute = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_accessControlPolicyListMetadata);
        }
    }
}