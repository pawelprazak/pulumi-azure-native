// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Sync Group object.
 */
/** @deprecated Version 2017-06-05-preview will be removed in v2 of the provider. */
export function getSyncGroup(args: GetSyncGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetSyncGroupResult> {
    pulumi.log.warn("getSyncGroup is deprecated: Version 2017-06-05-preview will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:storagesync/v20170605preview:getSyncGroup", {
        "resourceGroupName": args.resourceGroupName,
        "storageSyncServiceName": args.storageSyncServiceName,
        "syncGroupName": args.syncGroupName,
    }, opts);
}

export interface GetSyncGroupArgs {
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * Name of Storage Sync Service resource.
     */
    storageSyncServiceName: string;
    /**
     * Name of Sync Group resource.
     */
    syncGroupName: string;
}

/**
 * Sync Group object.
 */
export interface GetSyncGroupResult {
    /**
     * The id of the resource.
     */
    readonly id: string;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * Sync group status
     */
    readonly syncGroupStatus: string;
    /**
     * The type of the resource
     */
    readonly type: string;
    /**
     * Unique Id
     */
    readonly uniqueId?: string;
}

export function getSyncGroupOutput(args: GetSyncGroupOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSyncGroupResult> {
    return pulumi.output(args).apply(a => getSyncGroup(a, opts))
}

export interface GetSyncGroupOutputArgs {
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Name of Storage Sync Service resource.
     */
    storageSyncServiceName: pulumi.Input<string>;
    /**
     * Name of Sync Group resource.
     */
    syncGroupName: pulumi.Input<string>;
}
