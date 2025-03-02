// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Maintenance configuration record type
 */
/** @deprecated Version 2018-06-01-preview will be removed in v2 of the provider. */
export function getMaintenanceConfiguration(args: GetMaintenanceConfigurationArgs, opts?: pulumi.InvokeOptions): Promise<GetMaintenanceConfigurationResult> {
    pulumi.log.warn("getMaintenanceConfiguration is deprecated: Version 2018-06-01-preview will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:maintenance/v20180601preview:getMaintenanceConfiguration", {
        "resourceGroupName": args.resourceGroupName,
        "resourceName": args.resourceName,
    }, opts);
}

export interface GetMaintenanceConfigurationArgs {
    /**
     * Resource Group Name
     */
    resourceGroupName: string;
    /**
     * Resource Identifier
     */
    resourceName: string;
}

/**
 * Maintenance configuration record type
 */
export interface GetMaintenanceConfigurationResult {
    /**
     * Gets or sets extensionProperties of the maintenanceConfiguration
     */
    readonly extensionProperties?: {[key: string]: string};
    /**
     * Fully qualified identifier of the resource
     */
    readonly id: string;
    /**
     * Gets or sets location of the resource
     */
    readonly location?: string;
    /**
     * Gets or sets maintenanceScope of the configuration
     */
    readonly maintenanceScope?: string;
    /**
     * Name of the resource
     */
    readonly name: string;
    /**
     * Gets or sets namespace of the resource
     */
    readonly namespace?: string;
    /**
     * Gets or sets tags of the resource
     */
    readonly tags?: {[key: string]: string};
    /**
     * Type of the resource
     */
    readonly type: string;
}

export function getMaintenanceConfigurationOutput(args: GetMaintenanceConfigurationOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetMaintenanceConfigurationResult> {
    return pulumi.output(args).apply(a => getMaintenanceConfiguration(a, opts))
}

export interface GetMaintenanceConfigurationOutputArgs {
    /**
     * Resource Group Name
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Resource Identifier
     */
    resourceName: pulumi.Input<string>;
}
