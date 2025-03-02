// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Base class for backup items.
 */
export function getProtectedItem(args: GetProtectedItemArgs, opts?: pulumi.InvokeOptions): Promise<GetProtectedItemResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:recoveryservices/v20201001:getProtectedItem", {
        "containerName": args.containerName,
        "fabricName": args.fabricName,
        "filter": args.filter,
        "protectedItemName": args.protectedItemName,
        "resourceGroupName": args.resourceGroupName,
        "vaultName": args.vaultName,
    }, opts);
}

export interface GetProtectedItemArgs {
    /**
     * Container name associated with the backed up item.
     */
    containerName: string;
    /**
     * Fabric name associated with the backed up item.
     */
    fabricName: string;
    /**
     * OData filter options.
     */
    filter?: string;
    /**
     * Backed up item name whose details are to be fetched.
     */
    protectedItemName: string;
    /**
     * The name of the resource group where the recovery services vault is present.
     */
    resourceGroupName: string;
    /**
     * The name of the recovery services vault.
     */
    vaultName: string;
}

/**
 * Base class for backup items.
 */
export interface GetProtectedItemResult {
    /**
     * Optional ETag.
     */
    readonly eTag?: string;
    /**
     * Resource Id represents the complete path to the resource.
     */
    readonly id: string;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name associated with the resource.
     */
    readonly name: string;
    /**
     * ProtectedItemResource properties
     */
    readonly properties: outputs.recoveryservices.v20201001.AzureFileshareProtectedItemResponse | outputs.recoveryservices.v20201001.AzureIaaSClassicComputeVMProtectedItemResponse | outputs.recoveryservices.v20201001.AzureIaaSComputeVMProtectedItemResponse | outputs.recoveryservices.v20201001.AzureIaaSVMProtectedItemResponse | outputs.recoveryservices.v20201001.AzureSqlProtectedItemResponse | outputs.recoveryservices.v20201001.AzureVmWorkloadProtectedItemResponse | outputs.recoveryservices.v20201001.AzureVmWorkloadSAPAseDatabaseProtectedItemResponse | outputs.recoveryservices.v20201001.AzureVmWorkloadSAPHanaDatabaseProtectedItemResponse | outputs.recoveryservices.v20201001.AzureVmWorkloadSQLDatabaseProtectedItemResponse | outputs.recoveryservices.v20201001.DPMProtectedItemResponse | outputs.recoveryservices.v20201001.GenericProtectedItemResponse | outputs.recoveryservices.v20201001.MabFileFolderProtectedItemResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type represents the complete path of the form Namespace/ResourceType/ResourceType/...
     */
    readonly type: string;
}

export function getProtectedItemOutput(args: GetProtectedItemOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetProtectedItemResult> {
    return pulumi.output(args).apply(a => getProtectedItem(a, opts))
}

export interface GetProtectedItemOutputArgs {
    /**
     * Container name associated with the backed up item.
     */
    containerName: pulumi.Input<string>;
    /**
     * Fabric name associated with the backed up item.
     */
    fabricName: pulumi.Input<string>;
    /**
     * OData filter options.
     */
    filter?: pulumi.Input<string>;
    /**
     * Backed up item name whose details are to be fetched.
     */
    protectedItemName: pulumi.Input<string>;
    /**
     * The name of the resource group where the recovery services vault is present.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the recovery services vault.
     */
    vaultName: pulumi.Input<string>;
}
