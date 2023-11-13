// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.JobRouter
{
    /// <summary>
    /// Abstract base class for defining a distribution mode
    /// Please note <see cref="DistributionMode"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="BestWorkerMode"/>, <see cref="LongestIdleMode"/> and <see cref="RoundRobinMode"/>.
    /// </summary>
    public abstract partial class DistributionMode
    {
        /// <summary> Initializes a new instance of DistributionMode. </summary>
        protected DistributionMode()
        {
        }

        /// <summary> Initializes a new instance of DistributionMode. </summary>
        /// <param name="minConcurrentOffers"> Governs the minimum desired number of active concurrent offers a job can have. </param>
        /// <param name="maxConcurrentOffers"> Governs the maximum number of active concurrent offers a job can have. </param>
        /// <param name="bypassSelectors"> If set to true, then router will match workers to jobs even if they don't match label selectors. Warning: You may get workers that are not qualified for the job they are matched with if you set this variable to true. This flag is intended more for temporary usage. By default, set to false. </param>
        /// <param name="kind"> The type discriminator describing a sub-type of DistributionMode. </param>
        internal DistributionMode(int minConcurrentOffers, int maxConcurrentOffers, bool? bypassSelectors, string kind)
        {
            MinConcurrentOffers = minConcurrentOffers;
            MaxConcurrentOffers = maxConcurrentOffers;
            BypassSelectors = bypassSelectors;
            Kind = kind;
        }
    }
}
