// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerService.V20201201.Outputs
{

    /// <summary>
    /// Kubelet configurations of agent nodes.
    /// </summary>
    [OutputType]
    public sealed class KubeletConfigResponse
    {
        /// <summary>
        /// Allowlist of unsafe sysctls or unsafe sysctl patterns (ending in `*`).
        /// </summary>
        public readonly ImmutableArray<string> AllowedUnsafeSysctls;
        /// <summary>
        /// The maximum number of container log files that can be present for a container. The number must be ≥ 2.
        /// </summary>
        public readonly int? ContainerLogMaxFiles;
        /// <summary>
        /// The maximum size (e.g. 10Mi) of container log file before it is rotated.
        /// </summary>
        public readonly int? ContainerLogMaxSizeMB;
        /// <summary>
        /// Enable CPU CFS quota enforcement for containers that specify CPU limits.
        /// </summary>
        public readonly bool? CpuCfsQuota;
        /// <summary>
        /// Sets CPU CFS quota period value.
        /// </summary>
        public readonly string? CpuCfsQuotaPeriod;
        /// <summary>
        /// CPU Manager policy to use.
        /// </summary>
        public readonly string? CpuManagerPolicy;
        /// <summary>
        /// If set to true it will make the Kubelet fail to start if swap is enabled on the node.
        /// </summary>
        public readonly bool? FailSwapOn;
        /// <summary>
        /// The percent of disk usage after which image garbage collection is always run.
        /// </summary>
        public readonly int? ImageGcHighThreshold;
        /// <summary>
        /// The percent of disk usage before which image garbage collection is never run.
        /// </summary>
        public readonly int? ImageGcLowThreshold;
        /// <summary>
        /// The maximum number of processes per pod.
        /// </summary>
        public readonly int? PodMaxPids;
        /// <summary>
        /// Topology Manager policy to use.
        /// </summary>
        public readonly string? TopologyManagerPolicy;

        [OutputConstructor]
        private KubeletConfigResponse(
            ImmutableArray<string> allowedUnsafeSysctls,

            int? containerLogMaxFiles,

            int? containerLogMaxSizeMB,

            bool? cpuCfsQuota,

            string? cpuCfsQuotaPeriod,

            string? cpuManagerPolicy,

            bool? failSwapOn,

            int? imageGcHighThreshold,

            int? imageGcLowThreshold,

            int? podMaxPids,

            string? topologyManagerPolicy)
        {
            AllowedUnsafeSysctls = allowedUnsafeSysctls;
            ContainerLogMaxFiles = containerLogMaxFiles;
            ContainerLogMaxSizeMB = containerLogMaxSizeMB;
            CpuCfsQuota = cpuCfsQuota;
            CpuCfsQuotaPeriod = cpuCfsQuotaPeriod;
            CpuManagerPolicy = cpuManagerPolicy;
            FailSwapOn = failSwapOn;
            ImageGcHighThreshold = imageGcHighThreshold;
            ImageGcLowThreshold = imageGcLowThreshold;
            PodMaxPids = podMaxPids;
            TopologyManagerPolicy = topologyManagerPolicy;
        }
    }
}
