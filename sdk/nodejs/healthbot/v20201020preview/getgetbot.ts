// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * HealthBot resource definition
 */
/** @deprecated Version 2020-10-20-preview will be removed in v2 of the provider. */
export function getgetbot(args: GetgetbotArgs, opts?: pulumi.InvokeOptions): Promise<GetgetbotResult> {
    pulumi.log.warn("getgetbot is deprecated: Version 2020-10-20-preview will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:healthbot/v20201020preview:getgetbot", {
        "resourceGroupName": args.resourceGroupName,
        "resourceName": args.resourceName,
    }, opts);
}

export interface GetgetbotArgs {
    /**
     * The name of the Bot resource group in the user subscription.
     */
    resourceGroupName: string;
    /**
     * The name of the Bot resource.
     */
    resourceName: string;
}

/**
 * HealthBot resource definition
 */
export interface GetgetbotResult {
    /**
     * Fully qualified resource Id for the resource.
     */
    readonly id: string;
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The set of properties specific to healthcare bot resource.
     */
    readonly properties: outputs.healthbot.v20201020preview.HealthBotPropertiesResponse;
    /**
     * SKU of the HealthBot.
     */
    readonly sku?: outputs.healthbot.v20201020preview.SkuResponse;
    /**
     * Metadata pertaining to creation and last modification of the resource
     */
    readonly systemData: outputs.healthbot.v20201020preview.SystemDataResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource.
     */
    readonly type: string;
}

export function getgetbotOutput(args: GetgetbotOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetgetbotResult> {
    return pulumi.output(args).apply(a => getgetbot(a, opts))
}

export interface GetgetbotOutputArgs {
    /**
     * The name of the Bot resource group in the user subscription.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the Bot resource.
     */
    resourceName: pulumi.Input<string>;
}
