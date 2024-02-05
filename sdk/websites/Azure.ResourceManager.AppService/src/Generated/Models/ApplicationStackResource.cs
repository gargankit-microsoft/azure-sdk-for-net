// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> ARM resource for a ApplicationStack. </summary>
    public partial class ApplicationStackResource : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ApplicationStackResource"/>. </summary>
        public ApplicationStackResource()
        {
            MajorVersions = new ChangeTrackingList<StackMajorVersion>();
            Frameworks = new ChangeTrackingList<ApplicationStack>();
            IsDeprecated = new ChangeTrackingList<ApplicationStack>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationStackResource"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="stackName"> Application stack name. </param>
        /// <param name="display"> Application stack display name. </param>
        /// <param name="dependency"> Application stack dependency. </param>
        /// <param name="majorVersions"> List of major versions available. </param>
        /// <param name="frameworks"> List of frameworks associated with application stack. </param>
        /// <param name="isDeprecated"> &lt;code&gt;true&lt;/code&gt; if this is the stack is deprecated; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationStackResource(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string stackName, string display, string dependency, IList<StackMajorVersion> majorVersions, IList<ApplicationStack> frameworks, IList<ApplicationStack> isDeprecated, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            StackName = stackName;
            Display = display;
            Dependency = dependency;
            MajorVersions = majorVersions;
            Frameworks = frameworks;
            IsDeprecated = isDeprecated;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Application stack name. </summary>
        public string StackName { get; set; }
        /// <summary> Application stack display name. </summary>
        public string Display { get; set; }
        /// <summary> Application stack dependency. </summary>
        public string Dependency { get; set; }
        /// <summary> List of major versions available. </summary>
        public IList<StackMajorVersion> MajorVersions { get; }
        /// <summary> List of frameworks associated with application stack. </summary>
        public IList<ApplicationStack> Frameworks { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if this is the stack is deprecated; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public IList<ApplicationStack> IsDeprecated { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
