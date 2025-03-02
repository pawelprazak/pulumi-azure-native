// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Define the resourcePool.
 */
export function getResourcePool(args: GetResourcePoolArgs, opts?: pulumi.InvokeOptions): Promise<GetResourcePoolResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:connectedvmwarevsphere/v20220110preview:getResourcePool", {
        "resourceGroupName": args.resourceGroupName,
        "resourcePoolName": args.resourcePoolName,
    }, opts);
}

export interface GetResourcePoolArgs {
    /**
     * The Resource Group Name.
     */
    resourceGroupName: string;
    /**
     * Name of the resourcePool.
     */
    resourcePoolName: string;
}

/**
 * Define the resourcePool.
 */
export interface GetResourcePoolResult {
    /**
     * Gets or sets CPULimitMHz which specifies a CPU usage limit in MHz.
     * Utilization will not exceed this limit even if there are available resources.
     */
    readonly cpuLimitMHz: number;
    /**
     * Gets or sets CPUReservationMHz which specifies the CPU size in MHz that is guaranteed
     * to be available.
     */
    readonly cpuReservationMHz: number;
    /**
     * Gets or sets CPUSharesLevel which specifies the CPU allocation level for this pool.
     * This property is used in relative allocation between resource consumers.
     */
    readonly cpuSharesLevel: string;
    /**
     * Gets the name of the corresponding resource in Kubernetes.
     */
    readonly customResourceName: string;
    /**
     * Gets or sets the extended location.
     */
    readonly extendedLocation?: outputs.connectedvmwarevsphere.v20220110preview.ExtendedLocationResponse;
    /**
     * Gets or sets the Id.
     */
    readonly id: string;
    /**
     * Gets or sets the inventory Item ID for the resource pool.
     */
    readonly inventoryItemId?: string;
    /**
     * Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value.
     */
    readonly kind?: string;
    /**
     * Gets or sets the location.
     */
    readonly location: string;
    /**
     * Gets or sets MemLimitMB specifies a memory usage limit in megabytes.
     * Utilization will not exceed the specified limit even if there are available resources.
     */
    readonly memLimitMB: number;
    /**
     * Gets or sets MemReservationMB which specifies the guaranteed available memory in
     * megabytes.
     */
    readonly memReservationMB: number;
    /**
     * Gets or sets CPUSharesLevel which specifies the memory allocation level for this pool.
     * This property is used in relative allocation between resource consumers.
     */
    readonly memSharesLevel: string;
    /**
     * Gets or sets the vCenter Managed Object name for the resource pool.
     */
    readonly moName: string;
    /**
     * Gets or sets the vCenter MoRef (Managed Object Reference) ID for the resource pool.
     */
    readonly moRefId?: string;
    /**
     * Gets or sets the name.
     */
    readonly name: string;
    /**
     * Gets or sets the provisioning state.
     */
    readonly provisioningState: string;
    /**
     * The resource status information.
     */
    readonly statuses: outputs.connectedvmwarevsphere.v20220110preview.ResourceStatusResponse[];
    /**
     * The system data.
     */
    readonly systemData: outputs.connectedvmwarevsphere.v20220110preview.SystemDataResponse;
    /**
     * Gets or sets the Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Gets or sets the type of the resource.
     */
    readonly type: string;
    /**
     * Gets or sets a unique identifier for this resource.
     */
    readonly uuid: string;
    /**
     * Gets or sets the ARM Id of the vCenter resource in which this resource pool resides.
     */
    readonly vCenterId?: string;
}

export function getResourcePoolOutput(args: GetResourcePoolOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetResourcePoolResult> {
    return pulumi.output(args).apply(a => getResourcePool(a, opts))
}

export interface GetResourcePoolOutputArgs {
    /**
     * The Resource Group Name.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Name of the resourcePool.
     */
    resourcePoolName: pulumi.Input<string>;
}
