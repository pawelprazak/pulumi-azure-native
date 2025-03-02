// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Compute.V20191201.Outputs
{

    /// <summary>
    /// Describes the parameters of ephemeral disk settings that can be specified for operating system disk. &lt;br&gt;&lt;br&gt; NOTE: The ephemeral disk settings can only be specified for managed disk.
    /// </summary>
    [OutputType]
    public sealed class DiffDiskSettingsResponse
    {
        /// <summary>
        /// Specifies the ephemeral disk settings for operating system disk.
        /// </summary>
        public readonly string? Option;
        /// <summary>
        /// Specifies the ephemeral disk placement for operating system disk.&lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **CacheDisk** &lt;br&gt;&lt;br&gt; **ResourceDisk** &lt;br&gt;&lt;br&gt; Default: **CacheDisk** if one is configured for the VM size otherwise **ResourceDisk** is used.&lt;br&gt;&lt;br&gt; Refer to VM size documentation for Windows VM at https://docs.microsoft.com/en-us/azure/virtual-machines/windows/sizes and Linux VM at https://docs.microsoft.com/en-us/azure/virtual-machines/linux/sizes to check which VM sizes exposes a cache disk.
        /// </summary>
        public readonly string? Placement;

        [OutputConstructor]
        private DiffDiskSettingsResponse(
            string? option,

            string? placement)
        {
            Option = option;
            Placement = placement;
        }
    }
}
