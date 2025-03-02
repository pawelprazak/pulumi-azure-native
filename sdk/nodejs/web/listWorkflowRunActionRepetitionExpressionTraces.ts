// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * The expression traces.
 * API Version: 2022-03-01.
 */
export function listWorkflowRunActionRepetitionExpressionTraces(args: ListWorkflowRunActionRepetitionExpressionTracesArgs, opts?: pulumi.InvokeOptions): Promise<ListWorkflowRunActionRepetitionExpressionTracesResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:web:listWorkflowRunActionRepetitionExpressionTraces", {
        "actionName": args.actionName,
        "name": args.name,
        "repetitionName": args.repetitionName,
        "resourceGroupName": args.resourceGroupName,
        "runName": args.runName,
        "workflowName": args.workflowName,
    }, opts);
}

export interface ListWorkflowRunActionRepetitionExpressionTracesArgs {
    /**
     * The workflow action name.
     */
    actionName: string;
    /**
     * Site name.
     */
    name: string;
    /**
     * The workflow repetition.
     */
    repetitionName: string;
    /**
     * Name of the resource group to which the resource belongs.
     */
    resourceGroupName: string;
    /**
     * The workflow run name.
     */
    runName: string;
    /**
     * The workflow name.
     */
    workflowName: string;
}

/**
 * The expression traces.
 */
export interface ListWorkflowRunActionRepetitionExpressionTracesResult {
    readonly inputs?: outputs.web.ExpressionRootResponse[];
    /**
     * The link used to get the next page of recommendations.
     */
    readonly nextLink?: string;
    readonly value?: any;
}

export function listWorkflowRunActionRepetitionExpressionTracesOutput(args: ListWorkflowRunActionRepetitionExpressionTracesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListWorkflowRunActionRepetitionExpressionTracesResult> {
    return pulumi.output(args).apply(a => listWorkflowRunActionRepetitionExpressionTraces(a, opts))
}

export interface ListWorkflowRunActionRepetitionExpressionTracesOutputArgs {
    /**
     * The workflow action name.
     */
    actionName: pulumi.Input<string>;
    /**
     * Site name.
     */
    name: pulumi.Input<string>;
    /**
     * The workflow repetition.
     */
    repetitionName: pulumi.Input<string>;
    /**
     * Name of the resource group to which the resource belongs.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The workflow run name.
     */
    runName: pulumi.Input<string>;
    /**
     * The workflow name.
     */
    workflowName: pulumi.Input<string>;
}
