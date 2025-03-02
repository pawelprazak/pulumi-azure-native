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
    'GetSubnetResult',
    'AwaitableGetSubnetResult',
    'get_subnet',
    'get_subnet_output',
]

warnings.warn("""Version 2018-02-01 will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetSubnetResult:
    """
    Subnet in a virtual network resource.
    """
    def __init__(__self__, address_prefix=None, etag=None, id=None, ip_configurations=None, name=None, network_security_group=None, provisioning_state=None, resource_navigation_links=None, route_table=None, service_endpoints=None):
        if address_prefix and not isinstance(address_prefix, str):
            raise TypeError("Expected argument 'address_prefix' to be a str")
        pulumi.set(__self__, "address_prefix", address_prefix)
        if etag and not isinstance(etag, str):
            raise TypeError("Expected argument 'etag' to be a str")
        pulumi.set(__self__, "etag", etag)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if ip_configurations and not isinstance(ip_configurations, list):
            raise TypeError("Expected argument 'ip_configurations' to be a list")
        pulumi.set(__self__, "ip_configurations", ip_configurations)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if network_security_group and not isinstance(network_security_group, dict):
            raise TypeError("Expected argument 'network_security_group' to be a dict")
        pulumi.set(__self__, "network_security_group", network_security_group)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if resource_navigation_links and not isinstance(resource_navigation_links, list):
            raise TypeError("Expected argument 'resource_navigation_links' to be a list")
        pulumi.set(__self__, "resource_navigation_links", resource_navigation_links)
        if route_table and not isinstance(route_table, dict):
            raise TypeError("Expected argument 'route_table' to be a dict")
        pulumi.set(__self__, "route_table", route_table)
        if service_endpoints and not isinstance(service_endpoints, list):
            raise TypeError("Expected argument 'service_endpoints' to be a list")
        pulumi.set(__self__, "service_endpoints", service_endpoints)

    @property
    @pulumi.getter(name="addressPrefix")
    def address_prefix(self) -> Optional[str]:
        """
        The address prefix for the subnet.
        """
        return pulumi.get(self, "address_prefix")

    @property
    @pulumi.getter
    def etag(self) -> Optional[str]:
        """
        A unique read-only string that changes whenever the resource is updated.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        Resource ID.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="ipConfigurations")
    def ip_configurations(self) -> Sequence['outputs.IPConfigurationResponse']:
        """
        Gets an array of references to the network interface IP configurations using subnet.
        """
        return pulumi.get(self, "ip_configurations")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        The name of the resource that is unique within a resource group. This name can be used to access the resource.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkSecurityGroup")
    def network_security_group(self) -> Optional['outputs.NetworkSecurityGroupResponse']:
        """
        The reference of the NetworkSecurityGroup resource.
        """
        return pulumi.get(self, "network_security_group")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> Optional[str]:
        """
        The provisioning state of the resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="resourceNavigationLinks")
    def resource_navigation_links(self) -> Optional[Sequence['outputs.ResourceNavigationLinkResponse']]:
        """
        Gets an array of references to the external resources using subnet.
        """
        return pulumi.get(self, "resource_navigation_links")

    @property
    @pulumi.getter(name="routeTable")
    def route_table(self) -> Optional['outputs.RouteTableResponse']:
        """
        The reference of the RouteTable resource.
        """
        return pulumi.get(self, "route_table")

    @property
    @pulumi.getter(name="serviceEndpoints")
    def service_endpoints(self) -> Optional[Sequence['outputs.ServiceEndpointPropertiesFormatResponse']]:
        """
        An array of service endpoints.
        """
        return pulumi.get(self, "service_endpoints")


class AwaitableGetSubnetResult(GetSubnetResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSubnetResult(
            address_prefix=self.address_prefix,
            etag=self.etag,
            id=self.id,
            ip_configurations=self.ip_configurations,
            name=self.name,
            network_security_group=self.network_security_group,
            provisioning_state=self.provisioning_state,
            resource_navigation_links=self.resource_navigation_links,
            route_table=self.route_table,
            service_endpoints=self.service_endpoints)


def get_subnet(expand: Optional[str] = None,
               resource_group_name: Optional[str] = None,
               subnet_name: Optional[str] = None,
               virtual_network_name: Optional[str] = None,
               opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetSubnetResult:
    """
    Subnet in a virtual network resource.


    :param str expand: Expands referenced resources.
    :param str resource_group_name: The name of the resource group.
    :param str subnet_name: The name of the subnet.
    :param str virtual_network_name: The name of the virtual network.
    """
    pulumi.log.warn("""get_subnet is deprecated: Version 2018-02-01 will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['expand'] = expand
    __args__['resourceGroupName'] = resource_group_name
    __args__['subnetName'] = subnet_name
    __args__['virtualNetworkName'] = virtual_network_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:network/v20180201:getSubnet', __args__, opts=opts, typ=GetSubnetResult).value

    return AwaitableGetSubnetResult(
        address_prefix=__ret__.address_prefix,
        etag=__ret__.etag,
        id=__ret__.id,
        ip_configurations=__ret__.ip_configurations,
        name=__ret__.name,
        network_security_group=__ret__.network_security_group,
        provisioning_state=__ret__.provisioning_state,
        resource_navigation_links=__ret__.resource_navigation_links,
        route_table=__ret__.route_table,
        service_endpoints=__ret__.service_endpoints)


@_utilities.lift_output_func(get_subnet)
def get_subnet_output(expand: Optional[pulumi.Input[Optional[str]]] = None,
                      resource_group_name: Optional[pulumi.Input[str]] = None,
                      subnet_name: Optional[pulumi.Input[str]] = None,
                      virtual_network_name: Optional[pulumi.Input[str]] = None,
                      opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetSubnetResult]:
    """
    Subnet in a virtual network resource.


    :param str expand: Expands referenced resources.
    :param str resource_group_name: The name of the resource group.
    :param str subnet_name: The name of the subnet.
    :param str virtual_network_name: The name of the virtual network.
    """
    pulumi.log.warn("""get_subnet is deprecated: Version 2018-02-01 will be removed in v2 of the provider.""")
    ...
