// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * List of data partitions.
 */
export function listEnergyServicePartitions(args: ListEnergyServicePartitionsArgs, opts?: pulumi.InvokeOptions): Promise<ListEnergyServicePartitionsResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:openenergyplatform/v20220404preview:listEnergyServicePartitions", {
        "resourceGroupName": args.resourceGroupName,
        "resourceName": args.resourceName,
    }, opts);
}

export interface ListEnergyServicePartitionsArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * The resource name.
     */
    resourceName: string;
}

/**
 * List of data partitions.
 */
export interface ListEnergyServicePartitionsResult {
    /**
     * List of data partitions along with their properties in a given OEP resource.
     */
    readonly dataPartitionInfo?: outputs.openenergyplatform.v20220404preview.DataPartitionPropertiesResponse[];
}

export function listEnergyServicePartitionsOutput(args: ListEnergyServicePartitionsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListEnergyServicePartitionsResult> {
    return pulumi.output(args).apply(a => listEnergyServicePartitions(a, opts))
}

export interface ListEnergyServicePartitionsOutputArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The resource name.
     */
    resourceName: pulumi.Input<string>;
}
