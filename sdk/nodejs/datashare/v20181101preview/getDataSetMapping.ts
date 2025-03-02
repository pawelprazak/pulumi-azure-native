// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * A data set mapping data transfer object.
 */
/** @deprecated Version 2018-11-01-preview will be removed in v2 of the provider. */
export function getDataSetMapping(args: GetDataSetMappingArgs, opts?: pulumi.InvokeOptions): Promise<GetDataSetMappingResult> {
    pulumi.log.warn("getDataSetMapping is deprecated: Version 2018-11-01-preview will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:datashare/v20181101preview:getDataSetMapping", {
        "accountName": args.accountName,
        "dataSetMappingName": args.dataSetMappingName,
        "resourceGroupName": args.resourceGroupName,
        "shareSubscriptionName": args.shareSubscriptionName,
    }, opts);
}

export interface GetDataSetMappingArgs {
    /**
     * The name of the share account.
     */
    accountName: string;
    /**
     * The name of the dataSetMapping.
     */
    dataSetMappingName: string;
    /**
     * The resource group name.
     */
    resourceGroupName: string;
    /**
     * The name of the shareSubscription.
     */
    shareSubscriptionName: string;
}

/**
 * A data set mapping data transfer object.
 */
export interface GetDataSetMappingResult {
    /**
     * The resource id of the azure resource
     */
    readonly id: string;
    /**
     * Kind of data set mapping.
     */
    readonly kind: string;
    /**
     * Name of the azure resource
     */
    readonly name: string;
    /**
     * Type of the azure resource
     */
    readonly type: string;
}

export function getDataSetMappingOutput(args: GetDataSetMappingOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDataSetMappingResult> {
    return pulumi.output(args).apply(a => getDataSetMapping(a, opts))
}

export interface GetDataSetMappingOutputArgs {
    /**
     * The name of the share account.
     */
    accountName: pulumi.Input<string>;
    /**
     * The name of the dataSetMapping.
     */
    dataSetMappingName: pulumi.Input<string>;
    /**
     * The resource group name.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the shareSubscription.
     */
    shareSubscriptionName: pulumi.Input<string>;
}
