// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * The Streaming Locators associated with this Asset.
 */
export function listAssetStreamingLocators(args: ListAssetStreamingLocatorsArgs, opts?: pulumi.InvokeOptions): Promise<ListAssetStreamingLocatorsResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:media/v20211101:listAssetStreamingLocators", {
        "accountName": args.accountName,
        "assetName": args.assetName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListAssetStreamingLocatorsArgs {
    /**
     * The Media Services account name.
     */
    accountName: string;
    /**
     * The Asset name.
     */
    assetName: string;
    /**
     * The name of the resource group within the Azure subscription.
     */
    resourceGroupName: string;
}

/**
 * The Streaming Locators associated with this Asset.
 */
export interface ListAssetStreamingLocatorsResult {
    /**
     * The list of Streaming Locators.
     */
    readonly streamingLocators: outputs.media.v20211101.AssetStreamingLocatorResponse[];
}

export function listAssetStreamingLocatorsOutput(args: ListAssetStreamingLocatorsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListAssetStreamingLocatorsResult> {
    return pulumi.output(args).apply(a => listAssetStreamingLocators(a, opts))
}

export interface ListAssetStreamingLocatorsOutputArgs {
    /**
     * The Media Services account name.
     */
    accountName: pulumi.Input<string>;
    /**
     * The Asset name.
     */
    assetName: pulumi.Input<string>;
    /**
     * The name of the resource group within the Azure subscription.
     */
    resourceGroupName: pulumi.Input<string>;
}
