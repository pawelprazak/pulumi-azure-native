// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * A class represents the access keys of the resource.
 */
export function listSignalRKeys(args: ListSignalRKeysArgs, opts?: pulumi.InvokeOptions): Promise<ListSignalRKeysResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:signalrservice/v20220201:listSignalRKeys", {
        "resourceGroupName": args.resourceGroupName,
        "resourceName": args.resourceName,
    }, opts);
}

export interface ListSignalRKeysArgs {
    /**
     * The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    resourceGroupName: string;
    /**
     * The name of the resource.
     */
    resourceName: string;
}

/**
 * A class represents the access keys of the resource.
 */
export interface ListSignalRKeysResult {
    /**
     * Connection string constructed via the primaryKey
     */
    readonly primaryConnectionString?: string;
    /**
     * The primary access key.
     */
    readonly primaryKey?: string;
    /**
     * Connection string constructed via the secondaryKey
     */
    readonly secondaryConnectionString?: string;
    /**
     * The secondary access key.
     */
    readonly secondaryKey?: string;
}

export function listSignalRKeysOutput(args: ListSignalRKeysOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListSignalRKeysResult> {
    return pulumi.output(args).apply(a => listSignalRKeys(a, opts))
}

export interface ListSignalRKeysOutputArgs {
    /**
     * The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the resource.
     */
    resourceName: pulumi.Input<string>;
}
