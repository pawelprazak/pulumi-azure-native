// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Container App SourceControl.
 */
export function getContainerAppsSourceControl(args: GetContainerAppsSourceControlArgs, opts?: pulumi.InvokeOptions): Promise<GetContainerAppsSourceControlResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:app/v20220101preview:getContainerAppsSourceControl", {
        "containerAppName": args.containerAppName,
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetContainerAppsSourceControlArgs {
    /**
     * Name of the Container App.
     */
    containerAppName: string;
    /**
     * Name of the Container App SourceControl.
     */
    name: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
}

/**
 * Container App SourceControl.
 */
export interface GetContainerAppsSourceControlResult {
    /**
     * The branch which will trigger the auto deployment
     */
    readonly branch?: string;
    /**
     * Container App Revision Template with all possible settings and the
     * defaults if user did not provide them. The defaults are populated
     * as they were at the creation time
     */
    readonly githubActionConfiguration?: outputs.app.v20220101preview.GithubActionConfigurationResponse;
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Current provisioning State of the operation
     */
    readonly operationState: string;
    /**
     * The repo url which will be integrated to ContainerApp.
     */
    readonly repoUrl?: string;
    /**
     * Azure Resource Manager metadata containing createdBy and modifiedBy information.
     */
    readonly systemData: outputs.app.v20220101preview.SystemDataResponse;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}

export function getContainerAppsSourceControlOutput(args: GetContainerAppsSourceControlOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetContainerAppsSourceControlResult> {
    return pulumi.output(args).apply(a => getContainerAppsSourceControl(a, opts))
}

export interface GetContainerAppsSourceControlOutputArgs {
    /**
     * Name of the Container App.
     */
    containerAppName: pulumi.Input<string>;
    /**
     * Name of the Container App SourceControl.
     */
    name: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
}
