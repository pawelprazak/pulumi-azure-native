// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Security ML Analytics Setting
 */
/** @deprecated Please use one of the variants: AnomalySecurityMLAnalyticsSettings. */
export function getSecurityMLAnalyticsSetting(args: GetSecurityMLAnalyticsSettingArgs, opts?: pulumi.InvokeOptions): Promise<GetSecurityMLAnalyticsSettingResult> {
    pulumi.log.warn("getSecurityMLAnalyticsSetting is deprecated: Please use one of the variants: AnomalySecurityMLAnalyticsSettings.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:securityinsights/v20220601preview:getSecurityMLAnalyticsSetting", {
        "resourceGroupName": args.resourceGroupName,
        "settingsResourceName": args.settingsResourceName,
        "workspaceName": args.workspaceName,
    }, opts);
}

export interface GetSecurityMLAnalyticsSettingArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * Security ML Analytics Settings resource name
     */
    settingsResourceName: string;
    /**
     * The name of the workspace.
     */
    workspaceName: string;
}

/**
 * Security ML Analytics Setting
 */
export interface GetSecurityMLAnalyticsSettingResult {
    /**
     * Etag of the azure resource
     */
    readonly etag?: string;
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * The kind of security ML Analytics Settings
     */
    readonly kind: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Azure Resource Manager metadata containing createdBy and modifiedBy information.
     */
    readonly systemData: outputs.securityinsights.v20220601preview.SystemDataResponse;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}

export function getSecurityMLAnalyticsSettingOutput(args: GetSecurityMLAnalyticsSettingOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSecurityMLAnalyticsSettingResult> {
    return pulumi.output(args).apply(a => getSecurityMLAnalyticsSetting(a, opts))
}

export interface GetSecurityMLAnalyticsSettingOutputArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Security ML Analytics Settings resource name
     */
    settingsResourceName: pulumi.Input<string>;
    /**
     * The name of the workspace.
     */
    workspaceName: pulumi.Input<string>;
}
