// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Deployment information.
 */
/** @deprecated Version 2016-09-01 will be removed in v2 of the provider. */
export function getDeployment(args: GetDeploymentArgs, opts?: pulumi.InvokeOptions): Promise<GetDeploymentResult> {
    pulumi.log.warn("getDeployment is deprecated: Version 2016-09-01 will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:resources/v20160901:getDeployment", {
        "deploymentName": args.deploymentName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetDeploymentArgs {
    /**
     * The name of the deployment to get.
     */
    deploymentName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
}

/**
 * Deployment information.
 */
export interface GetDeploymentResult {
    /**
     * The ID of the deployment.
     */
    readonly id: string;
    /**
     * The name of the deployment.
     */
    readonly name: string;
    /**
     * Deployment properties.
     */
    readonly properties: outputs.resources.v20160901.DeploymentPropertiesExtendedResponse;
}

export function getDeploymentOutput(args: GetDeploymentOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDeploymentResult> {
    return pulumi.output(args).apply(a => getDeployment(a, opts))
}

export interface GetDeploymentOutputArgs {
    /**
     * The name of the deployment to get.
     */
    deploymentName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
}
