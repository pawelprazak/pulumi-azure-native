// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Describes an outbound endpoint for a DNS resolver.
 */
export function getOutboundEndpoint(args: GetOutboundEndpointArgs, opts?: pulumi.InvokeOptions): Promise<GetOutboundEndpointResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:network/v20220701:getOutboundEndpoint", {
        "dnsResolverName": args.dnsResolverName,
        "outboundEndpointName": args.outboundEndpointName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetOutboundEndpointArgs {
    /**
     * The name of the DNS resolver.
     */
    dnsResolverName: string;
    /**
     * The name of the outbound endpoint for the DNS resolver.
     */
    outboundEndpointName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
}

/**
 * Describes an outbound endpoint for a DNS resolver.
 */
export interface GetOutboundEndpointResult {
    /**
     * ETag of the outbound endpoint.
     */
    readonly etag: string;
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
     * The current provisioning state of the outbound endpoint. This is a read-only property and any attempt to set this value will be ignored.
     */
    readonly provisioningState: string;
    /**
     * The resourceGuid property of the outbound endpoint resource.
     */
    readonly resourceGuid: string;
    /**
     * The reference to the subnet used for the outbound endpoint.
     */
    readonly subnet: outputs.network.v20220701.SubResourceResponse;
    /**
     * Metadata pertaining to creation and last modification of the resource.
     */
    readonly systemData: outputs.network.v20220701.SystemDataResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}

export function getOutboundEndpointOutput(args: GetOutboundEndpointOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetOutboundEndpointResult> {
    return pulumi.output(args).apply(a => getOutboundEndpoint(a, opts))
}

export interface GetOutboundEndpointOutputArgs {
    /**
     * The name of the DNS resolver.
     */
    dnsResolverName: pulumi.Input<string>;
    /**
     * The name of the outbound endpoint for the DNS resolver.
     */
    outboundEndpointName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
}
