// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Compute.Outputs
{

    /// <summary>
    /// Specifies the hardware settings for the virtual machine.
    /// </summary>
    [OutputType]
    public sealed class HardwareProfileResponse
    {
        /// <summary>
        /// Specifies the size of the virtual machine. &lt;br&gt;&lt;br&gt; The enum data type is currently deprecated and will be removed by December 23rd 2023. &lt;br&gt;&lt;br&gt; Recommended way to get the list of available sizes is using these APIs: &lt;br&gt;&lt;br&gt; [List all available virtual machine sizes in an availability set](https://docs.microsoft.com/rest/api/compute/availabilitysets/listavailablesizes) &lt;br&gt;&lt;br&gt; [List all available virtual machine sizes in a region]( https://docs.microsoft.com/rest/api/compute/resourceskus/list) &lt;br&gt;&lt;br&gt; [List all available virtual machine sizes for resizing](https://docs.microsoft.com/rest/api/compute/virtualmachines/listavailablesizes). For more information about virtual machine sizes, see [Sizes for virtual machines](https://docs.microsoft.com/azure/virtual-machines/sizes). &lt;br&gt;&lt;br&gt; The available VM sizes depend on region and availability set.
        /// </summary>
        public readonly string? VmSize;

        [OutputConstructor]
        private HardwareProfileResponse(string? vmSize)
        {
            VmSize = vmSize;
        }
    }
}
