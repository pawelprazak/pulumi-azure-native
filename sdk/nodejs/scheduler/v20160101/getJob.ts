// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/** @deprecated Version 2016-01-01 will be removed in v2 of the provider. */
export function getJob(args: GetJobArgs, opts?: pulumi.InvokeOptions): Promise<GetJobResult> {
    pulumi.log.warn("getJob is deprecated: Version 2016-01-01 will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:scheduler/v20160101:getJob", {
        "jobCollectionName": args.jobCollectionName,
        "jobName": args.jobName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetJobArgs {
    /**
     * The job collection name.
     */
    jobCollectionName: string;
    /**
     * The job name.
     */
    jobName: string;
    /**
     * The resource group name.
     */
    resourceGroupName: string;
}

export interface GetJobResult {
    /**
     * Gets the job resource identifier.
     */
    readonly id: string;
    /**
     * Gets the job resource name.
     */
    readonly name: string;
    /**
     * Gets or sets the job properties.
     */
    readonly properties: outputs.scheduler.v20160101.JobPropertiesResponse;
    /**
     * Gets the job resource type.
     */
    readonly type: string;
}

export function getJobOutput(args: GetJobOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetJobResult> {
    return pulumi.output(args).apply(a => getJob(a, opts))
}

export interface GetJobOutputArgs {
    /**
     * The job collection name.
     */
    jobCollectionName: pulumi.Input<string>;
    /**
     * The job name.
     */
    jobName: pulumi.Input<string>;
    /**
     * The resource group name.
     */
    resourceGroupName: pulumi.Input<string>;
}
