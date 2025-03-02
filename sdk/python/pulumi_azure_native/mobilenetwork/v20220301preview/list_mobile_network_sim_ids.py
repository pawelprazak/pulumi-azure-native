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
    'ListMobileNetworkSimIdsResult',
    'AwaitableListMobileNetworkSimIdsResult',
    'list_mobile_network_sim_ids',
    'list_mobile_network_sim_ids_output',
]

@pulumi.output_type
class ListMobileNetworkSimIdsResult:
    """
    Response for list sim ids API service call.
    """
    def __init__(__self__, next_link=None, value=None):
        if next_link and not isinstance(next_link, str):
            raise TypeError("Expected argument 'next_link' to be a str")
        pulumi.set(__self__, "next_link", next_link)
        if value and not isinstance(value, list):
            raise TypeError("Expected argument 'value' to be a list")
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter(name="nextLink")
    def next_link(self) -> str:
        """
        The URL to get the next set of results.
        """
        return pulumi.get(self, "next_link")

    @property
    @pulumi.getter
    def value(self) -> Optional[Sequence['outputs.SubResourceResponse']]:
        """
        A list of sim profile ids in a resource group.
        """
        return pulumi.get(self, "value")


class AwaitableListMobileNetworkSimIdsResult(ListMobileNetworkSimIdsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return ListMobileNetworkSimIdsResult(
            next_link=self.next_link,
            value=self.value)


def list_mobile_network_sim_ids(mobile_network_name: Optional[str] = None,
                                resource_group_name: Optional[str] = None,
                                opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableListMobileNetworkSimIdsResult:
    """
    Response for list sim ids API service call.


    :param str mobile_network_name: The name of the mobile network.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    """
    __args__ = dict()
    __args__['mobileNetworkName'] = mobile_network_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:mobilenetwork/v20220301preview:listMobileNetworkSimIds', __args__, opts=opts, typ=ListMobileNetworkSimIdsResult).value

    return AwaitableListMobileNetworkSimIdsResult(
        next_link=__ret__.next_link,
        value=__ret__.value)


@_utilities.lift_output_func(list_mobile_network_sim_ids)
def list_mobile_network_sim_ids_output(mobile_network_name: Optional[pulumi.Input[str]] = None,
                                       resource_group_name: Optional[pulumi.Input[str]] = None,
                                       opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[ListMobileNetworkSimIdsResult]:
    """
    Response for list sim ids API service call.


    :param str mobile_network_name: The name of the mobile network.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    """
    ...
