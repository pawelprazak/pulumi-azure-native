// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * The Log Search Rule resource.
 * API Version: 2018-04-16.
 */
export function getScheduledQueryRule(args: GetScheduledQueryRuleArgs, opts?: pulumi.InvokeOptions): Promise<GetScheduledQueryRuleResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:insights:getScheduledQueryRule", {
        "resourceGroupName": args.resourceGroupName,
        "ruleName": args.ruleName,
    }, opts);
}

export interface GetScheduledQueryRuleArgs {
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
 * The Log Search Rule resource.
 */
export interface GetScheduledQueryRuleResult {
    /**
     * Action needs to be taken on rule execution.
     */
    readonly action: outputs.insights.AlertingActionResponse | outputs.insights.LogToMetricActionResponse;
    /**
     * The flag that indicates whether the alert should be automatically resolved or not. The default is false.
     */
    readonly autoMitigate?: boolean;
    /**
     * The api-version used when creating this alert rule
     */
    readonly createdWithApiVersion: string;
    /**
     * The description of the Log Search rule.
     */
    readonly description?: string;
    /**
     * The display name of the alert rule
     */
    readonly displayName?: string;
    /**
     * The flag which indicates whether the Log Search rule is enabled. Value should be true or false
     */
    readonly enabled?: string;
    /**
     * The etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. 
     */
    readonly etag: string;
    /**
     * Azure resource Id
     */
    readonly id: string;
    /**
     * True if alert rule is legacy Log Analytic rule
     */
    readonly isLegacyLogAnalyticsRule: boolean;
    /**
     * Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value.
     */
    readonly kind: string;
    /**
     * Last time the rule was updated in IS08601 format.
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
     * Provisioning state of the scheduled query rule
     */
    readonly provisioningState: string;
    /**
     * Schedule (Frequency, Time Window) for rule. Required for action type - AlertingAction
     */
    readonly schedule?: outputs.insights.ScheduleResponse;
    /**
     * Data Source against which rule will Query Data
     */
    readonly source: outputs.insights.SourceResponse;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Azure resource type
     */
    readonly type: string;
}

export function getScheduledQueryRuleOutput(args: GetScheduledQueryRuleOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetScheduledQueryRuleResult> {
    return pulumi.output(args).apply(a => getScheduledQueryRule(a, opts))
}

export interface GetScheduledQueryRuleOutputArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the rule.
     */
    ruleName: pulumi.Input<string>;
}
