// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * API Version: 2022-04-01-preview.
 */
export function getBillingHubServiceUsage(args: GetBillingHubServiceUsageArgs, opts?: pulumi.InvokeOptions): Promise<GetBillingHubServiceUsageResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:testbase:getBillingHubServiceUsage", {
        "endTimeStamp": args.endTimeStamp,
        "pageIndex": args.pageIndex,
        "pageSize": args.pageSize,
        "resourceGroupName": args.resourceGroupName,
        "startTimeStamp": args.startTimeStamp,
        "testBaseAccountName": args.testBaseAccountName,
    }, opts);
}

export interface GetBillingHubServiceUsageArgs {
    endTimeStamp: string;
    pageIndex?: number;
    pageSize?: number;
    /**
     * The name of the resource group that contains the resource.
     */
    resourceGroupName: string;
    startTimeStamp: string;
    /**
     * The resource name of the Test Base Account.
     */
    testBaseAccountName: string;
}

export interface GetBillingHubServiceUsageResult {
    readonly nextRequest?: outputs.testbase.BillingHubGetUsageRequestResponse;
    readonly packageUsageEntries?: outputs.testbase.BillingHubPackageUsageResponse[];
    readonly totalCharges?: number;
    readonly totalUsedBillableHours?: number;
    readonly totalUsedFreeHours?: number;
}

export function getBillingHubServiceUsageOutput(args: GetBillingHubServiceUsageOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetBillingHubServiceUsageResult> {
    return pulumi.output(args).apply(a => getBillingHubServiceUsage(a, opts))
}

export interface GetBillingHubServiceUsageOutputArgs {
    endTimeStamp: pulumi.Input<string>;
    pageIndex?: pulumi.Input<number>;
    pageSize?: pulumi.Input<number>;
    /**
     * The name of the resource group that contains the resource.
     */
    resourceGroupName: pulumi.Input<string>;
    startTimeStamp: pulumi.Input<string>;
    /**
     * The resource name of the Test Base Account.
     */
    testBaseAccountName: pulumi.Input<string>;
}
