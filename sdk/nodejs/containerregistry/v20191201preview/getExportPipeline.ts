// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * An object that represents an export pipeline for a container registry.
 */
export function getExportPipeline(args: GetExportPipelineArgs, opts?: pulumi.InvokeOptions): Promise<GetExportPipelineResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:containerregistry/v20191201preview:getExportPipeline", {
        "exportPipelineName": args.exportPipelineName,
        "registryName": args.registryName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetExportPipelineArgs {
    /**
     * The name of the export pipeline.
     */
    exportPipelineName: string;
    /**
     * The name of the container registry.
     */
    registryName: string;
    /**
     * The name of the resource group to which the container registry belongs.
     */
    resourceGroupName: string;
}

/**
 * An object that represents an export pipeline for a container registry.
 */
export interface GetExportPipelineResult {
    /**
     * The resource ID.
     */
    readonly id: string;
    /**
     * The identity of the export pipeline.
     */
    readonly identity?: outputs.containerregistry.v20191201preview.IdentityPropertiesResponse;
    /**
     * The location of the export pipeline.
     */
    readonly location?: string;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * The list of all options configured for the pipeline.
     */
    readonly options?: string[];
    /**
     * The provisioning state of the pipeline at the time the operation was called.
     */
    readonly provisioningState: string;
    /**
     * Metadata pertaining to creation and last modification of the resource.
     */
    readonly systemData: outputs.containerregistry.v20191201preview.SystemDataResponse;
    /**
     * The target properties of the export pipeline.
     */
    readonly target: outputs.containerregistry.v20191201preview.ExportPipelineTargetPropertiesResponse;
    /**
     * The type of the resource.
     */
    readonly type: string;
}

export function getExportPipelineOutput(args: GetExportPipelineOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetExportPipelineResult> {
    return pulumi.output(args).apply(a => getExportPipeline(a, opts))
}

export interface GetExportPipelineOutputArgs {
    /**
     * The name of the export pipeline.
     */
    exportPipelineName: pulumi.Input<string>;
    /**
     * The name of the container registry.
     */
    registryName: pulumi.Input<string>;
    /**
     * The name of the resource group to which the container registry belongs.
     */
    resourceGroupName: pulumi.Input<string>;
}
