// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * A task resource
 * API Version: 2018-04-19.
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
    public static readonly __pulumiType = 'azure-native:datamigration:Task';

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
    public readonly properties!: pulumi.Output<outputs.datamigration.ConnectToSourcePostgreSqlSyncTaskPropertiesResponse | outputs.datamigration.ConnectToSourceSqlServerSyncTaskPropertiesResponse | outputs.datamigration.ConnectToSourceSqlServerTaskPropertiesResponse | outputs.datamigration.ConnectToTargetAzureDbForMySqlTaskPropertiesResponse | outputs.datamigration.ConnectToTargetAzureDbForPostgreSqlSyncTaskPropertiesResponse | outputs.datamigration.ConnectToTargetSqlDbTaskPropertiesResponse | outputs.datamigration.ConnectToTargetSqlMISyncTaskPropertiesResponse | outputs.datamigration.ConnectToTargetSqlMITaskPropertiesResponse | outputs.datamigration.ConnectToTargetSqlSqlDbSyncTaskPropertiesResponse | outputs.datamigration.GetTdeCertificatesSqlTaskPropertiesResponse | outputs.datamigration.GetUserTablesSqlSyncTaskPropertiesResponse | outputs.datamigration.GetUserTablesSqlTaskPropertiesResponse | outputs.datamigration.MigrateMySqlAzureDbForMySqlSyncTaskPropertiesResponse | outputs.datamigration.MigratePostgreSqlAzureDbForPostgreSqlSyncTaskPropertiesResponse | outputs.datamigration.MigrateSqlServerSqlDbSyncTaskPropertiesResponse | outputs.datamigration.MigrateSqlServerSqlDbTaskPropertiesResponse | outputs.datamigration.MigrateSqlServerSqlMISyncTaskPropertiesResponse | outputs.datamigration.MigrateSqlServerSqlMITaskPropertiesResponse | outputs.datamigration.ValidateMigrationInputSqlServerSqlDbSyncTaskPropertiesResponse | outputs.datamigration.ValidateMigrationInputSqlServerSqlMISyncTaskPropertiesResponse | outputs.datamigration.ValidateMigrationInputSqlServerSqlMITaskPropertiesResponse>;
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
        const aliasOpts = { aliases: [{ type: "azure-native:datamigration/v20171115preview:Task" }, { type: "azure-native:datamigration/v20180315preview:Task" }, { type: "azure-native:datamigration/v20180331preview:Task" }, { type: "azure-native:datamigration/v20180419:Task" }, { type: "azure-native:datamigration/v20180715preview:Task" }, { type: "azure-native:datamigration/v20210630:Task" }, { type: "azure-native:datamigration/v20211030preview:Task" }, { type: "azure-native:datamigration/v20220130preview:Task" }, { type: "azure-native:datamigration/v20220330preview:Task" }] };
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
    properties?: pulumi.Input<inputs.datamigration.ConnectToSourcePostgreSqlSyncTaskPropertiesArgs | inputs.datamigration.ConnectToSourceSqlServerSyncTaskPropertiesArgs | inputs.datamigration.ConnectToSourceSqlServerTaskPropertiesArgs | inputs.datamigration.ConnectToTargetAzureDbForMySqlTaskPropertiesArgs | inputs.datamigration.ConnectToTargetAzureDbForPostgreSqlSyncTaskPropertiesArgs | inputs.datamigration.ConnectToTargetSqlDbTaskPropertiesArgs | inputs.datamigration.ConnectToTargetSqlMISyncTaskPropertiesArgs | inputs.datamigration.ConnectToTargetSqlMITaskPropertiesArgs | inputs.datamigration.ConnectToTargetSqlSqlDbSyncTaskPropertiesArgs | inputs.datamigration.GetTdeCertificatesSqlTaskPropertiesArgs | inputs.datamigration.GetUserTablesSqlSyncTaskPropertiesArgs | inputs.datamigration.GetUserTablesSqlTaskPropertiesArgs | inputs.datamigration.MigrateMySqlAzureDbForMySqlSyncTaskPropertiesArgs | inputs.datamigration.MigratePostgreSqlAzureDbForPostgreSqlSyncTaskPropertiesArgs | inputs.datamigration.MigrateSqlServerSqlDbSyncTaskPropertiesArgs | inputs.datamigration.MigrateSqlServerSqlDbTaskPropertiesArgs | inputs.datamigration.MigrateSqlServerSqlMISyncTaskPropertiesArgs | inputs.datamigration.MigrateSqlServerSqlMITaskPropertiesArgs | inputs.datamigration.ValidateMigrationInputSqlServerSqlDbSyncTaskPropertiesArgs | inputs.datamigration.ValidateMigrationInputSqlServerSqlMISyncTaskPropertiesArgs | inputs.datamigration.ValidateMigrationInputSqlServerSqlMITaskPropertiesArgs>;
    /**
     * Name of the service
     */
    serviceName: pulumi.Input<string>;
    /**
     * Name of the Task
     */
    taskName?: pulumi.Input<string>;
}
