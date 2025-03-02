// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Custom IP prefix resource.
 */
export function getCustomIPPrefix(args: GetCustomIPPrefixArgs, opts?: pulumi.InvokeOptions): Promise<GetCustomIPPrefixResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:network/v20201101:getCustomIPPrefix", {
        "customIpPrefixName": args.customIpPrefixName,
        "expand": args.expand,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetCustomIPPrefixArgs {
    /**
     * The name of the custom IP prefix.
     */
    customIpPrefixName: string;
    /**
     * Expands referenced resources.
     */
    expand?: string;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
}

/**
 * Custom IP prefix resource.
 */
export interface GetCustomIPPrefixResult {
    /**
     * The prefix range in CIDR notation. Should include the start address and the prefix length.
     */
    readonly cidr?: string;
    /**
     * The commissioned state of the Custom IP Prefix.
     */
    readonly commissionedState?: string;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * The extended location of the custom IP prefix.
     */
    readonly extendedLocation?: outputs.network.v20201101.ExtendedLocationResponse;
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
     * The provisioning state of the custom IP prefix resource.
     */
    readonly provisioningState: string;
    /**
     * The list of all referenced PublicIpPrefixes.
     */
    readonly publicIpPrefixes: outputs.network.v20201101.SubResourceResponse[];
    /**
     * The resource GUID property of the custom IP prefix resource.
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
    /**
     * A list of availability zones denoting the IP allocated for the resource needs to come from.
     */
    readonly zones?: string[];
}

export function getCustomIPPrefixOutput(args: GetCustomIPPrefixOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCustomIPPrefixResult> {
    return pulumi.output(args).apply(a => getCustomIPPrefix(a, opts))
}

export interface GetCustomIPPrefixOutputArgs {
    /**
     * The name of the custom IP prefix.
     */
    customIpPrefixName: pulumi.Input<string>;
    /**
     * Expands referenced resources.
     */
    expand?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
}
