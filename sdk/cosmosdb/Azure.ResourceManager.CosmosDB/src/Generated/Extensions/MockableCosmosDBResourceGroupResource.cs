// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableCosmosDBResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableCosmosDBResourceGroupResource"/> class for mocking. </summary>
        protected MockableCosmosDBResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableCosmosDBResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableCosmosDBResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of CosmosDBAccountResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of CosmosDBAccountResources and their operations over a CosmosDBAccountResource. </returns>
        public virtual CosmosDBAccountCollection GetCosmosDBAccounts()
        {
            return GetCachedClient(client => new CosmosDBAccountCollection(client, Id));
        }

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<CosmosDBAccountResource>> GetCosmosDBAccountAsync(string accountName, CancellationToken cancellationToken = default)
        {
            return await GetCosmosDBAccounts().GetAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<CosmosDBAccountResource> GetCosmosDBAccount(string accountName, CancellationToken cancellationToken = default)
        {
            return GetCosmosDBAccounts().Get(accountName, cancellationToken);
        }

        /// <summary> Gets a collection of CassandraClusterResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of CassandraClusterResources and their operations over a CassandraClusterResource. </returns>
        public virtual CassandraClusterCollection GetCassandraClusters()
        {
            return GetCachedClient(client => new CassandraClusterCollection(client, Id));
        }

        /// <summary>
        /// Get the properties of a managed Cassandra cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CassandraClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> Managed Cassandra cluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<CassandraClusterResource>> GetCassandraClusterAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            return await GetCassandraClusters().GetAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of a managed Cassandra cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CassandraClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> Managed Cassandra cluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<CassandraClusterResource> GetCassandraCluster(string clusterName, CancellationToken cancellationToken = default)
        {
            return GetCassandraClusters().Get(clusterName, cancellationToken);
        }

        /// <summary> Gets a collection of MongoClusterResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of MongoClusterResources and their operations over a MongoClusterResource. </returns>
        public virtual MongoClusterCollection GetMongoClusters()
        {
            return GetCachedClient(client => new MongoClusterCollection(client, Id));
        }

        /// <summary>
        /// Gets information about a mongo cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mongoClusterName"> The name of the mongo cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoClusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="mongoClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MongoClusterResource>> GetMongoClusterAsync(string mongoClusterName, CancellationToken cancellationToken = default)
        {
            return await GetMongoClusters().GetAsync(mongoClusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about a mongo cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mongoClusterName"> The name of the mongo cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mongoClusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="mongoClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<MongoClusterResource> GetMongoCluster(string mongoClusterName, CancellationToken cancellationToken = default)
        {
            return GetMongoClusters().Get(mongoClusterName, cancellationToken);
        }
    }
}
