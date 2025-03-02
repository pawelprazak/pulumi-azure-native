// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * An ADLS Gen 2 file system data set.
 */
export function getADLSGen2FileSystemDataSet(args: GetADLSGen2FileSystemDataSetArgs, opts?: pulumi.InvokeOptions): Promise<GetADLSGen2FileSystemDataSetResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:datashare/v20200901:getADLSGen2FileSystemDataSet", {
        "accountName": args.accountName,
        "dataSetName": args.dataSetName,
        "resourceGroupName": args.resourceGroupName,
        "shareName": args.shareName,
    }, opts);
}

export interface GetADLSGen2FileSystemDataSetArgs {
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
 * An ADLS Gen 2 file system data set.
 */
export interface GetADLSGen2FileSystemDataSetResult {
    /**
     * Unique id for identifying a data set resource
     */
    readonly dataSetId: string;
    /**
     * The file system name.
     */
    readonly fileSystem: string;
    /**
     * The resource id of the azure resource
     */
    readonly id: string;
    /**
     * Kind of data set.
     * Expected value is 'AdlsGen2FileSystem'.
     */
    readonly kind: "AdlsGen2FileSystem";
    /**
     * Name of the azure resource
     */
    readonly name: string;
    /**
     * Resource group of storage account
     */
    readonly resourceGroup: string;
    /**
     * Storage account name of the source data set
     */
    readonly storageAccountName: string;
    /**
     * Subscription id of storage account
     */
    readonly subscriptionId: string;
    /**
     * System Data of the Azure resource.
     */
    readonly systemData: outputs.datashare.v20200901.SystemDataResponse;
    /**
     * Type of the azure resource
     */
    readonly type: string;
}

export function getADLSGen2FileSystemDataSetOutput(args: GetADLSGen2FileSystemDataSetOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetADLSGen2FileSystemDataSetResult> {
    return pulumi.output(args).apply(a => getADLSGen2FileSystemDataSet(a, opts))
}

export interface GetADLSGen2FileSystemDataSetOutputArgs {
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
