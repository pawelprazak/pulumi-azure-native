// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * The List Cluster User Credential appliance.
 */
export function listApplianceClusterUserCredential(args: ListApplianceClusterUserCredentialArgs, opts?: pulumi.InvokeOptions): Promise<ListApplianceClusterUserCredentialResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:resourceconnector/v20220415preview:listApplianceClusterUserCredential", {
        "resourceGroupName": args.resourceGroupName,
        "resourceName": args.resourceName,
    }, opts);
}

export interface ListApplianceClusterUserCredentialArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * Appliances name.
     */
    resourceName: string;
}

/**
 * The List Cluster User Credential appliance.
 */
export interface ListApplianceClusterUserCredentialResult {
    /**
     * Contains the REP (rendezvous endpoint) and “Listener” access token from notification service (NS).
     */
    readonly hybridConnectionConfig: outputs.resourceconnector.v20220415preview.HybridConnectionConfigResponse;
    /**
     * The list of appliance kubeconfigs.
     */
    readonly kubeconfigs: outputs.resourceconnector.v20220415preview.ApplianceCredentialKubeconfigResponse[];
}

export function listApplianceClusterUserCredentialOutput(args: ListApplianceClusterUserCredentialOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListApplianceClusterUserCredentialResult> {
    return pulumi.output(args).apply(a => listApplianceClusterUserCredential(a, opts))
}

export interface ListApplianceClusterUserCredentialOutputArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Appliances name.
     */
    resourceName: pulumi.Input<string>;
}
