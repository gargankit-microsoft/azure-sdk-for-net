// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Class of response for listContentKeys action. </summary>
    internal partial class ListContentKeysResponse
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

        /// <summary> Initializes a new instance of <see cref="ListContentKeysResponse"/>. </summary>
        internal ListContentKeysResponse()
        {
            ContentKeys = new ChangeTrackingList<StreamingLocatorContentKey>();
        }

        /// <summary> Initializes a new instance of <see cref="ListContentKeysResponse"/>. </summary>
        /// <param name="contentKeys"> ContentKeys used by current Streaming Locator. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ListContentKeysResponse(IReadOnlyList<StreamingLocatorContentKey> contentKeys, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ContentKeys = contentKeys;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ContentKeys used by current Streaming Locator. </summary>
        public IReadOnlyList<StreamingLocatorContentKey> ContentKeys { get; }
    }
}
