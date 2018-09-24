namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>The user kind metadata</summary>
    public partial class UserMetadata
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
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Nutanix.Powershell.Models.IUserMetadata.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Nutanix.Powershell.Models.IUserMetadata.</returns>
        public static Nutanix.Powershell.Models.IUserMetadata FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new UserMetadata(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="UserMetadata" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="UserMetadata" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            if (serializationMode.HasFlag(Microsoft.Rest.ClientRuntime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != Name ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Name) : null, "name" ,container.Add );
            }
            /* serializeToContainerMember (wildcard) doesn't support 'application/json' /home/travis/.autorest/@microsoft.azure_autorest.incubator@1.0.115/node_modules/@microsoft.azure/autorest.incubator/dist/csharp/schema/wildcard.js*/
            if (serializationMode.HasFlag(Microsoft.Rest.ClientRuntime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != CreationTime ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(CreationTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "creation_time" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Rest.ClientRuntime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != Kind ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Kind) : null, "kind" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Rest.ClientRuntime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != LastUpdateTime ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(LastUpdateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "last_update_time" ,container.Add );
            }
            AddIf( null != OwnerReference ? (Carbon.Json.JsonNode) OwnerReference.ToJson(null) : null, "owner_reference" ,container.Add );
            AddIf( null != ProjectReference ? (Carbon.Json.JsonNode) ProjectReference.ToJson(null) : null, "project_reference" ,container.Add );
            AddIf( null != SpecHash ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(SpecHash) : null, "spec_hash" ,container.Add );
            AddIf( null != SpecVersion ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((int)SpecVersion) : null, "spec_version" ,container.Add );
            AddIf( null != Uuid ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Uuid) : null, "uuid" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="UserMetadata" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal UserMetadata(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _name = If( json?.PropertyT<Carbon.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;
            _categories = null /* deserializeFromContainerMember (wildcard) doesn't support 'application/json' /home/travis/.autorest/@microsoft.azure_autorest.incubator@1.0.115/node_modules/@microsoft.azure/autorest.incubator/dist/csharp/schema/wildcard.js*/;
            _creationTime = If( json?.PropertyT<Carbon.Json.JsonString>("creation_time"), out var __jsonCreationTime) ? System.DateTime.TryParse((string)__jsonCreationTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonCreationTimeValue) ? __jsonCreationTimeValue : CreationTime : CreationTime;
            _kind = If( json?.PropertyT<Carbon.Json.JsonString>("kind"), out var __jsonKind) ? (string)__jsonKind : (string)Kind;
            _lastUpdateTime = If( json?.PropertyT<Carbon.Json.JsonString>("last_update_time"), out var __jsonLastUpdateTime) ? System.DateTime.TryParse((string)__jsonLastUpdateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastUpdateTimeValue) ? __jsonLastUpdateTimeValue : LastUpdateTime : LastUpdateTime;
            _ownerReference = If( json?.PropertyT<Carbon.Json.JsonObject>("owner_reference"), out var __jsonOwnerReference) ? Nutanix.Powershell.Models.UserReference.FromJson(__jsonOwnerReference) : OwnerReference;
            _projectReference = If( json?.PropertyT<Carbon.Json.JsonObject>("project_reference"), out var __jsonProjectReference) ? Nutanix.Powershell.Models.ProjectReference.FromJson(__jsonProjectReference) : ProjectReference;
            _specHash = If( json?.PropertyT<Carbon.Json.JsonString>("spec_hash"), out var __jsonSpecHash) ? (string)__jsonSpecHash : (string)SpecHash;
            _specVersion = If( json?.PropertyT<Carbon.Json.JsonNumber>("spec_version"), out var __jsonSpecVersion) ? (int?)__jsonSpecVersion : SpecVersion;
            _uuid = If( json?.PropertyT<Carbon.Json.JsonString>("uuid"), out var __jsonUuid) ? (string)__jsonUuid : (string)Uuid;
            AfterFromJson(json);
        }
    }
}