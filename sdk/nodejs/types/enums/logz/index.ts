// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// Export sub-modules:
import * as v20201001 from "./v20201001";
import * as v20201001preview from "./v20201001preview";
import * as v20220101preview from "./v20220101preview";

export {
    v20201001,
    v20201001preview,
    v20220101preview,
};

export const ManagedIdentityTypes = {
    SystemAssigned: "SystemAssigned",
    UserAssigned: "UserAssigned",
} as const;

export type ManagedIdentityTypes = (typeof ManagedIdentityTypes)[keyof typeof ManagedIdentityTypes];

export const MarketplaceSubscriptionStatus = {
    Active: "Active",
    Suspended: "Suspended",
} as const;

/**
 * Flag specifying the Marketplace Subscription Status of the resource. If payment is not made in time, the resource will go in Suspended state.
 */
export type MarketplaceSubscriptionStatus = (typeof MarketplaceSubscriptionStatus)[keyof typeof MarketplaceSubscriptionStatus];

export const MonitoringStatus = {
    Enabled: "Enabled",
    Disabled: "Disabled",
} as const;

/**
 * Flag specifying if the resource monitoring is enabled or disabled.
 */
export type MonitoringStatus = (typeof MonitoringStatus)[keyof typeof MonitoringStatus];

export const TagAction = {
    Include: "Include",
    Exclude: "Exclude",
} as const;

/**
 * Valid actions for a filtering tag. Exclusion takes priority over inclusion.
 */
export type TagAction = (typeof TagAction)[keyof typeof TagAction];
