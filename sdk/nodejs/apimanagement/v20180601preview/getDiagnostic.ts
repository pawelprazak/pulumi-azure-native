// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Diagnostic details.
 */
export function getDiagnostic(args: GetDiagnosticArgs, opts?: pulumi.InvokeOptions): Promise<GetDiagnosticResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:apimanagement/v20180601preview:getDiagnostic", {
        "diagnosticId": args.diagnosticId,
        "resourceGroupName": args.resourceGroupName,
        "serviceName": args.serviceName,
    }, opts);
}

export interface GetDiagnosticArgs {
    /**
     * Diagnostic identifier. Must be unique in the current API Management service instance.
     */
    diagnosticId: string;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
    /**
     * The name of the API Management service.
     */
    serviceName: string;
}

/**
 * Diagnostic details.
 */
export interface GetDiagnosticResult {
    /**
     * Specifies for what type of messages sampling settings should not apply.
     */
    readonly alwaysLog?: string;
    /**
     * Diagnostic settings for incoming/outgoing HTTP messages to the Backend
     */
    readonly backend?: outputs.apimanagement.v20180601preview.PipelineDiagnosticSettingsResponse;
    /**
     * Whether to process Correlation Headers coming to Api Management Service. Only applicable to Application Insights diagnostics. Default is true.
     */
    readonly enableHttpCorrelationHeaders?: boolean;
    /**
     * Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
     */
    readonly frontend?: outputs.apimanagement.v20180601preview.PipelineDiagnosticSettingsResponse;
    /**
     * Resource ID.
     */
    readonly id: string;
    /**
     * Resource Id of a target logger.
     */
    readonly loggerId: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Sampling settings for Diagnostic.
     */
    readonly sampling?: outputs.apimanagement.v20180601preview.SamplingSettingsResponse;
    /**
     * Resource type for API Management resource.
     */
    readonly type: string;
}

export function getDiagnosticOutput(args: GetDiagnosticOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDiagnosticResult> {
    return pulumi.output(args).apply(a => getDiagnostic(a, opts))
}

export interface GetDiagnosticOutputArgs {
    /**
     * Diagnostic identifier. Must be unique in the current API Management service instance.
     */
    diagnosticId: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the API Management service.
     */
    serviceName: pulumi.Input<string>;
}
