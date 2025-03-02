// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Integration Runtime Monitoring Data.
 * API Version: 2021-10-30-preview.
 */
export function listSqlMigrationServiceMonitoringData(args: ListSqlMigrationServiceMonitoringDataArgs, opts?: pulumi.InvokeOptions): Promise<ListSqlMigrationServiceMonitoringDataResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:datamigration:listSqlMigrationServiceMonitoringData", {
        "resourceGroupName": args.resourceGroupName,
        "sqlMigrationServiceName": args.sqlMigrationServiceName,
    }, opts);
}

export interface ListSqlMigrationServiceMonitoringDataArgs {
    /**
     * Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    resourceGroupName: string;
    /**
     * Name of the SQL Migration Service.
     */
    sqlMigrationServiceName: string;
}

/**
 * Integration Runtime Monitoring Data.
 */
export interface ListSqlMigrationServiceMonitoringDataResult {
    /**
     * The name of Integration Runtime.
     */
    readonly name: string;
    /**
     * Integration Runtime node monitoring data.
     */
    readonly nodes: outputs.datamigration.NodeMonitoringDataResponse[];
}

export function listSqlMigrationServiceMonitoringDataOutput(args: ListSqlMigrationServiceMonitoringDataOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListSqlMigrationServiceMonitoringDataResult> {
    return pulumi.output(args).apply(a => listSqlMigrationServiceMonitoringData(a, opts))
}

export interface ListSqlMigrationServiceMonitoringDataOutputArgs {
    /**
     * Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Name of the SQL Migration Service.
     */
    sqlMigrationServiceName: pulumi.Input<string>;
}
