// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * A task resource
 */
export function getTask(args: GetTaskArgs, opts?: pulumi.InvokeOptions): Promise<GetTaskResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:datamigration/v20211030preview:getTask", {
        "expand": args.expand,
        "groupName": args.groupName,
        "projectName": args.projectName,
        "serviceName": args.serviceName,
        "taskName": args.taskName,
    }, opts);
}

export interface GetTaskArgs {
    /**
     * Expand the response
     */
    expand?: string;
    /**
     * Name of the resource group
     */
    groupName: string;
    /**
     * Name of the project
     */
    projectName: string;
    /**
     * Name of the service
     */
    serviceName: string;
    /**
     * Name of the Task
     */
    taskName: string;
}

/**
 * A task resource
 */
export interface GetTaskResult {
    /**
     * HTTP strong entity tag value. This is ignored if submitted.
     */
    readonly etag?: string;
    /**
     * Resource ID.
     */
    readonly id: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Custom task properties
     */
    readonly properties: outputs.datamigration.v20211030preview.ConnectToMongoDbTaskPropertiesResponse | outputs.datamigration.v20211030preview.ConnectToSourceMySqlTaskPropertiesResponse | outputs.datamigration.v20211030preview.ConnectToSourceOracleSyncTaskPropertiesResponse | outputs.datamigration.v20211030preview.ConnectToSourcePostgreSqlSyncTaskPropertiesResponse | outputs.datamigration.v20211030preview.ConnectToSourceSqlServerSyncTaskPropertiesResponse | outputs.datamigration.v20211030preview.ConnectToSourceSqlServerTaskPropertiesResponse | outputs.datamigration.v20211030preview.ConnectToTargetAzureDbForMySqlTaskPropertiesResponse | outputs.datamigration.v20211030preview.ConnectToTargetAzureDbForPostgreSqlSyncTaskPropertiesResponse | outputs.datamigration.v20211030preview.ConnectToTargetOracleAzureDbForPostgreSqlSyncTaskPropertiesResponse | outputs.datamigration.v20211030preview.ConnectToTargetSqlDbTaskPropertiesResponse | outputs.datamigration.v20211030preview.ConnectToTargetSqlMISyncTaskPropertiesResponse | outputs.datamigration.v20211030preview.ConnectToTargetSqlMITaskPropertiesResponse | outputs.datamigration.v20211030preview.ConnectToTargetSqlSqlDbSyncTaskPropertiesResponse | outputs.datamigration.v20211030preview.GetTdeCertificatesSqlTaskPropertiesResponse | outputs.datamigration.v20211030preview.GetUserTablesMySqlTaskPropertiesResponse | outputs.datamigration.v20211030preview.GetUserTablesOracleTaskPropertiesResponse | outputs.datamigration.v20211030preview.GetUserTablesPostgreSqlTaskPropertiesResponse | outputs.datamigration.v20211030preview.GetUserTablesSqlSyncTaskPropertiesResponse | outputs.datamigration.v20211030preview.GetUserTablesSqlTaskPropertiesResponse | outputs.datamigration.v20211030preview.MigrateMongoDbTaskPropertiesResponse | outputs.datamigration.v20211030preview.MigrateMySqlAzureDbForMySqlOfflineTaskPropertiesResponse | outputs.datamigration.v20211030preview.MigrateMySqlAzureDbForMySqlSyncTaskPropertiesResponse | outputs.datamigration.v20211030preview.MigrateOracleAzureDbForPostgreSqlSyncTaskPropertiesResponse | outputs.datamigration.v20211030preview.MigratePostgreSqlAzureDbForPostgreSqlSyncTaskPropertiesResponse | outputs.datamigration.v20211030preview.MigrateSqlServerSqlDbSyncTaskPropertiesResponse | outputs.datamigration.v20211030preview.MigrateSqlServerSqlDbTaskPropertiesResponse | outputs.datamigration.v20211030preview.MigrateSqlServerSqlMISyncTaskPropertiesResponse | outputs.datamigration.v20211030preview.MigrateSqlServerSqlMITaskPropertiesResponse | outputs.datamigration.v20211030preview.MigrateSsisTaskPropertiesResponse | outputs.datamigration.v20211030preview.ValidateMigrationInputSqlServerSqlDbSyncTaskPropertiesResponse | outputs.datamigration.v20211030preview.ValidateMigrationInputSqlServerSqlMISyncTaskPropertiesResponse | outputs.datamigration.v20211030preview.ValidateMigrationInputSqlServerSqlMITaskPropertiesResponse | outputs.datamigration.v20211030preview.ValidateMongoDbTaskPropertiesResponse | outputs.datamigration.v20211030preview.ValidateOracleAzureDbForPostgreSqlSyncTaskPropertiesResponse;
    /**
     * Metadata pertaining to creation and last modification of the resource.
     */
    readonly systemData: outputs.datamigration.v20211030preview.SystemDataResponse;
    /**
     * Resource type.
     */
    readonly type: string;
}

export function getTaskOutput(args: GetTaskOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetTaskResult> {
    return pulumi.output(args).apply(a => getTask(a, opts))
}

export interface GetTaskOutputArgs {
    /**
     * Expand the response
     */
    expand?: pulumi.Input<string>;
    /**
     * Name of the resource group
     */
    groupName: pulumi.Input<string>;
    /**
     * Name of the project
     */
    projectName: pulumi.Input<string>;
    /**
     * Name of the service
     */
    serviceName: pulumi.Input<string>;
    /**
     * Name of the Task
     */
    taskName: pulumi.Input<string>;
}
