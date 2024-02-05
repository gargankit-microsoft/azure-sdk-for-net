// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Integration runtime status response. </summary>
    public partial class SynapseIntegrationRuntimeStatusResult
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

        /// <summary> Initializes a new instance of <see cref="SynapseIntegrationRuntimeStatusResult"/>. </summary>
        /// <param name="properties">
        /// Integration runtime properties.
        /// Please note <see cref="SynapseIntegrationRuntimeStatus"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SynapseManagedIntegrationRuntimeStatus"/> and <see cref="SynapseSelfHostedIntegrationRuntimeStatus"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        internal SynapseIntegrationRuntimeStatusResult(SynapseIntegrationRuntimeStatus properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="SynapseIntegrationRuntimeStatusResult"/>. </summary>
        /// <param name="name"> The integration runtime name. </param>
        /// <param name="properties">
        /// Integration runtime properties.
        /// Please note <see cref="SynapseIntegrationRuntimeStatus"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SynapseManagedIntegrationRuntimeStatus"/> and <see cref="SynapseSelfHostedIntegrationRuntimeStatus"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseIntegrationRuntimeStatusResult(string name, SynapseIntegrationRuntimeStatus properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SynapseIntegrationRuntimeStatusResult"/> for deserialization. </summary>
        internal SynapseIntegrationRuntimeStatusResult()
        {
        }

        /// <summary> The integration runtime name. </summary>
        public string Name { get; }
        /// <summary>
        /// Integration runtime properties.
        /// Please note <see cref="SynapseIntegrationRuntimeStatus"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SynapseManagedIntegrationRuntimeStatus"/> and <see cref="SynapseSelfHostedIntegrationRuntimeStatus"/>.
        /// </summary>
        public SynapseIntegrationRuntimeStatus Properties { get; }
    }
}
