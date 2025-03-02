// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * An Azure Video Analyzer for Media account.
 * API Version: 2021-10-18-preview.
 */
export function getAccount(args: GetAccountArgs, opts?: pulumi.InvokeOptions): Promise<GetAccountResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:videoindexer:getAccount", {
        "accountName": args.accountName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetAccountArgs {
    /**
     * The name of the Azure Video Analyzer for Media account.
     */
    accountName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
}

/**
 * An Azure Video Analyzer for Media account.
 */
export interface GetAccountResult {
    /**
     * The account's data-plane ID. This can be set only when connecting an existing classic account
     */
    readonly accountId?: string;
    /**
     * The account's name
     */
    readonly accountName: string;
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * Managed service identity (system assigned and/or user assigned identities)
     */
    readonly identity?: outputs.videoindexer.ManagedServiceIdentityResponse;
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * The media services details
     */
    readonly mediaServices?: outputs.videoindexer.MediaServicesForPutRequestResponse;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Gets the status of the account at the time the operation was called.
     */
    readonly provisioningState: string;
    /**
     * The system meta data relating to this resource.
     */
    readonly systemData: outputs.videoindexer.SystemDataResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The account's tenant id
     */
    readonly tenantId: string;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}

export function getAccountOutput(args: GetAccountOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAccountResult> {
    return pulumi.output(args).apply(a => getAccount(a, opts))
}

export interface GetAccountOutputArgs {
    /**
     * The name of the Azure Video Analyzer for Media account.
     */
    accountName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
}
