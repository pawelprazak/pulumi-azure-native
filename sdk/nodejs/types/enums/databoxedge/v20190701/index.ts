// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***


export const AccountType = {
    GeneralPurposeStorage: "GeneralPurposeStorage",
    BlobStorage: "BlobStorage",
} as const;

/**
 * Type of storage accessed on the storage account.
 */
export type AccountType = (typeof AccountType)[keyof typeof AccountType];

export const AzureContainerDataFormat = {
    BlockBlob: "BlockBlob",
    PageBlob: "PageBlob",
    AzureFile: "AzureFile",
} as const;

/**
 * Storage format used for the file represented by the share.
 */
export type AzureContainerDataFormat = (typeof AzureContainerDataFormat)[keyof typeof AzureContainerDataFormat];

export const ClientPermissionType = {
    NoAccess: "NoAccess",
    ReadOnly: "ReadOnly",
    ReadWrite: "ReadWrite",
} as const;

/**
 * Type of access to be allowed for the client.
 */
export type ClientPermissionType = (typeof ClientPermissionType)[keyof typeof ClientPermissionType];

export const DataBoxEdgeDeviceStatus = {
    ReadyToSetup: "ReadyToSetup",
    Online: "Online",
    Offline: "Offline",
    NeedsAttention: "NeedsAttention",
    Disconnected: "Disconnected",
    PartiallyDisconnected: "PartiallyDisconnected",
    Maintenance: "Maintenance",
} as const;

/**
 * The status of the Data Box Edge/Gateway device.
 */
export type DataBoxEdgeDeviceStatus = (typeof DataBoxEdgeDeviceStatus)[keyof typeof DataBoxEdgeDeviceStatus];

export const DataPolicy = {
    Cloud: "Cloud",
    Local: "Local",
} as const;

/**
 * Data policy of the share.
 */
export type DataPolicy = (typeof DataPolicy)[keyof typeof DataPolicy];

export const DayOfWeek = {
    Sunday: "Sunday",
    Monday: "Monday",
    Tuesday: "Tuesday",
    Wednesday: "Wednesday",
    Thursday: "Thursday",
    Friday: "Friday",
    Saturday: "Saturday",
} as const;

export type DayOfWeek = (typeof DayOfWeek)[keyof typeof DayOfWeek];

export const EncryptionAlgorithm = {
    None: "None",
    AES256: "AES256",
    RSAES_PKCS1_v_1_5: "RSAES_PKCS1_v_1_5",
} as const;

/**
 * The algorithm used to encrypt "Value".
 */
export type EncryptionAlgorithm = (typeof EncryptionAlgorithm)[keyof typeof EncryptionAlgorithm];

export const MonitoringStatus = {
    Enabled: "Enabled",
    Disabled: "Disabled",
} as const;

/**
 * Current monitoring status of the share.
 */
export type MonitoringStatus = (typeof MonitoringStatus)[keyof typeof MonitoringStatus];

export const OrderState = {
    Untracked: "Untracked",
    AwaitingFulfilment: "AwaitingFulfilment",
    AwaitingPreparation: "AwaitingPreparation",
    AwaitingShipment: "AwaitingShipment",
    Shipped: "Shipped",
    Arriving: "Arriving",
    Delivered: "Delivered",
    ReplacementRequested: "ReplacementRequested",
    LostDevice: "LostDevice",
    Declined: "Declined",
    ReturnInitiated: "ReturnInitiated",
    AwaitingReturnShipment: "AwaitingReturnShipment",
    ShippedBack: "ShippedBack",
    CollectedAtMicrosoft: "CollectedAtMicrosoft",
} as const;

/**
 * Status of the order as per the allowed status types.
 */
export type OrderState = (typeof OrderState)[keyof typeof OrderState];

export const PlatformType = {
    Windows: "Windows",
    Linux: "Linux",
} as const;

/**
 * Host OS supported by the IoT role.
 */
export type PlatformType = (typeof PlatformType)[keyof typeof PlatformType];

export const RoleStatus = {
    Enabled: "Enabled",
    Disabled: "Disabled",
} as const;

/**
 * Role status.
 */
export type RoleStatus = (typeof RoleStatus)[keyof typeof RoleStatus];

export const RoleTypes = {
    IOT: "IOT",
    ASA: "ASA",
    Functions: "Functions",
    Cognitive: "Cognitive",
} as const;

/**
 * Role type.
 */
export type RoleTypes = (typeof RoleTypes)[keyof typeof RoleTypes];

export const SSLStatus = {
    Enabled: "Enabled",
    Disabled: "Disabled",
} as const;

/**
 * Signifies whether SSL needs to be enabled or not.
 */
export type SSLStatus = (typeof SSLStatus)[keyof typeof SSLStatus];

export const ShareAccessProtocol = {
    SMB: "SMB",
    NFS: "NFS",
} as const;

/**
 * Access protocol to be used by the share.
 */
export type ShareAccessProtocol = (typeof ShareAccessProtocol)[keyof typeof ShareAccessProtocol];

export const ShareAccessType = {
    Change: "Change",
    Read: "Read",
    Custom: "Custom",
} as const;

/**
 * Type of access to be allowed on the share for this user.
 */
export type ShareAccessType = (typeof ShareAccessType)[keyof typeof ShareAccessType];

export const ShareStatus = {
    Offline: "Offline",
    Unknown: "Unknown",
    OK: "OK",
    Updating: "Updating",
    NeedsAttention: "NeedsAttention",
} as const;

/**
 * Current status of the share.
 */
export type ShareStatus = (typeof ShareStatus)[keyof typeof ShareStatus];

export const SkuName = {
    Gateway: "Gateway",
    Edge: "Edge",
} as const;

/**
 * SKU name.
 */
export type SkuName = (typeof SkuName)[keyof typeof SkuName];

export const SkuTier = {
    Standard: "Standard",
} as const;

/**
 * The SKU tier. This is based on the SKU name.
 */
export type SkuTier = (typeof SkuTier)[keyof typeof SkuTier];

export const TriggerEventType = {
    FileEvent: "FileEvent",
    PeriodicTimerEvent: "PeriodicTimerEvent",
} as const;

/**
 * Trigger Kind.
 */
export type TriggerEventType = (typeof TriggerEventType)[keyof typeof TriggerEventType];
