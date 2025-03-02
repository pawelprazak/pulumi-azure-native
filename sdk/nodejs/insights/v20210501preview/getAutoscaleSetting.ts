// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * The autoscale setting resource.
 */
export function getAutoscaleSetting(args: GetAutoscaleSettingArgs, opts?: pulumi.InvokeOptions): Promise<GetAutoscaleSettingResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:insights/v20210501preview:getAutoscaleSetting", {
        "autoscaleSettingName": args.autoscaleSettingName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetAutoscaleSettingArgs {
    /**
     * The autoscale setting name.
     */
    autoscaleSettingName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
}

/**
 * The autoscale setting resource.
 */
export interface GetAutoscaleSettingResult {
    /**
     * the enabled flag. Specifies whether automatic scaling is enabled for the resource. The default value is 'true'.
     */
    readonly enabled?: boolean;
    /**
     * Azure resource Id
     */
    readonly id: string;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * the name of the autoscale setting.
     */
    readonly name: string;
    /**
     * the collection of notifications.
     */
    readonly notifications?: outputs.insights.v20210501preview.AutoscaleNotificationResponse[];
    /**
     * the predictive autoscale policy mode.
     */
    readonly predictiveAutoscalePolicy?: outputs.insights.v20210501preview.PredictiveAutoscalePolicyResponse;
    /**
     * the collection of automatic scaling profiles that specify different scaling parameters for different time periods. A maximum of 20 profiles can be specified.
     */
    readonly profiles: outputs.insights.v20210501preview.AutoscaleProfileResponse[];
    /**
     * The system metadata related to the response.
     */
    readonly systemData: outputs.insights.v20210501preview.SystemDataResponse;
    /**
     * Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater in length than 128 characters and a value no greater in length than 256 characters.
     */
    readonly tags?: {[key: string]: string};
    /**
     * the location of the resource that the autoscale setting should be added to.
     */
    readonly targetResourceLocation?: string;
    /**
     * the resource identifier of the resource that the autoscale setting should be added to.
     */
    readonly targetResourceUri?: string;
    /**
     * Azure resource type
     */
    readonly type: string;
}

export function getAutoscaleSettingOutput(args: GetAutoscaleSettingOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAutoscaleSettingResult> {
    return pulumi.output(args).apply(a => getAutoscaleSetting(a, opts))
}

export interface GetAutoscaleSettingOutputArgs {
    /**
     * The autoscale setting name.
     */
    autoscaleSettingName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
}
