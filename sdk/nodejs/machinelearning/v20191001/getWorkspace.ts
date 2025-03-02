// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * An object that represents a machine learning workspace.
 */
export function getWorkspace(args: GetWorkspaceArgs, opts?: pulumi.InvokeOptions): Promise<GetWorkspaceResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:machinelearning/v20191001:getWorkspace", {
        "resourceGroupName": args.resourceGroupName,
        "workspaceName": args.workspaceName,
    }, opts);
}

export interface GetWorkspaceArgs {
    /**
     * The name of the resource group to which the machine learning workspace belongs.
     */
    resourceGroupName: string;
    /**
     * The name of the machine learning workspace.
     */
    workspaceName: string;
}

/**
 * An object that represents a machine learning workspace.
 */
export interface GetWorkspaceResult {
    /**
     * The creation time for this workspace resource.
     */
    readonly creationTime: string;
    /**
     * The resource ID.
     */
    readonly id: string;
    /**
     * The key vault identifier used for encrypted workspaces.
     */
    readonly keyVaultIdentifierId?: string;
    /**
     * The location of the resource. This cannot be changed after the resource is created.
     */
    readonly location: string;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * The email id of the owner for this workspace.
     */
    readonly ownerEmail: string;
    /**
     * The sku of the workspace.
     */
    readonly sku?: outputs.machinelearning.v20191001.SkuResponse;
    /**
     * The regional endpoint for the machine learning studio service which hosts this workspace.
     */
    readonly studioEndpoint: string;
    /**
     * The tags of the resource.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource.
     */
    readonly type: string;
    /**
     * The fully qualified arm id of the storage account associated with this workspace.
     */
    readonly userStorageAccountId: string;
    /**
     * The immutable id associated with this workspace.
     */
    readonly workspaceId: string;
    /**
     * The current state of workspace resource.
     */
    readonly workspaceState: string;
    /**
     * The type of this workspace.
     */
    readonly workspaceType: string;
}

export function getWorkspaceOutput(args: GetWorkspaceOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetWorkspaceResult> {
    return pulumi.output(args).apply(a => getWorkspace(a, opts))
}

export interface GetWorkspaceOutputArgs {
    /**
     * The name of the resource group to which the machine learning workspace belongs.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the machine learning workspace.
     */
    workspaceName: pulumi.Input<string>;
}
