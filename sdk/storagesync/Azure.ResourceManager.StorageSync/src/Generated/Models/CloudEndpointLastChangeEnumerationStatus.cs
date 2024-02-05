// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Cloud endpoint change enumeration status object. </summary>
    public partial class CloudEndpointLastChangeEnumerationStatus
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

        /// <summary> Initializes a new instance of <see cref="CloudEndpointLastChangeEnumerationStatus"/>. </summary>
        internal CloudEndpointLastChangeEnumerationStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CloudEndpointLastChangeEnumerationStatus"/>. </summary>
        /// <param name="startedOn"> Timestamp when change enumeration started. </param>
        /// <param name="completedOn"> Timestamp when change enumeration completed. </param>
        /// <param name="namespaceFilesCount"> Count of files in the namespace. </param>
        /// <param name="namespaceDirectoriesCount"> Count of directories in the namespace. </param>
        /// <param name="namespaceSizeInBytes"> Namespace size in bytes. </param>
        /// <param name="nextRunTimestamp"> Timestamp of when change enumeration is expected to run again. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudEndpointLastChangeEnumerationStatus(DateTimeOffset? startedOn, DateTimeOffset? completedOn, long? namespaceFilesCount, long? namespaceDirectoriesCount, long? namespaceSizeInBytes, DateTimeOffset? nextRunTimestamp, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StartedOn = startedOn;
            CompletedOn = completedOn;
            NamespaceFilesCount = namespaceFilesCount;
            NamespaceDirectoriesCount = namespaceDirectoriesCount;
            NamespaceSizeInBytes = namespaceSizeInBytes;
            NextRunTimestamp = nextRunTimestamp;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Timestamp when change enumeration started. </summary>
        public DateTimeOffset? StartedOn { get; }
        /// <summary> Timestamp when change enumeration completed. </summary>
        public DateTimeOffset? CompletedOn { get; }
        /// <summary> Count of files in the namespace. </summary>
        public long? NamespaceFilesCount { get; }
        /// <summary> Count of directories in the namespace. </summary>
        public long? NamespaceDirectoriesCount { get; }
        /// <summary> Namespace size in bytes. </summary>
        public long? NamespaceSizeInBytes { get; }
        /// <summary> Timestamp of when change enumeration is expected to run again. </summary>
        public DateTimeOffset? NextRunTimestamp { get; }
    }
}
