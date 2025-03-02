// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20170228preview

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// A role defining the data plane operations that a principal can perform on a Time Series Insights client.
type AccessPolicyRole string

const (
	AccessPolicyRoleReader      = AccessPolicyRole("Reader")
	AccessPolicyRoleContributor = AccessPolicyRole("Contributor")
)

func (AccessPolicyRole) ElementType() reflect.Type {
	return reflect.TypeOf((*AccessPolicyRole)(nil)).Elem()
}

func (e AccessPolicyRole) ToAccessPolicyRoleOutput() AccessPolicyRoleOutput {
	return pulumi.ToOutput(e).(AccessPolicyRoleOutput)
}

func (e AccessPolicyRole) ToAccessPolicyRoleOutputWithContext(ctx context.Context) AccessPolicyRoleOutput {
	return pulumi.ToOutputWithContext(ctx, e).(AccessPolicyRoleOutput)
}

func (e AccessPolicyRole) ToAccessPolicyRolePtrOutput() AccessPolicyRolePtrOutput {
	return e.ToAccessPolicyRolePtrOutputWithContext(context.Background())
}

func (e AccessPolicyRole) ToAccessPolicyRolePtrOutputWithContext(ctx context.Context) AccessPolicyRolePtrOutput {
	return AccessPolicyRole(e).ToAccessPolicyRoleOutputWithContext(ctx).ToAccessPolicyRolePtrOutputWithContext(ctx)
}

func (e AccessPolicyRole) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e AccessPolicyRole) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e AccessPolicyRole) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e AccessPolicyRole) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type AccessPolicyRoleOutput struct{ *pulumi.OutputState }

func (AccessPolicyRoleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AccessPolicyRole)(nil)).Elem()
}

func (o AccessPolicyRoleOutput) ToAccessPolicyRoleOutput() AccessPolicyRoleOutput {
	return o
}

func (o AccessPolicyRoleOutput) ToAccessPolicyRoleOutputWithContext(ctx context.Context) AccessPolicyRoleOutput {
	return o
}

func (o AccessPolicyRoleOutput) ToAccessPolicyRolePtrOutput() AccessPolicyRolePtrOutput {
	return o.ToAccessPolicyRolePtrOutputWithContext(context.Background())
}

func (o AccessPolicyRoleOutput) ToAccessPolicyRolePtrOutputWithContext(ctx context.Context) AccessPolicyRolePtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v AccessPolicyRole) *AccessPolicyRole {
		return &v
	}).(AccessPolicyRolePtrOutput)
}

func (o AccessPolicyRoleOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o AccessPolicyRoleOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e AccessPolicyRole) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o AccessPolicyRoleOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o AccessPolicyRoleOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e AccessPolicyRole) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type AccessPolicyRolePtrOutput struct{ *pulumi.OutputState }

func (AccessPolicyRolePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AccessPolicyRole)(nil)).Elem()
}

func (o AccessPolicyRolePtrOutput) ToAccessPolicyRolePtrOutput() AccessPolicyRolePtrOutput {
	return o
}

func (o AccessPolicyRolePtrOutput) ToAccessPolicyRolePtrOutputWithContext(ctx context.Context) AccessPolicyRolePtrOutput {
	return o
}

func (o AccessPolicyRolePtrOutput) Elem() AccessPolicyRoleOutput {
	return o.ApplyT(func(v *AccessPolicyRole) AccessPolicyRole {
		if v != nil {
			return *v
		}
		var ret AccessPolicyRole
		return ret
	}).(AccessPolicyRoleOutput)
}

func (o AccessPolicyRolePtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o AccessPolicyRolePtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *AccessPolicyRole) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// AccessPolicyRoleInput is an input type that accepts AccessPolicyRoleArgs and AccessPolicyRoleOutput values.
// You can construct a concrete instance of `AccessPolicyRoleInput` via:
//
//          AccessPolicyRoleArgs{...}
type AccessPolicyRoleInput interface {
	pulumi.Input

	ToAccessPolicyRoleOutput() AccessPolicyRoleOutput
	ToAccessPolicyRoleOutputWithContext(context.Context) AccessPolicyRoleOutput
}

var accessPolicyRolePtrType = reflect.TypeOf((**AccessPolicyRole)(nil)).Elem()

type AccessPolicyRolePtrInput interface {
	pulumi.Input

	ToAccessPolicyRolePtrOutput() AccessPolicyRolePtrOutput
	ToAccessPolicyRolePtrOutputWithContext(context.Context) AccessPolicyRolePtrOutput
}

type accessPolicyRolePtr string

func AccessPolicyRolePtr(v string) AccessPolicyRolePtrInput {
	return (*accessPolicyRolePtr)(&v)
}

func (*accessPolicyRolePtr) ElementType() reflect.Type {
	return accessPolicyRolePtrType
}

func (in *accessPolicyRolePtr) ToAccessPolicyRolePtrOutput() AccessPolicyRolePtrOutput {
	return pulumi.ToOutput(in).(AccessPolicyRolePtrOutput)
}

func (in *accessPolicyRolePtr) ToAccessPolicyRolePtrOutputWithContext(ctx context.Context) AccessPolicyRolePtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(AccessPolicyRolePtrOutput)
}

// AccessPolicyRoleArrayInput is an input type that accepts AccessPolicyRoleArray and AccessPolicyRoleArrayOutput values.
// You can construct a concrete instance of `AccessPolicyRoleArrayInput` via:
//
//          AccessPolicyRoleArray{ AccessPolicyRoleArgs{...} }
type AccessPolicyRoleArrayInput interface {
	pulumi.Input

	ToAccessPolicyRoleArrayOutput() AccessPolicyRoleArrayOutput
	ToAccessPolicyRoleArrayOutputWithContext(context.Context) AccessPolicyRoleArrayOutput
}

type AccessPolicyRoleArray []AccessPolicyRole

func (AccessPolicyRoleArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]AccessPolicyRole)(nil)).Elem()
}

func (i AccessPolicyRoleArray) ToAccessPolicyRoleArrayOutput() AccessPolicyRoleArrayOutput {
	return i.ToAccessPolicyRoleArrayOutputWithContext(context.Background())
}

func (i AccessPolicyRoleArray) ToAccessPolicyRoleArrayOutputWithContext(ctx context.Context) AccessPolicyRoleArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccessPolicyRoleArrayOutput)
}

type AccessPolicyRoleArrayOutput struct{ *pulumi.OutputState }

func (AccessPolicyRoleArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]AccessPolicyRole)(nil)).Elem()
}

func (o AccessPolicyRoleArrayOutput) ToAccessPolicyRoleArrayOutput() AccessPolicyRoleArrayOutput {
	return o
}

func (o AccessPolicyRoleArrayOutput) ToAccessPolicyRoleArrayOutputWithContext(ctx context.Context) AccessPolicyRoleArrayOutput {
	return o
}

func (o AccessPolicyRoleArrayOutput) Index(i pulumi.IntInput) AccessPolicyRoleOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) AccessPolicyRole {
		return vs[0].([]AccessPolicyRole)[vs[1].(int)]
	}).(AccessPolicyRoleOutput)
}

// The kind of the event source.
type Kind string

const (
	Kind_Microsoft_EventHub = Kind("Microsoft.EventHub")
	Kind_Microsoft_IoTHub   = Kind("Microsoft.IoTHub")
)

func (Kind) ElementType() reflect.Type {
	return reflect.TypeOf((*Kind)(nil)).Elem()
}

func (e Kind) ToKindOutput() KindOutput {
	return pulumi.ToOutput(e).(KindOutput)
}

func (e Kind) ToKindOutputWithContext(ctx context.Context) KindOutput {
	return pulumi.ToOutputWithContext(ctx, e).(KindOutput)
}

func (e Kind) ToKindPtrOutput() KindPtrOutput {
	return e.ToKindPtrOutputWithContext(context.Background())
}

func (e Kind) ToKindPtrOutputWithContext(ctx context.Context) KindPtrOutput {
	return Kind(e).ToKindOutputWithContext(ctx).ToKindPtrOutputWithContext(ctx)
}

func (e Kind) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e Kind) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e Kind) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e Kind) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type KindOutput struct{ *pulumi.OutputState }

func (KindOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Kind)(nil)).Elem()
}

func (o KindOutput) ToKindOutput() KindOutput {
	return o
}

func (o KindOutput) ToKindOutputWithContext(ctx context.Context) KindOutput {
	return o
}

func (o KindOutput) ToKindPtrOutput() KindPtrOutput {
	return o.ToKindPtrOutputWithContext(context.Background())
}

func (o KindOutput) ToKindPtrOutputWithContext(ctx context.Context) KindPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v Kind) *Kind {
		return &v
	}).(KindPtrOutput)
}

func (o KindOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o KindOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e Kind) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o KindOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o KindOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e Kind) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type KindPtrOutput struct{ *pulumi.OutputState }

func (KindPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Kind)(nil)).Elem()
}

func (o KindPtrOutput) ToKindPtrOutput() KindPtrOutput {
	return o
}

func (o KindPtrOutput) ToKindPtrOutputWithContext(ctx context.Context) KindPtrOutput {
	return o
}

func (o KindPtrOutput) Elem() KindOutput {
	return o.ApplyT(func(v *Kind) Kind {
		if v != nil {
			return *v
		}
		var ret Kind
		return ret
	}).(KindOutput)
}

func (o KindPtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o KindPtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *Kind) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// KindInput is an input type that accepts KindArgs and KindOutput values.
// You can construct a concrete instance of `KindInput` via:
//
//          KindArgs{...}
type KindInput interface {
	pulumi.Input

	ToKindOutput() KindOutput
	ToKindOutputWithContext(context.Context) KindOutput
}

var kindPtrType = reflect.TypeOf((**Kind)(nil)).Elem()

type KindPtrInput interface {
	pulumi.Input

	ToKindPtrOutput() KindPtrOutput
	ToKindPtrOutputWithContext(context.Context) KindPtrOutput
}

type kindPtr string

func KindPtr(v string) KindPtrInput {
	return (*kindPtr)(&v)
}

func (*kindPtr) ElementType() reflect.Type {
	return kindPtrType
}

func (in *kindPtr) ToKindPtrOutput() KindPtrOutput {
	return pulumi.ToOutput(in).(KindPtrOutput)
}

func (in *kindPtr) ToKindPtrOutputWithContext(ctx context.Context) KindPtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(KindPtrOutput)
}

// The type of the key property.
type ReferenceDataKeyPropertyType string

const (
	ReferenceDataKeyPropertyTypeString   = ReferenceDataKeyPropertyType("String")
	ReferenceDataKeyPropertyTypeDouble   = ReferenceDataKeyPropertyType("Double")
	ReferenceDataKeyPropertyTypeBool     = ReferenceDataKeyPropertyType("Bool")
	ReferenceDataKeyPropertyTypeDateTime = ReferenceDataKeyPropertyType("DateTime")
)

func (ReferenceDataKeyPropertyType) ElementType() reflect.Type {
	return reflect.TypeOf((*ReferenceDataKeyPropertyType)(nil)).Elem()
}

func (e ReferenceDataKeyPropertyType) ToReferenceDataKeyPropertyTypeOutput() ReferenceDataKeyPropertyTypeOutput {
	return pulumi.ToOutput(e).(ReferenceDataKeyPropertyTypeOutput)
}

func (e ReferenceDataKeyPropertyType) ToReferenceDataKeyPropertyTypeOutputWithContext(ctx context.Context) ReferenceDataKeyPropertyTypeOutput {
	return pulumi.ToOutputWithContext(ctx, e).(ReferenceDataKeyPropertyTypeOutput)
}

func (e ReferenceDataKeyPropertyType) ToReferenceDataKeyPropertyTypePtrOutput() ReferenceDataKeyPropertyTypePtrOutput {
	return e.ToReferenceDataKeyPropertyTypePtrOutputWithContext(context.Background())
}

func (e ReferenceDataKeyPropertyType) ToReferenceDataKeyPropertyTypePtrOutputWithContext(ctx context.Context) ReferenceDataKeyPropertyTypePtrOutput {
	return ReferenceDataKeyPropertyType(e).ToReferenceDataKeyPropertyTypeOutputWithContext(ctx).ToReferenceDataKeyPropertyTypePtrOutputWithContext(ctx)
}

func (e ReferenceDataKeyPropertyType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e ReferenceDataKeyPropertyType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e ReferenceDataKeyPropertyType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e ReferenceDataKeyPropertyType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type ReferenceDataKeyPropertyTypeOutput struct{ *pulumi.OutputState }

func (ReferenceDataKeyPropertyTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ReferenceDataKeyPropertyType)(nil)).Elem()
}

func (o ReferenceDataKeyPropertyTypeOutput) ToReferenceDataKeyPropertyTypeOutput() ReferenceDataKeyPropertyTypeOutput {
	return o
}

func (o ReferenceDataKeyPropertyTypeOutput) ToReferenceDataKeyPropertyTypeOutputWithContext(ctx context.Context) ReferenceDataKeyPropertyTypeOutput {
	return o
}

func (o ReferenceDataKeyPropertyTypeOutput) ToReferenceDataKeyPropertyTypePtrOutput() ReferenceDataKeyPropertyTypePtrOutput {
	return o.ToReferenceDataKeyPropertyTypePtrOutputWithContext(context.Background())
}

func (o ReferenceDataKeyPropertyTypeOutput) ToReferenceDataKeyPropertyTypePtrOutputWithContext(ctx context.Context) ReferenceDataKeyPropertyTypePtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v ReferenceDataKeyPropertyType) *ReferenceDataKeyPropertyType {
		return &v
	}).(ReferenceDataKeyPropertyTypePtrOutput)
}

func (o ReferenceDataKeyPropertyTypeOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o ReferenceDataKeyPropertyTypeOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e ReferenceDataKeyPropertyType) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o ReferenceDataKeyPropertyTypeOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o ReferenceDataKeyPropertyTypeOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e ReferenceDataKeyPropertyType) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type ReferenceDataKeyPropertyTypePtrOutput struct{ *pulumi.OutputState }

func (ReferenceDataKeyPropertyTypePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ReferenceDataKeyPropertyType)(nil)).Elem()
}

func (o ReferenceDataKeyPropertyTypePtrOutput) ToReferenceDataKeyPropertyTypePtrOutput() ReferenceDataKeyPropertyTypePtrOutput {
	return o
}

func (o ReferenceDataKeyPropertyTypePtrOutput) ToReferenceDataKeyPropertyTypePtrOutputWithContext(ctx context.Context) ReferenceDataKeyPropertyTypePtrOutput {
	return o
}

func (o ReferenceDataKeyPropertyTypePtrOutput) Elem() ReferenceDataKeyPropertyTypeOutput {
	return o.ApplyT(func(v *ReferenceDataKeyPropertyType) ReferenceDataKeyPropertyType {
		if v != nil {
			return *v
		}
		var ret ReferenceDataKeyPropertyType
		return ret
	}).(ReferenceDataKeyPropertyTypeOutput)
}

func (o ReferenceDataKeyPropertyTypePtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o ReferenceDataKeyPropertyTypePtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *ReferenceDataKeyPropertyType) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// ReferenceDataKeyPropertyTypeInput is an input type that accepts ReferenceDataKeyPropertyTypeArgs and ReferenceDataKeyPropertyTypeOutput values.
// You can construct a concrete instance of `ReferenceDataKeyPropertyTypeInput` via:
//
//          ReferenceDataKeyPropertyTypeArgs{...}
type ReferenceDataKeyPropertyTypeInput interface {
	pulumi.Input

	ToReferenceDataKeyPropertyTypeOutput() ReferenceDataKeyPropertyTypeOutput
	ToReferenceDataKeyPropertyTypeOutputWithContext(context.Context) ReferenceDataKeyPropertyTypeOutput
}

var referenceDataKeyPropertyTypePtrType = reflect.TypeOf((**ReferenceDataKeyPropertyType)(nil)).Elem()

type ReferenceDataKeyPropertyTypePtrInput interface {
	pulumi.Input

	ToReferenceDataKeyPropertyTypePtrOutput() ReferenceDataKeyPropertyTypePtrOutput
	ToReferenceDataKeyPropertyTypePtrOutputWithContext(context.Context) ReferenceDataKeyPropertyTypePtrOutput
}

type referenceDataKeyPropertyTypePtr string

func ReferenceDataKeyPropertyTypePtr(v string) ReferenceDataKeyPropertyTypePtrInput {
	return (*referenceDataKeyPropertyTypePtr)(&v)
}

func (*referenceDataKeyPropertyTypePtr) ElementType() reflect.Type {
	return referenceDataKeyPropertyTypePtrType
}

func (in *referenceDataKeyPropertyTypePtr) ToReferenceDataKeyPropertyTypePtrOutput() ReferenceDataKeyPropertyTypePtrOutput {
	return pulumi.ToOutput(in).(ReferenceDataKeyPropertyTypePtrOutput)
}

func (in *referenceDataKeyPropertyTypePtr) ToReferenceDataKeyPropertyTypePtrOutputWithContext(ctx context.Context) ReferenceDataKeyPropertyTypePtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(ReferenceDataKeyPropertyTypePtrOutput)
}

// The name of this SKU.
type SkuName string

const (
	SkuNameS1 = SkuName("S1")
	SkuNameS2 = SkuName("S2")
)

func (SkuName) ElementType() reflect.Type {
	return reflect.TypeOf((*SkuName)(nil)).Elem()
}

func (e SkuName) ToSkuNameOutput() SkuNameOutput {
	return pulumi.ToOutput(e).(SkuNameOutput)
}

func (e SkuName) ToSkuNameOutputWithContext(ctx context.Context) SkuNameOutput {
	return pulumi.ToOutputWithContext(ctx, e).(SkuNameOutput)
}

func (e SkuName) ToSkuNamePtrOutput() SkuNamePtrOutput {
	return e.ToSkuNamePtrOutputWithContext(context.Background())
}

func (e SkuName) ToSkuNamePtrOutputWithContext(ctx context.Context) SkuNamePtrOutput {
	return SkuName(e).ToSkuNameOutputWithContext(ctx).ToSkuNamePtrOutputWithContext(ctx)
}

func (e SkuName) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e SkuName) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e SkuName) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e SkuName) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type SkuNameOutput struct{ *pulumi.OutputState }

func (SkuNameOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SkuName)(nil)).Elem()
}

func (o SkuNameOutput) ToSkuNameOutput() SkuNameOutput {
	return o
}

func (o SkuNameOutput) ToSkuNameOutputWithContext(ctx context.Context) SkuNameOutput {
	return o
}

func (o SkuNameOutput) ToSkuNamePtrOutput() SkuNamePtrOutput {
	return o.ToSkuNamePtrOutputWithContext(context.Background())
}

func (o SkuNameOutput) ToSkuNamePtrOutputWithContext(ctx context.Context) SkuNamePtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v SkuName) *SkuName {
		return &v
	}).(SkuNamePtrOutput)
}

func (o SkuNameOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o SkuNameOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e SkuName) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o SkuNameOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o SkuNameOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e SkuName) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type SkuNamePtrOutput struct{ *pulumi.OutputState }

func (SkuNamePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SkuName)(nil)).Elem()
}

func (o SkuNamePtrOutput) ToSkuNamePtrOutput() SkuNamePtrOutput {
	return o
}

func (o SkuNamePtrOutput) ToSkuNamePtrOutputWithContext(ctx context.Context) SkuNamePtrOutput {
	return o
}

func (o SkuNamePtrOutput) Elem() SkuNameOutput {
	return o.ApplyT(func(v *SkuName) SkuName {
		if v != nil {
			return *v
		}
		var ret SkuName
		return ret
	}).(SkuNameOutput)
}

func (o SkuNamePtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o SkuNamePtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *SkuName) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// SkuNameInput is an input type that accepts SkuNameArgs and SkuNameOutput values.
// You can construct a concrete instance of `SkuNameInput` via:
//
//          SkuNameArgs{...}
type SkuNameInput interface {
	pulumi.Input

	ToSkuNameOutput() SkuNameOutput
	ToSkuNameOutputWithContext(context.Context) SkuNameOutput
}

var skuNamePtrType = reflect.TypeOf((**SkuName)(nil)).Elem()

type SkuNamePtrInput interface {
	pulumi.Input

	ToSkuNamePtrOutput() SkuNamePtrOutput
	ToSkuNamePtrOutputWithContext(context.Context) SkuNamePtrOutput
}

type skuNamePtr string

func SkuNamePtr(v string) SkuNamePtrInput {
	return (*skuNamePtr)(&v)
}

func (*skuNamePtr) ElementType() reflect.Type {
	return skuNamePtrType
}

func (in *skuNamePtr) ToSkuNamePtrOutput() SkuNamePtrOutput {
	return pulumi.ToOutput(in).(SkuNamePtrOutput)
}

func (in *skuNamePtr) ToSkuNamePtrOutputWithContext(ctx context.Context) SkuNamePtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(SkuNamePtrOutput)
}

// The behavior the Time Series Insights service should take when the environment's capacity has been exceeded. If "PauseIngress" is specified, new events will not be read from the event source. If "PurgeOldData" is specified, new events will continue to be read and old events will be deleted from the environment. The default behavior is PurgeOldData.
type StorageLimitExceededBehavior string

const (
	StorageLimitExceededBehaviorPurgeOldData = StorageLimitExceededBehavior("PurgeOldData")
	StorageLimitExceededBehaviorPauseIngress = StorageLimitExceededBehavior("PauseIngress")
)

func (StorageLimitExceededBehavior) ElementType() reflect.Type {
	return reflect.TypeOf((*StorageLimitExceededBehavior)(nil)).Elem()
}

func (e StorageLimitExceededBehavior) ToStorageLimitExceededBehaviorOutput() StorageLimitExceededBehaviorOutput {
	return pulumi.ToOutput(e).(StorageLimitExceededBehaviorOutput)
}

func (e StorageLimitExceededBehavior) ToStorageLimitExceededBehaviorOutputWithContext(ctx context.Context) StorageLimitExceededBehaviorOutput {
	return pulumi.ToOutputWithContext(ctx, e).(StorageLimitExceededBehaviorOutput)
}

func (e StorageLimitExceededBehavior) ToStorageLimitExceededBehaviorPtrOutput() StorageLimitExceededBehaviorPtrOutput {
	return e.ToStorageLimitExceededBehaviorPtrOutputWithContext(context.Background())
}

func (e StorageLimitExceededBehavior) ToStorageLimitExceededBehaviorPtrOutputWithContext(ctx context.Context) StorageLimitExceededBehaviorPtrOutput {
	return StorageLimitExceededBehavior(e).ToStorageLimitExceededBehaviorOutputWithContext(ctx).ToStorageLimitExceededBehaviorPtrOutputWithContext(ctx)
}

func (e StorageLimitExceededBehavior) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e StorageLimitExceededBehavior) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e StorageLimitExceededBehavior) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e StorageLimitExceededBehavior) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type StorageLimitExceededBehaviorOutput struct{ *pulumi.OutputState }

func (StorageLimitExceededBehaviorOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*StorageLimitExceededBehavior)(nil)).Elem()
}

func (o StorageLimitExceededBehaviorOutput) ToStorageLimitExceededBehaviorOutput() StorageLimitExceededBehaviorOutput {
	return o
}

func (o StorageLimitExceededBehaviorOutput) ToStorageLimitExceededBehaviorOutputWithContext(ctx context.Context) StorageLimitExceededBehaviorOutput {
	return o
}

func (o StorageLimitExceededBehaviorOutput) ToStorageLimitExceededBehaviorPtrOutput() StorageLimitExceededBehaviorPtrOutput {
	return o.ToStorageLimitExceededBehaviorPtrOutputWithContext(context.Background())
}

func (o StorageLimitExceededBehaviorOutput) ToStorageLimitExceededBehaviorPtrOutputWithContext(ctx context.Context) StorageLimitExceededBehaviorPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v StorageLimitExceededBehavior) *StorageLimitExceededBehavior {
		return &v
	}).(StorageLimitExceededBehaviorPtrOutput)
}

func (o StorageLimitExceededBehaviorOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o StorageLimitExceededBehaviorOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e StorageLimitExceededBehavior) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o StorageLimitExceededBehaviorOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o StorageLimitExceededBehaviorOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e StorageLimitExceededBehavior) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type StorageLimitExceededBehaviorPtrOutput struct{ *pulumi.OutputState }

func (StorageLimitExceededBehaviorPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**StorageLimitExceededBehavior)(nil)).Elem()
}

func (o StorageLimitExceededBehaviorPtrOutput) ToStorageLimitExceededBehaviorPtrOutput() StorageLimitExceededBehaviorPtrOutput {
	return o
}

func (o StorageLimitExceededBehaviorPtrOutput) ToStorageLimitExceededBehaviorPtrOutputWithContext(ctx context.Context) StorageLimitExceededBehaviorPtrOutput {
	return o
}

func (o StorageLimitExceededBehaviorPtrOutput) Elem() StorageLimitExceededBehaviorOutput {
	return o.ApplyT(func(v *StorageLimitExceededBehavior) StorageLimitExceededBehavior {
		if v != nil {
			return *v
		}
		var ret StorageLimitExceededBehavior
		return ret
	}).(StorageLimitExceededBehaviorOutput)
}

func (o StorageLimitExceededBehaviorPtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o StorageLimitExceededBehaviorPtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *StorageLimitExceededBehavior) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// StorageLimitExceededBehaviorInput is an input type that accepts StorageLimitExceededBehaviorArgs and StorageLimitExceededBehaviorOutput values.
// You can construct a concrete instance of `StorageLimitExceededBehaviorInput` via:
//
//          StorageLimitExceededBehaviorArgs{...}
type StorageLimitExceededBehaviorInput interface {
	pulumi.Input

	ToStorageLimitExceededBehaviorOutput() StorageLimitExceededBehaviorOutput
	ToStorageLimitExceededBehaviorOutputWithContext(context.Context) StorageLimitExceededBehaviorOutput
}

var storageLimitExceededBehaviorPtrType = reflect.TypeOf((**StorageLimitExceededBehavior)(nil)).Elem()

type StorageLimitExceededBehaviorPtrInput interface {
	pulumi.Input

	ToStorageLimitExceededBehaviorPtrOutput() StorageLimitExceededBehaviorPtrOutput
	ToStorageLimitExceededBehaviorPtrOutputWithContext(context.Context) StorageLimitExceededBehaviorPtrOutput
}

type storageLimitExceededBehaviorPtr string

func StorageLimitExceededBehaviorPtr(v string) StorageLimitExceededBehaviorPtrInput {
	return (*storageLimitExceededBehaviorPtr)(&v)
}

func (*storageLimitExceededBehaviorPtr) ElementType() reflect.Type {
	return storageLimitExceededBehaviorPtrType
}

func (in *storageLimitExceededBehaviorPtr) ToStorageLimitExceededBehaviorPtrOutput() StorageLimitExceededBehaviorPtrOutput {
	return pulumi.ToOutput(in).(StorageLimitExceededBehaviorPtrOutput)
}

func (in *storageLimitExceededBehaviorPtr) ToStorageLimitExceededBehaviorPtrOutputWithContext(ctx context.Context) StorageLimitExceededBehaviorPtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(StorageLimitExceededBehaviorPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(AccessPolicyRoleOutput{})
	pulumi.RegisterOutputType(AccessPolicyRolePtrOutput{})
	pulumi.RegisterOutputType(AccessPolicyRoleArrayOutput{})
	pulumi.RegisterOutputType(KindOutput{})
	pulumi.RegisterOutputType(KindPtrOutput{})
	pulumi.RegisterOutputType(ReferenceDataKeyPropertyTypeOutput{})
	pulumi.RegisterOutputType(ReferenceDataKeyPropertyTypePtrOutput{})
	pulumi.RegisterOutputType(SkuNameOutput{})
	pulumi.RegisterOutputType(SkuNamePtrOutput{})
	pulumi.RegisterOutputType(StorageLimitExceededBehaviorOutput{})
	pulumi.RegisterOutputType(StorageLimitExceededBehaviorPtrOutput{})
}
