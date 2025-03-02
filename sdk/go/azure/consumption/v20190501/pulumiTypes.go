// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20190501

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// The start and end date for a budget.
type BudgetTimePeriod struct {
	// The end date for the budget. If not provided, we default this to 10 years from the start date.
	EndDate *string `pulumi:"endDate"`
	// The start date for the budget.
	StartDate string `pulumi:"startDate"`
}

// BudgetTimePeriodInput is an input type that accepts BudgetTimePeriodArgs and BudgetTimePeriodOutput values.
// You can construct a concrete instance of `BudgetTimePeriodInput` via:
//
//          BudgetTimePeriodArgs{...}
type BudgetTimePeriodInput interface {
	pulumi.Input

	ToBudgetTimePeriodOutput() BudgetTimePeriodOutput
	ToBudgetTimePeriodOutputWithContext(context.Context) BudgetTimePeriodOutput
}

// The start and end date for a budget.
type BudgetTimePeriodArgs struct {
	// The end date for the budget. If not provided, we default this to 10 years from the start date.
	EndDate pulumi.StringPtrInput `pulumi:"endDate"`
	// The start date for the budget.
	StartDate pulumi.StringInput `pulumi:"startDate"`
}

func (BudgetTimePeriodArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*BudgetTimePeriod)(nil)).Elem()
}

func (i BudgetTimePeriodArgs) ToBudgetTimePeriodOutput() BudgetTimePeriodOutput {
	return i.ToBudgetTimePeriodOutputWithContext(context.Background())
}

func (i BudgetTimePeriodArgs) ToBudgetTimePeriodOutputWithContext(ctx context.Context) BudgetTimePeriodOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BudgetTimePeriodOutput)
}

// The start and end date for a budget.
type BudgetTimePeriodOutput struct{ *pulumi.OutputState }

func (BudgetTimePeriodOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*BudgetTimePeriod)(nil)).Elem()
}

func (o BudgetTimePeriodOutput) ToBudgetTimePeriodOutput() BudgetTimePeriodOutput {
	return o
}

func (o BudgetTimePeriodOutput) ToBudgetTimePeriodOutputWithContext(ctx context.Context) BudgetTimePeriodOutput {
	return o
}

// The end date for the budget. If not provided, we default this to 10 years from the start date.
func (o BudgetTimePeriodOutput) EndDate() pulumi.StringPtrOutput {
	return o.ApplyT(func(v BudgetTimePeriod) *string { return v.EndDate }).(pulumi.StringPtrOutput)
}

// The start date for the budget.
func (o BudgetTimePeriodOutput) StartDate() pulumi.StringOutput {
	return o.ApplyT(func(v BudgetTimePeriod) string { return v.StartDate }).(pulumi.StringOutput)
}

// The start and end date for a budget.
type BudgetTimePeriodResponse struct {
	// The end date for the budget. If not provided, we default this to 10 years from the start date.
	EndDate *string `pulumi:"endDate"`
	// The start date for the budget.
	StartDate string `pulumi:"startDate"`
}

// The start and end date for a budget.
type BudgetTimePeriodResponseOutput struct{ *pulumi.OutputState }

func (BudgetTimePeriodResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*BudgetTimePeriodResponse)(nil)).Elem()
}

func (o BudgetTimePeriodResponseOutput) ToBudgetTimePeriodResponseOutput() BudgetTimePeriodResponseOutput {
	return o
}

func (o BudgetTimePeriodResponseOutput) ToBudgetTimePeriodResponseOutputWithContext(ctx context.Context) BudgetTimePeriodResponseOutput {
	return o
}

// The end date for the budget. If not provided, we default this to 10 years from the start date.
func (o BudgetTimePeriodResponseOutput) EndDate() pulumi.StringPtrOutput {
	return o.ApplyT(func(v BudgetTimePeriodResponse) *string { return v.EndDate }).(pulumi.StringPtrOutput)
}

// The start date for the budget.
func (o BudgetTimePeriodResponseOutput) StartDate() pulumi.StringOutput {
	return o.ApplyT(func(v BudgetTimePeriodResponse) string { return v.StartDate }).(pulumi.StringOutput)
}

// The current amount of cost which is being tracked for a budget.
type CurrentSpendResponse struct {
	// The total amount of cost which is being tracked by the budget.
	Amount float64 `pulumi:"amount"`
	// The unit of measure for the budget amount.
	Unit string `pulumi:"unit"`
}

// The current amount of cost which is being tracked for a budget.
type CurrentSpendResponseOutput struct{ *pulumi.OutputState }

func (CurrentSpendResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CurrentSpendResponse)(nil)).Elem()
}

func (o CurrentSpendResponseOutput) ToCurrentSpendResponseOutput() CurrentSpendResponseOutput {
	return o
}

func (o CurrentSpendResponseOutput) ToCurrentSpendResponseOutputWithContext(ctx context.Context) CurrentSpendResponseOutput {
	return o
}

// The total amount of cost which is being tracked by the budget.
func (o CurrentSpendResponseOutput) Amount() pulumi.Float64Output {
	return o.ApplyT(func(v CurrentSpendResponse) float64 { return v.Amount }).(pulumi.Float64Output)
}

// The unit of measure for the budget amount.
func (o CurrentSpendResponseOutput) Unit() pulumi.StringOutput {
	return o.ApplyT(func(v CurrentSpendResponse) string { return v.Unit }).(pulumi.StringOutput)
}

// May be used to filter budgets by user-specified dimensions and/or tags.
type Filter struct {
	// The list of filters on meters (GUID), mandatory for budgets of usage category.
	Meters []string `pulumi:"meters"`
	// The list of filters on resource groups, allowed at subscription level only.
	ResourceGroups []string `pulumi:"resourceGroups"`
	// The list of filters on resources.
	Resources []string `pulumi:"resources"`
	// The dictionary of filters on tags.
	Tags map[string][]string `pulumi:"tags"`
}

// FilterInput is an input type that accepts FilterArgs and FilterOutput values.
// You can construct a concrete instance of `FilterInput` via:
//
//          FilterArgs{...}
type FilterInput interface {
	pulumi.Input

	ToFilterOutput() FilterOutput
	ToFilterOutputWithContext(context.Context) FilterOutput
}

// May be used to filter budgets by user-specified dimensions and/or tags.
type FilterArgs struct {
	// The list of filters on meters (GUID), mandatory for budgets of usage category.
	Meters pulumi.StringArrayInput `pulumi:"meters"`
	// The list of filters on resource groups, allowed at subscription level only.
	ResourceGroups pulumi.StringArrayInput `pulumi:"resourceGroups"`
	// The list of filters on resources.
	Resources pulumi.StringArrayInput `pulumi:"resources"`
	// The dictionary of filters on tags.
	Tags pulumi.StringArrayMapInput `pulumi:"tags"`
}

func (FilterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*Filter)(nil)).Elem()
}

func (i FilterArgs) ToFilterOutput() FilterOutput {
	return i.ToFilterOutputWithContext(context.Background())
}

func (i FilterArgs) ToFilterOutputWithContext(ctx context.Context) FilterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FilterOutput)
}

func (i FilterArgs) ToFilterPtrOutput() FilterPtrOutput {
	return i.ToFilterPtrOutputWithContext(context.Background())
}

func (i FilterArgs) ToFilterPtrOutputWithContext(ctx context.Context) FilterPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FilterOutput).ToFilterPtrOutputWithContext(ctx)
}

// FilterPtrInput is an input type that accepts FilterArgs, FilterPtr and FilterPtrOutput values.
// You can construct a concrete instance of `FilterPtrInput` via:
//
//          FilterArgs{...}
//
//  or:
//
//          nil
type FilterPtrInput interface {
	pulumi.Input

	ToFilterPtrOutput() FilterPtrOutput
	ToFilterPtrOutputWithContext(context.Context) FilterPtrOutput
}

type filterPtrType FilterArgs

func FilterPtr(v *FilterArgs) FilterPtrInput {
	return (*filterPtrType)(v)
}

func (*filterPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**Filter)(nil)).Elem()
}

func (i *filterPtrType) ToFilterPtrOutput() FilterPtrOutput {
	return i.ToFilterPtrOutputWithContext(context.Background())
}

func (i *filterPtrType) ToFilterPtrOutputWithContext(ctx context.Context) FilterPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FilterPtrOutput)
}

// May be used to filter budgets by user-specified dimensions and/or tags.
type FilterOutput struct{ *pulumi.OutputState }

func (FilterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Filter)(nil)).Elem()
}

func (o FilterOutput) ToFilterOutput() FilterOutput {
	return o
}

func (o FilterOutput) ToFilterOutputWithContext(ctx context.Context) FilterOutput {
	return o
}

func (o FilterOutput) ToFilterPtrOutput() FilterPtrOutput {
	return o.ToFilterPtrOutputWithContext(context.Background())
}

func (o FilterOutput) ToFilterPtrOutputWithContext(ctx context.Context) FilterPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v Filter) *Filter {
		return &v
	}).(FilterPtrOutput)
}

// The list of filters on meters (GUID), mandatory for budgets of usage category.
func (o FilterOutput) Meters() pulumi.StringArrayOutput {
	return o.ApplyT(func(v Filter) []string { return v.Meters }).(pulumi.StringArrayOutput)
}

// The list of filters on resource groups, allowed at subscription level only.
func (o FilterOutput) ResourceGroups() pulumi.StringArrayOutput {
	return o.ApplyT(func(v Filter) []string { return v.ResourceGroups }).(pulumi.StringArrayOutput)
}

// The list of filters on resources.
func (o FilterOutput) Resources() pulumi.StringArrayOutput {
	return o.ApplyT(func(v Filter) []string { return v.Resources }).(pulumi.StringArrayOutput)
}

// The dictionary of filters on tags.
func (o FilterOutput) Tags() pulumi.StringArrayMapOutput {
	return o.ApplyT(func(v Filter) map[string][]string { return v.Tags }).(pulumi.StringArrayMapOutput)
}

type FilterPtrOutput struct{ *pulumi.OutputState }

func (FilterPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Filter)(nil)).Elem()
}

func (o FilterPtrOutput) ToFilterPtrOutput() FilterPtrOutput {
	return o
}

func (o FilterPtrOutput) ToFilterPtrOutputWithContext(ctx context.Context) FilterPtrOutput {
	return o
}

func (o FilterPtrOutput) Elem() FilterOutput {
	return o.ApplyT(func(v *Filter) Filter {
		if v != nil {
			return *v
		}
		var ret Filter
		return ret
	}).(FilterOutput)
}

// The list of filters on meters (GUID), mandatory for budgets of usage category.
func (o FilterPtrOutput) Meters() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *Filter) []string {
		if v == nil {
			return nil
		}
		return v.Meters
	}).(pulumi.StringArrayOutput)
}

// The list of filters on resource groups, allowed at subscription level only.
func (o FilterPtrOutput) ResourceGroups() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *Filter) []string {
		if v == nil {
			return nil
		}
		return v.ResourceGroups
	}).(pulumi.StringArrayOutput)
}

// The list of filters on resources.
func (o FilterPtrOutput) Resources() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *Filter) []string {
		if v == nil {
			return nil
		}
		return v.Resources
	}).(pulumi.StringArrayOutput)
}

// The dictionary of filters on tags.
func (o FilterPtrOutput) Tags() pulumi.StringArrayMapOutput {
	return o.ApplyT(func(v *Filter) map[string][]string {
		if v == nil {
			return nil
		}
		return v.Tags
	}).(pulumi.StringArrayMapOutput)
}

// May be used to filter budgets by user-specified dimensions and/or tags.
type FilterResponse struct {
	// The list of filters on meters (GUID), mandatory for budgets of usage category.
	Meters []string `pulumi:"meters"`
	// The list of filters on resource groups, allowed at subscription level only.
	ResourceGroups []string `pulumi:"resourceGroups"`
	// The list of filters on resources.
	Resources []string `pulumi:"resources"`
	// The dictionary of filters on tags.
	Tags map[string][]string `pulumi:"tags"`
}

// May be used to filter budgets by user-specified dimensions and/or tags.
type FilterResponseOutput struct{ *pulumi.OutputState }

func (FilterResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*FilterResponse)(nil)).Elem()
}

func (o FilterResponseOutput) ToFilterResponseOutput() FilterResponseOutput {
	return o
}

func (o FilterResponseOutput) ToFilterResponseOutputWithContext(ctx context.Context) FilterResponseOutput {
	return o
}

// The list of filters on meters (GUID), mandatory for budgets of usage category.
func (o FilterResponseOutput) Meters() pulumi.StringArrayOutput {
	return o.ApplyT(func(v FilterResponse) []string { return v.Meters }).(pulumi.StringArrayOutput)
}

// The list of filters on resource groups, allowed at subscription level only.
func (o FilterResponseOutput) ResourceGroups() pulumi.StringArrayOutput {
	return o.ApplyT(func(v FilterResponse) []string { return v.ResourceGroups }).(pulumi.StringArrayOutput)
}

// The list of filters on resources.
func (o FilterResponseOutput) Resources() pulumi.StringArrayOutput {
	return o.ApplyT(func(v FilterResponse) []string { return v.Resources }).(pulumi.StringArrayOutput)
}

// The dictionary of filters on tags.
func (o FilterResponseOutput) Tags() pulumi.StringArrayMapOutput {
	return o.ApplyT(func(v FilterResponse) map[string][]string { return v.Tags }).(pulumi.StringArrayMapOutput)
}

type FilterResponsePtrOutput struct{ *pulumi.OutputState }

func (FilterResponsePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**FilterResponse)(nil)).Elem()
}

func (o FilterResponsePtrOutput) ToFilterResponsePtrOutput() FilterResponsePtrOutput {
	return o
}

func (o FilterResponsePtrOutput) ToFilterResponsePtrOutputWithContext(ctx context.Context) FilterResponsePtrOutput {
	return o
}

func (o FilterResponsePtrOutput) Elem() FilterResponseOutput {
	return o.ApplyT(func(v *FilterResponse) FilterResponse {
		if v != nil {
			return *v
		}
		var ret FilterResponse
		return ret
	}).(FilterResponseOutput)
}

// The list of filters on meters (GUID), mandatory for budgets of usage category.
func (o FilterResponsePtrOutput) Meters() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *FilterResponse) []string {
		if v == nil {
			return nil
		}
		return v.Meters
	}).(pulumi.StringArrayOutput)
}

// The list of filters on resource groups, allowed at subscription level only.
func (o FilterResponsePtrOutput) ResourceGroups() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *FilterResponse) []string {
		if v == nil {
			return nil
		}
		return v.ResourceGroups
	}).(pulumi.StringArrayOutput)
}

// The list of filters on resources.
func (o FilterResponsePtrOutput) Resources() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *FilterResponse) []string {
		if v == nil {
			return nil
		}
		return v.Resources
	}).(pulumi.StringArrayOutput)
}

// The dictionary of filters on tags.
func (o FilterResponsePtrOutput) Tags() pulumi.StringArrayMapOutput {
	return o.ApplyT(func(v *FilterResponse) map[string][]string {
		if v == nil {
			return nil
		}
		return v.Tags
	}).(pulumi.StringArrayMapOutput)
}

// The notification associated with a budget.
type Notification struct {
	// Email addresses to send the budget notification to when the threshold is exceeded. Must have at least one contact email or contact group specified at the Subscription or Resource Group scopes. All other scopes must have at least one contact email specified.
	ContactEmails []string `pulumi:"contactEmails"`
	// Action groups to send the budget notification to when the threshold is exceeded. Must be provided as a fully qualified Azure resource id. Only supported at Subscription or Resource Group scopes.
	ContactGroups []string `pulumi:"contactGroups"`
	// Contact roles to send the budget notification to when the threshold is exceeded.
	ContactRoles []string `pulumi:"contactRoles"`
	// The notification is enabled or not.
	Enabled bool `pulumi:"enabled"`
	// The comparison operator.
	Operator string `pulumi:"operator"`
	// Threshold value associated with a notification. Notification is sent when the cost exceeded the threshold. It is always percent and has to be between 0 and 1000.
	Threshold float64 `pulumi:"threshold"`
	// The type of threshold
	ThresholdType *string `pulumi:"thresholdType"`
}

// Defaults sets the appropriate defaults for Notification
func (val *Notification) Defaults() *Notification {
	if val == nil {
		return nil
	}
	tmp := *val
	if isZero(tmp.ThresholdType) {
		thresholdType_ := "Actual"
		tmp.ThresholdType = &thresholdType_
	}
	return &tmp
}

// NotificationInput is an input type that accepts NotificationArgs and NotificationOutput values.
// You can construct a concrete instance of `NotificationInput` via:
//
//          NotificationArgs{...}
type NotificationInput interface {
	pulumi.Input

	ToNotificationOutput() NotificationOutput
	ToNotificationOutputWithContext(context.Context) NotificationOutput
}

// The notification associated with a budget.
type NotificationArgs struct {
	// Email addresses to send the budget notification to when the threshold is exceeded. Must have at least one contact email or contact group specified at the Subscription or Resource Group scopes. All other scopes must have at least one contact email specified.
	ContactEmails pulumi.StringArrayInput `pulumi:"contactEmails"`
	// Action groups to send the budget notification to when the threshold is exceeded. Must be provided as a fully qualified Azure resource id. Only supported at Subscription or Resource Group scopes.
	ContactGroups pulumi.StringArrayInput `pulumi:"contactGroups"`
	// Contact roles to send the budget notification to when the threshold is exceeded.
	ContactRoles pulumi.StringArrayInput `pulumi:"contactRoles"`
	// The notification is enabled or not.
	Enabled pulumi.BoolInput `pulumi:"enabled"`
	// The comparison operator.
	Operator pulumi.StringInput `pulumi:"operator"`
	// Threshold value associated with a notification. Notification is sent when the cost exceeded the threshold. It is always percent and has to be between 0 and 1000.
	Threshold pulumi.Float64Input `pulumi:"threshold"`
	// The type of threshold
	ThresholdType pulumi.StringPtrInput `pulumi:"thresholdType"`
}

// Defaults sets the appropriate defaults for NotificationArgs
func (val *NotificationArgs) Defaults() *NotificationArgs {
	if val == nil {
		return nil
	}
	tmp := *val
	if isZero(tmp.ThresholdType) {
		tmp.ThresholdType = pulumi.StringPtr("Actual")
	}
	return &tmp
}
func (NotificationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*Notification)(nil)).Elem()
}

func (i NotificationArgs) ToNotificationOutput() NotificationOutput {
	return i.ToNotificationOutputWithContext(context.Background())
}

func (i NotificationArgs) ToNotificationOutputWithContext(ctx context.Context) NotificationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NotificationOutput)
}

// NotificationMapInput is an input type that accepts NotificationMap and NotificationMapOutput values.
// You can construct a concrete instance of `NotificationMapInput` via:
//
//          NotificationMap{ "key": NotificationArgs{...} }
type NotificationMapInput interface {
	pulumi.Input

	ToNotificationMapOutput() NotificationMapOutput
	ToNotificationMapOutputWithContext(context.Context) NotificationMapOutput
}

type NotificationMap map[string]NotificationInput

func (NotificationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]Notification)(nil)).Elem()
}

func (i NotificationMap) ToNotificationMapOutput() NotificationMapOutput {
	return i.ToNotificationMapOutputWithContext(context.Background())
}

func (i NotificationMap) ToNotificationMapOutputWithContext(ctx context.Context) NotificationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NotificationMapOutput)
}

// The notification associated with a budget.
type NotificationOutput struct{ *pulumi.OutputState }

func (NotificationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Notification)(nil)).Elem()
}

func (o NotificationOutput) ToNotificationOutput() NotificationOutput {
	return o
}

func (o NotificationOutput) ToNotificationOutputWithContext(ctx context.Context) NotificationOutput {
	return o
}

// Email addresses to send the budget notification to when the threshold is exceeded. Must have at least one contact email or contact group specified at the Subscription or Resource Group scopes. All other scopes must have at least one contact email specified.
func (o NotificationOutput) ContactEmails() pulumi.StringArrayOutput {
	return o.ApplyT(func(v Notification) []string { return v.ContactEmails }).(pulumi.StringArrayOutput)
}

// Action groups to send the budget notification to when the threshold is exceeded. Must be provided as a fully qualified Azure resource id. Only supported at Subscription or Resource Group scopes.
func (o NotificationOutput) ContactGroups() pulumi.StringArrayOutput {
	return o.ApplyT(func(v Notification) []string { return v.ContactGroups }).(pulumi.StringArrayOutput)
}

// Contact roles to send the budget notification to when the threshold is exceeded.
func (o NotificationOutput) ContactRoles() pulumi.StringArrayOutput {
	return o.ApplyT(func(v Notification) []string { return v.ContactRoles }).(pulumi.StringArrayOutput)
}

// The notification is enabled or not.
func (o NotificationOutput) Enabled() pulumi.BoolOutput {
	return o.ApplyT(func(v Notification) bool { return v.Enabled }).(pulumi.BoolOutput)
}

// The comparison operator.
func (o NotificationOutput) Operator() pulumi.StringOutput {
	return o.ApplyT(func(v Notification) string { return v.Operator }).(pulumi.StringOutput)
}

// Threshold value associated with a notification. Notification is sent when the cost exceeded the threshold. It is always percent and has to be between 0 and 1000.
func (o NotificationOutput) Threshold() pulumi.Float64Output {
	return o.ApplyT(func(v Notification) float64 { return v.Threshold }).(pulumi.Float64Output)
}

// The type of threshold
func (o NotificationOutput) ThresholdType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Notification) *string { return v.ThresholdType }).(pulumi.StringPtrOutput)
}

type NotificationMapOutput struct{ *pulumi.OutputState }

func (NotificationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]Notification)(nil)).Elem()
}

func (o NotificationMapOutput) ToNotificationMapOutput() NotificationMapOutput {
	return o
}

func (o NotificationMapOutput) ToNotificationMapOutputWithContext(ctx context.Context) NotificationMapOutput {
	return o
}

func (o NotificationMapOutput) MapIndex(k pulumi.StringInput) NotificationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) Notification {
		return vs[0].(map[string]Notification)[vs[1].(string)]
	}).(NotificationOutput)
}

// The notification associated with a budget.
type NotificationResponse struct {
	// Email addresses to send the budget notification to when the threshold is exceeded. Must have at least one contact email or contact group specified at the Subscription or Resource Group scopes. All other scopes must have at least one contact email specified.
	ContactEmails []string `pulumi:"contactEmails"`
	// Action groups to send the budget notification to when the threshold is exceeded. Must be provided as a fully qualified Azure resource id. Only supported at Subscription or Resource Group scopes.
	ContactGroups []string `pulumi:"contactGroups"`
	// Contact roles to send the budget notification to when the threshold is exceeded.
	ContactRoles []string `pulumi:"contactRoles"`
	// The notification is enabled or not.
	Enabled bool `pulumi:"enabled"`
	// The comparison operator.
	Operator string `pulumi:"operator"`
	// Threshold value associated with a notification. Notification is sent when the cost exceeded the threshold. It is always percent and has to be between 0 and 1000.
	Threshold float64 `pulumi:"threshold"`
	// The type of threshold
	ThresholdType *string `pulumi:"thresholdType"`
}

// Defaults sets the appropriate defaults for NotificationResponse
func (val *NotificationResponse) Defaults() *NotificationResponse {
	if val == nil {
		return nil
	}
	tmp := *val
	if isZero(tmp.ThresholdType) {
		thresholdType_ := "Actual"
		tmp.ThresholdType = &thresholdType_
	}
	return &tmp
}

// The notification associated with a budget.
type NotificationResponseOutput struct{ *pulumi.OutputState }

func (NotificationResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*NotificationResponse)(nil)).Elem()
}

func (o NotificationResponseOutput) ToNotificationResponseOutput() NotificationResponseOutput {
	return o
}

func (o NotificationResponseOutput) ToNotificationResponseOutputWithContext(ctx context.Context) NotificationResponseOutput {
	return o
}

// Email addresses to send the budget notification to when the threshold is exceeded. Must have at least one contact email or contact group specified at the Subscription or Resource Group scopes. All other scopes must have at least one contact email specified.
func (o NotificationResponseOutput) ContactEmails() pulumi.StringArrayOutput {
	return o.ApplyT(func(v NotificationResponse) []string { return v.ContactEmails }).(pulumi.StringArrayOutput)
}

// Action groups to send the budget notification to when the threshold is exceeded. Must be provided as a fully qualified Azure resource id. Only supported at Subscription or Resource Group scopes.
func (o NotificationResponseOutput) ContactGroups() pulumi.StringArrayOutput {
	return o.ApplyT(func(v NotificationResponse) []string { return v.ContactGroups }).(pulumi.StringArrayOutput)
}

// Contact roles to send the budget notification to when the threshold is exceeded.
func (o NotificationResponseOutput) ContactRoles() pulumi.StringArrayOutput {
	return o.ApplyT(func(v NotificationResponse) []string { return v.ContactRoles }).(pulumi.StringArrayOutput)
}

// The notification is enabled or not.
func (o NotificationResponseOutput) Enabled() pulumi.BoolOutput {
	return o.ApplyT(func(v NotificationResponse) bool { return v.Enabled }).(pulumi.BoolOutput)
}

// The comparison operator.
func (o NotificationResponseOutput) Operator() pulumi.StringOutput {
	return o.ApplyT(func(v NotificationResponse) string { return v.Operator }).(pulumi.StringOutput)
}

// Threshold value associated with a notification. Notification is sent when the cost exceeded the threshold. It is always percent and has to be between 0 and 1000.
func (o NotificationResponseOutput) Threshold() pulumi.Float64Output {
	return o.ApplyT(func(v NotificationResponse) float64 { return v.Threshold }).(pulumi.Float64Output)
}

// The type of threshold
func (o NotificationResponseOutput) ThresholdType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v NotificationResponse) *string { return v.ThresholdType }).(pulumi.StringPtrOutput)
}

type NotificationResponseMapOutput struct{ *pulumi.OutputState }

func (NotificationResponseMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]NotificationResponse)(nil)).Elem()
}

func (o NotificationResponseMapOutput) ToNotificationResponseMapOutput() NotificationResponseMapOutput {
	return o
}

func (o NotificationResponseMapOutput) ToNotificationResponseMapOutputWithContext(ctx context.Context) NotificationResponseMapOutput {
	return o
}

func (o NotificationResponseMapOutput) MapIndex(k pulumi.StringInput) NotificationResponseOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) NotificationResponse {
		return vs[0].(map[string]NotificationResponse)[vs[1].(string)]
	}).(NotificationResponseOutput)
}

func init() {
	pulumi.RegisterOutputType(BudgetTimePeriodOutput{})
	pulumi.RegisterOutputType(BudgetTimePeriodResponseOutput{})
	pulumi.RegisterOutputType(CurrentSpendResponseOutput{})
	pulumi.RegisterOutputType(FilterOutput{})
	pulumi.RegisterOutputType(FilterPtrOutput{})
	pulumi.RegisterOutputType(FilterResponseOutput{})
	pulumi.RegisterOutputType(FilterResponsePtrOutput{})
	pulumi.RegisterOutputType(NotificationOutput{})
	pulumi.RegisterOutputType(NotificationMapOutput{})
	pulumi.RegisterOutputType(NotificationResponseOutput{})
	pulumi.RegisterOutputType(NotificationResponseMapOutput{})
}
