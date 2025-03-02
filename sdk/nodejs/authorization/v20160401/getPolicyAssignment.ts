// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * The policy assignment.
 */
/** @deprecated Version 2016-04-01 will be removed in v2 of the provider. */
export function getPolicyAssignment(args: GetPolicyAssignmentArgs, opts?: pulumi.InvokeOptions): Promise<GetPolicyAssignmentResult> {
    pulumi.log.warn("getPolicyAssignment is deprecated: Version 2016-04-01 will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:authorization/v20160401:getPolicyAssignment", {
        "policyAssignmentName": args.policyAssignmentName,
        "scope": args.scope,
    }, opts);
}

export interface GetPolicyAssignmentArgs {
    /**
     * The name of the policy assignment to get.
     */
    policyAssignmentName: string;
    /**
     * The scope of the policy assignment.
     */
    scope: string;
}

/**
 * The policy assignment.
 */
export interface GetPolicyAssignmentResult {
    /**
     * The display name of the policy assignment.
     */
    readonly displayName?: string;
    /**
     * The ID of the policy assignment.
     */
    readonly id?: string;
    /**
     * The name of the policy assignment.
     */
    readonly name?: string;
    /**
     * The ID of the policy definition.
     */
    readonly policyDefinitionId?: string;
    /**
     * The scope for the policy assignment.
     */
    readonly scope?: string;
    /**
     * The type of the policy assignment.
     */
    readonly type?: string;
}

export function getPolicyAssignmentOutput(args: GetPolicyAssignmentOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetPolicyAssignmentResult> {
    return pulumi.output(args).apply(a => getPolicyAssignment(a, opts))
}

export interface GetPolicyAssignmentOutputArgs {
    /**
     * The name of the policy assignment to get.
     */
    policyAssignmentName: pulumi.Input<string>;
    /**
     * The scope of the policy assignment.
     */
    scope: pulumi.Input<string>;
}
