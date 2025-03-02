// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Describes a Virtual Machine Scale Set.
 *
 * @deprecated Version 2018-10-01 will be removed in v2 of the provider.
 */
export class VirtualMachineScaleSet extends pulumi.CustomResource {
    /**
     * Get an existing VirtualMachineScaleSet resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): VirtualMachineScaleSet {
        pulumi.log.warn("VirtualMachineScaleSet is deprecated: Version 2018-10-01 will be removed in v2 of the provider.")
        return new VirtualMachineScaleSet(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:compute/v20181001:VirtualMachineScaleSet';

    /**
     * Returns true if the given object is an instance of VirtualMachineScaleSet.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VirtualMachineScaleSet {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VirtualMachineScaleSet.__pulumiType;
    }

    /**
     * Policy for automatic repairs.
     */
    public readonly automaticRepairsPolicy!: pulumi.Output<outputs.compute.v20181001.AutomaticRepairsPolicyResponse | undefined>;
    /**
     * When Overprovision is enabled, extensions are launched only on the requested number of VMs which are finally kept. This property will hence ensure that the extensions do not run on the extra overprovisioned VMs.
     */
    public readonly doNotRunExtensionsOnOverprovisionedVMs!: pulumi.Output<boolean | undefined>;
    /**
     * The identity of the virtual machine scale set, if configured.
     */
    public readonly identity!: pulumi.Output<outputs.compute.v20181001.VirtualMachineScaleSetIdentityResponse | undefined>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Specifies whether the Virtual Machine Scale Set should be overprovisioned.
     */
    public readonly overprovision!: pulumi.Output<boolean | undefined>;
    /**
     * Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started ->**. Enter any required information and then click **Save**.
     */
    public readonly plan!: pulumi.Output<outputs.compute.v20181001.PlanResponse | undefined>;
    /**
     * Fault Domain count for each placement group.
     */
    public readonly platformFaultDomainCount!: pulumi.Output<number | undefined>;
    /**
     * The provisioning state, which only appears in the response.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Specifies information about the proximity placement group that the virtual machine scale set should be assigned to. <br><br>Minimum api-version: 2018-04-01.
     */
    public readonly proximityPlacementGroup!: pulumi.Output<outputs.compute.v20181001.SubResourceResponse | undefined>;
    /**
     * When true this limits the scale set to a single placement group, of max size 100 virtual machines.
     */
    public readonly singlePlacementGroup!: pulumi.Output<boolean | undefined>;
    /**
     * The virtual machine scale set sku.
     */
    public readonly sku!: pulumi.Output<outputs.compute.v20181001.SkuResponse | undefined>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Specifies the ID which uniquely identifies a Virtual Machine Scale Set.
     */
    public /*out*/ readonly uniqueId!: pulumi.Output<string>;
    /**
     * The upgrade policy.
     */
    public readonly upgradePolicy!: pulumi.Output<outputs.compute.v20181001.UpgradePolicyResponse | undefined>;
    /**
     * The virtual machine profile.
     */
    public readonly virtualMachineProfile!: pulumi.Output<outputs.compute.v20181001.VirtualMachineScaleSetVMProfileResponse | undefined>;
    /**
     * Whether to force strictly even Virtual Machine distribution cross x-zones in case there is zone outage.
     */
    public readonly zoneBalance!: pulumi.Output<boolean | undefined>;
    /**
     * The virtual machine scale set zones. NOTE: Availability zones can only be set when you create the scale set.
     */
    public readonly zones!: pulumi.Output<string[] | undefined>;

    /**
     * Create a VirtualMachineScaleSet resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Version 2018-10-01 will be removed in v2 of the provider. */
    constructor(name: string, args: VirtualMachineScaleSetArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("VirtualMachineScaleSet is deprecated: Version 2018-10-01 will be removed in v2 of the provider.")
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            resourceInputs["automaticRepairsPolicy"] = args ? args.automaticRepairsPolicy : undefined;
            resourceInputs["doNotRunExtensionsOnOverprovisionedVMs"] = args ? args.doNotRunExtensionsOnOverprovisionedVMs : undefined;
            resourceInputs["identity"] = args ? args.identity : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["overprovision"] = args ? args.overprovision : undefined;
            resourceInputs["plan"] = args ? args.plan : undefined;
            resourceInputs["platformFaultDomainCount"] = args ? args.platformFaultDomainCount : undefined;
            resourceInputs["proximityPlacementGroup"] = args ? args.proximityPlacementGroup : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["singlePlacementGroup"] = args ? args.singlePlacementGroup : undefined;
            resourceInputs["sku"] = args ? args.sku : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["upgradePolicy"] = args ? args.upgradePolicy : undefined;
            resourceInputs["virtualMachineProfile"] = args ? args.virtualMachineProfile : undefined;
            resourceInputs["vmScaleSetName"] = args ? args.vmScaleSetName : undefined;
            resourceInputs["zoneBalance"] = args ? args.zoneBalance : undefined;
            resourceInputs["zones"] = args ? args.zones : undefined;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
            resourceInputs["uniqueId"] = undefined /*out*/;
        } else {
            resourceInputs["automaticRepairsPolicy"] = undefined /*out*/;
            resourceInputs["doNotRunExtensionsOnOverprovisionedVMs"] = undefined /*out*/;
            resourceInputs["identity"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["overprovision"] = undefined /*out*/;
            resourceInputs["plan"] = undefined /*out*/;
            resourceInputs["platformFaultDomainCount"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["proximityPlacementGroup"] = undefined /*out*/;
            resourceInputs["singlePlacementGroup"] = undefined /*out*/;
            resourceInputs["sku"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
            resourceInputs["uniqueId"] = undefined /*out*/;
            resourceInputs["upgradePolicy"] = undefined /*out*/;
            resourceInputs["virtualMachineProfile"] = undefined /*out*/;
            resourceInputs["zoneBalance"] = undefined /*out*/;
            resourceInputs["zones"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:compute:VirtualMachineScaleSet" }, { type: "azure-native:compute/v20150615:VirtualMachineScaleSet" }, { type: "azure-native:compute/v20160330:VirtualMachineScaleSet" }, { type: "azure-native:compute/v20160430preview:VirtualMachineScaleSet" }, { type: "azure-native:compute/v20170330:VirtualMachineScaleSet" }, { type: "azure-native:compute/v20171201:VirtualMachineScaleSet" }, { type: "azure-native:compute/v20180401:VirtualMachineScaleSet" }, { type: "azure-native:compute/v20180601:VirtualMachineScaleSet" }, { type: "azure-native:compute/v20190301:VirtualMachineScaleSet" }, { type: "azure-native:compute/v20190701:VirtualMachineScaleSet" }, { type: "azure-native:compute/v20191201:VirtualMachineScaleSet" }, { type: "azure-native:compute/v20200601:VirtualMachineScaleSet" }, { type: "azure-native:compute/v20201201:VirtualMachineScaleSet" }, { type: "azure-native:compute/v20210301:VirtualMachineScaleSet" }, { type: "azure-native:compute/v20210401:VirtualMachineScaleSet" }, { type: "azure-native:compute/v20210701:VirtualMachineScaleSet" }, { type: "azure-native:compute/v20211101:VirtualMachineScaleSet" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(VirtualMachineScaleSet.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a VirtualMachineScaleSet resource.
 */
export interface VirtualMachineScaleSetArgs {
    /**
     * Policy for automatic repairs.
     */
    automaticRepairsPolicy?: pulumi.Input<inputs.compute.v20181001.AutomaticRepairsPolicyArgs>;
    /**
     * When Overprovision is enabled, extensions are launched only on the requested number of VMs which are finally kept. This property will hence ensure that the extensions do not run on the extra overprovisioned VMs.
     */
    doNotRunExtensionsOnOverprovisionedVMs?: pulumi.Input<boolean>;
    /**
     * The identity of the virtual machine scale set, if configured.
     */
    identity?: pulumi.Input<inputs.compute.v20181001.VirtualMachineScaleSetIdentityArgs>;
    /**
     * Resource location
     */
    location?: pulumi.Input<string>;
    /**
     * Specifies whether the Virtual Machine Scale Set should be overprovisioned.
     */
    overprovision?: pulumi.Input<boolean>;
    /**
     * Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started ->**. Enter any required information and then click **Save**.
     */
    plan?: pulumi.Input<inputs.compute.v20181001.PlanArgs>;
    /**
     * Fault Domain count for each placement group.
     */
    platformFaultDomainCount?: pulumi.Input<number>;
    /**
     * Specifies information about the proximity placement group that the virtual machine scale set should be assigned to. <br><br>Minimum api-version: 2018-04-01.
     */
    proximityPlacementGroup?: pulumi.Input<inputs.compute.v20181001.SubResourceArgs>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * When true this limits the scale set to a single placement group, of max size 100 virtual machines.
     */
    singlePlacementGroup?: pulumi.Input<boolean>;
    /**
     * The virtual machine scale set sku.
     */
    sku?: pulumi.Input<inputs.compute.v20181001.SkuArgs>;
    /**
     * Resource tags
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The upgrade policy.
     */
    upgradePolicy?: pulumi.Input<inputs.compute.v20181001.UpgradePolicyArgs>;
    /**
     * The virtual machine profile.
     */
    virtualMachineProfile?: pulumi.Input<inputs.compute.v20181001.VirtualMachineScaleSetVMProfileArgs>;
    /**
     * The name of the VM scale set to create or update.
     */
    vmScaleSetName?: pulumi.Input<string>;
    /**
     * Whether to force strictly even Virtual Machine distribution cross x-zones in case there is zone outage.
     */
    zoneBalance?: pulumi.Input<boolean>;
    /**
     * The virtual machine scale set zones. NOTE: Availability zones can only be set when you create the scale set.
     */
    zones?: pulumi.Input<pulumi.Input<string>[]>;
}
