// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The AWS organization data for the member account. </summary>
    public partial class AwsOrganizationalDataMember : AwsOrganizationalInfo
    {
        /// <summary> Initializes a new instance of <see cref="AwsOrganizationalDataMember"/>. </summary>
        public AwsOrganizationalDataMember()
        {
            OrganizationMembershipType = OrganizationMembershipType.Member;
        }

        /// <summary> Initializes a new instance of <see cref="AwsOrganizationalDataMember"/>. </summary>
        /// <param name="organizationMembershipType"> The multi cloud account's membership type in the organization. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="parentHierarchyId"> If the multi cloud account is not of membership type organization, this will be the ID of the account's parent. </param>
        internal AwsOrganizationalDataMember(OrganizationMembershipType organizationMembershipType, IDictionary<string, BinaryData> serializedAdditionalRawData, string parentHierarchyId) : base(organizationMembershipType, serializedAdditionalRawData)
        {
            ParentHierarchyId = parentHierarchyId;
            OrganizationMembershipType = organizationMembershipType;
        }

        /// <summary> If the multi cloud account is not of membership type organization, this will be the ID of the account's parent. </summary>
        public string ParentHierarchyId { get; set; }
    }
}
