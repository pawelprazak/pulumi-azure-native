// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20220301preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Attached data network resource.
type AttachedDataNetwork struct {
	pulumi.CustomResourceState

	// The timestamp of resource creation (UTC).
	CreatedAt pulumi.StringPtrOutput `pulumi:"createdAt"`
	// The identity that created the resource.
	CreatedBy pulumi.StringPtrOutput `pulumi:"createdBy"`
	// The type of identity that created the resource.
	CreatedByType pulumi.StringPtrOutput `pulumi:"createdByType"`
	// The timestamp of resource last modification (UTC)
	LastModifiedAt pulumi.StringPtrOutput `pulumi:"lastModifiedAt"`
	// The identity that last modified the resource.
	LastModifiedBy pulumi.StringPtrOutput `pulumi:"lastModifiedBy"`
	// The type of identity that last modified the resource.
	LastModifiedByType pulumi.StringPtrOutput `pulumi:"lastModifiedByType"`
	// The geo-location where the resource lives
	Location pulumi.StringOutput `pulumi:"location"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The Network Address and Port Translation configuration.
	// If not specified the attached data network uses a default NAPT configuration with NAPT enabled.
	NaptConfiguration NaptConfigurationResponsePtrOutput `pulumi:"naptConfiguration"`
	// The provisioning state of the attached data network resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Azure Resource Manager metadata containing createdBy and modifiedBy information.
	SystemData SystemDataResponseOutput `pulumi:"systemData"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
	// The user equipment address pool prefixes for the attached data network that are dynamically assigned by the core to UEs when they set up a PDU session.
	// At least one of userEquipmentAddressPoolPrefix and userEquipmentStaticAddressPoolPrefix must be defined. If both are defined then they must be the same size.
	UserEquipmentAddressPoolPrefix pulumi.StringArrayOutput `pulumi:"userEquipmentAddressPoolPrefix"`
	// The user equipment address pool prefixes for the attached data network that are statically assigned by the core to UEs when they set up a PDU session.
	// The mapping of static IP to sim is configured in staticIpConfiguration on the sim resource.
	// At least one of userEquipmentAddressPoolPrefix and userEquipmentStaticAddressPoolPrefix must be defined. If both are defined then they must be the same size.
	UserEquipmentStaticAddressPoolPrefix pulumi.StringArrayOutput `pulumi:"userEquipmentStaticAddressPoolPrefix"`
	// The user plane interface on the data network. In 5G networks this is called as N6 interface whereas in 4G networks this is called as SGi interface.
	UserPlaneDataInterface InterfacePropertiesResponseOutput `pulumi:"userPlaneDataInterface"`
}

// NewAttachedDataNetwork registers a new resource with the given unique name, arguments, and options.
func NewAttachedDataNetwork(ctx *pulumi.Context,
	name string, args *AttachedDataNetworkArgs, opts ...pulumi.ResourceOption) (*AttachedDataNetwork, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.PacketCoreControlPlaneName == nil {
		return nil, errors.New("invalid value for required argument 'PacketCoreControlPlaneName'")
	}
	if args.PacketCoreDataPlaneName == nil {
		return nil, errors.New("invalid value for required argument 'PacketCoreDataPlaneName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.UserPlaneDataInterface == nil {
		return nil, errors.New("invalid value for required argument 'UserPlaneDataInterface'")
	}
	if args.NaptConfiguration != nil {
		args.NaptConfiguration = args.NaptConfiguration.ToNaptConfigurationPtrOutput().ApplyT(func(v *NaptConfiguration) *NaptConfiguration { return v.Defaults() }).(NaptConfigurationPtrOutput)
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-native:mobilenetwork:AttachedDataNetwork"),
		},
		{
			Type: pulumi.String("azure-native:mobilenetwork/v20220101preview:AttachedDataNetwork"),
		},
	})
	opts = append(opts, aliases)
	var resource AttachedDataNetwork
	err := ctx.RegisterResource("azure-native:mobilenetwork/v20220301preview:AttachedDataNetwork", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAttachedDataNetwork gets an existing AttachedDataNetwork resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAttachedDataNetwork(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AttachedDataNetworkState, opts ...pulumi.ResourceOption) (*AttachedDataNetwork, error) {
	var resource AttachedDataNetwork
	err := ctx.ReadResource("azure-native:mobilenetwork/v20220301preview:AttachedDataNetwork", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AttachedDataNetwork resources.
type attachedDataNetworkState struct {
}

type AttachedDataNetworkState struct {
}

func (AttachedDataNetworkState) ElementType() reflect.Type {
	return reflect.TypeOf((*attachedDataNetworkState)(nil)).Elem()
}

type attachedDataNetworkArgs struct {
	// The name of the attached data network.
	AttachedDataNetworkName *string `pulumi:"attachedDataNetworkName"`
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
	// The geo-location where the resource lives
	Location *string `pulumi:"location"`
	// The Network Address and Port Translation configuration.
	// If not specified the attached data network uses a default NAPT configuration with NAPT enabled.
	NaptConfiguration *NaptConfiguration `pulumi:"naptConfiguration"`
	// The name of the packet core control plane.
	PacketCoreControlPlaneName string `pulumi:"packetCoreControlPlaneName"`
	// The name of the packet core data plane.
	PacketCoreDataPlaneName string `pulumi:"packetCoreDataPlaneName"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The user equipment address pool prefixes for the attached data network that are dynamically assigned by the core to UEs when they set up a PDU session.
	// At least one of userEquipmentAddressPoolPrefix and userEquipmentStaticAddressPoolPrefix must be defined. If both are defined then they must be the same size.
	UserEquipmentAddressPoolPrefix []string `pulumi:"userEquipmentAddressPoolPrefix"`
	// The user equipment address pool prefixes for the attached data network that are statically assigned by the core to UEs when they set up a PDU session.
	// The mapping of static IP to sim is configured in staticIpConfiguration on the sim resource.
	// At least one of userEquipmentAddressPoolPrefix and userEquipmentStaticAddressPoolPrefix must be defined. If both are defined then they must be the same size.
	UserEquipmentStaticAddressPoolPrefix []string `pulumi:"userEquipmentStaticAddressPoolPrefix"`
	// The user plane interface on the data network. In 5G networks this is called as N6 interface whereas in 4G networks this is called as SGi interface.
	UserPlaneDataInterface InterfaceProperties `pulumi:"userPlaneDataInterface"`
}

// The set of arguments for constructing a AttachedDataNetwork resource.
type AttachedDataNetworkArgs struct {
	// The name of the attached data network.
	AttachedDataNetworkName pulumi.StringPtrInput
	// The timestamp of resource creation (UTC).
	CreatedAt pulumi.StringPtrInput
	// The identity that created the resource.
	CreatedBy pulumi.StringPtrInput
	// The type of identity that created the resource.
	CreatedByType pulumi.StringPtrInput
	// The timestamp of resource last modification (UTC)
	LastModifiedAt pulumi.StringPtrInput
	// The identity that last modified the resource.
	LastModifiedBy pulumi.StringPtrInput
	// The type of identity that last modified the resource.
	LastModifiedByType pulumi.StringPtrInput
	// The geo-location where the resource lives
	Location pulumi.StringPtrInput
	// The Network Address and Port Translation configuration.
	// If not specified the attached data network uses a default NAPT configuration with NAPT enabled.
	NaptConfiguration NaptConfigurationPtrInput
	// The name of the packet core control plane.
	PacketCoreControlPlaneName pulumi.StringInput
	// The name of the packet core data plane.
	PacketCoreDataPlaneName pulumi.StringInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The user equipment address pool prefixes for the attached data network that are dynamically assigned by the core to UEs when they set up a PDU session.
	// At least one of userEquipmentAddressPoolPrefix and userEquipmentStaticAddressPoolPrefix must be defined. If both are defined then they must be the same size.
	UserEquipmentAddressPoolPrefix pulumi.StringArrayInput
	// The user equipment address pool prefixes for the attached data network that are statically assigned by the core to UEs when they set up a PDU session.
	// The mapping of static IP to sim is configured in staticIpConfiguration on the sim resource.
	// At least one of userEquipmentAddressPoolPrefix and userEquipmentStaticAddressPoolPrefix must be defined. If both are defined then they must be the same size.
	UserEquipmentStaticAddressPoolPrefix pulumi.StringArrayInput
	// The user plane interface on the data network. In 5G networks this is called as N6 interface whereas in 4G networks this is called as SGi interface.
	UserPlaneDataInterface InterfacePropertiesInput
}

func (AttachedDataNetworkArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*attachedDataNetworkArgs)(nil)).Elem()
}

type AttachedDataNetworkInput interface {
	pulumi.Input

	ToAttachedDataNetworkOutput() AttachedDataNetworkOutput
	ToAttachedDataNetworkOutputWithContext(ctx context.Context) AttachedDataNetworkOutput
}

func (*AttachedDataNetwork) ElementType() reflect.Type {
	return reflect.TypeOf((**AttachedDataNetwork)(nil)).Elem()
}

func (i *AttachedDataNetwork) ToAttachedDataNetworkOutput() AttachedDataNetworkOutput {
	return i.ToAttachedDataNetworkOutputWithContext(context.Background())
}

func (i *AttachedDataNetwork) ToAttachedDataNetworkOutputWithContext(ctx context.Context) AttachedDataNetworkOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AttachedDataNetworkOutput)
}

type AttachedDataNetworkOutput struct{ *pulumi.OutputState }

func (AttachedDataNetworkOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AttachedDataNetwork)(nil)).Elem()
}

func (o AttachedDataNetworkOutput) ToAttachedDataNetworkOutput() AttachedDataNetworkOutput {
	return o
}

func (o AttachedDataNetworkOutput) ToAttachedDataNetworkOutputWithContext(ctx context.Context) AttachedDataNetworkOutput {
	return o
}

// The timestamp of resource creation (UTC).
func (o AttachedDataNetworkOutput) CreatedAt() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AttachedDataNetwork) pulumi.StringPtrOutput { return v.CreatedAt }).(pulumi.StringPtrOutput)
}

// The identity that created the resource.
func (o AttachedDataNetworkOutput) CreatedBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AttachedDataNetwork) pulumi.StringPtrOutput { return v.CreatedBy }).(pulumi.StringPtrOutput)
}

// The type of identity that created the resource.
func (o AttachedDataNetworkOutput) CreatedByType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AttachedDataNetwork) pulumi.StringPtrOutput { return v.CreatedByType }).(pulumi.StringPtrOutput)
}

// The timestamp of resource last modification (UTC)
func (o AttachedDataNetworkOutput) LastModifiedAt() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AttachedDataNetwork) pulumi.StringPtrOutput { return v.LastModifiedAt }).(pulumi.StringPtrOutput)
}

// The identity that last modified the resource.
func (o AttachedDataNetworkOutput) LastModifiedBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AttachedDataNetwork) pulumi.StringPtrOutput { return v.LastModifiedBy }).(pulumi.StringPtrOutput)
}

// The type of identity that last modified the resource.
func (o AttachedDataNetworkOutput) LastModifiedByType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AttachedDataNetwork) pulumi.StringPtrOutput { return v.LastModifiedByType }).(pulumi.StringPtrOutput)
}

// The geo-location where the resource lives
func (o AttachedDataNetworkOutput) Location() pulumi.StringOutput {
	return o.ApplyT(func(v *AttachedDataNetwork) pulumi.StringOutput { return v.Location }).(pulumi.StringOutput)
}

// The name of the resource
func (o AttachedDataNetworkOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *AttachedDataNetwork) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The Network Address and Port Translation configuration.
// If not specified the attached data network uses a default NAPT configuration with NAPT enabled.
func (o AttachedDataNetworkOutput) NaptConfiguration() NaptConfigurationResponsePtrOutput {
	return o.ApplyT(func(v *AttachedDataNetwork) NaptConfigurationResponsePtrOutput { return v.NaptConfiguration }).(NaptConfigurationResponsePtrOutput)
}

// The provisioning state of the attached data network resource.
func (o AttachedDataNetworkOutput) ProvisioningState() pulumi.StringOutput {
	return o.ApplyT(func(v *AttachedDataNetwork) pulumi.StringOutput { return v.ProvisioningState }).(pulumi.StringOutput)
}

// Azure Resource Manager metadata containing createdBy and modifiedBy information.
func (o AttachedDataNetworkOutput) SystemData() SystemDataResponseOutput {
	return o.ApplyT(func(v *AttachedDataNetwork) SystemDataResponseOutput { return v.SystemData }).(SystemDataResponseOutput)
}

// Resource tags.
func (o AttachedDataNetworkOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v *AttachedDataNetwork) pulumi.StringMapOutput { return v.Tags }).(pulumi.StringMapOutput)
}

// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
func (o AttachedDataNetworkOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *AttachedDataNetwork) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

// The user equipment address pool prefixes for the attached data network that are dynamically assigned by the core to UEs when they set up a PDU session.
// At least one of userEquipmentAddressPoolPrefix and userEquipmentStaticAddressPoolPrefix must be defined. If both are defined then they must be the same size.
func (o AttachedDataNetworkOutput) UserEquipmentAddressPoolPrefix() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *AttachedDataNetwork) pulumi.StringArrayOutput { return v.UserEquipmentAddressPoolPrefix }).(pulumi.StringArrayOutput)
}

// The user equipment address pool prefixes for the attached data network that are statically assigned by the core to UEs when they set up a PDU session.
// The mapping of static IP to sim is configured in staticIpConfiguration on the sim resource.
// At least one of userEquipmentAddressPoolPrefix and userEquipmentStaticAddressPoolPrefix must be defined. If both are defined then they must be the same size.
func (o AttachedDataNetworkOutput) UserEquipmentStaticAddressPoolPrefix() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *AttachedDataNetwork) pulumi.StringArrayOutput { return v.UserEquipmentStaticAddressPoolPrefix }).(pulumi.StringArrayOutput)
}

// The user plane interface on the data network. In 5G networks this is called as N6 interface whereas in 4G networks this is called as SGi interface.
func (o AttachedDataNetworkOutput) UserPlaneDataInterface() InterfacePropertiesResponseOutput {
	return o.ApplyT(func(v *AttachedDataNetwork) InterfacePropertiesResponseOutput { return v.UserPlaneDataInterface }).(InterfacePropertiesResponseOutput)
}

func init() {
	pulumi.RegisterOutputType(AttachedDataNetworkOutput{})
}
