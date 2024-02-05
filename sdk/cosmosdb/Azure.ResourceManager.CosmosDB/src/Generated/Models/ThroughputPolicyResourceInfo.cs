// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB resource throughput policy. </summary>
    public partial class ThroughputPolicyResourceInfo
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

        /// <summary> Initializes a new instance of <see cref="ThroughputPolicyResourceInfo"/>. </summary>
        public ThroughputPolicyResourceInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ThroughputPolicyResourceInfo"/>. </summary>
        /// <param name="isEnabled"> Determines whether the ThroughputPolicy is active or not. </param>
        /// <param name="incrementPercent"> Represents the percentage by which throughput can increase every time throughput policy kicks in. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ThroughputPolicyResourceInfo(bool? isEnabled, int? incrementPercent, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            IncrementPercent = incrementPercent;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Determines whether the ThroughputPolicy is active or not. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Represents the percentage by which throughput can increase every time throughput policy kicks in. </summary>
        public int? IncrementPercent { get; set; }
    }
}
