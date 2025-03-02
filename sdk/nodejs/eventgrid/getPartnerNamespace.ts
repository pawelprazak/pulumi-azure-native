// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * EventGrid Partner Namespace.
 * API Version: 2021-06-01-preview.
 */
export function getPartnerNamespace(args: GetPartnerNamespaceArgs, opts?: pulumi.InvokeOptions): Promise<GetPartnerNamespaceResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:eventgrid:getPartnerNamespace", {
        "partnerNamespaceName": args.partnerNamespaceName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetPartnerNamespaceArgs {
    /**
     * Name of the partner namespace.
     */
    partnerNamespaceName: string;
    /**
     * The name of the resource group within the user's subscription.
     */
    resourceGroupName: string;
}

/**
 * EventGrid Partner Namespace.
 */
export interface GetPartnerNamespaceResult {
    /**
     * This boolean is used to enable or disable local auth. Default value is false. When the property is set to true, only AAD token will be used to authenticate if user is allowed to publish to the partner namespace.
     */
    readonly disableLocalAuth?: boolean;
    /**
     * Endpoint for the partner namespace.
     */
    readonly endpoint: string;
    /**
     * Fully qualified identifier of the resource.
     */
    readonly id: string;
    /**
     * This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered only if PublicNetworkAccess is enabled.
     */
    readonly inboundIpRules?: outputs.eventgrid.InboundIpRuleResponse[];
    /**
     * Location of the resource.
     */
    readonly location: string;
    /**
     * Name of the resource.
     */
    readonly name: string;
    /**
     * The fully qualified ARM Id of the partner registration that should be associated with this partner namespace. This takes the following format:
     * /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerRegistrations/{partnerRegistrationName}.
     */
    readonly partnerRegistrationFullyQualifiedId?: string;
    readonly privateEndpointConnections: outputs.eventgrid.PrivateEndpointConnectionResponse[];
    /**
     * Provisioning state of the partner namespace.
     */
    readonly provisioningState: string;
    /**
     * This determines if traffic is allowed over public network. By default it is enabled.
     * You can further restrict to specific IPs by configuring <seealso cref="P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.PartnerNamespaceProperties.InboundIpRules" />
     */
    readonly publicNetworkAccess?: string;
    /**
     * The system metadata relating to Partner Namespace resource.
     */
    readonly systemData: outputs.eventgrid.SystemDataResponse;
    /**
     * Tags of the resource.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Type of the resource.
     */
    readonly type: string;
}

export function getPartnerNamespaceOutput(args: GetPartnerNamespaceOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetPartnerNamespaceResult> {
    return pulumi.output(args).apply(a => getPartnerNamespace(a, opts))
}

export interface GetPartnerNamespaceOutputArgs {
    /**
     * Name of the partner namespace.
     */
    partnerNamespaceName: pulumi.Input<string>;
    /**
     * The name of the resource group within the user's subscription.
     */
    resourceGroupName: pulumi.Input<string>;
}
