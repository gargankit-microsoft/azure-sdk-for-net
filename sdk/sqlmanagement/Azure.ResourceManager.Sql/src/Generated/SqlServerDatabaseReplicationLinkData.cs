// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the SqlServerDatabaseReplicationLink data model.
    /// A replication link.
    /// </summary>
    public partial class SqlServerDatabaseReplicationLinkData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SqlServerDatabaseReplicationLinkData"/>. </summary>
        public SqlServerDatabaseReplicationLinkData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlServerDatabaseReplicationLinkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="partnerServer"> Resource partner server. </param>
        /// <param name="partnerDatabase"> Resource partner database. </param>
        /// <param name="partnerLocation"> Resource partner location. </param>
        /// <param name="role"> Local replication role. </param>
        /// <param name="partnerRole"> Partner replication role. </param>
        /// <param name="replicationMode"> Replication mode. </param>
        /// <param name="startOn"> Time at which the link was created. </param>
        /// <param name="percentComplete"> Seeding completion percentage for the link. </param>
        /// <param name="replicationState"> Replication state (PENDING, SEEDING, CATCHUP, SUSPENDED). </param>
        /// <param name="isTerminationAllowed"> Whether the user is currently allowed to terminate the link. </param>
        /// <param name="linkType"> Link type (GEO, NAMED, STANDBY). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlServerDatabaseReplicationLinkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string partnerServer, string partnerDatabase, AzureLocation? partnerLocation, SqlServerDatabaseReplicationRole? role, SqlServerDatabaseReplicationRole? partnerRole, string replicationMode, DateTimeOffset? startOn, int? percentComplete, ReplicationLinkState? replicationState, bool? isTerminationAllowed, ReplicationLinkType? linkType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            PartnerServer = partnerServer;
            PartnerDatabase = partnerDatabase;
            PartnerLocation = partnerLocation;
            Role = role;
            PartnerRole = partnerRole;
            ReplicationMode = replicationMode;
            StartOn = startOn;
            PercentComplete = percentComplete;
            ReplicationState = replicationState;
            IsTerminationAllowed = isTerminationAllowed;
            LinkType = linkType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource partner server. </summary>
        public string PartnerServer { get; }
        /// <summary> Resource partner database. </summary>
        public string PartnerDatabase { get; }
        /// <summary> Resource partner location. </summary>
        public AzureLocation? PartnerLocation { get; }
        /// <summary> Local replication role. </summary>
        public SqlServerDatabaseReplicationRole? Role { get; }
        /// <summary> Partner replication role. </summary>
        public SqlServerDatabaseReplicationRole? PartnerRole { get; }
        /// <summary> Replication mode. </summary>
        public string ReplicationMode { get; }
        /// <summary> Time at which the link was created. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Seeding completion percentage for the link. </summary>
        public int? PercentComplete { get; }
        /// <summary> Replication state (PENDING, SEEDING, CATCHUP, SUSPENDED). </summary>
        public ReplicationLinkState? ReplicationState { get; }
        /// <summary> Whether the user is currently allowed to terminate the link. </summary>
        public bool? IsTerminationAllowed { get; }
        /// <summary> Link type (GEO, NAMED, STANDBY). </summary>
        public ReplicationLinkType? LinkType { get; }
    }
}
