// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * An Azure Cosmos DB User Definition
 */
export function getMongoDBResourceMongoUserDefinition(args: GetMongoDBResourceMongoUserDefinitionArgs, opts?: pulumi.InvokeOptions): Promise<GetMongoDBResourceMongoUserDefinitionResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:documentdb/v20220515preview:getMongoDBResourceMongoUserDefinition", {
        "accountName": args.accountName,
        "mongoUserDefinitionId": args.mongoUserDefinitionId,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetMongoDBResourceMongoUserDefinitionArgs {
    /**
     * Cosmos DB database account name.
     */
    accountName: string;
    /**
     * The ID for the User Definition {dbName.userName}.
     */
    mongoUserDefinitionId: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
}

/**
 * An Azure Cosmos DB User Definition
 */
export interface GetMongoDBResourceMongoUserDefinitionResult {
    /**
     * A custom definition for the USer Definition.
     */
    readonly customData?: string;
    /**
     * The database name for which access is being granted for this User Definition.
     */
    readonly databaseName?: string;
    /**
     * The unique resource identifier of the database account.
     */
    readonly id: string;
    /**
     * The Mongo Auth mechanism. For now, we only support auth mechanism SCRAM-SHA-256.
     */
    readonly mechanisms?: string;
    /**
     * The name of the database account.
     */
    readonly name: string;
    /**
     * The password for User Definition. Response does not contain user password.
     */
    readonly password?: string;
    /**
     * The set of roles inherited by the User Definition.
     */
    readonly roles?: outputs.documentdb.v20220515preview.RoleResponse[];
    /**
     * The type of Azure resource.
     */
    readonly type: string;
    /**
     * The user name for User Definition.
     */
    readonly userName?: string;
}

export function getMongoDBResourceMongoUserDefinitionOutput(args: GetMongoDBResourceMongoUserDefinitionOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetMongoDBResourceMongoUserDefinitionResult> {
    return pulumi.output(args).apply(a => getMongoDBResourceMongoUserDefinition(a, opts))
}

export interface GetMongoDBResourceMongoUserDefinitionOutputArgs {
    /**
     * Cosmos DB database account name.
     */
    accountName: pulumi.Input<string>;
    /**
     * The ID for the User Definition {dbName.userName}.
     */
    mongoUserDefinitionId: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
}
