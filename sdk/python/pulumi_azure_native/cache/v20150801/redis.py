# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from . import outputs
from ._enums import *
from ._inputs import *

__all__ = ['RedisArgs', 'Redis']

@pulumi.input_type
class RedisArgs:
    def __init__(__self__, *,
                 resource_group_name: pulumi.Input[str],
                 sku: pulumi.Input['SkuArgs'],
                 enable_non_ssl_port: Optional[pulumi.Input[bool]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 redis_configuration: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 redis_version: Optional[pulumi.Input[str]] = None,
                 shard_count: Optional[pulumi.Input[int]] = None,
                 static_ip: Optional[pulumi.Input[str]] = None,
                 subnet: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 tenant_settings: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 virtual_network: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Redis resource.
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input['SkuArgs'] sku: What SKU of Redis cache to deploy.
        :param pulumi.Input[bool] enable_non_ssl_port: If the value is true, then the non-SLL Redis server port (6379) will be enabled.
        :param pulumi.Input[str] location: Resource location.
        :param pulumi.Input[str] name: The name of the Redis cache.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] redis_configuration: All Redis Settings. Few possible keys: rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value etc.
        :param pulumi.Input[str] redis_version: RedisVersion parameter has been deprecated. As such, it is no longer necessary to provide this parameter and any value specified is ignored.
        :param pulumi.Input[int] shard_count: The number of shards to be created on a Premium Cluster Cache.
        :param pulumi.Input[str] static_ip: Required when deploying a Redis cache inside an existing Azure Virtual Network.
        :param pulumi.Input[str] subnet: Required when deploying a Redis cache inside an existing Azure Virtual Network.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tenant_settings: tenantSettings
        :param pulumi.Input[str] virtual_network: The exact ARM resource ID of the virtual network to deploy the Redis cache in. Example format: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/Microsoft.ClassicNetwork/VirtualNetworks/vnet1
        """
        pulumi.set(__self__, "resource_group_name", resource_group_name)
        pulumi.set(__self__, "sku", sku)
        if enable_non_ssl_port is not None:
            pulumi.set(__self__, "enable_non_ssl_port", enable_non_ssl_port)
        if location is not None:
            pulumi.set(__self__, "location", location)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if redis_configuration is not None:
            pulumi.set(__self__, "redis_configuration", redis_configuration)
        if redis_version is not None:
            pulumi.set(__self__, "redis_version", redis_version)
        if shard_count is not None:
            pulumi.set(__self__, "shard_count", shard_count)
        if static_ip is not None:
            pulumi.set(__self__, "static_ip", static_ip)
        if subnet is not None:
            pulumi.set(__self__, "subnet", subnet)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if tenant_settings is not None:
            pulumi.set(__self__, "tenant_settings", tenant_settings)
        if virtual_network is not None:
            pulumi.set(__self__, "virtual_network", virtual_network)

    @property
    @pulumi.getter(name="resourceGroupName")
    def resource_group_name(self) -> pulumi.Input[str]:
        """
        The name of the resource group.
        """
        return pulumi.get(self, "resource_group_name")

    @resource_group_name.setter
    def resource_group_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "resource_group_name", value)

    @property
    @pulumi.getter
    def sku(self) -> pulumi.Input['SkuArgs']:
        """
        What SKU of Redis cache to deploy.
        """
        return pulumi.get(self, "sku")

    @sku.setter
    def sku(self, value: pulumi.Input['SkuArgs']):
        pulumi.set(self, "sku", value)

    @property
    @pulumi.getter(name="enableNonSslPort")
    def enable_non_ssl_port(self) -> Optional[pulumi.Input[bool]]:
        """
        If the value is true, then the non-SLL Redis server port (6379) will be enabled.
        """
        return pulumi.get(self, "enable_non_ssl_port")

    @enable_non_ssl_port.setter
    def enable_non_ssl_port(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enable_non_ssl_port", value)

    @property
    @pulumi.getter
    def location(self) -> Optional[pulumi.Input[str]]:
        """
        Resource location.
        """
        return pulumi.get(self, "location")

    @location.setter
    def location(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "location", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the Redis cache.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="redisConfiguration")
    def redis_configuration(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        All Redis Settings. Few possible keys: rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value etc.
        """
        return pulumi.get(self, "redis_configuration")

    @redis_configuration.setter
    def redis_configuration(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "redis_configuration", value)

    @property
    @pulumi.getter(name="redisVersion")
    def redis_version(self) -> Optional[pulumi.Input[str]]:
        """
        RedisVersion parameter has been deprecated. As such, it is no longer necessary to provide this parameter and any value specified is ignored.
        """
        return pulumi.get(self, "redis_version")

    @redis_version.setter
    def redis_version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "redis_version", value)

    @property
    @pulumi.getter(name="shardCount")
    def shard_count(self) -> Optional[pulumi.Input[int]]:
        """
        The number of shards to be created on a Premium Cluster Cache.
        """
        return pulumi.get(self, "shard_count")

    @shard_count.setter
    def shard_count(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "shard_count", value)

    @property
    @pulumi.getter(name="staticIP")
    def static_ip(self) -> Optional[pulumi.Input[str]]:
        """
        Required when deploying a Redis cache inside an existing Azure Virtual Network.
        """
        return pulumi.get(self, "static_ip")

    @static_ip.setter
    def static_ip(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "static_ip", value)

    @property
    @pulumi.getter
    def subnet(self) -> Optional[pulumi.Input[str]]:
        """
        Required when deploying a Redis cache inside an existing Azure Virtual Network.
        """
        return pulumi.get(self, "subnet")

    @subnet.setter
    def subnet(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "subnet", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter(name="tenantSettings")
    def tenant_settings(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        tenantSettings
        """
        return pulumi.get(self, "tenant_settings")

    @tenant_settings.setter
    def tenant_settings(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "tenant_settings", value)

    @property
    @pulumi.getter(name="virtualNetwork")
    def virtual_network(self) -> Optional[pulumi.Input[str]]:
        """
        The exact ARM resource ID of the virtual network to deploy the Redis cache in. Example format: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/Microsoft.ClassicNetwork/VirtualNetworks/vnet1
        """
        return pulumi.get(self, "virtual_network")

    @virtual_network.setter
    def virtual_network(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "virtual_network", value)


warnings.warn("""Version 2015-08-01 will be removed in v2 of the provider.""", DeprecationWarning)


class Redis(pulumi.CustomResource):
    warnings.warn("""Version 2015-08-01 will be removed in v2 of the provider.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enable_non_ssl_port: Optional[pulumi.Input[bool]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 redis_configuration: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 redis_version: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 shard_count: Optional[pulumi.Input[int]] = None,
                 sku: Optional[pulumi.Input[pulumi.InputType['SkuArgs']]] = None,
                 static_ip: Optional[pulumi.Input[str]] = None,
                 subnet: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 tenant_settings: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 virtual_network: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        A Redis item in CreateOrUpdate Operation response.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] enable_non_ssl_port: If the value is true, then the non-SLL Redis server port (6379) will be enabled.
        :param pulumi.Input[str] location: Resource location.
        :param pulumi.Input[str] name: The name of the Redis cache.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] redis_configuration: All Redis Settings. Few possible keys: rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value etc.
        :param pulumi.Input[str] redis_version: RedisVersion parameter has been deprecated. As such, it is no longer necessary to provide this parameter and any value specified is ignored.
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[int] shard_count: The number of shards to be created on a Premium Cluster Cache.
        :param pulumi.Input[pulumi.InputType['SkuArgs']] sku: What SKU of Redis cache to deploy.
        :param pulumi.Input[str] static_ip: Required when deploying a Redis cache inside an existing Azure Virtual Network.
        :param pulumi.Input[str] subnet: Required when deploying a Redis cache inside an existing Azure Virtual Network.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tenant_settings: tenantSettings
        :param pulumi.Input[str] virtual_network: The exact ARM resource ID of the virtual network to deploy the Redis cache in. Example format: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/Microsoft.ClassicNetwork/VirtualNetworks/vnet1
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: RedisArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        A Redis item in CreateOrUpdate Operation response.

        :param str resource_name: The name of the resource.
        :param RedisArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(RedisArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enable_non_ssl_port: Optional[pulumi.Input[bool]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 redis_configuration: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 redis_version: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 shard_count: Optional[pulumi.Input[int]] = None,
                 sku: Optional[pulumi.Input[pulumi.InputType['SkuArgs']]] = None,
                 static_ip: Optional[pulumi.Input[str]] = None,
                 subnet: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 tenant_settings: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 virtual_network: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        pulumi.log.warn("""Redis is deprecated: Version 2015-08-01 will be removed in v2 of the provider.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = RedisArgs.__new__(RedisArgs)

            __props__.__dict__["enable_non_ssl_port"] = enable_non_ssl_port
            __props__.__dict__["location"] = location
            __props__.__dict__["name"] = name
            __props__.__dict__["redis_configuration"] = redis_configuration
            __props__.__dict__["redis_version"] = redis_version
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__.__dict__["resource_group_name"] = resource_group_name
            __props__.__dict__["shard_count"] = shard_count
            if sku is None and not opts.urn:
                raise TypeError("Missing required property 'sku'")
            __props__.__dict__["sku"] = sku
            __props__.__dict__["static_ip"] = static_ip
            __props__.__dict__["subnet"] = subnet
            __props__.__dict__["tags"] = tags
            __props__.__dict__["tenant_settings"] = tenant_settings
            __props__.__dict__["virtual_network"] = virtual_network
            __props__.__dict__["access_keys"] = None
            __props__.__dict__["host_name"] = None
            __props__.__dict__["port"] = None
            __props__.__dict__["provisioning_state"] = None
            __props__.__dict__["ssl_port"] = None
            __props__.__dict__["type"] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-native:cache:Redis"), pulumi.Alias(type_="azure-native:cache/v20160401:Redis"), pulumi.Alias(type_="azure-native:cache/v20170201:Redis"), pulumi.Alias(type_="azure-native:cache/v20171001:Redis"), pulumi.Alias(type_="azure-native:cache/v20180301:Redis"), pulumi.Alias(type_="azure-native:cache/v20190701:Redis"), pulumi.Alias(type_="azure-native:cache/v20200601:Redis"), pulumi.Alias(type_="azure-native:cache/v20201201:Redis"), pulumi.Alias(type_="azure-native:cache/v20210601:Redis")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Redis, __self__).__init__(
            'azure-native:cache/v20150801:Redis',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Redis':
        """
        Get an existing Redis resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = RedisArgs.__new__(RedisArgs)

        __props__.__dict__["access_keys"] = None
        __props__.__dict__["enable_non_ssl_port"] = None
        __props__.__dict__["host_name"] = None
        __props__.__dict__["location"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["port"] = None
        __props__.__dict__["provisioning_state"] = None
        __props__.__dict__["redis_configuration"] = None
        __props__.__dict__["redis_version"] = None
        __props__.__dict__["shard_count"] = None
        __props__.__dict__["sku"] = None
        __props__.__dict__["ssl_port"] = None
        __props__.__dict__["static_ip"] = None
        __props__.__dict__["subnet"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["tenant_settings"] = None
        __props__.__dict__["type"] = None
        __props__.__dict__["virtual_network"] = None
        return Redis(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="accessKeys")
    def access_keys(self) -> pulumi.Output[Optional['outputs.RedisAccessKeysResponse']]:
        """
        Redis cache access keys.
        """
        return pulumi.get(self, "access_keys")

    @property
    @pulumi.getter(name="enableNonSslPort")
    def enable_non_ssl_port(self) -> pulumi.Output[Optional[bool]]:
        """
        If the value is true, then the non-SLL Redis server port (6379) will be enabled.
        """
        return pulumi.get(self, "enable_non_ssl_port")

    @property
    @pulumi.getter(name="hostName")
    def host_name(self) -> pulumi.Output[Optional[str]]:
        """
        Redis host name.
        """
        return pulumi.get(self, "host_name")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Resource location.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def port(self) -> pulumi.Output[Optional[int]]:
        """
        Redis non-SSL port.
        """
        return pulumi.get(self, "port")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[Optional[str]]:
        """
        Redis instance provisioning status.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="redisConfiguration")
    def redis_configuration(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        All Redis Settings. Few possible keys: rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value etc.
        """
        return pulumi.get(self, "redis_configuration")

    @property
    @pulumi.getter(name="redisVersion")
    def redis_version(self) -> pulumi.Output[Optional[str]]:
        """
        RedisVersion parameter has been deprecated. As such, it is no longer necessary to provide this parameter and any value specified is ignored.
        """
        return pulumi.get(self, "redis_version")

    @property
    @pulumi.getter(name="shardCount")
    def shard_count(self) -> pulumi.Output[Optional[int]]:
        """
        The number of shards to be created on a Premium Cluster Cache.
        """
        return pulumi.get(self, "shard_count")

    @property
    @pulumi.getter
    def sku(self) -> pulumi.Output['outputs.SkuResponse']:
        """
        What SKU of Redis cache to deploy.
        """
        return pulumi.get(self, "sku")

    @property
    @pulumi.getter(name="sslPort")
    def ssl_port(self) -> pulumi.Output[Optional[int]]:
        """
        Redis SSL port.
        """
        return pulumi.get(self, "ssl_port")

    @property
    @pulumi.getter(name="staticIP")
    def static_ip(self) -> pulumi.Output[Optional[str]]:
        """
        Required when deploying a Redis cache inside an existing Azure Virtual Network.
        """
        return pulumi.get(self, "static_ip")

    @property
    @pulumi.getter
    def subnet(self) -> pulumi.Output[Optional[str]]:
        """
        Required when deploying a Redis cache inside an existing Azure Virtual Network.
        """
        return pulumi.get(self, "subnet")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="tenantSettings")
    def tenant_settings(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        tenantSettings
        """
        return pulumi.get(self, "tenant_settings")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="virtualNetwork")
    def virtual_network(self) -> pulumi.Output[Optional[str]]:
        """
        The exact ARM resource ID of the virtual network to deploy the Redis cache in. Example format: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/Microsoft.ClassicNetwork/VirtualNetworks/vnet1
        """
        return pulumi.get(self, "virtual_network")

