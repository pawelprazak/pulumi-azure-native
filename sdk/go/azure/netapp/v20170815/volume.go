// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20170815

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Volume resource
//
// Deprecated: Version 2017-08-15 will be removed in v2 of the provider.
type Volume struct {
	pulumi.CustomResourceState

	// A unique file path for the volume. Used when creating mount targets
	CreationToken pulumi.StringOutput `pulumi:"creationToken"`
	// Export policy rule
	ExportPolicy VolumePropertiesResponseExportPolicyPtrOutput `pulumi:"exportPolicy"`
	// Unique FileSystem Identifier.
	FileSystemId pulumi.StringOutput `pulumi:"fileSystemId"`
	// Resource location
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// Azure lifecycle management
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The service level of the file system
	ServiceLevel pulumi.StringOutput `pulumi:"serviceLevel"`
	// The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes
	SubnetId pulumi.StringPtrOutput `pulumi:"subnetId"`
	// Resource tags
	Tags pulumi.AnyOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
	// Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. Minimum size is 100 GiB. Upper limit is 100TiB.
	UsageThreshold pulumi.Float64PtrOutput `pulumi:"usageThreshold"`
}

// NewVolume registers a new resource with the given unique name, arguments, and options.
func NewVolume(ctx *pulumi.Context,
	name string, args *VolumeArgs, opts ...pulumi.ResourceOption) (*Volume, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AccountName == nil {
		return nil, errors.New("invalid value for required argument 'AccountName'")
	}
	if args.CreationToken == nil {
		return nil, errors.New("invalid value for required argument 'CreationToken'")
	}
	if args.PoolName == nil {
		return nil, errors.New("invalid value for required argument 'PoolName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if isZero(args.ServiceLevel) {
		args.ServiceLevel = pulumi.String("Premium")
	}
	if isZero(args.UsageThreshold) {
		args.UsageThreshold = pulumi.Float64Ptr(107374182400.0)
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-native:netapp:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20190501:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20190601:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20190701:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20190801:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20191001:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20191101:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20200201:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20200301:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20200501:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20200601:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20200701:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20200801:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20200901:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20201101:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20201201:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20210201:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20210401:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20210401preview:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20210601:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20210801:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20211001:Volume"),
		},
		{
			Type: pulumi.String("azure-native:netapp/v20220101:Volume"),
		},
	})
	opts = append(opts, aliases)
	var resource Volume
	err := ctx.RegisterResource("azure-native:netapp/v20170815:Volume", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVolume gets an existing Volume resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVolume(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VolumeState, opts ...pulumi.ResourceOption) (*Volume, error) {
	var resource Volume
	err := ctx.ReadResource("azure-native:netapp/v20170815:Volume", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Volume resources.
type volumeState struct {
}

type VolumeState struct {
}

func (VolumeState) ElementType() reflect.Type {
	return reflect.TypeOf((*volumeState)(nil)).Elem()
}

type volumeArgs struct {
	// The name of the NetApp account
	AccountName string `pulumi:"accountName"`
	// A unique file path for the volume. Used when creating mount targets
	CreationToken string `pulumi:"creationToken"`
	// Export policy rule
	ExportPolicy *VolumePropertiesExportPolicy `pulumi:"exportPolicy"`
	// Resource location
	Location *string `pulumi:"location"`
	// The name of the capacity pool
	PoolName string `pulumi:"poolName"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The service level of the file system
	ServiceLevel string `pulumi:"serviceLevel"`
	// The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes
	SubnetId *string `pulumi:"subnetId"`
	// Resource tags
	Tags interface{} `pulumi:"tags"`
	// Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. Minimum size is 100 GiB. Upper limit is 100TiB.
	UsageThreshold *float64 `pulumi:"usageThreshold"`
	// The name of the volume
	VolumeName *string `pulumi:"volumeName"`
}

// The set of arguments for constructing a Volume resource.
type VolumeArgs struct {
	// The name of the NetApp account
	AccountName pulumi.StringInput
	// A unique file path for the volume. Used when creating mount targets
	CreationToken pulumi.StringInput
	// Export policy rule
	ExportPolicy VolumePropertiesExportPolicyPtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// The name of the capacity pool
	PoolName pulumi.StringInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The service level of the file system
	ServiceLevel pulumi.StringInput
	// The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes
	SubnetId pulumi.StringPtrInput
	// Resource tags
	Tags pulumi.Input
	// Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. Minimum size is 100 GiB. Upper limit is 100TiB.
	UsageThreshold pulumi.Float64PtrInput
	// The name of the volume
	VolumeName pulumi.StringPtrInput
}

func (VolumeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*volumeArgs)(nil)).Elem()
}

type VolumeInput interface {
	pulumi.Input

	ToVolumeOutput() VolumeOutput
	ToVolumeOutputWithContext(ctx context.Context) VolumeOutput
}

func (*Volume) ElementType() reflect.Type {
	return reflect.TypeOf((**Volume)(nil)).Elem()
}

func (i *Volume) ToVolumeOutput() VolumeOutput {
	return i.ToVolumeOutputWithContext(context.Background())
}

func (i *Volume) ToVolumeOutputWithContext(ctx context.Context) VolumeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VolumeOutput)
}

type VolumeOutput struct{ *pulumi.OutputState }

func (VolumeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Volume)(nil)).Elem()
}

func (o VolumeOutput) ToVolumeOutput() VolumeOutput {
	return o
}

func (o VolumeOutput) ToVolumeOutputWithContext(ctx context.Context) VolumeOutput {
	return o
}

// A unique file path for the volume. Used when creating mount targets
func (o VolumeOutput) CreationToken() pulumi.StringOutput {
	return o.ApplyT(func(v *Volume) pulumi.StringOutput { return v.CreationToken }).(pulumi.StringOutput)
}

// Export policy rule
func (o VolumeOutput) ExportPolicy() VolumePropertiesResponseExportPolicyPtrOutput {
	return o.ApplyT(func(v *Volume) VolumePropertiesResponseExportPolicyPtrOutput { return v.ExportPolicy }).(VolumePropertiesResponseExportPolicyPtrOutput)
}

// Unique FileSystem Identifier.
func (o VolumeOutput) FileSystemId() pulumi.StringOutput {
	return o.ApplyT(func(v *Volume) pulumi.StringOutput { return v.FileSystemId }).(pulumi.StringOutput)
}

// Resource location
func (o VolumeOutput) Location() pulumi.StringOutput {
	return o.ApplyT(func(v *Volume) pulumi.StringOutput { return v.Location }).(pulumi.StringOutput)
}

// Resource name
func (o VolumeOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Volume) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Azure lifecycle management
func (o VolumeOutput) ProvisioningState() pulumi.StringOutput {
	return o.ApplyT(func(v *Volume) pulumi.StringOutput { return v.ProvisioningState }).(pulumi.StringOutput)
}

// The service level of the file system
func (o VolumeOutput) ServiceLevel() pulumi.StringOutput {
	return o.ApplyT(func(v *Volume) pulumi.StringOutput { return v.ServiceLevel }).(pulumi.StringOutput)
}

// The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes
func (o VolumeOutput) SubnetId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Volume) pulumi.StringPtrOutput { return v.SubnetId }).(pulumi.StringPtrOutput)
}

// Resource tags
func (o VolumeOutput) Tags() pulumi.AnyOutput {
	return o.ApplyT(func(v *Volume) pulumi.AnyOutput { return v.Tags }).(pulumi.AnyOutput)
}

// Resource type
func (o VolumeOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *Volume) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

// Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. Minimum size is 100 GiB. Upper limit is 100TiB.
func (o VolumeOutput) UsageThreshold() pulumi.Float64PtrOutput {
	return o.ApplyT(func(v *Volume) pulumi.Float64PtrOutput { return v.UsageThreshold }).(pulumi.Float64PtrOutput)
}

func init() {
	pulumi.RegisterOutputType(VolumeOutput{})
}
