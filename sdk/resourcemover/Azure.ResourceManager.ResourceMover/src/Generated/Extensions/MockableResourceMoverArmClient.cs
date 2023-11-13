// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ResourceMover;

namespace Azure.ResourceManager.ResourceMover.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableResourceMoverArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableResourceMoverArmClient"/> class for mocking. </summary>
        protected MockableResourceMoverArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableResourceMoverArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableResourceMoverArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableResourceMoverArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="MoverResourceSetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MoverResourceSetResource.CreateResourceIdentifier" /> to create a <see cref="MoverResourceSetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MoverResourceSetResource" /> object. </returns>
        public virtual MoverResourceSetResource GetMoverResourceSetResource(ResourceIdentifier id)
        {
            MoverResourceSetResource.ValidateResourceId(id);
            return new MoverResourceSetResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MoverResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MoverResource.CreateResourceIdentifier" /> to create a <see cref="MoverResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MoverResource" /> object. </returns>
        public virtual MoverResource GetMoverResource(ResourceIdentifier id)
        {
            MoverResource.ValidateResourceId(id);
            return new MoverResource(Client, id);
        }
    }
}
