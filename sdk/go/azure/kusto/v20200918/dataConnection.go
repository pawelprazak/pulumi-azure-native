// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20200918

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Class representing an data connection.
//
// Deprecated: Please use one of the variants: EventGridDataConnection, EventHubDataConnection, IotHubDataConnection.
type DataConnection struct {
	pulumi.CustomResourceState

	// Kind of the endpoint for the data connection
	Kind pulumi.StringOutput `pulumi:"kind"`
	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewDataConnection registers a new resource with the given unique name, arguments, and options.
func NewDataConnection(ctx *pulumi.Context,
	name string, args *DataConnectionArgs, opts ...pulumi.ResourceOption) (*DataConnection, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ClusterName == nil {
		return nil, errors.New("invalid value for required argument 'ClusterName'")
	}
	if args.DatabaseName == nil {
		return nil, errors.New("invalid value for required argument 'DatabaseName'")
	}
	if args.Kind == nil {
		return nil, errors.New("invalid value for required argument 'Kind'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-native:kusto:DataConnection"),
		},
		{
			Type: pulumi.String("azure-native:kusto/v20190121:DataConnection"),
		},
		{
			Type: pulumi.String("azure-native:kusto/v20190515:DataConnection"),
		},
		{
			Type: pulumi.String("azure-native:kusto/v20190907:DataConnection"),
		},
		{
			Type: pulumi.String("azure-native:kusto/v20191109:DataConnection"),
		},
		{
			Type: pulumi.String("azure-native:kusto/v20200215:DataConnection"),
		},
		{
			Type: pulumi.String("azure-native:kusto/v20200614:DataConnection"),
		},
		{
			Type: pulumi.String("azure-native:kusto/v20210101:DataConnection"),
		},
		{
			Type: pulumi.String("azure-native:kusto/v20210827:DataConnection"),
		},
		{
			Type: pulumi.String("azure-native:kusto/v20220201:DataConnection"),
		},
	})
	opts = append(opts, aliases)
	var resource DataConnection
	err := ctx.RegisterResource("azure-native:kusto/v20200918:DataConnection", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDataConnection gets an existing DataConnection resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDataConnection(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DataConnectionState, opts ...pulumi.ResourceOption) (*DataConnection, error) {
	var resource DataConnection
	err := ctx.ReadResource("azure-native:kusto/v20200918:DataConnection", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DataConnection resources.
type dataConnectionState struct {
}

type DataConnectionState struct {
}

func (DataConnectionState) ElementType() reflect.Type {
	return reflect.TypeOf((*dataConnectionState)(nil)).Elem()
}

type dataConnectionArgs struct {
	// The name of the Kusto cluster.
	ClusterName string `pulumi:"clusterName"`
	// The name of the data connection.
	DataConnectionName *string `pulumi:"dataConnectionName"`
	// The name of the database in the Kusto cluster.
	DatabaseName string `pulumi:"databaseName"`
	// Kind of the endpoint for the data connection
	Kind string `pulumi:"kind"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The name of the resource group containing the Kusto cluster.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a DataConnection resource.
type DataConnectionArgs struct {
	// The name of the Kusto cluster.
	ClusterName pulumi.StringInput
	// The name of the data connection.
	DataConnectionName pulumi.StringPtrInput
	// The name of the database in the Kusto cluster.
	DatabaseName pulumi.StringInput
	// Kind of the endpoint for the data connection
	Kind pulumi.StringInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The name of the resource group containing the Kusto cluster.
	ResourceGroupName pulumi.StringInput
}

func (DataConnectionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dataConnectionArgs)(nil)).Elem()
}

type DataConnectionInput interface {
	pulumi.Input

	ToDataConnectionOutput() DataConnectionOutput
	ToDataConnectionOutputWithContext(ctx context.Context) DataConnectionOutput
}

func (*DataConnection) ElementType() reflect.Type {
	return reflect.TypeOf((**DataConnection)(nil)).Elem()
}

func (i *DataConnection) ToDataConnectionOutput() DataConnectionOutput {
	return i.ToDataConnectionOutputWithContext(context.Background())
}

func (i *DataConnection) ToDataConnectionOutputWithContext(ctx context.Context) DataConnectionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DataConnectionOutput)
}

type DataConnectionOutput struct{ *pulumi.OutputState }

func (DataConnectionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DataConnection)(nil)).Elem()
}

func (o DataConnectionOutput) ToDataConnectionOutput() DataConnectionOutput {
	return o
}

func (o DataConnectionOutput) ToDataConnectionOutputWithContext(ctx context.Context) DataConnectionOutput {
	return o
}

// Kind of the endpoint for the data connection
func (o DataConnectionOutput) Kind() pulumi.StringOutput {
	return o.ApplyT(func(v *DataConnection) pulumi.StringOutput { return v.Kind }).(pulumi.StringOutput)
}

// Resource location.
func (o DataConnectionOutput) Location() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DataConnection) pulumi.StringPtrOutput { return v.Location }).(pulumi.StringPtrOutput)
}

// The name of the resource
func (o DataConnectionOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *DataConnection) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
func (o DataConnectionOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *DataConnection) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(DataConnectionOutput{})
}
