// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * A private endpoint connection
 */
export function getPrivateEndpointConnection(args: GetPrivateEndpointConnectionArgs, opts?: pulumi.InvokeOptions): Promise<GetPrivateEndpointConnectionResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:insights/v20191017preview:getPrivateEndpointConnection", {
        "privateEndpointConnectionName": args.privateEndpointConnectionName,
        "resourceGroupName": args.resourceGroupName,
        "scopeName": args.scopeName,
    }, opts);
}

export interface GetPrivateEndpointConnectionArgs {
    /**
     * The name of the private endpoint connection.
     */
    privateEndpointConnectionName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * The name of the Azure Monitor PrivateLinkScope resource.
     */
    scopeName: string;
}

/**
 * A private endpoint connection
 */
export interface GetPrivateEndpointConnectionResult {
    /**
     * Azure resource Id
     */
    readonly id: string;
    /**
     * Azure resource name
     */
    readonly name: string;
    /**
     * Private endpoint which the connection belongs to.
     */
    readonly privateEndpoint?: outputs.insights.v20191017preview.PrivateEndpointPropertyResponse;
    /**
     * Connection state of the private endpoint connection.
     */
    readonly privateLinkServiceConnectionState?: outputs.insights.v20191017preview.PrivateLinkServiceConnectionStatePropertyResponse;
    /**
     * State of the private endpoint connection.
     */
    readonly provisioningState: string;
    /**
     * Azure resource type
     */
    readonly type: string;
}

export function getPrivateEndpointConnectionOutput(args: GetPrivateEndpointConnectionOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetPrivateEndpointConnectionResult> {
    return pulumi.output(args).apply(a => getPrivateEndpointConnection(a, opts))
}

export interface GetPrivateEndpointConnectionOutputArgs {
    /**
     * The name of the private endpoint connection.
     */
    privateEndpointConnectionName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the Azure Monitor PrivateLinkScope resource.
     */
    scopeName: pulumi.Input<string>;
}
