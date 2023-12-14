﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Usage", "AZC0001:Use one of the following pre-approved namespace groups (https://azure.github.io/azure-sdk/registered_namespaces.html): Azure.AI, Azure.Analytics, Azure.Communication, Azure.Data, Azure.DigitalTwins, Azure.IoT, Azure.Learn, Azure.Media, Azure.Management, Azure.Messaging, Azure.ResourceManager, Azure.Search, Azure.Security, Azure.Storage, Azure.Template, Azure.Identity, Microsoft.Extensions.Azure", Justification = "Temporary while awaiting namespace group approval", Scope = "namespaceanddescendants", Target = "~N:Azure.Developer.DevCenter")]
[assembly: SuppressMessage("Usage", "AZC0007:DO provide a minimal constructor that takes only the parameters required to connect to the service.", Justification = "False positives on minimal constructors", Scope = "namespaceanddescendants", Target = "~N:Azure.Developer.DevCenter")]
[assembly: SuppressMessage("Usage", "AZC0006:DO provide constructor overloads that allow specifying additional options.", Justification = "False positives on options constructors", Scope = "namespaceanddescendants", Target = "~N:Azure.Developer.DevCenter")]
[assembly: SuppressMessage("Usage", "AZC0031: Model name 'EnvironmentDefinition' ends with 'Definition'. Suggest to rename it to an appropriate name.", Justification = "Environment Definition is a Deployment Environment concept", Scope = "namespaceanddescendants", Target = "~N:Azure.Developer.DevCenter")]
[assembly: SuppressMessage("Usage", "AZC0030: Model name 'EnvironmentDefinitionParameter' ends with 'Parameter'. Suggest to rename it to 'EnvironmentDefinitionContent' or 'EnvironmentDefinitionPatch' or any other appropriate name.", Justification = "Environment Definition Parameter is a Deployment Environment concept", Scope = "namespaceanddescendants", Target = "~N:Azure.Developer.DevCenter")]
