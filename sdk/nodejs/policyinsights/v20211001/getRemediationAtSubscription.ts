// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * The remediation definition.
 */
export function getRemediationAtSubscription(args: GetRemediationAtSubscriptionArgs, opts?: pulumi.InvokeOptions): Promise<GetRemediationAtSubscriptionResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:policyinsights/v20211001:getRemediationAtSubscription", {
        "remediationName": args.remediationName,
    }, opts);
}

export interface GetRemediationAtSubscriptionArgs {
    /**
     * The name of the remediation.
     */
    remediationName: string;
}

/**
 * The remediation definition.
 */
export interface GetRemediationAtSubscriptionResult {
    /**
     * The remediation correlation Id. Can be used to find events related to the remediation in the activity log.
     */
    readonly correlationId: string;
    /**
     * The time at which the remediation was created.
     */
    readonly createdOn: string;
    /**
     * The deployment status summary for all deployments created by the remediation.
     */
    readonly deploymentStatus: outputs.policyinsights.v20211001.RemediationDeploymentSummaryResponse;
    /**
     * The remediation failure threshold settings
     */
    readonly failureThreshold?: outputs.policyinsights.v20211001.RemediationPropertiesResponseFailureThreshold;
    /**
     * The filters that will be applied to determine which resources to remediate.
     */
    readonly filters?: outputs.policyinsights.v20211001.RemediationFiltersResponse;
    /**
     * The ID of the remediation.
     */
    readonly id: string;
    /**
     * The time at which the remediation was last updated.
     */
    readonly lastUpdatedOn: string;
    /**
     * The name of the remediation.
     */
    readonly name: string;
    /**
     * Determines how many resources to remediate at any given time. Can be used to increase or reduce the pace of the remediation. If not provided, the default parallel deployments value is used.
     */
    readonly parallelDeployments?: number;
    /**
     * The resource ID of the policy assignment that should be remediated.
     */
    readonly policyAssignmentId?: string;
    /**
     * The policy definition reference ID of the individual definition that should be remediated. Required when the policy assignment being remediated assigns a policy set definition.
     */
    readonly policyDefinitionReferenceId?: string;
    /**
     * The status of the remediation.
     */
    readonly provisioningState: string;
    /**
     * Determines the max number of resources that can be remediated by the remediation job. If not provided, the default resource count is used.
     */
    readonly resourceCount?: number;
    /**
     * The way resources to remediate are discovered. Defaults to ExistingNonCompliant if not specified.
     */
    readonly resourceDiscoveryMode?: string;
    /**
     * The remediation status message. Provides additional details regarding the state of the remediation.
     */
    readonly statusMessage: string;
    /**
     * Azure Resource Manager metadata containing createdBy and modifiedBy information.
     */
    readonly systemData: outputs.policyinsights.v20211001.SystemDataResponse;
    /**
     * The type of the remediation.
     */
    readonly type: string;
}

export function getRemediationAtSubscriptionOutput(args: GetRemediationAtSubscriptionOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetRemediationAtSubscriptionResult> {
    return pulumi.output(args).apply(a => getRemediationAtSubscription(a, opts))
}

export interface GetRemediationAtSubscriptionOutputArgs {
    /**
     * The name of the remediation.
     */
    remediationName: pulumi.Input<string>;
}
