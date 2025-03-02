// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20210801

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// A cluster must have at least one 'System' Agent Pool at all times. For additional information on agent pool restrictions and best practices, see: https://docs.microsoft.com/azure/aks/use-system-pools
type AgentPoolMode string

const (
	// System agent pools are primarily for hosting critical system pods such as CoreDNS and metrics-server. System agent pools osType must be Linux. System agent pools VM SKU must have at least 2vCPUs and 4GB of memory.
	AgentPoolModeSystem = AgentPoolMode("System")
	// User agent pools are primarily for hosting your application pods.
	AgentPoolModeUser = AgentPoolMode("User")
)

// The type of Agent Pool.
type AgentPoolType string

const (
	// Create an Agent Pool backed by a Virtual Machine Scale Set.
	AgentPoolTypeVirtualMachineScaleSets = AgentPoolType("VirtualMachineScaleSets")
	// Use of this is strongly discouraged.
	AgentPoolTypeAvailabilitySet = AgentPoolType("AvailabilitySet")
)

// The private link service connection status.
type ConnectionStatus string

const (
	ConnectionStatusPending      = ConnectionStatus("Pending")
	ConnectionStatusApproved     = ConnectionStatus("Approved")
	ConnectionStatusRejected     = ConnectionStatus("Rejected")
	ConnectionStatusDisconnected = ConnectionStatus("Disconnected")
)

// If not specified, the default is 'random'. See [expanders](https://github.com/kubernetes/autoscaler/blob/master/cluster-autoscaler/FAQ.md#what-are-expanders) for more information.
type Expander string

const (
	// Selects the node group that will have the least idle CPU (if tied, unused memory) after scale-up. This is useful when you have different classes of nodes, for example, high CPU or high memory nodes, and only want to expand those when there are pending pods that need a lot of those resources.
	Expander_Least_waste = Expander("least-waste")
	// Selects the node group that would be able to schedule the most pods when scaling up. This is useful when you are using nodeSelector to make sure certain pods land on certain nodes. Note that this won't cause the autoscaler to select bigger nodes vs. smaller, as it can add multiple smaller nodes at once.
	Expander_Most_pods = Expander("most-pods")
	// Selects the node group that has the highest priority assigned by the user. It's configuration is described in more details [here](https://github.com/kubernetes/autoscaler/blob/master/cluster-autoscaler/expander/priority/readme.md).
	ExpanderPriority = Expander("priority")
	// Used when you don't have a particular need for the node groups to scale differently.
	ExpanderRandom = Expander("random")
)

// The type of the extended location.
type ExtendedLocationTypes string

const (
	ExtendedLocationTypesEdgeZone = ExtendedLocationTypes("EdgeZone")
)

// GPUInstanceProfile to be used to specify GPU MIG instance profile for supported GPU VM SKU.
type GPUInstanceProfile string

const (
	GPUInstanceProfileMIG1g = GPUInstanceProfile("MIG1g")
	GPUInstanceProfileMIG2g = GPUInstanceProfile("MIG2g")
	GPUInstanceProfileMIG3g = GPUInstanceProfile("MIG3g")
	GPUInstanceProfileMIG4g = GPUInstanceProfile("MIG4g")
	GPUInstanceProfileMIG7g = GPUInstanceProfile("MIG7g")
)

// Determines the placement of emptyDir volumes, container runtime data root, and Kubelet ephemeral storage.
type KubeletDiskType string

const (
	// Kubelet will use the OS disk for its data.
	KubeletDiskTypeOS = KubeletDiskType("OS")
	// Kubelet will use the temporary disk for its data.
	KubeletDiskTypeTemporary = KubeletDiskType("Temporary")
)

// The license type to use for Windows VMs. See [Azure Hybrid User Benefits](https://azure.microsoft.com/pricing/hybrid-benefit/faq/) for more details.
type LicenseType string

const (
	// No additional licensing is applied.
	LicenseTypeNone = LicenseType("None")
	// Enables Azure Hybrid User Benefits for Windows VMs.
	LicenseType_Windows_Server = LicenseType("Windows_Server")
)

// The default is 'standard'. See [Azure Load Balancer SKUs](https://docs.microsoft.com/azure/load-balancer/skus) for more information about the differences between load balancer SKUs.
type LoadBalancerSku string

const (
	// Use a a standard Load Balancer. This is the recommended Load Balancer SKU. For more information about on working with the load balancer in the managed cluster, see the [standard Load Balancer](https://docs.microsoft.com/azure/aks/load-balancer-standard) article.
	LoadBalancerSkuStandard = LoadBalancerSku("standard")
	// Use a basic Load Balancer with limited functionality.
	LoadBalancerSkuBasic = LoadBalancerSku("basic")
)

// The name of a managed cluster SKU.
type ManagedClusterSKUName string

const (
	ManagedClusterSKUNameBasic = ManagedClusterSKUName("Basic")
)

// If not specified, the default is 'Free'. See [uptime SLA](https://docs.microsoft.com/azure/aks/uptime-sla) for more details.
type ManagedClusterSKUTier string

const (
	// Guarantees 99.95% availability of the Kubernetes API server endpoint for clusters that use Availability Zones and 99.9% of availability for clusters that don't use Availability Zones.
	ManagedClusterSKUTierPaid = ManagedClusterSKUTier("Paid")
	// No guaranteed SLA, no additional charges. Free tier clusters have an SLO of 99.5%.
	ManagedClusterSKUTierFree = ManagedClusterSKUTier("Free")
)

// This cannot be specified if networkPlugin is anything other than 'azure'.
type NetworkMode string

const (
	// No bridge is created. Intra-VM Pod to Pod communication is through IP routes created by Azure CNI. See [Transparent Mode](https://docs.microsoft.com/azure/aks/faq#transparent-mode) for more information.
	NetworkModeTransparent = NetworkMode("transparent")
	// This is no longer supported
	NetworkModeBridge = NetworkMode("bridge")
)

// Network plugin used for building the Kubernetes network.
type NetworkPlugin string

const (
	// Use the Azure CNI network plugin. See [Azure CNI (advanced) networking](https://docs.microsoft.com/azure/aks/concepts-network#azure-cni-advanced-networking) for more information.
	NetworkPluginAzure = NetworkPlugin("azure")
	// Use the Kubenet network plugin. See [Kubenet (basic) networking](https://docs.microsoft.com/azure/aks/concepts-network#kubenet-basic-networking) for more information.
	NetworkPluginKubenet = NetworkPlugin("kubenet")
)

// Network policy used for building the Kubernetes network.
type NetworkPolicy string

const (
	// Use Calico network policies. See [differences between Azure and Calico policies](https://docs.microsoft.com/azure/aks/use-network-policies#differences-between-azure-and-calico-policies-and-their-capabilities) for more information.
	NetworkPolicyCalico = NetworkPolicy("calico")
	// Use Azure network policies. See [differences between Azure and Calico policies](https://docs.microsoft.com/azure/aks/use-network-policies#differences-between-azure-and-calico-policies-and-their-capabilities) for more information.
	NetworkPolicyAzure = NetworkPolicy("azure")
)

// The default is 'Ephemeral' if the VM supports it and has a cache disk larger than the requested OSDiskSizeGB. Otherwise, defaults to 'Managed'. May not be changed after creation. For more information see [Ephemeral OS](https://docs.microsoft.com/azure/aks/cluster-configuration#ephemeral-os).
type OSDiskType string

const (
	// Azure replicates the operating system disk for a virtual machine to Azure storage to avoid data loss should the VM need to be relocated to another host. Since containers aren't designed to have local state persisted, this behavior offers limited value while providing some drawbacks, including slower node provisioning and higher read/write latency.
	OSDiskTypeManaged = OSDiskType("Managed")
	// Ephemeral OS disks are stored only on the host machine, just like a temporary disk. This provides lower read/write latency, along with faster node scaling and cluster upgrades.
	OSDiskTypeEphemeral = OSDiskType("Ephemeral")
)

// Specifies an OS SKU. This value must not be specified if OSType is Windows.
type OSSKU string

const (
	OSSKUUbuntu     = OSSKU("Ubuntu")
	OSSKUCBLMariner = OSSKU("CBLMariner")
)

// The operating system type. The default is Linux.
type OSType string

const (
	// Use Linux.
	OSTypeLinux = OSType("Linux")
	// Use Windows.
	OSTypeWindows = OSType("Windows")
)

// This can only be set at cluster creation time and cannot be changed later. For more information see [egress outbound type](https://docs.microsoft.com/azure/aks/egress-outboundtype).
type OutboundType string

const (
	// The load balancer is used for egress through an AKS assigned public IP. This supports Kubernetes services of type 'loadBalancer'. For more information see [outbound type loadbalancer](https://docs.microsoft.com/azure/aks/egress-outboundtype#outbound-type-of-loadbalancer).
	OutboundTypeLoadBalancer = OutboundType("loadBalancer")
	// Egress paths must be defined by the user. This is an advanced scenario and requires proper network configuration. For more information see [outbound type userDefinedRouting](https://docs.microsoft.com/azure/aks/egress-outboundtype#outbound-type-of-userdefinedrouting).
	OutboundTypeUserDefinedRouting = OutboundType("userDefinedRouting")
	// The AKS-managed NAT gateway is used for egress.
	OutboundTypeManagedNATGateway = OutboundType("managedNATGateway")
	// The user-assigned NAT gateway associated to the cluster subnet is used for egress. This is an advanced scenario and requires proper network configuration.
	OutboundTypeUserAssignedNATGateway = OutboundType("userAssignedNATGateway")
)

// Default value is 'Enabled' (case insensitive). Could be set to 'Disabled' to enable private cluster
type PublicNetworkAccess string

const (
	PublicNetworkAccessEnabled  = PublicNetworkAccess("Enabled")
	PublicNetworkAccessDisabled = PublicNetworkAccess("Disabled")
)

// For more information see [use managed identities in AKS](https://docs.microsoft.com/azure/aks/use-managed-identity).
type ResourceIdentityType string

const (
	// Use an implicitly created system assigned managed identity to manage cluster resources. Master components in the control plane such as kube-controller-manager will use the system assigned managed identity to manipulate Azure resources.
	ResourceIdentityTypeSystemAssigned = ResourceIdentityType("SystemAssigned")
	// Use a user-specified identity to manage cluster resources. Master components in the control plane such as kube-controller-manager will use the specified user assigned managed identity to manipulate Azure resources.
	ResourceIdentityTypeUserAssigned = ResourceIdentityType("UserAssigned")
	// Do not use a managed identity for the Managed Cluster, service principal will be used instead.
	ResourceIdentityTypeNone = ResourceIdentityType("None")
)

func (ResourceIdentityType) ElementType() reflect.Type {
	return reflect.TypeOf((*ResourceIdentityType)(nil)).Elem()
}

func (e ResourceIdentityType) ToResourceIdentityTypeOutput() ResourceIdentityTypeOutput {
	return pulumi.ToOutput(e).(ResourceIdentityTypeOutput)
}

func (e ResourceIdentityType) ToResourceIdentityTypeOutputWithContext(ctx context.Context) ResourceIdentityTypeOutput {
	return pulumi.ToOutputWithContext(ctx, e).(ResourceIdentityTypeOutput)
}

func (e ResourceIdentityType) ToResourceIdentityTypePtrOutput() ResourceIdentityTypePtrOutput {
	return e.ToResourceIdentityTypePtrOutputWithContext(context.Background())
}

func (e ResourceIdentityType) ToResourceIdentityTypePtrOutputWithContext(ctx context.Context) ResourceIdentityTypePtrOutput {
	return ResourceIdentityType(e).ToResourceIdentityTypeOutputWithContext(ctx).ToResourceIdentityTypePtrOutputWithContext(ctx)
}

func (e ResourceIdentityType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e ResourceIdentityType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e ResourceIdentityType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e ResourceIdentityType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type ResourceIdentityTypeOutput struct{ *pulumi.OutputState }

func (ResourceIdentityTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ResourceIdentityType)(nil)).Elem()
}

func (o ResourceIdentityTypeOutput) ToResourceIdentityTypeOutput() ResourceIdentityTypeOutput {
	return o
}

func (o ResourceIdentityTypeOutput) ToResourceIdentityTypeOutputWithContext(ctx context.Context) ResourceIdentityTypeOutput {
	return o
}

func (o ResourceIdentityTypeOutput) ToResourceIdentityTypePtrOutput() ResourceIdentityTypePtrOutput {
	return o.ToResourceIdentityTypePtrOutputWithContext(context.Background())
}

func (o ResourceIdentityTypeOutput) ToResourceIdentityTypePtrOutputWithContext(ctx context.Context) ResourceIdentityTypePtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v ResourceIdentityType) *ResourceIdentityType {
		return &v
	}).(ResourceIdentityTypePtrOutput)
}

func (o ResourceIdentityTypeOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o ResourceIdentityTypeOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e ResourceIdentityType) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o ResourceIdentityTypeOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o ResourceIdentityTypeOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e ResourceIdentityType) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type ResourceIdentityTypePtrOutput struct{ *pulumi.OutputState }

func (ResourceIdentityTypePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ResourceIdentityType)(nil)).Elem()
}

func (o ResourceIdentityTypePtrOutput) ToResourceIdentityTypePtrOutput() ResourceIdentityTypePtrOutput {
	return o
}

func (o ResourceIdentityTypePtrOutput) ToResourceIdentityTypePtrOutputWithContext(ctx context.Context) ResourceIdentityTypePtrOutput {
	return o
}

func (o ResourceIdentityTypePtrOutput) Elem() ResourceIdentityTypeOutput {
	return o.ApplyT(func(v *ResourceIdentityType) ResourceIdentityType {
		if v != nil {
			return *v
		}
		var ret ResourceIdentityType
		return ret
	}).(ResourceIdentityTypeOutput)
}

func (o ResourceIdentityTypePtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o ResourceIdentityTypePtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *ResourceIdentityType) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// ResourceIdentityTypeInput is an input type that accepts ResourceIdentityTypeArgs and ResourceIdentityTypeOutput values.
// You can construct a concrete instance of `ResourceIdentityTypeInput` via:
//
//          ResourceIdentityTypeArgs{...}
type ResourceIdentityTypeInput interface {
	pulumi.Input

	ToResourceIdentityTypeOutput() ResourceIdentityTypeOutput
	ToResourceIdentityTypeOutputWithContext(context.Context) ResourceIdentityTypeOutput
}

var resourceIdentityTypePtrType = reflect.TypeOf((**ResourceIdentityType)(nil)).Elem()

type ResourceIdentityTypePtrInput interface {
	pulumi.Input

	ToResourceIdentityTypePtrOutput() ResourceIdentityTypePtrOutput
	ToResourceIdentityTypePtrOutputWithContext(context.Context) ResourceIdentityTypePtrOutput
}

type resourceIdentityTypePtr string

func ResourceIdentityTypePtr(v string) ResourceIdentityTypePtrInput {
	return (*resourceIdentityTypePtr)(&v)
}

func (*resourceIdentityTypePtr) ElementType() reflect.Type {
	return resourceIdentityTypePtrType
}

func (in *resourceIdentityTypePtr) ToResourceIdentityTypePtrOutput() ResourceIdentityTypePtrOutput {
	return pulumi.ToOutput(in).(ResourceIdentityTypePtrOutput)
}

func (in *resourceIdentityTypePtr) ToResourceIdentityTypePtrOutputWithContext(ctx context.Context) ResourceIdentityTypePtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(ResourceIdentityTypePtrOutput)
}

// This also effects the cluster autoscaler behavior. If not specified, it defaults to Delete.
type ScaleDownMode string

const (
	// Create new instances during scale up and remove instances during scale down.
	ScaleDownModeDelete = ScaleDownMode("Delete")
	// Attempt to start deallocated instances (if they exist) during scale up and deallocate instances during scale down.
	ScaleDownModeDeallocate = ScaleDownMode("Deallocate")
)

// This cannot be specified unless the scaleSetPriority is 'Spot'. If not specified, the default is 'Delete'.
type ScaleSetEvictionPolicy string

const (
	// Nodes in the underlying Scale Set of the node pool are deleted when they're evicted.
	ScaleSetEvictionPolicyDelete = ScaleSetEvictionPolicy("Delete")
	// Nodes in the underlying Scale Set of the node pool are set to the stopped-deallocated state upon eviction. Nodes in the stopped-deallocated state count against your compute quota and can cause issues with cluster scaling or upgrading.
	ScaleSetEvictionPolicyDeallocate = ScaleSetEvictionPolicy("Deallocate")
)

// The Virtual Machine Scale Set priority. If not specified, the default is 'Regular'.
type ScaleSetPriority string

const (
	// Spot priority VMs will be used. There is no SLA for spot nodes. See [spot on AKS](https://docs.microsoft.com/azure/aks/spot-node-pool) for more information.
	ScaleSetPrioritySpot = ScaleSetPriority("Spot")
	// Regular VMs will be used.
	ScaleSetPriorityRegular = ScaleSetPriority("Regular")
)

// The type of a snapshot. The default is NodePool.
type SnapshotType string

const (
	// The snapshot is a snapshot of a node pool.
	SnapshotTypeNodePool = SnapshotType("NodePool")
)

// For more information see [setting the AKS cluster auto-upgrade channel](https://docs.microsoft.com/azure/aks/upgrade-cluster#set-auto-upgrade-channel).
type UpgradeChannel string

const (
	// Automatically upgrade the cluster to the latest supported patch release on the latest supported minor version. In cases where the cluster is at a version of Kubernetes that is at an N-2 minor version where N is the latest supported minor version, the cluster first upgrades to the latest supported patch version on N-1 minor version. For example, if a cluster is running version 1.17.7 and versions 1.17.9, 1.18.4, 1.18.6, and 1.19.1 are available, your cluster first is upgraded to 1.18.6, then is upgraded to 1.19.1.
	UpgradeChannelRapid = UpgradeChannel("rapid")
	// Automatically upgrade the cluster to the latest supported patch release on minor version N-1, where N is the latest supported minor version. For example, if a cluster is running version 1.17.7 and versions 1.17.9, 1.18.4, 1.18.6, and 1.19.1 are available, your cluster is upgraded to 1.18.6.
	UpgradeChannelStable = UpgradeChannel("stable")
	// Automatically upgrade the cluster to the latest supported patch version when it becomes available while keeping the minor version the same. For example, if a cluster is running version 1.17.7 and versions 1.17.9, 1.18.4, 1.18.6, and 1.19.1 are available, your cluster is upgraded to 1.17.9.
	UpgradeChannelPatch = UpgradeChannel("patch")
	// Automatically upgrade the node image to the latest version available. Microsoft provides patches and new images for image nodes frequently (usually weekly), but your running nodes won't get the new images unless you do a node image upgrade. Turning on the node-image channel will automatically update your node images whenever a new version is available.
	UpgradeChannel_Node_image = UpgradeChannel("node-image")
	// Disables auto-upgrades and keeps the cluster at its current version of Kubernetes.
	UpgradeChannelNone = UpgradeChannel("none")
)

// The day of the week.
type WeekDay string

const (
	WeekDaySunday    = WeekDay("Sunday")
	WeekDayMonday    = WeekDay("Monday")
	WeekDayTuesday   = WeekDay("Tuesday")
	WeekDayWednesday = WeekDay("Wednesday")
	WeekDayThursday  = WeekDay("Thursday")
	WeekDayFriday    = WeekDay("Friday")
	WeekDaySaturday  = WeekDay("Saturday")
)

// Determines the type of workload a node can run.
type WorkloadRuntime string

const (
	// Nodes will use Kubelet to run standard OCI container workloads.
	WorkloadRuntimeOCIContainer = WorkloadRuntime("OCIContainer")
	// Nodes will use Krustlet to run WASM workloads using the WASI provider (Preview).
	WorkloadRuntimeWasmWasi = WorkloadRuntime("WasmWasi")
)

func init() {
	pulumi.RegisterOutputType(ResourceIdentityTypeOutput{})
	pulumi.RegisterOutputType(ResourceIdentityTypePtrOutput{})
}
