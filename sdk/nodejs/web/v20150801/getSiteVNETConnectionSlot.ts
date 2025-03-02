// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * VNETInfo contract. This contract is public and is a stripped down version of VNETInfoInternal
 */
/** @deprecated Version 2015-08-01 will be removed in v2 of the provider. */
export function getSiteVNETConnectionSlot(args: GetSiteVNETConnectionSlotArgs, opts?: pulumi.InvokeOptions): Promise<GetSiteVNETConnectionSlotResult> {
    pulumi.log.warn("getSiteVNETConnectionSlot is deprecated: Version 2015-08-01 will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:web/v20150801:getSiteVNETConnectionSlot", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
        "slot": args.slot,
        "vnetName": args.vnetName,
    }, opts);
}

export interface GetSiteVNETConnectionSlotArgs {
    /**
     * The name of the web app
     */
    name: string;
    /**
     * The resource group name
     */
    resourceGroupName: string;
    /**
     * The name of the slot for this web app.
     */
    slot: string;
    /**
     * The name of the Virtual Network
     */
    vnetName: string;
}

/**
 * VNETInfo contract. This contract is public and is a stripped down version of VNETInfoInternal
 */
export interface GetSiteVNETConnectionSlotResult {
    /**
     * A certificate file (.cer) blob containing the public key of the private key used to authenticate a 
     *             Point-To-Site VPN connection.
     */
    readonly certBlob?: string;
    /**
     * The client certificate thumbprint
     */
    readonly certThumbprint?: string;
    /**
     * Dns servers to be used by this VNET. This should be a comma-separated list of IP addresses.
     */
    readonly dnsServers?: string;
    /**
     * Resource Id
     */
    readonly id?: string;
    /**
     * Kind of resource
     */
    readonly kind?: string;
    /**
     * Resource Location
     */
    readonly location: string;
    /**
     * Resource Name
     */
    readonly name?: string;
    /**
     * Flag to determine if a resync is required
     */
    readonly resyncRequired?: boolean;
    /**
     * The routes that this virtual network connection uses.
     */
    readonly routes?: outputs.web.v20150801.VnetRouteResponse[];
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type?: string;
    /**
     * The vnet resource id
     */
    readonly vnetResourceId?: string;
}

export function getSiteVNETConnectionSlotOutput(args: GetSiteVNETConnectionSlotOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSiteVNETConnectionSlotResult> {
    return pulumi.output(args).apply(a => getSiteVNETConnectionSlot(a, opts))
}

export interface GetSiteVNETConnectionSlotOutputArgs {
    /**
     * The name of the web app
     */
    name: pulumi.Input<string>;
    /**
     * The resource group name
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the slot for this web app.
     */
    slot: pulumi.Input<string>;
    /**
     * The name of the Virtual Network
     */
    vnetName: pulumi.Input<string>;
}
