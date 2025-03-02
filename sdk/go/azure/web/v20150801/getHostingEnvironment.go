// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20150801

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Description of an hostingEnvironment (App Service Environment)
//
// Deprecated: Version 2015-08-01 will be removed in v2 of the provider.
func LookupHostingEnvironment(ctx *pulumi.Context, args *LookupHostingEnvironmentArgs, opts ...pulumi.InvokeOption) (*LookupHostingEnvironmentResult, error) {
	var rv LookupHostingEnvironmentResult
	err := ctx.Invoke("azure-native:web/v20150801:getHostingEnvironment", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupHostingEnvironmentArgs struct {
	// Name of hostingEnvironment (App Service Environment)
	Name string `pulumi:"name"`
	// Name of resource group
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Description of an hostingEnvironment (App Service Environment)
type LookupHostingEnvironmentResult struct {
	// List of comma separated strings describing which VM sizes are allowed for front-ends
	AllowedMultiSizes *string `pulumi:"allowedMultiSizes"`
	// List of comma separated strings describing which VM sizes are allowed for workers
	AllowedWorkerSizes *string `pulumi:"allowedWorkerSizes"`
	// Api Management Account associated with this Hosting Environment
	ApiManagementAccountId *string `pulumi:"apiManagementAccountId"`
	// Custom settings for changing the behavior of the hosting environment
	ClusterSettings []NameValuePairResponse `pulumi:"clusterSettings"`
	// Edition of the metadata database for the hostingEnvironment (App Service Environment) e.g. "Standard"
	DatabaseEdition *string `pulumi:"databaseEdition"`
	// Service objective of the metadata database for the hostingEnvironment (App Service Environment) e.g. "S0"
	DatabaseServiceObjective *string `pulumi:"databaseServiceObjective"`
	// DNS suffix of the hostingEnvironment (App Service Environment)
	DnsSuffix *string `pulumi:"dnsSuffix"`
	// Current total, used, and available worker capacities
	EnvironmentCapacities []StampCapacityResponse `pulumi:"environmentCapacities"`
	// True/false indicating whether the hostingEnvironment (App Service Environment) is healthy
	EnvironmentIsHealthy *bool `pulumi:"environmentIsHealthy"`
	// Detailed message about with results of the last check of the hostingEnvironment (App Service Environment)
	EnvironmentStatus *string `pulumi:"environmentStatus"`
	// Resource Id
	Id *string `pulumi:"id"`
	// Specifies which endpoints to serve internally in the hostingEnvironment's (App Service Environment) VNET
	InternalLoadBalancingMode *string `pulumi:"internalLoadBalancingMode"`
	// Number of IP SSL addresses reserved for this hostingEnvironment (App Service Environment)
	IpsslAddressCount *int `pulumi:"ipsslAddressCount"`
	// Kind of resource
	Kind *string `pulumi:"kind"`
	// Last deployment action on this hostingEnvironment (App Service Environment)
	LastAction *string `pulumi:"lastAction"`
	// Result of the last deployment action on this hostingEnvironment (App Service Environment)
	LastActionResult *string `pulumi:"lastActionResult"`
	// Resource Location
	Location string `pulumi:"location"`
	// Maximum number of VMs in this hostingEnvironment (App Service Environment)
	MaximumNumberOfMachines *int `pulumi:"maximumNumberOfMachines"`
	// Number of front-end instances
	MultiRoleCount *int `pulumi:"multiRoleCount"`
	// Front-end VM size, e.g. "Medium", "Large"
	MultiSize *string `pulumi:"multiSize"`
	// Resource Name
	Name *string `pulumi:"name"`
	// Access control list for controlling traffic to the hostingEnvironment (App Service Environment)
	NetworkAccessControlList []NetworkAccessControlEntryResponse `pulumi:"networkAccessControlList"`
	// Provisioning state of the hostingEnvironment (App Service Environment)
	ProvisioningState *string `pulumi:"provisioningState"`
	// Resource group of the hostingEnvironment (App Service Environment)
	ResourceGroup *string `pulumi:"resourceGroup"`
	// Current status of the hostingEnvironment (App Service Environment)
	Status string `pulumi:"status"`
	// Subscription of the hostingEnvironment (App Service Environment)
	SubscriptionId *string `pulumi:"subscriptionId"`
	// True/false indicating whether the hostingEnvironment is suspended. The environment can be suspended e.g. when the management endpoint is no longer available
	//             (most likely because NSG blocked the incoming traffic)
	Suspended *bool `pulumi:"suspended"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
	// Number of upgrade domains of this hostingEnvironment (App Service Environment)
	UpgradeDomains *int `pulumi:"upgradeDomains"`
	// Description of IP SSL mapping for this hostingEnvironment (App Service Environment)
	VipMappings []VirtualIPMappingResponse `pulumi:"vipMappings"`
	// Description of the hostingEnvironment's (App Service Environment) virtual network
	VirtualNetwork *VirtualNetworkProfileResponse `pulumi:"virtualNetwork"`
	// Name of the hostingEnvironment's (App Service Environment) virtual network
	VnetName *string `pulumi:"vnetName"`
	// Resource group of the hostingEnvironment's (App Service Environment) virtual network
	VnetResourceGroupName *string `pulumi:"vnetResourceGroupName"`
	// Subnet of the hostingEnvironment's (App Service Environment) virtual network
	VnetSubnetName *string `pulumi:"vnetSubnetName"`
	// Description of worker pools with worker size ids, VM sizes, and number of workers in each pool
	WorkerPools []WorkerPoolResponse `pulumi:"workerPools"`
}

func LookupHostingEnvironmentOutput(ctx *pulumi.Context, args LookupHostingEnvironmentOutputArgs, opts ...pulumi.InvokeOption) LookupHostingEnvironmentResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupHostingEnvironmentResult, error) {
			args := v.(LookupHostingEnvironmentArgs)
			r, err := LookupHostingEnvironment(ctx, &args, opts...)
			var s LookupHostingEnvironmentResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupHostingEnvironmentResultOutput)
}

type LookupHostingEnvironmentOutputArgs struct {
	// Name of hostingEnvironment (App Service Environment)
	Name pulumi.StringInput `pulumi:"name"`
	// Name of resource group
	ResourceGroupName pulumi.StringInput `pulumi:"resourceGroupName"`
}

func (LookupHostingEnvironmentOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupHostingEnvironmentArgs)(nil)).Elem()
}

// Description of an hostingEnvironment (App Service Environment)
type LookupHostingEnvironmentResultOutput struct{ *pulumi.OutputState }

func (LookupHostingEnvironmentResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupHostingEnvironmentResult)(nil)).Elem()
}

func (o LookupHostingEnvironmentResultOutput) ToLookupHostingEnvironmentResultOutput() LookupHostingEnvironmentResultOutput {
	return o
}

func (o LookupHostingEnvironmentResultOutput) ToLookupHostingEnvironmentResultOutputWithContext(ctx context.Context) LookupHostingEnvironmentResultOutput {
	return o
}

// List of comma separated strings describing which VM sizes are allowed for front-ends
func (o LookupHostingEnvironmentResultOutput) AllowedMultiSizes() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *string { return v.AllowedMultiSizes }).(pulumi.StringPtrOutput)
}

// List of comma separated strings describing which VM sizes are allowed for workers
func (o LookupHostingEnvironmentResultOutput) AllowedWorkerSizes() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *string { return v.AllowedWorkerSizes }).(pulumi.StringPtrOutput)
}

// Api Management Account associated with this Hosting Environment
func (o LookupHostingEnvironmentResultOutput) ApiManagementAccountId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *string { return v.ApiManagementAccountId }).(pulumi.StringPtrOutput)
}

// Custom settings for changing the behavior of the hosting environment
func (o LookupHostingEnvironmentResultOutput) ClusterSettings() NameValuePairResponseArrayOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) []NameValuePairResponse { return v.ClusterSettings }).(NameValuePairResponseArrayOutput)
}

// Edition of the metadata database for the hostingEnvironment (App Service Environment) e.g. "Standard"
func (o LookupHostingEnvironmentResultOutput) DatabaseEdition() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *string { return v.DatabaseEdition }).(pulumi.StringPtrOutput)
}

// Service objective of the metadata database for the hostingEnvironment (App Service Environment) e.g. "S0"
func (o LookupHostingEnvironmentResultOutput) DatabaseServiceObjective() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *string { return v.DatabaseServiceObjective }).(pulumi.StringPtrOutput)
}

// DNS suffix of the hostingEnvironment (App Service Environment)
func (o LookupHostingEnvironmentResultOutput) DnsSuffix() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *string { return v.DnsSuffix }).(pulumi.StringPtrOutput)
}

// Current total, used, and available worker capacities
func (o LookupHostingEnvironmentResultOutput) EnvironmentCapacities() StampCapacityResponseArrayOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) []StampCapacityResponse { return v.EnvironmentCapacities }).(StampCapacityResponseArrayOutput)
}

// True/false indicating whether the hostingEnvironment (App Service Environment) is healthy
func (o LookupHostingEnvironmentResultOutput) EnvironmentIsHealthy() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *bool { return v.EnvironmentIsHealthy }).(pulumi.BoolPtrOutput)
}

// Detailed message about with results of the last check of the hostingEnvironment (App Service Environment)
func (o LookupHostingEnvironmentResultOutput) EnvironmentStatus() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *string { return v.EnvironmentStatus }).(pulumi.StringPtrOutput)
}

// Resource Id
func (o LookupHostingEnvironmentResultOutput) Id() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *string { return v.Id }).(pulumi.StringPtrOutput)
}

// Specifies which endpoints to serve internally in the hostingEnvironment's (App Service Environment) VNET
func (o LookupHostingEnvironmentResultOutput) InternalLoadBalancingMode() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *string { return v.InternalLoadBalancingMode }).(pulumi.StringPtrOutput)
}

// Number of IP SSL addresses reserved for this hostingEnvironment (App Service Environment)
func (o LookupHostingEnvironmentResultOutput) IpsslAddressCount() pulumi.IntPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *int { return v.IpsslAddressCount }).(pulumi.IntPtrOutput)
}

// Kind of resource
func (o LookupHostingEnvironmentResultOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *string { return v.Kind }).(pulumi.StringPtrOutput)
}

// Last deployment action on this hostingEnvironment (App Service Environment)
func (o LookupHostingEnvironmentResultOutput) LastAction() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *string { return v.LastAction }).(pulumi.StringPtrOutput)
}

// Result of the last deployment action on this hostingEnvironment (App Service Environment)
func (o LookupHostingEnvironmentResultOutput) LastActionResult() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *string { return v.LastActionResult }).(pulumi.StringPtrOutput)
}

// Resource Location
func (o LookupHostingEnvironmentResultOutput) Location() pulumi.StringOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) string { return v.Location }).(pulumi.StringOutput)
}

// Maximum number of VMs in this hostingEnvironment (App Service Environment)
func (o LookupHostingEnvironmentResultOutput) MaximumNumberOfMachines() pulumi.IntPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *int { return v.MaximumNumberOfMachines }).(pulumi.IntPtrOutput)
}

// Number of front-end instances
func (o LookupHostingEnvironmentResultOutput) MultiRoleCount() pulumi.IntPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *int { return v.MultiRoleCount }).(pulumi.IntPtrOutput)
}

// Front-end VM size, e.g. "Medium", "Large"
func (o LookupHostingEnvironmentResultOutput) MultiSize() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *string { return v.MultiSize }).(pulumi.StringPtrOutput)
}

// Resource Name
func (o LookupHostingEnvironmentResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

// Access control list for controlling traffic to the hostingEnvironment (App Service Environment)
func (o LookupHostingEnvironmentResultOutput) NetworkAccessControlList() NetworkAccessControlEntryResponseArrayOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) []NetworkAccessControlEntryResponse {
		return v.NetworkAccessControlList
	}).(NetworkAccessControlEntryResponseArrayOutput)
}

// Provisioning state of the hostingEnvironment (App Service Environment)
func (o LookupHostingEnvironmentResultOutput) ProvisioningState() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *string { return v.ProvisioningState }).(pulumi.StringPtrOutput)
}

// Resource group of the hostingEnvironment (App Service Environment)
func (o LookupHostingEnvironmentResultOutput) ResourceGroup() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *string { return v.ResourceGroup }).(pulumi.StringPtrOutput)
}

// Current status of the hostingEnvironment (App Service Environment)
func (o LookupHostingEnvironmentResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) string { return v.Status }).(pulumi.StringOutput)
}

// Subscription of the hostingEnvironment (App Service Environment)
func (o LookupHostingEnvironmentResultOutput) SubscriptionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *string { return v.SubscriptionId }).(pulumi.StringPtrOutput)
}

// True/false indicating whether the hostingEnvironment is suspended. The environment can be suspended e.g. when the management endpoint is no longer available
//             (most likely because NSG blocked the incoming traffic)
func (o LookupHostingEnvironmentResultOutput) Suspended() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *bool { return v.Suspended }).(pulumi.BoolPtrOutput)
}

// Resource tags
func (o LookupHostingEnvironmentResultOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) map[string]string { return v.Tags }).(pulumi.StringMapOutput)
}

// Resource type
func (o LookupHostingEnvironmentResultOutput) Type() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *string { return v.Type }).(pulumi.StringPtrOutput)
}

// Number of upgrade domains of this hostingEnvironment (App Service Environment)
func (o LookupHostingEnvironmentResultOutput) UpgradeDomains() pulumi.IntPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *int { return v.UpgradeDomains }).(pulumi.IntPtrOutput)
}

// Description of IP SSL mapping for this hostingEnvironment (App Service Environment)
func (o LookupHostingEnvironmentResultOutput) VipMappings() VirtualIPMappingResponseArrayOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) []VirtualIPMappingResponse { return v.VipMappings }).(VirtualIPMappingResponseArrayOutput)
}

// Description of the hostingEnvironment's (App Service Environment) virtual network
func (o LookupHostingEnvironmentResultOutput) VirtualNetwork() VirtualNetworkProfileResponsePtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *VirtualNetworkProfileResponse { return v.VirtualNetwork }).(VirtualNetworkProfileResponsePtrOutput)
}

// Name of the hostingEnvironment's (App Service Environment) virtual network
func (o LookupHostingEnvironmentResultOutput) VnetName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *string { return v.VnetName }).(pulumi.StringPtrOutput)
}

// Resource group of the hostingEnvironment's (App Service Environment) virtual network
func (o LookupHostingEnvironmentResultOutput) VnetResourceGroupName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *string { return v.VnetResourceGroupName }).(pulumi.StringPtrOutput)
}

// Subnet of the hostingEnvironment's (App Service Environment) virtual network
func (o LookupHostingEnvironmentResultOutput) VnetSubnetName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) *string { return v.VnetSubnetName }).(pulumi.StringPtrOutput)
}

// Description of worker pools with worker size ids, VM sizes, and number of workers in each pool
func (o LookupHostingEnvironmentResultOutput) WorkerPools() WorkerPoolResponseArrayOutput {
	return o.ApplyT(func(v LookupHostingEnvironmentResult) []WorkerPoolResponse { return v.WorkerPools }).(WorkerPoolResponseArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupHostingEnvironmentResultOutput{})
}
