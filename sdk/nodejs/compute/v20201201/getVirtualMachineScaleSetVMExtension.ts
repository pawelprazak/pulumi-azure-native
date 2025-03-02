// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Describes a VMSS VM Extension.
 */
export function getVirtualMachineScaleSetVMExtension(args: GetVirtualMachineScaleSetVMExtensionArgs, opts?: pulumi.InvokeOptions): Promise<GetVirtualMachineScaleSetVMExtensionResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:compute/v20201201:getVirtualMachineScaleSetVMExtension", {
        "expand": args.expand,
        "instanceId": args.instanceId,
        "resourceGroupName": args.resourceGroupName,
        "vmExtensionName": args.vmExtensionName,
        "vmScaleSetName": args.vmScaleSetName,
    }, opts);
}

export interface GetVirtualMachineScaleSetVMExtensionArgs {
    /**
     * The expand expression to apply on the operation.
     */
    expand?: string;
    /**
     * The instance ID of the virtual machine.
     */
    instanceId: string;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
    /**
     * The name of the virtual machine extension.
     */
    vmExtensionName: string;
    /**
     * The name of the VM scale set.
     */
    vmScaleSetName: string;
}

/**
 * Describes a VMSS VM Extension.
 */
export interface GetVirtualMachineScaleSetVMExtensionResult {
    /**
     * Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
     */
    readonly autoUpgradeMinorVersion?: boolean;
    /**
     * Indicates whether the extension should be automatically upgraded by the platform if there is a newer version of the extension available.
     */
    readonly enableAutomaticUpgrade?: boolean;
    /**
     * How the extension handler should be forced to update even if the extension configuration has not changed.
     */
    readonly forceUpdateTag?: string;
    /**
     * Resource Id
     */
    readonly id: string;
    /**
     * The virtual machine extension instance view.
     */
    readonly instanceView?: outputs.compute.v20201201.VirtualMachineExtensionInstanceViewResponse;
    /**
     * The name of the extension.
     */
    readonly name: string;
    /**
     * The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
     */
    readonly protectedSettings?: any;
    /**
     * The provisioning state, which only appears in the response.
     */
    readonly provisioningState: string;
    /**
     * The name of the extension handler publisher.
     */
    readonly publisher?: string;
    /**
     * Json formatted public settings for the extension.
     */
    readonly settings?: any;
    /**
     * Resource type
     */
    readonly type: string;
    /**
     * Specifies the version of the script handler.
     */
    readonly typeHandlerVersion?: string;
}

export function getVirtualMachineScaleSetVMExtensionOutput(args: GetVirtualMachineScaleSetVMExtensionOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetVirtualMachineScaleSetVMExtensionResult> {
    return pulumi.output(args).apply(a => getVirtualMachineScaleSetVMExtension(a, opts))
}

export interface GetVirtualMachineScaleSetVMExtensionOutputArgs {
    /**
     * The expand expression to apply on the operation.
     */
    expand?: pulumi.Input<string>;
    /**
     * The instance ID of the virtual machine.
     */
    instanceId: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the virtual machine extension.
     */
    vmExtensionName: pulumi.Input<string>;
    /**
     * The name of the VM scale set.
     */
    vmScaleSetName: pulumi.Input<string>;
}
