// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

export function getMonitorDefaultKey(args: GetMonitorDefaultKeyArgs, opts?: pulumi.InvokeOptions): Promise<GetMonitorDefaultKeyResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:datadog/v20200201preview:getMonitorDefaultKey", {
        "monitorName": args.monitorName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetMonitorDefaultKeyArgs {
    /**
     * Monitor resource name
     */
    monitorName: string;
    /**
     * The name of the resource group to which the Datadog resource belongs.
     */
    resourceGroupName: string;
}

export interface GetMonitorDefaultKeyResult {
    /**
     * The time of creation of the API key.
     */
    readonly created?: string;
    /**
     * The user that created the API key.
     */
    readonly createdBy?: string;
    /**
     * The value of the API key.
     */
    readonly key: string;
    /**
     * The name of the API key.
     */
    readonly name?: string;
}

export function getMonitorDefaultKeyOutput(args: GetMonitorDefaultKeyOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetMonitorDefaultKeyResult> {
    return pulumi.output(args).apply(a => getMonitorDefaultKey(a, opts))
}

export interface GetMonitorDefaultKeyOutputArgs {
    /**
     * Monitor resource name
     */
    monitorName: pulumi.Input<string>;
    /**
     * The name of the resource group to which the Datadog resource belongs.
     */
    resourceGroupName: pulumi.Input<string>;
}
