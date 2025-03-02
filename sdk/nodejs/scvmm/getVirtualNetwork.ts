// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * The VirtualNetworks resource definition.
 * API Version: 2020-06-05-preview.
 */
export function getVirtualNetwork(args: GetVirtualNetworkArgs, opts?: pulumi.InvokeOptions): Promise<GetVirtualNetworkResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:scvmm:getVirtualNetwork", {
        "resourceGroupName": args.resourceGroupName,
        "virtualNetworkName": args.virtualNetworkName,
    }, opts);
}

export interface GetVirtualNetworkArgs {
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
    /**
     * Name of the VirtualNetwork.
     */
    virtualNetworkName: string;
}

/**
 * The VirtualNetworks resource definition.
 */
export interface GetVirtualNetworkResult {
    /**
     * The extended location.
     */
    readonly extendedLocation: outputs.scvmm.ExtendedLocationResponse;
    /**
     * Resource Id
     */
    readonly id: string;
    /**
     * Gets or sets the inventory Item ID for the resource.
     */
    readonly inventoryItemId?: string;
    /**
     * Gets or sets the location.
     */
    readonly location: string;
    /**
     * Resource Name
     */
    readonly name: string;
    /**
     * Name of the virtual network in vmmServer.
     */
    readonly networkName: string;
    /**
     * Gets or sets the provisioning state.
     */
    readonly provisioningState: string;
    /**
     * The system data.
     */
    readonly systemData: outputs.scvmm.SystemDataResponse;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource Type
     */
    readonly type: string;
    /**
     * Unique ID of the virtual network.
     */
    readonly uuid?: string;
    /**
     * ARM Id of the vmmServer resource in which this resource resides.
     */
    readonly vmmServerId?: string;
}

export function getVirtualNetworkOutput(args: GetVirtualNetworkOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetVirtualNetworkResult> {
    return pulumi.output(args).apply(a => getVirtualNetwork(a, opts))
}

export interface GetVirtualNetworkOutputArgs {
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Name of the VirtualNetwork.
     */
    virtualNetworkName: pulumi.Input<string>;
}
