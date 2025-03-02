// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * API Version: 2016-01-29.
 */
export function listWorkspaceCollectionAccessKeys(args: ListWorkspaceCollectionAccessKeysArgs, opts?: pulumi.InvokeOptions): Promise<ListWorkspaceCollectionAccessKeysResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:powerbi:listWorkspaceCollectionAccessKeys", {
        "resourceGroupName": args.resourceGroupName,
        "workspaceCollectionName": args.workspaceCollectionName,
    }, opts);
}

export interface ListWorkspaceCollectionAccessKeysArgs {
    /**
     * Azure resource group
     */
    resourceGroupName: string;
    /**
     * Power BI Embedded Workspace Collection name
     */
    workspaceCollectionName: string;
}

export interface ListWorkspaceCollectionAccessKeysResult {
    /**
     * Access key 1
     */
    readonly key1?: string;
    /**
     * Access key 2
     */
    readonly key2?: string;
}

export function listWorkspaceCollectionAccessKeysOutput(args: ListWorkspaceCollectionAccessKeysOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListWorkspaceCollectionAccessKeysResult> {
    return pulumi.output(args).apply(a => listWorkspaceCollectionAccessKeys(a, opts))
}

export interface ListWorkspaceCollectionAccessKeysOutputArgs {
    /**
     * Azure resource group
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Power BI Embedded Workspace Collection name
     */
    workspaceCollectionName: pulumi.Input<string>;
}
