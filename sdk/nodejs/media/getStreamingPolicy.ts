// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * A Streaming Policy resource
 * API Version: 2020-05-01.
 */
export function getStreamingPolicy(args: GetStreamingPolicyArgs, opts?: pulumi.InvokeOptions): Promise<GetStreamingPolicyResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:media:getStreamingPolicy", {
        "accountName": args.accountName,
        "resourceGroupName": args.resourceGroupName,
        "streamingPolicyName": args.streamingPolicyName,
    }, opts);
}

export interface GetStreamingPolicyArgs {
    /**
     * The Media Services account name.
     */
    accountName: string;
    /**
     * The name of the resource group within the Azure subscription.
     */
    resourceGroupName: string;
    /**
     * The Streaming Policy name.
     */
    streamingPolicyName: string;
}

/**
 * A Streaming Policy resource
 */
export interface GetStreamingPolicyResult {
    /**
     * Configuration of CommonEncryptionCbcs
     */
    readonly commonEncryptionCbcs?: outputs.media.CommonEncryptionCbcsResponse;
    /**
     * Configuration of CommonEncryptionCenc
     */
    readonly commonEncryptionCenc?: outputs.media.CommonEncryptionCencResponse;
    /**
     * Creation time of Streaming Policy
     */
    readonly created: string;
    /**
     * Default ContentKey used by current Streaming Policy
     */
    readonly defaultContentKeyPolicyName?: string;
    /**
     * Configuration of EnvelopeEncryption
     */
    readonly envelopeEncryption?: outputs.media.EnvelopeEncryptionResponse;
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Configurations of NoEncryption
     */
    readonly noEncryption?: outputs.media.NoEncryptionResponse;
    /**
     * The system metadata relating to this resource.
     */
    readonly systemData: outputs.media.SystemDataResponse;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}

export function getStreamingPolicyOutput(args: GetStreamingPolicyOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetStreamingPolicyResult> {
    return pulumi.output(args).apply(a => getStreamingPolicy(a, opts))
}

export interface GetStreamingPolicyOutputArgs {
    /**
     * The Media Services account name.
     */
    accountName: pulumi.Input<string>;
    /**
     * The name of the resource group within the Azure subscription.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The Streaming Policy name.
     */
    streamingPolicyName: pulumi.Input<string>;
}
