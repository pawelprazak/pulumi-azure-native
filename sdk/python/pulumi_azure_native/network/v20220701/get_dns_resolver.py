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
    'GetDnsResolverResult',
    'AwaitableGetDnsResolverResult',
    'get_dns_resolver',
    'get_dns_resolver_output',
]

@pulumi.output_type
class GetDnsResolverResult:
    """
    Describes a DNS resolver.
    """
    def __init__(__self__, dns_resolver_state=None, etag=None, id=None, location=None, name=None, provisioning_state=None, resource_guid=None, system_data=None, tags=None, type=None, virtual_network=None):
        if dns_resolver_state and not isinstance(dns_resolver_state, str):
            raise TypeError("Expected argument 'dns_resolver_state' to be a str")
        pulumi.set(__self__, "dns_resolver_state", dns_resolver_state)
        if etag and not isinstance(etag, str):
            raise TypeError("Expected argument 'etag' to be a str")
        pulumi.set(__self__, "etag", etag)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if resource_guid and not isinstance(resource_guid, str):
            raise TypeError("Expected argument 'resource_guid' to be a str")
        pulumi.set(__self__, "resource_guid", resource_guid)
        if system_data and not isinstance(system_data, dict):
            raise TypeError("Expected argument 'system_data' to be a dict")
        pulumi.set(__self__, "system_data", system_data)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if virtual_network and not isinstance(virtual_network, dict):
            raise TypeError("Expected argument 'virtual_network' to be a dict")
        pulumi.set(__self__, "virtual_network", virtual_network)

    @property
    @pulumi.getter(name="dnsResolverState")
    def dns_resolver_state(self) -> str:
        """
        The current status of the DNS resolver. This is a read-only property and any attempt to set this value will be ignored.
        """
        return pulumi.get(self, "dns_resolver_state")

    @property
    @pulumi.getter
    def etag(self) -> str:
        """
        ETag of the DNS resolver.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def location(self) -> str:
        """
        The geo-location where the resource lives
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        The current provisioning state of the DNS resolver. This is a read-only property and any attempt to set this value will be ignored.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="resourceGuid")
    def resource_guid(self) -> str:
        """
        The resourceGuid property of the DNS resolver resource.
        """
        return pulumi.get(self, "resource_guid")

    @property
    @pulumi.getter(name="systemData")
    def system_data(self) -> 'outputs.SystemDataResponse':
        """
        Metadata pertaining to creation and last modification of the resource.
        """
        return pulumi.get(self, "system_data")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="virtualNetwork")
    def virtual_network(self) -> 'outputs.SubResourceResponse':
        """
        The reference to the virtual network. This cannot be changed after creation.
        """
        return pulumi.get(self, "virtual_network")


class AwaitableGetDnsResolverResult(GetDnsResolverResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDnsResolverResult(
            dns_resolver_state=self.dns_resolver_state,
            etag=self.etag,
            id=self.id,
            location=self.location,
            name=self.name,
            provisioning_state=self.provisioning_state,
            resource_guid=self.resource_guid,
            system_data=self.system_data,
            tags=self.tags,
            type=self.type,
            virtual_network=self.virtual_network)


def get_dns_resolver(dns_resolver_name: Optional[str] = None,
                     resource_group_name: Optional[str] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDnsResolverResult:
    """
    Describes a DNS resolver.


    :param str dns_resolver_name: The name of the DNS resolver.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    """
    __args__ = dict()
    __args__['dnsResolverName'] = dns_resolver_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:network/v20220701:getDnsResolver', __args__, opts=opts, typ=GetDnsResolverResult).value

    return AwaitableGetDnsResolverResult(
        dns_resolver_state=__ret__.dns_resolver_state,
        etag=__ret__.etag,
        id=__ret__.id,
        location=__ret__.location,
        name=__ret__.name,
        provisioning_state=__ret__.provisioning_state,
        resource_guid=__ret__.resource_guid,
        system_data=__ret__.system_data,
        tags=__ret__.tags,
        type=__ret__.type,
        virtual_network=__ret__.virtual_network)


@_utilities.lift_output_func(get_dns_resolver)
def get_dns_resolver_output(dns_resolver_name: Optional[pulumi.Input[str]] = None,
                            resource_group_name: Optional[pulumi.Input[str]] = None,
                            opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetDnsResolverResult]:
    """
    Describes a DNS resolver.


    :param str dns_resolver_name: The name of the DNS resolver.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    """
    ...
