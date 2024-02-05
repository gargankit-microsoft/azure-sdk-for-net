// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.ManagementGroups;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ManagementGroupNetworkManagerConnectionCollection
    {
        // Create or Update Management Group Network Manager Connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateManagementGroupNetworkManagerConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkManagerConnectionManagementGroupPut.json
            // this example is just showing the usage of "ManagementGroupNetworkManagerConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagementGroupResource created on azure
            // for more information of creating ManagementGroupResource, please refer to the document of ManagementGroupResource
            string managementGroupId = "managementGroupA";
            ResourceIdentifier managementGroupResourceId = ManagementGroupResource.CreateResourceIdentifier(managementGroupId);
            ManagementGroupResource managementGroupResource = client.GetManagementGroupResource(managementGroupResourceId);

            // get the collection of this ManagementGroupNetworkManagerConnectionResource
            ManagementGroupNetworkManagerConnectionCollection collection = managementGroupResource.GetManagementGroupNetworkManagerConnections();

            // invoke the operation
            string networkManagerConnectionName = "TestNMConnection";
            NetworkManagerConnectionData data = new NetworkManagerConnectionData()
            {
                NetworkManagerId = new ResourceIdentifier("/subscriptions/subscriptionC/resourceGroup/rg1/providers/Microsoft.Network/networkManagers/testNetworkManager"),
            };
            ArmOperation<ManagementGroupNetworkManagerConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, networkManagerConnectionName, data);
            ManagementGroupNetworkManagerConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkManagerConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Management Group Network Manager Connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetManagementGroupNetworkManagerConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkManagerConnectionManagementGroupGet.json
            // this example is just showing the usage of "ManagementGroupNetworkManagerConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagementGroupResource created on azure
            // for more information of creating ManagementGroupResource, please refer to the document of ManagementGroupResource
            string managementGroupId = "managementGroupA";
            ResourceIdentifier managementGroupResourceId = ManagementGroupResource.CreateResourceIdentifier(managementGroupId);
            ManagementGroupResource managementGroupResource = client.GetManagementGroupResource(managementGroupResourceId);

            // get the collection of this ManagementGroupNetworkManagerConnectionResource
            ManagementGroupNetworkManagerConnectionCollection collection = managementGroupResource.GetManagementGroupNetworkManagerConnections();

            // invoke the operation
            string networkManagerConnectionName = "TestNMConnection";
            ManagementGroupNetworkManagerConnectionResource result = await collection.GetAsync(networkManagerConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkManagerConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Management Group Network Manager Connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetManagementGroupNetworkManagerConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkManagerConnectionManagementGroupGet.json
            // this example is just showing the usage of "ManagementGroupNetworkManagerConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagementGroupResource created on azure
            // for more information of creating ManagementGroupResource, please refer to the document of ManagementGroupResource
            string managementGroupId = "managementGroupA";
            ResourceIdentifier managementGroupResourceId = ManagementGroupResource.CreateResourceIdentifier(managementGroupId);
            ManagementGroupResource managementGroupResource = client.GetManagementGroupResource(managementGroupResourceId);

            // get the collection of this ManagementGroupNetworkManagerConnectionResource
            ManagementGroupNetworkManagerConnectionCollection collection = managementGroupResource.GetManagementGroupNetworkManagerConnections();

            // invoke the operation
            string networkManagerConnectionName = "TestNMConnection";
            bool result = await collection.ExistsAsync(networkManagerConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Management Group Network Manager Connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetManagementGroupNetworkManagerConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkManagerConnectionManagementGroupGet.json
            // this example is just showing the usage of "ManagementGroupNetworkManagerConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagementGroupResource created on azure
            // for more information of creating ManagementGroupResource, please refer to the document of ManagementGroupResource
            string managementGroupId = "managementGroupA";
            ResourceIdentifier managementGroupResourceId = ManagementGroupResource.CreateResourceIdentifier(managementGroupId);
            ManagementGroupResource managementGroupResource = client.GetManagementGroupResource(managementGroupResourceId);

            // get the collection of this ManagementGroupNetworkManagerConnectionResource
            ManagementGroupNetworkManagerConnectionCollection collection = managementGroupResource.GetManagementGroupNetworkManagerConnections();

            // invoke the operation
            string networkManagerConnectionName = "TestNMConnection";
            NullableResponse<ManagementGroupNetworkManagerConnectionResource> response = await collection.GetIfExistsAsync(networkManagerConnectionName);
            ManagementGroupNetworkManagerConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkManagerConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // List Management Group Network Manager Connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListManagementGroupNetworkManagerConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkManagerConnectionManagementGroupList.json
            // this example is just showing the usage of "ManagementGroupNetworkManagerConnections_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagementGroupResource created on azure
            // for more information of creating ManagementGroupResource, please refer to the document of ManagementGroupResource
            string managementGroupId = "managementGroupA";
            ResourceIdentifier managementGroupResourceId = ManagementGroupResource.CreateResourceIdentifier(managementGroupId);
            ManagementGroupResource managementGroupResource = client.GetManagementGroupResource(managementGroupResourceId);

            // get the collection of this ManagementGroupNetworkManagerConnectionResource
            ManagementGroupNetworkManagerConnectionCollection collection = managementGroupResource.GetManagementGroupNetworkManagerConnections();

            // invoke the operation and iterate over the result
            await foreach (ManagementGroupNetworkManagerConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkManagerConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
