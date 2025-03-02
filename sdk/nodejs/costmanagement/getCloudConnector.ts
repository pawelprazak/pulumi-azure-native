// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * The Connector model definition
 * API Version: 2019-03-01-preview.
 */
export function getCloudConnector(args: GetCloudConnectorArgs, opts?: pulumi.InvokeOptions): Promise<GetCloudConnectorResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:costmanagement:getCloudConnector", {
        "connectorName": args.connectorName,
        "expand": args.expand,
    }, opts);
}

export interface GetCloudConnectorArgs {
    /**
     * Connector Name.
     */
    connectorName: string;
    /**
     * May be used to expand the collectionInfo property. By default, collectionInfo is not included.
     */
    expand?: string;
}

/**
 * The Connector model definition
 */
export interface GetCloudConnectorResult {
    /**
     * Connector billing model
     */
    readonly billingModel?: string;
    /**
     * Collection information
     */
    readonly collectionInfo: outputs.costmanagement.ConnectorCollectionInfoResponse;
    /**
     * Connector definition creation datetime
     */
    readonly createdOn: string;
    /**
     * Credentials authentication key (eg AWS ARN)
     */
    readonly credentialsKey?: string;
    /**
     * Number of days remaining of trial
     */
    readonly daysTrialRemaining: number;
    /**
     * Default ManagementGroupId
     */
    readonly defaultManagementGroupId?: string;
    /**
     * Connector DisplayName
     */
    readonly displayName?: string;
    /**
     * Associated ExternalBillingAccountId
     */
    readonly externalBillingAccountId: string;
    /**
     * Connector id
     */
    readonly id: string;
    /**
     * Connector kind (eg aws)
     */
    readonly kind?: string;
    /**
     * Connector last modified datetime
     */
    readonly modifiedOn: string;
    /**
     * Connector name
     */
    readonly name: string;
    /**
     * The display name of the providerBillingAccountId as defined on the external provider
     */
    readonly providerBillingAccountDisplayName: string;
    /**
     * Connector providerBillingAccountId, determined from credentials (eg AWS Consolidated account number)
     */
    readonly providerBillingAccountId: string;
    /**
     * Identifying source report. (For AWS this is a CUR report name, defined with Daily and with Resources)
     */
    readonly reportId?: string;
    /**
     * Connector status
     */
    readonly status: string;
    /**
     * Billing SubscriptionId
     */
    readonly subscriptionId?: string;
    /**
     * Connector type
     */
    readonly type: string;
}

export function getCloudConnectorOutput(args: GetCloudConnectorOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCloudConnectorResult> {
    return pulumi.output(args).apply(a => getCloudConnector(a, opts))
}

export interface GetCloudConnectorOutputArgs {
    /**
     * Connector Name.
     */
    connectorName: pulumi.Input<string>;
    /**
     * May be used to expand the collectionInfo property. By default, collectionInfo is not included.
     */
    expand?: pulumi.Input<string>;
}
