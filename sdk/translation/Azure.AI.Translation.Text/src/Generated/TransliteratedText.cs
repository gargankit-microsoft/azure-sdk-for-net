// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    /// <summary> Transliterated text element. </summary>
    public partial class TransliteratedText
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

        /// <summary> Initializes a new instance of <see cref="TransliteratedText"/>. </summary>
        /// <param name="text"> A string which is the result of converting the input string to the output script. </param>
        /// <param name="script"> A string specifying the script used in the output. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> or <paramref name="script"/> is null. </exception>
        internal TransliteratedText(string text, string script)
        {
            Argument.AssertNotNull(text, nameof(text));
            Argument.AssertNotNull(script, nameof(script));

            Text = text;
            Script = script;
        }

        /// <summary> Initializes a new instance of <see cref="TransliteratedText"/>. </summary>
        /// <param name="text"> A string which is the result of converting the input string to the output script. </param>
        /// <param name="script"> A string specifying the script used in the output. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TransliteratedText(string text, string script, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Text = text;
            Script = script;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TransliteratedText"/> for deserialization. </summary>
        internal TransliteratedText()
        {
        }

        /// <summary> A string which is the result of converting the input string to the output script. </summary>
        public string Text { get; }
        /// <summary> A string specifying the script used in the output. </summary>
        public string Script { get; }
    }
}
