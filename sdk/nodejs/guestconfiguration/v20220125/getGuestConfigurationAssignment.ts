// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Guest configuration assignment is an association between a machine and guest configuration.
 */
export function getGuestConfigurationAssignment(args: GetGuestConfigurationAssignmentArgs, opts?: pulumi.InvokeOptions): Promise<GetGuestConfigurationAssignmentResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:guestconfiguration/v20220125:getGuestConfigurationAssignment", {
        "guestConfigurationAssignmentName": args.guestConfigurationAssignmentName,
        "resourceGroupName": args.resourceGroupName,
        "vmName": args.vmName,
    }, opts);
}

export interface GetGuestConfigurationAssignmentArgs {
    /**
     * The guest configuration assignment name.
     */
    guestConfigurationAssignmentName: string;
    /**
     * The resource group name.
     */
    resourceGroupName: string;
    /**
     * The name of the virtual machine.
     */
    vmName: string;
}

/**
 * Guest configuration assignment is an association between a machine and guest configuration.
 */
export interface GetGuestConfigurationAssignmentResult {
    /**
     * ARM resource id of the guest configuration assignment.
     */
    readonly id: string;
    /**
     * Region where the VM is located.
     */
    readonly location?: string;
    /**
     * Name of the guest configuration assignment.
     */
    readonly name?: string;
    /**
     * Properties of the Guest configuration assignment.
     */
    readonly properties: outputs.guestconfiguration.v20220125.GuestConfigurationAssignmentPropertiesResponse;
    /**
     * Azure Resource Manager metadata containing createdBy and modifiedBy information.
     */
    readonly systemData: outputs.guestconfiguration.v20220125.SystemDataResponse;
    /**
     * The type of the resource.
     */
    readonly type: string;
}

export function getGuestConfigurationAssignmentOutput(args: GetGuestConfigurationAssignmentOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetGuestConfigurationAssignmentResult> {
    return pulumi.output(args).apply(a => getGuestConfigurationAssignment(a, opts))
}

export interface GetGuestConfigurationAssignmentOutputArgs {
    /**
     * The guest configuration assignment name.
     */
    guestConfigurationAssignmentName: pulumi.Input<string>;
    /**
     * The resource group name.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the virtual machine.
     */
    vmName: pulumi.Input<string>;
}
