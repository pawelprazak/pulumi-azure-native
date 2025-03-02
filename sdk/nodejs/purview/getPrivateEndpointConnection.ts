// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * A private endpoint connection class.
 * API Version: 2020-12-01-preview.
 */
export function getPrivateEndpointConnection(args: GetPrivateEndpointConnectionArgs, opts?: pulumi.InvokeOptions): Promise<GetPrivateEndpointConnectionResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:purview:getPrivateEndpointConnection", {
        "accountName": args.accountName,
        "privateEndpointConnectionName": args.privateEndpointConnectionName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetPrivateEndpointConnectionArgs {
    /**
     * The name of the account.
     */
    accountName: string;
    /**
     * Name of the private endpoint connection.
     */
    privateEndpointConnectionName: string;
    /**
     * The resource group name.
     */
    resourceGroupName: string;
}

/**
 * A private endpoint connection class.
 */
export interface GetPrivateEndpointConnectionResult {
    /**
     * Gets or sets the identifier.
     */
    readonly id: string;
    /**
     * Gets or sets the name.
     */
    readonly name: string;
    /**
     * The private endpoint information.
     */
    readonly privateEndpoint?: outputs.purview.PrivateEndpointResponse;
    /**
     * The private link service connection state.
     */
    readonly privateLinkServiceConnectionState?: outputs.purview.PrivateLinkServiceConnectionStateResponse;
    /**
     * The provisioning state.
     */
    readonly provisioningState: string;
    /**
     * Gets or sets the type.
     */
    readonly type: string;
}

export function getPrivateEndpointConnectionOutput(args: GetPrivateEndpointConnectionOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetPrivateEndpointConnectionResult> {
    return pulumi.output(args).apply(a => getPrivateEndpointConnection(a, opts))
}

export interface GetPrivateEndpointConnectionOutputArgs {
    /**
     * The name of the account.
     */
    accountName: pulumi.Input<string>;
    /**
     * Name of the private endpoint connection.
     */
    privateEndpointConnectionName: pulumi.Input<string>;
    /**
     * The resource group name.
     */
    resourceGroupName: pulumi.Input<string>;
}
