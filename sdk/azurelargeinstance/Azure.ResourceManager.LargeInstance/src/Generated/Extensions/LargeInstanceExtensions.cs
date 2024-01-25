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
using Azure.ResourceManager.LargeInstance.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.LargeInstance
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.LargeInstance. </summary>
    public static partial class LargeInstanceExtensions
    {
        private static MockableLargeInstanceArmClient GetMockableLargeInstanceArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableLargeInstanceArmClient(client0));
        }

        private static MockableLargeInstanceResourceGroupResource GetMockableLargeInstanceResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableLargeInstanceResourceGroupResource(client, resource.Id));
        }

        private static MockableLargeInstanceSubscriptionResource GetMockableLargeInstanceSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableLargeInstanceSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="LargeInstanceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LargeInstanceResource.CreateResourceIdentifier" /> to create a <see cref="LargeInstanceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLargeInstanceArmClient.GetLargeInstanceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="LargeInstanceResource"/> object. </returns>
        public static LargeInstanceResource GetLargeInstanceResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableLargeInstanceArmClient(client).GetLargeInstanceResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="LargeStorageInstanceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LargeStorageInstanceResource.CreateResourceIdentifier" /> to create a <see cref="LargeStorageInstanceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLargeInstanceArmClient.GetLargeStorageInstanceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="LargeStorageInstanceResource"/> object. </returns>
        public static LargeStorageInstanceResource GetLargeStorageInstanceResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableLargeInstanceArmClient(client).GetLargeStorageInstanceResource(id);
        }

        /// <summary>
        /// Gets a collection of LargeInstanceResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLargeInstanceResourceGroupResource.GetLargeInstances()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of LargeInstanceResources and their operations over a LargeInstanceResource. </returns>
        public static LargeInstanceCollection GetLargeInstances(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableLargeInstanceResourceGroupResource(resourceGroupResource).GetLargeInstances();
        }

        /// <summary>
        /// Gets an Azure Large Instance for the specified subscription, resource group,
        /// and instance name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureLargeInstance/azureLargeInstances/{azureLargeInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureLargeInstance_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-20-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LargeInstanceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLargeInstanceResourceGroupResource.GetLargeInstanceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="azureLargeInstanceName"> Name of the AzureLargeInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="azureLargeInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="azureLargeInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<LargeInstanceResource>> GetLargeInstanceAsync(this ResourceGroupResource resourceGroupResource, string azureLargeInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableLargeInstanceResourceGroupResource(resourceGroupResource).GetLargeInstanceAsync(azureLargeInstanceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an Azure Large Instance for the specified subscription, resource group,
        /// and instance name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureLargeInstance/azureLargeInstances/{azureLargeInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureLargeInstance_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-20-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LargeInstanceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLargeInstanceResourceGroupResource.GetLargeInstance(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="azureLargeInstanceName"> Name of the AzureLargeInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="azureLargeInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="azureLargeInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<LargeInstanceResource> GetLargeInstance(this ResourceGroupResource resourceGroupResource, string azureLargeInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableLargeInstanceResourceGroupResource(resourceGroupResource).GetLargeInstance(azureLargeInstanceName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of LargeStorageInstanceResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLargeInstanceResourceGroupResource.GetLargeStorageInstances()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of LargeStorageInstanceResources and their operations over a LargeStorageInstanceResource. </returns>
        public static LargeStorageInstanceCollection GetLargeStorageInstances(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableLargeInstanceResourceGroupResource(resourceGroupResource).GetLargeStorageInstances();
        }

        /// <summary>
        /// Gets an Azure Large Storage instance for the specified subscription, resource
        /// group, and instance name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureLargeInstance/azureLargeStorageInstances/{azureLargeStorageInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureLargeStorageInstance_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-20-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LargeStorageInstanceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLargeInstanceResourceGroupResource.GetLargeStorageInstanceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="azureLargeStorageInstanceName"> Name of the AzureLargeStorageInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="azureLargeStorageInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="azureLargeStorageInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<LargeStorageInstanceResource>> GetLargeStorageInstanceAsync(this ResourceGroupResource resourceGroupResource, string azureLargeStorageInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableLargeInstanceResourceGroupResource(resourceGroupResource).GetLargeStorageInstanceAsync(azureLargeStorageInstanceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an Azure Large Storage instance for the specified subscription, resource
        /// group, and instance name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureLargeInstance/azureLargeStorageInstances/{azureLargeStorageInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureLargeStorageInstance_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-20-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LargeStorageInstanceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLargeInstanceResourceGroupResource.GetLargeStorageInstance(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="azureLargeStorageInstanceName"> Name of the AzureLargeStorageInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="azureLargeStorageInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="azureLargeStorageInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<LargeStorageInstanceResource> GetLargeStorageInstance(this ResourceGroupResource resourceGroupResource, string azureLargeStorageInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableLargeInstanceResourceGroupResource(resourceGroupResource).GetLargeStorageInstance(azureLargeStorageInstanceName, cancellationToken);
        }

        /// <summary>
        /// Gets a list of Azure Large Instances in the specified subscription. The
        /// operations returns various properties of each Azure Large Instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureLargeInstance/azureLargeInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureLargeInstance_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-20-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LargeInstanceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLargeInstanceSubscriptionResource.GetLargeInstances(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="LargeInstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<LargeInstanceResource> GetLargeInstancesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableLargeInstanceSubscriptionResource(subscriptionResource).GetLargeInstancesAsync(cancellationToken);
        }

        /// <summary>
        /// Gets a list of Azure Large Instances in the specified subscription. The
        /// operations returns various properties of each Azure Large Instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureLargeInstance/azureLargeInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureLargeInstance_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-20-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LargeInstanceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLargeInstanceSubscriptionResource.GetLargeInstances(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="LargeInstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<LargeInstanceResource> GetLargeInstances(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableLargeInstanceSubscriptionResource(subscriptionResource).GetLargeInstances(cancellationToken);
        }

        /// <summary>
        /// Gets a list of AzureLargeStorageInstances in the specified subscription. The
        /// operations returns various properties of each Azure LargeStorage instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureLargeInstance/azureLargeStorageInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureLargeStorageInstance_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-20-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LargeStorageInstanceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLargeInstanceSubscriptionResource.GetLargeStorageInstances(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="LargeStorageInstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<LargeStorageInstanceResource> GetLargeStorageInstancesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableLargeInstanceSubscriptionResource(subscriptionResource).GetLargeStorageInstancesAsync(cancellationToken);
        }

        /// <summary>
        /// Gets a list of AzureLargeStorageInstances in the specified subscription. The
        /// operations returns various properties of each Azure LargeStorage instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureLargeInstance/azureLargeStorageInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureLargeStorageInstance_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-20-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LargeStorageInstanceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLargeInstanceSubscriptionResource.GetLargeStorageInstances(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="LargeStorageInstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<LargeStorageInstanceResource> GetLargeStorageInstances(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableLargeInstanceSubscriptionResource(subscriptionResource).GetLargeStorageInstances(cancellationToken);
        }
    }
}
