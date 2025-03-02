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
    'GetReplicationProtectionContainerMappingResult',
    'AwaitableGetReplicationProtectionContainerMappingResult',
    'get_replication_protection_container_mapping',
    'get_replication_protection_container_mapping_output',
]

warnings.warn("""Version 2016-08-10 will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetReplicationProtectionContainerMappingResult:
    """
    Protection container mapping object.
    """
    def __init__(__self__, id=None, location=None, name=None, properties=None, type=None):
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
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Resource Id
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        Resource Location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource Name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def properties(self) -> 'outputs.ProtectionContainerMappingPropertiesResponse':
        """
        The custom data.
        """
        return pulumi.get(self, "properties")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource Type
        """
        return pulumi.get(self, "type")


class AwaitableGetReplicationProtectionContainerMappingResult(GetReplicationProtectionContainerMappingResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetReplicationProtectionContainerMappingResult(
            id=self.id,
            location=self.location,
            name=self.name,
            properties=self.properties,
            type=self.type)


def get_replication_protection_container_mapping(fabric_name: Optional[str] = None,
                                                 mapping_name: Optional[str] = None,
                                                 protection_container_name: Optional[str] = None,
                                                 resource_group_name: Optional[str] = None,
                                                 resource_name: Optional[str] = None,
                                                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetReplicationProtectionContainerMappingResult:
    """
    Protection container mapping object.


    :param str fabric_name: Fabric name.
    :param str mapping_name: Protection Container mapping name.
    :param str protection_container_name: Protection container name.
    :param str resource_group_name: The name of the resource group where the recovery services vault is present.
    :param str resource_name: The name of the recovery services vault.
    """
    pulumi.log.warn("""get_replication_protection_container_mapping is deprecated: Version 2016-08-10 will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['fabricName'] = fabric_name
    __args__['mappingName'] = mapping_name
    __args__['protectionContainerName'] = protection_container_name
    __args__['resourceGroupName'] = resource_group_name
    __args__['resourceName'] = resource_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:recoveryservices/v20160810:getReplicationProtectionContainerMapping', __args__, opts=opts, typ=GetReplicationProtectionContainerMappingResult).value

    return AwaitableGetReplicationProtectionContainerMappingResult(
        id=__ret__.id,
        location=__ret__.location,
        name=__ret__.name,
        properties=__ret__.properties,
        type=__ret__.type)


@_utilities.lift_output_func(get_replication_protection_container_mapping)
def get_replication_protection_container_mapping_output(fabric_name: Optional[pulumi.Input[str]] = None,
                                                        mapping_name: Optional[pulumi.Input[str]] = None,
                                                        protection_container_name: Optional[pulumi.Input[str]] = None,
                                                        resource_group_name: Optional[pulumi.Input[str]] = None,
                                                        resource_name: Optional[pulumi.Input[str]] = None,
                                                        opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetReplicationProtectionContainerMappingResult]:
    """
    Protection container mapping object.


    :param str fabric_name: Fabric name.
    :param str mapping_name: Protection Container mapping name.
    :param str protection_container_name: Protection container name.
    :param str resource_group_name: The name of the resource group where the recovery services vault is present.
    :param str resource_name: The name of the recovery services vault.
    """
    pulumi.log.warn("""get_replication_protection_container_mapping is deprecated: Version 2016-08-10 will be removed in v2 of the provider.""")
    ...
