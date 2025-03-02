// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Represents a ApplicationGroup definition.
 */
/** @deprecated Version 2019-12-10-preview will be removed in v2 of the provider. */
export function getApplicationGroup(args: GetApplicationGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetApplicationGroupResult> {
    pulumi.log.warn("getApplicationGroup is deprecated: Version 2019-12-10-preview will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:desktopvirtualization/v20191210preview:getApplicationGroup", {
        "applicationGroupName": args.applicationGroupName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetApplicationGroupArgs {
    /**
     * The name of the application group
     */
    applicationGroupName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
}

/**
 * Represents a ApplicationGroup definition.
 */
export interface GetApplicationGroupResult {
    /**
     * Resource Type of ApplicationGroup.
     */
    readonly applicationGroupType: string;
    /**
     * Description of ApplicationGroup.
     */
    readonly description?: string;
    /**
     * Friendly name of ApplicationGroup.
     */
    readonly friendlyName?: string;
    /**
     * HostPool arm path of ApplicationGroup.
     */
    readonly hostPoolArmPath: string;
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
    /**
     * Workspace arm path of ApplicationGroup.
     */
    readonly workspaceArmPath: string;
}

export function getApplicationGroupOutput(args: GetApplicationGroupOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetApplicationGroupResult> {
    return pulumi.output(args).apply(a => getApplicationGroup(a, opts))
}

export interface GetApplicationGroupOutputArgs {
    /**
     * The name of the application group
     */
    applicationGroupName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
}
