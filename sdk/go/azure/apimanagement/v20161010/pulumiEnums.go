// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20161010

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Hostname type.
type HostnameType string

const (
	HostnameTypeProxy      = HostnameType("Proxy")
	HostnameTypePortal     = HostnameType("Portal")
	HostnameTypeManagement = HostnameType("Management")
	HostnameTypeScm        = HostnameType("Scm")
)

func (HostnameType) ElementType() reflect.Type {
	return reflect.TypeOf((*HostnameType)(nil)).Elem()
}

func (e HostnameType) ToHostnameTypeOutput() HostnameTypeOutput {
	return pulumi.ToOutput(e).(HostnameTypeOutput)
}

func (e HostnameType) ToHostnameTypeOutputWithContext(ctx context.Context) HostnameTypeOutput {
	return pulumi.ToOutputWithContext(ctx, e).(HostnameTypeOutput)
}

func (e HostnameType) ToHostnameTypePtrOutput() HostnameTypePtrOutput {
	return e.ToHostnameTypePtrOutputWithContext(context.Background())
}

func (e HostnameType) ToHostnameTypePtrOutputWithContext(ctx context.Context) HostnameTypePtrOutput {
	return HostnameType(e).ToHostnameTypeOutputWithContext(ctx).ToHostnameTypePtrOutputWithContext(ctx)
}

func (e HostnameType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e HostnameType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e HostnameType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e HostnameType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type HostnameTypeOutput struct{ *pulumi.OutputState }

func (HostnameTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*HostnameType)(nil)).Elem()
}

func (o HostnameTypeOutput) ToHostnameTypeOutput() HostnameTypeOutput {
	return o
}

func (o HostnameTypeOutput) ToHostnameTypeOutputWithContext(ctx context.Context) HostnameTypeOutput {
	return o
}

func (o HostnameTypeOutput) ToHostnameTypePtrOutput() HostnameTypePtrOutput {
	return o.ToHostnameTypePtrOutputWithContext(context.Background())
}

func (o HostnameTypeOutput) ToHostnameTypePtrOutputWithContext(ctx context.Context) HostnameTypePtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v HostnameType) *HostnameType {
		return &v
	}).(HostnameTypePtrOutput)
}

func (o HostnameTypeOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o HostnameTypeOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e HostnameType) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o HostnameTypeOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o HostnameTypeOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e HostnameType) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type HostnameTypePtrOutput struct{ *pulumi.OutputState }

func (HostnameTypePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**HostnameType)(nil)).Elem()
}

func (o HostnameTypePtrOutput) ToHostnameTypePtrOutput() HostnameTypePtrOutput {
	return o
}

func (o HostnameTypePtrOutput) ToHostnameTypePtrOutputWithContext(ctx context.Context) HostnameTypePtrOutput {
	return o
}

func (o HostnameTypePtrOutput) Elem() HostnameTypeOutput {
	return o.ApplyT(func(v *HostnameType) HostnameType {
		if v != nil {
			return *v
		}
		var ret HostnameType
		return ret
	}).(HostnameTypeOutput)
}

func (o HostnameTypePtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o HostnameTypePtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *HostnameType) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// HostnameTypeInput is an input type that accepts HostnameTypeArgs and HostnameTypeOutput values.
// You can construct a concrete instance of `HostnameTypeInput` via:
//
//          HostnameTypeArgs{...}
type HostnameTypeInput interface {
	pulumi.Input

	ToHostnameTypeOutput() HostnameTypeOutput
	ToHostnameTypeOutputWithContext(context.Context) HostnameTypeOutput
}

var hostnameTypePtrType = reflect.TypeOf((**HostnameType)(nil)).Elem()

type HostnameTypePtrInput interface {
	pulumi.Input

	ToHostnameTypePtrOutput() HostnameTypePtrOutput
	ToHostnameTypePtrOutputWithContext(context.Context) HostnameTypePtrOutput
}

type hostnameTypePtr string

func HostnameTypePtr(v string) HostnameTypePtrInput {
	return (*hostnameTypePtr)(&v)
}

func (*hostnameTypePtr) ElementType() reflect.Type {
	return hostnameTypePtrType
}

func (in *hostnameTypePtr) ToHostnameTypePtrOutput() HostnameTypePtrOutput {
	return pulumi.ToOutput(in).(HostnameTypePtrOutput)
}

func (in *hostnameTypePtr) ToHostnameTypePtrOutputWithContext(ctx context.Context) HostnameTypePtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(HostnameTypePtrOutput)
}

// The Key to be used to generate token for user.
type KeyTypeContract string

const (
	KeyTypeContractPrimary   = KeyTypeContract("primary")
	KeyTypeContractSecondary = KeyTypeContract("secondary")
)

func (KeyTypeContract) ElementType() reflect.Type {
	return reflect.TypeOf((*KeyTypeContract)(nil)).Elem()
}

func (e KeyTypeContract) ToKeyTypeContractOutput() KeyTypeContractOutput {
	return pulumi.ToOutput(e).(KeyTypeContractOutput)
}

func (e KeyTypeContract) ToKeyTypeContractOutputWithContext(ctx context.Context) KeyTypeContractOutput {
	return pulumi.ToOutputWithContext(ctx, e).(KeyTypeContractOutput)
}

func (e KeyTypeContract) ToKeyTypeContractPtrOutput() KeyTypeContractPtrOutput {
	return e.ToKeyTypeContractPtrOutputWithContext(context.Background())
}

func (e KeyTypeContract) ToKeyTypeContractPtrOutputWithContext(ctx context.Context) KeyTypeContractPtrOutput {
	return KeyTypeContract(e).ToKeyTypeContractOutputWithContext(ctx).ToKeyTypeContractPtrOutputWithContext(ctx)
}

func (e KeyTypeContract) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e KeyTypeContract) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e KeyTypeContract) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e KeyTypeContract) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type KeyTypeContractOutput struct{ *pulumi.OutputState }

func (KeyTypeContractOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*KeyTypeContract)(nil)).Elem()
}

func (o KeyTypeContractOutput) ToKeyTypeContractOutput() KeyTypeContractOutput {
	return o
}

func (o KeyTypeContractOutput) ToKeyTypeContractOutputWithContext(ctx context.Context) KeyTypeContractOutput {
	return o
}

func (o KeyTypeContractOutput) ToKeyTypeContractPtrOutput() KeyTypeContractPtrOutput {
	return o.ToKeyTypeContractPtrOutputWithContext(context.Background())
}

func (o KeyTypeContractOutput) ToKeyTypeContractPtrOutputWithContext(ctx context.Context) KeyTypeContractPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v KeyTypeContract) *KeyTypeContract {
		return &v
	}).(KeyTypeContractPtrOutput)
}

func (o KeyTypeContractOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o KeyTypeContractOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e KeyTypeContract) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o KeyTypeContractOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o KeyTypeContractOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e KeyTypeContract) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type KeyTypeContractPtrOutput struct{ *pulumi.OutputState }

func (KeyTypeContractPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**KeyTypeContract)(nil)).Elem()
}

func (o KeyTypeContractPtrOutput) ToKeyTypeContractPtrOutput() KeyTypeContractPtrOutput {
	return o
}

func (o KeyTypeContractPtrOutput) ToKeyTypeContractPtrOutputWithContext(ctx context.Context) KeyTypeContractPtrOutput {
	return o
}

func (o KeyTypeContractPtrOutput) Elem() KeyTypeContractOutput {
	return o.ApplyT(func(v *KeyTypeContract) KeyTypeContract {
		if v != nil {
			return *v
		}
		var ret KeyTypeContract
		return ret
	}).(KeyTypeContractOutput)
}

func (o KeyTypeContractPtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o KeyTypeContractPtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *KeyTypeContract) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// KeyTypeContractInput is an input type that accepts KeyTypeContractArgs and KeyTypeContractOutput values.
// You can construct a concrete instance of `KeyTypeContractInput` via:
//
//          KeyTypeContractArgs{...}
type KeyTypeContractInput interface {
	pulumi.Input

	ToKeyTypeContractOutput() KeyTypeContractOutput
	ToKeyTypeContractOutputWithContext(context.Context) KeyTypeContractOutput
}

var keyTypeContractPtrType = reflect.TypeOf((**KeyTypeContract)(nil)).Elem()

type KeyTypeContractPtrInput interface {
	pulumi.Input

	ToKeyTypeContractPtrOutput() KeyTypeContractPtrOutput
	ToKeyTypeContractPtrOutputWithContext(context.Context) KeyTypeContractPtrOutput
}

type keyTypeContractPtr string

func KeyTypeContractPtr(v string) KeyTypeContractPtrInput {
	return (*keyTypeContractPtr)(&v)
}

func (*keyTypeContractPtr) ElementType() reflect.Type {
	return keyTypeContractPtrType
}

func (in *keyTypeContractPtr) ToKeyTypeContractPtrOutput() KeyTypeContractPtrOutput {
	return pulumi.ToOutput(in).(KeyTypeContractPtrOutput)
}

func (in *keyTypeContractPtr) ToKeyTypeContractPtrOutputWithContext(ctx context.Context) KeyTypeContractPtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(KeyTypeContractPtrOutput)
}

// Name of the Sku.
type SkuType string

const (
	SkuTypeDeveloper = SkuType("Developer")
	SkuTypeStandard  = SkuType("Standard")
	SkuTypePremium   = SkuType("Premium")
)

func (SkuType) ElementType() reflect.Type {
	return reflect.TypeOf((*SkuType)(nil)).Elem()
}

func (e SkuType) ToSkuTypeOutput() SkuTypeOutput {
	return pulumi.ToOutput(e).(SkuTypeOutput)
}

func (e SkuType) ToSkuTypeOutputWithContext(ctx context.Context) SkuTypeOutput {
	return pulumi.ToOutputWithContext(ctx, e).(SkuTypeOutput)
}

func (e SkuType) ToSkuTypePtrOutput() SkuTypePtrOutput {
	return e.ToSkuTypePtrOutputWithContext(context.Background())
}

func (e SkuType) ToSkuTypePtrOutputWithContext(ctx context.Context) SkuTypePtrOutput {
	return SkuType(e).ToSkuTypeOutputWithContext(ctx).ToSkuTypePtrOutputWithContext(ctx)
}

func (e SkuType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e SkuType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e SkuType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e SkuType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type SkuTypeOutput struct{ *pulumi.OutputState }

func (SkuTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SkuType)(nil)).Elem()
}

func (o SkuTypeOutput) ToSkuTypeOutput() SkuTypeOutput {
	return o
}

func (o SkuTypeOutput) ToSkuTypeOutputWithContext(ctx context.Context) SkuTypeOutput {
	return o
}

func (o SkuTypeOutput) ToSkuTypePtrOutput() SkuTypePtrOutput {
	return o.ToSkuTypePtrOutputWithContext(context.Background())
}

func (o SkuTypeOutput) ToSkuTypePtrOutputWithContext(ctx context.Context) SkuTypePtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v SkuType) *SkuType {
		return &v
	}).(SkuTypePtrOutput)
}

func (o SkuTypeOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o SkuTypeOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e SkuType) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o SkuTypeOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o SkuTypeOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e SkuType) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type SkuTypePtrOutput struct{ *pulumi.OutputState }

func (SkuTypePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SkuType)(nil)).Elem()
}

func (o SkuTypePtrOutput) ToSkuTypePtrOutput() SkuTypePtrOutput {
	return o
}

func (o SkuTypePtrOutput) ToSkuTypePtrOutputWithContext(ctx context.Context) SkuTypePtrOutput {
	return o
}

func (o SkuTypePtrOutput) Elem() SkuTypeOutput {
	return o.ApplyT(func(v *SkuType) SkuType {
		if v != nil {
			return *v
		}
		var ret SkuType
		return ret
	}).(SkuTypeOutput)
}

func (o SkuTypePtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o SkuTypePtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *SkuType) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// SkuTypeInput is an input type that accepts SkuTypeArgs and SkuTypeOutput values.
// You can construct a concrete instance of `SkuTypeInput` via:
//
//          SkuTypeArgs{...}
type SkuTypeInput interface {
	pulumi.Input

	ToSkuTypeOutput() SkuTypeOutput
	ToSkuTypeOutputWithContext(context.Context) SkuTypeOutput
}

var skuTypePtrType = reflect.TypeOf((**SkuType)(nil)).Elem()

type SkuTypePtrInput interface {
	pulumi.Input

	ToSkuTypePtrOutput() SkuTypePtrOutput
	ToSkuTypePtrOutputWithContext(context.Context) SkuTypePtrOutput
}

type skuTypePtr string

func SkuTypePtr(v string) SkuTypePtrInput {
	return (*skuTypePtr)(&v)
}

func (*skuTypePtr) ElementType() reflect.Type {
	return skuTypePtrType
}

func (in *skuTypePtr) ToSkuTypePtrOutput() SkuTypePtrOutput {
	return pulumi.ToOutput(in).(SkuTypePtrOutput)
}

func (in *skuTypePtr) ToSkuTypePtrOutputWithContext(ctx context.Context) SkuTypePtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(SkuTypePtrOutput)
}

// The type of VPN in which API Management service needs to be configured in. None (Default Value) means the API Management service is not part of any Virtual Network, External means the API Management deployment is set up inside a Virtual Network having an Internet Facing Endpoint, and Internal means that API Management deployment is setup inside a Virtual Network having an Intranet Facing Endpoint only.
type VirtualNetworkType string

const (
	VirtualNetworkTypeNone     = VirtualNetworkType("None")
	VirtualNetworkTypeExternal = VirtualNetworkType("External")
	VirtualNetworkTypeInternal = VirtualNetworkType("Internal")
)

func (VirtualNetworkType) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualNetworkType)(nil)).Elem()
}

func (e VirtualNetworkType) ToVirtualNetworkTypeOutput() VirtualNetworkTypeOutput {
	return pulumi.ToOutput(e).(VirtualNetworkTypeOutput)
}

func (e VirtualNetworkType) ToVirtualNetworkTypeOutputWithContext(ctx context.Context) VirtualNetworkTypeOutput {
	return pulumi.ToOutputWithContext(ctx, e).(VirtualNetworkTypeOutput)
}

func (e VirtualNetworkType) ToVirtualNetworkTypePtrOutput() VirtualNetworkTypePtrOutput {
	return e.ToVirtualNetworkTypePtrOutputWithContext(context.Background())
}

func (e VirtualNetworkType) ToVirtualNetworkTypePtrOutputWithContext(ctx context.Context) VirtualNetworkTypePtrOutput {
	return VirtualNetworkType(e).ToVirtualNetworkTypeOutputWithContext(ctx).ToVirtualNetworkTypePtrOutputWithContext(ctx)
}

func (e VirtualNetworkType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e VirtualNetworkType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e VirtualNetworkType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e VirtualNetworkType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type VirtualNetworkTypeOutput struct{ *pulumi.OutputState }

func (VirtualNetworkTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualNetworkType)(nil)).Elem()
}

func (o VirtualNetworkTypeOutput) ToVirtualNetworkTypeOutput() VirtualNetworkTypeOutput {
	return o
}

func (o VirtualNetworkTypeOutput) ToVirtualNetworkTypeOutputWithContext(ctx context.Context) VirtualNetworkTypeOutput {
	return o
}

func (o VirtualNetworkTypeOutput) ToVirtualNetworkTypePtrOutput() VirtualNetworkTypePtrOutput {
	return o.ToVirtualNetworkTypePtrOutputWithContext(context.Background())
}

func (o VirtualNetworkTypeOutput) ToVirtualNetworkTypePtrOutputWithContext(ctx context.Context) VirtualNetworkTypePtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v VirtualNetworkType) *VirtualNetworkType {
		return &v
	}).(VirtualNetworkTypePtrOutput)
}

func (o VirtualNetworkTypeOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o VirtualNetworkTypeOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e VirtualNetworkType) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o VirtualNetworkTypeOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o VirtualNetworkTypeOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e VirtualNetworkType) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type VirtualNetworkTypePtrOutput struct{ *pulumi.OutputState }

func (VirtualNetworkTypePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**VirtualNetworkType)(nil)).Elem()
}

func (o VirtualNetworkTypePtrOutput) ToVirtualNetworkTypePtrOutput() VirtualNetworkTypePtrOutput {
	return o
}

func (o VirtualNetworkTypePtrOutput) ToVirtualNetworkTypePtrOutputWithContext(ctx context.Context) VirtualNetworkTypePtrOutput {
	return o
}

func (o VirtualNetworkTypePtrOutput) Elem() VirtualNetworkTypeOutput {
	return o.ApplyT(func(v *VirtualNetworkType) VirtualNetworkType {
		if v != nil {
			return *v
		}
		var ret VirtualNetworkType
		return ret
	}).(VirtualNetworkTypeOutput)
}

func (o VirtualNetworkTypePtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o VirtualNetworkTypePtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *VirtualNetworkType) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// VirtualNetworkTypeInput is an input type that accepts VirtualNetworkTypeArgs and VirtualNetworkTypeOutput values.
// You can construct a concrete instance of `VirtualNetworkTypeInput` via:
//
//          VirtualNetworkTypeArgs{...}
type VirtualNetworkTypeInput interface {
	pulumi.Input

	ToVirtualNetworkTypeOutput() VirtualNetworkTypeOutput
	ToVirtualNetworkTypeOutputWithContext(context.Context) VirtualNetworkTypeOutput
}

var virtualNetworkTypePtrType = reflect.TypeOf((**VirtualNetworkType)(nil)).Elem()

type VirtualNetworkTypePtrInput interface {
	pulumi.Input

	ToVirtualNetworkTypePtrOutput() VirtualNetworkTypePtrOutput
	ToVirtualNetworkTypePtrOutputWithContext(context.Context) VirtualNetworkTypePtrOutput
}

type virtualNetworkTypePtr string

func VirtualNetworkTypePtr(v string) VirtualNetworkTypePtrInput {
	return (*virtualNetworkTypePtr)(&v)
}

func (*virtualNetworkTypePtr) ElementType() reflect.Type {
	return virtualNetworkTypePtrType
}

func (in *virtualNetworkTypePtr) ToVirtualNetworkTypePtrOutput() VirtualNetworkTypePtrOutput {
	return pulumi.ToOutput(in).(VirtualNetworkTypePtrOutput)
}

func (in *virtualNetworkTypePtr) ToVirtualNetworkTypePtrOutputWithContext(ctx context.Context) VirtualNetworkTypePtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(VirtualNetworkTypePtrOutput)
}

func init() {
	pulumi.RegisterOutputType(HostnameTypeOutput{})
	pulumi.RegisterOutputType(HostnameTypePtrOutput{})
	pulumi.RegisterOutputType(KeyTypeContractOutput{})
	pulumi.RegisterOutputType(KeyTypeContractPtrOutput{})
	pulumi.RegisterOutputType(SkuTypeOutput{})
	pulumi.RegisterOutputType(SkuTypePtrOutput{})
	pulumi.RegisterOutputType(VirtualNetworkTypeOutput{})
	pulumi.RegisterOutputType(VirtualNetworkTypePtrOutput{})
}
