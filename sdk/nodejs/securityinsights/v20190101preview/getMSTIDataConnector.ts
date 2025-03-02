// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Represents Microsoft Threat Intelligence data connector.
 */
export function getMSTIDataConnector(args: GetMSTIDataConnectorArgs, opts?: pulumi.InvokeOptions): Promise<GetMSTIDataConnectorResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:securityinsights/v20190101preview:getMSTIDataConnector", {
        "dataConnectorId": args.dataConnectorId,
        "operationalInsightsResourceProvider": args.operationalInsightsResourceProvider,
        "resourceGroupName": args.resourceGroupName,
        "workspaceName": args.workspaceName,
    }, opts);
}

export interface GetMSTIDataConnectorArgs {
    /**
     * Connector ID
     */
    dataConnectorId: string;
    /**
     * The namespace of workspaces resource provider- Microsoft.OperationalInsights.
     */
    operationalInsightsResourceProvider: string;
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * The name of the workspace.
     */
    workspaceName: string;
}

/**
 * Represents Microsoft Threat Intelligence data connector.
 */
export interface GetMSTIDataConnectorResult {
    /**
     * The available data types for the connector.
     */
    readonly dataTypes: outputs.securityinsights.v20190101preview.MSTIDataConnectorDataTypesResponse;
    /**
     * Etag of the azure resource
     */
    readonly etag?: string;
    /**
     * Azure resource Id
     */
    readonly id: string;
    /**
     *
     * Expected value is 'MicrosoftThreatIntelligence'.
     */
    readonly kind: "MicrosoftThreatIntelligence";
    /**
     * Azure resource name
     */
    readonly name: string;
    /**
     * The tenant id to connect to, and get the data from.
     */
    readonly tenantId: string;
    /**
     * Azure resource type
     */
    readonly type: string;
}

export function getMSTIDataConnectorOutput(args: GetMSTIDataConnectorOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetMSTIDataConnectorResult> {
    return pulumi.output(args).apply(a => getMSTIDataConnector(a, opts))
}

export interface GetMSTIDataConnectorOutputArgs {
    /**
     * Connector ID
     */
    dataConnectorId: pulumi.Input<string>;
    /**
     * The namespace of workspaces resource provider- Microsoft.OperationalInsights.
     */
    operationalInsightsResourceProvider: pulumi.Input<string>;
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the workspace.
     */
    workspaceName: pulumi.Input<string>;
}
