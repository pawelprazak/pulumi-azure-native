// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Compute.V20190301.Outputs
{

    /// <summary>
    /// Describes the target region information.
    /// </summary>
    [OutputType]
    public sealed class TargetRegionResponse
    {
        /// <summary>
        /// The name of the region.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The number of replicas of the Image Version to be created per region. This property is updatable.
        /// </summary>
        public readonly int? RegionalReplicaCount;
        /// <summary>
        /// Specifies the storage account type to be used to store the image. This property is not updatable.
        /// </summary>
        public readonly string? StorageAccountType;

        [OutputConstructor]
        private TargetRegionResponse(
            string name,

            int? regionalReplicaCount,

            string? storageAccountType)
        {
            Name = name;
            RegionalReplicaCount = regionalReplicaCount;
            StorageAccountType = storageAccountType;
        }
    }
}
