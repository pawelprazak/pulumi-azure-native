// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Machine Learning compute object wrapped into ARM resource envelope.
 * API Version: 2021-01-01.
 */
export function getMachineLearningCompute(args: GetMachineLearningComputeArgs, opts?: pulumi.InvokeOptions): Promise<GetMachineLearningComputeResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:machinelearningservices:getMachineLearningCompute", {
        "computeName": args.computeName,
        "resourceGroupName": args.resourceGroupName,
        "workspaceName": args.workspaceName,
    }, opts);
}

export interface GetMachineLearningComputeArgs {
    /**
     * Name of the Azure Machine Learning compute.
     */
    computeName: string;
    /**
     * Name of the resource group in which workspace is located.
     */
    resourceGroupName: string;
    /**
     * Name of Azure Machine Learning workspace.
     */
    workspaceName: string;
}

/**
 * Machine Learning compute object wrapped into ARM resource envelope.
 */
export interface GetMachineLearningComputeResult {
    /**
     * Specifies the resource ID.
     */
    readonly id: string;
    /**
     * The identity of the resource.
     */
    readonly identity?: outputs.machinelearningservices.IdentityResponse;
    /**
     * Specifies the location of the resource.
     */
    readonly location?: string;
    /**
     * Specifies the name of the resource.
     */
    readonly name: string;
    /**
     * Compute properties
     */
    readonly properties: outputs.machinelearningservices.AKSResponse | outputs.machinelearningservices.AmlComputeResponse | outputs.machinelearningservices.ComputeInstanceResponse | outputs.machinelearningservices.DataFactoryResponse | outputs.machinelearningservices.DataLakeAnalyticsResponse | outputs.machinelearningservices.DatabricksResponse | outputs.machinelearningservices.HDInsightResponse | outputs.machinelearningservices.VirtualMachineResponse;
    /**
     * The sku of the workspace.
     */
    readonly sku?: outputs.machinelearningservices.SkuResponse;
    /**
     * Read only system data
     */
    readonly systemData: outputs.machinelearningservices.SystemDataResponse;
    /**
     * Contains resource tags defined as key/value pairs.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Specifies the type of the resource.
     */
    readonly type: string;
}

export function getMachineLearningComputeOutput(args: GetMachineLearningComputeOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetMachineLearningComputeResult> {
    return pulumi.output(args).apply(a => getMachineLearningCompute(a, opts))
}

export interface GetMachineLearningComputeOutputArgs {
    /**
     * Name of the Azure Machine Learning compute.
     */
    computeName: pulumi.Input<string>;
    /**
     * Name of the resource group in which workspace is located.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Name of Azure Machine Learning workspace.
     */
    workspaceName: pulumi.Input<string>;
}
