// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * The diagnostic setting resource.
 * API Version: 2017-05-01-preview.
 */
export function getDiagnosticSetting(args: GetDiagnosticSettingArgs, opts?: pulumi.InvokeOptions): Promise<GetDiagnosticSettingResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:insights:getDiagnosticSetting", {
        "name": args.name,
        "resourceUri": args.resourceUri,
    }, opts);
}

export interface GetDiagnosticSettingArgs {
    /**
     * The name of the diagnostic setting.
     */
    name: string;
    /**
     * The identifier of the resource.
     */
    resourceUri: string;
}

/**
 * The diagnostic setting resource.
 */
export interface GetDiagnosticSettingResult {
    /**
     * The resource Id for the event hub authorization rule.
     */
    readonly eventHubAuthorizationRuleId?: string;
    /**
     * The name of the event hub. If none is specified, the default event hub will be selected.
     */
    readonly eventHubName?: string;
    /**
     * Azure resource Id
     */
    readonly id: string;
    /**
     * A string indicating whether the export to Log Analytics should use the default destination type, i.e. AzureDiagnostics, or use a destination type constructed as follows: <normalized service identity>_<normalized category name>. Possible values are: Dedicated and null (null is default.)
     */
    readonly logAnalyticsDestinationType?: string;
    /**
     * The list of logs settings.
     */
    readonly logs?: outputs.insights.LogSettingsResponse[];
    /**
     * The list of metric settings.
     */
    readonly metrics?: outputs.insights.MetricSettingsResponse[];
    /**
     * Azure resource name
     */
    readonly name: string;
    /**
     * The service bus rule Id of the diagnostic setting. This is here to maintain backwards compatibility.
     */
    readonly serviceBusRuleId?: string;
    /**
     * The resource ID of the storage account to which you would like to send Diagnostic Logs.
     */
    readonly storageAccountId?: string;
    /**
     * Azure resource type
     */
    readonly type: string;
    /**
     * The full ARM resource ID of the Log Analytics workspace to which you would like to send Diagnostic Logs. Example: /subscriptions/4b9e8510-67ab-4e9a-95a9-e2f1e570ea9c/resourceGroups/insights-integration/providers/Microsoft.OperationalInsights/workspaces/viruela2
     */
    readonly workspaceId?: string;
}

export function getDiagnosticSettingOutput(args: GetDiagnosticSettingOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDiagnosticSettingResult> {
    return pulumi.output(args).apply(a => getDiagnosticSetting(a, opts))
}

export interface GetDiagnosticSettingOutputArgs {
    /**
     * The name of the diagnostic setting.
     */
    name: pulumi.Input<string>;
    /**
     * The identifier of the resource.
     */
    resourceUri: pulumi.Input<string>;
}
