// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * List of unencrypted credentials for accessing device.
 */
export function listJobCredentials(args: ListJobCredentialsArgs, opts?: pulumi.InvokeOptions): Promise<ListJobCredentialsResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:databox/v20180101:listJobCredentials", {
        "jobName": args.jobName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListJobCredentialsArgs {
    /**
     * The name of the job Resource within the specified resource group. job names must be between 3 and 24 characters in length and use any alphanumeric and underscore only
     */
    jobName: string;
    /**
     * The Resource Group Name
     */
    resourceGroupName: string;
}

/**
 * List of unencrypted credentials for accessing device.
 */
export interface ListJobCredentialsResult {
    /**
     * Link for the next set of unencrypted credentials.
     */
    readonly nextLink?: string;
    /**
     * List of unencrypted credentials.
     */
    readonly value?: outputs.databox.v20180101.UnencryptedCredentialsResponse[];
}

export function listJobCredentialsOutput(args: ListJobCredentialsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListJobCredentialsResult> {
    return pulumi.output(args).apply(a => listJobCredentials(a, opts))
}

export interface ListJobCredentialsOutputArgs {
    /**
     * The name of the job Resource within the specified resource group. job names must be between 3 and 24 characters in length and use any alphanumeric and underscore only
     */
    jobName: pulumi.Input<string>;
    /**
     * The Resource Group Name
     */
    resourceGroupName: pulumi.Input<string>;
}
