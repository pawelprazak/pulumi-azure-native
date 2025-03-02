// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Role Addon
 */
/** @deprecated Version 2020-09-01 will be removed in v2 of the provider. */
export function getAddon(args: GetAddonArgs, opts?: pulumi.InvokeOptions): Promise<GetAddonResult> {
    pulumi.log.warn("getAddon is deprecated: Version 2020-09-01 will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:databoxedge/v20200901:getAddon", {
        "addonName": args.addonName,
        "deviceName": args.deviceName,
        "resourceGroupName": args.resourceGroupName,
        "roleName": args.roleName,
    }, opts);
}

export interface GetAddonArgs {
    /**
     * The addon name.
     */
    addonName: string;
    /**
     * The device name.
     */
    deviceName: string;
    /**
     * The resource group name.
     */
    resourceGroupName: string;
    /**
     * The role name.
     */
    roleName: string;
}

/**
 * Role Addon
 */
export interface GetAddonResult {
    /**
     * The path ID that uniquely identifies the object.
     */
    readonly id: string;
    /**
     * Addon type.
     */
    readonly kind: string;
    /**
     * The object name.
     */
    readonly name: string;
    /**
     * Addon type
     */
    readonly systemData: outputs.databoxedge.v20200901.SystemDataResponse;
    /**
     * The hierarchical type of the object.
     */
    readonly type: string;
}

export function getAddonOutput(args: GetAddonOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAddonResult> {
    return pulumi.output(args).apply(a => getAddon(a, opts))
}

export interface GetAddonOutputArgs {
    /**
     * The addon name.
     */
    addonName: pulumi.Input<string>;
    /**
     * The device name.
     */
    deviceName: pulumi.Input<string>;
    /**
     * The resource group name.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The role name.
     */
    roleName: pulumi.Input<string>;
}
