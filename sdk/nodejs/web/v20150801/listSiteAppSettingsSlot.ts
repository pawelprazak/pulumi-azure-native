// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * String dictionary resource
 */
export function listSiteAppSettingsSlot(args: ListSiteAppSettingsSlotArgs, opts?: pulumi.InvokeOptions): Promise<ListSiteAppSettingsSlotResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:web/v20150801:listSiteAppSettingsSlot", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
        "slot": args.slot,
    }, opts);
}

export interface ListSiteAppSettingsSlotArgs {
    /**
     * Name of web app
     */
    name: string;
    /**
     * Name of resource group
     */
    resourceGroupName: string;
    /**
     * Name of web app slot. If not specified then will default to production slot.
     */
    slot: string;
}

/**
 * String dictionary resource
 */
export interface ListSiteAppSettingsSlotResult {
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
     * Settings
     */
    readonly properties: {[key: string]: string};
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type?: string;
}

export function listSiteAppSettingsSlotOutput(args: ListSiteAppSettingsSlotOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListSiteAppSettingsSlotResult> {
    return pulumi.output(args).apply(a => listSiteAppSettingsSlot(a, opts))
}

export interface ListSiteAppSettingsSlotOutputArgs {
    /**
     * Name of web app
     */
    name: pulumi.Input<string>;
    /**
     * Name of resource group
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Name of web app slot. If not specified then will default to production slot.
     */
    slot: pulumi.Input<string>;
}
