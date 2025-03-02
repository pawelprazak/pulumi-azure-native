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

__all__ = ['SiteVNETConnectionSlotArgs', 'SiteVNETConnectionSlot']

@pulumi.input_type
class SiteVNETConnectionSlotArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 resource_group_name: pulumi.Input[str],
                 slot: pulumi.Input[str],
                 cert_blob: Optional[pulumi.Input[str]] = None,
                 cert_thumbprint: Optional[pulumi.Input[str]] = None,
                 dns_servers: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 kind: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 resync_required: Optional[pulumi.Input[bool]] = None,
                 routes: Optional[pulumi.Input[Sequence[pulumi.Input['VnetRouteArgs']]]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 vnet_name: Optional[pulumi.Input[str]] = None,
                 vnet_resource_id: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a SiteVNETConnectionSlot resource.
        :param pulumi.Input[str] name: Resource Name
        :param pulumi.Input[str] resource_group_name: The resource group name
        :param pulumi.Input[str] slot: The name of the slot for this web app.
        :param pulumi.Input[str] cert_blob: A certificate file (.cer) blob containing the public key of the private key used to authenticate a 
                           Point-To-Site VPN connection.
        :param pulumi.Input[str] cert_thumbprint: The client certificate thumbprint
        :param pulumi.Input[str] dns_servers: Dns servers to be used by this VNET. This should be a comma-separated list of IP addresses.
        :param pulumi.Input[str] id: Resource Id
        :param pulumi.Input[str] kind: Kind of resource
        :param pulumi.Input[str] location: Resource Location
        :param pulumi.Input[bool] resync_required: Flag to determine if a resync is required
        :param pulumi.Input[Sequence[pulumi.Input['VnetRouteArgs']]] routes: The routes that this virtual network connection uses.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags
        :param pulumi.Input[str] type: Resource type
        :param pulumi.Input[str] vnet_name: The name of the Virtual Network
        :param pulumi.Input[str] vnet_resource_id: The vnet resource id
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "resource_group_name", resource_group_name)
        pulumi.set(__self__, "slot", slot)
        if cert_blob is not None:
            pulumi.set(__self__, "cert_blob", cert_blob)
        if cert_thumbprint is not None:
            pulumi.set(__self__, "cert_thumbprint", cert_thumbprint)
        if dns_servers is not None:
            pulumi.set(__self__, "dns_servers", dns_servers)
        if id is not None:
            pulumi.set(__self__, "id", id)
        if kind is not None:
            pulumi.set(__self__, "kind", kind)
        if location is not None:
            pulumi.set(__self__, "location", location)
        if resync_required is not None:
            pulumi.set(__self__, "resync_required", resync_required)
        if routes is not None:
            pulumi.set(__self__, "routes", routes)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if type is not None:
            pulumi.set(__self__, "type", type)
        if vnet_name is not None:
            pulumi.set(__self__, "vnet_name", vnet_name)
        if vnet_resource_id is not None:
            pulumi.set(__self__, "vnet_resource_id", vnet_resource_id)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        Resource Name
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="resourceGroupName")
    def resource_group_name(self) -> pulumi.Input[str]:
        """
        The resource group name
        """
        return pulumi.get(self, "resource_group_name")

    @resource_group_name.setter
    def resource_group_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "resource_group_name", value)

    @property
    @pulumi.getter
    def slot(self) -> pulumi.Input[str]:
        """
        The name of the slot for this web app.
        """
        return pulumi.get(self, "slot")

    @slot.setter
    def slot(self, value: pulumi.Input[str]):
        pulumi.set(self, "slot", value)

    @property
    @pulumi.getter(name="certBlob")
    def cert_blob(self) -> Optional[pulumi.Input[str]]:
        """
        A certificate file (.cer) blob containing the public key of the private key used to authenticate a 
                    Point-To-Site VPN connection.
        """
        return pulumi.get(self, "cert_blob")

    @cert_blob.setter
    def cert_blob(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cert_blob", value)

    @property
    @pulumi.getter(name="certThumbprint")
    def cert_thumbprint(self) -> Optional[pulumi.Input[str]]:
        """
        The client certificate thumbprint
        """
        return pulumi.get(self, "cert_thumbprint")

    @cert_thumbprint.setter
    def cert_thumbprint(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cert_thumbprint", value)

    @property
    @pulumi.getter(name="dnsServers")
    def dns_servers(self) -> Optional[pulumi.Input[str]]:
        """
        Dns servers to be used by this VNET. This should be a comma-separated list of IP addresses.
        """
        return pulumi.get(self, "dns_servers")

    @dns_servers.setter
    def dns_servers(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "dns_servers", value)

    @property
    @pulumi.getter
    def id(self) -> Optional[pulumi.Input[str]]:
        """
        Resource Id
        """
        return pulumi.get(self, "id")

    @id.setter
    def id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "id", value)

    @property
    @pulumi.getter
    def kind(self) -> Optional[pulumi.Input[str]]:
        """
        Kind of resource
        """
        return pulumi.get(self, "kind")

    @kind.setter
    def kind(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "kind", value)

    @property
    @pulumi.getter
    def location(self) -> Optional[pulumi.Input[str]]:
        """
        Resource Location
        """
        return pulumi.get(self, "location")

    @location.setter
    def location(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "location", value)

    @property
    @pulumi.getter(name="resyncRequired")
    def resync_required(self) -> Optional[pulumi.Input[bool]]:
        """
        Flag to determine if a resync is required
        """
        return pulumi.get(self, "resync_required")

    @resync_required.setter
    def resync_required(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "resync_required", value)

    @property
    @pulumi.getter
    def routes(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['VnetRouteArgs']]]]:
        """
        The routes that this virtual network connection uses.
        """
        return pulumi.get(self, "routes")

    @routes.setter
    def routes(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['VnetRouteArgs']]]]):
        pulumi.set(self, "routes", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter(name="vnetName")
    def vnet_name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the Virtual Network
        """
        return pulumi.get(self, "vnet_name")

    @vnet_name.setter
    def vnet_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "vnet_name", value)

    @property
    @pulumi.getter(name="vnetResourceId")
    def vnet_resource_id(self) -> Optional[pulumi.Input[str]]:
        """
        The vnet resource id
        """
        return pulumi.get(self, "vnet_resource_id")

    @vnet_resource_id.setter
    def vnet_resource_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "vnet_resource_id", value)


warnings.warn("""Version 2015-08-01 will be removed in v2 of the provider.""", DeprecationWarning)


class SiteVNETConnectionSlot(pulumi.CustomResource):
    warnings.warn("""Version 2015-08-01 will be removed in v2 of the provider.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cert_blob: Optional[pulumi.Input[str]] = None,
                 cert_thumbprint: Optional[pulumi.Input[str]] = None,
                 dns_servers: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 kind: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 resync_required: Optional[pulumi.Input[bool]] = None,
                 routes: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VnetRouteArgs']]]]] = None,
                 slot: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 vnet_name: Optional[pulumi.Input[str]] = None,
                 vnet_resource_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        VNETInfo contract. This contract is public and is a stripped down version of VNETInfoInternal

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cert_blob: A certificate file (.cer) blob containing the public key of the private key used to authenticate a 
                           Point-To-Site VPN connection.
        :param pulumi.Input[str] cert_thumbprint: The client certificate thumbprint
        :param pulumi.Input[str] dns_servers: Dns servers to be used by this VNET. This should be a comma-separated list of IP addresses.
        :param pulumi.Input[str] id: Resource Id
        :param pulumi.Input[str] kind: Kind of resource
        :param pulumi.Input[str] location: Resource Location
        :param pulumi.Input[str] name: Resource Name
        :param pulumi.Input[str] resource_group_name: The resource group name
        :param pulumi.Input[bool] resync_required: Flag to determine if a resync is required
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VnetRouteArgs']]]] routes: The routes that this virtual network connection uses.
        :param pulumi.Input[str] slot: The name of the slot for this web app.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags
        :param pulumi.Input[str] type: Resource type
        :param pulumi.Input[str] vnet_name: The name of the Virtual Network
        :param pulumi.Input[str] vnet_resource_id: The vnet resource id
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: SiteVNETConnectionSlotArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        VNETInfo contract. This contract is public and is a stripped down version of VNETInfoInternal

        :param str resource_name: The name of the resource.
        :param SiteVNETConnectionSlotArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(SiteVNETConnectionSlotArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cert_blob: Optional[pulumi.Input[str]] = None,
                 cert_thumbprint: Optional[pulumi.Input[str]] = None,
                 dns_servers: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 kind: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 resync_required: Optional[pulumi.Input[bool]] = None,
                 routes: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['VnetRouteArgs']]]]] = None,
                 slot: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 vnet_name: Optional[pulumi.Input[str]] = None,
                 vnet_resource_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        pulumi.log.warn("""SiteVNETConnectionSlot is deprecated: Version 2015-08-01 will be removed in v2 of the provider.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = SiteVNETConnectionSlotArgs.__new__(SiteVNETConnectionSlotArgs)

            __props__.__dict__["cert_blob"] = cert_blob
            __props__.__dict__["cert_thumbprint"] = cert_thumbprint
            __props__.__dict__["dns_servers"] = dns_servers
            __props__.__dict__["id"] = id
            __props__.__dict__["kind"] = kind
            __props__.__dict__["location"] = location
            if name is None and not opts.urn:
                raise TypeError("Missing required property 'name'")
            __props__.__dict__["name"] = name
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__.__dict__["resource_group_name"] = resource_group_name
            __props__.__dict__["resync_required"] = resync_required
            __props__.__dict__["routes"] = routes
            if slot is None and not opts.urn:
                raise TypeError("Missing required property 'slot'")
            __props__.__dict__["slot"] = slot
            __props__.__dict__["tags"] = tags
            __props__.__dict__["type"] = type
            __props__.__dict__["vnet_name"] = vnet_name
            __props__.__dict__["vnet_resource_id"] = vnet_resource_id
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-native:web:SiteVNETConnectionSlot"), pulumi.Alias(type_="azure-native:web/v20160801:SiteVNETConnectionSlot"), pulumi.Alias(type_="azure-native:web/v20180201:SiteVNETConnectionSlot"), pulumi.Alias(type_="azure-native:web/v20181101:SiteVNETConnectionSlot"), pulumi.Alias(type_="azure-native:web/v20190801:SiteVNETConnectionSlot"), pulumi.Alias(type_="azure-native:web/v20200601:SiteVNETConnectionSlot"), pulumi.Alias(type_="azure-native:web/v20200901:SiteVNETConnectionSlot"), pulumi.Alias(type_="azure-native:web/v20201001:SiteVNETConnectionSlot"), pulumi.Alias(type_="azure-native:web/v20201201:SiteVNETConnectionSlot"), pulumi.Alias(type_="azure-native:web/v20210101:SiteVNETConnectionSlot"), pulumi.Alias(type_="azure-native:web/v20210115:SiteVNETConnectionSlot"), pulumi.Alias(type_="azure-native:web/v20210201:SiteVNETConnectionSlot"), pulumi.Alias(type_="azure-native:web/v20210301:SiteVNETConnectionSlot"), pulumi.Alias(type_="azure-native:web/v20220301:SiteVNETConnectionSlot")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(SiteVNETConnectionSlot, __self__).__init__(
            'azure-native:web/v20150801:SiteVNETConnectionSlot',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'SiteVNETConnectionSlot':
        """
        Get an existing SiteVNETConnectionSlot resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = SiteVNETConnectionSlotArgs.__new__(SiteVNETConnectionSlotArgs)

        __props__.__dict__["cert_blob"] = None
        __props__.__dict__["cert_thumbprint"] = None
        __props__.__dict__["dns_servers"] = None
        __props__.__dict__["kind"] = None
        __props__.__dict__["location"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["resync_required"] = None
        __props__.__dict__["routes"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["type"] = None
        __props__.__dict__["vnet_resource_id"] = None
        return SiteVNETConnectionSlot(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="certBlob")
    def cert_blob(self) -> pulumi.Output[Optional[str]]:
        """
        A certificate file (.cer) blob containing the public key of the private key used to authenticate a 
                    Point-To-Site VPN connection.
        """
        return pulumi.get(self, "cert_blob")

    @property
    @pulumi.getter(name="certThumbprint")
    def cert_thumbprint(self) -> pulumi.Output[Optional[str]]:
        """
        The client certificate thumbprint
        """
        return pulumi.get(self, "cert_thumbprint")

    @property
    @pulumi.getter(name="dnsServers")
    def dns_servers(self) -> pulumi.Output[Optional[str]]:
        """
        Dns servers to be used by this VNET. This should be a comma-separated list of IP addresses.
        """
        return pulumi.get(self, "dns_servers")

    @property
    @pulumi.getter
    def kind(self) -> pulumi.Output[Optional[str]]:
        """
        Kind of resource
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Resource Location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[Optional[str]]:
        """
        Resource Name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="resyncRequired")
    def resync_required(self) -> pulumi.Output[Optional[bool]]:
        """
        Flag to determine if a resync is required
        """
        return pulumi.get(self, "resync_required")

    @property
    @pulumi.getter
    def routes(self) -> pulumi.Output[Optional[Sequence['outputs.VnetRouteResponse']]]:
        """
        The routes that this virtual network connection uses.
        """
        return pulumi.get(self, "routes")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[Optional[str]]:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="vnetResourceId")
    def vnet_resource_id(self) -> pulumi.Output[Optional[str]]:
        """
        The vnet resource id
        """
        return pulumi.get(self, "vnet_resource_id")

