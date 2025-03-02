// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Represents Activity entity query.
 * API Version: 2021-03-01-preview.
 */
export function getActivityCustomEntityQuery(args: GetActivityCustomEntityQueryArgs, opts?: pulumi.InvokeOptions): Promise<GetActivityCustomEntityQueryResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:securityinsights:getActivityCustomEntityQuery", {
        "entityQueryId": args.entityQueryId,
        "operationalInsightsResourceProvider": args.operationalInsightsResourceProvider,
        "resourceGroupName": args.resourceGroupName,
        "workspaceName": args.workspaceName,
    }, opts);
}

export interface GetActivityCustomEntityQueryArgs {
    /**
     * entity query ID
     */
    entityQueryId: string;
    /**
     * The namespace of workspaces resource provider- Microsoft.OperationalInsights.
     */
    operationalInsightsResourceProvider: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * The name of the workspace.
     */
    workspaceName: string;
}

/**
 * Represents Activity entity query.
 */
export interface GetActivityCustomEntityQueryResult {
    /**
     * The entity query content to display in timeline
     */
    readonly content?: string;
    /**
     * The time the activity was created
     */
    readonly createdTimeUtc: string;
    /**
     * The entity query description
     */
    readonly description?: string;
    /**
     * Determines whether this activity is enabled or disabled.
     */
    readonly enabled?: boolean;
    /**
     * The query applied only to entities matching to all filters
     */
    readonly entitiesFilter?: {[key: string]: string[]};
    /**
     * Etag of the azure resource
     */
    readonly etag?: string;
    /**
     * Azure resource Id
     */
    readonly id: string;
    /**
     * The type of the query's source entity
     */
    readonly inputEntityType?: string;
    /**
     * The kind of the entity query
     * Expected value is 'Activity'.
     */
    readonly kind: "Activity";
    /**
     * The last time the activity was updated
     */
    readonly lastModifiedTimeUtc: string;
    /**
     * Azure resource name
     */
    readonly name: string;
    /**
     * The Activity query definitions
     */
    readonly queryDefinitions?: outputs.securityinsights.ActivityEntityQueriesPropertiesResponseQueryDefinitions;
    /**
     * List of the fields of the source entity that are required to run the query
     */
    readonly requiredInputFieldsSets?: string[][];
    /**
     * Azure Resource Manager metadata containing createdBy and modifiedBy information.
     */
    readonly systemData: outputs.securityinsights.SystemDataResponse;
    /**
     * The template id this activity was created from
     */
    readonly templateName?: string;
    /**
     * The entity query title
     */
    readonly title?: string;
    /**
     * Azure resource type
     */
    readonly type: string;
}

export function getActivityCustomEntityQueryOutput(args: GetActivityCustomEntityQueryOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetActivityCustomEntityQueryResult> {
    return pulumi.output(args).apply(a => getActivityCustomEntityQuery(a, opts))
}

export interface GetActivityCustomEntityQueryOutputArgs {
    /**
     * entity query ID
     */
    entityQueryId: pulumi.Input<string>;
    /**
     * The namespace of workspaces resource provider- Microsoft.OperationalInsights.
     */
    operationalInsightsResourceProvider: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the workspace.
     */
    workspaceName: pulumi.Input<string>;
}
