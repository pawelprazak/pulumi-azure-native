// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***


export const CreatedByType = {
    User: "User",
    Application: "Application",
    ManagedIdentity: "ManagedIdentity",
    Key: "Key",
} as const;

/**
 * The type of identity that last modified the resource.
 */
export type CreatedByType = (typeof CreatedByType)[keyof typeof CreatedByType];

export const DiagnosticLevel = {
    Off: "Off",
    Basic: "Basic",
    Enhanced: "Enhanced",
} as const;

/**
 * Desired level of diagnostic data emitted by the cluster.
 */
export type DiagnosticLevel = (typeof DiagnosticLevel)[keyof typeof DiagnosticLevel];

export const WindowsServerSubscription = {
    Disabled: "Disabled",
    Enabled: "Enabled",
} as const;

/**
 * Desired state of Windows Server Subscription.
 */
export type WindowsServerSubscription = (typeof WindowsServerSubscription)[keyof typeof WindowsServerSubscription];
