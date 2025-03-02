// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.LabServices.Outputs
{

    /// <summary>
    /// Represents a size category supported by this Lab Account (small, medium or large)
    /// </summary>
    [OutputType]
    public sealed class EnvironmentSizeResponse
    {
        /// <summary>
        /// The pay-as-you-go dollar price per hour this size will cost. It does not include discounts and may not reflect the actual price the size will cost. This is the maximum price of all prices within this tier.
        /// </summary>
        public readonly double MaxPrice;
        /// <summary>
        /// The amount of memory available (in GB). This is the minimum amount of memory within this tier.
        /// </summary>
        public readonly double MinMemory;
        /// <summary>
        /// The number of cores a VM of this size has. This is the minimum number of cores within this tier.
        /// </summary>
        public readonly int MinNumberOfCores;
        /// <summary>
        /// The size category
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Represents a set of compute sizes that can serve this given size type
        /// </summary>
        public readonly ImmutableArray<Outputs.SizeInfoResponse> VmSizes;

        [OutputConstructor]
        private EnvironmentSizeResponse(
            double maxPrice,

            double minMemory,

            int minNumberOfCores,

            string? name,

            ImmutableArray<Outputs.SizeInfoResponse> vmSizes)
        {
            MaxPrice = maxPrice;
            MinMemory = minMemory;
            MinNumberOfCores = minNumberOfCores;
            Name = name;
            VmSizes = vmSizes;
        }
    }
}
