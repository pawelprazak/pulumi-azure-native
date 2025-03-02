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
    /// Describes a virtual machine scale set virtual machine profile.
    /// </summary>
    [OutputType]
    public sealed class VirtualMachineScaleSetVMProfileResponse
    {
        /// <summary>
        /// The virtual machine scale set extension profile.
        /// </summary>
        public readonly Outputs.VirtualMachineScaleSetExtensionProfileResponse? ExtensionProfile;
        /// <summary>
        /// The virtual machine scale set network profile.
        /// </summary>
        public readonly Outputs.VirtualMachineScaleSetNetworkProfileResponse? NetworkProfile;
        /// <summary>
        /// The virtual machine scale set OS profile.
        /// </summary>
        public readonly Outputs.VirtualMachineScaleSetOSProfileResponse? OsProfile;
        /// <summary>
        /// The virtual machine scale set storage profile.
        /// </summary>
        public readonly Outputs.VirtualMachineScaleSetStorageProfileResponse? StorageProfile;

        [OutputConstructor]
        private VirtualMachineScaleSetVMProfileResponse(
            Outputs.VirtualMachineScaleSetExtensionProfileResponse? extensionProfile,

            Outputs.VirtualMachineScaleSetNetworkProfileResponse? networkProfile,

            Outputs.VirtualMachineScaleSetOSProfileResponse? osProfile,

            Outputs.VirtualMachineScaleSetStorageProfileResponse? storageProfile)
        {
            ExtensionProfile = extensionProfile;
            NetworkProfile = networkProfile;
            OsProfile = osProfile;
            StorageProfile = storageProfile;
        }
    }
}
