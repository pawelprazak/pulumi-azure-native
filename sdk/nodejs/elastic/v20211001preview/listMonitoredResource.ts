// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Response of a list operation.
 */
export function listMonitoredResource(args: ListMonitoredResourceArgs, opts?: pulumi.InvokeOptions): Promise<ListMonitoredResourceResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:elastic/v20211001preview:listMonitoredResource", {
        "monitorName": args.monitorName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListMonitoredResourceArgs {
    /**
     * Monitor resource name
     */
    monitorName: string;
    /**
     * The name of the resource group to which the Elastic resource belongs.
     */
    resourceGroupName: string;
}

/**
 * Response of a list operation.
 */
export interface ListMonitoredResourceResult {
    /**
     * Link to the next set of results, if any.
     */
    readonly nextLink?: string;
    /**
     * Results of a list operation.
     */
    readonly value?: outputs.elastic.v20211001preview.MonitoredResourceResponse[];
}

export function listMonitoredResourceOutput(args: ListMonitoredResourceOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListMonitoredResourceResult> {
    return pulumi.output(args).apply(a => listMonitoredResource(a, opts))
}

export interface ListMonitoredResourceOutputArgs {
    /**
     * Monitor resource name
     */
    monitorName: pulumi.Input<string>;
    /**
     * The name of the resource group to which the Elastic resource belongs.
     */
    resourceGroupName: pulumi.Input<string>;
}
