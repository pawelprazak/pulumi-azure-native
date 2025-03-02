// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * The list of credential result response.
 */
export function listConnectedClusterUserCredential(args: ListConnectedClusterUserCredentialArgs, opts?: pulumi.InvokeOptions): Promise<ListConnectedClusterUserCredentialResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:kubernetes/v20220501preview:listConnectedClusterUserCredential", {
        "authenticationMethod": args.authenticationMethod,
        "clientProxy": args.clientProxy,
        "clusterName": args.clusterName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListConnectedClusterUserCredentialArgs {
    /**
     * The mode of client authentication.
     */
    authenticationMethod: string | enums.kubernetes.v20220501preview.AuthenticationMethod;
    /**
     * Boolean value to indicate whether the request is for client side proxy or not
     */
    clientProxy: boolean;
    /**
     * The name of the Kubernetes cluster on which get is called.
     */
    clusterName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
}

/**
 * The list of credential result response.
 */
export interface ListConnectedClusterUserCredentialResult {
    /**
     * Contains the REP (rendezvous endpoint) and “Sender” access token.
     */
    readonly hybridConnectionConfig: outputs.kubernetes.v20220501preview.HybridConnectionConfigResponse;
    /**
     * Base64-encoded Kubernetes configuration file.
     */
    readonly kubeconfigs: outputs.kubernetes.v20220501preview.CredentialResultResponse[];
}

export function listConnectedClusterUserCredentialOutput(args: ListConnectedClusterUserCredentialOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListConnectedClusterUserCredentialResult> {
    return pulumi.output(args).apply(a => listConnectedClusterUserCredential(a, opts))
}

export interface ListConnectedClusterUserCredentialOutputArgs {
    /**
     * The mode of client authentication.
     */
    authenticationMethod: pulumi.Input<string | enums.kubernetes.v20220501preview.AuthenticationMethod>;
    /**
     * Boolean value to indicate whether the request is for client side proxy or not
     */
    clientProxy: pulumi.Input<boolean>;
    /**
     * The name of the Kubernetes cluster on which get is called.
     */
    clusterName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
}
