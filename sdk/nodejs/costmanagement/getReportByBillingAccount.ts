// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * A report resource.
 * API Version: 2018-08-01-preview.
 */
export function getReportByBillingAccount(args: GetReportByBillingAccountArgs, opts?: pulumi.InvokeOptions): Promise<GetReportByBillingAccountResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:costmanagement:getReportByBillingAccount", {
        "billingAccountId": args.billingAccountId,
        "reportName": args.reportName,
    }, opts);
}

export interface GetReportByBillingAccountArgs {
    /**
     * BillingAccount ID
     */
    billingAccountId: string;
    /**
     * Report Name.
     */
    reportName: string;
}

/**
 * A report resource.
 */
export interface GetReportByBillingAccountResult {
    /**
     * Has definition for the report.
     */
    readonly definition: outputs.costmanagement.ReportDefinitionResponse;
    /**
     * Has delivery information for the report.
     */
    readonly deliveryInfo: outputs.costmanagement.ReportDeliveryInfoResponse;
    /**
     * The format of the report being delivered.
     */
    readonly format?: string;
    /**
     * Resource Id.
     */
    readonly id: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Has schedule information for the report.
     */
    readonly schedule?: outputs.costmanagement.ReportScheduleResponse;
    /**
     * Resource tags.
     */
    readonly tags: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
}

export function getReportByBillingAccountOutput(args: GetReportByBillingAccountOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetReportByBillingAccountResult> {
    return pulumi.output(args).apply(a => getReportByBillingAccount(a, opts))
}

export interface GetReportByBillingAccountOutputArgs {
    /**
     * BillingAccount ID
     */
    billingAccountId: pulumi.Input<string>;
    /**
     * Report Name.
     */
    reportName: pulumi.Input<string>;
}
