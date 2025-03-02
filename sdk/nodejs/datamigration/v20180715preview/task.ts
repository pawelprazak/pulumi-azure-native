// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * A task resource
 */
export class Task extends pulumi.CustomResource {
    /**
     * Get an existing Task resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Task {
        return new Task(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:datamigration/v20180715preview:Task';

    /**
     * Returns true if the given object is an instance of Task.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Task {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Task.__pulumiType;
    }

    /**
     * HTTP strong entity tag value. This is ignored if submitted.
     */
    public /*out*/ readonly etag!: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Custom task properties
     */
    public readonly properties!: pulumi.Output<outputs.datamigration.v20180715preview.ConnectToMongoDbTaskPropertiesResponse | outputs.datamigration.v20180715preview.ConnectToSourceOracleSyncTaskPropertiesResponse | outputs.datamigration.v20180715preview.ConnectToSourcePostgreSqlSyncTaskPropertiesResponse | outputs.datamigration.v20180715preview.ConnectToSourceSqlServerSyncTaskPropertiesResponse | outputs.datamigration.v20180715preview.ConnectToSourceSqlServerTaskPropertiesResponse | outputs.datamigration.v20180715preview.ConnectToTargetAzureDbForMySqlTaskPropertiesResponse | outputs.datamigration.v20180715preview.ConnectToTargetAzureDbForPostgreSqlSyncTaskPropertiesResponse | outputs.datamigration.v20180715preview.ConnectToTargetOracleAzureDbForPostgreSqlSyncTaskPropertiesResponse | outputs.datamigration.v20180715preview.ConnectToTargetSqlDbTaskPropertiesResponse | outputs.datamigration.v20180715preview.ConnectToTargetSqlMISyncTaskPropertiesResponse | outputs.datamigration.v20180715preview.ConnectToTargetSqlMITaskPropertiesResponse | outputs.datamigration.v20180715preview.ConnectToTargetSqlSqlDbSyncTaskPropertiesResponse | outputs.datamigration.v20180715preview.GetTdeCertificatesSqlTaskPropertiesResponse | outputs.datamigration.v20180715preview.GetUserTablesOracleTaskPropertiesResponse | outputs.datamigration.v20180715preview.GetUserTablesPostgreSqlTaskPropertiesResponse | outputs.datamigration.v20180715preview.GetUserTablesSqlSyncTaskPropertiesResponse | outputs.datamigration.v20180715preview.GetUserTablesSqlTaskPropertiesResponse | outputs.datamigration.v20180715preview.MigrateMongoDbTaskPropertiesResponse | outputs.datamigration.v20180715preview.MigrateMySqlAzureDbForMySqlSyncTaskPropertiesResponse | outputs.datamigration.v20180715preview.MigrateOracleAzureDbForPostgreSqlSyncTaskPropertiesResponse | outputs.datamigration.v20180715preview.MigratePostgreSqlAzureDbForPostgreSqlSyncTaskPropertiesResponse | outputs.datamigration.v20180715preview.MigrateSqlServerSqlDbSyncTaskPropertiesResponse | outputs.datamigration.v20180715preview.MigrateSqlServerSqlDbTaskPropertiesResponse | outputs.datamigration.v20180715preview.MigrateSqlServerSqlMISyncTaskPropertiesResponse | outputs.datamigration.v20180715preview.MigrateSqlServerSqlMITaskPropertiesResponse | outputs.datamigration.v20180715preview.MigrateSsisTaskPropertiesResponse | outputs.datamigration.v20180715preview.ValidateMigrationInputSqlServerSqlDbSyncTaskPropertiesResponse | outputs.datamigration.v20180715preview.ValidateMigrationInputSqlServerSqlMISyncTaskPropertiesResponse | outputs.datamigration.v20180715preview.ValidateMigrationInputSqlServerSqlMITaskPropertiesResponse | outputs.datamigration.v20180715preview.ValidateMongoDbTaskPropertiesResponse | outputs.datamigration.v20180715preview.ValidateOracleAzureDbForPostgreSqlSyncTaskPropertiesResponse>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Task resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: TaskArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.groupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'groupName'");
            }
            if ((!args || args.projectName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'projectName'");
            }
            if ((!args || args.serviceName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'serviceName'");
            }
            resourceInputs["groupName"] = args ? args.groupName : undefined;
            resourceInputs["projectName"] = args ? args.projectName : undefined;
            resourceInputs["properties"] = args ? args.properties : undefined;
            resourceInputs["serviceName"] = args ? args.serviceName : undefined;
            resourceInputs["taskName"] = args ? args.taskName : undefined;
            resourceInputs["etag"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["etag"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["properties"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:datamigration:Task" }, { type: "azure-native:datamigration/v20171115preview:Task" }, { type: "azure-native:datamigration/v20180315preview:Task" }, { type: "azure-native:datamigration/v20180331preview:Task" }, { type: "azure-native:datamigration/v20180419:Task" }, { type: "azure-native:datamigration/v20210630:Task" }, { type: "azure-native:datamigration/v20211030preview:Task" }, { type: "azure-native:datamigration/v20220130preview:Task" }, { type: "azure-native:datamigration/v20220330preview:Task" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(Task.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a Task resource.
 */
export interface TaskArgs {
    /**
     * Name of the resource group
     */
    groupName: pulumi.Input<string>;
    /**
     * Name of the project
     */
    projectName: pulumi.Input<string>;
    /**
     * Custom task properties
     */
    properties?: pulumi.Input<inputs.datamigration.v20180715preview.ConnectToMongoDbTaskPropertiesArgs | inputs.datamigration.v20180715preview.ConnectToSourceOracleSyncTaskPropertiesArgs | inputs.datamigration.v20180715preview.ConnectToSourcePostgreSqlSyncTaskPropertiesArgs | inputs.datamigration.v20180715preview.ConnectToSourceSqlServerSyncTaskPropertiesArgs | inputs.datamigration.v20180715preview.ConnectToSourceSqlServerTaskPropertiesArgs | inputs.datamigration.v20180715preview.ConnectToTargetAzureDbForMySqlTaskPropertiesArgs | inputs.datamigration.v20180715preview.ConnectToTargetAzureDbForPostgreSqlSyncTaskPropertiesArgs | inputs.datamigration.v20180715preview.ConnectToTargetOracleAzureDbForPostgreSqlSyncTaskPropertiesArgs | inputs.datamigration.v20180715preview.ConnectToTargetSqlDbTaskPropertiesArgs | inputs.datamigration.v20180715preview.ConnectToTargetSqlMISyncTaskPropertiesArgs | inputs.datamigration.v20180715preview.ConnectToTargetSqlMITaskPropertiesArgs | inputs.datamigration.v20180715preview.ConnectToTargetSqlSqlDbSyncTaskPropertiesArgs | inputs.datamigration.v20180715preview.GetTdeCertificatesSqlTaskPropertiesArgs | inputs.datamigration.v20180715preview.GetUserTablesOracleTaskPropertiesArgs | inputs.datamigration.v20180715preview.GetUserTablesPostgreSqlTaskPropertiesArgs | inputs.datamigration.v20180715preview.GetUserTablesSqlSyncTaskPropertiesArgs | inputs.datamigration.v20180715preview.GetUserTablesSqlTaskPropertiesArgs | inputs.datamigration.v20180715preview.MigrateMongoDbTaskPropertiesArgs | inputs.datamigration.v20180715preview.MigrateMySqlAzureDbForMySqlSyncTaskPropertiesArgs | inputs.datamigration.v20180715preview.MigrateOracleAzureDbForPostgreSqlSyncTaskPropertiesArgs | inputs.datamigration.v20180715preview.MigratePostgreSqlAzureDbForPostgreSqlSyncTaskPropertiesArgs | inputs.datamigration.v20180715preview.MigrateSqlServerSqlDbSyncTaskPropertiesArgs | inputs.datamigration.v20180715preview.MigrateSqlServerSqlDbTaskPropertiesArgs | inputs.datamigration.v20180715preview.MigrateSqlServerSqlMISyncTaskPropertiesArgs | inputs.datamigration.v20180715preview.MigrateSqlServerSqlMITaskPropertiesArgs | inputs.datamigration.v20180715preview.MigrateSsisTaskPropertiesArgs | inputs.datamigration.v20180715preview.ValidateMigrationInputSqlServerSqlDbSyncTaskPropertiesArgs | inputs.datamigration.v20180715preview.ValidateMigrationInputSqlServerSqlMISyncTaskPropertiesArgs | inputs.datamigration.v20180715preview.ValidateMigrationInputSqlServerSqlMITaskPropertiesArgs | inputs.datamigration.v20180715preview.ValidateMongoDbTaskPropertiesArgs | inputs.datamigration.v20180715preview.ValidateOracleAzureDbForPostgreSqlSyncTaskPropertiesArgs>;
    /**
     * Name of the service
     */
    serviceName: pulumi.Input<string>;
    /**
     * Name of the Task
     */
    taskName?: pulumi.Input<string>;
}
