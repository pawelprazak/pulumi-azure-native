// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Azure Resource Manager resource envelope.
 */
export function getDataVersion(args: GetDataVersionArgs, opts?: pulumi.InvokeOptions): Promise<GetDataVersionResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:machinelearningservices/v20210301preview:getDataVersion", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
        "version": args.version,
        "workspaceName": args.workspaceName,
    }, opts);
}

export interface GetDataVersionArgs {
    /**
     * Container name.
     */
    name: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * Version identifier.
     */
    version: string;
    /**
     * Name of Azure Machine Learning workspace.
     */
    workspaceName: string;
}

/**
 * Azure Resource Manager resource envelope.
 */
export interface GetDataVersionResult {
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * [Required] Additional attributes of the entity.
     */
    readonly properties: outputs.machinelearningservices.v20210301preview.DataVersionResponse;
    /**
     * System data associated with resource provider
     */
    readonly systemData: outputs.machinelearningservices.v20210301preview.SystemDataResponse;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}

export function getDataVersionOutput(args: GetDataVersionOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDataVersionResult> {
    return pulumi.output(args).apply(a => getDataVersion(a, opts))
}

export interface GetDataVersionOutputArgs {
    /**
     * Container name.
     */
    name: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Version identifier.
     */
    version: pulumi.Input<string>;
    /**
     * Name of Azure Machine Learning workspace.
     */
    workspaceName: pulumi.Input<string>;
}
