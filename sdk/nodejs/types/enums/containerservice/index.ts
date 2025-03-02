// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// Export sub-modules:
import * as v20151101preview from "./v20151101preview";
import * as v20160330 from "./v20160330";
import * as v20160930 from "./v20160930";
import * as v20170131 from "./v20170131";
import * as v20170831 from "./v20170831";
import * as v20180331 from "./v20180331";
import * as v20180801preview from "./v20180801preview";
import * as v20180930preview from "./v20180930preview";
import * as v20190201 from "./v20190201";
import * as v20190401 from "./v20190401";
import * as v20190430 from "./v20190430";
import * as v20190601 from "./v20190601";
import * as v20190801 from "./v20190801";
import * as v20190930preview from "./v20190930preview";
import * as v20191001 from "./v20191001";
import * as v20191027preview from "./v20191027preview";
import * as v20191101 from "./v20191101";
import * as v20200101 from "./v20200101";
import * as v20200201 from "./v20200201";
import * as v20200301 from "./v20200301";
import * as v20200401 from "./v20200401";
import * as v20200601 from "./v20200601";
import * as v20200701 from "./v20200701";
import * as v20200901 from "./v20200901";
import * as v20201101 from "./v20201101";
import * as v20201201 from "./v20201201";
import * as v20210201 from "./v20210201";
import * as v20210301 from "./v20210301";
import * as v20210501 from "./v20210501";
import * as v20210701 from "./v20210701";
import * as v20210801 from "./v20210801";
import * as v20210901 from "./v20210901";
import * as v20211001 from "./v20211001";
import * as v20211101preview from "./v20211101preview";
import * as v20220101 from "./v20220101";
import * as v20220102preview from "./v20220102preview";
import * as v20220201 from "./v20220201";
import * as v20220202preview from "./v20220202preview";
import * as v20220301 from "./v20220301";
import * as v20220302preview from "./v20220302preview";
import * as v20220401 from "./v20220401";
import * as v20220402preview from "./v20220402preview";
import * as v20220502preview from "./v20220502preview";

export {
    v20151101preview,
    v20160330,
    v20160930,
    v20170131,
    v20170831,
    v20180331,
    v20180801preview,
    v20180930preview,
    v20190201,
    v20190401,
    v20190430,
    v20190601,
    v20190801,
    v20190930preview,
    v20191001,
    v20191027preview,
    v20191101,
    v20200101,
    v20200201,
    v20200301,
    v20200401,
    v20200601,
    v20200701,
    v20200901,
    v20201101,
    v20201201,
    v20210201,
    v20210301,
    v20210501,
    v20210701,
    v20210801,
    v20210901,
    v20211001,
    v20211101preview,
    v20220101,
    v20220102preview,
    v20220201,
    v20220202preview,
    v20220301,
    v20220302preview,
    v20220401,
    v20220402preview,
    v20220502preview,
};

export const AgentPoolMode = {
    System: "System",
    User: "User",
} as const;

/**
 * AgentPoolMode represents mode of an agent pool
 */
export type AgentPoolMode = (typeof AgentPoolMode)[keyof typeof AgentPoolMode];

export const AgentPoolType = {
    VirtualMachineScaleSets: "VirtualMachineScaleSets",
    AvailabilitySet: "AvailabilitySet",
} as const;

/**
 * AgentPoolType represents types of an agent pool
 */
export type AgentPoolType = (typeof AgentPoolType)[keyof typeof AgentPoolType];

export const ConnectionStatus = {
    Pending: "Pending",
    Approved: "Approved",
    Rejected: "Rejected",
    Disconnected: "Disconnected",
} as const;

/**
 * The private link service connection status.
 */
export type ConnectionStatus = (typeof ConnectionStatus)[keyof typeof ConnectionStatus];

export const Expander = {
    Least_waste: "least-waste",
    Most_pods: "most-pods",
    Priority: "priority",
    Random: "random",
} as const;

export type Expander = (typeof Expander)[keyof typeof Expander];

export const ExtendedLocationTypes = {
    EdgeZone: "EdgeZone",
} as const;

/**
 * The type of the extended location.
 */
export type ExtendedLocationTypes = (typeof ExtendedLocationTypes)[keyof typeof ExtendedLocationTypes];

export const GPUInstanceProfile = {
    MIG1g: "MIG1g",
    MIG2g: "MIG2g",
    MIG3g: "MIG3g",
    MIG4g: "MIG4g",
    MIG7g: "MIG7g",
} as const;

/**
 * GPUInstanceProfile to be used to specify GPU MIG instance profile for supported GPU VM SKU. Supported values are MIG1g, MIG2g, MIG3g, MIG4g and MIG7g.
 */
export type GPUInstanceProfile = (typeof GPUInstanceProfile)[keyof typeof GPUInstanceProfile];

export const KubeletDiskType = {
    OS: "OS",
    Temporary: "Temporary",
} as const;

/**
 * KubeletDiskType determines the placement of emptyDir volumes, container runtime data root, and Kubelet ephemeral storage. Currently allows one value, OS, resulting in Kubelet using the OS disk for data.
 */
export type KubeletDiskType = (typeof KubeletDiskType)[keyof typeof KubeletDiskType];

export const LicenseType = {
    None: "None",
    Windows_Server: "Windows_Server",
} as const;

/**
 * The licenseType to use for Windows VMs. Windows_Server is used to enable Azure Hybrid User Benefits for Windows VMs.
 */
export type LicenseType = (typeof LicenseType)[keyof typeof LicenseType];

export const LoadBalancerSku = {
    Standard: "standard",
    Basic: "basic",
} as const;

/**
 * The load balancer sku for the managed cluster.
 */
export type LoadBalancerSku = (typeof LoadBalancerSku)[keyof typeof LoadBalancerSku];

export const ManagedClusterSKUName = {
    Basic: "Basic",
} as const;

/**
 * Name of a managed cluster SKU.
 */
export type ManagedClusterSKUName = (typeof ManagedClusterSKUName)[keyof typeof ManagedClusterSKUName];

export const ManagedClusterSKUTier = {
    Paid: "Paid",
    Free: "Free",
} as const;

/**
 * Tier of a managed cluster SKU.
 */
export type ManagedClusterSKUTier = (typeof ManagedClusterSKUTier)[keyof typeof ManagedClusterSKUTier];

export const NetworkMode = {
    Transparent: "transparent",
    Bridge: "bridge",
} as const;

/**
 * Network mode used for building Kubernetes network.
 */
export type NetworkMode = (typeof NetworkMode)[keyof typeof NetworkMode];

export const NetworkPlugin = {
    Azure: "azure",
    Kubenet: "kubenet",
} as const;

/**
 * Network plugin used for building Kubernetes network.
 */
export type NetworkPlugin = (typeof NetworkPlugin)[keyof typeof NetworkPlugin];

export const NetworkPolicy = {
    Calico: "calico",
    Azure: "azure",
} as const;

/**
 * Network policy used for building Kubernetes network.
 */
export type NetworkPolicy = (typeof NetworkPolicy)[keyof typeof NetworkPolicy];

export const OSDiskType = {
    Managed: "Managed",
    Ephemeral: "Ephemeral",
} as const;

/**
 * OS disk type to be used for machines in a given agent pool. Allowed values are 'Ephemeral' and 'Managed'. If unspecified, defaults to 'Ephemeral' when the VM supports ephemeral OS and has a cache disk larger than the requested OSDiskSizeGB. Otherwise, defaults to 'Managed'. May not be changed after creation.
 */
export type OSDiskType = (typeof OSDiskType)[keyof typeof OSDiskType];

export const OSSKU = {
    Ubuntu: "Ubuntu",
    CBLMariner: "CBLMariner",
} as const;

/**
 * OsSKU to be used to specify os sku. Choose from Ubuntu(default) and CBLMariner for Linux OSType. Not applicable to Windows OSType.
 */
export type OSSKU = (typeof OSSKU)[keyof typeof OSSKU];

export const OSType = {
    Linux: "Linux",
    Windows: "Windows",
} as const;

/**
 * OsType to be used to specify os type. Choose from Linux and Windows. Default to Linux.
 */
export type OSType = (typeof OSType)[keyof typeof OSType];

export const OpenShiftAgentPoolProfileRole = {
    Compute: "compute",
    Infra: "infra",
} as const;

/**
 * Define the role of the AgentPoolProfile.
 */
export type OpenShiftAgentPoolProfileRole = (typeof OpenShiftAgentPoolProfileRole)[keyof typeof OpenShiftAgentPoolProfileRole];

export const OpenShiftContainerServiceVMSize = {
    Standard_D2s_v3: "Standard_D2s_v3",
    Standard_D4s_v3: "Standard_D4s_v3",
    Standard_D8s_v3: "Standard_D8s_v3",
    Standard_D16s_v3: "Standard_D16s_v3",
    Standard_D32s_v3: "Standard_D32s_v3",
    Standard_D64s_v3: "Standard_D64s_v3",
    Standard_DS4_v2: "Standard_DS4_v2",
    Standard_DS5_v2: "Standard_DS5_v2",
    Standard_F8s_v2: "Standard_F8s_v2",
    Standard_F16s_v2: "Standard_F16s_v2",
    Standard_F32s_v2: "Standard_F32s_v2",
    Standard_F64s_v2: "Standard_F64s_v2",
    Standard_F72s_v2: "Standard_F72s_v2",
    Standard_F8s: "Standard_F8s",
    Standard_F16s: "Standard_F16s",
    Standard_E4s_v3: "Standard_E4s_v3",
    Standard_E8s_v3: "Standard_E8s_v3",
    Standard_E16s_v3: "Standard_E16s_v3",
    Standard_E20s_v3: "Standard_E20s_v3",
    Standard_E32s_v3: "Standard_E32s_v3",
    Standard_E64s_v3: "Standard_E64s_v3",
    Standard_GS2: "Standard_GS2",
    Standard_GS3: "Standard_GS3",
    Standard_GS4: "Standard_GS4",
    Standard_GS5: "Standard_GS5",
    Standard_DS12_v2: "Standard_DS12_v2",
    Standard_DS13_v2: "Standard_DS13_v2",
    Standard_DS14_v2: "Standard_DS14_v2",
    Standard_DS15_v2: "Standard_DS15_v2",
    Standard_L4s: "Standard_L4s",
    Standard_L8s: "Standard_L8s",
    Standard_L16s: "Standard_L16s",
    Standard_L32s: "Standard_L32s",
} as const;

/**
 * Size of agent VMs.
 */
export type OpenShiftContainerServiceVMSize = (typeof OpenShiftContainerServiceVMSize)[keyof typeof OpenShiftContainerServiceVMSize];

export const OutboundType = {
    LoadBalancer: "loadBalancer",
    UserDefinedRouting: "userDefinedRouting",
} as const;

/**
 * The outbound (egress) routing method.
 */
export type OutboundType = (typeof OutboundType)[keyof typeof OutboundType];

export const ResourceIdentityType = {
    SystemAssigned: "SystemAssigned",
    UserAssigned: "UserAssigned",
    None: "None",
} as const;

/**
 * The type of identity used for the managed cluster. Type 'SystemAssigned' will use an implicitly created identity in master components and an auto-created user assigned identity in MC_ resource group in agent nodes. Type 'None' will not use MSI for the managed cluster, service principal will be used instead.
 */
export type ResourceIdentityType = (typeof ResourceIdentityType)[keyof typeof ResourceIdentityType];

export const ScaleSetEvictionPolicy = {
    Delete: "Delete",
    Deallocate: "Deallocate",
} as const;

/**
 * ScaleSetEvictionPolicy to be used to specify eviction policy for Spot virtual machine scale set. Default to Delete.
 */
export type ScaleSetEvictionPolicy = (typeof ScaleSetEvictionPolicy)[keyof typeof ScaleSetEvictionPolicy];

export const ScaleSetPriority = {
    Spot: "Spot",
    Regular: "Regular",
} as const;

/**
 * ScaleSetPriority to be used to specify virtual machine scale set priority. Default to regular.
 */
export type ScaleSetPriority = (typeof ScaleSetPriority)[keyof typeof ScaleSetPriority];

export const SnapshotType = {
    /**
     * The snapshot is a snapshot of a node pool.
     */
    NodePool: "NodePool",
} as const;

/**
 * The type of a snapshot. The default is NodePool.
 */
export type SnapshotType = (typeof SnapshotType)[keyof typeof SnapshotType];

export const UpgradeChannel = {
    Rapid: "rapid",
    Stable: "stable",
    Patch: "patch",
    Node_image: "node-image",
    None: "none",
} as const;

/**
 * upgrade channel for auto upgrade.
 */
export type UpgradeChannel = (typeof UpgradeChannel)[keyof typeof UpgradeChannel];

export const WeekDay = {
    Sunday: "Sunday",
    Monday: "Monday",
    Tuesday: "Tuesday",
    Wednesday: "Wednesday",
    Thursday: "Thursday",
    Friday: "Friday",
    Saturday: "Saturday",
} as const;

/**
 * A day in a week.
 */
export type WeekDay = (typeof WeekDay)[keyof typeof WeekDay];
