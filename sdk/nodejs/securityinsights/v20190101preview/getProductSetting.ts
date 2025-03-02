// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * The Setting.
 */
/** @deprecated Please use one of the variants: Anomalies, EntityAnalytics, EyesOn, IPSyncer, Ueba. */
export function getProductSetting(args: GetProductSettingArgs, opts?: pulumi.InvokeOptions): Promise<GetProductSettingResult> {
    pulumi.log.warn("getProductSetting is deprecated: Please use one of the variants: Anomalies, EntityAnalytics, EyesOn, IPSyncer, Ueba.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:securityinsights/v20190101preview:getProductSetting", {
        "operationalInsightsResourceProvider": args.operationalInsightsResourceProvider,
        "resourceGroupName": args.resourceGroupName,
        "settingsName": args.settingsName,
        "workspaceName": args.workspaceName,
    }, opts);
}

export interface GetProductSettingArgs {
    /**
     * The namespace of workspaces resource provider- Microsoft.OperationalInsights.
     */
    operationalInsightsResourceProvider: string;
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * The setting name. Supports - Anomalies, EyesOn, EntityAnalytics, Ueba
     */
    settingsName: string;
    /**
     * The name of the workspace.
     */
    workspaceName: string;
}

/**
 * The Setting.
 */
export interface GetProductSettingResult {
    /**
     * Etag of the azure resource
     */
    readonly etag?: string;
    /**
     * Azure resource Id
     */
    readonly id: string;
    /**
     * The kind of the setting
     */
    readonly kind: string;
    /**
     * Azure resource name
     */
    readonly name: string;
    /**
     * Azure resource type
     */
    readonly type: string;
}

export function getProductSettingOutput(args: GetProductSettingOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetProductSettingResult> {
    return pulumi.output(args).apply(a => getProductSetting(a, opts))
}

export interface GetProductSettingOutputArgs {
    /**
     * The namespace of workspaces resource provider- Microsoft.OperationalInsights.
     */
    operationalInsightsResourceProvider: pulumi.Input<string>;
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The setting name. Supports - Anomalies, EyesOn, EntityAnalytics, Ueba
     */
    settingsName: pulumi.Input<string>;
    /**
     * The name of the workspace.
     */
    workspaceName: pulumi.Input<string>;
}
