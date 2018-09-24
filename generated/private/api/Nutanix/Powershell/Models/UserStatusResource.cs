namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>User Resource Definition.</summary>
    public partial class UserStatusResource : Nutanix.Powershell.Models.IUserStatusResource, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for AccessControlPolicyReferenceList property</summary>
        private Nutanix.Powershell.Models.IAccessControlPolicyReference[] _accessControlPolicyReferenceList;

        /// <summary>List of ACP references.</summary>
        public Nutanix.Powershell.Models.IAccessControlPolicyReference[] AccessControlPolicyReferenceList
        {
            get
            {
                return this._accessControlPolicyReferenceList;
            }
            set
            {
                this._accessControlPolicyReferenceList = value;
            }
        }
        /// <summary>Backing field for DirectoryServiceUser property</summary>
        private Nutanix.Powershell.Models.IDirectoryServiceUserStatus _directoryServiceUser;

        /// <summary>A Directory Service user.</summary>
        public Nutanix.Powershell.Models.IDirectoryServiceUserStatus DirectoryServiceUser
        {
            get
            {
                return this._directoryServiceUser;
            }
            set
            {
                this._directoryServiceUser = value;
            }
        }
        /// <summary>Backing field for DisplayName property</summary>
        private string _displayName;

        /// <summary>
        /// The display name of the user (common name) provided by the directory service.
        /// </summary>
        public string DisplayName
        {
            get
            {
                return this._displayName;
            }
            set
            {
                this._displayName = value;
            }
        }
        /// <summary>Backing field for ProjectsReferenceList property</summary>
        private Nutanix.Powershell.Models.IProjectReference[] _projectsReferenceList;

        /// <summary>A list of projects the user is part of.</summary>
        public Nutanix.Powershell.Models.IProjectReference[] ProjectsReferenceList
        {
            get
            {
                return this._projectsReferenceList;
            }
            set
            {
                this._projectsReferenceList = value;
            }
        }
        /// <summary>Backing field for ResourceUsageSummary property</summary>
        private Nutanix.Powershell.Models.IUserStatusResourceResourceUsageSummary _resourceUsageSummary;

        public Nutanix.Powershell.Models.IUserStatusResourceResourceUsageSummary ResourceUsageSummary
        {
            get
            {
                return this._resourceUsageSummary;
            }
            set
            {
                this._resourceUsageSummary = value;
            }
        }
        /// <summary>Backing field for UserType property</summary>
        private string _userType;

        public string UserType
        {
            get
            {
                return this._userType;
            }
            set
            {
                this._userType = value;
            }
        }
        /// <summary>Creates an new <see cref="UserStatusResource" /> instance.</summary>
        public UserStatusResource()
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
            if (AccessControlPolicyReferenceList != null ) {
                    for (int __i = 0; __i < AccessControlPolicyReferenceList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"AccessControlPolicyReferenceList[{__i}]", AccessControlPolicyReferenceList[__i]);
                    }
                  }
            await eventListener.AssertObjectIsValid(nameof(DirectoryServiceUser), DirectoryServiceUser);
            if (ProjectsReferenceList != null ) {
                    for (int __i = 0; __i < ProjectsReferenceList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"ProjectsReferenceList[{__i}]", ProjectsReferenceList[__i]);
                    }
                  }
            await eventListener.AssertObjectIsValid(nameof(ResourceUsageSummary), ResourceUsageSummary);
        }
    }
    /// User Resource Definition.
    public partial interface IUserStatusResource : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IAccessControlPolicyReference[] AccessControlPolicyReferenceList { get; set; }
        Nutanix.Powershell.Models.IDirectoryServiceUserStatus DirectoryServiceUser { get; set; }
        string DisplayName { get; set; }
        Nutanix.Powershell.Models.IProjectReference[] ProjectsReferenceList { get; set; }
        Nutanix.Powershell.Models.IUserStatusResourceResourceUsageSummary ResourceUsageSummary { get; set; }
        string UserType { get; set; }
    }
}