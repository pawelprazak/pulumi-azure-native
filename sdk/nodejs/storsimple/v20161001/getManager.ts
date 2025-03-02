// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * The StorSimple Manager
 */
/** @deprecated Version 2016-10-01 will be removed in v2 of the provider. */
export function getManager(args: GetManagerArgs, opts?: pulumi.InvokeOptions): Promise<GetManagerResult> {
    pulumi.log.warn("getManager is deprecated: Version 2016-10-01 will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:storsimple/v20161001:getManager", {
        "managerName": args.managerName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetManagerArgs {
    /**
     * The manager name
     */
    managerName: string;
    /**
     * The resource group name
     */
    resourceGroupName: string;
}

/**
 * The StorSimple Manager
 */
export interface GetManagerResult {
    /**
     * Specifies if the Manager is Garda or Helsinki
     */
    readonly cisIntrinsicSettings?: outputs.storsimple.v20161001.ManagerIntrinsicSettingsResponse;
    /**
     * ETag of the Manager
     */
    readonly etag?: string;
    /**
     * The Resource Id
     */
    readonly id: string;
    /**
     * The Geo location of the Manager
     */
    readonly location: string;
    /**
     * The Resource Name
     */
    readonly name: string;
    /**
     * Specifies the state of the resource as it is getting provisioned. Value of "Succeeded" means the Manager was successfully created
     */
    readonly provisioningState: string;
    /**
     * Specifies the Sku
     */
    readonly sku?: outputs.storsimple.v20161001.ManagerSkuResponse;
    /**
     * Tags attached to the Manager
     */
    readonly tags?: {[key: string]: string};
    /**
     * The Resource type
     */
    readonly type: string;
}

export function getManagerOutput(args: GetManagerOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetManagerResult> {
    return pulumi.output(args).apply(a => getManager(a, opts))
}

export interface GetManagerOutputArgs {
    /**
     * The manager name
     */
    managerName: pulumi.Input<string>;
    /**
     * The resource group name
     */
    resourceGroupName: pulumi.Input<string>;
}
