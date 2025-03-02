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
    'GetStorageDomainResult',
    'AwaitableGetStorageDomainResult',
    'get_storage_domain',
    'get_storage_domain_output',
]

warnings.warn("""Version 2016-10-01 will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetStorageDomainResult:
    """
    The storage domain.
    """
    def __init__(__self__, encryption_key=None, encryption_status=None, id=None, name=None, storage_account_credential_ids=None, type=None):
        if encryption_key and not isinstance(encryption_key, dict):
            raise TypeError("Expected argument 'encryption_key' to be a dict")
        pulumi.set(__self__, "encryption_key", encryption_key)
        if encryption_status and not isinstance(encryption_status, str):
            raise TypeError("Expected argument 'encryption_status' to be a str")
        pulumi.set(__self__, "encryption_status", encryption_status)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if storage_account_credential_ids and not isinstance(storage_account_credential_ids, list):
            raise TypeError("Expected argument 'storage_account_credential_ids' to be a list")
        pulumi.set(__self__, "storage_account_credential_ids", storage_account_credential_ids)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="encryptionKey")
    def encryption_key(self) -> Optional['outputs.AsymmetricEncryptedSecretResponse']:
        """
        The encryption key used to encrypt the data. This is a user secret.
        """
        return pulumi.get(self, "encryption_key")

    @property
    @pulumi.getter(name="encryptionStatus")
    def encryption_status(self) -> str:
        """
        The encryption status "Enabled | Disabled".
        """
        return pulumi.get(self, "encryption_status")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The identifier.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="storageAccountCredentialIds")
    def storage_account_credential_ids(self) -> Sequence[str]:
        """
        The storage account credentials.
        """
        return pulumi.get(self, "storage_account_credential_ids")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type.
        """
        return pulumi.get(self, "type")


class AwaitableGetStorageDomainResult(GetStorageDomainResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetStorageDomainResult(
            encryption_key=self.encryption_key,
            encryption_status=self.encryption_status,
            id=self.id,
            name=self.name,
            storage_account_credential_ids=self.storage_account_credential_ids,
            type=self.type)


def get_storage_domain(manager_name: Optional[str] = None,
                       resource_group_name: Optional[str] = None,
                       storage_domain_name: Optional[str] = None,
                       opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetStorageDomainResult:
    """
    The storage domain.


    :param str manager_name: The manager name
    :param str resource_group_name: The resource group name
    :param str storage_domain_name: The storage domain name.
    """
    pulumi.log.warn("""get_storage_domain is deprecated: Version 2016-10-01 will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['managerName'] = manager_name
    __args__['resourceGroupName'] = resource_group_name
    __args__['storageDomainName'] = storage_domain_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:storsimple/v20161001:getStorageDomain', __args__, opts=opts, typ=GetStorageDomainResult).value

    return AwaitableGetStorageDomainResult(
        encryption_key=__ret__.encryption_key,
        encryption_status=__ret__.encryption_status,
        id=__ret__.id,
        name=__ret__.name,
        storage_account_credential_ids=__ret__.storage_account_credential_ids,
        type=__ret__.type)


@_utilities.lift_output_func(get_storage_domain)
def get_storage_domain_output(manager_name: Optional[pulumi.Input[str]] = None,
                              resource_group_name: Optional[pulumi.Input[str]] = None,
                              storage_domain_name: Optional[pulumi.Input[str]] = None,
                              opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetStorageDomainResult]:
    """
    The storage domain.


    :param str manager_name: The manager name
    :param str resource_group_name: The resource group name
    :param str storage_domain_name: The storage domain name.
    """
    pulumi.log.warn("""get_storage_domain is deprecated: Version 2016-10-01 will be removed in v2 of the provider.""")
    ...
