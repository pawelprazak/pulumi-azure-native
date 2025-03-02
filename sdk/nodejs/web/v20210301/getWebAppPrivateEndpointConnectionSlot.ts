// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Remote Private Endpoint Connection ARM resource.
 */
export function getWebAppPrivateEndpointConnectionSlot(args: GetWebAppPrivateEndpointConnectionSlotArgs, opts?: pulumi.InvokeOptions): Promise<GetWebAppPrivateEndpointConnectionSlotResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:web/v20210301:getWebAppPrivateEndpointConnectionSlot", {
        "name": args.name,
        "privateEndpointConnectionName": args.privateEndpointConnectionName,
        "resourceGroupName": args.resourceGroupName,
        "slot": args.slot,
    }, opts);
}

export interface GetWebAppPrivateEndpointConnectionSlotArgs {
    /**
     * Name of the site.
     */
    name: string;
    /**
     * Name of the private endpoint connection.
     */
    privateEndpointConnectionName: string;
    /**
     * Name of the resource group to which the resource belongs.
     */
    resourceGroupName: string;
    /**
     * Name of the site deployment slot.
     */
    slot: string;
}

/**
 * Remote Private Endpoint Connection ARM resource.
 */
export interface GetWebAppPrivateEndpointConnectionSlotResult {
    /**
     * Resource Id.
     */
    readonly id: string;
    /**
     * Private IPAddresses mapped to the remote private endpoint
     */
    readonly ipAddresses?: string[];
    /**
     * Kind of resource.
     */
    readonly kind?: string;
    /**
     * Resource Name.
     */
    readonly name: string;
    /**
     * PrivateEndpoint of a remote private endpoint connection
     */
    readonly privateEndpoint?: outputs.web.v20210301.ArmIdWrapperResponse;
    /**
     * The state of a private link connection
     */
    readonly privateLinkServiceConnectionState?: outputs.web.v20210301.PrivateLinkConnectionStateResponse;
    readonly provisioningState: string;
    /**
     * Resource type.
     */
    readonly type: string;
}

export function getWebAppPrivateEndpointConnectionSlotOutput(args: GetWebAppPrivateEndpointConnectionSlotOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetWebAppPrivateEndpointConnectionSlotResult> {
    return pulumi.output(args).apply(a => getWebAppPrivateEndpointConnectionSlot(a, opts))
}

export interface GetWebAppPrivateEndpointConnectionSlotOutputArgs {
    /**
     * Name of the site.
     */
    name: pulumi.Input<string>;
    /**
     * Name of the private endpoint connection.
     */
    privateEndpointConnectionName: pulumi.Input<string>;
    /**
     * Name of the resource group to which the resource belongs.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Name of the site deployment slot.
     */
    slot: pulumi.Input<string>;
}
