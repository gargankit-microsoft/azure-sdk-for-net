// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Progress metrics definition. </summary>
    public partial class ProgressMetrics
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

        /// <summary> Initializes a new instance of <see cref="ProgressMetrics"/>. </summary>
        internal ProgressMetrics()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProgressMetrics"/>. </summary>
        /// <param name="completedDatapointCount"> The completed datapoint count. </param>
        /// <param name="incrementalDataLastRefreshOn"> The time of last successful incremental data refresh in UTC. </param>
        /// <param name="skippedDatapointCount"> The skipped datapoint count. </param>
        /// <param name="totalDatapointCount"> The total datapoint count. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProgressMetrics(long? completedDatapointCount, DateTimeOffset? incrementalDataLastRefreshOn, long? skippedDatapointCount, long? totalDatapointCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CompletedDatapointCount = completedDatapointCount;
            IncrementalDataLastRefreshOn = incrementalDataLastRefreshOn;
            SkippedDatapointCount = skippedDatapointCount;
            TotalDatapointCount = totalDatapointCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The completed datapoint count. </summary>
        public long? CompletedDatapointCount { get; }
        /// <summary> The time of last successful incremental data refresh in UTC. </summary>
        public DateTimeOffset? IncrementalDataLastRefreshOn { get; }
        /// <summary> The skipped datapoint count. </summary>
        public long? SkippedDatapointCount { get; }
        /// <summary> The total datapoint count. </summary>
        public long? TotalDatapointCount { get; }
    }
}
