# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'GetSecurityConnectorApplicationResult',
    'AwaitableGetSecurityConnectorApplicationResult',
    'get_security_connector_application',
    'get_security_connector_application_output',
]

@pulumi.output_type
class GetSecurityConnectorApplicationResult:
    """
    Security Application over a given scope
    """
    def __init__(__self__, description=None, display_name=None, id=None, name=None, source_resource_type=None, type=None):
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if display_name and not isinstance(display_name, str):
            raise TypeError("Expected argument 'display_name' to be a str")
        pulumi.set(__self__, "display_name", display_name)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if source_resource_type and not isinstance(source_resource_type, str):
            raise TypeError("Expected argument 'source_resource_type' to be a str")
        pulumi.set(__self__, "source_resource_type", source_resource_type)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        """
        description of the application
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[str]:
        """
        display name of the application
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Resource Id
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="sourceResourceType")
    def source_resource_type(self) -> str:
        """
        The application source, what it affects, e.g. Assessments
        """
        return pulumi.get(self, "source_resource_type")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type
        """
        return pulumi.get(self, "type")


class AwaitableGetSecurityConnectorApplicationResult(GetSecurityConnectorApplicationResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSecurityConnectorApplicationResult(
            description=self.description,
            display_name=self.display_name,
            id=self.id,
            name=self.name,
            source_resource_type=self.source_resource_type,
            type=self.type)


def get_security_connector_application(application_id: Optional[str] = None,
                                       resource_group_name: Optional[str] = None,
                                       security_connector_name: Optional[str] = None,
                                       opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetSecurityConnectorApplicationResult:
    """
    Security Application over a given scope


    :param str application_id: The security Application key - unique key for the standard application
    :param str resource_group_name: The name of the resource group within the user's subscription. The name is case insensitive.
    :param str security_connector_name: The security connector name.
    """
    __args__ = dict()
    __args__['applicationId'] = application_id
    __args__['resourceGroupName'] = resource_group_name
    __args__['securityConnectorName'] = security_connector_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:security/v20220701preview:getSecurityConnectorApplication', __args__, opts=opts, typ=GetSecurityConnectorApplicationResult).value

    return AwaitableGetSecurityConnectorApplicationResult(
        description=__ret__.description,
        display_name=__ret__.display_name,
        id=__ret__.id,
        name=__ret__.name,
        source_resource_type=__ret__.source_resource_type,
        type=__ret__.type)


@_utilities.lift_output_func(get_security_connector_application)
def get_security_connector_application_output(application_id: Optional[pulumi.Input[str]] = None,
                                              resource_group_name: Optional[pulumi.Input[str]] = None,
                                              security_connector_name: Optional[pulumi.Input[str]] = None,
                                              opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetSecurityConnectorApplicationResult]:
    """
    Security Application over a given scope


    :param str application_id: The security Application key - unique key for the standard application
    :param str resource_group_name: The name of the resource group within the user's subscription. The name is case insensitive.
    :param str security_connector_name: The security connector name.
    """
    ...
