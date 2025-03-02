// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * A function object, containing all information associated with the named function. All functions are contained under a streaming job.
 */
export function getFunction(args: GetFunctionArgs, opts?: pulumi.InvokeOptions): Promise<GetFunctionResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:streamanalytics/v20211001preview:getFunction", {
        "functionName": args.functionName,
        "jobName": args.jobName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetFunctionArgs {
    /**
     * The name of the function.
     */
    functionName: string;
    /**
     * The name of the streaming job.
     */
    jobName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
}

/**
 * A function object, containing all information associated with the named function. All functions are contained under a streaming job.
 */
export interface GetFunctionResult {
    /**
     * Resource Id
     */
    readonly id: string;
    /**
     * Resource name
     */
    readonly name?: string;
    /**
     * The properties that are associated with a function.
     */
    readonly properties: outputs.streamanalytics.v20211001preview.AggregateFunctionPropertiesResponse | outputs.streamanalytics.v20211001preview.ScalarFunctionPropertiesResponse;
    /**
     * Resource type
     */
    readonly type: string;
}

export function getFunctionOutput(args: GetFunctionOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetFunctionResult> {
    return pulumi.output(args).apply(a => getFunction(a, opts))
}

export interface GetFunctionOutputArgs {
    /**
     * The name of the function.
     */
    functionName: pulumi.Input<string>;
    /**
     * The name of the streaming job.
     */
    jobName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
}
