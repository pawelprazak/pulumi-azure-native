# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'GetLabResourceResult',
    'AwaitableGetLabResourceResult',
    'get_lab_resource',
    'get_lab_resource_output',
]

warnings.warn("""Version 2015-05-21-preview will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetLabResourceResult:
    """
    A lab.
    """
    def __init__(__self__, artifacts_storage_account=None, created_date=None, default_storage_account=None, default_virtual_network_id=None, id=None, lab_storage_type=None, location=None, name=None, provisioning_state=None, storage_accounts=None, tags=None, type=None, vault_name=None):
        if artifacts_storage_account and not isinstance(artifacts_storage_account, str):
            raise TypeError("Expected argument 'artifacts_storage_account' to be a str")
        pulumi.set(__self__, "artifacts_storage_account", artifacts_storage_account)
        if created_date and not isinstance(created_date, str):
            raise TypeError("Expected argument 'created_date' to be a str")
        pulumi.set(__self__, "created_date", created_date)
        if default_storage_account and not isinstance(default_storage_account, str):
            raise TypeError("Expected argument 'default_storage_account' to be a str")
        pulumi.set(__self__, "default_storage_account", default_storage_account)
        if default_virtual_network_id and not isinstance(default_virtual_network_id, str):
            raise TypeError("Expected argument 'default_virtual_network_id' to be a str")
        pulumi.set(__self__, "default_virtual_network_id", default_virtual_network_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if lab_storage_type and not isinstance(lab_storage_type, str):
            raise TypeError("Expected argument 'lab_storage_type' to be a str")
        pulumi.set(__self__, "lab_storage_type", lab_storage_type)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if storage_accounts and not isinstance(storage_accounts, list):
            raise TypeError("Expected argument 'storage_accounts' to be a list")
        pulumi.set(__self__, "storage_accounts", storage_accounts)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if vault_name and not isinstance(vault_name, str):
            raise TypeError("Expected argument 'vault_name' to be a str")
        pulumi.set(__self__, "vault_name", vault_name)

    @property
    @pulumi.getter(name="artifactsStorageAccount")
    def artifacts_storage_account(self) -> Optional[str]:
        """
        The artifact storage account of the lab.
        """
        return pulumi.get(self, "artifacts_storage_account")

    @property
    @pulumi.getter(name="createdDate")
    def created_date(self) -> Optional[str]:
        """
        The creation date of the lab.
        """
        return pulumi.get(self, "created_date")

    @property
    @pulumi.getter(name="defaultStorageAccount")
    def default_storage_account(self) -> Optional[str]:
        """
        The lab's default storage account.
        """
        return pulumi.get(self, "default_storage_account")

    @property
    @pulumi.getter(name="defaultVirtualNetworkId")
    def default_virtual_network_id(self) -> Optional[str]:
        """
        The default virtual network identifier of the lab.
        """
        return pulumi.get(self, "default_virtual_network_id")

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        The identifier of the resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="labStorageType")
    def lab_storage_type(self) -> Optional[str]:
        """
        The type of the lab storage.
        """
        return pulumi.get(self, "lab_storage_type")

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        The location of the resource.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        The name of the resource.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> Optional[str]:
        """
        The provisioning status of the resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="storageAccounts")
    def storage_accounts(self) -> Optional[Sequence[str]]:
        """
        The storage accounts of the lab.
        """
        return pulumi.get(self, "storage_accounts")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        The tags of the resource.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        """
        The type of the resource.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="vaultName")
    def vault_name(self) -> Optional[str]:
        """
        The name of the key vault of the lab.
        """
        return pulumi.get(self, "vault_name")


class AwaitableGetLabResourceResult(GetLabResourceResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetLabResourceResult(
            artifacts_storage_account=self.artifacts_storage_account,
            created_date=self.created_date,
            default_storage_account=self.default_storage_account,
            default_virtual_network_id=self.default_virtual_network_id,
            id=self.id,
            lab_storage_type=self.lab_storage_type,
            location=self.location,
            name=self.name,
            provisioning_state=self.provisioning_state,
            storage_accounts=self.storage_accounts,
            tags=self.tags,
            type=self.type,
            vault_name=self.vault_name)


def get_lab_resource(name: Optional[str] = None,
                     resource_group_name: Optional[str] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetLabResourceResult:
    """
    A lab.


    :param str name: The name of the lab.
    :param str resource_group_name: The name of the resource group.
    """
    pulumi.log.warn("""get_lab_resource is deprecated: Version 2015-05-21-preview will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:devtestlab/v20150521preview:getLabResource', __args__, opts=opts, typ=GetLabResourceResult).value

    return AwaitableGetLabResourceResult(
        artifacts_storage_account=__ret__.artifacts_storage_account,
        created_date=__ret__.created_date,
        default_storage_account=__ret__.default_storage_account,
        default_virtual_network_id=__ret__.default_virtual_network_id,
        id=__ret__.id,
        lab_storage_type=__ret__.lab_storage_type,
        location=__ret__.location,
        name=__ret__.name,
        provisioning_state=__ret__.provisioning_state,
        storage_accounts=__ret__.storage_accounts,
        tags=__ret__.tags,
        type=__ret__.type,
        vault_name=__ret__.vault_name)


@_utilities.lift_output_func(get_lab_resource)
def get_lab_resource_output(name: Optional[pulumi.Input[str]] = None,
                            resource_group_name: Optional[pulumi.Input[str]] = None,
                            opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetLabResourceResult]:
    """
    A lab.


    :param str name: The name of the lab.
    :param str resource_group_name: The name of the resource group.
    """
    pulumi.log.warn("""get_lab_resource is deprecated: Version 2015-05-21-preview will be removed in v2 of the provider.""")
    ...
