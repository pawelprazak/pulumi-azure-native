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
    'GetVaultResult',
    'AwaitableGetVaultResult',
    'get_vault',
    'get_vault_output',
]

warnings.warn("""Version 2015-06-01 will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetVaultResult:
    """
    Resource information with extended details.
    """
    def __init__(__self__, id=None, location=None, name=None, properties=None, tags=None, type=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if properties and not isinstance(properties, dict):
            raise TypeError("Expected argument 'properties' to be a dict")
        pulumi.set(__self__, "properties", properties)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The Azure Resource Manager resource ID for the key vault.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def location(self) -> str:
        """
        The supported Azure location where the key vault should be created.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the key vault.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def properties(self) -> 'outputs.VaultPropertiesResponse':
        """
        Properties of the vault
        """
        return pulumi.get(self, "properties")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        The tags that will be assigned to the key vault. 
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The resource type of the key vault.
        """
        return pulumi.get(self, "type")


class AwaitableGetVaultResult(GetVaultResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetVaultResult(
            id=self.id,
            location=self.location,
            name=self.name,
            properties=self.properties,
            tags=self.tags,
            type=self.type)


def get_vault(resource_group_name: Optional[str] = None,
              vault_name: Optional[str] = None,
              opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetVaultResult:
    """
    Resource information with extended details.


    :param str resource_group_name: The name of the Resource Group to which the vault belongs.
    :param str vault_name: The name of the vault.
    """
    pulumi.log.warn("""get_vault is deprecated: Version 2015-06-01 will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['resourceGroupName'] = resource_group_name
    __args__['vaultName'] = vault_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:keyvault/v20150601:getVault', __args__, opts=opts, typ=GetVaultResult).value

    return AwaitableGetVaultResult(
        id=__ret__.id,
        location=__ret__.location,
        name=__ret__.name,
        properties=__ret__.properties,
        tags=__ret__.tags,
        type=__ret__.type)


@_utilities.lift_output_func(get_vault)
def get_vault_output(resource_group_name: Optional[pulumi.Input[str]] = None,
                     vault_name: Optional[pulumi.Input[str]] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetVaultResult]:
    """
    Resource information with extended details.


    :param str resource_group_name: The name of the Resource Group to which the vault belongs.
    :param str vault_name: The name of the vault.
    """
    pulumi.log.warn("""get_vault is deprecated: Version 2015-06-01 will be removed in v2 of the provider.""")
    ...
