// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Namespace/NotificationHub Connection String
 */
export function listNotificationHubKeys(args: ListNotificationHubKeysArgs, opts?: pulumi.InvokeOptions): Promise<ListNotificationHubKeysResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:notificationhubs/v20140901:listNotificationHubKeys", {
        "authorizationRuleName": args.authorizationRuleName,
        "namespaceName": args.namespaceName,
        "notificationHubName": args.notificationHubName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListNotificationHubKeysArgs {
    /**
     * The connection string of the NotificationHub for the specified authorizationRule.
     */
    authorizationRuleName: string;
    /**
     * The namespace name.
     */
    namespaceName: string;
    /**
     * The notification hub name.
     */
    notificationHubName: string;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
}

/**
 * Namespace/NotificationHub Connection String
 */
export interface ListNotificationHubKeysResult {
    /**
     * Gets or sets the primaryConnectionString of the created Namespace AuthorizationRule.
     */
    readonly primaryConnectionString?: string;
    /**
     * Gets or sets the secondaryConnectionString of the created Namespace AuthorizationRule
     */
    readonly secondaryConnectionString?: string;
}

export function listNotificationHubKeysOutput(args: ListNotificationHubKeysOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListNotificationHubKeysResult> {
    return pulumi.output(args).apply(a => listNotificationHubKeys(a, opts))
}

export interface ListNotificationHubKeysOutputArgs {
    /**
     * The connection string of the NotificationHub for the specified authorizationRule.
     */
    authorizationRuleName: pulumi.Input<string>;
    /**
     * The namespace name.
     */
    namespaceName: pulumi.Input<string>;
    /**
     * The notification hub name.
     */
    notificationHubName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
}
