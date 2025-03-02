// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * A SQL server registration.
 */
/** @deprecated Version 2017-03-01-preview will be removed in v2 of the provider. */
export function getSqlServerRegistration(args: GetSqlServerRegistrationArgs, opts?: pulumi.InvokeOptions): Promise<GetSqlServerRegistrationResult> {
    pulumi.log.warn("getSqlServerRegistration is deprecated: Version 2017-03-01-preview will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:azuredata/v20170301preview:getSqlServerRegistration", {
        "resourceGroupName": args.resourceGroupName,
        "sqlServerRegistrationName": args.sqlServerRegistrationName,
    }, opts);
}

export interface GetSqlServerRegistrationArgs {
    /**
     * Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    resourceGroupName: string;
    /**
     * Name of the SQL Server registration.
     */
    sqlServerRegistrationName: string;
}

/**
 * A SQL server registration.
 */
export interface GetSqlServerRegistrationResult {
    /**
     * Resource ID.
     */
    readonly id: string;
    /**
     * Resource location.
     */
    readonly location: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Optional Properties as JSON string
     */
    readonly propertyBag?: string;
    /**
     * Resource Group Name
     */
    readonly resourceGroup?: string;
    /**
     * Subscription Id
     */
    readonly subscriptionId?: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
}

export function getSqlServerRegistrationOutput(args: GetSqlServerRegistrationOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSqlServerRegistrationResult> {
    return pulumi.output(args).apply(a => getSqlServerRegistration(a, opts))
}

export interface GetSqlServerRegistrationOutputArgs {
    /**
     * Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Name of the SQL Server registration.
     */
    sqlServerRegistrationName: pulumi.Input<string>;
}
