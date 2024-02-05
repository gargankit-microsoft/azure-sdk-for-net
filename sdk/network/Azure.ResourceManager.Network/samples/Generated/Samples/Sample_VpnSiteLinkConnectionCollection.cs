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
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_VpnSiteLinkConnectionCollection
    {
        // VpnSiteLinkConnectionList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_VpnSiteLinkConnectionList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/VpnSiteLinkConnectionList.json
            // this example is just showing the usage of "VpnLinkConnections_ListByVpnConnection" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnConnectionResource created on azure
            // for more information of creating VpnConnectionResource, please refer to the document of VpnConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            string connectionName = "vpnConnection1";
            ResourceIdentifier vpnConnectionResourceId = VpnConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName, connectionName);
            VpnConnectionResource vpnConnection = client.GetVpnConnectionResource(vpnConnectionResourceId);

            // get the collection of this VpnSiteLinkConnectionResource
            VpnSiteLinkConnectionCollection collection = vpnConnection.GetVpnSiteLinkConnections();

            // invoke the operation and iterate over the result
            await foreach (VpnSiteLinkConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VpnSiteLinkConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // VpnSiteLinkConnectionGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VpnSiteLinkConnectionGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/VpnSiteLinkConnectionGet.json
            // this example is just showing the usage of "VpnSiteLinkConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnConnectionResource created on azure
            // for more information of creating VpnConnectionResource, please refer to the document of VpnConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            string connectionName = "vpnConnection1";
            ResourceIdentifier vpnConnectionResourceId = VpnConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName, connectionName);
            VpnConnectionResource vpnConnection = client.GetVpnConnectionResource(vpnConnectionResourceId);

            // get the collection of this VpnSiteLinkConnectionResource
            VpnSiteLinkConnectionCollection collection = vpnConnection.GetVpnSiteLinkConnections();

            // invoke the operation
            string linkConnectionName = "Connection-Link1";
            VpnSiteLinkConnectionResource result = await collection.GetAsync(linkConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnSiteLinkConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VpnSiteLinkConnectionGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_VpnSiteLinkConnectionGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/VpnSiteLinkConnectionGet.json
            // this example is just showing the usage of "VpnSiteLinkConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnConnectionResource created on azure
            // for more information of creating VpnConnectionResource, please refer to the document of VpnConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            string connectionName = "vpnConnection1";
            ResourceIdentifier vpnConnectionResourceId = VpnConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName, connectionName);
            VpnConnectionResource vpnConnection = client.GetVpnConnectionResource(vpnConnectionResourceId);

            // get the collection of this VpnSiteLinkConnectionResource
            VpnSiteLinkConnectionCollection collection = vpnConnection.GetVpnSiteLinkConnections();

            // invoke the operation
            string linkConnectionName = "Connection-Link1";
            bool result = await collection.ExistsAsync(linkConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // VpnSiteLinkConnectionGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_VpnSiteLinkConnectionGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/VpnSiteLinkConnectionGet.json
            // this example is just showing the usage of "VpnSiteLinkConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnConnectionResource created on azure
            // for more information of creating VpnConnectionResource, please refer to the document of VpnConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            string connectionName = "vpnConnection1";
            ResourceIdentifier vpnConnectionResourceId = VpnConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName, connectionName);
            VpnConnectionResource vpnConnection = client.GetVpnConnectionResource(vpnConnectionResourceId);

            // get the collection of this VpnSiteLinkConnectionResource
            VpnSiteLinkConnectionCollection collection = vpnConnection.GetVpnSiteLinkConnections();

            // invoke the operation
            string linkConnectionName = "Connection-Link1";
            NullableResponse<VpnSiteLinkConnectionResource> response = await collection.GetIfExistsAsync(linkConnectionName);
            VpnSiteLinkConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VpnSiteLinkConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
