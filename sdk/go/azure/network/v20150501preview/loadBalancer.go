// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20150501preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// LoadBalancer resource
//
// Deprecated: Version 2015-05-01-preview will be removed in v2 of the provider.
type LoadBalancer struct {
	pulumi.CustomResourceState

	// Gets or sets Pools of backend IP addresses
	BackendAddressPools BackendAddressPoolResponseArrayOutput `pulumi:"backendAddressPools"`
	// Gets a unique read-only string that changes whenever the resource is updated
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// Gets or sets frontend IP addresses of the load balancer
	FrontendIPConfigurations FrontendIpConfigurationResponseArrayOutput `pulumi:"frontendIPConfigurations"`
	// Gets or sets inbound NAT pools
	InboundNatPools InboundNatPoolResponseArrayOutput `pulumi:"inboundNatPools"`
	// Gets or sets list of inbound rules
	InboundNatRules InboundNatRuleResponseArrayOutput `pulumi:"inboundNatRules"`
	// Gets or sets load balancing rules
	LoadBalancingRules LoadBalancingRuleResponseArrayOutput `pulumi:"loadBalancingRules"`
	// Resource location
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// Gets or sets outbound NAT rules
	OutboundNatRules OutboundNatRuleResponseArrayOutput `pulumi:"outboundNatRules"`
	// Gets or sets list of Load balancer probes
	Probes ProbeResponseArrayOutput `pulumi:"probes"`
	// Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
	ProvisioningState pulumi.StringPtrOutput `pulumi:"provisioningState"`
	// Gets or sets resource guid property of the Load balancer resource
	ResourceGuid pulumi.StringPtrOutput `pulumi:"resourceGuid"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewLoadBalancer registers a new resource with the given unique name, arguments, and options.
func NewLoadBalancer(ctx *pulumi.Context,
	name string, args *LoadBalancerArgs, opts ...pulumi.ResourceOption) (*LoadBalancer, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-native:network:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20150615:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20160330:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20160601:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20160901:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20161201:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20170301:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20170601:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20170801:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20170901:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20171001:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20171101:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20180101:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20180201:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20180401:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20180601:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20180701:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20180801:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20181001:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20181101:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20181201:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20190201:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20190401:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20190601:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20190701:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20190801:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20190901:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20191101:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20191201:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20200301:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20200401:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20200501:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20200601:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20200701:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20200801:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20201101:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20210201:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20210301:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20210501:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20210801:LoadBalancer"),
		},
		{
			Type: pulumi.String("azure-native:network/v20220101:LoadBalancer"),
		},
	})
	opts = append(opts, aliases)
	var resource LoadBalancer
	err := ctx.RegisterResource("azure-native:network/v20150501preview:LoadBalancer", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLoadBalancer gets an existing LoadBalancer resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLoadBalancer(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LoadBalancerState, opts ...pulumi.ResourceOption) (*LoadBalancer, error) {
	var resource LoadBalancer
	err := ctx.ReadResource("azure-native:network/v20150501preview:LoadBalancer", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering LoadBalancer resources.
type loadBalancerState struct {
}

type LoadBalancerState struct {
}

func (LoadBalancerState) ElementType() reflect.Type {
	return reflect.TypeOf((*loadBalancerState)(nil)).Elem()
}

type loadBalancerArgs struct {
	// Gets or sets Pools of backend IP addresses
	BackendAddressPools []BackendAddressPool `pulumi:"backendAddressPools"`
	// Gets or sets frontend IP addresses of the load balancer
	FrontendIPConfigurations []FrontendIpConfiguration `pulumi:"frontendIPConfigurations"`
	// Gets or sets inbound NAT pools
	InboundNatPools []InboundNatPool `pulumi:"inboundNatPools"`
	// Gets or sets list of inbound rules
	InboundNatRules []InboundNatRule `pulumi:"inboundNatRules"`
	// The name of the loadBalancer.
	LoadBalancerName *string `pulumi:"loadBalancerName"`
	// Gets or sets load balancing rules
	LoadBalancingRules []LoadBalancingRule `pulumi:"loadBalancingRules"`
	// Resource location
	Location *string `pulumi:"location"`
	// Gets or sets outbound NAT rules
	OutboundNatRules []OutboundNatRule `pulumi:"outboundNatRules"`
	// Gets or sets list of Load balancer probes
	Probes []Probe `pulumi:"probes"`
	// Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
	ProvisioningState *string `pulumi:"provisioningState"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Gets or sets resource guid property of the Load balancer resource
	ResourceGuid *string `pulumi:"resourceGuid"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a LoadBalancer resource.
type LoadBalancerArgs struct {
	// Gets or sets Pools of backend IP addresses
	BackendAddressPools BackendAddressPoolArrayInput
	// Gets or sets frontend IP addresses of the load balancer
	FrontendIPConfigurations FrontendIpConfigurationArrayInput
	// Gets or sets inbound NAT pools
	InboundNatPools InboundNatPoolArrayInput
	// Gets or sets list of inbound rules
	InboundNatRules InboundNatRuleArrayInput
	// The name of the loadBalancer.
	LoadBalancerName pulumi.StringPtrInput
	// Gets or sets load balancing rules
	LoadBalancingRules LoadBalancingRuleArrayInput
	// Resource location
	Location pulumi.StringPtrInput
	// Gets or sets outbound NAT rules
	OutboundNatRules OutboundNatRuleArrayInput
	// Gets or sets list of Load balancer probes
	Probes ProbeArrayInput
	// Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
	ProvisioningState pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Gets or sets resource guid property of the Load balancer resource
	ResourceGuid pulumi.StringPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
}

func (LoadBalancerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*loadBalancerArgs)(nil)).Elem()
}

type LoadBalancerInput interface {
	pulumi.Input

	ToLoadBalancerOutput() LoadBalancerOutput
	ToLoadBalancerOutputWithContext(ctx context.Context) LoadBalancerOutput
}

func (*LoadBalancer) ElementType() reflect.Type {
	return reflect.TypeOf((**LoadBalancer)(nil)).Elem()
}

func (i *LoadBalancer) ToLoadBalancerOutput() LoadBalancerOutput {
	return i.ToLoadBalancerOutputWithContext(context.Background())
}

func (i *LoadBalancer) ToLoadBalancerOutputWithContext(ctx context.Context) LoadBalancerOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LoadBalancerOutput)
}

type LoadBalancerOutput struct{ *pulumi.OutputState }

func (LoadBalancerOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**LoadBalancer)(nil)).Elem()
}

func (o LoadBalancerOutput) ToLoadBalancerOutput() LoadBalancerOutput {
	return o
}

func (o LoadBalancerOutput) ToLoadBalancerOutputWithContext(ctx context.Context) LoadBalancerOutput {
	return o
}

// Gets or sets Pools of backend IP addresses
func (o LoadBalancerOutput) BackendAddressPools() BackendAddressPoolResponseArrayOutput {
	return o.ApplyT(func(v *LoadBalancer) BackendAddressPoolResponseArrayOutput { return v.BackendAddressPools }).(BackendAddressPoolResponseArrayOutput)
}

// Gets a unique read-only string that changes whenever the resource is updated
func (o LoadBalancerOutput) Etag() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *LoadBalancer) pulumi.StringPtrOutput { return v.Etag }).(pulumi.StringPtrOutput)
}

// Gets or sets frontend IP addresses of the load balancer
func (o LoadBalancerOutput) FrontendIPConfigurations() FrontendIpConfigurationResponseArrayOutput {
	return o.ApplyT(func(v *LoadBalancer) FrontendIpConfigurationResponseArrayOutput { return v.FrontendIPConfigurations }).(FrontendIpConfigurationResponseArrayOutput)
}

// Gets or sets inbound NAT pools
func (o LoadBalancerOutput) InboundNatPools() InboundNatPoolResponseArrayOutput {
	return o.ApplyT(func(v *LoadBalancer) InboundNatPoolResponseArrayOutput { return v.InboundNatPools }).(InboundNatPoolResponseArrayOutput)
}

// Gets or sets list of inbound rules
func (o LoadBalancerOutput) InboundNatRules() InboundNatRuleResponseArrayOutput {
	return o.ApplyT(func(v *LoadBalancer) InboundNatRuleResponseArrayOutput { return v.InboundNatRules }).(InboundNatRuleResponseArrayOutput)
}

// Gets or sets load balancing rules
func (o LoadBalancerOutput) LoadBalancingRules() LoadBalancingRuleResponseArrayOutput {
	return o.ApplyT(func(v *LoadBalancer) LoadBalancingRuleResponseArrayOutput { return v.LoadBalancingRules }).(LoadBalancingRuleResponseArrayOutput)
}

// Resource location
func (o LoadBalancerOutput) Location() pulumi.StringOutput {
	return o.ApplyT(func(v *LoadBalancer) pulumi.StringOutput { return v.Location }).(pulumi.StringOutput)
}

// Resource name
func (o LoadBalancerOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *LoadBalancer) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Gets or sets outbound NAT rules
func (o LoadBalancerOutput) OutboundNatRules() OutboundNatRuleResponseArrayOutput {
	return o.ApplyT(func(v *LoadBalancer) OutboundNatRuleResponseArrayOutput { return v.OutboundNatRules }).(OutboundNatRuleResponseArrayOutput)
}

// Gets or sets list of Load balancer probes
func (o LoadBalancerOutput) Probes() ProbeResponseArrayOutput {
	return o.ApplyT(func(v *LoadBalancer) ProbeResponseArrayOutput { return v.Probes }).(ProbeResponseArrayOutput)
}

// Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
func (o LoadBalancerOutput) ProvisioningState() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *LoadBalancer) pulumi.StringPtrOutput { return v.ProvisioningState }).(pulumi.StringPtrOutput)
}

// Gets or sets resource guid property of the Load balancer resource
func (o LoadBalancerOutput) ResourceGuid() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *LoadBalancer) pulumi.StringPtrOutput { return v.ResourceGuid }).(pulumi.StringPtrOutput)
}

// Resource tags
func (o LoadBalancerOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v *LoadBalancer) pulumi.StringMapOutput { return v.Tags }).(pulumi.StringMapOutput)
}

// Resource type
func (o LoadBalancerOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *LoadBalancer) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LoadBalancerOutput{})
}
