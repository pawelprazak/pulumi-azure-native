// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Represents a Watchlist Item in Azure Security Insights.
 */
export function getWatchlistItem(args: GetWatchlistItemArgs, opts?: pulumi.InvokeOptions): Promise<GetWatchlistItemResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:securityinsights/v20210401:getWatchlistItem", {
        "operationalInsightsResourceProvider": args.operationalInsightsResourceProvider,
        "resourceGroupName": args.resourceGroupName,
        "watchlistAlias": args.watchlistAlias,
        "watchlistItemId": args.watchlistItemId,
        "workspaceName": args.workspaceName,
    }, opts);
}

export interface GetWatchlistItemArgs {
    /**
     * The namespace of workspaces resource provider- Microsoft.OperationalInsights.
     */
    operationalInsightsResourceProvider: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * The watchlist alias
     */
    watchlistAlias: string;
    /**
     * The watchlist item id (GUID)
     */
    watchlistItemId: string;
    /**
     * The name of the workspace.
     */
    workspaceName: string;
}

/**
 * Represents a Watchlist Item in Azure Security Insights.
 */
export interface GetWatchlistItemResult {
    /**
     * The time the watchlist item was created
     */
    readonly created?: string;
    /**
     * Describes a user that created the watchlist item
     */
    readonly createdBy?: outputs.securityinsights.v20210401.WatchlistUserInfoResponse;
    /**
     * key-value pairs for a watchlist item entity mapping
     */
    readonly entityMapping?: any;
    /**
     * Etag of the azure resource
     */
    readonly etag?: string;
    /**
     * Azure resource Id
     */
    readonly id: string;
    /**
     * A flag that indicates if the watchlist item is deleted or not
     */
    readonly isDeleted?: boolean;
    /**
     * key-value pairs for a watchlist item
     */
    readonly itemsKeyValue: any;
    /**
     * Azure resource name
     */
    readonly name: string;
    /**
     * Azure Resource Manager metadata containing createdBy and modifiedBy information.
     */
    readonly systemData: outputs.securityinsights.v20210401.SystemDataResponse;
    /**
     * The tenantId to which the watchlist item belongs to
     */
    readonly tenantId?: string;
    /**
     * Azure resource type
     */
    readonly type: string;
    /**
     * The last time the watchlist item was updated
     */
    readonly updated?: string;
    /**
     * Describes a user that updated the watchlist item
     */
    readonly updatedBy?: outputs.securityinsights.v20210401.WatchlistUserInfoResponse;
    /**
     * The id (a Guid) of the watchlist item
     */
    readonly watchlistItemId?: string;
    /**
     * The type of the watchlist item
     */
    readonly watchlistItemType?: string;
}

export function getWatchlistItemOutput(args: GetWatchlistItemOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetWatchlistItemResult> {
    return pulumi.output(args).apply(a => getWatchlistItem(a, opts))
}

export interface GetWatchlistItemOutputArgs {
    /**
     * The namespace of workspaces resource provider- Microsoft.OperationalInsights.
     */
    operationalInsightsResourceProvider: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The watchlist alias
     */
    watchlistAlias: pulumi.Input<string>;
    /**
     * The watchlist item id (GUID)
     */
    watchlistItemId: pulumi.Input<string>;
    /**
     * The name of the workspace.
     */
    workspaceName: pulumi.Input<string>;
}
