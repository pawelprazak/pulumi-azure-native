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
    'ListVolumeReplicationsResult',
    'AwaitableListVolumeReplicationsResult',
    'list_volume_replications',
    'list_volume_replications_output',
]

@pulumi.output_type
class ListVolumeReplicationsResult:
    """
    List Replications
    """
    def __init__(__self__, value=None):
        if value and not isinstance(value, list):
            raise TypeError("Expected argument 'value' to be a list")
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def value(self) -> Optional[Sequence['outputs.ReplicationResponse']]:
        """
        A list of replications
        """
        return pulumi.get(self, "value")


class AwaitableListVolumeReplicationsResult(ListVolumeReplicationsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return ListVolumeReplicationsResult(
            value=self.value)


def list_volume_replications(account_name: Optional[str] = None,
                             pool_name: Optional[str] = None,
                             resource_group_name: Optional[str] = None,
                             volume_name: Optional[str] = None,
                             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableListVolumeReplicationsResult:
    """
    List Replications


    :param str account_name: The name of the NetApp account
    :param str pool_name: The name of the capacity pool
    :param str resource_group_name: The name of the resource group.
    :param str volume_name: The name of the volume
    """
    __args__ = dict()
    __args__['accountName'] = account_name
    __args__['poolName'] = pool_name
    __args__['resourceGroupName'] = resource_group_name
    __args__['volumeName'] = volume_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:netapp/v20220101:listVolumeReplications', __args__, opts=opts, typ=ListVolumeReplicationsResult).value

    return AwaitableListVolumeReplicationsResult(
        value=__ret__.value)


@_utilities.lift_output_func(list_volume_replications)
def list_volume_replications_output(account_name: Optional[pulumi.Input[str]] = None,
                                    pool_name: Optional[pulumi.Input[str]] = None,
                                    resource_group_name: Optional[pulumi.Input[str]] = None,
                                    volume_name: Optional[pulumi.Input[str]] = None,
                                    opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[ListVolumeReplicationsResult]:
    """
    List Replications


    :param str account_name: The name of the NetApp account
    :param str pool_name: The name of the capacity pool
    :param str resource_group_name: The name of the resource group.
    :param str volume_name: The name of the volume
    """
    ...
