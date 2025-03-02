// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Virtual Network Tap resource.
 */
export function getVirtualNetworkTap(args: GetVirtualNetworkTapArgs, opts?: pulumi.InvokeOptions): Promise<GetVirtualNetworkTapResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:network/v20201101:getVirtualNetworkTap", {
        "resourceGroupName": args.resourceGroupName,
        "tapName": args.tapName,
    }, opts);
}

export interface GetVirtualNetworkTapArgs {
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
    /**
     * The name of virtual network tap.
     */
    tapName: string;
}

/**
 * Virtual Network Tap resource.
 */
export interface GetVirtualNetworkTapResult {
    /**
     * The reference to the private IP address on the internal Load Balancer that will receive the tap.
     */
    readonly destinationLoadBalancerFrontEndIPConfiguration?: outputs.network.v20201101.FrontendIPConfigurationResponse;
    /**
     * The reference to the private IP Address of the collector nic that will receive the tap.
     */
    readonly destinationNetworkInterfaceIPConfiguration?: outputs.network.v20201101.NetworkInterfaceIPConfigurationResponse;
    /**
     * The VXLAN destination port that will receive the tapped traffic.
     */
    readonly destinationPort?: number;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * Resource ID.
     */
    readonly id?: string;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Specifies the list of resource IDs for the network interface IP configuration that needs to be tapped.
     */
    readonly networkInterfaceTapConfigurations: outputs.network.v20201101.NetworkInterfaceTapConfigurationResponse[];
    /**
     * The provisioning state of the virtual network tap resource.
     */
    readonly provisioningState: string;
    /**
     * The resource GUID property of the virtual network tap resource.
     */
    readonly resourceGuid: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
}

export function getVirtualNetworkTapOutput(args: GetVirtualNetworkTapOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetVirtualNetworkTapResult> {
    return pulumi.output(args).apply(a => getVirtualNetworkTap(a, opts))
}

export interface GetVirtualNetworkTapOutputArgs {
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of virtual network tap.
     */
    tapName: pulumi.Input<string>;
}
