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

__all__ = ['OrganizationArgs', 'Organization']

@pulumi.input_type
class OrganizationArgs:
    def __init__(__self__, *,
                 resource_group_name: pulumi.Input[str],
                 location: Optional[pulumi.Input[str]] = None,
                 offer_detail: Optional[pulumi.Input['OrganizationResourcePropertiesOfferDetailArgs']] = None,
                 organization_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 user_detail: Optional[pulumi.Input['OrganizationResourcePropertiesUserDetailArgs']] = None):
        """
        The set of arguments for constructing a Organization resource.
        :param pulumi.Input[str] resource_group_name: Resource group name
        :param pulumi.Input[str] location: Location of Organization resource
        :param pulumi.Input['OrganizationResourcePropertiesOfferDetailArgs'] offer_detail: Confluent offer detail
        :param pulumi.Input[str] organization_name: Organization resource name
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Organization resource tags
        :param pulumi.Input['OrganizationResourcePropertiesUserDetailArgs'] user_detail: Subscriber detail
        """
        pulumi.set(__self__, "resource_group_name", resource_group_name)
        if location is not None:
            pulumi.set(__self__, "location", location)
        if offer_detail is not None:
            pulumi.set(__self__, "offer_detail", offer_detail)
        if organization_name is not None:
            pulumi.set(__self__, "organization_name", organization_name)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if user_detail is not None:
            pulumi.set(__self__, "user_detail", user_detail)

    @property
    @pulumi.getter(name="resourceGroupName")
    def resource_group_name(self) -> pulumi.Input[str]:
        """
        Resource group name
        """
        return pulumi.get(self, "resource_group_name")

    @resource_group_name.setter
    def resource_group_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "resource_group_name", value)

    @property
    @pulumi.getter
    def location(self) -> Optional[pulumi.Input[str]]:
        """
        Location of Organization resource
        """
        return pulumi.get(self, "location")

    @location.setter
    def location(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "location", value)

    @property
    @pulumi.getter(name="offerDetail")
    def offer_detail(self) -> Optional[pulumi.Input['OrganizationResourcePropertiesOfferDetailArgs']]:
        """
        Confluent offer detail
        """
        return pulumi.get(self, "offer_detail")

    @offer_detail.setter
    def offer_detail(self, value: Optional[pulumi.Input['OrganizationResourcePropertiesOfferDetailArgs']]):
        pulumi.set(self, "offer_detail", value)

    @property
    @pulumi.getter(name="organizationName")
    def organization_name(self) -> Optional[pulumi.Input[str]]:
        """
        Organization resource name
        """
        return pulumi.get(self, "organization_name")

    @organization_name.setter
    def organization_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "organization_name", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Organization resource tags
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter(name="userDetail")
    def user_detail(self) -> Optional[pulumi.Input['OrganizationResourcePropertiesUserDetailArgs']]:
        """
        Subscriber detail
        """
        return pulumi.get(self, "user_detail")

    @user_detail.setter
    def user_detail(self, value: Optional[pulumi.Input['OrganizationResourcePropertiesUserDetailArgs']]):
        pulumi.set(self, "user_detail", value)


class Organization(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 offer_detail: Optional[pulumi.Input[pulumi.InputType['OrganizationResourcePropertiesOfferDetailArgs']]] = None,
                 organization_name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 user_detail: Optional[pulumi.Input[pulumi.InputType['OrganizationResourcePropertiesUserDetailArgs']]] = None,
                 __props__=None):
        """
        Organization resource.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] location: Location of Organization resource
        :param pulumi.Input[pulumi.InputType['OrganizationResourcePropertiesOfferDetailArgs']] offer_detail: Confluent offer detail
        :param pulumi.Input[str] organization_name: Organization resource name
        :param pulumi.Input[str] resource_group_name: Resource group name
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Organization resource tags
        :param pulumi.Input[pulumi.InputType['OrganizationResourcePropertiesUserDetailArgs']] user_detail: Subscriber detail
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: OrganizationArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Organization resource.

        :param str resource_name: The name of the resource.
        :param OrganizationArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(OrganizationArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 offer_detail: Optional[pulumi.Input[pulumi.InputType['OrganizationResourcePropertiesOfferDetailArgs']]] = None,
                 organization_name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 user_detail: Optional[pulumi.Input[pulumi.InputType['OrganizationResourcePropertiesUserDetailArgs']]] = None,
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
            __props__ = OrganizationArgs.__new__(OrganizationArgs)

            __props__.__dict__["location"] = location
            __props__.__dict__["offer_detail"] = offer_detail
            __props__.__dict__["organization_name"] = organization_name
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__.__dict__["resource_group_name"] = resource_group_name
            __props__.__dict__["tags"] = tags
            __props__.__dict__["user_detail"] = user_detail
            __props__.__dict__["created_time"] = None
            __props__.__dict__["name"] = None
            __props__.__dict__["organization_id"] = None
            __props__.__dict__["provisioning_state"] = None
            __props__.__dict__["sso_url"] = None
            __props__.__dict__["type"] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-native:confluent:Organization"), pulumi.Alias(type_="azure-native:confluent/v20200301:Organization"), pulumi.Alias(type_="azure-native:confluent/v20210301preview:Organization"), pulumi.Alias(type_="azure-native:confluent/v20210901preview:Organization"), pulumi.Alias(type_="azure-native:confluent/v20211201:Organization")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Organization, __self__).__init__(
            'azure-native:confluent/v20200301preview:Organization',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Organization':
        """
        Get an existing Organization resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = OrganizationArgs.__new__(OrganizationArgs)

        __props__.__dict__["created_time"] = None
        __props__.__dict__["location"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["offer_detail"] = None
        __props__.__dict__["organization_id"] = None
        __props__.__dict__["provisioning_state"] = None
        __props__.__dict__["sso_url"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["type"] = None
        __props__.__dict__["user_detail"] = None
        return Organization(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="createdTime")
    def created_time(self) -> pulumi.Output[str]:
        """
        The creation time of the resource.
        """
        return pulumi.get(self, "created_time")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[Optional[str]]:
        """
        Location of Organization resource
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the resource.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="offerDetail")
    def offer_detail(self) -> pulumi.Output[Optional['outputs.OrganizationResourcePropertiesResponseOfferDetail']]:
        """
        Confluent offer detail
        """
        return pulumi.get(self, "offer_detail")

    @property
    @pulumi.getter(name="organizationId")
    def organization_id(self) -> pulumi.Output[str]:
        """
        Id of the Confluent organization.
        """
        return pulumi.get(self, "organization_id")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        Provision states for confluent RP
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="ssoUrl")
    def sso_url(self) -> pulumi.Output[str]:
        """
        SSO url for the Confluent organization.
        """
        return pulumi.get(self, "sso_url")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Organization resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        The type of the resource.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="userDetail")
    def user_detail(self) -> pulumi.Output[Optional['outputs.OrganizationResourcePropertiesResponseUserDetail']]:
        """
        Subscriber detail
        """
        return pulumi.get(self, "user_detail")

