// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Cloud Endpoint object.
 */
/** @deprecated Version 2018-04-02 will be removed in v2 of the provider. */
export function getCloudEndpoint(args: GetCloudEndpointArgs, opts?: pulumi.InvokeOptions): Promise<GetCloudEndpointResult> {
    pulumi.log.warn("getCloudEndpoint is deprecated: Version 2018-04-02 will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:storagesync/v20180402:getCloudEndpoint", {
        "cloudEndpointName": args.cloudEndpointName,
        "resourceGroupName": args.resourceGroupName,
        "storageSyncServiceName": args.storageSyncServiceName,
        "syncGroupName": args.syncGroupName,
    }, opts);
}

export interface GetCloudEndpointArgs {
    /**
     * Name of Cloud Endpoint object.
     */
    cloudEndpointName: string;
    /**
     * The name of the resource group. The name is case insensitive.
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
 * Cloud Endpoint object.
 */
export interface GetCloudEndpointResult {
    /**
     * Backup Enabled
     */
    readonly backupEnabled: boolean;
    /**
     * Friendly Name
     */
    readonly friendlyName?: string;
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * Resource Last Operation Name
     */
    readonly lastOperationName?: string;
    /**
     * CloudEndpoint lastWorkflowId
     */
    readonly lastWorkflowId?: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Partnership Id
     */
    readonly partnershipId?: string;
    /**
     * CloudEndpoint Provisioning State
     */
    readonly provisioningState?: string;
    /**
     * Storage Account Resource Id
     */
    readonly storageAccountResourceId?: string;
    /**
     * Storage Account Share name
     */
    readonly storageAccountShareName?: string;
    /**
     * Storage Account Tenant Id
     */
    readonly storageAccountTenantId?: string;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}

export function getCloudEndpointOutput(args: GetCloudEndpointOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCloudEndpointResult> {
    return pulumi.output(args).apply(a => getCloudEndpoint(a, opts))
}

export interface GetCloudEndpointOutputArgs {
    /**
     * Name of Cloud Endpoint object.
     */
    cloudEndpointName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
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
