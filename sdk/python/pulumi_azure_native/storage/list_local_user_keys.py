# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs

__all__ = [
    'ListLocalUserKeysResult',
    'AwaitableListLocalUserKeysResult',
    'list_local_user_keys',
    'list_local_user_keys_output',
]

@pulumi.output_type
class ListLocalUserKeysResult:
    """
    The Storage Account Local User keys.
    """
    def __init__(__self__, shared_key=None, ssh_authorized_keys=None):
        if shared_key and not isinstance(shared_key, str):
            raise TypeError("Expected argument 'shared_key' to be a str")
        pulumi.set(__self__, "shared_key", shared_key)
        if ssh_authorized_keys and not isinstance(ssh_authorized_keys, list):
            raise TypeError("Expected argument 'ssh_authorized_keys' to be a list")
        pulumi.set(__self__, "ssh_authorized_keys", ssh_authorized_keys)

    @property
    @pulumi.getter(name="sharedKey")
    def shared_key(self) -> str:
        """
        Auto generated by the server for SMB authentication.
        """
        return pulumi.get(self, "shared_key")

    @property
    @pulumi.getter(name="sshAuthorizedKeys")
    def ssh_authorized_keys(self) -> Optional[Sequence['outputs.SshPublicKeyResponse']]:
        """
        Optional, local user ssh authorized keys for SFTP.
        """
        return pulumi.get(self, "ssh_authorized_keys")


class AwaitableListLocalUserKeysResult(ListLocalUserKeysResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return ListLocalUserKeysResult(
            shared_key=self.shared_key,
            ssh_authorized_keys=self.ssh_authorized_keys)


def list_local_user_keys(account_name: Optional[str] = None,
                         resource_group_name: Optional[str] = None,
                         username: Optional[str] = None,
                         opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableListLocalUserKeysResult:
    """
    The Storage Account Local User keys.
    API Version: 2021-08-01.


    :param str account_name: The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
    :param str resource_group_name: The name of the resource group within the user's subscription. The name is case insensitive.
    :param str username: The name of local user. The username must contain lowercase letters and numbers only. It must be unique only within the storage account.
    """
    __args__ = dict()
    __args__['accountName'] = account_name
    __args__['resourceGroupName'] = resource_group_name
    __args__['username'] = username
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:storage:listLocalUserKeys', __args__, opts=opts, typ=ListLocalUserKeysResult).value

    return AwaitableListLocalUserKeysResult(
        shared_key=__ret__.shared_key,
        ssh_authorized_keys=__ret__.ssh_authorized_keys)


@_utilities.lift_output_func(list_local_user_keys)
def list_local_user_keys_output(account_name: Optional[pulumi.Input[str]] = None,
                                resource_group_name: Optional[pulumi.Input[str]] = None,
                                username: Optional[pulumi.Input[str]] = None,
                                opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[ListLocalUserKeysResult]:
    """
    The Storage Account Local User keys.
    API Version: 2021-08-01.


    :param str account_name: The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
    :param str resource_group_name: The name of the resource group within the user's subscription. The name is case insensitive.
    :param str username: The name of local user. The username must contain lowercase letters and numbers only. It must be unique only within the storage account.
    """
    ...
