// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * A stored credential that can be used by a job to connect to target databases.
 */
export function getJobCredential(args: GetJobCredentialArgs, opts?: pulumi.InvokeOptions): Promise<GetJobCredentialResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:sql/v20210201preview:getJobCredential", {
        "credentialName": args.credentialName,
        "jobAgentName": args.jobAgentName,
        "resourceGroupName": args.resourceGroupName,
        "serverName": args.serverName,
    }, opts);
}

export interface GetJobCredentialArgs {
    /**
     * The name of the credential.
     */
    credentialName: string;
    /**
     * The name of the job agent.
     */
    jobAgentName: string;
    /**
     * The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    resourceGroupName: string;
    /**
     * The name of the server.
     */
    serverName: string;
}

/**
 * A stored credential that can be used by a job to connect to target databases.
 */
export interface GetJobCredentialResult {
    /**
     * Resource ID.
     */
    readonly id: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * The credential user name.
     */
    readonly username: string;
}

export function getJobCredentialOutput(args: GetJobCredentialOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetJobCredentialResult> {
    return pulumi.output(args).apply(a => getJobCredential(a, opts))
}

export interface GetJobCredentialOutputArgs {
    /**
     * The name of the credential.
     */
    credentialName: pulumi.Input<string>;
    /**
     * The name of the job agent.
     */
    jobAgentName: pulumi.Input<string>;
    /**
     * The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the server.
     */
    serverName: pulumi.Input<string>;
}
