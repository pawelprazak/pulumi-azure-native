// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerInstance.V20170801Preview.Outputs
{

    /// <summary>
    /// The resource requests.
    /// </summary>
    [OutputType]
    public sealed class ResourceRequestsResponse
    {
        /// <summary>
        /// The CPU request of this container instance.
        /// </summary>
        public readonly double Cpu;
        /// <summary>
        /// The memory request in GB of this container instance.
        /// </summary>
        public readonly double MemoryInGB;

        [OutputConstructor]
        private ResourceRequestsResponse(
            double cpu,

            double memoryInGB)
        {
            Cpu = cpu;
            MemoryInGB = memoryInGB;
        }
    }
}
