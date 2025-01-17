// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing the JitRequest data model.
    /// Information about JIT request definition.
    /// </summary>
    public partial class JitRequestData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="JitRequestData"/>. </summary>
        /// <param name="location"> The location. </param>
        public JitRequestData(AzureLocation location) : base(location)
        {
            JitAuthorizationPolicies = new ChangeTrackingList<JitAuthorizationPolicies>();
        }

        /// <summary> Initializes a new instance of <see cref="JitRequestData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="applicationResourceId"> The parent application id. </param>
        /// <param name="publisherTenantId"> The publisher tenant id. </param>
        /// <param name="jitAuthorizationPolicies"> The JIT authorization policies. </param>
        /// <param name="jitSchedulingPolicy"> The JIT request properties. </param>
        /// <param name="provisioningState"> The JIT request provisioning state. </param>
        /// <param name="jitRequestState"> The JIT request state. </param>
        /// <param name="createdBy"> The client entity that created the JIT request. </param>
        /// <param name="updatedBy"> The client entity that last updated the JIT request. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JitRequestData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string applicationResourceId, Guid? publisherTenantId, IList<JitAuthorizationPolicies> jitAuthorizationPolicies, JitSchedulingPolicy jitSchedulingPolicy, ResourcesProvisioningState? provisioningState, JitRequestState? jitRequestState, ArmApplicationDetails createdBy, ArmApplicationDetails updatedBy, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ApplicationResourceId = applicationResourceId;
            PublisherTenantId = publisherTenantId;
            JitAuthorizationPolicies = jitAuthorizationPolicies;
            JitSchedulingPolicy = jitSchedulingPolicy;
            ProvisioningState = provisioningState;
            JitRequestState = jitRequestState;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="JitRequestData"/> for deserialization. </summary>
        internal JitRequestData()
        {
        }

        /// <summary> The parent application id. </summary>
        public string ApplicationResourceId { get; set; }
        /// <summary> The publisher tenant id. </summary>
        public Guid? PublisherTenantId { get; }
        /// <summary> The JIT authorization policies. </summary>
        public IList<JitAuthorizationPolicies> JitAuthorizationPolicies { get; }
        /// <summary> The JIT request properties. </summary>
        public JitSchedulingPolicy JitSchedulingPolicy { get; set; }
        /// <summary> The JIT request provisioning state. </summary>
        public ResourcesProvisioningState? ProvisioningState { get; }
        /// <summary> The JIT request state. </summary>
        public JitRequestState? JitRequestState { get; }
        /// <summary> The client entity that created the JIT request. </summary>
        public ArmApplicationDetails CreatedBy { get; }
        /// <summary> The client entity that last updated the JIT request. </summary>
        public ArmApplicationDetails UpdatedBy { get; }
    }
}
