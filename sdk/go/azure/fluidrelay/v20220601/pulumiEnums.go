// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20220601

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Values can be SystemAssigned or UserAssigned
type CmkIdentityType string

const (
	CmkIdentityTypeSystemAssigned = CmkIdentityType("SystemAssigned")
	CmkIdentityTypeUserAssigned   = CmkIdentityType("UserAssigned")
)

func (CmkIdentityType) ElementType() reflect.Type {
	return reflect.TypeOf((*CmkIdentityType)(nil)).Elem()
}

func (e CmkIdentityType) ToCmkIdentityTypeOutput() CmkIdentityTypeOutput {
	return pulumi.ToOutput(e).(CmkIdentityTypeOutput)
}

func (e CmkIdentityType) ToCmkIdentityTypeOutputWithContext(ctx context.Context) CmkIdentityTypeOutput {
	return pulumi.ToOutputWithContext(ctx, e).(CmkIdentityTypeOutput)
}

func (e CmkIdentityType) ToCmkIdentityTypePtrOutput() CmkIdentityTypePtrOutput {
	return e.ToCmkIdentityTypePtrOutputWithContext(context.Background())
}

func (e CmkIdentityType) ToCmkIdentityTypePtrOutputWithContext(ctx context.Context) CmkIdentityTypePtrOutput {
	return CmkIdentityType(e).ToCmkIdentityTypeOutputWithContext(ctx).ToCmkIdentityTypePtrOutputWithContext(ctx)
}

func (e CmkIdentityType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e CmkIdentityType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e CmkIdentityType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e CmkIdentityType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type CmkIdentityTypeOutput struct{ *pulumi.OutputState }

func (CmkIdentityTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CmkIdentityType)(nil)).Elem()
}

func (o CmkIdentityTypeOutput) ToCmkIdentityTypeOutput() CmkIdentityTypeOutput {
	return o
}

func (o CmkIdentityTypeOutput) ToCmkIdentityTypeOutputWithContext(ctx context.Context) CmkIdentityTypeOutput {
	return o
}

func (o CmkIdentityTypeOutput) ToCmkIdentityTypePtrOutput() CmkIdentityTypePtrOutput {
	return o.ToCmkIdentityTypePtrOutputWithContext(context.Background())
}

func (o CmkIdentityTypeOutput) ToCmkIdentityTypePtrOutputWithContext(ctx context.Context) CmkIdentityTypePtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v CmkIdentityType) *CmkIdentityType {
		return &v
	}).(CmkIdentityTypePtrOutput)
}

func (o CmkIdentityTypeOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o CmkIdentityTypeOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e CmkIdentityType) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o CmkIdentityTypeOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o CmkIdentityTypeOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e CmkIdentityType) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type CmkIdentityTypePtrOutput struct{ *pulumi.OutputState }

func (CmkIdentityTypePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**CmkIdentityType)(nil)).Elem()
}

func (o CmkIdentityTypePtrOutput) ToCmkIdentityTypePtrOutput() CmkIdentityTypePtrOutput {
	return o
}

func (o CmkIdentityTypePtrOutput) ToCmkIdentityTypePtrOutputWithContext(ctx context.Context) CmkIdentityTypePtrOutput {
	return o
}

func (o CmkIdentityTypePtrOutput) Elem() CmkIdentityTypeOutput {
	return o.ApplyT(func(v *CmkIdentityType) CmkIdentityType {
		if v != nil {
			return *v
		}
		var ret CmkIdentityType
		return ret
	}).(CmkIdentityTypeOutput)
}

func (o CmkIdentityTypePtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o CmkIdentityTypePtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *CmkIdentityType) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// CmkIdentityTypeInput is an input type that accepts CmkIdentityTypeArgs and CmkIdentityTypeOutput values.
// You can construct a concrete instance of `CmkIdentityTypeInput` via:
//
//          CmkIdentityTypeArgs{...}
type CmkIdentityTypeInput interface {
	pulumi.Input

	ToCmkIdentityTypeOutput() CmkIdentityTypeOutput
	ToCmkIdentityTypeOutputWithContext(context.Context) CmkIdentityTypeOutput
}

var cmkIdentityTypePtrType = reflect.TypeOf((**CmkIdentityType)(nil)).Elem()

type CmkIdentityTypePtrInput interface {
	pulumi.Input

	ToCmkIdentityTypePtrOutput() CmkIdentityTypePtrOutput
	ToCmkIdentityTypePtrOutputWithContext(context.Context) CmkIdentityTypePtrOutput
}

type cmkIdentityTypePtr string

func CmkIdentityTypePtr(v string) CmkIdentityTypePtrInput {
	return (*cmkIdentityTypePtr)(&v)
}

func (*cmkIdentityTypePtr) ElementType() reflect.Type {
	return cmkIdentityTypePtrType
}

func (in *cmkIdentityTypePtr) ToCmkIdentityTypePtrOutput() CmkIdentityTypePtrOutput {
	return pulumi.ToOutput(in).(CmkIdentityTypePtrOutput)
}

func (in *cmkIdentityTypePtr) ToCmkIdentityTypePtrOutputWithContext(ctx context.Context) CmkIdentityTypePtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(CmkIdentityTypePtrOutput)
}

// Provision states for FluidRelay RP
type ProvisioningState string

const (
	ProvisioningStateSucceeded = ProvisioningState("Succeeded")
	ProvisioningStateFailed    = ProvisioningState("Failed")
	ProvisioningStateCanceled  = ProvisioningState("Canceled")
)

// The identity type.
type ResourceIdentityType string

const (
	ResourceIdentityTypeSystemAssigned               = ResourceIdentityType("SystemAssigned")
	ResourceIdentityTypeUserAssigned                 = ResourceIdentityType("UserAssigned")
	ResourceIdentityType_SystemAssigned_UserAssigned = ResourceIdentityType("SystemAssigned, UserAssigned")
	ResourceIdentityTypeNone                         = ResourceIdentityType("None")
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

// Sku of the storage associated with the resource
type StorageSKU string

const (
	StorageSKUStandard = StorageSKU("standard")
	StorageSKUBasic    = StorageSKU("basic")
)

func init() {
	pulumi.RegisterOutputType(CmkIdentityTypeOutput{})
	pulumi.RegisterOutputType(CmkIdentityTypePtrOutput{})
	pulumi.RegisterOutputType(ResourceIdentityTypeOutput{})
	pulumi.RegisterOutputType(ResourceIdentityTypePtrOutput{})
}
