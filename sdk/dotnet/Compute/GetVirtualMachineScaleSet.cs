// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Compute
{
    public static class GetVirtualMachineScaleSet
    {
        /// <summary>
        /// Describes a Virtual Machine Scale Set.
        /// API Version: 2021-03-01.
        /// </summary>
        public static Task<GetVirtualMachineScaleSetResult> InvokeAsync(GetVirtualMachineScaleSetArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVirtualMachineScaleSetResult>("azure-native:compute:getVirtualMachineScaleSet", args ?? new GetVirtualMachineScaleSetArgs(), options.WithDefaults());

        /// <summary>
        /// Describes a Virtual Machine Scale Set.
        /// API Version: 2021-03-01.
        /// </summary>
        public static Output<GetVirtualMachineScaleSetResult> Invoke(GetVirtualMachineScaleSetInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetVirtualMachineScaleSetResult>("azure-native:compute:getVirtualMachineScaleSet", args ?? new GetVirtualMachineScaleSetInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetVirtualMachineScaleSetArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The expand expression to apply on the operation. 'UserData' retrieves the UserData property of the VM scale set that was provided by the user during the VM scale set Create/Update operation
        /// </summary>
        [Input("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the VM scale set.
        /// </summary>
        [Input("vmScaleSetName", required: true)]
        public string VmScaleSetName { get; set; } = null!;

        public GetVirtualMachineScaleSetArgs()
        {
        }
    }

    public sealed class GetVirtualMachineScaleSetInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The expand expression to apply on the operation. 'UserData' retrieves the UserData property of the VM scale set that was provided by the user during the VM scale set Create/Update operation
        /// </summary>
        [Input("expand")]
        public Input<string>? Expand { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the VM scale set.
        /// </summary>
        [Input("vmScaleSetName", required: true)]
        public Input<string> VmScaleSetName { get; set; } = null!;

        public GetVirtualMachineScaleSetInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetVirtualMachineScaleSetResult
    {
        /// <summary>
        /// Specifies additional capabilities enabled or disabled on the Virtual Machines in the Virtual Machine Scale Set. For instance: whether the Virtual Machines have the capability to support attaching managed data disks with UltraSSD_LRS storage account type.
        /// </summary>
        public readonly Outputs.AdditionalCapabilitiesResponse? AdditionalCapabilities;
        /// <summary>
        /// Policy for automatic repairs.
        /// </summary>
        public readonly Outputs.AutomaticRepairsPolicyResponse? AutomaticRepairsPolicy;
        /// <summary>
        /// When Overprovision is enabled, extensions are launched only on the requested number of VMs which are finally kept. This property will hence ensure that the extensions do not run on the extra overprovisioned VMs.
        /// </summary>
        public readonly bool? DoNotRunExtensionsOnOverprovisionedVMs;
        /// <summary>
        /// The extended location of the Virtual Machine Scale Set.
        /// </summary>
        public readonly Outputs.ExtendedLocationResponse? ExtendedLocation;
        /// <summary>
        /// Specifies information about the dedicated host group that the virtual machine scale set resides in. &lt;br&gt;&lt;br&gt;Minimum api-version: 2020-06-01.
        /// </summary>
        public readonly Outputs.SubResourceResponse? HostGroup;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The identity of the virtual machine scale set, if configured.
        /// </summary>
        public readonly Outputs.VirtualMachineScaleSetIdentityResponse? Identity;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Specifies the orchestration mode for the virtual machine scale set.
        /// </summary>
        public readonly string? OrchestrationMode;
        /// <summary>
        /// Specifies whether the Virtual Machine Scale Set should be overprovisioned.
        /// </summary>
        public readonly bool? Overprovision;
        /// <summary>
        /// Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started -&gt;**. Enter any required information and then click **Save**.
        /// </summary>
        public readonly Outputs.PlanResponse? Plan;
        /// <summary>
        /// Fault Domain count for each placement group.
        /// </summary>
        public readonly int? PlatformFaultDomainCount;
        /// <summary>
        /// The provisioning state, which only appears in the response.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Specifies information about the proximity placement group that the virtual machine scale set should be assigned to. &lt;br&gt;&lt;br&gt;Minimum api-version: 2018-04-01.
        /// </summary>
        public readonly Outputs.SubResourceResponse? ProximityPlacementGroup;
        /// <summary>
        /// Specifies the scale-in policy that decides which virtual machines are chosen for removal when a Virtual Machine Scale Set is scaled-in.
        /// </summary>
        public readonly Outputs.ScaleInPolicyResponse? ScaleInPolicy;
        /// <summary>
        /// When true this limits the scale set to a single placement group, of max size 100 virtual machines. NOTE: If singlePlacementGroup is true, it may be modified to false. However, if singlePlacementGroup is false, it may not be modified to true.
        /// </summary>
        public readonly bool? SinglePlacementGroup;
        /// <summary>
        /// The virtual machine scale set sku.
        /// </summary>
        public readonly Outputs.SkuResponse? Sku;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Specifies the ID which uniquely identifies a Virtual Machine Scale Set.
        /// </summary>
        public readonly string UniqueId;
        /// <summary>
        /// The upgrade policy.
        /// </summary>
        public readonly Outputs.UpgradePolicyResponse? UpgradePolicy;
        /// <summary>
        /// The virtual machine profile.
        /// </summary>
        public readonly Outputs.VirtualMachineScaleSetVMProfileResponse? VirtualMachineProfile;
        /// <summary>
        /// Whether to force strictly even Virtual Machine distribution cross x-zones in case there is zone outage.
        /// </summary>
        public readonly bool? ZoneBalance;
        /// <summary>
        /// The virtual machine scale set zones. NOTE: Availability zones can only be set when you create the scale set
        /// </summary>
        public readonly ImmutableArray<string> Zones;

        [OutputConstructor]
        private GetVirtualMachineScaleSetResult(
            Outputs.AdditionalCapabilitiesResponse? additionalCapabilities,

            Outputs.AutomaticRepairsPolicyResponse? automaticRepairsPolicy,

            bool? doNotRunExtensionsOnOverprovisionedVMs,

            Outputs.ExtendedLocationResponse? extendedLocation,

            Outputs.SubResourceResponse? hostGroup,

            string id,

            Outputs.VirtualMachineScaleSetIdentityResponse? identity,

            string location,

            string name,

            string? orchestrationMode,

            bool? overprovision,

            Outputs.PlanResponse? plan,

            int? platformFaultDomainCount,

            string provisioningState,

            Outputs.SubResourceResponse? proximityPlacementGroup,

            Outputs.ScaleInPolicyResponse? scaleInPolicy,

            bool? singlePlacementGroup,

            Outputs.SkuResponse? sku,

            ImmutableDictionary<string, string>? tags,

            string type,

            string uniqueId,

            Outputs.UpgradePolicyResponse? upgradePolicy,

            Outputs.VirtualMachineScaleSetVMProfileResponse? virtualMachineProfile,

            bool? zoneBalance,

            ImmutableArray<string> zones)
        {
            AdditionalCapabilities = additionalCapabilities;
            AutomaticRepairsPolicy = automaticRepairsPolicy;
            DoNotRunExtensionsOnOverprovisionedVMs = doNotRunExtensionsOnOverprovisionedVMs;
            ExtendedLocation = extendedLocation;
            HostGroup = hostGroup;
            Id = id;
            Identity = identity;
            Location = location;
            Name = name;
            OrchestrationMode = orchestrationMode;
            Overprovision = overprovision;
            Plan = plan;
            PlatformFaultDomainCount = platformFaultDomainCount;
            ProvisioningState = provisioningState;
            ProximityPlacementGroup = proximityPlacementGroup;
            ScaleInPolicy = scaleInPolicy;
            SinglePlacementGroup = singlePlacementGroup;
            Sku = sku;
            Tags = tags;
            Type = type;
            UniqueId = uniqueId;
            UpgradePolicy = upgradePolicy;
            VirtualMachineProfile = virtualMachineProfile;
            ZoneBalance = zoneBalance;
            Zones = zones;
        }
    }
}
