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
    'GetHubRouteTableResult',
    'AwaitableGetHubRouteTableResult',
    'get_hub_route_table',
    'get_hub_route_table_output',
]

@pulumi.output_type
class GetHubRouteTableResult:
    """
    RouteTable resource in a virtual hub.
    """
    def __init__(__self__, associated_connections=None, etag=None, id=None, labels=None, name=None, propagating_connections=None, provisioning_state=None, routes=None, type=None):
        if associated_connections and not isinstance(associated_connections, list):
            raise TypeError("Expected argument 'associated_connections' to be a list")
        pulumi.set(__self__, "associated_connections", associated_connections)
        if etag and not isinstance(etag, str):
            raise TypeError("Expected argument 'etag' to be a str")
        pulumi.set(__self__, "etag", etag)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if labels and not isinstance(labels, list):
            raise TypeError("Expected argument 'labels' to be a list")
        pulumi.set(__self__, "labels", labels)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if propagating_connections and not isinstance(propagating_connections, list):
            raise TypeError("Expected argument 'propagating_connections' to be a list")
        pulumi.set(__self__, "propagating_connections", propagating_connections)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if routes and not isinstance(routes, list):
            raise TypeError("Expected argument 'routes' to be a list")
        pulumi.set(__self__, "routes", routes)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="associatedConnections")
    def associated_connections(self) -> Sequence[str]:
        """
        List of all connections associated with this route table.
        """
        return pulumi.get(self, "associated_connections")

    @property
    @pulumi.getter
    def etag(self) -> str:
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
    @pulumi.getter
    def labels(self) -> Optional[Sequence[str]]:
        """
        List of labels associated with this route table.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        The name of the resource that is unique within a resource group. This name can be used to access the resource.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="propagatingConnections")
    def propagating_connections(self) -> Sequence[str]:
        """
        List of all connections that advertise to this route table.
        """
        return pulumi.get(self, "propagating_connections")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        The provisioning state of the RouteTable resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def routes(self) -> Optional[Sequence['outputs.HubRouteResponse']]:
        """
        List of all routes.
        """
        return pulumi.get(self, "routes")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type.
        """
        return pulumi.get(self, "type")


class AwaitableGetHubRouteTableResult(GetHubRouteTableResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetHubRouteTableResult(
            associated_connections=self.associated_connections,
            etag=self.etag,
            id=self.id,
            labels=self.labels,
            name=self.name,
            propagating_connections=self.propagating_connections,
            provisioning_state=self.provisioning_state,
            routes=self.routes,
            type=self.type)


def get_hub_route_table(resource_group_name: Optional[str] = None,
                        route_table_name: Optional[str] = None,
                        virtual_hub_name: Optional[str] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetHubRouteTableResult:
    """
    RouteTable resource in a virtual hub.


    :param str resource_group_name: The resource group name of the VirtualHub.
    :param str route_table_name: The name of the RouteTable.
    :param str virtual_hub_name: The name of the VirtualHub.
    """
    __args__ = dict()
    __args__['resourceGroupName'] = resource_group_name
    __args__['routeTableName'] = route_table_name
    __args__['virtualHubName'] = virtual_hub_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:network/v20210801:getHubRouteTable', __args__, opts=opts, typ=GetHubRouteTableResult).value

    return AwaitableGetHubRouteTableResult(
        associated_connections=__ret__.associated_connections,
        etag=__ret__.etag,
        id=__ret__.id,
        labels=__ret__.labels,
        name=__ret__.name,
        propagating_connections=__ret__.propagating_connections,
        provisioning_state=__ret__.provisioning_state,
        routes=__ret__.routes,
        type=__ret__.type)


@_utilities.lift_output_func(get_hub_route_table)
def get_hub_route_table_output(resource_group_name: Optional[pulumi.Input[str]] = None,
                               route_table_name: Optional[pulumi.Input[str]] = None,
                               virtual_hub_name: Optional[pulumi.Input[str]] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetHubRouteTableResult]:
    """
    RouteTable resource in a virtual hub.


    :param str resource_group_name: The resource group name of the VirtualHub.
    :param str route_table_name: The name of the RouteTable.
    :param str virtual_hub_name: The name of the VirtualHub.
    """
    ...
