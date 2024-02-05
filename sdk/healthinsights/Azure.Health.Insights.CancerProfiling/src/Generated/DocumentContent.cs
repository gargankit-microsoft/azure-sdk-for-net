// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Health.Insights.CancerProfiling
{
    /// <summary> The content of the patient document. </summary>
    public partial class DocumentContent
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

        /// <summary> Initializes a new instance of <see cref="DocumentContent"/>. </summary>
        /// <param name="sourceType">
        /// The type of the content's source.
        /// In case the source type is 'inline', the content is given as a string (for instance, text).
        /// In case the source type is 'reference', the content is given as a URI.
        /// </param>
        /// <param name="value"> The content of the document, given either inline (as a string) or as a reference (URI). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DocumentContent(DocumentContentSourceType sourceType, string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            SourceType = sourceType;
            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentContent"/>. </summary>
        /// <param name="sourceType">
        /// The type of the content's source.
        /// In case the source type is 'inline', the content is given as a string (for instance, text).
        /// In case the source type is 'reference', the content is given as a URI.
        /// </param>
        /// <param name="value"> The content of the document, given either inline (as a string) or as a reference (URI). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentContent(DocumentContentSourceType sourceType, string value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceType = sourceType;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentContent"/> for deserialization. </summary>
        internal DocumentContent()
        {
        }

        /// <summary>
        /// The type of the content's source.
        /// In case the source type is 'inline', the content is given as a string (for instance, text).
        /// In case the source type is 'reference', the content is given as a URI.
        /// </summary>
        public DocumentContentSourceType SourceType { get; }
        /// <summary> The content of the document, given either inline (as a string) or as a reference (URI). </summary>
        public string Value { get; }
    }
}
