// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * String dictionary resource.
 */
export function listWebAppMetadata(args: ListWebAppMetadataArgs, opts?: pulumi.InvokeOptions): Promise<ListWebAppMetadataResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:web/v20201001:listWebAppMetadata", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListWebAppMetadataArgs {
    /**
     * Name of the app.
     */
    name: string;
    /**
     * Name of the resource group to which the resource belongs.
     */
    resourceGroupName: string;
}

/**
 * String dictionary resource.
 */
export interface ListWebAppMetadataResult {
    /**
     * Resource Id.
     */
    readonly id: string;
    /**
     * Kind of resource.
     */
    readonly kind?: string;
    /**
     * Resource Name.
     */
    readonly name: string;
    /**
     * Settings.
     */
    readonly properties: {[key: string]: string};
    /**
     * The system metadata relating to this resource.
     */
    readonly systemData: outputs.web.v20201001.SystemDataResponse;
    /**
     * Resource type.
     */
    readonly type: string;
}

export function listWebAppMetadataOutput(args: ListWebAppMetadataOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListWebAppMetadataResult> {
    return pulumi.output(args).apply(a => listWebAppMetadata(a, opts))
}

export interface ListWebAppMetadataOutputArgs {
    /**
     * Name of the app.
     */
    name: pulumi.Input<string>;
    /**
     * Name of the resource group to which the resource belongs.
     */
    resourceGroupName: pulumi.Input<string>;
}
