// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * CDN endpoint is the entity within a CDN profile containing configuration information regarding caching behaviors and origins. The CDN endpoint is exposed using the URL format <endpointname>.azureedge.net by default, but custom domains can also be created.
 */
/** @deprecated Version 2015-06-01 will be removed in v2 of the provider. */
export function getEndpoint(args: GetEndpointArgs, opts?: pulumi.InvokeOptions): Promise<GetEndpointResult> {
    pulumi.log.warn("getEndpoint is deprecated: Version 2015-06-01 will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:cdn/v20150601:getEndpoint", {
        "endpointName": args.endpointName,
        "profileName": args.profileName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetEndpointArgs {
    /**
     * Name of the endpoint within the CDN profile.
     */
    endpointName: string;
    /**
     * Name of the CDN profile within the resource group.
     */
    profileName: string;
    /**
     * Name of the resource group within the Azure subscription.
     */
    resourceGroupName: string;
}

/**
 * CDN endpoint is the entity within a CDN profile containing configuration information regarding caching behaviors and origins. The CDN endpoint is exposed using the URL format <endpointname>.azureedge.net by default, but custom domains can also be created.
 */
export interface GetEndpointResult {
    /**
     * List of content types on which compression will be applied. The value for the elements should be a valid MIME type.
     */
    readonly contentTypesToCompress?: string[];
    /**
     * The host name of the endpoint {endpointName}.{DNSZone}
     */
    readonly hostName: string;
    /**
     * Resource ID
     */
    readonly id: string;
    /**
     * Indicates whether the compression is enabled. Default value is false. If compression is enabled, the content transferred from cdn endpoint to end user will be compressed. The requested content must be larger than 1 byte and smaller than 1 MB.
     */
    readonly isCompressionEnabled?: boolean;
    /**
     * Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
     */
    readonly isHttpAllowed?: boolean;
    /**
     * Indicates whether https traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
     */
    readonly isHttpsAllowed?: boolean;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * The host header the CDN provider will send along with content requests to origins. The default value is the host name of the origin.
     */
    readonly originHostHeader?: string;
    /**
     * The path used for origin requests.
     */
    readonly originPath?: string;
    /**
     * The set of origins for the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options.
     */
    readonly origins?: outputs.cdn.v20150601.DeepCreatedOriginResponse[];
    /**
     * Provisioning status of the endpoint.
     */
    readonly provisioningState: string;
    /**
     * Defines the query string caching behavior.
     */
    readonly queryStringCachingBehavior?: string;
    /**
     * Resource status of the endpoint.
     */
    readonly resourceState: string;
    /**
     * Resource tags
     */
    readonly tags: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type: string;
}

export function getEndpointOutput(args: GetEndpointOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetEndpointResult> {
    return pulumi.output(args).apply(a => getEndpoint(a, opts))
}

export interface GetEndpointOutputArgs {
    /**
     * Name of the endpoint within the CDN profile.
     */
    endpointName: pulumi.Input<string>;
    /**
     * Name of the CDN profile within the resource group.
     */
    profileName: pulumi.Input<string>;
    /**
     * Name of the resource group within the Azure subscription.
     */
    resourceGroupName: pulumi.Input<string>;
}
