﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.ResourceManager.Core.Tests
{
    public class SubscriptionOperationsTests : ResourceManagerTestBase
    {
        private AzureResourceManagerClient _client;

        public SubscriptionOperationsTests(bool isAsync)
            : base(isAsync)//, RecordedTestMode.Record)
        {
        }

        [SetUp]
        public void SetUp()
        {
            _client = GetArmClient();
        }

        [TestCase(null)]
        [TestCase("")]
        [SyncOnly]
        [RecordedTest]
        public void TestGetResourceGroupOpsArgNullException(string resourceGroupName)
        {
            var subOps = _client.DefaultSubscription;
            Assert.Throws<ArgumentOutOfRangeException>(delegate { subOps.GetResourceGroupOperations(resourceGroupName); });
        }

        [TestCase("te%st")]        
        [TestCase("test ")]
        [TestCase("te$st")]
        [TestCase("te#st")]
        [TestCase("te#st")]
        [SyncOnly]
        [RecordedTest]
        public void TestGetResourceGroupOpsArgException(string resourceGroupName)
        {
            var subOps = _client.DefaultSubscription;
            Assert.Throws<ArgumentException>(delegate { subOps.GetResourceGroupOperations(resourceGroupName); });
        }

        [TestCase(91)]
        [SyncOnly]
        [RecordedTest]
        public void TestGetResourceGroupOpsOutOfRangeArgException(int length)
        {
            var resourceGroupName = GetLongString(length);
            var subOps = _client.DefaultSubscription;
            Assert.Throws<ArgumentOutOfRangeException>(delegate { subOps.GetResourceGroupOperations(resourceGroupName); });
        }

        [TestCase("te.st")]
        [TestCase("te")]
        [TestCase("t")]
        [SyncOnly]
        [RecordedTest]
        public void TestGetResourceGroupOpsValid(string resourceGroupName)
        {
            var subOps = _client.DefaultSubscription;
            Assert.DoesNotThrow(delegate { subOps.GetResourceGroupOperations(resourceGroupName); });
        }

        [TestCase(89)]
        [TestCase(90)]
        [SyncOnly]
        [RecordedTest]
        public void TestGetResourceGroupOpsLong(int length)
        {
            var resourceGroupName = GetLongString(length);
            var subOps = _client.DefaultSubscription;
            Assert.DoesNotThrow(delegate { subOps.GetResourceGroupOperations(resourceGroupName); });
        }

        private string GetLongString(int length)
        {
            StringBuilder builder = new StringBuilder();
            for(int i=0; i<length; i++)
            {
                builder.Append('a');
            }
            return builder.ToString();
        }
    }
}
