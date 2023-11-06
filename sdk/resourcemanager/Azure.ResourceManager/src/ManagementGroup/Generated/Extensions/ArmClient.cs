// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.ManagementGroups;

namespace Azure.ResourceManager
{
    public partial class ArmClient
    {
        /// <summary>
        /// Gets an object representing a <see cref="ManagementGroupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagementGroupResource.CreateResourceIdentifier" /> to create a <see cref="ManagementGroupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagementGroupResource" /> object. </returns>
        public virtual ManagementGroupResource GetManagementGroupResource(ResourceIdentifier id)
        {
            ManagementGroupResource.ValidateResourceId(id);
            return new ManagementGroupResource(this, id);
        }
    }
}
