// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * The Live Output.
 */
export function getLiveOutput(args: GetLiveOutputArgs, opts?: pulumi.InvokeOptions): Promise<GetLiveOutputResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:media/v20211101:getLiveOutput", {
        "accountName": args.accountName,
        "liveEventName": args.liveEventName,
        "liveOutputName": args.liveOutputName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetLiveOutputArgs {
    /**
     * The Media Services account name.
     */
    accountName: string;
    /**
     * The name of the live event, maximum length is 32.
     */
    liveEventName: string;
    /**
     * The name of the live output.
     */
    liveOutputName: string;
    /**
     * The name of the resource group within the Azure subscription.
     */
    resourceGroupName: string;
}

/**
 * The Live Output.
 */
export interface GetLiveOutputResult {
    /**
     * ISO 8601 time between 1 minute to 25 hours to indicate the maximum content length that can be archived in the asset for this live output. This also sets the maximum content length for the rewind window. For example, use PT1H30M to indicate 1 hour and 30 minutes of archive window.
     */
    readonly archiveWindowLength: string;
    /**
     * The asset that the live output will write to.
     */
    readonly assetName: string;
    /**
     * The creation time the live output.
     */
    readonly created: string;
    /**
     * The description of the live output.
     */
    readonly description?: string;
    /**
     * HTTP Live Streaming (HLS) packing setting for the live output.
     */
    readonly hls?: outputs.media.v20211101.HlsResponse;
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * The time the live output was last modified.
     */
    readonly lastModified: string;
    /**
     * The manifest file name. If not provided, the service will generate one automatically.
     */
    readonly manifestName?: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The initial timestamp that the live output will start at, any content before this value will not be archived.
     */
    readonly outputSnapTime?: number;
    /**
     * The provisioning state of the live output.
     */
    readonly provisioningState: string;
    /**
     * The resource state of the live output.
     */
    readonly resourceState: string;
    /**
     * The system metadata relating to this resource.
     */
    readonly systemData: outputs.media.v20211101.SystemDataResponse;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}

export function getLiveOutputOutput(args: GetLiveOutputOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetLiveOutputResult> {
    return pulumi.output(args).apply(a => getLiveOutput(a, opts))
}

export interface GetLiveOutputOutputArgs {
    /**
     * The Media Services account name.
     */
    accountName: pulumi.Input<string>;
    /**
     * The name of the live event, maximum length is 32.
     */
    liveEventName: pulumi.Input<string>;
    /**
     * The name of the live output.
     */
    liveOutputName: pulumi.Input<string>;
    /**
     * The name of the resource group within the Azure subscription.
     */
    resourceGroupName: pulumi.Input<string>;
}
