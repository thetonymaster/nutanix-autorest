namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// All api calls that return a list will have this metadata block as input
    /// </summary>
    public partial class AccessControlPolicyListMetadata
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
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="AccessControlPolicyListMetadata" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal AccessControlPolicyListMetadata(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _filter = If( json?.PropertyT<Carbon.Json.JsonString>("filter"), out var __jsonFilter) ? (string)__jsonFilter : (string)Filter;
            _kind = If( json?.PropertyT<Carbon.Json.JsonString>("kind"), out var __jsonKind) ? (string)__jsonKind : (string)Kind;
            _length = If( json?.PropertyT<Carbon.Json.JsonNumber>("length"), out var __jsonLength) ? (int?)__jsonLength : Length;
            _offset = If( json?.PropertyT<Carbon.Json.JsonNumber>("offset"), out var __jsonOffset) ? (int?)__jsonOffset : Offset;
            _sortAttribute = If( json?.PropertyT<Carbon.Json.JsonString>("sort_attribute"), out var __jsonSortAttribute) ? (string)__jsonSortAttribute : (string)SortAttribute;
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Nutanix.Powershell.Models.IAccessControlPolicyListMetadata.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Nutanix.Powershell.Models.IAccessControlPolicyListMetadata.</returns>
        public static Nutanix.Powershell.Models.IAccessControlPolicyListMetadata FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new AccessControlPolicyListMetadata(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="AccessControlPolicyListMetadata" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AccessControlPolicyListMetadata" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != Filter ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Filter) : null, "filter" ,container.Add );
            AddIf( null != Kind ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Kind) : null, "kind" ,container.Add );
            AddIf( null != Length ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((int)Length) : null, "length" ,container.Add );
            AddIf( null != Offset ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((int)Offset) : null, "offset" ,container.Add );
            AddIf( null != SortAttribute ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(SortAttribute) : null, "sort_attribute" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}