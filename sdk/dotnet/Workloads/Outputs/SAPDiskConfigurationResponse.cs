// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Workloads.Outputs
{

    /// <summary>
    /// The SAP Disk Configuration.
    /// </summary>
    [OutputType]
    public sealed class SAPDiskConfigurationResponse
    {
        /// <summary>
        /// The disk count.
        /// </summary>
        public readonly double? DiskCount;
        /// <summary>
        /// The disk Iops.
        /// </summary>
        public readonly double? DiskIopsReadWrite;
        /// <summary>
        /// The disk provisioned throughput in MBps.
        /// </summary>
        public readonly double? DiskMBpsReadWrite;
        /// <summary>
        /// The disk size in GB.
        /// </summary>
        public readonly double? DiskSizeGB;
        /// <summary>
        /// The disk storage type
        /// </summary>
        public readonly string? DiskStorageType;
        /// <summary>
        /// The disk type.
        /// </summary>
        public readonly string? DiskType;
        /// <summary>
        /// The volume name.
        /// </summary>
        public readonly string? Volume;

        [OutputConstructor]
        private SAPDiskConfigurationResponse(
            double? diskCount,

            double? diskIopsReadWrite,

            double? diskMBpsReadWrite,

            double? diskSizeGB,

            string? diskStorageType,

            string? diskType,

            string? volume)
        {
            DiskCount = diskCount;
            DiskIopsReadWrite = diskIopsReadWrite;
            DiskMBpsReadWrite = diskMBpsReadWrite;
            DiskSizeGB = diskSizeGB;
            DiskStorageType = diskStorageType;
            DiskType = diskType;
            Volume = volume;
        }
    }
}
