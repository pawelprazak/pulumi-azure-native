# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from . import outputs

__all__ = [
    'GetCacheResult',
    'AwaitableGetCacheResult',
    'get_cache',
    'get_cache_output',
]

warnings.warn("""Version 2019-08-01-preview will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetCacheResult:
    """
    A cache instance.  Follows Azure Resource Manager standards: https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/resource-api-reference.md
    """
    def __init__(__self__, cache_size_gb=None, health=None, id=None, location=None, mount_addresses=None, name=None, provisioning_state=None, sku=None, subnet=None, tags=None, type=None, upgrade_status=None):
        if cache_size_gb and not isinstance(cache_size_gb, int):
            raise TypeError("Expected argument 'cache_size_gb' to be a int")
        pulumi.set(__self__, "cache_size_gb", cache_size_gb)
        if health and not isinstance(health, dict):
            raise TypeError("Expected argument 'health' to be a dict")
        pulumi.set(__self__, "health", health)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if mount_addresses and not isinstance(mount_addresses, list):
            raise TypeError("Expected argument 'mount_addresses' to be a list")
        pulumi.set(__self__, "mount_addresses", mount_addresses)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if sku and not isinstance(sku, dict):
            raise TypeError("Expected argument 'sku' to be a dict")
        pulumi.set(__self__, "sku", sku)
        if subnet and not isinstance(subnet, str):
            raise TypeError("Expected argument 'subnet' to be a str")
        pulumi.set(__self__, "subnet", subnet)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if upgrade_status and not isinstance(upgrade_status, dict):
            raise TypeError("Expected argument 'upgrade_status' to be a dict")
        pulumi.set(__self__, "upgrade_status", upgrade_status)

    @property
    @pulumi.getter(name="cacheSizeGB")
    def cache_size_gb(self) -> Optional[int]:
        """
        The size of this cache's cache, in GB.
        """
        return pulumi.get(self, "cache_size_gb")

    @property
    @pulumi.getter
    def health(self) -> 'outputs.CacheHealthResponse':
        """
        Health of the cache.
        """
        return pulumi.get(self, "health")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Fully qualified URL of the cache.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        Region name string.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="mountAddresses")
    def mount_addresses(self) -> Sequence[str]:
        """
        Array of IP addresses that can be used by clients mounting this Cache.
        """
        return pulumi.get(self, "mount_addresses")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of cache.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> Optional[str]:
        """
        ARM provisioning state, see https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/Addendum.md#provisioningstate-property
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def sku(self) -> Optional['outputs.CacheResponseSku']:
        """
        Sku for the cache.
        """
        return pulumi.get(self, "sku")

    @property
    @pulumi.getter
    def subnet(self) -> Optional[str]:
        """
        Subnet used for the cache.
        """
        return pulumi.get(self, "subnet")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Any]:
        """
        ARM tags as name/value pairs.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Type for the cache; Microsoft.StorageCache/Cache
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="upgradeStatus")
    def upgrade_status(self) -> Optional['outputs.CacheUpgradeStatusResponse']:
        """
        Upgrade status of the cache.
        """
        return pulumi.get(self, "upgrade_status")


class AwaitableGetCacheResult(GetCacheResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetCacheResult(
            cache_size_gb=self.cache_size_gb,
            health=self.health,
            id=self.id,
            location=self.location,
            mount_addresses=self.mount_addresses,
            name=self.name,
            provisioning_state=self.provisioning_state,
            sku=self.sku,
            subnet=self.subnet,
            tags=self.tags,
            type=self.type,
            upgrade_status=self.upgrade_status)


def get_cache(cache_name: Optional[str] = None,
              resource_group_name: Optional[str] = None,
              opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetCacheResult:
    """
    A cache instance.  Follows Azure Resource Manager standards: https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/resource-api-reference.md


    :param str cache_name: Name of cache.
    :param str resource_group_name: Target resource group.
    """
    pulumi.log.warn("""get_cache is deprecated: Version 2019-08-01-preview will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['cacheName'] = cache_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:storagecache/v20190801preview:getCache', __args__, opts=opts, typ=GetCacheResult).value

    return AwaitableGetCacheResult(
        cache_size_gb=__ret__.cache_size_gb,
        health=__ret__.health,
        id=__ret__.id,
        location=__ret__.location,
        mount_addresses=__ret__.mount_addresses,
        name=__ret__.name,
        provisioning_state=__ret__.provisioning_state,
        sku=__ret__.sku,
        subnet=__ret__.subnet,
        tags=__ret__.tags,
        type=__ret__.type,
        upgrade_status=__ret__.upgrade_status)


@_utilities.lift_output_func(get_cache)
def get_cache_output(cache_name: Optional[pulumi.Input[str]] = None,
                     resource_group_name: Optional[pulumi.Input[str]] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetCacheResult]:
    """
    A cache instance.  Follows Azure Resource Manager standards: https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/resource-api-reference.md


    :param str cache_name: Name of cache.
    :param str resource_group_name: Target resource group.
    """
    pulumi.log.warn("""get_cache is deprecated: Version 2019-08-01-preview will be removed in v2 of the provider.""")
    ...
