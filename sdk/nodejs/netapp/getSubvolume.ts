// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Subvolume Information properties
 * API Version: 2021-10-01.
 */
export function getSubvolume(args: GetSubvolumeArgs, opts?: pulumi.InvokeOptions): Promise<GetSubvolumeResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:netapp:getSubvolume", {
        "accountName": args.accountName,
        "poolName": args.poolName,
        "resourceGroupName": args.resourceGroupName,
        "subvolumeName": args.subvolumeName,
        "volumeName": args.volumeName,
    }, opts);
}

export interface GetSubvolumeArgs {
    /**
     * The name of the NetApp account
     */
    accountName: string;
    /**
     * The name of the capacity pool
     */
    poolName: string;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
    /**
     * The name of the subvolume.
     */
    subvolumeName: string;
    /**
     * The name of the volume
     */
    volumeName: string;
}

/**
 * Subvolume Information properties
 */
export interface GetSubvolumeResult {
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * parent path to the subvolume
     */
    readonly parentPath?: string;
    /**
     * Path to the subvolume
     */
    readonly path?: string;
    /**
     * Azure lifecycle management
     */
    readonly provisioningState: string;
    /**
     * The system meta data relating to this resource.
     */
    readonly systemData: outputs.netapp.SystemDataResponse;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}

export function getSubvolumeOutput(args: GetSubvolumeOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSubvolumeResult> {
    return pulumi.output(args).apply(a => getSubvolume(a, opts))
}

export interface GetSubvolumeOutputArgs {
    /**
     * The name of the NetApp account
     */
    accountName: pulumi.Input<string>;
    /**
     * The name of the capacity pool
     */
    poolName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the subvolume.
     */
    subvolumeName: pulumi.Input<string>;
    /**
     * The name of the volume
     */
    volumeName: pulumi.Input<string>;
}
