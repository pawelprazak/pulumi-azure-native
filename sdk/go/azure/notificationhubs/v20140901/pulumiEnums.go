// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20140901

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type AccessRights string

const (
	AccessRightsManage = AccessRights("Manage")
	AccessRightsSend   = AccessRights("Send")
	AccessRightsListen = AccessRights("Listen")
)

func (AccessRights) ElementType() reflect.Type {
	return reflect.TypeOf((*AccessRights)(nil)).Elem()
}

func (e AccessRights) ToAccessRightsOutput() AccessRightsOutput {
	return pulumi.ToOutput(e).(AccessRightsOutput)
}

func (e AccessRights) ToAccessRightsOutputWithContext(ctx context.Context) AccessRightsOutput {
	return pulumi.ToOutputWithContext(ctx, e).(AccessRightsOutput)
}

func (e AccessRights) ToAccessRightsPtrOutput() AccessRightsPtrOutput {
	return e.ToAccessRightsPtrOutputWithContext(context.Background())
}

func (e AccessRights) ToAccessRightsPtrOutputWithContext(ctx context.Context) AccessRightsPtrOutput {
	return AccessRights(e).ToAccessRightsOutputWithContext(ctx).ToAccessRightsPtrOutputWithContext(ctx)
}

func (e AccessRights) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e AccessRights) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e AccessRights) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e AccessRights) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type AccessRightsOutput struct{ *pulumi.OutputState }

func (AccessRightsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AccessRights)(nil)).Elem()
}

func (o AccessRightsOutput) ToAccessRightsOutput() AccessRightsOutput {
	return o
}

func (o AccessRightsOutput) ToAccessRightsOutputWithContext(ctx context.Context) AccessRightsOutput {
	return o
}

func (o AccessRightsOutput) ToAccessRightsPtrOutput() AccessRightsPtrOutput {
	return o.ToAccessRightsPtrOutputWithContext(context.Background())
}

func (o AccessRightsOutput) ToAccessRightsPtrOutputWithContext(ctx context.Context) AccessRightsPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v AccessRights) *AccessRights {
		return &v
	}).(AccessRightsPtrOutput)
}

func (o AccessRightsOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o AccessRightsOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e AccessRights) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o AccessRightsOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o AccessRightsOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e AccessRights) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type AccessRightsPtrOutput struct{ *pulumi.OutputState }

func (AccessRightsPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AccessRights)(nil)).Elem()
}

func (o AccessRightsPtrOutput) ToAccessRightsPtrOutput() AccessRightsPtrOutput {
	return o
}

func (o AccessRightsPtrOutput) ToAccessRightsPtrOutputWithContext(ctx context.Context) AccessRightsPtrOutput {
	return o
}

func (o AccessRightsPtrOutput) Elem() AccessRightsOutput {
	return o.ApplyT(func(v *AccessRights) AccessRights {
		if v != nil {
			return *v
		}
		var ret AccessRights
		return ret
	}).(AccessRightsOutput)
}

func (o AccessRightsPtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o AccessRightsPtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *AccessRights) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// AccessRightsInput is an input type that accepts AccessRightsArgs and AccessRightsOutput values.
// You can construct a concrete instance of `AccessRightsInput` via:
//
//          AccessRightsArgs{...}
type AccessRightsInput interface {
	pulumi.Input

	ToAccessRightsOutput() AccessRightsOutput
	ToAccessRightsOutputWithContext(context.Context) AccessRightsOutput
}

var accessRightsPtrType = reflect.TypeOf((**AccessRights)(nil)).Elem()

type AccessRightsPtrInput interface {
	pulumi.Input

	ToAccessRightsPtrOutput() AccessRightsPtrOutput
	ToAccessRightsPtrOutputWithContext(context.Context) AccessRightsPtrOutput
}

type accessRightsPtr string

func AccessRightsPtr(v string) AccessRightsPtrInput {
	return (*accessRightsPtr)(&v)
}

func (*accessRightsPtr) ElementType() reflect.Type {
	return accessRightsPtrType
}

func (in *accessRightsPtr) ToAccessRightsPtrOutput() AccessRightsPtrOutput {
	return pulumi.ToOutput(in).(AccessRightsPtrOutput)
}

func (in *accessRightsPtr) ToAccessRightsPtrOutputWithContext(ctx context.Context) AccessRightsPtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(AccessRightsPtrOutput)
}

// AccessRightsArrayInput is an input type that accepts AccessRightsArray and AccessRightsArrayOutput values.
// You can construct a concrete instance of `AccessRightsArrayInput` via:
//
//          AccessRightsArray{ AccessRightsArgs{...} }
type AccessRightsArrayInput interface {
	pulumi.Input

	ToAccessRightsArrayOutput() AccessRightsArrayOutput
	ToAccessRightsArrayOutputWithContext(context.Context) AccessRightsArrayOutput
}

type AccessRightsArray []AccessRights

func (AccessRightsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]AccessRights)(nil)).Elem()
}

func (i AccessRightsArray) ToAccessRightsArrayOutput() AccessRightsArrayOutput {
	return i.ToAccessRightsArrayOutputWithContext(context.Background())
}

func (i AccessRightsArray) ToAccessRightsArrayOutputWithContext(ctx context.Context) AccessRightsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccessRightsArrayOutput)
}

type AccessRightsArrayOutput struct{ *pulumi.OutputState }

func (AccessRightsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]AccessRights)(nil)).Elem()
}

func (o AccessRightsArrayOutput) ToAccessRightsArrayOutput() AccessRightsArrayOutput {
	return o
}

func (o AccessRightsArrayOutput) ToAccessRightsArrayOutputWithContext(ctx context.Context) AccessRightsArrayOutput {
	return o
}

func (o AccessRightsArrayOutput) Index(i pulumi.IntInput) AccessRightsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) AccessRights {
		return vs[0].([]AccessRights)[vs[1].(int)]
	}).(AccessRightsOutput)
}

// Gets or sets the namespace type.
type NamespaceType string

const (
	NamespaceTypeMessaging       = NamespaceType("Messaging")
	NamespaceTypeNotificationHub = NamespaceType("NotificationHub")
)

func (NamespaceType) ElementType() reflect.Type {
	return reflect.TypeOf((*NamespaceType)(nil)).Elem()
}

func (e NamespaceType) ToNamespaceTypeOutput() NamespaceTypeOutput {
	return pulumi.ToOutput(e).(NamespaceTypeOutput)
}

func (e NamespaceType) ToNamespaceTypeOutputWithContext(ctx context.Context) NamespaceTypeOutput {
	return pulumi.ToOutputWithContext(ctx, e).(NamespaceTypeOutput)
}

func (e NamespaceType) ToNamespaceTypePtrOutput() NamespaceTypePtrOutput {
	return e.ToNamespaceTypePtrOutputWithContext(context.Background())
}

func (e NamespaceType) ToNamespaceTypePtrOutputWithContext(ctx context.Context) NamespaceTypePtrOutput {
	return NamespaceType(e).ToNamespaceTypeOutputWithContext(ctx).ToNamespaceTypePtrOutputWithContext(ctx)
}

func (e NamespaceType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e NamespaceType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e NamespaceType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e NamespaceType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type NamespaceTypeOutput struct{ *pulumi.OutputState }

func (NamespaceTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*NamespaceType)(nil)).Elem()
}

func (o NamespaceTypeOutput) ToNamespaceTypeOutput() NamespaceTypeOutput {
	return o
}

func (o NamespaceTypeOutput) ToNamespaceTypeOutputWithContext(ctx context.Context) NamespaceTypeOutput {
	return o
}

func (o NamespaceTypeOutput) ToNamespaceTypePtrOutput() NamespaceTypePtrOutput {
	return o.ToNamespaceTypePtrOutputWithContext(context.Background())
}

func (o NamespaceTypeOutput) ToNamespaceTypePtrOutputWithContext(ctx context.Context) NamespaceTypePtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v NamespaceType) *NamespaceType {
		return &v
	}).(NamespaceTypePtrOutput)
}

func (o NamespaceTypeOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o NamespaceTypeOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e NamespaceType) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o NamespaceTypeOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o NamespaceTypeOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e NamespaceType) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type NamespaceTypePtrOutput struct{ *pulumi.OutputState }

func (NamespaceTypePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**NamespaceType)(nil)).Elem()
}

func (o NamespaceTypePtrOutput) ToNamespaceTypePtrOutput() NamespaceTypePtrOutput {
	return o
}

func (o NamespaceTypePtrOutput) ToNamespaceTypePtrOutputWithContext(ctx context.Context) NamespaceTypePtrOutput {
	return o
}

func (o NamespaceTypePtrOutput) Elem() NamespaceTypeOutput {
	return o.ApplyT(func(v *NamespaceType) NamespaceType {
		if v != nil {
			return *v
		}
		var ret NamespaceType
		return ret
	}).(NamespaceTypeOutput)
}

func (o NamespaceTypePtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o NamespaceTypePtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *NamespaceType) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// NamespaceTypeInput is an input type that accepts NamespaceTypeArgs and NamespaceTypeOutput values.
// You can construct a concrete instance of `NamespaceTypeInput` via:
//
//          NamespaceTypeArgs{...}
type NamespaceTypeInput interface {
	pulumi.Input

	ToNamespaceTypeOutput() NamespaceTypeOutput
	ToNamespaceTypeOutputWithContext(context.Context) NamespaceTypeOutput
}

var namespaceTypePtrType = reflect.TypeOf((**NamespaceType)(nil)).Elem()

type NamespaceTypePtrInput interface {
	pulumi.Input

	ToNamespaceTypePtrOutput() NamespaceTypePtrOutput
	ToNamespaceTypePtrOutputWithContext(context.Context) NamespaceTypePtrOutput
}

type namespaceTypePtr string

func NamespaceTypePtr(v string) NamespaceTypePtrInput {
	return (*namespaceTypePtr)(&v)
}

func (*namespaceTypePtr) ElementType() reflect.Type {
	return namespaceTypePtrType
}

func (in *namespaceTypePtr) ToNamespaceTypePtrOutput() NamespaceTypePtrOutput {
	return pulumi.ToOutput(in).(NamespaceTypePtrOutput)
}

func (in *namespaceTypePtr) ToNamespaceTypePtrOutputWithContext(ctx context.Context) NamespaceTypePtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(NamespaceTypePtrOutput)
}

func init() {
	pulumi.RegisterOutputType(AccessRightsOutput{})
	pulumi.RegisterOutputType(AccessRightsPtrOutput{})
	pulumi.RegisterOutputType(AccessRightsArrayOutput{})
	pulumi.RegisterOutputType(NamespaceTypeOutput{})
	pulumi.RegisterOutputType(NamespaceTypePtrOutput{})
}
