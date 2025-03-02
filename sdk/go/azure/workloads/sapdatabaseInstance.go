// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package workloads

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Define the SAP Database Instance.
// API Version: 2021-12-01-preview.
type SAPDatabaseInstance struct {
	pulumi.CustomResourceState

	// The database SID.
	DatabaseSid pulumi.StringOutput `pulumi:"databaseSid"`
	// The SAP database type.
	DatabaseType pulumi.StringOutput `pulumi:"databaseType"`
	// Defines the Database Instance errors.
	Errors SAPVirtualInstanceErrorResponseOutput `pulumi:"errors"`
	// The database IP Address.
	IpAddress pulumi.StringOutput `pulumi:"ipAddress"`
	// The geo-location where the resource lives
	Location pulumi.StringOutput `pulumi:"location"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Defines the provisioning states.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Defines the SAP Instance status.
	Status pulumi.StringOutput `pulumi:"status"`
	// The database subnet.
	Subnet pulumi.StringOutput `pulumi:"subnet"`
	// Azure Resource Manager metadata containing createdBy and modifiedBy information.
	SystemData SystemDataResponseOutput `pulumi:"systemData"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
	// The list of virtual machines.
	VmDetails DatabaseVmDetailsResponseArrayOutput `pulumi:"vmDetails"`
}

// NewSAPDatabaseInstance registers a new resource with the given unique name, arguments, and options.
func NewSAPDatabaseInstance(ctx *pulumi.Context,
	name string, args *SAPDatabaseInstanceArgs, opts ...pulumi.ResourceOption) (*SAPDatabaseInstance, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.SapVirtualInstanceName == nil {
		return nil, errors.New("invalid value for required argument 'SapVirtualInstanceName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-native:workloads/v20211201preview:SAPDatabaseInstance"),
		},
	})
	opts = append(opts, aliases)
	var resource SAPDatabaseInstance
	err := ctx.RegisterResource("azure-native:workloads:SAPDatabaseInstance", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSAPDatabaseInstance gets an existing SAPDatabaseInstance resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSAPDatabaseInstance(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SAPDatabaseInstanceState, opts ...pulumi.ResourceOption) (*SAPDatabaseInstance, error) {
	var resource SAPDatabaseInstance
	err := ctx.ReadResource("azure-native:workloads:SAPDatabaseInstance", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SAPDatabaseInstance resources.
type sapdatabaseInstanceState struct {
}

type SAPDatabaseInstanceState struct {
}

func (SAPDatabaseInstanceState) ElementType() reflect.Type {
	return reflect.TypeOf((*sapdatabaseInstanceState)(nil)).Elem()
}

type sapdatabaseInstanceArgs struct {
	// Database Instance string modeled as parameter for auto generation to work correctly.
	DatabaseInstanceName *string `pulumi:"databaseInstanceName"`
	// The geo-location where the resource lives
	Location *string `pulumi:"location"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the Virtual Instances for SAP.
	SapVirtualInstanceName string `pulumi:"sapVirtualInstanceName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a SAPDatabaseInstance resource.
type SAPDatabaseInstanceArgs struct {
	// Database Instance string modeled as parameter for auto generation to work correctly.
	DatabaseInstanceName pulumi.StringPtrInput
	// The geo-location where the resource lives
	Location pulumi.StringPtrInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// The name of the Virtual Instances for SAP.
	SapVirtualInstanceName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (SAPDatabaseInstanceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*sapdatabaseInstanceArgs)(nil)).Elem()
}

type SAPDatabaseInstanceInput interface {
	pulumi.Input

	ToSAPDatabaseInstanceOutput() SAPDatabaseInstanceOutput
	ToSAPDatabaseInstanceOutputWithContext(ctx context.Context) SAPDatabaseInstanceOutput
}

func (*SAPDatabaseInstance) ElementType() reflect.Type {
	return reflect.TypeOf((**SAPDatabaseInstance)(nil)).Elem()
}

func (i *SAPDatabaseInstance) ToSAPDatabaseInstanceOutput() SAPDatabaseInstanceOutput {
	return i.ToSAPDatabaseInstanceOutputWithContext(context.Background())
}

func (i *SAPDatabaseInstance) ToSAPDatabaseInstanceOutputWithContext(ctx context.Context) SAPDatabaseInstanceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SAPDatabaseInstanceOutput)
}

type SAPDatabaseInstanceOutput struct{ *pulumi.OutputState }

func (SAPDatabaseInstanceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SAPDatabaseInstance)(nil)).Elem()
}

func (o SAPDatabaseInstanceOutput) ToSAPDatabaseInstanceOutput() SAPDatabaseInstanceOutput {
	return o
}

func (o SAPDatabaseInstanceOutput) ToSAPDatabaseInstanceOutputWithContext(ctx context.Context) SAPDatabaseInstanceOutput {
	return o
}

// The database SID.
func (o SAPDatabaseInstanceOutput) DatabaseSid() pulumi.StringOutput {
	return o.ApplyT(func(v *SAPDatabaseInstance) pulumi.StringOutput { return v.DatabaseSid }).(pulumi.StringOutput)
}

// The SAP database type.
func (o SAPDatabaseInstanceOutput) DatabaseType() pulumi.StringOutput {
	return o.ApplyT(func(v *SAPDatabaseInstance) pulumi.StringOutput { return v.DatabaseType }).(pulumi.StringOutput)
}

// Defines the Database Instance errors.
func (o SAPDatabaseInstanceOutput) Errors() SAPVirtualInstanceErrorResponseOutput {
	return o.ApplyT(func(v *SAPDatabaseInstance) SAPVirtualInstanceErrorResponseOutput { return v.Errors }).(SAPVirtualInstanceErrorResponseOutput)
}

// The database IP Address.
func (o SAPDatabaseInstanceOutput) IpAddress() pulumi.StringOutput {
	return o.ApplyT(func(v *SAPDatabaseInstance) pulumi.StringOutput { return v.IpAddress }).(pulumi.StringOutput)
}

// The geo-location where the resource lives
func (o SAPDatabaseInstanceOutput) Location() pulumi.StringOutput {
	return o.ApplyT(func(v *SAPDatabaseInstance) pulumi.StringOutput { return v.Location }).(pulumi.StringOutput)
}

// The name of the resource
func (o SAPDatabaseInstanceOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *SAPDatabaseInstance) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Defines the provisioning states.
func (o SAPDatabaseInstanceOutput) ProvisioningState() pulumi.StringOutput {
	return o.ApplyT(func(v *SAPDatabaseInstance) pulumi.StringOutput { return v.ProvisioningState }).(pulumi.StringOutput)
}

// Defines the SAP Instance status.
func (o SAPDatabaseInstanceOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *SAPDatabaseInstance) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

// The database subnet.
func (o SAPDatabaseInstanceOutput) Subnet() pulumi.StringOutput {
	return o.ApplyT(func(v *SAPDatabaseInstance) pulumi.StringOutput { return v.Subnet }).(pulumi.StringOutput)
}

// Azure Resource Manager metadata containing createdBy and modifiedBy information.
func (o SAPDatabaseInstanceOutput) SystemData() SystemDataResponseOutput {
	return o.ApplyT(func(v *SAPDatabaseInstance) SystemDataResponseOutput { return v.SystemData }).(SystemDataResponseOutput)
}

// Resource tags.
func (o SAPDatabaseInstanceOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v *SAPDatabaseInstance) pulumi.StringMapOutput { return v.Tags }).(pulumi.StringMapOutput)
}

// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
func (o SAPDatabaseInstanceOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *SAPDatabaseInstance) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

// The list of virtual machines.
func (o SAPDatabaseInstanceOutput) VmDetails() DatabaseVmDetailsResponseArrayOutput {
	return o.ApplyT(func(v *SAPDatabaseInstance) DatabaseVmDetailsResponseArrayOutput { return v.VmDetails }).(DatabaseVmDetailsResponseArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(SAPDatabaseInstanceOutput{})
}
