// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * A managed cluster snapshot resource.
 */
export function getManagedClusterSnapshot(args: GetManagedClusterSnapshotArgs, opts?: pulumi.InvokeOptions): Promise<GetManagedClusterSnapshotResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:containerservice/v20220202preview:getManagedClusterSnapshot", {
        "resourceGroupName": args.resourceGroupName,
        "resourceName": args.resourceName,
    }, opts);
}

export interface GetManagedClusterSnapshotArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * The name of the managed cluster resource.
     */
    resourceName: string;
}

/**
 * A managed cluster snapshot resource.
 */
export interface GetManagedClusterSnapshotResult {
    /**
     * CreationData to be used to specify the source resource ID to create this snapshot.
     */
    readonly creationData?: outputs.containerservice.v20220202preview.CreationDataResponse;
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * What the properties will be showed when getting managed cluster snapshot. Those properties are read-only.
     */
    readonly managedClusterPropertiesReadOnly: outputs.containerservice.v20220202preview.ManagedClusterPropertiesForSnapshotResponse;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The type of a snapshot. The default is NodePool.
     */
    readonly snapshotType?: string;
    /**
     * Azure Resource Manager metadata containing createdBy and modifiedBy information.
     */
    readonly systemData: outputs.containerservice.v20220202preview.SystemDataResponse;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}

export function getManagedClusterSnapshotOutput(args: GetManagedClusterSnapshotOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetManagedClusterSnapshotResult> {
    return pulumi.output(args).apply(a => getManagedClusterSnapshot(a, opts))
}

export interface GetManagedClusterSnapshotOutputArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the managed cluster resource.
     */
    resourceName: pulumi.Input<string>;
}
