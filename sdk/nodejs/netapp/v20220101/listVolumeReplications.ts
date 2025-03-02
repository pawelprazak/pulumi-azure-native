// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * List Replications
 */
export function listVolumeReplications(args: ListVolumeReplicationsArgs, opts?: pulumi.InvokeOptions): Promise<ListVolumeReplicationsResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:netapp/v20220101:listVolumeReplications", {
        "accountName": args.accountName,
        "poolName": args.poolName,
        "resourceGroupName": args.resourceGroupName,
        "volumeName": args.volumeName,
    }, opts);
}

export interface ListVolumeReplicationsArgs {
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
     * The name of the volume
     */
    volumeName: string;
}

/**
 * List Replications
 */
export interface ListVolumeReplicationsResult {
    /**
     * A list of replications
     */
    readonly value?: outputs.netapp.v20220101.ReplicationResponse[];
}

export function listVolumeReplicationsOutput(args: ListVolumeReplicationsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListVolumeReplicationsResult> {
    return pulumi.output(args).apply(a => listVolumeReplications(a, opts))
}

export interface ListVolumeReplicationsOutputArgs {
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
     * The name of the volume
     */
    volumeName: pulumi.Input<string>;
}
