namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>User Resource Definition.</summary>
    public partial class UserStatusResource
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        partial void AfterFromJson(Carbon.Json.JsonObject json);
        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Carbon.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        partial void AfterToJson(ref Carbon.Json.JsonObject container);
        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeFromJson(Carbon.Json.JsonObject json, ref bool returnNow);
        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeToJson(ref Carbon.Json.JsonObject container, ref bool returnNow);
        /// <summary>
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Nutanix.Powershell.Models.IUserStatusResource.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Nutanix.Powershell.Models.IUserStatusResource.</returns>
        public static Nutanix.Powershell.Models.IUserStatusResource FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new UserStatusResource(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="UserStatusResource" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="UserStatusResource" /> as a <see cref="Carbon.Json.JsonNode" />.
        /// </returns>
        public Carbon.Json.JsonNode ToJson(Carbon.Json.JsonObject container, Microsoft.Rest.ClientRuntime.SerializationMode serializationMode)
        {
            container = container ?? new Carbon.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (null != AccessControlPolicyReferenceList)
            {
                var __x = new Carbon.Json.XNodeArray();
                foreach( var __y in AccessControlPolicyReferenceList )
                {
                    AddIf(__y?.ToJson(null) ,__x.Add);
                }
                container.Add("access_control_policy_reference_list",__x);
            }
            AddIf( null != DirectoryServiceUser ? (Carbon.Json.JsonNode) DirectoryServiceUser.ToJson(null) : null, "directory_service_user" ,container.Add );
            AddIf( null != DisplayName ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(DisplayName) : null, "display_name" ,container.Add );
            if (null != ProjectsReferenceList)
            {
                var __s = new Carbon.Json.XNodeArray();
                foreach( var __t in ProjectsReferenceList )
                {
                    AddIf(__t?.ToJson(null) ,__s.Add);
                }
                container.Add("projects_reference_list",__s);
            }
            AddIf( null != ResourceUsageSummary ? (Carbon.Json.JsonNode) ResourceUsageSummary.ToJson(null) : null, "resource_usage_summary" ,container.Add );
            AddIf( null != UserType ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(UserType) : null, "user_type" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="UserStatusResource" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal UserStatusResource(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _accessControlPolicyReferenceList = If( json?.PropertyT<Carbon.Json.JsonArray>("access_control_policy_reference_list"), out var __jsonAccessControlPolicyReferenceList) ? If( __jsonAccessControlPolicyReferenceList, out var __w) ? new System.Func<Nutanix.Powershell.Models.IAccessControlPolicyReference[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __w, (__v)=> Nutanix.Powershell.Models.AccessControlPolicyReference.FromJson(__v)  ) ) )() : null : AccessControlPolicyReferenceList;
            _directoryServiceUser = If( json?.PropertyT<Carbon.Json.JsonObject>("directory_service_user"), out var __jsonDirectoryServiceUser) ? Nutanix.Powershell.Models.DirectoryServiceUserStatus.FromJson(__jsonDirectoryServiceUser) : DirectoryServiceUser;
            _displayName = If( json?.PropertyT<Carbon.Json.JsonString>("display_name"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;
            _projectsReferenceList = If( json?.PropertyT<Carbon.Json.JsonArray>("projects_reference_list"), out var __jsonProjectsReferenceList) ? If( __jsonProjectsReferenceList, out var __r) ? new System.Func<Nutanix.Powershell.Models.IProjectReference[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __r, (__q)=> Nutanix.Powershell.Models.ProjectReference.FromJson(__q)  ) ) )() : null : ProjectsReferenceList;
            _resourceUsageSummary = If( json?.PropertyT<Carbon.Json.JsonObject>("resource_usage_summary"), out var __jsonResourceUsageSummary) ? Nutanix.Powershell.Models.UserStatusResourceResourceUsageSummary.FromJson(__jsonResourceUsageSummary) : ResourceUsageSummary;
            _userType = If( json?.PropertyT<Carbon.Json.JsonString>("user_type"), out var __jsonUserType) ? (string)__jsonUserType : (string)UserType;
            AfterFromJson(json);
        }
    }
}