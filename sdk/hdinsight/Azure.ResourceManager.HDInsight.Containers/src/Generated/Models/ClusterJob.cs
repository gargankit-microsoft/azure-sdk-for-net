// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Cluster job. </summary>
    public partial class ClusterJob : ResourceData
    {
        /// <summary> Initializes a new instance of ClusterJob. </summary>
        /// <param name="properties">
        /// Properties of cluster job.
        /// Please note <see cref="ClusterJobProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FlinkJobProperties"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public ClusterJob(ClusterJobProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of ClusterJob. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// Properties of cluster job.
        /// Please note <see cref="ClusterJobProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FlinkJobProperties"/>.
        /// </param>
        internal ClusterJob(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ClusterJobProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary>
        /// Properties of cluster job.
        /// Please note <see cref="ClusterJobProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FlinkJobProperties"/>.
        /// </summary>
        public ClusterJobProperties Properties { get; set; }
    }
}
