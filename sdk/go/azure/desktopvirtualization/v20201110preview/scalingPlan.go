// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20201110preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Represents a scaling plan definition.
//
// Deprecated: Version 2020-11-10-preview will be removed in v2 of the provider.
type ScalingPlan struct {
	pulumi.CustomResourceState

	// Description of scaling plan.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Exclusion tag for scaling plan.
	ExclusionTag pulumi.StringPtrOutput `pulumi:"exclusionTag"`
	// User friendly name of scaling plan.
	FriendlyName pulumi.StringPtrOutput `pulumi:"friendlyName"`
	// List of ScalingHostPoolReference definitions.
	HostPoolReferences ScalingHostPoolReferenceResponseArrayOutput `pulumi:"hostPoolReferences"`
	// HostPool type for scaling plan.
	HostPoolType pulumi.StringPtrOutput `pulumi:"hostPoolType"`
	// The geo-location where the resource lives
	Location pulumi.StringOutput `pulumi:"location"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// List of ScalingSchedule definitions.
	Schedules ScalingScheduleResponseArrayOutput `pulumi:"schedules"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Timezone of the scaling plan.
	TimeZone pulumi.StringPtrOutput `pulumi:"timeZone"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewScalingPlan registers a new resource with the given unique name, arguments, and options.
func NewScalingPlan(ctx *pulumi.Context,
	name string, args *ScalingPlanArgs, opts ...pulumi.ResourceOption) (*ScalingPlan, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-native:desktopvirtualization:ScalingPlan"),
		},
		{
			Type: pulumi.String("azure-native:desktopvirtualization/v20210114preview:ScalingPlan"),
		},
		{
			Type: pulumi.String("azure-native:desktopvirtualization/v20210201preview:ScalingPlan"),
		},
		{
			Type: pulumi.String("azure-native:desktopvirtualization/v20210309preview:ScalingPlan"),
		},
		{
			Type: pulumi.String("azure-native:desktopvirtualization/v20210401preview:ScalingPlan"),
		},
		{
			Type: pulumi.String("azure-native:desktopvirtualization/v20210712:ScalingPlan"),
		},
		{
			Type: pulumi.String("azure-native:desktopvirtualization/v20210903preview:ScalingPlan"),
		},
		{
			Type: pulumi.String("azure-native:desktopvirtualization/v20220210preview:ScalingPlan"),
		},
		{
			Type: pulumi.String("azure-native:desktopvirtualization/v20220401preview:ScalingPlan"),
		},
	})
	opts = append(opts, aliases)
	var resource ScalingPlan
	err := ctx.RegisterResource("azure-native:desktopvirtualization/v20201110preview:ScalingPlan", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetScalingPlan gets an existing ScalingPlan resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetScalingPlan(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ScalingPlanState, opts ...pulumi.ResourceOption) (*ScalingPlan, error) {
	var resource ScalingPlan
	err := ctx.ReadResource("azure-native:desktopvirtualization/v20201110preview:ScalingPlan", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ScalingPlan resources.
type scalingPlanState struct {
}

type ScalingPlanState struct {
}

func (ScalingPlanState) ElementType() reflect.Type {
	return reflect.TypeOf((*scalingPlanState)(nil)).Elem()
}

type scalingPlanArgs struct {
	// Description of scaling plan.
	Description *string `pulumi:"description"`
	// Exclusion tag for scaling plan.
	ExclusionTag *string `pulumi:"exclusionTag"`
	// User friendly name of scaling plan.
	FriendlyName *string `pulumi:"friendlyName"`
	// List of ScalingHostPoolReference definitions.
	HostPoolReferences []ScalingHostPoolReference `pulumi:"hostPoolReferences"`
	// HostPool type for scaling plan.
	HostPoolType *string `pulumi:"hostPoolType"`
	// The geo-location where the resource lives
	Location *string `pulumi:"location"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the scaling plan.
	ScalingPlanName *string `pulumi:"scalingPlanName"`
	// List of ScalingSchedule definitions.
	Schedules []ScalingSchedule `pulumi:"schedules"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Timezone of the scaling plan.
	TimeZone *string `pulumi:"timeZone"`
}

// The set of arguments for constructing a ScalingPlan resource.
type ScalingPlanArgs struct {
	// Description of scaling plan.
	Description pulumi.StringPtrInput
	// Exclusion tag for scaling plan.
	ExclusionTag pulumi.StringPtrInput
	// User friendly name of scaling plan.
	FriendlyName pulumi.StringPtrInput
	// List of ScalingHostPoolReference definitions.
	HostPoolReferences ScalingHostPoolReferenceArrayInput
	// HostPool type for scaling plan.
	HostPoolType pulumi.StringPtrInput
	// The geo-location where the resource lives
	Location pulumi.StringPtrInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// The name of the scaling plan.
	ScalingPlanName pulumi.StringPtrInput
	// List of ScalingSchedule definitions.
	Schedules ScalingScheduleArrayInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Timezone of the scaling plan.
	TimeZone pulumi.StringPtrInput
}

func (ScalingPlanArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*scalingPlanArgs)(nil)).Elem()
}

type ScalingPlanInput interface {
	pulumi.Input

	ToScalingPlanOutput() ScalingPlanOutput
	ToScalingPlanOutputWithContext(ctx context.Context) ScalingPlanOutput
}

func (*ScalingPlan) ElementType() reflect.Type {
	return reflect.TypeOf((**ScalingPlan)(nil)).Elem()
}

func (i *ScalingPlan) ToScalingPlanOutput() ScalingPlanOutput {
	return i.ToScalingPlanOutputWithContext(context.Background())
}

func (i *ScalingPlan) ToScalingPlanOutputWithContext(ctx context.Context) ScalingPlanOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ScalingPlanOutput)
}

type ScalingPlanOutput struct{ *pulumi.OutputState }

func (ScalingPlanOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ScalingPlan)(nil)).Elem()
}

func (o ScalingPlanOutput) ToScalingPlanOutput() ScalingPlanOutput {
	return o
}

func (o ScalingPlanOutput) ToScalingPlanOutputWithContext(ctx context.Context) ScalingPlanOutput {
	return o
}

// Description of scaling plan.
func (o ScalingPlanOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ScalingPlan) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// Exclusion tag for scaling plan.
func (o ScalingPlanOutput) ExclusionTag() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ScalingPlan) pulumi.StringPtrOutput { return v.ExclusionTag }).(pulumi.StringPtrOutput)
}

// User friendly name of scaling plan.
func (o ScalingPlanOutput) FriendlyName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ScalingPlan) pulumi.StringPtrOutput { return v.FriendlyName }).(pulumi.StringPtrOutput)
}

// List of ScalingHostPoolReference definitions.
func (o ScalingPlanOutput) HostPoolReferences() ScalingHostPoolReferenceResponseArrayOutput {
	return o.ApplyT(func(v *ScalingPlan) ScalingHostPoolReferenceResponseArrayOutput { return v.HostPoolReferences }).(ScalingHostPoolReferenceResponseArrayOutput)
}

// HostPool type for scaling plan.
func (o ScalingPlanOutput) HostPoolType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ScalingPlan) pulumi.StringPtrOutput { return v.HostPoolType }).(pulumi.StringPtrOutput)
}

// The geo-location where the resource lives
func (o ScalingPlanOutput) Location() pulumi.StringOutput {
	return o.ApplyT(func(v *ScalingPlan) pulumi.StringOutput { return v.Location }).(pulumi.StringOutput)
}

// The name of the resource
func (o ScalingPlanOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *ScalingPlan) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// List of ScalingSchedule definitions.
func (o ScalingPlanOutput) Schedules() ScalingScheduleResponseArrayOutput {
	return o.ApplyT(func(v *ScalingPlan) ScalingScheduleResponseArrayOutput { return v.Schedules }).(ScalingScheduleResponseArrayOutput)
}

// Resource tags.
func (o ScalingPlanOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v *ScalingPlan) pulumi.StringMapOutput { return v.Tags }).(pulumi.StringMapOutput)
}

// Timezone of the scaling plan.
func (o ScalingPlanOutput) TimeZone() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ScalingPlan) pulumi.StringPtrOutput { return v.TimeZone }).(pulumi.StringPtrOutput)
}

// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
func (o ScalingPlanOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *ScalingPlan) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(ScalingPlanOutput{})
}
