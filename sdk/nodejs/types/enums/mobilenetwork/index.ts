// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// Export sub-modules:
import * as v20220101preview from "./v20220101preview";
import * as v20220301preview from "./v20220301preview";

export {
    v20220101preview,
    v20220301preview,
};

export const CoreNetworkType = {
    CoreNetworkType_5GC: "5GC",
    EPC: "EPC",
} as const;

/**
 * The core network technology generation.
 */
export type CoreNetworkType = (typeof CoreNetworkType)[keyof typeof CoreNetworkType];

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

export const NaptEnabled = {
    Enabled: "Enabled",
    Disabled: "Disabled",
} as const;

/**
 * Whether NAPT is enabled for connections to this attachedDataNetwork.
 */
export type NaptEnabled = (typeof NaptEnabled)[keyof typeof NaptEnabled];

export const PduSessionType = {
    IPv4: "IPv4",
    IPv6: "IPv6",
} as const;

/**
 * The default PDU session type, which is used if the UE does not request a specific session type.
 */
export type PduSessionType = (typeof PduSessionType)[keyof typeof PduSessionType];

export const PreemptionCapability = {
    NotPreempt: "NotPreempt",
    MayPreempt: "MayPreempt",
} as const;

/**
 * Default QoS Flow preemption capability.  The Preemption Capability of a QoS Flow controls whether it can preempt another QoS Flow with a lower priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.
 */
export type PreemptionCapability = (typeof PreemptionCapability)[keyof typeof PreemptionCapability];

export const PreemptionVulnerability = {
    NotPreemptable: "NotPreemptable",
    Preemptable: "Preemptable",
} as const;

/**
 * Default QoS Flow preemption vulnerability.  The Preemption Vulnerability of a QoS Flow controls whether it can be preempted by QoS Flow with a higher priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.
 */
export type PreemptionVulnerability = (typeof PreemptionVulnerability)[keyof typeof PreemptionVulnerability];

export const SdfDirection = {
    Uplink: "Uplink",
    Downlink: "Downlink",
    Bidirectional: "Bidirectional",
} as const;

/**
 * The direction of this flow.
 */
export type SdfDirection = (typeof SdfDirection)[keyof typeof SdfDirection];

export const TrafficControlPermission = {
    Enabled: "Enabled",
    Blocked: "Blocked",
} as const;

/**
 * Determines whether flows that match this PCC Rule are permitted.
 */
export type TrafficControlPermission = (typeof TrafficControlPermission)[keyof typeof TrafficControlPermission];
