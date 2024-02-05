// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Live trace category configuration of a Microsoft.SignalRService resource. </summary>
    public partial class LiveTraceCategory
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

        /// <summary> Initializes a new instance of <see cref="LiveTraceCategory"/>. </summary>
        /// <param name="name">
        /// Gets or sets the live trace category's name.
        /// Available values: ConnectivityLogs, MessagingLogs.
        /// Case insensitive.
        /// </param>
        /// <param name="enabled">
        /// Indicates whether or the live trace category is enabled.
        /// Available values: true, false.
        /// Case insensitive.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LiveTraceCategory(string name, string enabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Enabled = enabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
