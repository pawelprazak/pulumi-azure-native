// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Content type contract details.
 * API Version: 2020-12-01.
 */
export function getContentType(args: GetContentTypeArgs, opts?: pulumi.InvokeOptions): Promise<GetContentTypeResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:apimanagement:getContentType", {
        "contentTypeId": args.contentTypeId,
        "resourceGroupName": args.resourceGroupName,
        "serviceName": args.serviceName,
    }, opts);
}

export interface GetContentTypeArgs {
    /**
     * Content type identifier.
     */
    contentTypeId: string;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
    /**
     * The name of the API Management service.
     */
    serviceName: string;
}

/**
 * Content type contract details.
 */
export interface GetContentTypeResult {
    /**
     * Content type description.
     */
    readonly description?: string;
    /**
     * Resource ID.
     */
    readonly id: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Content type schema.
     */
    readonly schema?: any;
    /**
     * Resource type for API Management resource.
     */
    readonly type: string;
    /**
     * Content type version.
     */
    readonly version?: string;
}

export function getContentTypeOutput(args: GetContentTypeOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetContentTypeResult> {
    return pulumi.output(args).apply(a => getContentType(a, opts))
}

export interface GetContentTypeOutputArgs {
    /**
     * Content type identifier.
     */
    contentTypeId: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the API Management service.
     */
    serviceName: pulumi.Input<string>;
}
