// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20160601

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This is the preferred geo location for the job to run.
type RunLocation string

const (
	RunLocationNone               = RunLocation("none")
	RunLocationAustraliaeast      = RunLocation("australiaeast")
	RunLocationAustraliasoutheast = RunLocation("australiasoutheast")
	RunLocationBrazilsouth        = RunLocation("brazilsouth")
	RunLocationCanadacentral      = RunLocation("canadacentral")
	RunLocationCanadaeast         = RunLocation("canadaeast")
	RunLocationCentralindia       = RunLocation("centralindia")
	RunLocationCentralus          = RunLocation("centralus")
	RunLocationEastasia           = RunLocation("eastasia")
	RunLocationEastus             = RunLocation("eastus")
	RunLocationEastus2            = RunLocation("eastus2")
	RunLocationJapaneast          = RunLocation("japaneast")
	RunLocationJapanwest          = RunLocation("japanwest")
	RunLocationKoreacentral       = RunLocation("koreacentral")
	RunLocationKoreasouth         = RunLocation("koreasouth")
	RunLocationSoutheastasia      = RunLocation("southeastasia")
	RunLocationSouthcentralus     = RunLocation("southcentralus")
	RunLocationSouthindia         = RunLocation("southindia")
	RunLocationNorthcentralus     = RunLocation("northcentralus")
	RunLocationNortheurope        = RunLocation("northeurope")
	RunLocationUksouth            = RunLocation("uksouth")
	RunLocationUkwest             = RunLocation("ukwest")
	RunLocationWestcentralus      = RunLocation("westcentralus")
	RunLocationWesteurope         = RunLocation("westeurope")
	RunLocationWestindia          = RunLocation("westindia")
	RunLocationWestus             = RunLocation("westus")
	RunLocationWestus2            = RunLocation("westus2")
)

func (RunLocation) ElementType() reflect.Type {
	return reflect.TypeOf((*RunLocation)(nil)).Elem()
}

func (e RunLocation) ToRunLocationOutput() RunLocationOutput {
	return pulumi.ToOutput(e).(RunLocationOutput)
}

func (e RunLocation) ToRunLocationOutputWithContext(ctx context.Context) RunLocationOutput {
	return pulumi.ToOutputWithContext(ctx, e).(RunLocationOutput)
}

func (e RunLocation) ToRunLocationPtrOutput() RunLocationPtrOutput {
	return e.ToRunLocationPtrOutputWithContext(context.Background())
}

func (e RunLocation) ToRunLocationPtrOutputWithContext(ctx context.Context) RunLocationPtrOutput {
	return RunLocation(e).ToRunLocationOutputWithContext(ctx).ToRunLocationPtrOutputWithContext(ctx)
}

func (e RunLocation) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e RunLocation) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e RunLocation) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e RunLocation) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type RunLocationOutput struct{ *pulumi.OutputState }

func (RunLocationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*RunLocation)(nil)).Elem()
}

func (o RunLocationOutput) ToRunLocationOutput() RunLocationOutput {
	return o
}

func (o RunLocationOutput) ToRunLocationOutputWithContext(ctx context.Context) RunLocationOutput {
	return o
}

func (o RunLocationOutput) ToRunLocationPtrOutput() RunLocationPtrOutput {
	return o.ToRunLocationPtrOutputWithContext(context.Background())
}

func (o RunLocationOutput) ToRunLocationPtrOutputWithContext(ctx context.Context) RunLocationPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v RunLocation) *RunLocation {
		return &v
	}).(RunLocationPtrOutput)
}

func (o RunLocationOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o RunLocationOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e RunLocation) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o RunLocationOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o RunLocationOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e RunLocation) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type RunLocationPtrOutput struct{ *pulumi.OutputState }

func (RunLocationPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**RunLocation)(nil)).Elem()
}

func (o RunLocationPtrOutput) ToRunLocationPtrOutput() RunLocationPtrOutput {
	return o
}

func (o RunLocationPtrOutput) ToRunLocationPtrOutputWithContext(ctx context.Context) RunLocationPtrOutput {
	return o
}

func (o RunLocationPtrOutput) Elem() RunLocationOutput {
	return o.ApplyT(func(v *RunLocation) RunLocation {
		if v != nil {
			return *v
		}
		var ret RunLocation
		return ret
	}).(RunLocationOutput)
}

func (o RunLocationPtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o RunLocationPtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *RunLocation) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// RunLocationInput is an input type that accepts RunLocationArgs and RunLocationOutput values.
// You can construct a concrete instance of `RunLocationInput` via:
//
//          RunLocationArgs{...}
type RunLocationInput interface {
	pulumi.Input

	ToRunLocationOutput() RunLocationOutput
	ToRunLocationOutputWithContext(context.Context) RunLocationOutput
}

var runLocationPtrType = reflect.TypeOf((**RunLocation)(nil)).Elem()

type RunLocationPtrInput interface {
	pulumi.Input

	ToRunLocationPtrOutput() RunLocationPtrOutput
	ToRunLocationPtrOutputWithContext(context.Context) RunLocationPtrOutput
}

type runLocationPtr string

func RunLocationPtr(v string) RunLocationPtrInput {
	return (*runLocationPtr)(&v)
}

func (*runLocationPtr) ElementType() reflect.Type {
	return runLocationPtrType
}

func (in *runLocationPtr) ToRunLocationPtrOutput() RunLocationPtrOutput {
	return pulumi.ToOutput(in).(RunLocationPtrOutput)
}

func (in *runLocationPtr) ToRunLocationPtrOutputWithContext(ctx context.Context) RunLocationPtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(RunLocationPtrOutput)
}

// State of the job definition.
type State string

const (
	StateDisabled  = State("Disabled")
	StateEnabled   = State("Enabled")
	StateSupported = State("Supported")
)

func (State) ElementType() reflect.Type {
	return reflect.TypeOf((*State)(nil)).Elem()
}

func (e State) ToStateOutput() StateOutput {
	return pulumi.ToOutput(e).(StateOutput)
}

func (e State) ToStateOutputWithContext(ctx context.Context) StateOutput {
	return pulumi.ToOutputWithContext(ctx, e).(StateOutput)
}

func (e State) ToStatePtrOutput() StatePtrOutput {
	return e.ToStatePtrOutputWithContext(context.Background())
}

func (e State) ToStatePtrOutputWithContext(ctx context.Context) StatePtrOutput {
	return State(e).ToStateOutputWithContext(ctx).ToStatePtrOutputWithContext(ctx)
}

func (e State) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e State) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e State) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e State) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type StateOutput struct{ *pulumi.OutputState }

func (StateOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*State)(nil)).Elem()
}

func (o StateOutput) ToStateOutput() StateOutput {
	return o
}

func (o StateOutput) ToStateOutputWithContext(ctx context.Context) StateOutput {
	return o
}

func (o StateOutput) ToStatePtrOutput() StatePtrOutput {
	return o.ToStatePtrOutputWithContext(context.Background())
}

func (o StateOutput) ToStatePtrOutputWithContext(ctx context.Context) StatePtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v State) *State {
		return &v
	}).(StatePtrOutput)
}

func (o StateOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o StateOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e State) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o StateOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o StateOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e State) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type StatePtrOutput struct{ *pulumi.OutputState }

func (StatePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**State)(nil)).Elem()
}

func (o StatePtrOutput) ToStatePtrOutput() StatePtrOutput {
	return o
}

func (o StatePtrOutput) ToStatePtrOutputWithContext(ctx context.Context) StatePtrOutput {
	return o
}

func (o StatePtrOutput) Elem() StateOutput {
	return o.ApplyT(func(v *State) State {
		if v != nil {
			return *v
		}
		var ret State
		return ret
	}).(StateOutput)
}

func (o StatePtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o StatePtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *State) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// StateInput is an input type that accepts StateArgs and StateOutput values.
// You can construct a concrete instance of `StateInput` via:
//
//          StateArgs{...}
type StateInput interface {
	pulumi.Input

	ToStateOutput() StateOutput
	ToStateOutputWithContext(context.Context) StateOutput
}

var statePtrType = reflect.TypeOf((**State)(nil)).Elem()

type StatePtrInput interface {
	pulumi.Input

	ToStatePtrOutput() StatePtrOutput
	ToStatePtrOutputWithContext(context.Context) StatePtrOutput
}

type statePtr string

func StatePtr(v string) StatePtrInput {
	return (*statePtr)(&v)
}

func (*statePtr) ElementType() reflect.Type {
	return statePtrType
}

func (in *statePtr) ToStatePtrOutput() StatePtrOutput {
	return pulumi.ToOutput(in).(StatePtrOutput)
}

func (in *statePtr) ToStatePtrOutputWithContext(ctx context.Context) StatePtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(StatePtrOutput)
}

// The encryption algorithm used to encrypt data.
type SupportedAlgorithm string

const (
	SupportedAlgorithmNone      = SupportedAlgorithm("None")
	SupportedAlgorithm_RSA1_5   = SupportedAlgorithm("RSA1_5")
	SupportedAlgorithm_RSA_OAEP = SupportedAlgorithm("RSA_OAEP")
	SupportedAlgorithmPlainText = SupportedAlgorithm("PlainText")
)

func (SupportedAlgorithm) ElementType() reflect.Type {
	return reflect.TypeOf((*SupportedAlgorithm)(nil)).Elem()
}

func (e SupportedAlgorithm) ToSupportedAlgorithmOutput() SupportedAlgorithmOutput {
	return pulumi.ToOutput(e).(SupportedAlgorithmOutput)
}

func (e SupportedAlgorithm) ToSupportedAlgorithmOutputWithContext(ctx context.Context) SupportedAlgorithmOutput {
	return pulumi.ToOutputWithContext(ctx, e).(SupportedAlgorithmOutput)
}

func (e SupportedAlgorithm) ToSupportedAlgorithmPtrOutput() SupportedAlgorithmPtrOutput {
	return e.ToSupportedAlgorithmPtrOutputWithContext(context.Background())
}

func (e SupportedAlgorithm) ToSupportedAlgorithmPtrOutputWithContext(ctx context.Context) SupportedAlgorithmPtrOutput {
	return SupportedAlgorithm(e).ToSupportedAlgorithmOutputWithContext(ctx).ToSupportedAlgorithmPtrOutputWithContext(ctx)
}

func (e SupportedAlgorithm) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e SupportedAlgorithm) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e SupportedAlgorithm) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e SupportedAlgorithm) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type SupportedAlgorithmOutput struct{ *pulumi.OutputState }

func (SupportedAlgorithmOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SupportedAlgorithm)(nil)).Elem()
}

func (o SupportedAlgorithmOutput) ToSupportedAlgorithmOutput() SupportedAlgorithmOutput {
	return o
}

func (o SupportedAlgorithmOutput) ToSupportedAlgorithmOutputWithContext(ctx context.Context) SupportedAlgorithmOutput {
	return o
}

func (o SupportedAlgorithmOutput) ToSupportedAlgorithmPtrOutput() SupportedAlgorithmPtrOutput {
	return o.ToSupportedAlgorithmPtrOutputWithContext(context.Background())
}

func (o SupportedAlgorithmOutput) ToSupportedAlgorithmPtrOutputWithContext(ctx context.Context) SupportedAlgorithmPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v SupportedAlgorithm) *SupportedAlgorithm {
		return &v
	}).(SupportedAlgorithmPtrOutput)
}

func (o SupportedAlgorithmOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o SupportedAlgorithmOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e SupportedAlgorithm) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o SupportedAlgorithmOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o SupportedAlgorithmOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e SupportedAlgorithm) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type SupportedAlgorithmPtrOutput struct{ *pulumi.OutputState }

func (SupportedAlgorithmPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SupportedAlgorithm)(nil)).Elem()
}

func (o SupportedAlgorithmPtrOutput) ToSupportedAlgorithmPtrOutput() SupportedAlgorithmPtrOutput {
	return o
}

func (o SupportedAlgorithmPtrOutput) ToSupportedAlgorithmPtrOutputWithContext(ctx context.Context) SupportedAlgorithmPtrOutput {
	return o
}

func (o SupportedAlgorithmPtrOutput) Elem() SupportedAlgorithmOutput {
	return o.ApplyT(func(v *SupportedAlgorithm) SupportedAlgorithm {
		if v != nil {
			return *v
		}
		var ret SupportedAlgorithm
		return ret
	}).(SupportedAlgorithmOutput)
}

func (o SupportedAlgorithmPtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o SupportedAlgorithmPtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *SupportedAlgorithm) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// SupportedAlgorithmInput is an input type that accepts SupportedAlgorithmArgs and SupportedAlgorithmOutput values.
// You can construct a concrete instance of `SupportedAlgorithmInput` via:
//
//          SupportedAlgorithmArgs{...}
type SupportedAlgorithmInput interface {
	pulumi.Input

	ToSupportedAlgorithmOutput() SupportedAlgorithmOutput
	ToSupportedAlgorithmOutputWithContext(context.Context) SupportedAlgorithmOutput
}

var supportedAlgorithmPtrType = reflect.TypeOf((**SupportedAlgorithm)(nil)).Elem()

type SupportedAlgorithmPtrInput interface {
	pulumi.Input

	ToSupportedAlgorithmPtrOutput() SupportedAlgorithmPtrOutput
	ToSupportedAlgorithmPtrOutputWithContext(context.Context) SupportedAlgorithmPtrOutput
}

type supportedAlgorithmPtr string

func SupportedAlgorithmPtr(v string) SupportedAlgorithmPtrInput {
	return (*supportedAlgorithmPtr)(&v)
}

func (*supportedAlgorithmPtr) ElementType() reflect.Type {
	return supportedAlgorithmPtrType
}

func (in *supportedAlgorithmPtr) ToSupportedAlgorithmPtrOutput() SupportedAlgorithmPtrOutput {
	return pulumi.ToOutput(in).(SupportedAlgorithmPtrOutput)
}

func (in *supportedAlgorithmPtr) ToSupportedAlgorithmPtrOutputWithContext(ctx context.Context) SupportedAlgorithmPtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(SupportedAlgorithmPtrOutput)
}

// Enum to detect if user confirmation is required. If not passed will default to NotRequired.
type UserConfirmation string

const (
	UserConfirmationNotRequired = UserConfirmation("NotRequired")
	UserConfirmationRequired    = UserConfirmation("Required")
)

func (UserConfirmation) ElementType() reflect.Type {
	return reflect.TypeOf((*UserConfirmation)(nil)).Elem()
}

func (e UserConfirmation) ToUserConfirmationOutput() UserConfirmationOutput {
	return pulumi.ToOutput(e).(UserConfirmationOutput)
}

func (e UserConfirmation) ToUserConfirmationOutputWithContext(ctx context.Context) UserConfirmationOutput {
	return pulumi.ToOutputWithContext(ctx, e).(UserConfirmationOutput)
}

func (e UserConfirmation) ToUserConfirmationPtrOutput() UserConfirmationPtrOutput {
	return e.ToUserConfirmationPtrOutputWithContext(context.Background())
}

func (e UserConfirmation) ToUserConfirmationPtrOutputWithContext(ctx context.Context) UserConfirmationPtrOutput {
	return UserConfirmation(e).ToUserConfirmationOutputWithContext(ctx).ToUserConfirmationPtrOutputWithContext(ctx)
}

func (e UserConfirmation) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e UserConfirmation) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e UserConfirmation) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e UserConfirmation) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type UserConfirmationOutput struct{ *pulumi.OutputState }

func (UserConfirmationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*UserConfirmation)(nil)).Elem()
}

func (o UserConfirmationOutput) ToUserConfirmationOutput() UserConfirmationOutput {
	return o
}

func (o UserConfirmationOutput) ToUserConfirmationOutputWithContext(ctx context.Context) UserConfirmationOutput {
	return o
}

func (o UserConfirmationOutput) ToUserConfirmationPtrOutput() UserConfirmationPtrOutput {
	return o.ToUserConfirmationPtrOutputWithContext(context.Background())
}

func (o UserConfirmationOutput) ToUserConfirmationPtrOutputWithContext(ctx context.Context) UserConfirmationPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v UserConfirmation) *UserConfirmation {
		return &v
	}).(UserConfirmationPtrOutput)
}

func (o UserConfirmationOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o UserConfirmationOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e UserConfirmation) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o UserConfirmationOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o UserConfirmationOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e UserConfirmation) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type UserConfirmationPtrOutput struct{ *pulumi.OutputState }

func (UserConfirmationPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**UserConfirmation)(nil)).Elem()
}

func (o UserConfirmationPtrOutput) ToUserConfirmationPtrOutput() UserConfirmationPtrOutput {
	return o
}

func (o UserConfirmationPtrOutput) ToUserConfirmationPtrOutputWithContext(ctx context.Context) UserConfirmationPtrOutput {
	return o
}

func (o UserConfirmationPtrOutput) Elem() UserConfirmationOutput {
	return o.ApplyT(func(v *UserConfirmation) UserConfirmation {
		if v != nil {
			return *v
		}
		var ret UserConfirmation
		return ret
	}).(UserConfirmationOutput)
}

func (o UserConfirmationPtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o UserConfirmationPtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *UserConfirmation) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// UserConfirmationInput is an input type that accepts UserConfirmationArgs and UserConfirmationOutput values.
// You can construct a concrete instance of `UserConfirmationInput` via:
//
//          UserConfirmationArgs{...}
type UserConfirmationInput interface {
	pulumi.Input

	ToUserConfirmationOutput() UserConfirmationOutput
	ToUserConfirmationOutputWithContext(context.Context) UserConfirmationOutput
}

var userConfirmationPtrType = reflect.TypeOf((**UserConfirmation)(nil)).Elem()

type UserConfirmationPtrInput interface {
	pulumi.Input

	ToUserConfirmationPtrOutput() UserConfirmationPtrOutput
	ToUserConfirmationPtrOutputWithContext(context.Context) UserConfirmationPtrOutput
}

type userConfirmationPtr string

func UserConfirmationPtr(v string) UserConfirmationPtrInput {
	return (*userConfirmationPtr)(&v)
}

func (*userConfirmationPtr) ElementType() reflect.Type {
	return userConfirmationPtrType
}

func (in *userConfirmationPtr) ToUserConfirmationPtrOutput() UserConfirmationPtrOutput {
	return pulumi.ToOutput(in).(UserConfirmationPtrOutput)
}

func (in *userConfirmationPtr) ToUserConfirmationPtrOutputWithContext(ctx context.Context) UserConfirmationPtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(UserConfirmationPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(RunLocationOutput{})
	pulumi.RegisterOutputType(RunLocationPtrOutput{})
	pulumi.RegisterOutputType(StateOutput{})
	pulumi.RegisterOutputType(StatePtrOutput{})
	pulumi.RegisterOutputType(SupportedAlgorithmOutput{})
	pulumi.RegisterOutputType(SupportedAlgorithmPtrOutput{})
	pulumi.RegisterOutputType(UserConfirmationOutput{})
	pulumi.RegisterOutputType(UserConfirmationPtrOutput{})
}
