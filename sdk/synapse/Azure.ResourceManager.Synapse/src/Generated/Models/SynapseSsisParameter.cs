// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Ssis parameter. </summary>
    public partial class SynapseSsisParameter
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

        /// <summary> Initializes a new instance of <see cref="SynapseSsisParameter"/>. </summary>
        internal SynapseSsisParameter()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseSsisParameter"/>. </summary>
        /// <param name="id"> Parameter id. </param>
        /// <param name="name"> Parameter name. </param>
        /// <param name="description"> Parameter description. </param>
        /// <param name="dataType"> Parameter type. </param>
        /// <param name="isRequired"> Whether parameter is required. </param>
        /// <param name="isSensitive"> Whether parameter is sensitive. </param>
        /// <param name="designDefaultValue"> Design default value of parameter. </param>
        /// <param name="defaultValue"> Default value of parameter. </param>
        /// <param name="sensitiveDefaultValue"> Default sensitive value of parameter. </param>
        /// <param name="valueType"> Parameter value type. </param>
        /// <param name="valueSet"> Parameter value set. </param>
        /// <param name="variable"> Parameter reference variable. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseSsisParameter(long? id, string name, string description, string dataType, bool? isRequired, bool? isSensitive, string designDefaultValue, string defaultValue, string sensitiveDefaultValue, string valueType, bool? valueSet, string variable, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Name = name;
            Description = description;
            DataType = dataType;
            IsRequired = isRequired;
            IsSensitive = isSensitive;
            DesignDefaultValue = designDefaultValue;
            DefaultValue = defaultValue;
            SensitiveDefaultValue = sensitiveDefaultValue;
            ValueType = valueType;
            ValueSet = valueSet;
            Variable = variable;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Parameter id. </summary>
        public long? Id { get; }
        /// <summary> Parameter name. </summary>
        public string Name { get; }
        /// <summary> Parameter description. </summary>
        public string Description { get; }
        /// <summary> Parameter type. </summary>
        public string DataType { get; }
        /// <summary> Whether parameter is required. </summary>
        public bool? IsRequired { get; }
        /// <summary> Whether parameter is sensitive. </summary>
        public bool? IsSensitive { get; }
        /// <summary> Design default value of parameter. </summary>
        public string DesignDefaultValue { get; }
        /// <summary> Default value of parameter. </summary>
        public string DefaultValue { get; }
        /// <summary> Default sensitive value of parameter. </summary>
        public string SensitiveDefaultValue { get; }
        /// <summary> Parameter value type. </summary>
        public string ValueType { get; }
        /// <summary> Parameter value set. </summary>
        public bool? ValueSet { get; }
        /// <summary> Parameter reference variable. </summary>
        public string Variable { get; }
    }
}
