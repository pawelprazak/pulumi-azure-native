# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'GetSiteHostNameBindingSlotResult',
    'AwaitableGetSiteHostNameBindingSlotResult',
    'get_site_host_name_binding_slot',
    'get_site_host_name_binding_slot_output',
]

warnings.warn("""Version 2015-08-01 will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetSiteHostNameBindingSlotResult:
    """
    A host name binding object
    """
    def __init__(__self__, azure_resource_name=None, azure_resource_type=None, custom_host_name_dns_record_type=None, domain_id=None, host_name_type=None, id=None, kind=None, location=None, name=None, site_name=None, tags=None, type=None):
        if azure_resource_name and not isinstance(azure_resource_name, str):
            raise TypeError("Expected argument 'azure_resource_name' to be a str")
        pulumi.set(__self__, "azure_resource_name", azure_resource_name)
        if azure_resource_type and not isinstance(azure_resource_type, str):
            raise TypeError("Expected argument 'azure_resource_type' to be a str")
        pulumi.set(__self__, "azure_resource_type", azure_resource_type)
        if custom_host_name_dns_record_type and not isinstance(custom_host_name_dns_record_type, str):
            raise TypeError("Expected argument 'custom_host_name_dns_record_type' to be a str")
        pulumi.set(__self__, "custom_host_name_dns_record_type", custom_host_name_dns_record_type)
        if domain_id and not isinstance(domain_id, str):
            raise TypeError("Expected argument 'domain_id' to be a str")
        pulumi.set(__self__, "domain_id", domain_id)
        if host_name_type and not isinstance(host_name_type, str):
            raise TypeError("Expected argument 'host_name_type' to be a str")
        pulumi.set(__self__, "host_name_type", host_name_type)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if kind and not isinstance(kind, str):
            raise TypeError("Expected argument 'kind' to be a str")
        pulumi.set(__self__, "kind", kind)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if site_name and not isinstance(site_name, str):
            raise TypeError("Expected argument 'site_name' to be a str")
        pulumi.set(__self__, "site_name", site_name)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="azureResourceName")
    def azure_resource_name(self) -> Optional[str]:
        """
        Azure resource name
        """
        return pulumi.get(self, "azure_resource_name")

    @property
    @pulumi.getter(name="azureResourceType")
    def azure_resource_type(self) -> Optional[str]:
        """
        Azure resource type
        """
        return pulumi.get(self, "azure_resource_type")

    @property
    @pulumi.getter(name="customHostNameDnsRecordType")
    def custom_host_name_dns_record_type(self) -> Optional[str]:
        """
        Custom DNS record type
        """
        return pulumi.get(self, "custom_host_name_dns_record_type")

    @property
    @pulumi.getter(name="domainId")
    def domain_id(self) -> Optional[str]:
        """
        Fully qualified ARM domain resource URI
        """
        return pulumi.get(self, "domain_id")

    @property
    @pulumi.getter(name="hostNameType")
    def host_name_type(self) -> Optional[str]:
        """
        Host name type
        """
        return pulumi.get(self, "host_name_type")

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        Resource Id
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def kind(self) -> Optional[str]:
        """
        Kind of resource
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def location(self) -> str:
        """
        Resource Location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Resource Name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="siteName")
    def site_name(self) -> Optional[str]:
        """
        Web app name
        """
        return pulumi.get(self, "site_name")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        """
        Resource type
        """
        return pulumi.get(self, "type")


class AwaitableGetSiteHostNameBindingSlotResult(GetSiteHostNameBindingSlotResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSiteHostNameBindingSlotResult(
            azure_resource_name=self.azure_resource_name,
            azure_resource_type=self.azure_resource_type,
            custom_host_name_dns_record_type=self.custom_host_name_dns_record_type,
            domain_id=self.domain_id,
            host_name_type=self.host_name_type,
            id=self.id,
            kind=self.kind,
            location=self.location,
            name=self.name,
            site_name=self.site_name,
            tags=self.tags,
            type=self.type)


def get_site_host_name_binding_slot(host_name: Optional[str] = None,
                                    name: Optional[str] = None,
                                    resource_group_name: Optional[str] = None,
                                    slot: Optional[str] = None,
                                    opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetSiteHostNameBindingSlotResult:
    """
    A host name binding object


    :param str host_name: Name of host
    :param str name: Name of web app
    :param str resource_group_name: Name of resource group
    :param str slot: Name of web app slot. If not specified then will default to production slot.
    """
    pulumi.log.warn("""get_site_host_name_binding_slot is deprecated: Version 2015-08-01 will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['hostName'] = host_name
    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    __args__['slot'] = slot
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:web/v20150801:getSiteHostNameBindingSlot', __args__, opts=opts, typ=GetSiteHostNameBindingSlotResult).value

    return AwaitableGetSiteHostNameBindingSlotResult(
        azure_resource_name=__ret__.azure_resource_name,
        azure_resource_type=__ret__.azure_resource_type,
        custom_host_name_dns_record_type=__ret__.custom_host_name_dns_record_type,
        domain_id=__ret__.domain_id,
        host_name_type=__ret__.host_name_type,
        id=__ret__.id,
        kind=__ret__.kind,
        location=__ret__.location,
        name=__ret__.name,
        site_name=__ret__.site_name,
        tags=__ret__.tags,
        type=__ret__.type)


@_utilities.lift_output_func(get_site_host_name_binding_slot)
def get_site_host_name_binding_slot_output(host_name: Optional[pulumi.Input[str]] = None,
                                           name: Optional[pulumi.Input[str]] = None,
                                           resource_group_name: Optional[pulumi.Input[str]] = None,
                                           slot: Optional[pulumi.Input[str]] = None,
                                           opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetSiteHostNameBindingSlotResult]:
    """
    A host name binding object


    :param str host_name: Name of host
    :param str name: Name of web app
    :param str resource_group_name: Name of resource group
    :param str slot: Name of web app slot. If not specified then will default to production slot.
    """
    pulumi.log.warn("""get_site_host_name_binding_slot is deprecated: Version 2015-08-01 will be removed in v2 of the provider.""")
    ...
