// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function getOnlineDeploymentLogs(args: GetOnlineDeploymentLogsArgs, opts?: pulumi.InvokeOptions): Promise<GetOnlineDeploymentLogsResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:machinelearningservices/v20210301preview:getOnlineDeploymentLogs", {
        "containerType": args.containerType,
        "deploymentName": args.deploymentName,
        "endpointName": args.endpointName,
        "resourceGroupName": args.resourceGroupName,
        "tail": args.tail,
        "workspaceName": args.workspaceName,
    }, opts);
}

export interface GetOnlineDeploymentLogsArgs {
    /**
     * The type of container to retrieve logs from.
     */
    containerType?: string | enums.machinelearningservices.v20210301preview.ContainerType;
    /**
     * The name and identifier for the endpoint.
     */
    deploymentName: string;
    /**
     * Inference endpoint name.
     */
    endpointName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * The maximum number of lines to tail.
     */
    tail?: number;
    /**
     * Name of Azure Machine Learning workspace.
     */
    workspaceName: string;
}

export interface GetOnlineDeploymentLogsResult {
    /**
     * The retrieved online deployment logs.
     */
    readonly content?: string;
}

export function getOnlineDeploymentLogsOutput(args: GetOnlineDeploymentLogsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetOnlineDeploymentLogsResult> {
    return pulumi.output(args).apply(a => getOnlineDeploymentLogs(a, opts))
}

export interface GetOnlineDeploymentLogsOutputArgs {
    /**
     * The type of container to retrieve logs from.
     */
    containerType?: pulumi.Input<string | enums.machinelearningservices.v20210301preview.ContainerType>;
    /**
     * The name and identifier for the endpoint.
     */
    deploymentName: pulumi.Input<string>;
    /**
     * Inference endpoint name.
     */
    endpointName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The maximum number of lines to tail.
     */
    tail?: pulumi.Input<number>;
    /**
     * Name of Azure Machine Learning workspace.
     */
    workspaceName: pulumi.Input<string>;
}
