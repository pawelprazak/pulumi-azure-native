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
    'GetPrivateLinkServiceResult',
    'AwaitableGetPrivateLinkServiceResult',
    'get_private_link_service',
    'get_private_link_service_output',
]

@pulumi.output_type
class GetPrivateLinkServiceResult:
    """
    Private link service resource.
    """
    def __init__(__self__, alias=None, auto_approval=None, enable_proxy_protocol=None, etag=None, extended_location=None, fqdns=None, id=None, ip_configurations=None, load_balancer_frontend_ip_configurations=None, location=None, name=None, network_interfaces=None, private_endpoint_connections=None, provisioning_state=None, tags=None, type=None, visibility=None):
        if alias and not isinstance(alias, str):
            raise TypeError("Expected argument 'alias' to be a str")
        pulumi.set(__self__, "alias", alias)
        if auto_approval and not isinstance(auto_approval, dict):
            raise TypeError("Expected argument 'auto_approval' to be a dict")
        pulumi.set(__self__, "auto_approval", auto_approval)
        if enable_proxy_protocol and not isinstance(enable_proxy_protocol, bool):
            raise TypeError("Expected argument 'enable_proxy_protocol' to be a bool")
        pulumi.set(__self__, "enable_proxy_protocol", enable_proxy_protocol)
        if etag and not isinstance(etag, str):
            raise TypeError("Expected argument 'etag' to be a str")
        pulumi.set(__self__, "etag", etag)
        if extended_location and not isinstance(extended_location, dict):
            raise TypeError("Expected argument 'extended_location' to be a dict")
        pulumi.set(__self__, "extended_location", extended_location)
        if fqdns and not isinstance(fqdns, list):
            raise TypeError("Expected argument 'fqdns' to be a list")
        pulumi.set(__self__, "fqdns", fqdns)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if ip_configurations and not isinstance(ip_configurations, list):
            raise TypeError("Expected argument 'ip_configurations' to be a list")
        pulumi.set(__self__, "ip_configurations", ip_configurations)
        if load_balancer_frontend_ip_configurations and not isinstance(load_balancer_frontend_ip_configurations, list):
            raise TypeError("Expected argument 'load_balancer_frontend_ip_configurations' to be a list")
        pulumi.set(__self__, "load_balancer_frontend_ip_configurations", load_balancer_frontend_ip_configurations)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if network_interfaces and not isinstance(network_interfaces, list):
            raise TypeError("Expected argument 'network_interfaces' to be a list")
        pulumi.set(__self__, "network_interfaces", network_interfaces)
        if private_endpoint_connections and not isinstance(private_endpoint_connections, list):
            raise TypeError("Expected argument 'private_endpoint_connections' to be a list")
        pulumi.set(__self__, "private_endpoint_connections", private_endpoint_connections)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if visibility and not isinstance(visibility, dict):
            raise TypeError("Expected argument 'visibility' to be a dict")
        pulumi.set(__self__, "visibility", visibility)

    @property
    @pulumi.getter
    def alias(self) -> str:
        """
        The alias of the private link service.
        """
        return pulumi.get(self, "alias")

    @property
    @pulumi.getter(name="autoApproval")
    def auto_approval(self) -> Optional['outputs.PrivateLinkServicePropertiesResponseAutoApproval']:
        """
        The auto-approval list of the private link service.
        """
        return pulumi.get(self, "auto_approval")

    @property
    @pulumi.getter(name="enableProxyProtocol")
    def enable_proxy_protocol(self) -> Optional[bool]:
        """
        Whether the private link service is enabled for proxy protocol or not.
        """
        return pulumi.get(self, "enable_proxy_protocol")

    @property
    @pulumi.getter
    def etag(self) -> str:
        """
        A unique read-only string that changes whenever the resource is updated.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter(name="extendedLocation")
    def extended_location(self) -> Optional['outputs.ExtendedLocationResponse']:
        """
        The extended location of the load balancer.
        """
        return pulumi.get(self, "extended_location")

    @property
    @pulumi.getter
    def fqdns(self) -> Optional[Sequence[str]]:
        """
        The list of Fqdn.
        """
        return pulumi.get(self, "fqdns")

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        Resource ID.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="ipConfigurations")
    def ip_configurations(self) -> Optional[Sequence['outputs.PrivateLinkServiceIpConfigurationResponse']]:
        """
        An array of private link service IP configurations.
        """
        return pulumi.get(self, "ip_configurations")

    @property
    @pulumi.getter(name="loadBalancerFrontendIpConfigurations")
    def load_balancer_frontend_ip_configurations(self) -> Optional[Sequence['outputs.FrontendIPConfigurationResponse']]:
        """
        An array of references to the load balancer IP configurations.
        """
        return pulumi.get(self, "load_balancer_frontend_ip_configurations")

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        Resource location.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkInterfaces")
    def network_interfaces(self) -> Sequence['outputs.NetworkInterfaceResponse']:
        """
        An array of references to the network interfaces created for this private link service.
        """
        return pulumi.get(self, "network_interfaces")

    @property
    @pulumi.getter(name="privateEndpointConnections")
    def private_endpoint_connections(self) -> Sequence['outputs.PrivateEndpointConnectionResponse']:
        """
        An array of list about connections to the private endpoint.
        """
        return pulumi.get(self, "private_endpoint_connections")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        The provisioning state of the private link service resource.
        """
        return pulumi.get(self, "provisioning_state")

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
        Resource type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def visibility(self) -> Optional['outputs.PrivateLinkServicePropertiesResponseVisibility']:
        """
        The visibility list of the private link service.
        """
        return pulumi.get(self, "visibility")


class AwaitableGetPrivateLinkServiceResult(GetPrivateLinkServiceResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetPrivateLinkServiceResult(
            alias=self.alias,
            auto_approval=self.auto_approval,
            enable_proxy_protocol=self.enable_proxy_protocol,
            etag=self.etag,
            extended_location=self.extended_location,
            fqdns=self.fqdns,
            id=self.id,
            ip_configurations=self.ip_configurations,
            load_balancer_frontend_ip_configurations=self.load_balancer_frontend_ip_configurations,
            location=self.location,
            name=self.name,
            network_interfaces=self.network_interfaces,
            private_endpoint_connections=self.private_endpoint_connections,
            provisioning_state=self.provisioning_state,
            tags=self.tags,
            type=self.type,
            visibility=self.visibility)


def get_private_link_service(expand: Optional[str] = None,
                             resource_group_name: Optional[str] = None,
                             service_name: Optional[str] = None,
                             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetPrivateLinkServiceResult:
    """
    Private link service resource.


    :param str expand: Expands referenced resources.
    :param str resource_group_name: The name of the resource group.
    :param str service_name: The name of the private link service.
    """
    __args__ = dict()
    __args__['expand'] = expand
    __args__['resourceGroupName'] = resource_group_name
    __args__['serviceName'] = service_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:network/v20220101:getPrivateLinkService', __args__, opts=opts, typ=GetPrivateLinkServiceResult).value

    return AwaitableGetPrivateLinkServiceResult(
        alias=__ret__.alias,
        auto_approval=__ret__.auto_approval,
        enable_proxy_protocol=__ret__.enable_proxy_protocol,
        etag=__ret__.etag,
        extended_location=__ret__.extended_location,
        fqdns=__ret__.fqdns,
        id=__ret__.id,
        ip_configurations=__ret__.ip_configurations,
        load_balancer_frontend_ip_configurations=__ret__.load_balancer_frontend_ip_configurations,
        location=__ret__.location,
        name=__ret__.name,
        network_interfaces=__ret__.network_interfaces,
        private_endpoint_connections=__ret__.private_endpoint_connections,
        provisioning_state=__ret__.provisioning_state,
        tags=__ret__.tags,
        type=__ret__.type,
        visibility=__ret__.visibility)


@_utilities.lift_output_func(get_private_link_service)
def get_private_link_service_output(expand: Optional[pulumi.Input[Optional[str]]] = None,
                                    resource_group_name: Optional[pulumi.Input[str]] = None,
                                    service_name: Optional[pulumi.Input[str]] = None,
                                    opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetPrivateLinkServiceResult]:
    """
    Private link service resource.


    :param str expand: Expands referenced resources.
    :param str resource_group_name: The name of the resource group.
    :param str service_name: The name of the private link service.
    """
    ...
