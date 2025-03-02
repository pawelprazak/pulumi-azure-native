// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20140901

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Single item in List or Get Consumer group operation
//
// Deprecated: Version 2014-09-01 will be removed in v2 of the provider.
type ConsumerGroup struct {
	pulumi.CustomResourceState

	// Exact time the message was created.
	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	// The path of the Event Hub.
	EventHubPath pulumi.StringOutput `pulumi:"eventHubPath"`
	// Resource location
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
	// The exact time the message was updated.
	UpdatedAt pulumi.StringOutput `pulumi:"updatedAt"`
	// The user metadata.
	UserMetadata pulumi.StringPtrOutput `pulumi:"userMetadata"`
}

// NewConsumerGroup registers a new resource with the given unique name, arguments, and options.
func NewConsumerGroup(ctx *pulumi.Context,
	name string, args *ConsumerGroupArgs, opts ...pulumi.ResourceOption) (*ConsumerGroup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.EventHubName == nil {
		return nil, errors.New("invalid value for required argument 'EventHubName'")
	}
	if args.NamespaceName == nil {
		return nil, errors.New("invalid value for required argument 'NamespaceName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-native:eventhub:ConsumerGroup"),
		},
		{
			Type: pulumi.String("azure-native:eventhub/v20150801:ConsumerGroup"),
		},
		{
			Type: pulumi.String("azure-native:eventhub/v20170401:ConsumerGroup"),
		},
		{
			Type: pulumi.String("azure-native:eventhub/v20180101preview:ConsumerGroup"),
		},
		{
			Type: pulumi.String("azure-native:eventhub/v20210101preview:ConsumerGroup"),
		},
		{
			Type: pulumi.String("azure-native:eventhub/v20210601preview:ConsumerGroup"),
		},
		{
			Type: pulumi.String("azure-native:eventhub/v20211101:ConsumerGroup"),
		},
		{
			Type: pulumi.String("azure-native:eventhub/v20220101preview:ConsumerGroup"),
		},
	})
	opts = append(opts, aliases)
	var resource ConsumerGroup
	err := ctx.RegisterResource("azure-native:eventhub/v20140901:ConsumerGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetConsumerGroup gets an existing ConsumerGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetConsumerGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ConsumerGroupState, opts ...pulumi.ResourceOption) (*ConsumerGroup, error) {
	var resource ConsumerGroup
	err := ctx.ReadResource("azure-native:eventhub/v20140901:ConsumerGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ConsumerGroup resources.
type consumerGroupState struct {
}

type ConsumerGroupState struct {
}

func (ConsumerGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*consumerGroupState)(nil)).Elem()
}

type consumerGroupArgs struct {
	// The consumer group name
	ConsumerGroupName *string `pulumi:"consumerGroupName"`
	// The Event Hub name
	EventHubName string `pulumi:"eventHubName"`
	// Location of the resource.
	Location *string `pulumi:"location"`
	// Name of the consumer group.
	Name *string `pulumi:"name"`
	// The Namespace name
	NamespaceName string `pulumi:"namespaceName"`
	// Name of the resource group within the azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// ARM type of the Namespace.
	Type *string `pulumi:"type"`
	// The user metadata.
	UserMetadata *string `pulumi:"userMetadata"`
}

// The set of arguments for constructing a ConsumerGroup resource.
type ConsumerGroupArgs struct {
	// The consumer group name
	ConsumerGroupName pulumi.StringPtrInput
	// The Event Hub name
	EventHubName pulumi.StringInput
	// Location of the resource.
	Location pulumi.StringPtrInput
	// Name of the consumer group.
	Name pulumi.StringPtrInput
	// The Namespace name
	NamespaceName pulumi.StringInput
	// Name of the resource group within the azure subscription.
	ResourceGroupName pulumi.StringInput
	// ARM type of the Namespace.
	Type pulumi.StringPtrInput
	// The user metadata.
	UserMetadata pulumi.StringPtrInput
}

func (ConsumerGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*consumerGroupArgs)(nil)).Elem()
}

type ConsumerGroupInput interface {
	pulumi.Input

	ToConsumerGroupOutput() ConsumerGroupOutput
	ToConsumerGroupOutputWithContext(ctx context.Context) ConsumerGroupOutput
}

func (*ConsumerGroup) ElementType() reflect.Type {
	return reflect.TypeOf((**ConsumerGroup)(nil)).Elem()
}

func (i *ConsumerGroup) ToConsumerGroupOutput() ConsumerGroupOutput {
	return i.ToConsumerGroupOutputWithContext(context.Background())
}

func (i *ConsumerGroup) ToConsumerGroupOutputWithContext(ctx context.Context) ConsumerGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConsumerGroupOutput)
}

type ConsumerGroupOutput struct{ *pulumi.OutputState }

func (ConsumerGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ConsumerGroup)(nil)).Elem()
}

func (o ConsumerGroupOutput) ToConsumerGroupOutput() ConsumerGroupOutput {
	return o
}

func (o ConsumerGroupOutput) ToConsumerGroupOutputWithContext(ctx context.Context) ConsumerGroupOutput {
	return o
}

// Exact time the message was created.
func (o ConsumerGroupOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *ConsumerGroup) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

// The path of the Event Hub.
func (o ConsumerGroupOutput) EventHubPath() pulumi.StringOutput {
	return o.ApplyT(func(v *ConsumerGroup) pulumi.StringOutput { return v.EventHubPath }).(pulumi.StringOutput)
}

// Resource location
func (o ConsumerGroupOutput) Location() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ConsumerGroup) pulumi.StringPtrOutput { return v.Location }).(pulumi.StringPtrOutput)
}

// Resource name
func (o ConsumerGroupOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *ConsumerGroup) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Resource type
func (o ConsumerGroupOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *ConsumerGroup) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

// The exact time the message was updated.
func (o ConsumerGroupOutput) UpdatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *ConsumerGroup) pulumi.StringOutput { return v.UpdatedAt }).(pulumi.StringOutput)
}

// The user metadata.
func (o ConsumerGroupOutput) UserMetadata() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ConsumerGroup) pulumi.StringPtrOutput { return v.UserMetadata }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(ConsumerGroupOutput{})
}
