# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = ['OriginArgs', 'Origin']

@pulumi.input_type
class OriginArgs:
    def __init__(__self__, *,
                 endpoint_name: pulumi.Input[str],
                 host_name: pulumi.Input[str],
                 profile_name: pulumi.Input[str],
                 resource_group_name: pulumi.Input[str],
                 http_port: Optional[pulumi.Input[int]] = None,
                 https_port: Optional[pulumi.Input[int]] = None,
                 origin_name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Origin resource.
        :param pulumi.Input[str] endpoint_name: Name of the endpoint within the CDN profile.
        :param pulumi.Input[str] host_name: The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.
        :param pulumi.Input[str] profile_name: Name of the CDN profile within the resource group.
        :param pulumi.Input[str] resource_group_name: Name of the resource group within the Azure subscription.
        :param pulumi.Input[int] http_port: The value of the HTTP port. Must be between 1 and 65535.
        :param pulumi.Input[int] https_port: The value of the HTTPS port. Must be between 1 and 65535.
        :param pulumi.Input[str] origin_name: Name of the origin, an arbitrary value but it needs to be unique under endpoint
        """
        pulumi.set(__self__, "endpoint_name", endpoint_name)
        pulumi.set(__self__, "host_name", host_name)
        pulumi.set(__self__, "profile_name", profile_name)
        pulumi.set(__self__, "resource_group_name", resource_group_name)
        if http_port is not None:
            pulumi.set(__self__, "http_port", http_port)
        if https_port is not None:
            pulumi.set(__self__, "https_port", https_port)
        if origin_name is not None:
            pulumi.set(__self__, "origin_name", origin_name)

    @property
    @pulumi.getter(name="endpointName")
    def endpoint_name(self) -> pulumi.Input[str]:
        """
        Name of the endpoint within the CDN profile.
        """
        return pulumi.get(self, "endpoint_name")

    @endpoint_name.setter
    def endpoint_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "endpoint_name", value)

    @property
    @pulumi.getter(name="hostName")
    def host_name(self) -> pulumi.Input[str]:
        """
        The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.
        """
        return pulumi.get(self, "host_name")

    @host_name.setter
    def host_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "host_name", value)

    @property
    @pulumi.getter(name="profileName")
    def profile_name(self) -> pulumi.Input[str]:
        """
        Name of the CDN profile within the resource group.
        """
        return pulumi.get(self, "profile_name")

    @profile_name.setter
    def profile_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "profile_name", value)

    @property
    @pulumi.getter(name="resourceGroupName")
    def resource_group_name(self) -> pulumi.Input[str]:
        """
        Name of the resource group within the Azure subscription.
        """
        return pulumi.get(self, "resource_group_name")

    @resource_group_name.setter
    def resource_group_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "resource_group_name", value)

    @property
    @pulumi.getter(name="httpPort")
    def http_port(self) -> Optional[pulumi.Input[int]]:
        """
        The value of the HTTP port. Must be between 1 and 65535.
        """
        return pulumi.get(self, "http_port")

    @http_port.setter
    def http_port(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "http_port", value)

    @property
    @pulumi.getter(name="httpsPort")
    def https_port(self) -> Optional[pulumi.Input[int]]:
        """
        The value of the HTTPS port. Must be between 1 and 65535.
        """
        return pulumi.get(self, "https_port")

    @https_port.setter
    def https_port(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "https_port", value)

    @property
    @pulumi.getter(name="originName")
    def origin_name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the origin, an arbitrary value but it needs to be unique under endpoint
        """
        return pulumi.get(self, "origin_name")

    @origin_name.setter
    def origin_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "origin_name", value)


warnings.warn("""Version 2016-04-02 will be removed in v2 of the provider.""", DeprecationWarning)


class Origin(pulumi.CustomResource):
    warnings.warn("""Version 2016-04-02 will be removed in v2 of the provider.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 endpoint_name: Optional[pulumi.Input[str]] = None,
                 host_name: Optional[pulumi.Input[str]] = None,
                 http_port: Optional[pulumi.Input[int]] = None,
                 https_port: Optional[pulumi.Input[int]] = None,
                 origin_name: Optional[pulumi.Input[str]] = None,
                 profile_name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        CDN origin is the source of the content being delivered via CDN. When the edge nodes represented by an endpoint do not have the requested content cached, they attempt to fetch it from one or more of the configured origins.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] endpoint_name: Name of the endpoint within the CDN profile.
        :param pulumi.Input[str] host_name: The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.
        :param pulumi.Input[int] http_port: The value of the HTTP port. Must be between 1 and 65535.
        :param pulumi.Input[int] https_port: The value of the HTTPS port. Must be between 1 and 65535.
        :param pulumi.Input[str] origin_name: Name of the origin, an arbitrary value but it needs to be unique under endpoint
        :param pulumi.Input[str] profile_name: Name of the CDN profile within the resource group.
        :param pulumi.Input[str] resource_group_name: Name of the resource group within the Azure subscription.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: OriginArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        CDN origin is the source of the content being delivered via CDN. When the edge nodes represented by an endpoint do not have the requested content cached, they attempt to fetch it from one or more of the configured origins.

        :param str resource_name: The name of the resource.
        :param OriginArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(OriginArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 endpoint_name: Optional[pulumi.Input[str]] = None,
                 host_name: Optional[pulumi.Input[str]] = None,
                 http_port: Optional[pulumi.Input[int]] = None,
                 https_port: Optional[pulumi.Input[int]] = None,
                 origin_name: Optional[pulumi.Input[str]] = None,
                 profile_name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        pulumi.log.warn("""Origin is deprecated: Version 2016-04-02 will be removed in v2 of the provider.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = OriginArgs.__new__(OriginArgs)

            if endpoint_name is None and not opts.urn:
                raise TypeError("Missing required property 'endpoint_name'")
            __props__.__dict__["endpoint_name"] = endpoint_name
            if host_name is None and not opts.urn:
                raise TypeError("Missing required property 'host_name'")
            __props__.__dict__["host_name"] = host_name
            __props__.__dict__["http_port"] = http_port
            __props__.__dict__["https_port"] = https_port
            __props__.__dict__["origin_name"] = origin_name
            if profile_name is None and not opts.urn:
                raise TypeError("Missing required property 'profile_name'")
            __props__.__dict__["profile_name"] = profile_name
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__.__dict__["resource_group_name"] = resource_group_name
            __props__.__dict__["name"] = None
            __props__.__dict__["provisioning_state"] = None
            __props__.__dict__["resource_state"] = None
            __props__.__dict__["type"] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-native:cdn:Origin"), pulumi.Alias(type_="azure-native:cdn/v20150601:Origin"), pulumi.Alias(type_="azure-native:cdn/v20191231:Origin"), pulumi.Alias(type_="azure-native:cdn/v20200331:Origin"), pulumi.Alias(type_="azure-native:cdn/v20200415:Origin"), pulumi.Alias(type_="azure-native:cdn/v20200901:Origin"), pulumi.Alias(type_="azure-native:cdn/v20210601:Origin")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Origin, __self__).__init__(
            'azure-native:cdn/v20160402:Origin',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Origin':
        """
        Get an existing Origin resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = OriginArgs.__new__(OriginArgs)

        __props__.__dict__["host_name"] = None
        __props__.__dict__["http_port"] = None
        __props__.__dict__["https_port"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["provisioning_state"] = None
        __props__.__dict__["resource_state"] = None
        __props__.__dict__["type"] = None
        return Origin(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="hostName")
    def host_name(self) -> pulumi.Output[str]:
        """
        The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.
        """
        return pulumi.get(self, "host_name")

    @property
    @pulumi.getter(name="httpPort")
    def http_port(self) -> pulumi.Output[Optional[int]]:
        """
        The value of the HTTP port. Must be between 1 and 65535.
        """
        return pulumi.get(self, "http_port")

    @property
    @pulumi.getter(name="httpsPort")
    def https_port(self) -> pulumi.Output[Optional[int]]:
        """
        The value of the https port. Must be between 1 and 65535.
        """
        return pulumi.get(self, "https_port")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        Provisioning status of the origin.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="resourceState")
    def resource_state(self) -> pulumi.Output[str]:
        """
        Resource status of the origin.
        """
        return pulumi.get(self, "resource_state")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type
        """
        return pulumi.get(self, "type")

