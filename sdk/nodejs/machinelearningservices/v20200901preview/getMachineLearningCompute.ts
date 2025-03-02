// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Machine Learning compute object wrapped into ARM resource envelope.
 */
export function getMachineLearningCompute(args: GetMachineLearningComputeArgs, opts?: pulumi.InvokeOptions): Promise<GetMachineLearningComputeResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:machinelearningservices/v20200901preview:getMachineLearningCompute", {
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
    readonly identity?: outputs.machinelearningservices.v20200901preview.IdentityResponse;
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
    readonly properties: outputs.machinelearningservices.v20200901preview.AKSResponse | outputs.machinelearningservices.v20200901preview.AmlComputeResponse | outputs.machinelearningservices.v20200901preview.ComputeInstanceResponse | outputs.machinelearningservices.v20200901preview.DataFactoryResponse | outputs.machinelearningservices.v20200901preview.DataLakeAnalyticsResponse | outputs.machinelearningservices.v20200901preview.DatabricksResponse | outputs.machinelearningservices.v20200901preview.HDInsightResponse | outputs.machinelearningservices.v20200901preview.VirtualMachineResponse;
    /**
     * The sku of the workspace.
     */
    readonly sku?: outputs.machinelearningservices.v20200901preview.SkuResponse;
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
