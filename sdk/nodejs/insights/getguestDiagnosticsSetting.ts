// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Virtual machine guest diagnostics settings resource.
 * API Version: 2018-06-01-preview.
 */
export function getguestDiagnosticsSetting(args: GetguestDiagnosticsSettingArgs, opts?: pulumi.InvokeOptions): Promise<GetguestDiagnosticsSettingResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:insights:getguestDiagnosticsSetting", {
        "diagnosticSettingsName": args.diagnosticSettingsName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetguestDiagnosticsSettingArgs {
    /**
     * The name of the diagnostic setting.
     */
    diagnosticSettingsName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
}

/**
 * Virtual machine guest diagnostics settings resource.
 */
export interface GetguestDiagnosticsSettingResult {
    /**
     * the array of data source object which are configured to collect and send data
     */
    readonly dataSources?: outputs.insights.DataSourceResponse[];
    /**
     * Azure resource Id
     */
    readonly id: string;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Azure resource name
     */
    readonly name: string;
    /**
     * Operating system type for the configuration
     */
    readonly osType?: string;
    readonly proxySetting?: string;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Azure resource type
     */
    readonly type: string;
}

export function getguestDiagnosticsSettingOutput(args: GetguestDiagnosticsSettingOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetguestDiagnosticsSettingResult> {
    return pulumi.output(args).apply(a => getguestDiagnosticsSetting(a, opts))
}

export interface GetguestDiagnosticsSettingOutputArgs {
    /**
     * The name of the diagnostic setting.
     */
    diagnosticSettingsName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
}
