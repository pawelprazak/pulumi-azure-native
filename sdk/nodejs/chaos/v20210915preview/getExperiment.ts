// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Model that represents a Experiment resource.
 */
export function getExperiment(args: GetExperimentArgs, opts?: pulumi.InvokeOptions): Promise<GetExperimentResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:chaos/v20210915preview:getExperiment", {
        "experimentName": args.experimentName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetExperimentArgs {
    /**
     * String that represents a Experiment resource name.
     */
    experimentName: string;
    /**
     * String that represents an Azure resource group.
     */
    resourceGroupName: string;
}

/**
 * Model that represents a Experiment resource.
 */
export interface GetExperimentResult {
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * The identity of the experiment resource.
     */
    readonly identity?: outputs.chaos.v20210915preview.ResourceIdentityResponse;
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The properties of the experiment resource.
     */
    readonly properties: outputs.chaos.v20210915preview.ExperimentPropertiesResponse;
    /**
     * The system metadata of the experiment resource.
     */
    readonly systemData: outputs.chaos.v20210915preview.SystemDataResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}

export function getExperimentOutput(args: GetExperimentOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetExperimentResult> {
    return pulumi.output(args).apply(a => getExperiment(a, opts))
}

export interface GetExperimentOutputArgs {
    /**
     * String that represents a Experiment resource name.
     */
    experimentName: pulumi.Input<string>;
    /**
     * String that represents an Azure resource group.
     */
    resourceGroupName: pulumi.Input<string>;
}
