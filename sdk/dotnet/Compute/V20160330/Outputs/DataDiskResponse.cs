// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Compute.V20160330.Outputs
{

    /// <summary>
    /// Describes a data disk.
    /// </summary>
    [OutputType]
    public sealed class DataDiskResponse
    {
        /// <summary>
        /// Specifies the caching requirements. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **None** &lt;br&gt;&lt;br&gt; **ReadOnly** &lt;br&gt;&lt;br&gt; **ReadWrite** &lt;br&gt;&lt;br&gt; Default: **None for Standard storage. ReadOnly for Premium storage**
        /// </summary>
        public readonly string? Caching;
        /// <summary>
        /// Specifies how the virtual machine should be created.&lt;br&gt;&lt;br&gt; Possible values are:&lt;br&gt;&lt;br&gt; **Attach** \u2013 This value is used when you are using a specialized disk to create the virtual machine.&lt;br&gt;&lt;br&gt; **FromImage** \u2013 This value is used when you are using an image to create the virtual machine. If you are using a platform image, you also use the imageReference element described above. If you are using a marketplace image, you  also use the plan element previously described.
        /// </summary>
        public readonly string CreateOption;
        /// <summary>
        /// Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the size of the disk in a virtual machine image. &lt;br&gt;&lt;br&gt; This value cannot be larger than 1023 GB
        /// </summary>
        public readonly int? DiskSizeGB;
        /// <summary>
        /// The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist.
        /// </summary>
        public readonly Outputs.VirtualHardDiskResponse? Image;
        /// <summary>
        /// Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM.
        /// </summary>
        public readonly int Lun;
        /// <summary>
        /// The disk name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The virtual hard disk.
        /// </summary>
        public readonly Outputs.VirtualHardDiskResponse Vhd;

        [OutputConstructor]
        private DataDiskResponse(
            string? caching,

            string createOption,

            int? diskSizeGB,

            Outputs.VirtualHardDiskResponse? image,

            int lun,

            string name,

            Outputs.VirtualHardDiskResponse vhd)
        {
            Caching = caching;
            CreateOption = createOption;
            DiskSizeGB = diskSizeGB;
            Image = image;
            Lun = lun;
            Name = name;
            Vhd = vhd;
        }
    }
}
