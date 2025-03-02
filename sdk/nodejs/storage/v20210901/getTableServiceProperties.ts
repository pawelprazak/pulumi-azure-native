// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * The properties of a storage account’s Table service.
 */
export function getTableServiceProperties(args: GetTableServicePropertiesArgs, opts?: pulumi.InvokeOptions): Promise<GetTableServicePropertiesResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:storage/v20210901:getTableServiceProperties", {
        "accountName": args.accountName,
        "resourceGroupName": args.resourceGroupName,
        "tableServiceName": args.tableServiceName,
    }, opts);
}

export interface GetTableServicePropertiesArgs {
    /**
     * The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
     */
    accountName: string;
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * The name of the Table Service within the specified storage account. Table Service Name must be 'default'
     */
    tableServiceName: string;
}

/**
 * The properties of a storage account’s Table service.
 */
export interface GetTableServicePropertiesResult {
    /**
     * Specifies CORS rules for the Table service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the Table service.
     */
    readonly cors?: outputs.storage.v20210901.CorsRulesResponse;
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}

export function getTableServicePropertiesOutput(args: GetTableServicePropertiesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetTableServicePropertiesResult> {
    return pulumi.output(args).apply(a => getTableServiceProperties(a, opts))
}

export interface GetTableServicePropertiesOutputArgs {
    /**
     * The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
     */
    accountName: pulumi.Input<string>;
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the Table Service within the specified storage account. Table Service Name must be 'default'
     */
    tableServiceName: pulumi.Input<string>;
}
