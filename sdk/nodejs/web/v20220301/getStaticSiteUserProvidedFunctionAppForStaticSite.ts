// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Static Site User Provided Function App ARM resource.
 */
export function getStaticSiteUserProvidedFunctionAppForStaticSite(args: GetStaticSiteUserProvidedFunctionAppForStaticSiteArgs, opts?: pulumi.InvokeOptions): Promise<GetStaticSiteUserProvidedFunctionAppForStaticSiteResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:web/v20220301:getStaticSiteUserProvidedFunctionAppForStaticSite", {
        "functionAppName": args.functionAppName,
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetStaticSiteUserProvidedFunctionAppForStaticSiteArgs {
    /**
     * Name of the function app registered with the static site.
     */
    functionAppName: string;
    /**
     * Name of the static site.
     */
    name: string;
    /**
     * Name of the resource group to which the resource belongs.
     */
    resourceGroupName: string;
}

/**
 * Static Site User Provided Function App ARM resource.
 */
export interface GetStaticSiteUserProvidedFunctionAppForStaticSiteResult {
    /**
     * The date and time on which the function app was registered with the static site.
     */
    readonly createdOn: string;
    /**
     * The region of the function app registered with the static site
     */
    readonly functionAppRegion?: string;
    /**
     * The resource id of the function app registered with the static site
     */
    readonly functionAppResourceId?: string;
    /**
     * Resource Id.
     */
    readonly id: string;
    /**
     * Kind of resource.
     */
    readonly kind?: string;
    /**
     * Resource Name.
     */
    readonly name: string;
    /**
     * Resource type.
     */
    readonly type: string;
}

export function getStaticSiteUserProvidedFunctionAppForStaticSiteOutput(args: GetStaticSiteUserProvidedFunctionAppForStaticSiteOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetStaticSiteUserProvidedFunctionAppForStaticSiteResult> {
    return pulumi.output(args).apply(a => getStaticSiteUserProvidedFunctionAppForStaticSite(a, opts))
}

export interface GetStaticSiteUserProvidedFunctionAppForStaticSiteOutputArgs {
    /**
     * Name of the function app registered with the static site.
     */
    functionAppName: pulumi.Input<string>;
    /**
     * Name of the static site.
     */
    name: pulumi.Input<string>;
    /**
     * Name of the resource group to which the resource belongs.
     */
    resourceGroupName: pulumi.Input<string>;
}
