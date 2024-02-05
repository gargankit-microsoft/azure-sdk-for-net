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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ApplicationGatewayResource
    {
        // Delete ApplicationGateway
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteApplicationGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ApplicationGatewayDelete.json
            // this example is just showing the usage of "ApplicationGateways_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayResource created on azure
            // for more information of creating ApplicationGatewayResource, please refer to the document of ApplicationGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string applicationGatewayName = "appgw";
            ResourceIdentifier applicationGatewayResourceId = ApplicationGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGatewayName);
            ApplicationGatewayResource applicationGateway = client.GetApplicationGatewayResource(applicationGatewayResourceId);

            // invoke the operation
            await applicationGateway.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get ApplicationGateway
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetApplicationGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ApplicationGatewayGet.json
            // this example is just showing the usage of "ApplicationGateways_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayResource created on azure
            // for more information of creating ApplicationGatewayResource, please refer to the document of ApplicationGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string applicationGatewayName = "appgw";
            ResourceIdentifier applicationGatewayResourceId = ApplicationGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGatewayName);
            ApplicationGatewayResource applicationGateway = client.GetApplicationGatewayResource(applicationGatewayResourceId);

            // invoke the operation
            ApplicationGatewayResource result = await applicationGateway.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApplicationGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update Application Gateway tags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateApplicationGatewayTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ApplicationGatewayUpdateTags.json
            // this example is just showing the usage of "ApplicationGateways_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayResource created on azure
            // for more information of creating ApplicationGatewayResource, please refer to the document of ApplicationGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string applicationGatewayName = "AppGw";
            ResourceIdentifier applicationGatewayResourceId = ApplicationGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGatewayName);
            ApplicationGatewayResource applicationGateway = client.GetApplicationGatewayResource(applicationGatewayResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            ApplicationGatewayResource result = await applicationGateway.UpdateAsync(networkTagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApplicationGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Lists all application gateways in a subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetApplicationGateways_ListsAllApplicationGatewaysInASubscription()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ApplicationGatewayListAll.json
            // this example is just showing the usage of "ApplicationGateways_ListAll" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ApplicationGatewayResource item in subscriptionResource.GetApplicationGatewaysAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApplicationGatewayData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Start Application Gateway
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Start_StartApplicationGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ApplicationGatewayStart.json
            // this example is just showing the usage of "ApplicationGateways_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayResource created on azure
            // for more information of creating ApplicationGatewayResource, please refer to the document of ApplicationGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string applicationGatewayName = "appgw";
            ResourceIdentifier applicationGatewayResourceId = ApplicationGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGatewayName);
            ApplicationGatewayResource applicationGateway = client.GetApplicationGatewayResource(applicationGatewayResourceId);

            // invoke the operation
            await applicationGateway.StartAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Stop Application Gateway
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Stop_StopApplicationGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ApplicationGatewayStop.json
            // this example is just showing the usage of "ApplicationGateways_Stop" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayResource created on azure
            // for more information of creating ApplicationGatewayResource, please refer to the document of ApplicationGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string applicationGatewayName = "appgw";
            ResourceIdentifier applicationGatewayResourceId = ApplicationGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGatewayName);
            ApplicationGatewayResource applicationGateway = client.GetApplicationGatewayResource(applicationGatewayResourceId);

            // invoke the operation
            await applicationGateway.StopAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get Backend Health
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task BackendHealth_GetBackendHealth()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ApplicationGatewayBackendHealthGet.json
            // this example is just showing the usage of "ApplicationGateways_BackendHealth" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayResource created on azure
            // for more information of creating ApplicationGatewayResource, please refer to the document of ApplicationGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "appgw";
            string applicationGatewayName = "appgw";
            ResourceIdentifier applicationGatewayResourceId = ApplicationGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGatewayName);
            ApplicationGatewayResource applicationGateway = client.GetApplicationGatewayResource(applicationGatewayResourceId);

            // invoke the operation
            ArmOperation<ApplicationGatewayBackendHealth> lro = await applicationGateway.BackendHealthAsync(WaitUntil.Completed);
            ApplicationGatewayBackendHealth result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Test Backend Health
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task BackendHealthOnDemand_TestBackendHealth()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ApplicationGatewayBackendHealthTest.json
            // this example is just showing the usage of "ApplicationGateways_BackendHealthOnDemand" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayResource created on azure
            // for more information of creating ApplicationGatewayResource, please refer to the document of ApplicationGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string applicationGatewayName = "appgw";
            ResourceIdentifier applicationGatewayResourceId = ApplicationGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGatewayName);
            ApplicationGatewayResource applicationGateway = client.GetApplicationGatewayResource(applicationGatewayResourceId);

            // invoke the operation
            ApplicationGatewayOnDemandProbe probeRequest = new ApplicationGatewayOnDemandProbe()
            {
                Protocol = ApplicationGatewayProtocol.Http,
                Path = "/",
                Timeout = 30,
                PickHostNameFromBackendHttpSettings = true,
                BackendAddressPoolId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/applicationGateways/appgw/backendaddressPools/MFAnalyticsPool"),
                BackendHttpSettingsId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/applicationGateways/appgw/backendHttpSettingsCollection/MFPoolSettings"),
            };
            ArmOperation<ApplicationGatewayBackendHealthOnDemand> lro = await applicationGateway.BackendHealthOnDemandAsync(WaitUntil.Completed, probeRequest);
            ApplicationGatewayBackendHealthOnDemand result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Available Server Variables
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAvailableServerVariablesApplicationGateways_GetAvailableServerVariables()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ApplicationGatewayAvailableServerVariablesGet.json
            // this example is just showing the usage of "ApplicationGateways_ListAvailableServerVariables" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "72f988bf-86f1-41af-91ab-2d7cd0dddd4";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (string item in subscriptionResource.GetAvailableServerVariablesApplicationGatewaysAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Available Request Headers
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAvailableRequestHeadersApplicationGateways_GetAvailableRequestHeaders()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ApplicationGatewayAvailableRequestHeadersGet.json
            // this example is just showing the usage of "ApplicationGateways_ListAvailableRequestHeaders" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "72f988bf-86f1-41af-91ab-2d7cd0dddd4";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (string item in subscriptionResource.GetAvailableRequestHeadersApplicationGatewaysAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Available Response Headers
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAvailableResponseHeadersApplicationGateways_GetAvailableResponseHeaders()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ApplicationGatewayAvailableResponseHeadersGet.json
            // this example is just showing the usage of "ApplicationGateways_ListAvailableResponseHeaders" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "72f988bf-86f1-41af-91ab-2d7cd0dddd4";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (string item in subscriptionResource.GetAvailableResponseHeadersApplicationGatewaysAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Available Waf Rule Sets
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAppGatewayAvailableWafRuleSets_GetAvailableWafRuleSets()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ApplicationGatewayAvailableWafRuleSetsGet.json
            // this example is just showing the usage of "ApplicationGateways_ListAvailableWafRuleSets" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ApplicationGatewayFirewallRuleSet item in subscriptionResource.GetAppGatewayAvailableWafRuleSetsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Available Ssl Options
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetApplicationGatewayAvailableSslOptions_GetAvailableSslOptions()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ApplicationGatewayAvailableSslOptionsGet.json
            // this example is just showing the usage of "ApplicationGateways_ListAvailableSslOptions" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            ApplicationGatewayAvailableSslOptionsInfo result = await subscriptionResource.GetApplicationGatewayAvailableSslOptionsAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Available Ssl Predefined Policies
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetApplicationGatewayAvailableSslPredefinedPolicies_GetAvailableSslPredefinedPolicies()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ApplicationGatewayAvailableSslOptionsPredefinedPoliciesGet.json
            // this example is just showing the usage of "ApplicationGateways_ListAvailableSslPredefinedPolicies" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ApplicationGatewaySslPredefinedPolicy item in subscriptionResource.GetApplicationGatewayAvailableSslPredefinedPoliciesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Available Ssl Predefined Policy by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetApplicationGatewaySslPredefinedPolicy_GetAvailableSslPredefinedPolicyByName()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ApplicationGatewayAvailableSslOptionsPredefinedPolicyGet.json
            // this example is just showing the usage of "ApplicationGateways_GetSslPredefinedPolicy" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            string predefinedPolicyName = "AppGwSslPolicy20150501";
            ApplicationGatewaySslPredefinedPolicy result = await subscriptionResource.GetApplicationGatewaySslPredefinedPolicyAsync(predefinedPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Lists all private link resources on application gateway
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetApplicationGatewayPrivateLinkResources_ListsAllPrivateLinkResourcesOnApplicationGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/ApplicationGatewayPrivateLinkResourceList.json
            // this example is just showing the usage of "ApplicationGatewayPrivateLinkResources_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayResource created on azure
            // for more information of creating ApplicationGatewayResource, please refer to the document of ApplicationGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string applicationGatewayName = "appgw";
            ResourceIdentifier applicationGatewayResourceId = ApplicationGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGatewayName);
            ApplicationGatewayResource applicationGateway = client.GetApplicationGatewayResource(applicationGatewayResourceId);

            // invoke the operation and iterate over the result
            await foreach (ApplicationGatewayPrivateLinkResource item in applicationGateway.GetApplicationGatewayPrivateLinkResourcesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
