// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Peering in an ExpressRoute Cross Connection resource.
 */
export function getExpressRouteCrossConnectionPeering(args: GetExpressRouteCrossConnectionPeeringArgs, opts?: pulumi.InvokeOptions): Promise<GetExpressRouteCrossConnectionPeeringResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:network/v20181201:getExpressRouteCrossConnectionPeering", {
        "crossConnectionName": args.crossConnectionName,
        "peeringName": args.peeringName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetExpressRouteCrossConnectionPeeringArgs {
    /**
     * The name of the ExpressRouteCrossConnection.
     */
    crossConnectionName: string;
    /**
     * The name of the peering.
     */
    peeringName: string;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
}

/**
 * Peering in an ExpressRoute Cross Connection resource.
 */
export interface GetExpressRouteCrossConnectionPeeringResult {
    /**
     * The Azure ASN.
     */
    readonly azureASN: number;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * The GatewayManager Etag.
     */
    readonly gatewayManagerEtag?: string;
    /**
     * Resource ID.
     */
    readonly id?: string;
    /**
     * The IPv6 peering configuration.
     */
    readonly ipv6PeeringConfig?: outputs.network.v20181201.Ipv6ExpressRouteCircuitPeeringConfigResponse;
    /**
     * Gets whether the provider or the customer last modified the peering.
     */
    readonly lastModifiedBy?: string;
    /**
     * The Microsoft peering configuration.
     */
    readonly microsoftPeeringConfig?: outputs.network.v20181201.ExpressRouteCircuitPeeringConfigResponse;
    /**
     * Gets name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    readonly name?: string;
    /**
     * The peer ASN.
     */
    readonly peerASN?: number;
    /**
     * The peering type.
     */
    readonly peeringType?: string;
    /**
     * The primary port.
     */
    readonly primaryAzurePort: string;
    /**
     * The primary address prefix.
     */
    readonly primaryPeerAddressPrefix?: string;
    /**
     * Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
     */
    readonly provisioningState: string;
    /**
     * The secondary port.
     */
    readonly secondaryAzurePort: string;
    /**
     * The secondary address prefix.
     */
    readonly secondaryPeerAddressPrefix?: string;
    /**
     * The shared key.
     */
    readonly sharedKey?: string;
    /**
     * The peering state.
     */
    readonly state?: string;
    /**
     * The VLAN ID.
     */
    readonly vlanId?: number;
}

export function getExpressRouteCrossConnectionPeeringOutput(args: GetExpressRouteCrossConnectionPeeringOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetExpressRouteCrossConnectionPeeringResult> {
    return pulumi.output(args).apply(a => getExpressRouteCrossConnectionPeering(a, opts))
}

export interface GetExpressRouteCrossConnectionPeeringOutputArgs {
    /**
     * The name of the ExpressRouteCrossConnection.
     */
    crossConnectionName: pulumi.Input<string>;
    /**
     * The name of the peering.
     */
    peeringName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
}
