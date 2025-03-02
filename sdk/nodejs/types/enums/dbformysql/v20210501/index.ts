// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***


export const CreateMode = {
    Default: "Default",
    PointInTimeRestore: "PointInTimeRestore",
    Replica: "Replica",
    GeoRestore: "GeoRestore",
} as const;

/**
 * The mode to create a new MySQL server.
 */
export type CreateMode = (typeof CreateMode)[keyof typeof CreateMode];

export const DataEncryptionType = {
    AzureKeyVault: "AzureKeyVault",
    SystemManaged: "SystemManaged",
} as const;

/**
 * The key type, AzureKeyVault for enable cmk, SystemManaged for disable cmk.
 */
export type DataEncryptionType = (typeof DataEncryptionType)[keyof typeof DataEncryptionType];

export const EnableStatusEnum = {
    Enabled: "Enabled",
    Disabled: "Disabled",
} as const;

/**
 * Enable Storage Auto Grow or not.
 */
export type EnableStatusEnum = (typeof EnableStatusEnum)[keyof typeof EnableStatusEnum];

export const HighAvailabilityMode = {
    Disabled: "Disabled",
    ZoneRedundant: "ZoneRedundant",
    SameZone: "SameZone",
} as const;

/**
 * High availability mode for a server.
 */
export type HighAvailabilityMode = (typeof HighAvailabilityMode)[keyof typeof HighAvailabilityMode];

export const ManagedServiceIdentityType = {
    UserAssigned: "UserAssigned",
} as const;

/**
 * Type of managed service identity.
 */
export type ManagedServiceIdentityType = (typeof ManagedServiceIdentityType)[keyof typeof ManagedServiceIdentityType];

export const ReplicationRole = {
    None: "None",
    Source: "Source",
    Replica: "Replica",
} as const;

/**
 * The replication role.
 */
export type ReplicationRole = (typeof ReplicationRole)[keyof typeof ReplicationRole];

export const ServerVersion = {
    ServerVersion_5_7: "5.7",
    ServerVersion_8_0_21: "8.0.21",
} as const;

/**
 * Server version.
 */
export type ServerVersion = (typeof ServerVersion)[keyof typeof ServerVersion];

export const SkuTier = {
    Burstable: "Burstable",
    GeneralPurpose: "GeneralPurpose",
    MemoryOptimized: "MemoryOptimized",
} as const;

/**
 * The tier of the particular SKU, e.g. GeneralPurpose.
 */
export type SkuTier = (typeof SkuTier)[keyof typeof SkuTier];
