// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * An HCX Enterprise Site resource
 * API Version: 2020-03-20.
 */
export function getHcxEnterpriseSite(args: GetHcxEnterpriseSiteArgs, opts?: pulumi.InvokeOptions): Promise<GetHcxEnterpriseSiteResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:avs:getHcxEnterpriseSite", {
        "hcxEnterpriseSiteName": args.hcxEnterpriseSiteName,
        "privateCloudName": args.privateCloudName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetHcxEnterpriseSiteArgs {
    /**
     * Name of the HCX Enterprise Site in the private cloud
     */
    hcxEnterpriseSiteName: string;
    /**
     * Name of the private cloud
     */
    privateCloudName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
}

/**
 * An HCX Enterprise Site resource
 */
export interface GetHcxEnterpriseSiteResult {
    /**
     * The activation key
     */
    readonly activationKey: string;
    /**
     * Resource ID.
     */
    readonly id: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The status of the HCX Enterprise Site
     */
    readonly status: string;
    /**
     * Resource type.
     */
    readonly type: string;
}

export function getHcxEnterpriseSiteOutput(args: GetHcxEnterpriseSiteOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetHcxEnterpriseSiteResult> {
    return pulumi.output(args).apply(a => getHcxEnterpriseSite(a, opts))
}

export interface GetHcxEnterpriseSiteOutputArgs {
    /**
     * Name of the HCX Enterprise Site in the private cloud
     */
    hcxEnterpriseSiteName: pulumi.Input<string>;
    /**
     * Name of the private cloud
     */
    privateCloudName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
}
