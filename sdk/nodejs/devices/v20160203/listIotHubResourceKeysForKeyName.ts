// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * The properties of an IoT hub shared access policy.
 */
export function listIotHubResourceKeysForKeyName(args: ListIotHubResourceKeysForKeyNameArgs, opts?: pulumi.InvokeOptions): Promise<ListIotHubResourceKeysForKeyNameResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:devices/v20160203:listIotHubResourceKeysForKeyName", {
        "keyName": args.keyName,
        "resourceGroupName": args.resourceGroupName,
        "resourceName": args.resourceName,
    }, opts);
}

export interface ListIotHubResourceKeysForKeyNameArgs {
    /**
     * The name of the shared access policy.
     */
    keyName: string;
    /**
     * The name of the resource group that contains the IoT hub.
     */
    resourceGroupName: string;
    /**
     * The name of the IoT hub.
     */
    resourceName: string;
}

/**
 * The properties of an IoT hub shared access policy.
 */
export interface ListIotHubResourceKeysForKeyNameResult {
    /**
     * The name of the shared access policy.
     */
    readonly keyName: string;
    /**
     * The primary key.
     */
    readonly primaryKey?: string;
    /**
     * The permissions assigned to the shared access policy.
     */
    readonly rights: string;
    /**
     * The secondary key.
     */
    readonly secondaryKey?: string;
}

export function listIotHubResourceKeysForKeyNameOutput(args: ListIotHubResourceKeysForKeyNameOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListIotHubResourceKeysForKeyNameResult> {
    return pulumi.output(args).apply(a => listIotHubResourceKeysForKeyName(a, opts))
}

export interface ListIotHubResourceKeysForKeyNameOutputArgs {
    /**
     * The name of the shared access policy.
     */
    keyName: pulumi.Input<string>;
    /**
     * The name of the resource group that contains the IoT hub.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the IoT hub.
     */
    resourceName: pulumi.Input<string>;
}
