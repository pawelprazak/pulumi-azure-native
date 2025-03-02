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
    'GetResourceResult',
    'AwaitableGetResourceResult',
    'get_resource',
    'get_resource_output',
]

warnings.warn("""Version 2015-11-01 will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetResourceResult:
    """
    Resource information.
    """
    def __init__(__self__, id=None, location=None, name=None, plan=None, properties=None, tags=None, type=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if plan and not isinstance(plan, dict):
            raise TypeError("Expected argument 'plan' to be a dict")
        pulumi.set(__self__, "plan", plan)
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
        Resource Id
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def location(self) -> str:
        """
        Resource location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def plan(self) -> Optional['outputs.PlanResponse']:
        """
        Gets or sets the plan of the resource.
        """
        return pulumi.get(self, "plan")

    @property
    @pulumi.getter
    def properties(self) -> Any:
        """
        Gets or sets the resource properties.
        """
        return pulumi.get(self, "properties")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type
        """
        return pulumi.get(self, "type")


class AwaitableGetResourceResult(GetResourceResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetResourceResult(
            id=self.id,
            location=self.location,
            name=self.name,
            plan=self.plan,
            properties=self.properties,
            tags=self.tags,
            type=self.type)


def get_resource(parent_resource_path: Optional[str] = None,
                 resource_group_name: Optional[str] = None,
                 resource_name: Optional[str] = None,
                 resource_provider_namespace: Optional[str] = None,
                 resource_type: Optional[str] = None,
                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetResourceResult:
    """
    Resource information.


    :param str parent_resource_path: Resource identity.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    :param str resource_name: Resource identity.
    :param str resource_provider_namespace: Resource identity.
    :param str resource_type: Resource identity.
    """
    pulumi.log.warn("""get_resource is deprecated: Version 2015-11-01 will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['parentResourcePath'] = parent_resource_path
    __args__['resourceGroupName'] = resource_group_name
    __args__['resourceName'] = resource_name
    __args__['resourceProviderNamespace'] = resource_provider_namespace
    __args__['resourceType'] = resource_type
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:resources/v20151101:getResource', __args__, opts=opts, typ=GetResourceResult).value

    return AwaitableGetResourceResult(
        id=__ret__.id,
        location=__ret__.location,
        name=__ret__.name,
        plan=__ret__.plan,
        properties=__ret__.properties,
        tags=__ret__.tags,
        type=__ret__.type)


@_utilities.lift_output_func(get_resource)
def get_resource_output(parent_resource_path: Optional[pulumi.Input[str]] = None,
                        resource_group_name: Optional[pulumi.Input[str]] = None,
                        resource_name: Optional[pulumi.Input[str]] = None,
                        resource_provider_namespace: Optional[pulumi.Input[str]] = None,
                        resource_type: Optional[pulumi.Input[str]] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetResourceResult]:
    """
    Resource information.


    :param str parent_resource_path: Resource identity.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    :param str resource_name: Resource identity.
    :param str resource_provider_namespace: Resource identity.
    :param str resource_type: Resource identity.
    """
    pulumi.log.warn("""get_resource is deprecated: Version 2015-11-01 will be removed in v2 of the provider.""")
    ...
