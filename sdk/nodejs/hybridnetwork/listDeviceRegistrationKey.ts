// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * The device registration key.
 * API Version: 2020-01-01-preview.
 */
export function listDeviceRegistrationKey(args: ListDeviceRegistrationKeyArgs, opts?: pulumi.InvokeOptions): Promise<ListDeviceRegistrationKeyResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:hybridnetwork:listDeviceRegistrationKey", {
        "deviceName": args.deviceName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListDeviceRegistrationKeyArgs {
    /**
     * The name of the device resource.
     */
    deviceName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
}

/**
 * The device registration key.
 */
export interface ListDeviceRegistrationKeyResult {
    /**
     * The registration key for the device.
     */
    readonly registrationKey: string;
}

export function listDeviceRegistrationKeyOutput(args: ListDeviceRegistrationKeyOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListDeviceRegistrationKeyResult> {
    return pulumi.output(args).apply(a => listDeviceRegistrationKey(a, opts))
}

export interface ListDeviceRegistrationKeyOutputArgs {
    /**
     * The name of the device resource.
     */
    deviceName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
}
