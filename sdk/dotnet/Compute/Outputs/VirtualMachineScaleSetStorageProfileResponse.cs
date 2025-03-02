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
    /// Describes a virtual machine scale set storage profile.
    /// </summary>
    [OutputType]
    public sealed class VirtualMachineScaleSetStorageProfileResponse
    {
        /// <summary>
        /// Specifies the parameters that are used to add data disks to the virtual machines in the scale set. &lt;br&gt;&lt;br&gt; For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
        /// </summary>
        public readonly ImmutableArray<Outputs.VirtualMachineScaleSetDataDiskResponse> DataDisks;
        /// <summary>
        /// Specifies information about the image to use. You can specify information about platform images, marketplace images, or virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual machine image, but is not used in other creation operations.
        /// </summary>
        public readonly Outputs.ImageReferenceResponse? ImageReference;
        /// <summary>
        /// Specifies information about the operating system disk used by the virtual machines in the scale set. &lt;br&gt;&lt;br&gt; For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
        /// </summary>
        public readonly Outputs.VirtualMachineScaleSetOSDiskResponse? OsDisk;

        [OutputConstructor]
        private VirtualMachineScaleSetStorageProfileResponse(
            ImmutableArray<Outputs.VirtualMachineScaleSetDataDiskResponse> dataDisks,

            Outputs.ImageReferenceResponse? imageReference,

            Outputs.VirtualMachineScaleSetOSDiskResponse? osDisk)
        {
            DataDisks = dataDisks;
            ImageReference = imageReference;
            OsDisk = osDisk;
        }
    }
}
