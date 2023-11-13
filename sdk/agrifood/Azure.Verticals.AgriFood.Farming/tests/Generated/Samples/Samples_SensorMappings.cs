// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.Verticals.AgriFood.Farming;
using NUnit.Framework;

namespace Azure.Verticals.AgriFood.Farming.Samples
{
    public partial class Samples_SensorMappings
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorMappings client = new FarmBeatsClient(credential).GetSensorMappingsClient(apiVersion: "2022-11-01-preview");

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.CreateOrUpdate("<sensorMappingId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorMappings client = new FarmBeatsClient(credential).GetSensorMappingsClient(apiVersion: "2022-11-01-preview");

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.CreateOrUpdateAsync("<sensorMappingId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorMappings client = new FarmBeatsClient(credential).GetSensorMappingsClient(apiVersion: "2022-11-01-preview");

            using RequestContent content = RequestContent.Create(new
            {
                sensorId = "<sensorId>",
                sensorPartnerId = "<sensorPartnerId>",
                partyId = "<partyId>",
                boundaryId = "<boundaryId>",
                status = "<status>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = client.CreateOrUpdate("<sensorMappingId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("sensorId").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("boundaryId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorMappings client = new FarmBeatsClient(credential).GetSensorMappingsClient(apiVersion: "2022-11-01-preview");

            using RequestContent content = RequestContent.Create(new
            {
                sensorId = "<sensorId>",
                sensorPartnerId = "<sensorPartnerId>",
                partyId = "<partyId>",
                boundaryId = "<boundaryId>",
                status = "<status>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = await client.CreateOrUpdateAsync("<sensorMappingId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("sensorId").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("boundaryId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSensorMapping_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorMappings client = new FarmBeatsClient(credential).GetSensorMappingsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetSensorMapping("<sensorMappingId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSensorMapping_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorMappings client = new FarmBeatsClient(credential).GetSensorMappingsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetSensorMappingAsync("<sensorMappingId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSensorMapping_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorMappings client = new FarmBeatsClient(credential).GetSensorMappingsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetSensorMapping("<sensorMappingId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("sensorId").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("boundaryId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSensorMapping_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorMappings client = new FarmBeatsClient(credential).GetSensorMappingsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetSensorMappingAsync("<sensorMappingId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("sensorId").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("boundaryId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorMappings client = new FarmBeatsClient(credential).GetSensorMappingsClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<sensorMappingId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorMappings client = new FarmBeatsClient(credential).GetSensorMappingsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<sensorMappingId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorMappings client = new FarmBeatsClient(credential).GetSensorMappingsClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<sensorMappingId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorMappings client = new FarmBeatsClient(credential).GetSensorMappingsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<sensorMappingId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSensorMappings_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorMappings client = new FarmBeatsClient(credential).GetSensorMappingsClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetSensorMappings(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSensorMappings_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorMappings client = new FarmBeatsClient(credential).GetSensorMappingsClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetSensorMappingsAsync(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSensorMappings_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorMappings client = new FarmBeatsClient(credential).GetSensorMappingsClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetSensorMappings(new string[] { "<sensorIds>" }, new string[] { "<sensorPartnerIds>" }, new string[] { "<partyIds>" }, new string[] { "<boundaryIds>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("sensorId").ToString());
                Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
                Console.WriteLine(result.GetProperty("partyId").ToString());
                Console.WriteLine(result.GetProperty("boundaryId").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSensorMappings_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorMappings client = new FarmBeatsClient(credential).GetSensorMappingsClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetSensorMappingsAsync(new string[] { "<sensorIds>" }, new string[] { "<sensorPartnerIds>" }, new string[] { "<partyIds>" }, new string[] { "<boundaryIds>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("sensorId").ToString());
                Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
                Console.WriteLine(result.GetProperty("partyId").ToString());
                Console.WriteLine(result.GetProperty("boundaryId").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
            }
        }
    }
}
