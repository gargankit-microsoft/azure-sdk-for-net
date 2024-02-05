// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The supported capabilities. </summary>
    public partial class ContainerSupportedCapabilities
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

        /// <summary> Initializes a new instance of <see cref="ContainerSupportedCapabilities"/>. </summary>
        internal ContainerSupportedCapabilities()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerSupportedCapabilities"/>. </summary>
        /// <param name="maxMemoryInGB"> The maximum allowed memory request in GB. </param>
        /// <param name="maxCpu"> The maximum allowed CPU request in cores. </param>
        /// <param name="maxGpuCount"> The maximum allowed GPU count. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerSupportedCapabilities(float? maxMemoryInGB, float? maxCpu, float? maxGpuCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MaxMemoryInGB = maxMemoryInGB;
            MaxCpu = maxCpu;
            MaxGpuCount = maxGpuCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The maximum allowed memory request in GB. </summary>
        public float? MaxMemoryInGB { get; }
        /// <summary> The maximum allowed CPU request in cores. </summary>
        public float? MaxCpu { get; }
        /// <summary> The maximum allowed GPU count. </summary>
        public float? MaxGpuCount { get; }
    }
}
