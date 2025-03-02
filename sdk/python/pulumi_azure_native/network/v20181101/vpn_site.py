# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from . import outputs
from ._inputs import *

__all__ = ['VpnSiteArgs', 'VpnSite']

@pulumi.input_type
class VpnSiteArgs:
    def __init__(__self__, *,
                 resource_group_name: pulumi.Input[str],
                 address_space: Optional[pulumi.Input['AddressSpaceArgs']] = None,
                 bgp_properties: Optional[pulumi.Input['BgpSettingsArgs']] = None,
                 device_properties: Optional[pulumi.Input['DevicePropertiesArgs']] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 ip_address: Optional[pulumi.Input[str]] = None,
                 is_security_site: Optional[pulumi.Input[bool]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 site_key: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 virtual_wan: Optional[pulumi.Input['SubResourceArgs']] = None,
                 vpn_site_name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a VpnSite resource.
        :param pulumi.Input[str] resource_group_name: The resource group name of the VpnSite.
        :param pulumi.Input['AddressSpaceArgs'] address_space: The AddressSpace that contains an array of IP address ranges.
        :param pulumi.Input['BgpSettingsArgs'] bgp_properties: The set of bgp properties.
        :param pulumi.Input['DevicePropertiesArgs'] device_properties: The device properties
        :param pulumi.Input[str] id: Resource ID.
        :param pulumi.Input[str] ip_address: The ip-address for the vpn-site.
        :param pulumi.Input[bool] is_security_site: IsSecuritySite flag
        :param pulumi.Input[str] location: Resource location.
        :param pulumi.Input[str] site_key: The key for vpn-site that can be used for connections.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input['SubResourceArgs'] virtual_wan: The VirtualWAN to which the vpnSite belongs
        :param pulumi.Input[str] vpn_site_name: The name of the VpnSite being created or updated.
        """
        pulumi.set(__self__, "resource_group_name", resource_group_name)
        if address_space is not None:
            pulumi.set(__self__, "address_space", address_space)
        if bgp_properties is not None:
            pulumi.set(__self__, "bgp_properties", bgp_properties)
        if device_properties is not None:
            pulumi.set(__self__, "device_properties", device_properties)
        if id is not None:
            pulumi.set(__self__, "id", id)
        if ip_address is not None:
            pulumi.set(__self__, "ip_address", ip_address)
        if is_security_site is not None:
            pulumi.set(__self__, "is_security_site", is_security_site)
        if location is not None:
            pulumi.set(__self__, "location", location)
        if site_key is not None:
            pulumi.set(__self__, "site_key", site_key)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if virtual_wan is not None:
            pulumi.set(__self__, "virtual_wan", virtual_wan)
        if vpn_site_name is not None:
            pulumi.set(__self__, "vpn_site_name", vpn_site_name)

    @property
    @pulumi.getter(name="resourceGroupName")
    def resource_group_name(self) -> pulumi.Input[str]:
        """
        The resource group name of the VpnSite.
        """
        return pulumi.get(self, "resource_group_name")

    @resource_group_name.setter
    def resource_group_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "resource_group_name", value)

    @property
    @pulumi.getter(name="addressSpace")
    def address_space(self) -> Optional[pulumi.Input['AddressSpaceArgs']]:
        """
        The AddressSpace that contains an array of IP address ranges.
        """
        return pulumi.get(self, "address_space")

    @address_space.setter
    def address_space(self, value: Optional[pulumi.Input['AddressSpaceArgs']]):
        pulumi.set(self, "address_space", value)

    @property
    @pulumi.getter(name="bgpProperties")
    def bgp_properties(self) -> Optional[pulumi.Input['BgpSettingsArgs']]:
        """
        The set of bgp properties.
        """
        return pulumi.get(self, "bgp_properties")

    @bgp_properties.setter
    def bgp_properties(self, value: Optional[pulumi.Input['BgpSettingsArgs']]):
        pulumi.set(self, "bgp_properties", value)

    @property
    @pulumi.getter(name="deviceProperties")
    def device_properties(self) -> Optional[pulumi.Input['DevicePropertiesArgs']]:
        """
        The device properties
        """
        return pulumi.get(self, "device_properties")

    @device_properties.setter
    def device_properties(self, value: Optional[pulumi.Input['DevicePropertiesArgs']]):
        pulumi.set(self, "device_properties", value)

    @property
    @pulumi.getter
    def id(self) -> Optional[pulumi.Input[str]]:
        """
        Resource ID.
        """
        return pulumi.get(self, "id")

    @id.setter
    def id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "id", value)

    @property
    @pulumi.getter(name="ipAddress")
    def ip_address(self) -> Optional[pulumi.Input[str]]:
        """
        The ip-address for the vpn-site.
        """
        return pulumi.get(self, "ip_address")

    @ip_address.setter
    def ip_address(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ip_address", value)

    @property
    @pulumi.getter(name="isSecuritySite")
    def is_security_site(self) -> Optional[pulumi.Input[bool]]:
        """
        IsSecuritySite flag
        """
        return pulumi.get(self, "is_security_site")

    @is_security_site.setter
    def is_security_site(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "is_security_site", value)

    @property
    @pulumi.getter
    def location(self) -> Optional[pulumi.Input[str]]:
        """
        Resource location.
        """
        return pulumi.get(self, "location")

    @location.setter
    def location(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "location", value)

    @property
    @pulumi.getter(name="siteKey")
    def site_key(self) -> Optional[pulumi.Input[str]]:
        """
        The key for vpn-site that can be used for connections.
        """
        return pulumi.get(self, "site_key")

    @site_key.setter
    def site_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "site_key", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter(name="virtualWan")
    def virtual_wan(self) -> Optional[pulumi.Input['SubResourceArgs']]:
        """
        The VirtualWAN to which the vpnSite belongs
        """
        return pulumi.get(self, "virtual_wan")

    @virtual_wan.setter
    def virtual_wan(self, value: Optional[pulumi.Input['SubResourceArgs']]):
        pulumi.set(self, "virtual_wan", value)

    @property
    @pulumi.getter(name="vpnSiteName")
    def vpn_site_name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the VpnSite being created or updated.
        """
        return pulumi.get(self, "vpn_site_name")

    @vpn_site_name.setter
    def vpn_site_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "vpn_site_name", value)


class VpnSite(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 address_space: Optional[pulumi.Input[pulumi.InputType['AddressSpaceArgs']]] = None,
                 bgp_properties: Optional[pulumi.Input[pulumi.InputType['BgpSettingsArgs']]] = None,
                 device_properties: Optional[pulumi.Input[pulumi.InputType['DevicePropertiesArgs']]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 ip_address: Optional[pulumi.Input[str]] = None,
                 is_security_site: Optional[pulumi.Input[bool]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 site_key: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 virtual_wan: Optional[pulumi.Input[pulumi.InputType['SubResourceArgs']]] = None,
                 vpn_site_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        VpnSite Resource.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['AddressSpaceArgs']] address_space: The AddressSpace that contains an array of IP address ranges.
        :param pulumi.Input[pulumi.InputType['BgpSettingsArgs']] bgp_properties: The set of bgp properties.
        :param pulumi.Input[pulumi.InputType['DevicePropertiesArgs']] device_properties: The device properties
        :param pulumi.Input[str] id: Resource ID.
        :param pulumi.Input[str] ip_address: The ip-address for the vpn-site.
        :param pulumi.Input[bool] is_security_site: IsSecuritySite flag
        :param pulumi.Input[str] location: Resource location.
        :param pulumi.Input[str] resource_group_name: The resource group name of the VpnSite.
        :param pulumi.Input[str] site_key: The key for vpn-site that can be used for connections.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[pulumi.InputType['SubResourceArgs']] virtual_wan: The VirtualWAN to which the vpnSite belongs
        :param pulumi.Input[str] vpn_site_name: The name of the VpnSite being created or updated.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: VpnSiteArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        VpnSite Resource.

        :param str resource_name: The name of the resource.
        :param VpnSiteArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(VpnSiteArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 address_space: Optional[pulumi.Input[pulumi.InputType['AddressSpaceArgs']]] = None,
                 bgp_properties: Optional[pulumi.Input[pulumi.InputType['BgpSettingsArgs']]] = None,
                 device_properties: Optional[pulumi.Input[pulumi.InputType['DevicePropertiesArgs']]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 ip_address: Optional[pulumi.Input[str]] = None,
                 is_security_site: Optional[pulumi.Input[bool]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 site_key: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 virtual_wan: Optional[pulumi.Input[pulumi.InputType['SubResourceArgs']]] = None,
                 vpn_site_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = VpnSiteArgs.__new__(VpnSiteArgs)

            __props__.__dict__["address_space"] = address_space
            __props__.__dict__["bgp_properties"] = bgp_properties
            __props__.__dict__["device_properties"] = device_properties
            __props__.__dict__["id"] = id
            __props__.__dict__["ip_address"] = ip_address
            __props__.__dict__["is_security_site"] = is_security_site
            __props__.__dict__["location"] = location
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__.__dict__["resource_group_name"] = resource_group_name
            __props__.__dict__["site_key"] = site_key
            __props__.__dict__["tags"] = tags
            __props__.__dict__["virtual_wan"] = virtual_wan
            __props__.__dict__["vpn_site_name"] = vpn_site_name
            __props__.__dict__["etag"] = None
            __props__.__dict__["name"] = None
            __props__.__dict__["provisioning_state"] = None
            __props__.__dict__["type"] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-native:network:VpnSite"), pulumi.Alias(type_="azure-native:network/v20180401:VpnSite"), pulumi.Alias(type_="azure-native:network/v20180601:VpnSite"), pulumi.Alias(type_="azure-native:network/v20180701:VpnSite"), pulumi.Alias(type_="azure-native:network/v20180801:VpnSite"), pulumi.Alias(type_="azure-native:network/v20181001:VpnSite"), pulumi.Alias(type_="azure-native:network/v20181201:VpnSite"), pulumi.Alias(type_="azure-native:network/v20190201:VpnSite"), pulumi.Alias(type_="azure-native:network/v20190401:VpnSite"), pulumi.Alias(type_="azure-native:network/v20190601:VpnSite"), pulumi.Alias(type_="azure-native:network/v20190701:VpnSite"), pulumi.Alias(type_="azure-native:network/v20190801:VpnSite"), pulumi.Alias(type_="azure-native:network/v20190901:VpnSite"), pulumi.Alias(type_="azure-native:network/v20191101:VpnSite"), pulumi.Alias(type_="azure-native:network/v20191201:VpnSite"), pulumi.Alias(type_="azure-native:network/v20200301:VpnSite"), pulumi.Alias(type_="azure-native:network/v20200401:VpnSite"), pulumi.Alias(type_="azure-native:network/v20200501:VpnSite"), pulumi.Alias(type_="azure-native:network/v20200601:VpnSite"), pulumi.Alias(type_="azure-native:network/v20200701:VpnSite"), pulumi.Alias(type_="azure-native:network/v20200801:VpnSite"), pulumi.Alias(type_="azure-native:network/v20201101:VpnSite"), pulumi.Alias(type_="azure-native:network/v20210201:VpnSite"), pulumi.Alias(type_="azure-native:network/v20210301:VpnSite"), pulumi.Alias(type_="azure-native:network/v20210501:VpnSite"), pulumi.Alias(type_="azure-native:network/v20210801:VpnSite"), pulumi.Alias(type_="azure-native:network/v20220101:VpnSite")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(VpnSite, __self__).__init__(
            'azure-native:network/v20181101:VpnSite',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'VpnSite':
        """
        Get an existing VpnSite resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = VpnSiteArgs.__new__(VpnSiteArgs)

        __props__.__dict__["address_space"] = None
        __props__.__dict__["bgp_properties"] = None
        __props__.__dict__["device_properties"] = None
        __props__.__dict__["etag"] = None
        __props__.__dict__["ip_address"] = None
        __props__.__dict__["is_security_site"] = None
        __props__.__dict__["location"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["provisioning_state"] = None
        __props__.__dict__["site_key"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["type"] = None
        __props__.__dict__["virtual_wan"] = None
        return VpnSite(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="addressSpace")
    def address_space(self) -> pulumi.Output[Optional['outputs.AddressSpaceResponse']]:
        """
        The AddressSpace that contains an array of IP address ranges.
        """
        return pulumi.get(self, "address_space")

    @property
    @pulumi.getter(name="bgpProperties")
    def bgp_properties(self) -> pulumi.Output[Optional['outputs.BgpSettingsResponse']]:
        """
        The set of bgp properties.
        """
        return pulumi.get(self, "bgp_properties")

    @property
    @pulumi.getter(name="deviceProperties")
    def device_properties(self) -> pulumi.Output[Optional['outputs.DevicePropertiesResponse']]:
        """
        The device properties
        """
        return pulumi.get(self, "device_properties")

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[str]:
        """
        Gets a unique read-only string that changes whenever the resource is updated.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter(name="ipAddress")
    def ip_address(self) -> pulumi.Output[Optional[str]]:
        """
        The ip-address for the vpn-site.
        """
        return pulumi.get(self, "ip_address")

    @property
    @pulumi.getter(name="isSecuritySite")
    def is_security_site(self) -> pulumi.Output[Optional[bool]]:
        """
        IsSecuritySite flag
        """
        return pulumi.get(self, "is_security_site")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Resource location.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        The provisioning state of the resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="siteKey")
    def site_key(self) -> pulumi.Output[Optional[str]]:
        """
        The key for vpn-site that can be used for connections.
        """
        return pulumi.get(self, "site_key")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="virtualWan")
    def virtual_wan(self) -> pulumi.Output[Optional['outputs.SubResourceResponse']]:
        """
        The VirtualWAN to which the vpnSite belongs
        """
        return pulumi.get(self, "virtual_wan")

