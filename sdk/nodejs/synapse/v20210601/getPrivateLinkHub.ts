// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * A privateLinkHub
 */
export function getPrivateLinkHub(args: GetPrivateLinkHubArgs, opts?: pulumi.InvokeOptions): Promise<GetPrivateLinkHubResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:synapse/v20210601:getPrivateLinkHub", {
        "privateLinkHubName": args.privateLinkHubName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetPrivateLinkHubArgs {
    /**
     * Name of the privateLinkHub
     */
    privateLinkHubName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
}

/**
 * A privateLinkHub
 */
export interface GetPrivateLinkHubResult {
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * List of private endpoint connections
     */
    readonly privateEndpointConnections: outputs.synapse.v20210601.PrivateEndpointConnectionForPrivateLinkHubBasicResponse[];
    /**
     * PrivateLinkHub provisioning state
     */
    readonly provisioningState?: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}

export function getPrivateLinkHubOutput(args: GetPrivateLinkHubOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetPrivateLinkHubResult> {
    return pulumi.output(args).apply(a => getPrivateLinkHub(a, opts))
}

export interface GetPrivateLinkHubOutputArgs {
    /**
     * Name of the privateLinkHub
     */
    privateLinkHubName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
}
