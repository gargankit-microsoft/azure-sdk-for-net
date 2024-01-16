// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a SecurityConnectorGitHubOwner along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SecurityConnectorGitHubOwnerResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSecurityConnectorGitHubOwnerResource method.
    /// Otherwise you can get one from its parent resource <see cref="DevOpsConfigurationResource"/> using the GetSecurityConnectorGitHubOwner method.
    /// </summary>
    public partial class SecurityConnectorGitHubOwnerResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SecurityConnectorGitHubOwnerResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="securityConnectorName"> The securityConnectorName. </param>
        /// <param name="ownerName"> The ownerName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string securityConnectorName, string ownerName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _securityConnectorGitHubOwnerGitHubOwnersClientDiagnostics;
        private readonly GitHubOwnersRestOperations _securityConnectorGitHubOwnerGitHubOwnersRestClient;
        private readonly SecurityConnectorGitHubOwnerData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/securityConnectors/devops/gitHubOwners";

        /// <summary> Initializes a new instance of the <see cref="SecurityConnectorGitHubOwnerResource"/> class for mocking. </summary>
        protected SecurityConnectorGitHubOwnerResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityConnectorGitHubOwnerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SecurityConnectorGitHubOwnerResource(ArmClient client, SecurityConnectorGitHubOwnerData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityConnectorGitHubOwnerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SecurityConnectorGitHubOwnerResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityConnectorGitHubOwnerGitHubOwnersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string securityConnectorGitHubOwnerGitHubOwnersApiVersion);
            _securityConnectorGitHubOwnerGitHubOwnersRestClient = new GitHubOwnersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityConnectorGitHubOwnerGitHubOwnersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SecurityConnectorGitHubOwnerData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SecurityConnectorGitHubRepositoryResources in the SecurityConnectorGitHubOwner. </summary>
        /// <returns> An object representing collection of SecurityConnectorGitHubRepositoryResources and their operations over a SecurityConnectorGitHubRepositoryResource. </returns>
        public virtual SecurityConnectorGitHubRepositoryCollection GetSecurityConnectorGitHubRepositories()
        {
            return GetCachedClient(client => new SecurityConnectorGitHubRepositoryCollection(client, Id));
        }

        /// <summary>
        /// Returns a monitored GitHub repository.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}/repos/{repoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubRepos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitHubRepositoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repoName"> The repository name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="repoName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="repoName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SecurityConnectorGitHubRepositoryResource>> GetSecurityConnectorGitHubRepositoryAsync(string repoName, CancellationToken cancellationToken = default)
        {
            return await GetSecurityConnectorGitHubRepositories().GetAsync(repoName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a monitored GitHub repository.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}/repos/{repoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubRepos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitHubRepositoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repoName"> The repository name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="repoName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="repoName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SecurityConnectorGitHubRepositoryResource> GetSecurityConnectorGitHubRepository(string repoName, CancellationToken cancellationToken = default)
        {
            return GetSecurityConnectorGitHubRepositories().Get(repoName, cancellationToken);
        }

        /// <summary>
        /// Returns a monitored GitHub owner.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOwners_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitHubOwnerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SecurityConnectorGitHubOwnerResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _securityConnectorGitHubOwnerGitHubOwnersClientDiagnostics.CreateScope("SecurityConnectorGitHubOwnerResource.Get");
            scope.Start();
            try
            {
                var response = await _securityConnectorGitHubOwnerGitHubOwnersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorGitHubOwnerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a monitored GitHub owner.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitHubOwners/{ownerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOwners_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitHubOwnerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SecurityConnectorGitHubOwnerResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _securityConnectorGitHubOwnerGitHubOwnersClientDiagnostics.CreateScope("SecurityConnectorGitHubOwnerResource.Get");
            scope.Start();
            try
            {
                var response = _securityConnectorGitHubOwnerGitHubOwnersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorGitHubOwnerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
