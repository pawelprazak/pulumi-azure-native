# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'GetPrivateLinkScopedResourceResult',
    'AwaitableGetPrivateLinkScopedResourceResult',
    'get_private_link_scoped_resource',
    'get_private_link_scoped_resource_output',
]

@pulumi.output_type
class GetPrivateLinkScopedResourceResult:
    """
    A private link scoped resource
    """
    def __init__(__self__, id=None, linked_resource_id=None, name=None, provisioning_state=None, type=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if linked_resource_id and not isinstance(linked_resource_id, str):
            raise TypeError("Expected argument 'linked_resource_id' to be a str")
        pulumi.set(__self__, "linked_resource_id", linked_resource_id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Azure resource Id
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="linkedResourceId")
    def linked_resource_id(self) -> Optional[str]:
        """
        The resource id of the scoped Azure monitor resource.
        """
        return pulumi.get(self, "linked_resource_id")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Azure resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        State of the private endpoint connection.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Azure resource type
        """
        return pulumi.get(self, "type")


class AwaitableGetPrivateLinkScopedResourceResult(GetPrivateLinkScopedResourceResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetPrivateLinkScopedResourceResult(
            id=self.id,
            linked_resource_id=self.linked_resource_id,
            name=self.name,
            provisioning_state=self.provisioning_state,
            type=self.type)


def get_private_link_scoped_resource(name: Optional[str] = None,
                                     resource_group_name: Optional[str] = None,
                                     scope_name: Optional[str] = None,
                                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetPrivateLinkScopedResourceResult:
    """
    A private link scoped resource
    API Version: 2019-10-17-preview.


    :param str name: The name of the scoped resource object.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    :param str scope_name: The name of the Azure Monitor PrivateLinkScope resource.
    """
    __args__ = dict()
    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    __args__['scopeName'] = scope_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:insights:getPrivateLinkScopedResource', __args__, opts=opts, typ=GetPrivateLinkScopedResourceResult).value

    return AwaitableGetPrivateLinkScopedResourceResult(
        id=__ret__.id,
        linked_resource_id=__ret__.linked_resource_id,
        name=__ret__.name,
        provisioning_state=__ret__.provisioning_state,
        type=__ret__.type)


@_utilities.lift_output_func(get_private_link_scoped_resource)
def get_private_link_scoped_resource_output(name: Optional[pulumi.Input[str]] = None,
                                            resource_group_name: Optional[pulumi.Input[str]] = None,
                                            scope_name: Optional[pulumi.Input[str]] = None,
                                            opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetPrivateLinkScopedResourceResult]:
    """
    A private link scoped resource
    API Version: 2019-10-17-preview.


    :param str name: The name of the scoped resource object.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    :param str scope_name: The name of the Azure Monitor PrivateLinkScope resource.
    """
    ...
