// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20150801

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// A Redis item in CreateOrUpdate Operation response.
//
// Deprecated: Version 2015-08-01 will be removed in v2 of the provider.
type Redis struct {
	pulumi.CustomResourceState

	// Redis cache access keys.
	AccessKeys RedisAccessKeysResponsePtrOutput `pulumi:"accessKeys"`
	// If the value is true, then the non-SLL Redis server port (6379) will be enabled.
	EnableNonSslPort pulumi.BoolPtrOutput `pulumi:"enableNonSslPort"`
	// Redis host name.
	HostName pulumi.StringPtrOutput `pulumi:"hostName"`
	// Resource location.
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Redis non-SSL port.
	Port pulumi.IntPtrOutput `pulumi:"port"`
	// Redis instance provisioning status.
	ProvisioningState pulumi.StringPtrOutput `pulumi:"provisioningState"`
	// All Redis Settings. Few possible keys: rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value etc.
	RedisConfiguration pulumi.StringMapOutput `pulumi:"redisConfiguration"`
	// RedisVersion parameter has been deprecated. As such, it is no longer necessary to provide this parameter and any value specified is ignored.
	RedisVersion pulumi.StringPtrOutput `pulumi:"redisVersion"`
	// The number of shards to be created on a Premium Cluster Cache.
	ShardCount pulumi.IntPtrOutput `pulumi:"shardCount"`
	// What SKU of Redis cache to deploy.
	Sku SkuResponseOutput `pulumi:"sku"`
	// Redis SSL port.
	SslPort pulumi.IntPtrOutput `pulumi:"sslPort"`
	// Required when deploying a Redis cache inside an existing Azure Virtual Network.
	StaticIP pulumi.StringPtrOutput `pulumi:"staticIP"`
	// Required when deploying a Redis cache inside an existing Azure Virtual Network.
	Subnet pulumi.StringPtrOutput `pulumi:"subnet"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// tenantSettings
	TenantSettings pulumi.StringMapOutput `pulumi:"tenantSettings"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
	// The exact ARM resource ID of the virtual network to deploy the Redis cache in. Example format: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/Microsoft.ClassicNetwork/VirtualNetworks/vnet1
	VirtualNetwork pulumi.StringPtrOutput `pulumi:"virtualNetwork"`
}

// NewRedis registers a new resource with the given unique name, arguments, and options.
func NewRedis(ctx *pulumi.Context,
	name string, args *RedisArgs, opts ...pulumi.ResourceOption) (*Redis, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.Sku == nil {
		return nil, errors.New("invalid value for required argument 'Sku'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-native:cache:Redis"),
		},
		{
			Type: pulumi.String("azure-native:cache/v20160401:Redis"),
		},
		{
			Type: pulumi.String("azure-native:cache/v20170201:Redis"),
		},
		{
			Type: pulumi.String("azure-native:cache/v20171001:Redis"),
		},
		{
			Type: pulumi.String("azure-native:cache/v20180301:Redis"),
		},
		{
			Type: pulumi.String("azure-native:cache/v20190701:Redis"),
		},
		{
			Type: pulumi.String("azure-native:cache/v20200601:Redis"),
		},
		{
			Type: pulumi.String("azure-native:cache/v20201201:Redis"),
		},
		{
			Type: pulumi.String("azure-native:cache/v20210601:Redis"),
		},
	})
	opts = append(opts, aliases)
	var resource Redis
	err := ctx.RegisterResource("azure-native:cache/v20150801:Redis", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRedis gets an existing Redis resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRedis(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RedisState, opts ...pulumi.ResourceOption) (*Redis, error) {
	var resource Redis
	err := ctx.ReadResource("azure-native:cache/v20150801:Redis", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Redis resources.
type redisState struct {
}

type RedisState struct {
}

func (RedisState) ElementType() reflect.Type {
	return reflect.TypeOf((*redisState)(nil)).Elem()
}

type redisArgs struct {
	// If the value is true, then the non-SLL Redis server port (6379) will be enabled.
	EnableNonSslPort *bool `pulumi:"enableNonSslPort"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The name of the Redis cache.
	Name *string `pulumi:"name"`
	// All Redis Settings. Few possible keys: rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value etc.
	RedisConfiguration map[string]string `pulumi:"redisConfiguration"`
	// RedisVersion parameter has been deprecated. As such, it is no longer necessary to provide this parameter and any value specified is ignored.
	RedisVersion *string `pulumi:"redisVersion"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The number of shards to be created on a Premium Cluster Cache.
	ShardCount *int `pulumi:"shardCount"`
	// What SKU of Redis cache to deploy.
	Sku Sku `pulumi:"sku"`
	// Required when deploying a Redis cache inside an existing Azure Virtual Network.
	StaticIP *string `pulumi:"staticIP"`
	// Required when deploying a Redis cache inside an existing Azure Virtual Network.
	Subnet *string `pulumi:"subnet"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// tenantSettings
	TenantSettings map[string]string `pulumi:"tenantSettings"`
	// The exact ARM resource ID of the virtual network to deploy the Redis cache in. Example format: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/Microsoft.ClassicNetwork/VirtualNetworks/vnet1
	VirtualNetwork *string `pulumi:"virtualNetwork"`
}

// The set of arguments for constructing a Redis resource.
type RedisArgs struct {
	// If the value is true, then the non-SLL Redis server port (6379) will be enabled.
	EnableNonSslPort pulumi.BoolPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The name of the Redis cache.
	Name pulumi.StringPtrInput
	// All Redis Settings. Few possible keys: rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value etc.
	RedisConfiguration pulumi.StringMapInput
	// RedisVersion parameter has been deprecated. As such, it is no longer necessary to provide this parameter and any value specified is ignored.
	RedisVersion pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The number of shards to be created on a Premium Cluster Cache.
	ShardCount pulumi.IntPtrInput
	// What SKU of Redis cache to deploy.
	Sku SkuInput
	// Required when deploying a Redis cache inside an existing Azure Virtual Network.
	StaticIP pulumi.StringPtrInput
	// Required when deploying a Redis cache inside an existing Azure Virtual Network.
	Subnet pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// tenantSettings
	TenantSettings pulumi.StringMapInput
	// The exact ARM resource ID of the virtual network to deploy the Redis cache in. Example format: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/Microsoft.ClassicNetwork/VirtualNetworks/vnet1
	VirtualNetwork pulumi.StringPtrInput
}

func (RedisArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*redisArgs)(nil)).Elem()
}

type RedisInput interface {
	pulumi.Input

	ToRedisOutput() RedisOutput
	ToRedisOutputWithContext(ctx context.Context) RedisOutput
}

func (*Redis) ElementType() reflect.Type {
	return reflect.TypeOf((**Redis)(nil)).Elem()
}

func (i *Redis) ToRedisOutput() RedisOutput {
	return i.ToRedisOutputWithContext(context.Background())
}

func (i *Redis) ToRedisOutputWithContext(ctx context.Context) RedisOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RedisOutput)
}

type RedisOutput struct{ *pulumi.OutputState }

func (RedisOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Redis)(nil)).Elem()
}

func (o RedisOutput) ToRedisOutput() RedisOutput {
	return o
}

func (o RedisOutput) ToRedisOutputWithContext(ctx context.Context) RedisOutput {
	return o
}

// Redis cache access keys.
func (o RedisOutput) AccessKeys() RedisAccessKeysResponsePtrOutput {
	return o.ApplyT(func(v *Redis) RedisAccessKeysResponsePtrOutput { return v.AccessKeys }).(RedisAccessKeysResponsePtrOutput)
}

// If the value is true, then the non-SLL Redis server port (6379) will be enabled.
func (o RedisOutput) EnableNonSslPort() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *Redis) pulumi.BoolPtrOutput { return v.EnableNonSslPort }).(pulumi.BoolPtrOutput)
}

// Redis host name.
func (o RedisOutput) HostName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Redis) pulumi.StringPtrOutput { return v.HostName }).(pulumi.StringPtrOutput)
}

// Resource location.
func (o RedisOutput) Location() pulumi.StringOutput {
	return o.ApplyT(func(v *Redis) pulumi.StringOutput { return v.Location }).(pulumi.StringOutput)
}

// Resource name.
func (o RedisOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Redis) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Redis non-SSL port.
func (o RedisOutput) Port() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *Redis) pulumi.IntPtrOutput { return v.Port }).(pulumi.IntPtrOutput)
}

// Redis instance provisioning status.
func (o RedisOutput) ProvisioningState() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Redis) pulumi.StringPtrOutput { return v.ProvisioningState }).(pulumi.StringPtrOutput)
}

// All Redis Settings. Few possible keys: rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value etc.
func (o RedisOutput) RedisConfiguration() pulumi.StringMapOutput {
	return o.ApplyT(func(v *Redis) pulumi.StringMapOutput { return v.RedisConfiguration }).(pulumi.StringMapOutput)
}

// RedisVersion parameter has been deprecated. As such, it is no longer necessary to provide this parameter and any value specified is ignored.
func (o RedisOutput) RedisVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Redis) pulumi.StringPtrOutput { return v.RedisVersion }).(pulumi.StringPtrOutput)
}

// The number of shards to be created on a Premium Cluster Cache.
func (o RedisOutput) ShardCount() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *Redis) pulumi.IntPtrOutput { return v.ShardCount }).(pulumi.IntPtrOutput)
}

// What SKU of Redis cache to deploy.
func (o RedisOutput) Sku() SkuResponseOutput {
	return o.ApplyT(func(v *Redis) SkuResponseOutput { return v.Sku }).(SkuResponseOutput)
}

// Redis SSL port.
func (o RedisOutput) SslPort() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *Redis) pulumi.IntPtrOutput { return v.SslPort }).(pulumi.IntPtrOutput)
}

// Required when deploying a Redis cache inside an existing Azure Virtual Network.
func (o RedisOutput) StaticIP() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Redis) pulumi.StringPtrOutput { return v.StaticIP }).(pulumi.StringPtrOutput)
}

// Required when deploying a Redis cache inside an existing Azure Virtual Network.
func (o RedisOutput) Subnet() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Redis) pulumi.StringPtrOutput { return v.Subnet }).(pulumi.StringPtrOutput)
}

// Resource tags.
func (o RedisOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v *Redis) pulumi.StringMapOutput { return v.Tags }).(pulumi.StringMapOutput)
}

// tenantSettings
func (o RedisOutput) TenantSettings() pulumi.StringMapOutput {
	return o.ApplyT(func(v *Redis) pulumi.StringMapOutput { return v.TenantSettings }).(pulumi.StringMapOutput)
}

// Resource type.
func (o RedisOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *Redis) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

// The exact ARM resource ID of the virtual network to deploy the Redis cache in. Example format: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/Microsoft.ClassicNetwork/VirtualNetworks/vnet1
func (o RedisOutput) VirtualNetwork() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Redis) pulumi.StringPtrOutput { return v.VirtualNetwork }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(RedisOutput{})
}
