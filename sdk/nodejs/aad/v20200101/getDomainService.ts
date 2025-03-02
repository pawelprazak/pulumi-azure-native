// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Domain service.
 */
/** @deprecated Version 2020-01-01 will be removed in v2 of the provider. */
export function getDomainService(args: GetDomainServiceArgs, opts?: pulumi.InvokeOptions): Promise<GetDomainServiceResult> {
    pulumi.log.warn("getDomainService is deprecated: Version 2020-01-01 will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:aad/v20200101:getDomainService", {
        "domainServiceName": args.domainServiceName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetDomainServiceArgs {
    /**
     * The name of the domain service.
     */
    domainServiceName: string;
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    resourceGroupName: string;
}

/**
 * Domain service.
 */
export interface GetDomainServiceResult {
    /**
     * Deployment Id
     */
    readonly deploymentId: string;
    /**
     * Domain Configuration Type
     */
    readonly domainConfigurationType?: string;
    /**
     * The name of the Azure domain that the user would like to deploy Domain Services to.
     */
    readonly domainName?: string;
    /**
     * DomainSecurity Settings
     */
    readonly domainSecuritySettings?: outputs.aad.v20200101.DomainSecuritySettingsResponse;
    /**
     * Resource etag
     */
    readonly etag?: string;
    /**
     * Enabled or Disabled flag to turn on Group-based filtered sync
     */
    readonly filteredSync?: string;
    /**
     * Resource Id
     */
    readonly id: string;
    /**
     * Secure LDAP Settings
     */
    readonly ldapsSettings?: outputs.aad.v20200101.LdapsSettingsResponse;
    /**
     * Resource location
     */
    readonly location?: string;
    /**
     * Migration Properties
     */
    readonly migrationProperties: outputs.aad.v20200101.MigrationPropertiesResponse;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Notification Settings
     */
    readonly notificationSettings?: outputs.aad.v20200101.NotificationSettingsResponse;
    /**
     * the current deployment or provisioning state, which only appears in the response.
     */
    readonly provisioningState: string;
    /**
     * List of ReplicaSets
     */
    readonly replicaSets?: outputs.aad.v20200101.ReplicaSetResponse[];
    /**
     * Resource Forest Settings
     */
    readonly resourceForestSettings?: outputs.aad.v20200101.ResourceForestSettingsResponse;
    /**
     * Sku Type
     */
    readonly sku?: string;
    /**
     * SyncOwner ReplicaSet Id
     */
    readonly syncOwner: string;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Azure Active Directory Tenant Id
     */
    readonly tenantId: string;
    /**
     * Resource type
     */
    readonly type: string;
    /**
     * Data Model Version
     */
    readonly version: number;
}

export function getDomainServiceOutput(args: GetDomainServiceOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDomainServiceResult> {
    return pulumi.output(args).apply(a => getDomainService(a, opts))
}

export interface GetDomainServiceOutputArgs {
    /**
     * The name of the domain service.
     */
    domainServiceName: pulumi.Input<string>;
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
}
