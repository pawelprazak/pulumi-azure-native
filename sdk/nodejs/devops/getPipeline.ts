// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Pipeline used to configure Continuous Integration (CI) & Continuous Delivery (CD) for Azure resources.
 * API Version: 2020-07-13-preview.
 */
export function getPipeline(args: GetPipelineArgs, opts?: pulumi.InvokeOptions): Promise<GetPipelineResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:devops:getPipeline", {
        "pipelineName": args.pipelineName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetPipelineArgs {
    /**
     * The name of the Pipeline resource in ARM.
     */
    pipelineName: string;
    /**
     * Name of the resource group within the Azure subscription.
     */
    resourceGroupName: string;
}

/**
 * Pipeline used to configure Continuous Integration (CI) & Continuous Delivery (CD) for Azure resources.
 */
export interface GetPipelineResult {
    /**
     * Configuration used to bootstrap the Pipeline.
     */
    readonly bootstrapConfiguration: outputs.devops.BootstrapConfigurationResponse;
    /**
     * Resource Id
     */
    readonly id: string;
    /**
     * Resource Location
     */
    readonly location?: string;
    /**
     * Resource Name
     */
    readonly name: string;
    /**
     * Unique identifier of the Pipeline
     */
    readonly pipelineId: number;
    /**
     * Specifies which CI/CD provider to use. Valid options are 'azurePipeline', 'githubWorkflow'.
     */
    readonly pipelineType: string;
    /**
     * The system metadata pertaining to this resource.
     */
    readonly systemData: outputs.devops.SystemDataResponse;
    /**
     * Resource Tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource Type
     */
    readonly type: string;
}

export function getPipelineOutput(args: GetPipelineOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetPipelineResult> {
    return pulumi.output(args).apply(a => getPipeline(a, opts))
}

export interface GetPipelineOutputArgs {
    /**
     * The name of the Pipeline resource in ARM.
     */
    pipelineName: pulumi.Input<string>;
    /**
     * Name of the resource group within the Azure subscription.
     */
    resourceGroupName: pulumi.Input<string>;
}
