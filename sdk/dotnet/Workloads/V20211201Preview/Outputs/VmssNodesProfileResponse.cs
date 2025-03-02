// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Workloads.V20211201Preview.Outputs
{

    /// <summary>
    /// VMSS profile
    /// </summary>
    [OutputType]
    public sealed class VmssNodesProfileResponse
    {
        /// <summary>
        /// Maximum number of nodes for autoscale
        /// </summary>
        public readonly int? AutoScaleMaxCount;
        /// <summary>
        /// Minimum number of nodes for autoscale
        /// </summary>
        public readonly int? AutoScaleMinCount;
        /// <summary>
        /// Data disks details. This property is not in use right now
        /// </summary>
        public readonly ImmutableArray<Outputs.DiskInfoResponse> DataDisks;
        /// <summary>
        /// VM or VMSS name
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// VM/VMSS resource ARM Ids
        /// </summary>
        public readonly ImmutableArray<string> NodeResourceIds;
        /// <summary>
        /// VM SKU for node(s)
        /// </summary>
        public readonly string NodeSku;
        /// <summary>
        /// OS disk details
        /// </summary>
        public readonly Outputs.DiskInfoResponse OsDisk;
        /// <summary>
        /// OS image used for creating the nodes
        /// </summary>
        public readonly Outputs.OsImageProfileResponse OsImage;

        [OutputConstructor]
        private VmssNodesProfileResponse(
            int? autoScaleMaxCount,

            int? autoScaleMinCount,

            ImmutableArray<Outputs.DiskInfoResponse> dataDisks,

            string? name,

            ImmutableArray<string> nodeResourceIds,

            string nodeSku,

            Outputs.DiskInfoResponse osDisk,

            Outputs.OsImageProfileResponse osImage)
        {
            AutoScaleMaxCount = autoScaleMaxCount;
            AutoScaleMinCount = autoScaleMinCount;
            DataDisks = dataDisks;
            Name = name;
            NodeResourceIds = nodeResourceIds;
            NodeSku = nodeSku;
            OsDisk = osDisk;
            OsImage = osImage;
        }
    }
}
