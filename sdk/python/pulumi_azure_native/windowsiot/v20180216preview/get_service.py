# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'GetServiceResult',
    'AwaitableGetServiceResult',
    'get_service',
    'get_service_output',
]

warnings.warn("""Version 2018-02-16-preview will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetServiceResult:
    """
    The description of the Windows IoT Device Service.
    """
    def __init__(__self__, admin_domain_name=None, billing_domain_name=None, etag=None, id=None, location=None, name=None, notes=None, quantity=None, start_date=None, tags=None, type=None):
        if admin_domain_name and not isinstance(admin_domain_name, str):
            raise TypeError("Expected argument 'admin_domain_name' to be a str")
        pulumi.set(__self__, "admin_domain_name", admin_domain_name)
        if billing_domain_name and not isinstance(billing_domain_name, str):
            raise TypeError("Expected argument 'billing_domain_name' to be a str")
        pulumi.set(__self__, "billing_domain_name", billing_domain_name)
        if etag and not isinstance(etag, str):
            raise TypeError("Expected argument 'etag' to be a str")
        pulumi.set(__self__, "etag", etag)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if notes and not isinstance(notes, str):
            raise TypeError("Expected argument 'notes' to be a str")
        pulumi.set(__self__, "notes", notes)
        if quantity and not isinstance(quantity, float):
            raise TypeError("Expected argument 'quantity' to be a float")
        pulumi.set(__self__, "quantity", quantity)
        if start_date and not isinstance(start_date, str):
            raise TypeError("Expected argument 'start_date' to be a str")
        pulumi.set(__self__, "start_date", start_date)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="adminDomainName")
    def admin_domain_name(self) -> Optional[str]:
        """
        Windows IoT Device Service OEM AAD domain
        """
        return pulumi.get(self, "admin_domain_name")

    @property
    @pulumi.getter(name="billingDomainName")
    def billing_domain_name(self) -> str:
        """
        Windows IoT Device Service ODM AAD domain
        """
        return pulumi.get(self, "billing_domain_name")

    @property
    @pulumi.getter
    def etag(self) -> Optional[str]:
        """
        The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Fully qualified resource Id for the resource
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        The Azure Region where the resource lives
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def notes(self) -> Optional[str]:
        """
        Windows IoT Device Service notes.
        """
        return pulumi.get(self, "notes")

    @property
    @pulumi.getter
    def quantity(self) -> Optional[float]:
        """
        Windows IoT Device Service device allocation,
        """
        return pulumi.get(self, "quantity")

    @property
    @pulumi.getter(name="startDate")
    def start_date(self) -> str:
        """
        Windows IoT Device Service start date,
        """
        return pulumi.get(self, "start_date")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource.
        """
        return pulumi.get(self, "type")


class AwaitableGetServiceResult(GetServiceResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetServiceResult(
            admin_domain_name=self.admin_domain_name,
            billing_domain_name=self.billing_domain_name,
            etag=self.etag,
            id=self.id,
            location=self.location,
            name=self.name,
            notes=self.notes,
            quantity=self.quantity,
            start_date=self.start_date,
            tags=self.tags,
            type=self.type)


def get_service(device_name: Optional[str] = None,
                resource_group_name: Optional[str] = None,
                opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetServiceResult:
    """
    The description of the Windows IoT Device Service.


    :param str device_name: The name of the Windows IoT Device Service.
    :param str resource_group_name: The name of the resource group that contains the Windows IoT Device Service.
    """
    pulumi.log.warn("""get_service is deprecated: Version 2018-02-16-preview will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['deviceName'] = device_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:windowsiot/v20180216preview:getService', __args__, opts=opts, typ=GetServiceResult).value

    return AwaitableGetServiceResult(
        admin_domain_name=__ret__.admin_domain_name,
        billing_domain_name=__ret__.billing_domain_name,
        etag=__ret__.etag,
        id=__ret__.id,
        location=__ret__.location,
        name=__ret__.name,
        notes=__ret__.notes,
        quantity=__ret__.quantity,
        start_date=__ret__.start_date,
        tags=__ret__.tags,
        type=__ret__.type)


@_utilities.lift_output_func(get_service)
def get_service_output(device_name: Optional[pulumi.Input[str]] = None,
                       resource_group_name: Optional[pulumi.Input[str]] = None,
                       opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetServiceResult]:
    """
    The description of the Windows IoT Device Service.


    :param str device_name: The name of the Windows IoT Device Service.
    :param str resource_group_name: The name of the resource group that contains the Windows IoT Device Service.
    """
    pulumi.log.warn("""get_service is deprecated: Version 2018-02-16-preview will be removed in v2 of the provider.""")
    ...
