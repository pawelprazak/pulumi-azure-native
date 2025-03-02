# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'ListCommunicationServiceKeysResult',
    'AwaitableListCommunicationServiceKeysResult',
    'list_communication_service_keys',
    'list_communication_service_keys_output',
]

@pulumi.output_type
class ListCommunicationServiceKeysResult:
    """
    A class representing the access keys of a CommunicationService.
    """
    def __init__(__self__, primary_connection_string=None, primary_key=None, secondary_connection_string=None, secondary_key=None):
        if primary_connection_string and not isinstance(primary_connection_string, str):
            raise TypeError("Expected argument 'primary_connection_string' to be a str")
        pulumi.set(__self__, "primary_connection_string", primary_connection_string)
        if primary_key and not isinstance(primary_key, str):
            raise TypeError("Expected argument 'primary_key' to be a str")
        pulumi.set(__self__, "primary_key", primary_key)
        if secondary_connection_string and not isinstance(secondary_connection_string, str):
            raise TypeError("Expected argument 'secondary_connection_string' to be a str")
        pulumi.set(__self__, "secondary_connection_string", secondary_connection_string)
        if secondary_key and not isinstance(secondary_key, str):
            raise TypeError("Expected argument 'secondary_key' to be a str")
        pulumi.set(__self__, "secondary_key", secondary_key)

    @property
    @pulumi.getter(name="primaryConnectionString")
    def primary_connection_string(self) -> Optional[str]:
        """
        CommunicationService connection string constructed via the primaryKey
        """
        return pulumi.get(self, "primary_connection_string")

    @property
    @pulumi.getter(name="primaryKey")
    def primary_key(self) -> Optional[str]:
        """
        The primary access key.
        """
        return pulumi.get(self, "primary_key")

    @property
    @pulumi.getter(name="secondaryConnectionString")
    def secondary_connection_string(self) -> Optional[str]:
        """
        CommunicationService connection string constructed via the secondaryKey
        """
        return pulumi.get(self, "secondary_connection_string")

    @property
    @pulumi.getter(name="secondaryKey")
    def secondary_key(self) -> Optional[str]:
        """
        The secondary access key.
        """
        return pulumi.get(self, "secondary_key")


class AwaitableListCommunicationServiceKeysResult(ListCommunicationServiceKeysResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return ListCommunicationServiceKeysResult(
            primary_connection_string=self.primary_connection_string,
            primary_key=self.primary_key,
            secondary_connection_string=self.secondary_connection_string,
            secondary_key=self.secondary_key)


def list_communication_service_keys(communication_service_name: Optional[str] = None,
                                    resource_group_name: Optional[str] = None,
                                    opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableListCommunicationServiceKeysResult:
    """
    A class representing the access keys of a CommunicationService.


    :param str communication_service_name: The name of the CommunicationService resource.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    """
    __args__ = dict()
    __args__['communicationServiceName'] = communication_service_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:communication/v20220701preview:listCommunicationServiceKeys', __args__, opts=opts, typ=ListCommunicationServiceKeysResult).value

    return AwaitableListCommunicationServiceKeysResult(
        primary_connection_string=__ret__.primary_connection_string,
        primary_key=__ret__.primary_key,
        secondary_connection_string=__ret__.secondary_connection_string,
        secondary_key=__ret__.secondary_key)


@_utilities.lift_output_func(list_communication_service_keys)
def list_communication_service_keys_output(communication_service_name: Optional[pulumi.Input[str]] = None,
                                           resource_group_name: Optional[pulumi.Input[str]] = None,
                                           opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[ListCommunicationServiceKeysResult]:
    """
    A class representing the access keys of a CommunicationService.


    :param str communication_service_name: The name of the CommunicationService resource.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    """
    ...
