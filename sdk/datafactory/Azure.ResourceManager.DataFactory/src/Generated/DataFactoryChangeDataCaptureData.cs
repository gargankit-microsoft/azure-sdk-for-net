// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataFactory.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary>
    /// A class representing the DataFactoryChangeDataCapture data model.
    /// Change data capture resource type.
    /// </summary>
    public partial class DataFactoryChangeDataCaptureData : ResourceData
    {
        /// <summary> Initializes a new instance of DataFactoryChangeDataCaptureData. </summary>
        /// <param name="sourceConnectionsInfo"> List of sources connections that can be used as sources in the CDC. </param>
        /// <param name="targetConnectionsInfo"> List of target connections that can be used as sources in the CDC. </param>
        /// <param name="policy"> CDC policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceConnectionsInfo"/>, <paramref name="targetConnectionsInfo"/> or <paramref name="policy"/> is null. </exception>
        public DataFactoryChangeDataCaptureData(IEnumerable<MapperSourceConnectionsInfo> sourceConnectionsInfo, IEnumerable<MapperTargetConnectionsInfo> targetConnectionsInfo, MapperPolicy policy)
        {
            Argument.AssertNotNull(sourceConnectionsInfo, nameof(sourceConnectionsInfo));
            Argument.AssertNotNull(targetConnectionsInfo, nameof(targetConnectionsInfo));
            Argument.AssertNotNull(policy, nameof(policy));

            SourceConnectionsInfo = sourceConnectionsInfo.ToList();
            TargetConnectionsInfo = targetConnectionsInfo.ToList();
            Policy = policy;
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of DataFactoryChangeDataCaptureData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="folder"> The folder that this CDC is in. If not specified, CDC will appear at the root level. </param>
        /// <param name="description"> The description of the change data capture. </param>
        /// <param name="sourceConnectionsInfo"> List of sources connections that can be used as sources in the CDC. </param>
        /// <param name="targetConnectionsInfo"> List of target connections that can be used as sources in the CDC. </param>
        /// <param name="policy"> CDC policy. </param>
        /// <param name="allowVnetOverride"> A boolean to determine if the vnet configuration needs to be overwritten. </param>
        /// <param name="status"> Status of the CDC as to if it is running or stopped. </param>
        /// <param name="eTag"> Etag identifies change in the resource. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal DataFactoryChangeDataCaptureData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ChangeDataCaptureFolder folder, string description, IList<MapperSourceConnectionsInfo> sourceConnectionsInfo, IList<MapperTargetConnectionsInfo> targetConnectionsInfo, MapperPolicy policy, bool? allowVnetOverride, string status, ETag? eTag, IDictionary<string, BinaryData> additionalProperties) : base(id, name, resourceType, systemData)
        {
            Folder = folder;
            Description = description;
            SourceConnectionsInfo = sourceConnectionsInfo;
            TargetConnectionsInfo = targetConnectionsInfo;
            Policy = policy;
            AllowVnetOverride = allowVnetOverride;
            Status = status;
            ETag = eTag;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The folder that this CDC is in. If not specified, CDC will appear at the root level. </summary>
        internal ChangeDataCaptureFolder Folder { get; set; }
        /// <summary> The name of the folder that this CDC is in. </summary>
        public string FolderName
        {
            get => Folder is null ? default : Folder.Name;
            set
            {
                if (Folder is null)
                    Folder = new ChangeDataCaptureFolder();
                Folder.Name = value;
            }
        }

        /// <summary> The description of the change data capture. </summary>
        public string Description { get; set; }
        /// <summary> List of sources connections that can be used as sources in the CDC. </summary>
        public IList<MapperSourceConnectionsInfo> SourceConnectionsInfo { get; }
        /// <summary> List of target connections that can be used as sources in the CDC. </summary>
        public IList<MapperTargetConnectionsInfo> TargetConnectionsInfo { get; }
        /// <summary> CDC policy. </summary>
        public MapperPolicy Policy { get; set; }
        /// <summary> A boolean to determine if the vnet configuration needs to be overwritten. </summary>
        public bool? AllowVnetOverride { get; set; }
        /// <summary> Status of the CDC as to if it is running or stopped. </summary>
        public string Status { get; set; }
        /// <summary> Etag identifies change in the resource. </summary>
        public ETag? ETag { get; }
        /// <summary>
        /// Additional Properties
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
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
