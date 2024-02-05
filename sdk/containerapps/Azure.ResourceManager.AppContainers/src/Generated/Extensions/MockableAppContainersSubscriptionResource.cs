// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppContainers;
using Azure.ResourceManager.AppContainers.Models;

namespace Azure.ResourceManager.AppContainers.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableAppContainersSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _availableWorkloadProfilesClientDiagnostics;
        private AvailableWorkloadProfilesRestOperations _availableWorkloadProfilesRestClient;
        private ClientDiagnostics _billingMetersClientDiagnostics;
        private BillingMetersRestOperations _billingMetersRestClient;
        private ClientDiagnostics _containerAppConnectedEnvironmentConnectedEnvironmentsClientDiagnostics;
        private ConnectedEnvironmentsRestOperations _containerAppConnectedEnvironmentConnectedEnvironmentsRestClient;
        private ClientDiagnostics _containerAppClientDiagnostics;
        private ContainerAppsRestOperations _containerAppRestClient;
        private ClientDiagnostics _containerAppJobJobsClientDiagnostics;
        private JobsRestOperations _containerAppJobJobsRestClient;
        private ClientDiagnostics _containerAppManagedEnvironmentManagedEnvironmentsClientDiagnostics;
        private ManagedEnvironmentsRestOperations _containerAppManagedEnvironmentManagedEnvironmentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableAppContainersSubscriptionResource"/> class for mocking. </summary>
        protected MockableAppContainersSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAppContainersSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAppContainersSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics AvailableWorkloadProfilesClientDiagnostics => _availableWorkloadProfilesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AppContainers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private AvailableWorkloadProfilesRestOperations AvailableWorkloadProfilesRestClient => _availableWorkloadProfilesRestClient ??= new AvailableWorkloadProfilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics BillingMetersClientDiagnostics => _billingMetersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AppContainers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private BillingMetersRestOperations BillingMetersRestClient => _billingMetersRestClient ??= new BillingMetersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ContainerAppConnectedEnvironmentConnectedEnvironmentsClientDiagnostics => _containerAppConnectedEnvironmentConnectedEnvironmentsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AppContainers", ContainerAppConnectedEnvironmentResource.ResourceType.Namespace, Diagnostics);
        private ConnectedEnvironmentsRestOperations ContainerAppConnectedEnvironmentConnectedEnvironmentsRestClient => _containerAppConnectedEnvironmentConnectedEnvironmentsRestClient ??= new ConnectedEnvironmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ContainerAppConnectedEnvironmentResource.ResourceType));
        private ClientDiagnostics ContainerAppClientDiagnostics => _containerAppClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AppContainers", ContainerAppResource.ResourceType.Namespace, Diagnostics);
        private ContainerAppsRestOperations ContainerAppRestClient => _containerAppRestClient ??= new ContainerAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ContainerAppResource.ResourceType));
        private ClientDiagnostics ContainerAppJobJobsClientDiagnostics => _containerAppJobJobsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AppContainers", ContainerAppJobResource.ResourceType.Namespace, Diagnostics);
        private JobsRestOperations ContainerAppJobJobsRestClient => _containerAppJobJobsRestClient ??= new JobsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ContainerAppJobResource.ResourceType));
        private ClientDiagnostics ContainerAppManagedEnvironmentManagedEnvironmentsClientDiagnostics => _containerAppManagedEnvironmentManagedEnvironmentsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AppContainers", ContainerAppManagedEnvironmentResource.ResourceType.Namespace, Diagnostics);
        private ManagedEnvironmentsRestOperations ContainerAppManagedEnvironmentManagedEnvironmentsRestClient => _containerAppManagedEnvironmentManagedEnvironmentsRestClient ??= new ManagedEnvironmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ContainerAppManagedEnvironmentResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Get all available workload profiles for a location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.App/locations/{location}/availableManagedEnvironmentsWorkloadProfileTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableWorkloadProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppAvailableWorkloadProfile"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppAvailableWorkloadProfile> GetAvailableWorkloadProfilesAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AvailableWorkloadProfilesRestClient.CreateGetRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AvailableWorkloadProfilesRestClient.CreateGetNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => ContainerAppAvailableWorkloadProfile.DeserializeContainerAppAvailableWorkloadProfile(e), AvailableWorkloadProfilesClientDiagnostics, Pipeline, "MockableAppContainersSubscriptionResource.GetAvailableWorkloadProfiles", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all available workload profiles for a location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.App/locations/{location}/availableManagedEnvironmentsWorkloadProfileTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableWorkloadProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppAvailableWorkloadProfile"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppAvailableWorkloadProfile> GetAvailableWorkloadProfiles(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AvailableWorkloadProfilesRestClient.CreateGetRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AvailableWorkloadProfilesRestClient.CreateGetNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => ContainerAppAvailableWorkloadProfile.DeserializeContainerAppAvailableWorkloadProfile(e), AvailableWorkloadProfilesClientDiagnostics, Pipeline, "MockableAppContainersSubscriptionResource.GetAvailableWorkloadProfiles", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all billingMeters for a location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.App/locations/{location}/billingMeters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingMeters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppBillingMeter"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppBillingMeter> GetBillingMetersAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => BillingMetersRestClient.CreateGetRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => ContainerAppBillingMeter.DeserializeContainerAppBillingMeter(e), BillingMetersClientDiagnostics, Pipeline, "MockableAppContainersSubscriptionResource.GetBillingMeters", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get all billingMeters for a location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.App/locations/{location}/billingMeters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingMeters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppBillingMeter"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppBillingMeter> GetBillingMeters(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => BillingMetersRestClient.CreateGetRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => ContainerAppBillingMeter.DeserializeContainerAppBillingMeter(e), BillingMetersClientDiagnostics, Pipeline, "MockableAppContainersSubscriptionResource.GetBillingMeters", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get all connectedEnvironments for a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.App/connectedEnvironments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironments_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppConnectedEnvironmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppConnectedEnvironmentResource> GetContainerAppConnectedEnvironmentsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ContainerAppConnectedEnvironmentConnectedEnvironmentsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ContainerAppConnectedEnvironmentConnectedEnvironmentsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerAppConnectedEnvironmentResource(Client, ContainerAppConnectedEnvironmentData.DeserializeContainerAppConnectedEnvironmentData(e)), ContainerAppConnectedEnvironmentConnectedEnvironmentsClientDiagnostics, Pipeline, "MockableAppContainersSubscriptionResource.GetContainerAppConnectedEnvironments", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all connectedEnvironments for a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.App/connectedEnvironments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironments_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppConnectedEnvironmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppConnectedEnvironmentResource> GetContainerAppConnectedEnvironments(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ContainerAppConnectedEnvironmentConnectedEnvironmentsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ContainerAppConnectedEnvironmentConnectedEnvironmentsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerAppConnectedEnvironmentResource(Client, ContainerAppConnectedEnvironmentData.DeserializeContainerAppConnectedEnvironmentData(e)), ContainerAppConnectedEnvironmentConnectedEnvironmentsClientDiagnostics, Pipeline, "MockableAppContainersSubscriptionResource.GetContainerAppConnectedEnvironments", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the Container Apps in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.App/containerApps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerApps_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppResource> GetContainerAppsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ContainerAppRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ContainerAppRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerAppResource(Client, ContainerAppData.DeserializeContainerAppData(e)), ContainerAppClientDiagnostics, Pipeline, "MockableAppContainersSubscriptionResource.GetContainerApps", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the Container Apps in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.App/containerApps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerApps_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppResource> GetContainerApps(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ContainerAppRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ContainerAppRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerAppResource(Client, ContainerAppData.DeserializeContainerAppData(e)), ContainerAppClientDiagnostics, Pipeline, "MockableAppContainersSubscriptionResource.GetContainerApps", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the Container Apps Jobs in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.App/jobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppJobResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppJobResource> GetContainerAppJobsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ContainerAppJobJobsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ContainerAppJobJobsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerAppJobResource(Client, ContainerAppJobData.DeserializeContainerAppJobData(e)), ContainerAppJobJobsClientDiagnostics, Pipeline, "MockableAppContainersSubscriptionResource.GetContainerAppJobs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the Container Apps Jobs in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.App/jobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppJobResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppJobResource> GetContainerAppJobs(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ContainerAppJobJobsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ContainerAppJobJobsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerAppJobResource(Client, ContainerAppJobData.DeserializeContainerAppJobData(e)), ContainerAppJobJobsClientDiagnostics, Pipeline, "MockableAppContainersSubscriptionResource.GetContainerAppJobs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all Managed Environments for a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.App/managedEnvironments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironments_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppManagedEnvironmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppManagedEnvironmentResource> GetContainerAppManagedEnvironmentsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ContainerAppManagedEnvironmentManagedEnvironmentsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ContainerAppManagedEnvironmentManagedEnvironmentsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerAppManagedEnvironmentResource(Client, ContainerAppManagedEnvironmentData.DeserializeContainerAppManagedEnvironmentData(e)), ContainerAppManagedEnvironmentManagedEnvironmentsClientDiagnostics, Pipeline, "MockableAppContainersSubscriptionResource.GetContainerAppManagedEnvironments", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all Managed Environments for a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.App/managedEnvironments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironments_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppManagedEnvironmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppManagedEnvironmentResource> GetContainerAppManagedEnvironments(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ContainerAppManagedEnvironmentManagedEnvironmentsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ContainerAppManagedEnvironmentManagedEnvironmentsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerAppManagedEnvironmentResource(Client, ContainerAppManagedEnvironmentData.DeserializeContainerAppManagedEnvironmentData(e)), ContainerAppManagedEnvironmentManagedEnvironmentsClientDiagnostics, Pipeline, "MockableAppContainersSubscriptionResource.GetContainerAppManagedEnvironments", "value", "nextLink", cancellationToken);
        }
    }
}
