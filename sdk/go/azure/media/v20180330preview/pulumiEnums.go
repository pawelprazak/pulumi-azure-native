// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20180330preview

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// The encoding profile to be used when encoding audio with AAC.
type AacAudioProfile string

const (
	// Specifies that the output audio is to be encoded into AAC Low Complexity profile (AAC-LC).
	AacAudioProfileAacLc = AacAudioProfile("AacLc")
	// Specifies that the output audio is to be encoded into HE-AAC v1 profile.
	AacAudioProfileHeAacV1 = AacAudioProfile("HeAacV1")
	// Specifies that the output audio is to be encoded into HE-AAC v2 profile.
	AacAudioProfileHeAacV2 = AacAudioProfile("HeAacV2")
)

// The permissions to set on the SAS URL.
type AssetContainerPermission string

const (
	// The SAS URL will allow read access to the container.
	AssetContainerPermissionRead = AssetContainerPermission("Read")
	// The SAS URL will allow read and write access to the container.
	AssetContainerPermissionReadWrite = AssetContainerPermission("ReadWrite")
	// The SAS URL will allow read, write and delete access to the container.
	AssetContainerPermissionReadWriteDelete = AssetContainerPermission("ReadWriteDelete")
)

// The rental and lease key type.
type ContentKeyPolicyFairPlayRentalAndLeaseKeyType string

const (
	// Represents a ContentKeyPolicyFairPlayRentalAndLeaseKeyType that is unavailable in current API version.
	ContentKeyPolicyFairPlayRentalAndLeaseKeyTypeUnknown = ContentKeyPolicyFairPlayRentalAndLeaseKeyType("Unknown")
	// Key duration is not specified.
	ContentKeyPolicyFairPlayRentalAndLeaseKeyTypeUndefined = ContentKeyPolicyFairPlayRentalAndLeaseKeyType("Undefined")
	// Content key can be persisted with an unlimited duration
	ContentKeyPolicyFairPlayRentalAndLeaseKeyTypePersistentUnlimited = ContentKeyPolicyFairPlayRentalAndLeaseKeyType("PersistentUnlimited")
	// Content key can be persisted and the valid duration is limited by the Rental Duration value
	ContentKeyPolicyFairPlayRentalAndLeaseKeyTypePersistentLimited = ContentKeyPolicyFairPlayRentalAndLeaseKeyType("PersistentLimited")
)

// The PlayReady content type.
type ContentKeyPolicyPlayReadyContentType string

const (
	// Represents a ContentKeyPolicyPlayReadyContentType that is unavailable in current API version.
	ContentKeyPolicyPlayReadyContentTypeUnknown = ContentKeyPolicyPlayReadyContentType("Unknown")
	// Unspecified content type.
	ContentKeyPolicyPlayReadyContentTypeUnspecified = ContentKeyPolicyPlayReadyContentType("Unspecified")
	// Ultraviolet download content type.
	ContentKeyPolicyPlayReadyContentTypeUltraVioletDownload = ContentKeyPolicyPlayReadyContentType("UltraVioletDownload")
	// Ultraviolet streaming content type.
	ContentKeyPolicyPlayReadyContentTypeUltraVioletStreaming = ContentKeyPolicyPlayReadyContentType("UltraVioletStreaming")
)

// The license type.
type ContentKeyPolicyPlayReadyLicenseType string

const (
	// Represents a ContentKeyPolicyPlayReadyLicenseType that is unavailable in current API version.
	ContentKeyPolicyPlayReadyLicenseTypeUnknown = ContentKeyPolicyPlayReadyLicenseType("Unknown")
	// Non persistent license.
	ContentKeyPolicyPlayReadyLicenseTypeNonPersistent = ContentKeyPolicyPlayReadyLicenseType("NonPersistent")
	// Persistent license. Allows offline playback.
	ContentKeyPolicyPlayReadyLicenseTypePersistent = ContentKeyPolicyPlayReadyLicenseType("Persistent")
)

// Configures Unknown output handling settings of the license.
type ContentKeyPolicyPlayReadyUnknownOutputPassingOption string

const (
	// Represents a ContentKeyPolicyPlayReadyUnknownOutputPassingOption that is unavailable in current API version.
	ContentKeyPolicyPlayReadyUnknownOutputPassingOptionUnknown = ContentKeyPolicyPlayReadyUnknownOutputPassingOption("Unknown")
	// Passing the video portion of protected content to an Unknown Output is not allowed.
	ContentKeyPolicyPlayReadyUnknownOutputPassingOptionNotAllowed = ContentKeyPolicyPlayReadyUnknownOutputPassingOption("NotAllowed")
	// Passing the video portion of protected content to an Unknown Output is allowed.
	ContentKeyPolicyPlayReadyUnknownOutputPassingOptionAllowed = ContentKeyPolicyPlayReadyUnknownOutputPassingOption("Allowed")
	// Passing the video portion of protected content to an Unknown Output is allowed but with constrained resolution.
	ContentKeyPolicyPlayReadyUnknownOutputPassingOptionAllowedWithVideoConstriction = ContentKeyPolicyPlayReadyUnknownOutputPassingOption("AllowedWithVideoConstriction")
)

// The type of token.
type ContentKeyPolicyRestrictionTokenType string

const (
	// Represents a ContentKeyPolicyRestrictionTokenType that is unavailable in current API version.
	ContentKeyPolicyRestrictionTokenTypeUnknown = ContentKeyPolicyRestrictionTokenType("Unknown")
	// Simple Web Token.
	ContentKeyPolicyRestrictionTokenTypeSwt = ContentKeyPolicyRestrictionTokenType("Swt")
	// JSON Web Token.
	ContentKeyPolicyRestrictionTokenTypeJwt = ContentKeyPolicyRestrictionTokenType("Jwt")
)

// The deinterlacing mode. Defaults to AutoPixelAdaptive.
type DeinterlaceMode string

const (
	// Disables de-interlacing of the source video.
	DeinterlaceModeOff = DeinterlaceMode("Off")
	// Apply automatic pixel adaptive de-interlacing on each frame in the input video.
	DeinterlaceModeAutoPixelAdaptive = DeinterlaceMode("AutoPixelAdaptive")
)

// The field parity for de-interlacing, defaults to Auto.
type DeinterlaceParity string

const (
	// Automatically detect the order of fields
	DeinterlaceParityAuto = DeinterlaceParity("Auto")
	// Apply top field first processing of input video.
	DeinterlaceParityTopFieldFirst = DeinterlaceParity("TopFieldFirst")
	// Apply bottom field first processing of input video.
	DeinterlaceParityBottomFieldFirst = DeinterlaceParity("BottomFieldFirst")
)

// The built-in preset to be used for encoding videos.
type EncoderNamedPreset string

const (
	// Produces a set of GOP aligned MP4 files with H.264 video and stereo AAC audio. Auto-generates a bitrate ladder based on the input resolution and bitrate. The auto-generated preset will never exceed the input resolution and bitrate. For example, if the input is 720p at 3 Mbps, output will remain 720p at best, and will start at rates lower than 3 Mbps. The output will have video and audio in separate MP4 files, which is optimal for adaptive streaming.
	EncoderNamedPresetAdaptiveStreaming = EncoderNamedPreset("AdaptiveStreaming")
	// Produces a single MP4 file containing only stereo audio encoded at 192 kbps.
	EncoderNamedPresetAACGoodQualityAudio = EncoderNamedPreset("AACGoodQualityAudio")
	// Produces a set of 8 GOP-aligned MP4 files, ranging from 6000 kbps to 400 kbps, and stereo AAC audio. Resolution starts at 1080p and goes down to 360p.
	EncoderNamedPresetH264MultipleBitrate1080p = EncoderNamedPreset("H264MultipleBitrate1080p")
	// Produces a set of 6 GOP-aligned MP4 files, ranging from 3400 kbps to 400 kbps, and stereo AAC audio. Resolution starts at 720p and goes down to 360p.
	EncoderNamedPresetH264MultipleBitrate720p = EncoderNamedPreset("H264MultipleBitrate720p")
	// Produces a set of 5 GOP-aligned MP4 files, ranging from 1600kbps to 400 kbps, and stereo AAC audio. Resolution starts at 480p and goes down to 360p.
	EncoderNamedPresetH264MultipleBitrateSD = EncoderNamedPreset("H264MultipleBitrateSD")
)

// The entropy mode to be used for this layer. If not specified, the encoder chooses the mode that is appropriate for the profile and level.
type EntropyMode string

const (
	// Context Adaptive Binary Arithmetic Coder (CABAC) entropy encoding.
	EntropyModeCabac = EntropyMode("Cabac")
	// Context Adaptive Variable Length Coder (CAVLC) entropy encoding.
	EntropyModeCavlc = EntropyMode("Cavlc")
)

// Tells the encoder how to choose its encoding settings. The default value is Balanced.
type H264Complexity string

const (
	// Tells the encoder to use settings that are optimized for faster encoding. Quality is sacrificed to decrease encoding time.
	H264ComplexitySpeed = H264Complexity("Speed")
	// Tells the encoder to use settings that achieve a balance between speed and quality.
	H264ComplexityBalanced = H264Complexity("Balanced")
	// Tells the encoder to use settings that are optimized to produce higher quality output at the expense of slower overall encode time.
	H264ComplexityQuality = H264Complexity("Quality")
)

// Which profile of the H.264 standard should be used when encoding this layer. Default is Auto.
type H264VideoProfile string

const (
	// Tells the encoder to automatically determine the appropriate H.264 profile.
	H264VideoProfileAuto = H264VideoProfile("Auto")
	// Baseline profile
	H264VideoProfileBaseline = H264VideoProfile("Baseline")
	// Main profile
	H264VideoProfileMain = H264VideoProfile("Main")
	// High profile.
	H264VideoProfileHigh = H264VideoProfile("High")
	// High 4:2:2 profile.
	H264VideoProfileHigh422 = H264VideoProfile("High422")
	// High 4:4:4 predictive profile.
	H264VideoProfileHigh444 = H264VideoProfile("High444")
)

// The encoding type for Live Event.
type LiveEventEncodingType string

const (
	LiveEventEncodingTypeNone  = LiveEventEncodingType("None")
	LiveEventEncodingTypeBasic = LiveEventEncodingType("Basic")
)

func (LiveEventEncodingType) ElementType() reflect.Type {
	return reflect.TypeOf((*LiveEventEncodingType)(nil)).Elem()
}

func (e LiveEventEncodingType) ToLiveEventEncodingTypeOutput() LiveEventEncodingTypeOutput {
	return pulumi.ToOutput(e).(LiveEventEncodingTypeOutput)
}

func (e LiveEventEncodingType) ToLiveEventEncodingTypeOutputWithContext(ctx context.Context) LiveEventEncodingTypeOutput {
	return pulumi.ToOutputWithContext(ctx, e).(LiveEventEncodingTypeOutput)
}

func (e LiveEventEncodingType) ToLiveEventEncodingTypePtrOutput() LiveEventEncodingTypePtrOutput {
	return e.ToLiveEventEncodingTypePtrOutputWithContext(context.Background())
}

func (e LiveEventEncodingType) ToLiveEventEncodingTypePtrOutputWithContext(ctx context.Context) LiveEventEncodingTypePtrOutput {
	return LiveEventEncodingType(e).ToLiveEventEncodingTypeOutputWithContext(ctx).ToLiveEventEncodingTypePtrOutputWithContext(ctx)
}

func (e LiveEventEncodingType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e LiveEventEncodingType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e LiveEventEncodingType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e LiveEventEncodingType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type LiveEventEncodingTypeOutput struct{ *pulumi.OutputState }

func (LiveEventEncodingTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LiveEventEncodingType)(nil)).Elem()
}

func (o LiveEventEncodingTypeOutput) ToLiveEventEncodingTypeOutput() LiveEventEncodingTypeOutput {
	return o
}

func (o LiveEventEncodingTypeOutput) ToLiveEventEncodingTypeOutputWithContext(ctx context.Context) LiveEventEncodingTypeOutput {
	return o
}

func (o LiveEventEncodingTypeOutput) ToLiveEventEncodingTypePtrOutput() LiveEventEncodingTypePtrOutput {
	return o.ToLiveEventEncodingTypePtrOutputWithContext(context.Background())
}

func (o LiveEventEncodingTypeOutput) ToLiveEventEncodingTypePtrOutputWithContext(ctx context.Context) LiveEventEncodingTypePtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v LiveEventEncodingType) *LiveEventEncodingType {
		return &v
	}).(LiveEventEncodingTypePtrOutput)
}

func (o LiveEventEncodingTypeOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o LiveEventEncodingTypeOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e LiveEventEncodingType) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o LiveEventEncodingTypeOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o LiveEventEncodingTypeOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e LiveEventEncodingType) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type LiveEventEncodingTypePtrOutput struct{ *pulumi.OutputState }

func (LiveEventEncodingTypePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**LiveEventEncodingType)(nil)).Elem()
}

func (o LiveEventEncodingTypePtrOutput) ToLiveEventEncodingTypePtrOutput() LiveEventEncodingTypePtrOutput {
	return o
}

func (o LiveEventEncodingTypePtrOutput) ToLiveEventEncodingTypePtrOutputWithContext(ctx context.Context) LiveEventEncodingTypePtrOutput {
	return o
}

func (o LiveEventEncodingTypePtrOutput) Elem() LiveEventEncodingTypeOutput {
	return o.ApplyT(func(v *LiveEventEncodingType) LiveEventEncodingType {
		if v != nil {
			return *v
		}
		var ret LiveEventEncodingType
		return ret
	}).(LiveEventEncodingTypeOutput)
}

func (o LiveEventEncodingTypePtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o LiveEventEncodingTypePtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *LiveEventEncodingType) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// LiveEventEncodingTypeInput is an input type that accepts LiveEventEncodingTypeArgs and LiveEventEncodingTypeOutput values.
// You can construct a concrete instance of `LiveEventEncodingTypeInput` via:
//
//          LiveEventEncodingTypeArgs{...}
type LiveEventEncodingTypeInput interface {
	pulumi.Input

	ToLiveEventEncodingTypeOutput() LiveEventEncodingTypeOutput
	ToLiveEventEncodingTypeOutputWithContext(context.Context) LiveEventEncodingTypeOutput
}

var liveEventEncodingTypePtrType = reflect.TypeOf((**LiveEventEncodingType)(nil)).Elem()

type LiveEventEncodingTypePtrInput interface {
	pulumi.Input

	ToLiveEventEncodingTypePtrOutput() LiveEventEncodingTypePtrOutput
	ToLiveEventEncodingTypePtrOutputWithContext(context.Context) LiveEventEncodingTypePtrOutput
}

type liveEventEncodingTypePtr string

func LiveEventEncodingTypePtr(v string) LiveEventEncodingTypePtrInput {
	return (*liveEventEncodingTypePtr)(&v)
}

func (*liveEventEncodingTypePtr) ElementType() reflect.Type {
	return liveEventEncodingTypePtrType
}

func (in *liveEventEncodingTypePtr) ToLiveEventEncodingTypePtrOutput() LiveEventEncodingTypePtrOutput {
	return pulumi.ToOutput(in).(LiveEventEncodingTypePtrOutput)
}

func (in *liveEventEncodingTypePtr) ToLiveEventEncodingTypePtrOutputWithContext(ctx context.Context) LiveEventEncodingTypePtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(LiveEventEncodingTypePtrOutput)
}

// The streaming protocol for the Live Event.
type LiveEventInputProtocol string

const (
	LiveEventInputProtocolFragmentedMP4 = LiveEventInputProtocol("FragmentedMP4")
	LiveEventInputProtocolRTMP          = LiveEventInputProtocol("RTMP")
)

func (LiveEventInputProtocol) ElementType() reflect.Type {
	return reflect.TypeOf((*LiveEventInputProtocol)(nil)).Elem()
}

func (e LiveEventInputProtocol) ToLiveEventInputProtocolOutput() LiveEventInputProtocolOutput {
	return pulumi.ToOutput(e).(LiveEventInputProtocolOutput)
}

func (e LiveEventInputProtocol) ToLiveEventInputProtocolOutputWithContext(ctx context.Context) LiveEventInputProtocolOutput {
	return pulumi.ToOutputWithContext(ctx, e).(LiveEventInputProtocolOutput)
}

func (e LiveEventInputProtocol) ToLiveEventInputProtocolPtrOutput() LiveEventInputProtocolPtrOutput {
	return e.ToLiveEventInputProtocolPtrOutputWithContext(context.Background())
}

func (e LiveEventInputProtocol) ToLiveEventInputProtocolPtrOutputWithContext(ctx context.Context) LiveEventInputProtocolPtrOutput {
	return LiveEventInputProtocol(e).ToLiveEventInputProtocolOutputWithContext(ctx).ToLiveEventInputProtocolPtrOutputWithContext(ctx)
}

func (e LiveEventInputProtocol) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e LiveEventInputProtocol) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e LiveEventInputProtocol) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e LiveEventInputProtocol) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type LiveEventInputProtocolOutput struct{ *pulumi.OutputState }

func (LiveEventInputProtocolOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LiveEventInputProtocol)(nil)).Elem()
}

func (o LiveEventInputProtocolOutput) ToLiveEventInputProtocolOutput() LiveEventInputProtocolOutput {
	return o
}

func (o LiveEventInputProtocolOutput) ToLiveEventInputProtocolOutputWithContext(ctx context.Context) LiveEventInputProtocolOutput {
	return o
}

func (o LiveEventInputProtocolOutput) ToLiveEventInputProtocolPtrOutput() LiveEventInputProtocolPtrOutput {
	return o.ToLiveEventInputProtocolPtrOutputWithContext(context.Background())
}

func (o LiveEventInputProtocolOutput) ToLiveEventInputProtocolPtrOutputWithContext(ctx context.Context) LiveEventInputProtocolPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v LiveEventInputProtocol) *LiveEventInputProtocol {
		return &v
	}).(LiveEventInputProtocolPtrOutput)
}

func (o LiveEventInputProtocolOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o LiveEventInputProtocolOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e LiveEventInputProtocol) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o LiveEventInputProtocolOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o LiveEventInputProtocolOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e LiveEventInputProtocol) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type LiveEventInputProtocolPtrOutput struct{ *pulumi.OutputState }

func (LiveEventInputProtocolPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**LiveEventInputProtocol)(nil)).Elem()
}

func (o LiveEventInputProtocolPtrOutput) ToLiveEventInputProtocolPtrOutput() LiveEventInputProtocolPtrOutput {
	return o
}

func (o LiveEventInputProtocolPtrOutput) ToLiveEventInputProtocolPtrOutputWithContext(ctx context.Context) LiveEventInputProtocolPtrOutput {
	return o
}

func (o LiveEventInputProtocolPtrOutput) Elem() LiveEventInputProtocolOutput {
	return o.ApplyT(func(v *LiveEventInputProtocol) LiveEventInputProtocol {
		if v != nil {
			return *v
		}
		var ret LiveEventInputProtocol
		return ret
	}).(LiveEventInputProtocolOutput)
}

func (o LiveEventInputProtocolPtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o LiveEventInputProtocolPtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *LiveEventInputProtocol) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// LiveEventInputProtocolInput is an input type that accepts LiveEventInputProtocolArgs and LiveEventInputProtocolOutput values.
// You can construct a concrete instance of `LiveEventInputProtocolInput` via:
//
//          LiveEventInputProtocolArgs{...}
type LiveEventInputProtocolInput interface {
	pulumi.Input

	ToLiveEventInputProtocolOutput() LiveEventInputProtocolOutput
	ToLiveEventInputProtocolOutputWithContext(context.Context) LiveEventInputProtocolOutput
}

var liveEventInputProtocolPtrType = reflect.TypeOf((**LiveEventInputProtocol)(nil)).Elem()

type LiveEventInputProtocolPtrInput interface {
	pulumi.Input

	ToLiveEventInputProtocolPtrOutput() LiveEventInputProtocolPtrOutput
	ToLiveEventInputProtocolPtrOutputWithContext(context.Context) LiveEventInputProtocolPtrOutput
}

type liveEventInputProtocolPtr string

func LiveEventInputProtocolPtr(v string) LiveEventInputProtocolPtrInput {
	return (*liveEventInputProtocolPtr)(&v)
}

func (*liveEventInputProtocolPtr) ElementType() reflect.Type {
	return liveEventInputProtocolPtrType
}

func (in *liveEventInputProtocolPtr) ToLiveEventInputProtocolPtrOutput() LiveEventInputProtocolPtrOutput {
	return pulumi.ToOutput(in).(LiveEventInputProtocolPtrOutput)
}

func (in *liveEventInputProtocolPtr) ToLiveEventInputProtocolPtrOutputWithContext(ctx context.Context) LiveEventInputProtocolPtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(LiveEventInputProtocolPtrOutput)
}

// A Transform can define more than one outputs. This property defines what the service should do when one output fails - either continue to produce other outputs, or, stop the other outputs. The default is stop.
type OnErrorType string

const (
	// Tells the service that if this TransformOutput fails, then any other incomplete TransformOutputs can be stopped.
	OnErrorTypeStopProcessingJob = OnErrorType("StopProcessingJob")
	// Tells the service that if this TransformOutput fails, then allow any other TransformOutput to continue.
	OnErrorTypeContinueJob = OnErrorType("ContinueJob")
)

// Sets the relative priority of the TransformOutputs within a Transform. This sets the priority that the service uses for processing TransformOutputs. The default priority is Normal.
type Priority string

const (
	// Used for TransformOutputs that can be generated after Normal and High priority TransformOutputs.
	PriorityLow = Priority("Low")
	// Used for TransformOutputs that can be generated at Normal priority.
	PriorityNormal = Priority("Normal")
	// Used for TransformOutputs that should take precedence over others.
	PriorityHigh = Priority("High")
)

// The rotation, if any, to be applied to the input video, before it is encoded. Default is Auto
type Rotation string

const (
	// Automatically detect and rotate as needed.
	RotationAuto = Rotation("Auto")
	// Do not rotate the video.  If the output format supports it, any metadata about rotation is kept intact.
	RotationNone = Rotation("None")
	// Do not rotate the video but remove any metadata about the rotation.
	RotationRotate0 = Rotation("Rotate0")
	// Rotate 90 degrees clockwise.
	RotationRotate90 = Rotation("Rotate90")
	// Rotate 180 degrees clockwise.
	RotationRotate180 = Rotation("Rotate180")
	// Rotate 270 degrees clockwise.
	RotationRotate270 = Rotation("Rotate270")
)

// The type of the storage account.
type StorageAccountType string

const (
	// The primary storage account for the Media Services account.
	StorageAccountTypePrimary = StorageAccountType("Primary")
	// A secondary storage account for the Media Services account.
	StorageAccountTypeSecondary = StorageAccountType("Secondary")
)

type StreamOptionsFlag string

const (
	StreamOptionsFlagDefault    = StreamOptionsFlag("Default")
	StreamOptionsFlagLowLatency = StreamOptionsFlag("LowLatency")
)

func (StreamOptionsFlag) ElementType() reflect.Type {
	return reflect.TypeOf((*StreamOptionsFlag)(nil)).Elem()
}

func (e StreamOptionsFlag) ToStreamOptionsFlagOutput() StreamOptionsFlagOutput {
	return pulumi.ToOutput(e).(StreamOptionsFlagOutput)
}

func (e StreamOptionsFlag) ToStreamOptionsFlagOutputWithContext(ctx context.Context) StreamOptionsFlagOutput {
	return pulumi.ToOutputWithContext(ctx, e).(StreamOptionsFlagOutput)
}

func (e StreamOptionsFlag) ToStreamOptionsFlagPtrOutput() StreamOptionsFlagPtrOutput {
	return e.ToStreamOptionsFlagPtrOutputWithContext(context.Background())
}

func (e StreamOptionsFlag) ToStreamOptionsFlagPtrOutputWithContext(ctx context.Context) StreamOptionsFlagPtrOutput {
	return StreamOptionsFlag(e).ToStreamOptionsFlagOutputWithContext(ctx).ToStreamOptionsFlagPtrOutputWithContext(ctx)
}

func (e StreamOptionsFlag) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e StreamOptionsFlag) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e StreamOptionsFlag) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e StreamOptionsFlag) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type StreamOptionsFlagOutput struct{ *pulumi.OutputState }

func (StreamOptionsFlagOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*StreamOptionsFlag)(nil)).Elem()
}

func (o StreamOptionsFlagOutput) ToStreamOptionsFlagOutput() StreamOptionsFlagOutput {
	return o
}

func (o StreamOptionsFlagOutput) ToStreamOptionsFlagOutputWithContext(ctx context.Context) StreamOptionsFlagOutput {
	return o
}

func (o StreamOptionsFlagOutput) ToStreamOptionsFlagPtrOutput() StreamOptionsFlagPtrOutput {
	return o.ToStreamOptionsFlagPtrOutputWithContext(context.Background())
}

func (o StreamOptionsFlagOutput) ToStreamOptionsFlagPtrOutputWithContext(ctx context.Context) StreamOptionsFlagPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v StreamOptionsFlag) *StreamOptionsFlag {
		return &v
	}).(StreamOptionsFlagPtrOutput)
}

func (o StreamOptionsFlagOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o StreamOptionsFlagOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e StreamOptionsFlag) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o StreamOptionsFlagOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o StreamOptionsFlagOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e StreamOptionsFlag) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type StreamOptionsFlagPtrOutput struct{ *pulumi.OutputState }

func (StreamOptionsFlagPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**StreamOptionsFlag)(nil)).Elem()
}

func (o StreamOptionsFlagPtrOutput) ToStreamOptionsFlagPtrOutput() StreamOptionsFlagPtrOutput {
	return o
}

func (o StreamOptionsFlagPtrOutput) ToStreamOptionsFlagPtrOutputWithContext(ctx context.Context) StreamOptionsFlagPtrOutput {
	return o
}

func (o StreamOptionsFlagPtrOutput) Elem() StreamOptionsFlagOutput {
	return o.ApplyT(func(v *StreamOptionsFlag) StreamOptionsFlag {
		if v != nil {
			return *v
		}
		var ret StreamOptionsFlag
		return ret
	}).(StreamOptionsFlagOutput)
}

func (o StreamOptionsFlagPtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o StreamOptionsFlagPtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *StreamOptionsFlag) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// StreamOptionsFlagInput is an input type that accepts StreamOptionsFlagArgs and StreamOptionsFlagOutput values.
// You can construct a concrete instance of `StreamOptionsFlagInput` via:
//
//          StreamOptionsFlagArgs{...}
type StreamOptionsFlagInput interface {
	pulumi.Input

	ToStreamOptionsFlagOutput() StreamOptionsFlagOutput
	ToStreamOptionsFlagOutputWithContext(context.Context) StreamOptionsFlagOutput
}

var streamOptionsFlagPtrType = reflect.TypeOf((**StreamOptionsFlag)(nil)).Elem()

type StreamOptionsFlagPtrInput interface {
	pulumi.Input

	ToStreamOptionsFlagPtrOutput() StreamOptionsFlagPtrOutput
	ToStreamOptionsFlagPtrOutputWithContext(context.Context) StreamOptionsFlagPtrOutput
}

type streamOptionsFlagPtr string

func StreamOptionsFlagPtr(v string) StreamOptionsFlagPtrInput {
	return (*streamOptionsFlagPtr)(&v)
}

func (*streamOptionsFlagPtr) ElementType() reflect.Type {
	return streamOptionsFlagPtrType
}

func (in *streamOptionsFlagPtr) ToStreamOptionsFlagPtrOutput() StreamOptionsFlagPtrOutput {
	return pulumi.ToOutput(in).(StreamOptionsFlagPtrOutput)
}

func (in *streamOptionsFlagPtr) ToStreamOptionsFlagPtrOutputWithContext(ctx context.Context) StreamOptionsFlagPtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(StreamOptionsFlagPtrOutput)
}

// StreamOptionsFlagArrayInput is an input type that accepts StreamOptionsFlagArray and StreamOptionsFlagArrayOutput values.
// You can construct a concrete instance of `StreamOptionsFlagArrayInput` via:
//
//          StreamOptionsFlagArray{ StreamOptionsFlagArgs{...} }
type StreamOptionsFlagArrayInput interface {
	pulumi.Input

	ToStreamOptionsFlagArrayOutput() StreamOptionsFlagArrayOutput
	ToStreamOptionsFlagArrayOutputWithContext(context.Context) StreamOptionsFlagArrayOutput
}

type StreamOptionsFlagArray []StreamOptionsFlag

func (StreamOptionsFlagArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]StreamOptionsFlag)(nil)).Elem()
}

func (i StreamOptionsFlagArray) ToStreamOptionsFlagArrayOutput() StreamOptionsFlagArrayOutput {
	return i.ToStreamOptionsFlagArrayOutputWithContext(context.Background())
}

func (i StreamOptionsFlagArray) ToStreamOptionsFlagArrayOutputWithContext(ctx context.Context) StreamOptionsFlagArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StreamOptionsFlagArrayOutput)
}

type StreamOptionsFlagArrayOutput struct{ *pulumi.OutputState }

func (StreamOptionsFlagArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]StreamOptionsFlag)(nil)).Elem()
}

func (o StreamOptionsFlagArrayOutput) ToStreamOptionsFlagArrayOutput() StreamOptionsFlagArrayOutput {
	return o
}

func (o StreamOptionsFlagArrayOutput) ToStreamOptionsFlagArrayOutputWithContext(ctx context.Context) StreamOptionsFlagArrayOutput {
	return o
}

func (o StreamOptionsFlagArrayOutput) Index(i pulumi.IntInput) StreamOptionsFlagOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) StreamOptionsFlag {
		return vs[0].([]StreamOptionsFlag)[vs[1].(int)]
	}).(StreamOptionsFlagOutput)
}

// The resizing mode - how the input video will be resized to fit the desired output resolution(s). Default is AutoSize
type StretchMode string

const (
	// Strictly respect the output resolution without considering the pixel aspect ratio or display aspect ratio of the input video.
	StretchModeNone = StretchMode("None")
	// Override the output resolution, and change it to match the display aspect ratio of the input, without padding. For example, if the input is 1920x1080 and the encoding preset asks for 1280x1280, then the value in the preset is overridden, and the output will be at 1280x720, which maintains the input aspect ratio of 16:9.
	StretchModeAutoSize = StretchMode("AutoSize")
	// Pad the output (with either letterbox or pillar box) to honor the output resolution, while ensuring that the active video region in the output has the same aspect ratio as the input. For example, if the input is 1920x1080 and the encoding preset asks for 1280x1280, then the output will be at 1280x1280, which contains an inner rectangle of 1280x720 at aspect ratio of 16:9, and pillar box regions 280 pixels wide at the left and right.
	StretchModeAutoFit = StretchMode("AutoFit")
)

// Track property condition operation
type TrackPropertyCompareOperation string

const (
	// Unknown track property compare operation
	TrackPropertyCompareOperationUnknown = TrackPropertyCompareOperation("Unknown")
	// Equal operation
	TrackPropertyCompareOperationEqual = TrackPropertyCompareOperation("Equal")
)

// Track property type
type TrackPropertyType string

const (
	// Unknown track property
	TrackPropertyTypeUnknown = TrackPropertyType("Unknown")
	// Track FourCC
	TrackPropertyTypeFourCC = TrackPropertyType("FourCC")
)

func init() {
	pulumi.RegisterOutputType(LiveEventEncodingTypeOutput{})
	pulumi.RegisterOutputType(LiveEventEncodingTypePtrOutput{})
	pulumi.RegisterOutputType(LiveEventInputProtocolOutput{})
	pulumi.RegisterOutputType(LiveEventInputProtocolPtrOutput{})
	pulumi.RegisterOutputType(StreamOptionsFlagOutput{})
	pulumi.RegisterOutputType(StreamOptionsFlagPtrOutput{})
	pulumi.RegisterOutputType(StreamOptionsFlagArrayOutput{})
}
