// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * The metric alert resource.
 * API Version: 2018-03-01.
 */
export function getMetricAlert(args: GetMetricAlertArgs, opts?: pulumi.InvokeOptions): Promise<GetMetricAlertResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:insights:getMetricAlert", {
        "resourceGroupName": args.resourceGroupName,
        "ruleName": args.ruleName,
    }, opts);
}

export interface GetMetricAlertArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * The name of the rule.
     */
    ruleName: string;
}

/**
 * The metric alert resource.
 */
export interface GetMetricAlertResult {
    /**
     * the array of actions that are performed when the alert rule becomes active, and when an alert condition is resolved.
     */
    readonly actions?: outputs.insights.MetricAlertActionResponse[];
    /**
     * the flag that indicates whether the alert should be auto resolved or not. The default is true.
     */
    readonly autoMitigate?: boolean;
    /**
     * defines the specific alert criteria information.
     */
    readonly criteria: outputs.insights.MetricAlertMultipleResourceMultipleMetricCriteriaResponse | outputs.insights.MetricAlertSingleResourceMultipleMetricCriteriaResponse | outputs.insights.WebtestLocationAvailabilityCriteriaResponse;
    /**
     * the description of the metric alert that will be included in the alert email.
     */
    readonly description?: string;
    /**
     * the flag that indicates whether the metric alert is enabled.
     */
    readonly enabled: boolean;
    /**
     * how often the metric alert is evaluated represented in ISO 8601 duration format.
     */
    readonly evaluationFrequency: string;
    /**
     * Azure resource Id
     */
    readonly id: string;
    /**
     * the value indicating whether this alert rule is migrated.
     */
    readonly isMigrated: boolean;
    /**
     * Last time the rule was updated in ISO8601 format.
     */
    readonly lastUpdatedTime: string;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Azure resource name
     */
    readonly name: string;
    /**
     * the list of resource id's that this metric alert is scoped to.
     */
    readonly scopes: string[];
    /**
     * Alert severity {0, 1, 2, 3, 4}
     */
    readonly severity: number;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * the region of the target resource(s) on which the alert is created/updated. Mandatory if the scope contains a subscription, resource group, or more than one resource.
     */
    readonly targetResourceRegion?: string;
    /**
     * the resource type of the target resource(s) on which the alert is created/updated. Mandatory if the scope contains a subscription, resource group, or more than one resource.
     */
    readonly targetResourceType?: string;
    /**
     * Azure resource type
     */
    readonly type: string;
    /**
     * the period of time (in ISO 8601 duration format) that is used to monitor alert activity based on the threshold.
     */
    readonly windowSize: string;
}

export function getMetricAlertOutput(args: GetMetricAlertOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetMetricAlertResult> {
    return pulumi.output(args).apply(a => getMetricAlert(a, opts))
}

export interface GetMetricAlertOutputArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the rule.
     */
    ruleName: pulumi.Input<string>;
}
