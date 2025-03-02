// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20211201

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Confluent Offer detail
type OfferDetail struct {
	// Offer Id
	Id string `pulumi:"id"`
	// Offer Plan Id
	PlanId string `pulumi:"planId"`
	// Offer Plan Name
	PlanName string `pulumi:"planName"`
	// Publisher Id
	PublisherId string `pulumi:"publisherId"`
	// Offer Plan Term unit
	TermUnit string `pulumi:"termUnit"`
}

// OfferDetailInput is an input type that accepts OfferDetailArgs and OfferDetailOutput values.
// You can construct a concrete instance of `OfferDetailInput` via:
//
//          OfferDetailArgs{...}
type OfferDetailInput interface {
	pulumi.Input

	ToOfferDetailOutput() OfferDetailOutput
	ToOfferDetailOutputWithContext(context.Context) OfferDetailOutput
}

// Confluent Offer detail
type OfferDetailArgs struct {
	// Offer Id
	Id pulumi.StringInput `pulumi:"id"`
	// Offer Plan Id
	PlanId pulumi.StringInput `pulumi:"planId"`
	// Offer Plan Name
	PlanName pulumi.StringInput `pulumi:"planName"`
	// Publisher Id
	PublisherId pulumi.StringInput `pulumi:"publisherId"`
	// Offer Plan Term unit
	TermUnit pulumi.StringInput `pulumi:"termUnit"`
}

func (OfferDetailArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*OfferDetail)(nil)).Elem()
}

func (i OfferDetailArgs) ToOfferDetailOutput() OfferDetailOutput {
	return i.ToOfferDetailOutputWithContext(context.Background())
}

func (i OfferDetailArgs) ToOfferDetailOutputWithContext(ctx context.Context) OfferDetailOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OfferDetailOutput)
}

// Confluent Offer detail
type OfferDetailOutput struct{ *pulumi.OutputState }

func (OfferDetailOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*OfferDetail)(nil)).Elem()
}

func (o OfferDetailOutput) ToOfferDetailOutput() OfferDetailOutput {
	return o
}

func (o OfferDetailOutput) ToOfferDetailOutputWithContext(ctx context.Context) OfferDetailOutput {
	return o
}

// Offer Id
func (o OfferDetailOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v OfferDetail) string { return v.Id }).(pulumi.StringOutput)
}

// Offer Plan Id
func (o OfferDetailOutput) PlanId() pulumi.StringOutput {
	return o.ApplyT(func(v OfferDetail) string { return v.PlanId }).(pulumi.StringOutput)
}

// Offer Plan Name
func (o OfferDetailOutput) PlanName() pulumi.StringOutput {
	return o.ApplyT(func(v OfferDetail) string { return v.PlanName }).(pulumi.StringOutput)
}

// Publisher Id
func (o OfferDetailOutput) PublisherId() pulumi.StringOutput {
	return o.ApplyT(func(v OfferDetail) string { return v.PublisherId }).(pulumi.StringOutput)
}

// Offer Plan Term unit
func (o OfferDetailOutput) TermUnit() pulumi.StringOutput {
	return o.ApplyT(func(v OfferDetail) string { return v.TermUnit }).(pulumi.StringOutput)
}

// Confluent Offer detail
type OfferDetailResponse struct {
	// Offer Id
	Id string `pulumi:"id"`
	// Offer Plan Id
	PlanId string `pulumi:"planId"`
	// Offer Plan Name
	PlanName string `pulumi:"planName"`
	// Publisher Id
	PublisherId string `pulumi:"publisherId"`
	// SaaS Offer Status
	Status string `pulumi:"status"`
	// Offer Plan Term unit
	TermUnit string `pulumi:"termUnit"`
}

// Confluent Offer detail
type OfferDetailResponseOutput struct{ *pulumi.OutputState }

func (OfferDetailResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*OfferDetailResponse)(nil)).Elem()
}

func (o OfferDetailResponseOutput) ToOfferDetailResponseOutput() OfferDetailResponseOutput {
	return o
}

func (o OfferDetailResponseOutput) ToOfferDetailResponseOutputWithContext(ctx context.Context) OfferDetailResponseOutput {
	return o
}

// Offer Id
func (o OfferDetailResponseOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v OfferDetailResponse) string { return v.Id }).(pulumi.StringOutput)
}

// Offer Plan Id
func (o OfferDetailResponseOutput) PlanId() pulumi.StringOutput {
	return o.ApplyT(func(v OfferDetailResponse) string { return v.PlanId }).(pulumi.StringOutput)
}

// Offer Plan Name
func (o OfferDetailResponseOutput) PlanName() pulumi.StringOutput {
	return o.ApplyT(func(v OfferDetailResponse) string { return v.PlanName }).(pulumi.StringOutput)
}

// Publisher Id
func (o OfferDetailResponseOutput) PublisherId() pulumi.StringOutput {
	return o.ApplyT(func(v OfferDetailResponse) string { return v.PublisherId }).(pulumi.StringOutput)
}

// SaaS Offer Status
func (o OfferDetailResponseOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v OfferDetailResponse) string { return v.Status }).(pulumi.StringOutput)
}

// Offer Plan Term unit
func (o OfferDetailResponseOutput) TermUnit() pulumi.StringOutput {
	return o.ApplyT(func(v OfferDetailResponse) string { return v.TermUnit }).(pulumi.StringOutput)
}

// Metadata pertaining to creation and last modification of the resource.
type SystemDataResponse struct {
	// The timestamp of resource creation (UTC).
	CreatedAt *string `pulumi:"createdAt"`
	// The identity that created the resource.
	CreatedBy *string `pulumi:"createdBy"`
	// The type of identity that created the resource.
	CreatedByType *string `pulumi:"createdByType"`
	// The timestamp of resource last modification (UTC)
	LastModifiedAt *string `pulumi:"lastModifiedAt"`
	// The identity that last modified the resource.
	LastModifiedBy *string `pulumi:"lastModifiedBy"`
	// The type of identity that last modified the resource.
	LastModifiedByType *string `pulumi:"lastModifiedByType"`
}

// Metadata pertaining to creation and last modification of the resource.
type SystemDataResponseOutput struct{ *pulumi.OutputState }

func (SystemDataResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SystemDataResponse)(nil)).Elem()
}

func (o SystemDataResponseOutput) ToSystemDataResponseOutput() SystemDataResponseOutput {
	return o
}

func (o SystemDataResponseOutput) ToSystemDataResponseOutputWithContext(ctx context.Context) SystemDataResponseOutput {
	return o
}

// The timestamp of resource creation (UTC).
func (o SystemDataResponseOutput) CreatedAt() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SystemDataResponse) *string { return v.CreatedAt }).(pulumi.StringPtrOutput)
}

// The identity that created the resource.
func (o SystemDataResponseOutput) CreatedBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SystemDataResponse) *string { return v.CreatedBy }).(pulumi.StringPtrOutput)
}

// The type of identity that created the resource.
func (o SystemDataResponseOutput) CreatedByType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SystemDataResponse) *string { return v.CreatedByType }).(pulumi.StringPtrOutput)
}

// The timestamp of resource last modification (UTC)
func (o SystemDataResponseOutput) LastModifiedAt() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SystemDataResponse) *string { return v.LastModifiedAt }).(pulumi.StringPtrOutput)
}

// The identity that last modified the resource.
func (o SystemDataResponseOutput) LastModifiedBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SystemDataResponse) *string { return v.LastModifiedBy }).(pulumi.StringPtrOutput)
}

// The type of identity that last modified the resource.
func (o SystemDataResponseOutput) LastModifiedByType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SystemDataResponse) *string { return v.LastModifiedByType }).(pulumi.StringPtrOutput)
}

// Subscriber detail
type UserDetail struct {
	// Email address
	EmailAddress string `pulumi:"emailAddress"`
	// First name
	FirstName *string `pulumi:"firstName"`
	// Last name
	LastName *string `pulumi:"lastName"`
}

// UserDetailInput is an input type that accepts UserDetailArgs and UserDetailOutput values.
// You can construct a concrete instance of `UserDetailInput` via:
//
//          UserDetailArgs{...}
type UserDetailInput interface {
	pulumi.Input

	ToUserDetailOutput() UserDetailOutput
	ToUserDetailOutputWithContext(context.Context) UserDetailOutput
}

// Subscriber detail
type UserDetailArgs struct {
	// Email address
	EmailAddress pulumi.StringInput `pulumi:"emailAddress"`
	// First name
	FirstName pulumi.StringPtrInput `pulumi:"firstName"`
	// Last name
	LastName pulumi.StringPtrInput `pulumi:"lastName"`
}

func (UserDetailArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*UserDetail)(nil)).Elem()
}

func (i UserDetailArgs) ToUserDetailOutput() UserDetailOutput {
	return i.ToUserDetailOutputWithContext(context.Background())
}

func (i UserDetailArgs) ToUserDetailOutputWithContext(ctx context.Context) UserDetailOutput {
	return pulumi.ToOutputWithContext(ctx, i).(UserDetailOutput)
}

// Subscriber detail
type UserDetailOutput struct{ *pulumi.OutputState }

func (UserDetailOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*UserDetail)(nil)).Elem()
}

func (o UserDetailOutput) ToUserDetailOutput() UserDetailOutput {
	return o
}

func (o UserDetailOutput) ToUserDetailOutputWithContext(ctx context.Context) UserDetailOutput {
	return o
}

// Email address
func (o UserDetailOutput) EmailAddress() pulumi.StringOutput {
	return o.ApplyT(func(v UserDetail) string { return v.EmailAddress }).(pulumi.StringOutput)
}

// First name
func (o UserDetailOutput) FirstName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v UserDetail) *string { return v.FirstName }).(pulumi.StringPtrOutput)
}

// Last name
func (o UserDetailOutput) LastName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v UserDetail) *string { return v.LastName }).(pulumi.StringPtrOutput)
}

// Subscriber detail
type UserDetailResponse struct {
	// Email address
	EmailAddress string `pulumi:"emailAddress"`
	// First name
	FirstName *string `pulumi:"firstName"`
	// Last name
	LastName *string `pulumi:"lastName"`
}

// Subscriber detail
type UserDetailResponseOutput struct{ *pulumi.OutputState }

func (UserDetailResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*UserDetailResponse)(nil)).Elem()
}

func (o UserDetailResponseOutput) ToUserDetailResponseOutput() UserDetailResponseOutput {
	return o
}

func (o UserDetailResponseOutput) ToUserDetailResponseOutputWithContext(ctx context.Context) UserDetailResponseOutput {
	return o
}

// Email address
func (o UserDetailResponseOutput) EmailAddress() pulumi.StringOutput {
	return o.ApplyT(func(v UserDetailResponse) string { return v.EmailAddress }).(pulumi.StringOutput)
}

// First name
func (o UserDetailResponseOutput) FirstName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v UserDetailResponse) *string { return v.FirstName }).(pulumi.StringPtrOutput)
}

// Last name
func (o UserDetailResponseOutput) LastName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v UserDetailResponse) *string { return v.LastName }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(OfferDetailOutput{})
	pulumi.RegisterOutputType(OfferDetailResponseOutput{})
	pulumi.RegisterOutputType(SystemDataResponseOutput{})
	pulumi.RegisterOutputType(UserDetailOutput{})
	pulumi.RegisterOutputType(UserDetailResponseOutput{})
}
