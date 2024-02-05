// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.DeviceUpdate;
using Azure.ResourceManager.DeviceUpdate.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DeviceUpdate.Samples
{
    public partial class Sample_SubscriptionResourceExtensions
    {
        // CheckNameAvailability_AlreadyExists
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckDeviceUpdateNameAvailability_CheckNameAvailabilityAlreadyExists()
        {
            // Generated from example definition: specification/deviceupdate/resource-manager/Microsoft.DeviceUpdate/stable/2023-07-01/examples/CheckNameAvailability_AlreadyExists.json
            // this example is just showing the usage of "CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            DeviceUpdateAvailabilityContent content = new DeviceUpdateAvailabilityContent()
            {
                Name = "contoso",
                CheckNameAvailabilityRequestType = new ResourceType("Microsoft.DeviceUpdate/accounts"),
            };
            DeviceUpdateNameAvailabilityResult result = await subscriptionResource.CheckDeviceUpdateNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // CheckNameAvailability_Available
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckDeviceUpdateNameAvailability_CheckNameAvailabilityAvailable()
        {
            // Generated from example definition: specification/deviceupdate/resource-manager/Microsoft.DeviceUpdate/stable/2023-07-01/examples/CheckNameAvailability_Available.json
            // this example is just showing the usage of "CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            DeviceUpdateAvailabilityContent content = new DeviceUpdateAvailabilityContent()
            {
                Name = "contoso",
                CheckNameAvailabilityRequestType = new ResourceType("Microsoft.DeviceUpdate/accounts"),
            };
            DeviceUpdateNameAvailabilityResult result = await subscriptionResource.CheckDeviceUpdateNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
