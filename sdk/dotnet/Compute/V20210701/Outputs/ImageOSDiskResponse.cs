// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Compute.V20210701.Outputs
{

    /// <summary>
    /// Describes an Operating System disk.
    /// </summary>
    [OutputType]
    public sealed class ImageOSDiskResponse
    {
        /// <summary>
        /// The Virtual Hard Disk.
        /// </summary>
        public readonly string? BlobUri;
        /// <summary>
        /// Specifies the caching requirements. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **None** &lt;br&gt;&lt;br&gt; **ReadOnly** &lt;br&gt;&lt;br&gt; **ReadWrite** &lt;br&gt;&lt;br&gt; Default: **None for Standard storage. ReadOnly for Premium storage**
        /// </summary>
        public readonly string? Caching;
        /// <summary>
        /// Specifies the customer managed disk encryption set resource id for the managed image disk.
        /// </summary>
        public readonly Outputs.DiskEncryptionSetParametersResponse? DiskEncryptionSet;
        /// <summary>
        /// Specifies the size of empty data disks in gigabytes. This element can be used to overwrite the name of the disk in a virtual machine image. &lt;br&gt;&lt;br&gt; This value cannot be larger than 1023 GB
        /// </summary>
        public readonly int? DiskSizeGB;
        /// <summary>
        /// The managedDisk.
        /// </summary>
        public readonly Outputs.SubResourceResponse? ManagedDisk;
        /// <summary>
        /// The OS State.
        /// </summary>
        public readonly string OsState;
        /// <summary>
        /// This property allows you to specify the type of the OS that is included in the disk if creating a VM from a custom image. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**
        /// </summary>
        public readonly string OsType;
        /// <summary>
        /// The snapshot.
        /// </summary>
        public readonly Outputs.SubResourceResponse? Snapshot;
        /// <summary>
        /// Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with data disks, it cannot be used with OS Disk.
        /// </summary>
        public readonly string? StorageAccountType;

        [OutputConstructor]
        private ImageOSDiskResponse(
            string? blobUri,

            string? caching,

            Outputs.DiskEncryptionSetParametersResponse? diskEncryptionSet,

            int? diskSizeGB,

            Outputs.SubResourceResponse? managedDisk,

            string osState,

            string osType,

            Outputs.SubResourceResponse? snapshot,

            string? storageAccountType)
        {
            BlobUri = blobUri;
            Caching = caching;
            DiskEncryptionSet = diskEncryptionSet;
            DiskSizeGB = diskSizeGB;
            ManagedDisk = managedDisk;
            OsState = osState;
            OsType = osType;
            Snapshot = snapshot;
            StorageAccountType = storageAccountType;
        }
    }
}
