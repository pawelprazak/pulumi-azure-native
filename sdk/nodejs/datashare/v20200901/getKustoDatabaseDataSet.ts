// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * A kusto database data set.
 */
export function getKustoDatabaseDataSet(args: GetKustoDatabaseDataSetArgs, opts?: pulumi.InvokeOptions): Promise<GetKustoDatabaseDataSetResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:datashare/v20200901:getKustoDatabaseDataSet", {
        "accountName": args.accountName,
        "dataSetName": args.dataSetName,
        "resourceGroupName": args.resourceGroupName,
        "shareName": args.shareName,
    }, opts);
}

export interface GetKustoDatabaseDataSetArgs {
    /**
     * The name of the share account.
     */
    accountName: string;
    /**
     * The name of the dataSet.
     */
    dataSetName: string;
    /**
     * The resource group name.
     */
    resourceGroupName: string;
    /**
     * The name of the share.
     */
    shareName: string;
}

/**
 * A kusto database data set.
 */
export interface GetKustoDatabaseDataSetResult {
    /**
     * Unique id for identifying a data set resource
     */
    readonly dataSetId: string;
    /**
     * The resource id of the azure resource
     */
    readonly id: string;
    /**
     * Kind of data set.
     * Expected value is 'KustoDatabase'.
     */
    readonly kind: "KustoDatabase";
    /**
     * Resource id of the kusto database.
     */
    readonly kustoDatabaseResourceId: string;
    /**
     * Location of the kusto cluster.
     */
    readonly location: string;
    /**
     * Name of the azure resource
     */
    readonly name: string;
    /**
     * Provisioning state of the kusto database data set.
     */
    readonly provisioningState: string;
    /**
     * System Data of the Azure resource.
     */
    readonly systemData: outputs.datashare.v20200901.SystemDataResponse;
    /**
     * Type of the azure resource
     */
    readonly type: string;
}

export function getKustoDatabaseDataSetOutput(args: GetKustoDatabaseDataSetOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetKustoDatabaseDataSetResult> {
    return pulumi.output(args).apply(a => getKustoDatabaseDataSet(a, opts))
}

export interface GetKustoDatabaseDataSetOutputArgs {
    /**
     * The name of the share account.
     */
    accountName: pulumi.Input<string>;
    /**
     * The name of the dataSet.
     */
    dataSetName: pulumi.Input<string>;
    /**
     * The resource group name.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the share.
     */
    shareName: pulumi.Input<string>;
}
