// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * List of deployments for a remediation.
 * API Version: 2019-07-01.
 */
export function listRemediationDeploymentsAtSubscription(args: ListRemediationDeploymentsAtSubscriptionArgs, opts?: pulumi.InvokeOptions): Promise<ListRemediationDeploymentsAtSubscriptionResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:policyinsights:listRemediationDeploymentsAtSubscription", {
        "remediationName": args.remediationName,
        "top": args.top,
    }, opts);
}

export interface ListRemediationDeploymentsAtSubscriptionArgs {
    /**
     * The name of the remediation.
     */
    remediationName: string;
    /**
     * Maximum number of records to return.
     */
    top?: number;
}

/**
 * List of deployments for a remediation.
 */
export interface ListRemediationDeploymentsAtSubscriptionResult {
    /**
     * The URL to get the next set of results.
     */
    readonly nextLink: string;
    /**
     * Array of deployments for the remediation.
     */
    readonly value: outputs.policyinsights.RemediationDeploymentResponse[];
}

export function listRemediationDeploymentsAtSubscriptionOutput(args: ListRemediationDeploymentsAtSubscriptionOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListRemediationDeploymentsAtSubscriptionResult> {
    return pulumi.output(args).apply(a => listRemediationDeploymentsAtSubscription(a, opts))
}

export interface ListRemediationDeploymentsAtSubscriptionOutputArgs {
    /**
     * The name of the remediation.
     */
    remediationName: pulumi.Input<string>;
    /**
     * Maximum number of records to return.
     */
    top?: pulumi.Input<number>;
}
