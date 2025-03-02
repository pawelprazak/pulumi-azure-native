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

__all__ = ['TemplateSpecVersionArgs', 'TemplateSpecVersion']

@pulumi.input_type
class TemplateSpecVersionArgs:
    def __init__(__self__, *,
                 resource_group_name: pulumi.Input[str],
                 template_spec_name: pulumi.Input[str],
                 artifacts: Optional[pulumi.Input[Sequence[pulumi.Input['TemplateSpecTemplateArtifactArgs']]]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 template: Optional[Any] = None,
                 template_spec_version: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a TemplateSpecVersion resource.
        :param pulumi.Input[str] resource_group_name: The name of the resource group. The name is case insensitive.
        :param pulumi.Input[str] template_spec_name: Name of the Template Spec.
        :param pulumi.Input[Sequence[pulumi.Input['TemplateSpecTemplateArtifactArgs']]] artifacts: An array of Template Spec artifacts.
        :param pulumi.Input[str] description: Template Spec version description.
        :param pulumi.Input[str] location: The location of the Template Spec Version. It must match the location of the parent Template Spec.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param Any template: The Azure Resource Manager template content.
        :param pulumi.Input[str] template_spec_version: The version of the Template Spec.
        """
        pulumi.set(__self__, "resource_group_name", resource_group_name)
        pulumi.set(__self__, "template_spec_name", template_spec_name)
        if artifacts is not None:
            pulumi.set(__self__, "artifacts", artifacts)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if location is not None:
            pulumi.set(__self__, "location", location)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if template is not None:
            pulumi.set(__self__, "template", template)
        if template_spec_version is not None:
            pulumi.set(__self__, "template_spec_version", template_spec_version)

    @property
    @pulumi.getter(name="resourceGroupName")
    def resource_group_name(self) -> pulumi.Input[str]:
        """
        The name of the resource group. The name is case insensitive.
        """
        return pulumi.get(self, "resource_group_name")

    @resource_group_name.setter
    def resource_group_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "resource_group_name", value)

    @property
    @pulumi.getter(name="templateSpecName")
    def template_spec_name(self) -> pulumi.Input[str]:
        """
        Name of the Template Spec.
        """
        return pulumi.get(self, "template_spec_name")

    @template_spec_name.setter
    def template_spec_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "template_spec_name", value)

    @property
    @pulumi.getter
    def artifacts(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['TemplateSpecTemplateArtifactArgs']]]]:
        """
        An array of Template Spec artifacts.
        """
        return pulumi.get(self, "artifacts")

    @artifacts.setter
    def artifacts(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['TemplateSpecTemplateArtifactArgs']]]]):
        pulumi.set(self, "artifacts", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Template Spec version description.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def location(self) -> Optional[pulumi.Input[str]]:
        """
        The location of the Template Spec Version. It must match the location of the parent Template Spec.
        """
        return pulumi.get(self, "location")

    @location.setter
    def location(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "location", value)

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
    @pulumi.getter
    def template(self) -> Optional[Any]:
        """
        The Azure Resource Manager template content.
        """
        return pulumi.get(self, "template")

    @template.setter
    def template(self, value: Optional[Any]):
        pulumi.set(self, "template", value)

    @property
    @pulumi.getter(name="templateSpecVersion")
    def template_spec_version(self) -> Optional[pulumi.Input[str]]:
        """
        The version of the Template Spec.
        """
        return pulumi.get(self, "template_spec_version")

    @template_spec_version.setter
    def template_spec_version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "template_spec_version", value)


class TemplateSpecVersion(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 artifacts: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TemplateSpecTemplateArtifactArgs']]]]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 template: Optional[Any] = None,
                 template_spec_name: Optional[pulumi.Input[str]] = None,
                 template_spec_version: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Template Spec Version object.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TemplateSpecTemplateArtifactArgs']]]] artifacts: An array of Template Spec artifacts.
        :param pulumi.Input[str] description: Template Spec version description.
        :param pulumi.Input[str] location: The location of the Template Spec Version. It must match the location of the parent Template Spec.
        :param pulumi.Input[str] resource_group_name: The name of the resource group. The name is case insensitive.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param Any template: The Azure Resource Manager template content.
        :param pulumi.Input[str] template_spec_name: Name of the Template Spec.
        :param pulumi.Input[str] template_spec_version: The version of the Template Spec.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: TemplateSpecVersionArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Template Spec Version object.

        :param str resource_name: The name of the resource.
        :param TemplateSpecVersionArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(TemplateSpecVersionArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 artifacts: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TemplateSpecTemplateArtifactArgs']]]]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 template: Optional[Any] = None,
                 template_spec_name: Optional[pulumi.Input[str]] = None,
                 template_spec_version: Optional[pulumi.Input[str]] = None,
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
            __props__ = TemplateSpecVersionArgs.__new__(TemplateSpecVersionArgs)

            __props__.__dict__["artifacts"] = artifacts
            __props__.__dict__["description"] = description
            __props__.__dict__["location"] = location
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__.__dict__["resource_group_name"] = resource_group_name
            __props__.__dict__["tags"] = tags
            __props__.__dict__["template"] = template
            if template_spec_name is None and not opts.urn:
                raise TypeError("Missing required property 'template_spec_name'")
            __props__.__dict__["template_spec_name"] = template_spec_name
            __props__.__dict__["template_spec_version"] = template_spec_version
            __props__.__dict__["name"] = None
            __props__.__dict__["system_data"] = None
            __props__.__dict__["type"] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-native:resources:TemplateSpecVersion"), pulumi.Alias(type_="azure-native:resources/v20210301preview:TemplateSpecVersion"), pulumi.Alias(type_="azure-native:resources/v20210501:TemplateSpecVersion"), pulumi.Alias(type_="azure-native:resources/v20220201:TemplateSpecVersion")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(TemplateSpecVersion, __self__).__init__(
            'azure-native:resources/v20190601preview:TemplateSpecVersion',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'TemplateSpecVersion':
        """
        Get an existing TemplateSpecVersion resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = TemplateSpecVersionArgs.__new__(TemplateSpecVersionArgs)

        __props__.__dict__["artifacts"] = None
        __props__.__dict__["description"] = None
        __props__.__dict__["location"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["system_data"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["template"] = None
        __props__.__dict__["type"] = None
        return TemplateSpecVersion(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def artifacts(self) -> pulumi.Output[Optional[Sequence['outputs.TemplateSpecTemplateArtifactResponse']]]:
        """
        An array of Template Spec artifacts.
        """
        return pulumi.get(self, "artifacts")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Template Spec version description.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        The location of the Template Spec Version. It must match the location of the parent Template Spec.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Name of this resource.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="systemData")
    def system_data(self) -> pulumi.Output['outputs.SystemDataResponse']:
        """
        Azure Resource Manager metadata containing createdBy and modifiedBy information.
        """
        return pulumi.get(self, "system_data")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def template(self) -> pulumi.Output[Optional[Any]]:
        """
        The Azure Resource Manager template content.
        """
        return pulumi.get(self, "template")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Type of this resource.
        """
        return pulumi.get(self, "type")

