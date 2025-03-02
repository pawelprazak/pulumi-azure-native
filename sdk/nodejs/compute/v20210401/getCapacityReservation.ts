// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Specifies information about the capacity reservation.
 */
export function getCapacityReservation(args: GetCapacityReservationArgs, opts?: pulumi.InvokeOptions): Promise<GetCapacityReservationResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:compute/v20210401:getCapacityReservation", {
        "capacityReservationGroupName": args.capacityReservationGroupName,
        "capacityReservationName": args.capacityReservationName,
        "expand": args.expand,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetCapacityReservationArgs {
    /**
     * The name of the capacity reservation group.
     */
    capacityReservationGroupName: string;
    /**
     * The name of the capacity reservation.
     */
    capacityReservationName: string;
    /**
     * The expand expression to apply on the operation. 'InstanceView' retrieves a snapshot of the runtime properties of the capacity reservation that is managed by the platform and can change outside of control plane operations.
     */
    expand?: string;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
}

/**
 * Specifies information about the capacity reservation.
 */
export interface GetCapacityReservationResult {
    /**
     * Resource Id
     */
    readonly id: string;
    /**
     * The Capacity reservation instance view.
     */
    readonly instanceView: outputs.compute.v20210401.CapacityReservationInstanceViewResponse;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * The provisioning state, which only appears in the response.
     */
    readonly provisioningState: string;
    /**
     * The date time when the capacity reservation was last updated.
     */
    readonly provisioningTime: string;
    /**
     * A unique id generated and assigned to the capacity reservation by the platform which does not change throughout the lifetime of the resource.
     */
    readonly reservationId: string;
    /**
     * SKU of the resource for which capacity needs be reserved. The SKU name and capacity is required to be set. Currently VM Skus with the capability called 'CapacityReservationSupported' set to true are supported. Refer to List Microsoft.Compute SKUs in a region (https://docs.microsoft.com/rest/api/compute/resourceskus/list) for supported values.
     */
    readonly sku: outputs.compute.v20210401.SkuResponse;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type: string;
    /**
     * A list of all virtual machine resource ids that are associated with the capacity reservation.
     */
    readonly virtualMachinesAssociated: outputs.compute.v20210401.SubResourceReadOnlyResponse[];
    /**
     * Availability Zone to use for this capacity reservation. The zone has to be single value and also should be part for the list of zones specified during the capacity reservation group creation. The zone can be assigned only during creation. If not provided, the reservation supports only non-zonal deployments. If provided, enforces VM/VMSS using this capacity reservation to be in same zone.
     */
    readonly zones?: string[];
}

export function getCapacityReservationOutput(args: GetCapacityReservationOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCapacityReservationResult> {
    return pulumi.output(args).apply(a => getCapacityReservation(a, opts))
}

export interface GetCapacityReservationOutputArgs {
    /**
     * The name of the capacity reservation group.
     */
    capacityReservationGroupName: pulumi.Input<string>;
    /**
     * The name of the capacity reservation.
     */
    capacityReservationName: pulumi.Input<string>;
    /**
     * The expand expression to apply on the operation. 'InstanceView' retrieves a snapshot of the runtime properties of the capacity reservation that is managed by the platform and can change outside of control plane operations.
     */
    expand?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
}
