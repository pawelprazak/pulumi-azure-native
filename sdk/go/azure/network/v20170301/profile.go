// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20170301

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Class representing a Traffic Manager profile.
//
// Deprecated: Version 2017-03-01 will be removed in v2 of the provider.
type Profile struct {
	pulumi.CustomResourceState

	// Gets or sets the DNS settings of the Traffic Manager profile.
	DnsConfig DnsConfigResponsePtrOutput `pulumi:"dnsConfig"`
	// Gets or sets the list of endpoints in the Traffic Manager profile.
	Endpoints EndpointResponseArrayOutput `pulumi:"endpoints"`
	// Resource location
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Gets or sets the endpoint monitoring settings of the Traffic Manager profile.
	MonitorConfig MonitorConfigResponsePtrOutput `pulumi:"monitorConfig"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// Gets or sets the status of the Traffic Manager profile.  Possible values are 'Enabled' and 'Disabled'.
	ProfileStatus pulumi.StringPtrOutput `pulumi:"profileStatus"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Gets or sets the traffic routing method of the Traffic Manager profile.  Possible values are 'Performance', 'Weighted', 'Priority' or 'Geographic'.
	TrafficRoutingMethod pulumi.StringPtrOutput `pulumi:"trafficRoutingMethod"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewProfile registers a new resource with the given unique name, arguments, and options.
func NewProfile(ctx *pulumi.Context,
	name string, args *ProfileArgs, opts ...pulumi.ResourceOption) (*Profile, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-native:network:Profile"),
		},
		{
			Type: pulumi.String("azure-native:network/v20151101:Profile"),
		},
		{
			Type: pulumi.String("azure-native:network/v20170501:Profile"),
		},
		{
			Type: pulumi.String("azure-native:network/v20180201:Profile"),
		},
		{
			Type: pulumi.String("azure-native:network/v20180301:Profile"),
		},
		{
			Type: pulumi.String("azure-native:network/v20180401:Profile"),
		},
		{
			Type: pulumi.String("azure-native:network/v20180801:Profile"),
		},
	})
	opts = append(opts, aliases)
	var resource Profile
	err := ctx.RegisterResource("azure-native:network/v20170301:Profile", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetProfile gets an existing Profile resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetProfile(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ProfileState, opts ...pulumi.ResourceOption) (*Profile, error) {
	var resource Profile
	err := ctx.ReadResource("azure-native:network/v20170301:Profile", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Profile resources.
type profileState struct {
}

type ProfileState struct {
}

func (ProfileState) ElementType() reflect.Type {
	return reflect.TypeOf((*profileState)(nil)).Elem()
}

type profileArgs struct {
	// Gets or sets the DNS settings of the Traffic Manager profile.
	DnsConfig *DnsConfig `pulumi:"dnsConfig"`
	// Gets or sets the list of endpoints in the Traffic Manager profile.
	Endpoints []EndpointType `pulumi:"endpoints"`
	// Resource location
	Location *string `pulumi:"location"`
	// Gets or sets the endpoint monitoring settings of the Traffic Manager profile.
	MonitorConfig *MonitorConfig `pulumi:"monitorConfig"`
	// The name of the Traffic Manager profile.
	ProfileName *string `pulumi:"profileName"`
	// Gets or sets the status of the Traffic Manager profile.  Possible values are 'Enabled' and 'Disabled'.
	ProfileStatus *string `pulumi:"profileStatus"`
	// The name of the resource group containing the Traffic Manager profile.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Gets or sets the traffic routing method of the Traffic Manager profile.  Possible values are 'Performance', 'Weighted', 'Priority' or 'Geographic'.
	TrafficRoutingMethod *string `pulumi:"trafficRoutingMethod"`
}

// The set of arguments for constructing a Profile resource.
type ProfileArgs struct {
	// Gets or sets the DNS settings of the Traffic Manager profile.
	DnsConfig DnsConfigPtrInput
	// Gets or sets the list of endpoints in the Traffic Manager profile.
	Endpoints EndpointTypeArrayInput
	// Resource location
	Location pulumi.StringPtrInput
	// Gets or sets the endpoint monitoring settings of the Traffic Manager profile.
	MonitorConfig MonitorConfigPtrInput
	// The name of the Traffic Manager profile.
	ProfileName pulumi.StringPtrInput
	// Gets or sets the status of the Traffic Manager profile.  Possible values are 'Enabled' and 'Disabled'.
	ProfileStatus pulumi.StringPtrInput
	// The name of the resource group containing the Traffic Manager profile.
	ResourceGroupName pulumi.StringInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Gets or sets the traffic routing method of the Traffic Manager profile.  Possible values are 'Performance', 'Weighted', 'Priority' or 'Geographic'.
	TrafficRoutingMethod pulumi.StringPtrInput
}

func (ProfileArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*profileArgs)(nil)).Elem()
}

type ProfileInput interface {
	pulumi.Input

	ToProfileOutput() ProfileOutput
	ToProfileOutputWithContext(ctx context.Context) ProfileOutput
}

func (*Profile) ElementType() reflect.Type {
	return reflect.TypeOf((**Profile)(nil)).Elem()
}

func (i *Profile) ToProfileOutput() ProfileOutput {
	return i.ToProfileOutputWithContext(context.Background())
}

func (i *Profile) ToProfileOutputWithContext(ctx context.Context) ProfileOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProfileOutput)
}

type ProfileOutput struct{ *pulumi.OutputState }

func (ProfileOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Profile)(nil)).Elem()
}

func (o ProfileOutput) ToProfileOutput() ProfileOutput {
	return o
}

func (o ProfileOutput) ToProfileOutputWithContext(ctx context.Context) ProfileOutput {
	return o
}

// Gets or sets the DNS settings of the Traffic Manager profile.
func (o ProfileOutput) DnsConfig() DnsConfigResponsePtrOutput {
	return o.ApplyT(func(v *Profile) DnsConfigResponsePtrOutput { return v.DnsConfig }).(DnsConfigResponsePtrOutput)
}

// Gets or sets the list of endpoints in the Traffic Manager profile.
func (o ProfileOutput) Endpoints() EndpointResponseArrayOutput {
	return o.ApplyT(func(v *Profile) EndpointResponseArrayOutput { return v.Endpoints }).(EndpointResponseArrayOutput)
}

// Resource location
func (o ProfileOutput) Location() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Profile) pulumi.StringPtrOutput { return v.Location }).(pulumi.StringPtrOutput)
}

// Gets or sets the endpoint monitoring settings of the Traffic Manager profile.
func (o ProfileOutput) MonitorConfig() MonitorConfigResponsePtrOutput {
	return o.ApplyT(func(v *Profile) MonitorConfigResponsePtrOutput { return v.MonitorConfig }).(MonitorConfigResponsePtrOutput)
}

// Resource name
func (o ProfileOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Profile) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Gets or sets the status of the Traffic Manager profile.  Possible values are 'Enabled' and 'Disabled'.
func (o ProfileOutput) ProfileStatus() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Profile) pulumi.StringPtrOutput { return v.ProfileStatus }).(pulumi.StringPtrOutput)
}

// Resource tags
func (o ProfileOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v *Profile) pulumi.StringMapOutput { return v.Tags }).(pulumi.StringMapOutput)
}

// Gets or sets the traffic routing method of the Traffic Manager profile.  Possible values are 'Performance', 'Weighted', 'Priority' or 'Geographic'.
func (o ProfileOutput) TrafficRoutingMethod() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Profile) pulumi.StringPtrOutput { return v.TrafficRoutingMethod }).(pulumi.StringPtrOutput)
}

// Resource type
func (o ProfileOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *Profile) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(ProfileOutput{})
}
