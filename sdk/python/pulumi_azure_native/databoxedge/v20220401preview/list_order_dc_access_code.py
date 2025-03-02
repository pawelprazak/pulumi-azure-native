# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'ListOrderDCAccessCodeResult',
    'AwaitableListOrderDCAccessCodeResult',
    'list_order_dc_access_code',
    'list_order_dc_access_code_output',
]

@pulumi.output_type
class ListOrderDCAccessCodeResult:
    """
    DC Access code in the case of Self Managed Shipping.
    """
    def __init__(__self__, auth_code=None):
        if auth_code and not isinstance(auth_code, str):
            raise TypeError("Expected argument 'auth_code' to be a str")
        pulumi.set(__self__, "auth_code", auth_code)

    @property
    @pulumi.getter(name="authCode")
    def auth_code(self) -> Optional[str]:
        """
        DCAccess Code for the Self Managed shipment.
        """
        return pulumi.get(self, "auth_code")


class AwaitableListOrderDCAccessCodeResult(ListOrderDCAccessCodeResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return ListOrderDCAccessCodeResult(
            auth_code=self.auth_code)


def list_order_dc_access_code(device_name: Optional[str] = None,
                              resource_group_name: Optional[str] = None,
                              opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableListOrderDCAccessCodeResult:
    """
    DC Access code in the case of Self Managed Shipping.


    :param str device_name: The device name
    :param str resource_group_name: The resource group name.
    """
    __args__ = dict()
    __args__['deviceName'] = device_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:databoxedge/v20220401preview:listOrderDCAccessCode', __args__, opts=opts, typ=ListOrderDCAccessCodeResult).value

    return AwaitableListOrderDCAccessCodeResult(
        auth_code=__ret__.auth_code)


@_utilities.lift_output_func(list_order_dc_access_code)
def list_order_dc_access_code_output(device_name: Optional[pulumi.Input[str]] = None,
                                     resource_group_name: Optional[pulumi.Input[str]] = None,
                                     opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[ListOrderDCAccessCodeResult]:
    """
    DC Access code in the case of Self Managed Shipping.


    :param str device_name: The device name
    :param str resource_group_name: The resource group name.
    """
    ...
