// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * String dictionary resource
 */
export function listSiteConnectionStrings(args: ListSiteConnectionStringsArgs, opts?: pulumi.InvokeOptions): Promise<ListSiteConnectionStringsResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:web/v20150801:listSiteConnectionStrings", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListSiteConnectionStringsArgs {
    /**
     * Name of web app
     */
    name: string;
    /**
     * Name of resource group
     */
    resourceGroupName: string;
}

/**
 * String dictionary resource
 */
export interface ListSiteConnectionStringsResult {
    /**
     * Resource Id
     */
    readonly id?: string;
    /**
     * Kind of resource
     */
    readonly kind?: string;
    /**
     * Resource Location
     */
    readonly location: string;
    /**
     * Resource Name
     */
    readonly name?: string;
    /**
     * Connection strings
     */
    readonly properties: {[key: string]: outputs.web.v20150801.ConnStringValueTypePairResponse};
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type?: string;
}

export function listSiteConnectionStringsOutput(args: ListSiteConnectionStringsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListSiteConnectionStringsResult> {
    return pulumi.output(args).apply(a => listSiteConnectionStrings(a, opts))
}

export interface ListSiteConnectionStringsOutputArgs {
    /**
     * Name of web app
     */
    name: pulumi.Input<string>;
    /**
     * Name of resource group
     */
    resourceGroupName: pulumi.Input<string>;
}
