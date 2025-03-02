# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from . import outputs
from ._enums import *
from ._inputs import *

__all__ = ['BlueprintArgs', 'Blueprint']

@pulumi.input_type
class BlueprintArgs:
    def __init__(__self__, *,
                 management_group_name: pulumi.Input[str],
                 target_scope: pulumi.Input[Union[str, 'BlueprintTargetScope']],
                 blueprint_name: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 layout: Optional[Any] = None,
                 parameters: Optional[pulumi.Input[Mapping[str, pulumi.Input['ParameterDefinitionArgs']]]] = None,
                 resource_groups: Optional[pulumi.Input[Mapping[str, pulumi.Input['ResourceGroupDefinitionArgs']]]] = None,
                 versions: Optional[Any] = None):
        """
        The set of arguments for constructing a Blueprint resource.
        :param pulumi.Input[str] management_group_name: ManagementGroup where blueprint stores.
        :param pulumi.Input[Union[str, 'BlueprintTargetScope']] target_scope: The scope where this Blueprint can be applied.
        :param pulumi.Input[str] blueprint_name: name of the blueprint.
        :param pulumi.Input[str] description: Multi-line explain this resource.
        :param pulumi.Input[str] display_name: One-liner string explain this resource.
        :param Any layout: Layout view of the blueprint, for UI reference.
        :param pulumi.Input[Mapping[str, pulumi.Input['ParameterDefinitionArgs']]] parameters: Parameters required by this Blueprint definition.
        :param pulumi.Input[Mapping[str, pulumi.Input['ResourceGroupDefinitionArgs']]] resource_groups: Resource group placeholders defined by this Blueprint definition.
        :param Any versions: Published versions of this blueprint.
        """
        pulumi.set(__self__, "management_group_name", management_group_name)
        pulumi.set(__self__, "target_scope", target_scope)
        if blueprint_name is not None:
            pulumi.set(__self__, "blueprint_name", blueprint_name)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if layout is not None:
            pulumi.set(__self__, "layout", layout)
        if parameters is not None:
            pulumi.set(__self__, "parameters", parameters)
        if resource_groups is not None:
            pulumi.set(__self__, "resource_groups", resource_groups)
        if versions is not None:
            pulumi.set(__self__, "versions", versions)

    @property
    @pulumi.getter(name="managementGroupName")
    def management_group_name(self) -> pulumi.Input[str]:
        """
        ManagementGroup where blueprint stores.
        """
        return pulumi.get(self, "management_group_name")

    @management_group_name.setter
    def management_group_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "management_group_name", value)

    @property
    @pulumi.getter(name="targetScope")
    def target_scope(self) -> pulumi.Input[Union[str, 'BlueprintTargetScope']]:
        """
        The scope where this Blueprint can be applied.
        """
        return pulumi.get(self, "target_scope")

    @target_scope.setter
    def target_scope(self, value: pulumi.Input[Union[str, 'BlueprintTargetScope']]):
        pulumi.set(self, "target_scope", value)

    @property
    @pulumi.getter(name="blueprintName")
    def blueprint_name(self) -> Optional[pulumi.Input[str]]:
        """
        name of the blueprint.
        """
        return pulumi.get(self, "blueprint_name")

    @blueprint_name.setter
    def blueprint_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "blueprint_name", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Multi-line explain this resource.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[pulumi.Input[str]]:
        """
        One-liner string explain this resource.
        """
        return pulumi.get(self, "display_name")

    @display_name.setter
    def display_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "display_name", value)

    @property
    @pulumi.getter
    def layout(self) -> Optional[Any]:
        """
        Layout view of the blueprint, for UI reference.
        """
        return pulumi.get(self, "layout")

    @layout.setter
    def layout(self, value: Optional[Any]):
        pulumi.set(self, "layout", value)

    @property
    @pulumi.getter
    def parameters(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input['ParameterDefinitionArgs']]]]:
        """
        Parameters required by this Blueprint definition.
        """
        return pulumi.get(self, "parameters")

    @parameters.setter
    def parameters(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input['ParameterDefinitionArgs']]]]):
        pulumi.set(self, "parameters", value)

    @property
    @pulumi.getter(name="resourceGroups")
    def resource_groups(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input['ResourceGroupDefinitionArgs']]]]:
        """
        Resource group placeholders defined by this Blueprint definition.
        """
        return pulumi.get(self, "resource_groups")

    @resource_groups.setter
    def resource_groups(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input['ResourceGroupDefinitionArgs']]]]):
        pulumi.set(self, "resource_groups", value)

    @property
    @pulumi.getter
    def versions(self) -> Optional[Any]:
        """
        Published versions of this blueprint.
        """
        return pulumi.get(self, "versions")

    @versions.setter
    def versions(self, value: Optional[Any]):
        pulumi.set(self, "versions", value)


warnings.warn("""Version 2017-11-11-preview will be removed in v2 of the provider.""", DeprecationWarning)


class Blueprint(pulumi.CustomResource):
    warnings.warn("""Version 2017-11-11-preview will be removed in v2 of the provider.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 blueprint_name: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 layout: Optional[Any] = None,
                 management_group_name: Optional[pulumi.Input[str]] = None,
                 parameters: Optional[pulumi.Input[Mapping[str, pulumi.Input[pulumi.InputType['ParameterDefinitionArgs']]]]] = None,
                 resource_groups: Optional[pulumi.Input[Mapping[str, pulumi.Input[pulumi.InputType['ResourceGroupDefinitionArgs']]]]] = None,
                 target_scope: Optional[pulumi.Input[Union[str, 'BlueprintTargetScope']]] = None,
                 versions: Optional[Any] = None,
                 __props__=None):
        """
        Represents a Blueprint definition.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] blueprint_name: name of the blueprint.
        :param pulumi.Input[str] description: Multi-line explain this resource.
        :param pulumi.Input[str] display_name: One-liner string explain this resource.
        :param Any layout: Layout view of the blueprint, for UI reference.
        :param pulumi.Input[str] management_group_name: ManagementGroup where blueprint stores.
        :param pulumi.Input[Mapping[str, pulumi.Input[pulumi.InputType['ParameterDefinitionArgs']]]] parameters: Parameters required by this Blueprint definition.
        :param pulumi.Input[Mapping[str, pulumi.Input[pulumi.InputType['ResourceGroupDefinitionArgs']]]] resource_groups: Resource group placeholders defined by this Blueprint definition.
        :param pulumi.Input[Union[str, 'BlueprintTargetScope']] target_scope: The scope where this Blueprint can be applied.
        :param Any versions: Published versions of this blueprint.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: BlueprintArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Represents a Blueprint definition.

        :param str resource_name: The name of the resource.
        :param BlueprintArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(BlueprintArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 blueprint_name: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 layout: Optional[Any] = None,
                 management_group_name: Optional[pulumi.Input[str]] = None,
                 parameters: Optional[pulumi.Input[Mapping[str, pulumi.Input[pulumi.InputType['ParameterDefinitionArgs']]]]] = None,
                 resource_groups: Optional[pulumi.Input[Mapping[str, pulumi.Input[pulumi.InputType['ResourceGroupDefinitionArgs']]]]] = None,
                 target_scope: Optional[pulumi.Input[Union[str, 'BlueprintTargetScope']]] = None,
                 versions: Optional[Any] = None,
                 __props__=None):
        pulumi.log.warn("""Blueprint is deprecated: Version 2017-11-11-preview will be removed in v2 of the provider.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = BlueprintArgs.__new__(BlueprintArgs)

            __props__.__dict__["blueprint_name"] = blueprint_name
            __props__.__dict__["description"] = description
            __props__.__dict__["display_name"] = display_name
            __props__.__dict__["layout"] = layout
            if management_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'management_group_name'")
            __props__.__dict__["management_group_name"] = management_group_name
            __props__.__dict__["parameters"] = parameters
            __props__.__dict__["resource_groups"] = resource_groups
            if target_scope is None and not opts.urn:
                raise TypeError("Missing required property 'target_scope'")
            __props__.__dict__["target_scope"] = target_scope
            __props__.__dict__["versions"] = versions
            __props__.__dict__["name"] = None
            __props__.__dict__["status"] = None
            __props__.__dict__["type"] = None
        super(Blueprint, __self__).__init__(
            'azure-native:blueprint/v20171111preview:Blueprint',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Blueprint':
        """
        Get an existing Blueprint resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = BlueprintArgs.__new__(BlueprintArgs)

        __props__.__dict__["description"] = None
        __props__.__dict__["display_name"] = None
        __props__.__dict__["layout"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["parameters"] = None
        __props__.__dict__["resource_groups"] = None
        __props__.__dict__["status"] = None
        __props__.__dict__["target_scope"] = None
        __props__.__dict__["type"] = None
        __props__.__dict__["versions"] = None
        return Blueprint(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Multi-line explain this resource.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> pulumi.Output[Optional[str]]:
        """
        One-liner string explain this resource.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def layout(self) -> pulumi.Output[Optional[Any]]:
        """
        Layout view of the blueprint, for UI reference.
        """
        return pulumi.get(self, "layout")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Name of this resource.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def parameters(self) -> pulumi.Output[Optional[Mapping[str, 'outputs.ParameterDefinitionResponse']]]:
        """
        Parameters required by this Blueprint definition.
        """
        return pulumi.get(self, "parameters")

    @property
    @pulumi.getter(name="resourceGroups")
    def resource_groups(self) -> pulumi.Output[Optional[Mapping[str, 'outputs.ResourceGroupDefinitionResponse']]]:
        """
        Resource group placeholders defined by this Blueprint definition.
        """
        return pulumi.get(self, "resource_groups")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output['outputs.BlueprintStatusResponse']:
        """
        Status of the Blueprint. This field is readonly.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="targetScope")
    def target_scope(self) -> pulumi.Output[str]:
        """
        The scope where this Blueprint can be applied.
        """
        return pulumi.get(self, "target_scope")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Type of this resource.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def versions(self) -> pulumi.Output[Optional[Any]]:
        """
        Published versions of this blueprint.
        """
        return pulumi.get(self, "versions")

