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

__all__ = ['HostPoolArgs', 'HostPool']

@pulumi.input_type
class HostPoolArgs:
    def __init__(__self__, *,
                 host_pool_type: pulumi.Input[Union[str, 'HostPoolType']],
                 load_balancer_type: pulumi.Input[Union[str, 'LoadBalancerType']],
                 preferred_app_group_type: pulumi.Input[Union[str, 'PreferredAppGroupType']],
                 resource_group_name: pulumi.Input[str],
                 custom_rdp_property: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 friendly_name: Optional[pulumi.Input[str]] = None,
                 host_pool_name: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 max_session_limit: Optional[pulumi.Input[int]] = None,
                 personal_desktop_assignment_type: Optional[pulumi.Input[Union[str, 'PersonalDesktopAssignmentType']]] = None,
                 registration_info: Optional[pulumi.Input['RegistrationInfoArgs']] = None,
                 ring: Optional[pulumi.Input[int]] = None,
                 sso_client_id: Optional[pulumi.Input[str]] = None,
                 sso_client_secret_key_vault_path: Optional[pulumi.Input[str]] = None,
                 sso_context: Optional[pulumi.Input[str]] = None,
                 sso_secret_type: Optional[pulumi.Input[Union[str, 'SSOSecretType']]] = None,
                 ssoadfs_authority: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 validation_environment: Optional[pulumi.Input[bool]] = None,
                 vm_template: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a HostPool resource.
        :param pulumi.Input[Union[str, 'HostPoolType']] host_pool_type: HostPool type for desktop.
        :param pulumi.Input[Union[str, 'LoadBalancerType']] load_balancer_type: The type of the load balancer.
        :param pulumi.Input[Union[str, 'PreferredAppGroupType']] preferred_app_group_type: The type of preferred application group type, default to Desktop Application Group
        :param pulumi.Input[str] resource_group_name: The name of the resource group. The name is case insensitive.
        :param pulumi.Input[str] custom_rdp_property: Custom rdp property of HostPool.
        :param pulumi.Input[str] description: Description of HostPool.
        :param pulumi.Input[str] friendly_name: Friendly name of HostPool.
        :param pulumi.Input[str] host_pool_name: The name of the host pool within the specified resource group
        :param pulumi.Input[str] location: The geo-location where the resource lives
        :param pulumi.Input[int] max_session_limit: The max session limit of HostPool.
        :param pulumi.Input[Union[str, 'PersonalDesktopAssignmentType']] personal_desktop_assignment_type: PersonalDesktopAssignment type for HostPool.
        :param pulumi.Input['RegistrationInfoArgs'] registration_info: The registration info of HostPool.
        :param pulumi.Input[int] ring: The ring number of HostPool.
        :param pulumi.Input[str] sso_client_id: ClientId for the registered Relying Party used to issue WVD SSO certificates.
        :param pulumi.Input[str] sso_client_secret_key_vault_path: Path to Azure KeyVault storing the secret used for communication to ADFS.
        :param pulumi.Input[str] sso_context: Path to keyvault containing ssoContext secret.
        :param pulumi.Input[Union[str, 'SSOSecretType']] sso_secret_type: The type of single sign on Secret Type.
        :param pulumi.Input[str] ssoadfs_authority: URL to customer ADFS server for signing WVD SSO certificates.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[bool] validation_environment: Is validation environment.
        :param pulumi.Input[str] vm_template: VM template for sessionhosts configuration within hostpool.
        """
        pulumi.set(__self__, "host_pool_type", host_pool_type)
        pulumi.set(__self__, "load_balancer_type", load_balancer_type)
        pulumi.set(__self__, "preferred_app_group_type", preferred_app_group_type)
        pulumi.set(__self__, "resource_group_name", resource_group_name)
        if custom_rdp_property is not None:
            pulumi.set(__self__, "custom_rdp_property", custom_rdp_property)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if friendly_name is not None:
            pulumi.set(__self__, "friendly_name", friendly_name)
        if host_pool_name is not None:
            pulumi.set(__self__, "host_pool_name", host_pool_name)
        if location is not None:
            pulumi.set(__self__, "location", location)
        if max_session_limit is not None:
            pulumi.set(__self__, "max_session_limit", max_session_limit)
        if personal_desktop_assignment_type is not None:
            pulumi.set(__self__, "personal_desktop_assignment_type", personal_desktop_assignment_type)
        if registration_info is not None:
            pulumi.set(__self__, "registration_info", registration_info)
        if ring is not None:
            pulumi.set(__self__, "ring", ring)
        if sso_client_id is not None:
            pulumi.set(__self__, "sso_client_id", sso_client_id)
        if sso_client_secret_key_vault_path is not None:
            pulumi.set(__self__, "sso_client_secret_key_vault_path", sso_client_secret_key_vault_path)
        if sso_context is not None:
            pulumi.set(__self__, "sso_context", sso_context)
        if sso_secret_type is not None:
            pulumi.set(__self__, "sso_secret_type", sso_secret_type)
        if ssoadfs_authority is not None:
            pulumi.set(__self__, "ssoadfs_authority", ssoadfs_authority)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if validation_environment is not None:
            pulumi.set(__self__, "validation_environment", validation_environment)
        if vm_template is not None:
            pulumi.set(__self__, "vm_template", vm_template)

    @property
    @pulumi.getter(name="hostPoolType")
    def host_pool_type(self) -> pulumi.Input[Union[str, 'HostPoolType']]:
        """
        HostPool type for desktop.
        """
        return pulumi.get(self, "host_pool_type")

    @host_pool_type.setter
    def host_pool_type(self, value: pulumi.Input[Union[str, 'HostPoolType']]):
        pulumi.set(self, "host_pool_type", value)

    @property
    @pulumi.getter(name="loadBalancerType")
    def load_balancer_type(self) -> pulumi.Input[Union[str, 'LoadBalancerType']]:
        """
        The type of the load balancer.
        """
        return pulumi.get(self, "load_balancer_type")

    @load_balancer_type.setter
    def load_balancer_type(self, value: pulumi.Input[Union[str, 'LoadBalancerType']]):
        pulumi.set(self, "load_balancer_type", value)

    @property
    @pulumi.getter(name="preferredAppGroupType")
    def preferred_app_group_type(self) -> pulumi.Input[Union[str, 'PreferredAppGroupType']]:
        """
        The type of preferred application group type, default to Desktop Application Group
        """
        return pulumi.get(self, "preferred_app_group_type")

    @preferred_app_group_type.setter
    def preferred_app_group_type(self, value: pulumi.Input[Union[str, 'PreferredAppGroupType']]):
        pulumi.set(self, "preferred_app_group_type", value)

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
    @pulumi.getter(name="customRdpProperty")
    def custom_rdp_property(self) -> Optional[pulumi.Input[str]]:
        """
        Custom rdp property of HostPool.
        """
        return pulumi.get(self, "custom_rdp_property")

    @custom_rdp_property.setter
    def custom_rdp_property(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "custom_rdp_property", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of HostPool.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="friendlyName")
    def friendly_name(self) -> Optional[pulumi.Input[str]]:
        """
        Friendly name of HostPool.
        """
        return pulumi.get(self, "friendly_name")

    @friendly_name.setter
    def friendly_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "friendly_name", value)

    @property
    @pulumi.getter(name="hostPoolName")
    def host_pool_name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the host pool within the specified resource group
        """
        return pulumi.get(self, "host_pool_name")

    @host_pool_name.setter
    def host_pool_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "host_pool_name", value)

    @property
    @pulumi.getter
    def location(self) -> Optional[pulumi.Input[str]]:
        """
        The geo-location where the resource lives
        """
        return pulumi.get(self, "location")

    @location.setter
    def location(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "location", value)

    @property
    @pulumi.getter(name="maxSessionLimit")
    def max_session_limit(self) -> Optional[pulumi.Input[int]]:
        """
        The max session limit of HostPool.
        """
        return pulumi.get(self, "max_session_limit")

    @max_session_limit.setter
    def max_session_limit(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "max_session_limit", value)

    @property
    @pulumi.getter(name="personalDesktopAssignmentType")
    def personal_desktop_assignment_type(self) -> Optional[pulumi.Input[Union[str, 'PersonalDesktopAssignmentType']]]:
        """
        PersonalDesktopAssignment type for HostPool.
        """
        return pulumi.get(self, "personal_desktop_assignment_type")

    @personal_desktop_assignment_type.setter
    def personal_desktop_assignment_type(self, value: Optional[pulumi.Input[Union[str, 'PersonalDesktopAssignmentType']]]):
        pulumi.set(self, "personal_desktop_assignment_type", value)

    @property
    @pulumi.getter(name="registrationInfo")
    def registration_info(self) -> Optional[pulumi.Input['RegistrationInfoArgs']]:
        """
        The registration info of HostPool.
        """
        return pulumi.get(self, "registration_info")

    @registration_info.setter
    def registration_info(self, value: Optional[pulumi.Input['RegistrationInfoArgs']]):
        pulumi.set(self, "registration_info", value)

    @property
    @pulumi.getter
    def ring(self) -> Optional[pulumi.Input[int]]:
        """
        The ring number of HostPool.
        """
        return pulumi.get(self, "ring")

    @ring.setter
    def ring(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "ring", value)

    @property
    @pulumi.getter(name="ssoClientId")
    def sso_client_id(self) -> Optional[pulumi.Input[str]]:
        """
        ClientId for the registered Relying Party used to issue WVD SSO certificates.
        """
        return pulumi.get(self, "sso_client_id")

    @sso_client_id.setter
    def sso_client_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "sso_client_id", value)

    @property
    @pulumi.getter(name="ssoClientSecretKeyVaultPath")
    def sso_client_secret_key_vault_path(self) -> Optional[pulumi.Input[str]]:
        """
        Path to Azure KeyVault storing the secret used for communication to ADFS.
        """
        return pulumi.get(self, "sso_client_secret_key_vault_path")

    @sso_client_secret_key_vault_path.setter
    def sso_client_secret_key_vault_path(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "sso_client_secret_key_vault_path", value)

    @property
    @pulumi.getter(name="ssoContext")
    def sso_context(self) -> Optional[pulumi.Input[str]]:
        """
        Path to keyvault containing ssoContext secret.
        """
        return pulumi.get(self, "sso_context")

    @sso_context.setter
    def sso_context(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "sso_context", value)

    @property
    @pulumi.getter(name="ssoSecretType")
    def sso_secret_type(self) -> Optional[pulumi.Input[Union[str, 'SSOSecretType']]]:
        """
        The type of single sign on Secret Type.
        """
        return pulumi.get(self, "sso_secret_type")

    @sso_secret_type.setter
    def sso_secret_type(self, value: Optional[pulumi.Input[Union[str, 'SSOSecretType']]]):
        pulumi.set(self, "sso_secret_type", value)

    @property
    @pulumi.getter(name="ssoadfsAuthority")
    def ssoadfs_authority(self) -> Optional[pulumi.Input[str]]:
        """
        URL to customer ADFS server for signing WVD SSO certificates.
        """
        return pulumi.get(self, "ssoadfs_authority")

    @ssoadfs_authority.setter
    def ssoadfs_authority(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ssoadfs_authority", value)

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
    @pulumi.getter(name="validationEnvironment")
    def validation_environment(self) -> Optional[pulumi.Input[bool]]:
        """
        Is validation environment.
        """
        return pulumi.get(self, "validation_environment")

    @validation_environment.setter
    def validation_environment(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "validation_environment", value)

    @property
    @pulumi.getter(name="vmTemplate")
    def vm_template(self) -> Optional[pulumi.Input[str]]:
        """
        VM template for sessionhosts configuration within hostpool.
        """
        return pulumi.get(self, "vm_template")

    @vm_template.setter
    def vm_template(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "vm_template", value)


warnings.warn("""Version 2020-10-19-preview will be removed in v2 of the provider.""", DeprecationWarning)


class HostPool(pulumi.CustomResource):
    warnings.warn("""Version 2020-10-19-preview will be removed in v2 of the provider.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 custom_rdp_property: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 friendly_name: Optional[pulumi.Input[str]] = None,
                 host_pool_name: Optional[pulumi.Input[str]] = None,
                 host_pool_type: Optional[pulumi.Input[Union[str, 'HostPoolType']]] = None,
                 load_balancer_type: Optional[pulumi.Input[Union[str, 'LoadBalancerType']]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 max_session_limit: Optional[pulumi.Input[int]] = None,
                 personal_desktop_assignment_type: Optional[pulumi.Input[Union[str, 'PersonalDesktopAssignmentType']]] = None,
                 preferred_app_group_type: Optional[pulumi.Input[Union[str, 'PreferredAppGroupType']]] = None,
                 registration_info: Optional[pulumi.Input[pulumi.InputType['RegistrationInfoArgs']]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 ring: Optional[pulumi.Input[int]] = None,
                 sso_client_id: Optional[pulumi.Input[str]] = None,
                 sso_client_secret_key_vault_path: Optional[pulumi.Input[str]] = None,
                 sso_context: Optional[pulumi.Input[str]] = None,
                 sso_secret_type: Optional[pulumi.Input[Union[str, 'SSOSecretType']]] = None,
                 ssoadfs_authority: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 validation_environment: Optional[pulumi.Input[bool]] = None,
                 vm_template: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Represents a HostPool definition.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] custom_rdp_property: Custom rdp property of HostPool.
        :param pulumi.Input[str] description: Description of HostPool.
        :param pulumi.Input[str] friendly_name: Friendly name of HostPool.
        :param pulumi.Input[str] host_pool_name: The name of the host pool within the specified resource group
        :param pulumi.Input[Union[str, 'HostPoolType']] host_pool_type: HostPool type for desktop.
        :param pulumi.Input[Union[str, 'LoadBalancerType']] load_balancer_type: The type of the load balancer.
        :param pulumi.Input[str] location: The geo-location where the resource lives
        :param pulumi.Input[int] max_session_limit: The max session limit of HostPool.
        :param pulumi.Input[Union[str, 'PersonalDesktopAssignmentType']] personal_desktop_assignment_type: PersonalDesktopAssignment type for HostPool.
        :param pulumi.Input[Union[str, 'PreferredAppGroupType']] preferred_app_group_type: The type of preferred application group type, default to Desktop Application Group
        :param pulumi.Input[pulumi.InputType['RegistrationInfoArgs']] registration_info: The registration info of HostPool.
        :param pulumi.Input[str] resource_group_name: The name of the resource group. The name is case insensitive.
        :param pulumi.Input[int] ring: The ring number of HostPool.
        :param pulumi.Input[str] sso_client_id: ClientId for the registered Relying Party used to issue WVD SSO certificates.
        :param pulumi.Input[str] sso_client_secret_key_vault_path: Path to Azure KeyVault storing the secret used for communication to ADFS.
        :param pulumi.Input[str] sso_context: Path to keyvault containing ssoContext secret.
        :param pulumi.Input[Union[str, 'SSOSecretType']] sso_secret_type: The type of single sign on Secret Type.
        :param pulumi.Input[str] ssoadfs_authority: URL to customer ADFS server for signing WVD SSO certificates.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[bool] validation_environment: Is validation environment.
        :param pulumi.Input[str] vm_template: VM template for sessionhosts configuration within hostpool.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: HostPoolArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Represents a HostPool definition.

        :param str resource_name: The name of the resource.
        :param HostPoolArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(HostPoolArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 custom_rdp_property: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 friendly_name: Optional[pulumi.Input[str]] = None,
                 host_pool_name: Optional[pulumi.Input[str]] = None,
                 host_pool_type: Optional[pulumi.Input[Union[str, 'HostPoolType']]] = None,
                 load_balancer_type: Optional[pulumi.Input[Union[str, 'LoadBalancerType']]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 max_session_limit: Optional[pulumi.Input[int]] = None,
                 personal_desktop_assignment_type: Optional[pulumi.Input[Union[str, 'PersonalDesktopAssignmentType']]] = None,
                 preferred_app_group_type: Optional[pulumi.Input[Union[str, 'PreferredAppGroupType']]] = None,
                 registration_info: Optional[pulumi.Input[pulumi.InputType['RegistrationInfoArgs']]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 ring: Optional[pulumi.Input[int]] = None,
                 sso_client_id: Optional[pulumi.Input[str]] = None,
                 sso_client_secret_key_vault_path: Optional[pulumi.Input[str]] = None,
                 sso_context: Optional[pulumi.Input[str]] = None,
                 sso_secret_type: Optional[pulumi.Input[Union[str, 'SSOSecretType']]] = None,
                 ssoadfs_authority: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 validation_environment: Optional[pulumi.Input[bool]] = None,
                 vm_template: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        pulumi.log.warn("""HostPool is deprecated: Version 2020-10-19-preview will be removed in v2 of the provider.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = HostPoolArgs.__new__(HostPoolArgs)

            __props__.__dict__["custom_rdp_property"] = custom_rdp_property
            __props__.__dict__["description"] = description
            __props__.__dict__["friendly_name"] = friendly_name
            __props__.__dict__["host_pool_name"] = host_pool_name
            if host_pool_type is None and not opts.urn:
                raise TypeError("Missing required property 'host_pool_type'")
            __props__.__dict__["host_pool_type"] = host_pool_type
            if load_balancer_type is None and not opts.urn:
                raise TypeError("Missing required property 'load_balancer_type'")
            __props__.__dict__["load_balancer_type"] = load_balancer_type
            __props__.__dict__["location"] = location
            __props__.__dict__["max_session_limit"] = max_session_limit
            __props__.__dict__["personal_desktop_assignment_type"] = personal_desktop_assignment_type
            if preferred_app_group_type is None and not opts.urn:
                raise TypeError("Missing required property 'preferred_app_group_type'")
            __props__.__dict__["preferred_app_group_type"] = preferred_app_group_type
            __props__.__dict__["registration_info"] = registration_info
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__.__dict__["resource_group_name"] = resource_group_name
            __props__.__dict__["ring"] = ring
            __props__.__dict__["sso_client_id"] = sso_client_id
            __props__.__dict__["sso_client_secret_key_vault_path"] = sso_client_secret_key_vault_path
            __props__.__dict__["sso_context"] = sso_context
            __props__.__dict__["sso_secret_type"] = sso_secret_type
            __props__.__dict__["ssoadfs_authority"] = ssoadfs_authority
            __props__.__dict__["tags"] = tags
            __props__.__dict__["validation_environment"] = validation_environment
            __props__.__dict__["vm_template"] = vm_template
            __props__.__dict__["application_group_references"] = None
            __props__.__dict__["name"] = None
            __props__.__dict__["type"] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-native:desktopvirtualization:HostPool"), pulumi.Alias(type_="azure-native:desktopvirtualization/v20190123preview:HostPool"), pulumi.Alias(type_="azure-native:desktopvirtualization/v20190924preview:HostPool"), pulumi.Alias(type_="azure-native:desktopvirtualization/v20191210preview:HostPool"), pulumi.Alias(type_="azure-native:desktopvirtualization/v20200921preview:HostPool"), pulumi.Alias(type_="azure-native:desktopvirtualization/v20201102preview:HostPool"), pulumi.Alias(type_="azure-native:desktopvirtualization/v20201110preview:HostPool"), pulumi.Alias(type_="azure-native:desktopvirtualization/v20210114preview:HostPool"), pulumi.Alias(type_="azure-native:desktopvirtualization/v20210201preview:HostPool"), pulumi.Alias(type_="azure-native:desktopvirtualization/v20210309preview:HostPool"), pulumi.Alias(type_="azure-native:desktopvirtualization/v20210401preview:HostPool"), pulumi.Alias(type_="azure-native:desktopvirtualization/v20210712:HostPool"), pulumi.Alias(type_="azure-native:desktopvirtualization/v20210903preview:HostPool"), pulumi.Alias(type_="azure-native:desktopvirtualization/v20220210preview:HostPool"), pulumi.Alias(type_="azure-native:desktopvirtualization/v20220401preview:HostPool")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(HostPool, __self__).__init__(
            'azure-native:desktopvirtualization/v20201019preview:HostPool',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'HostPool':
        """
        Get an existing HostPool resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = HostPoolArgs.__new__(HostPoolArgs)

        __props__.__dict__["application_group_references"] = None
        __props__.__dict__["custom_rdp_property"] = None
        __props__.__dict__["description"] = None
        __props__.__dict__["friendly_name"] = None
        __props__.__dict__["host_pool_type"] = None
        __props__.__dict__["load_balancer_type"] = None
        __props__.__dict__["location"] = None
        __props__.__dict__["max_session_limit"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["personal_desktop_assignment_type"] = None
        __props__.__dict__["preferred_app_group_type"] = None
        __props__.__dict__["registration_info"] = None
        __props__.__dict__["ring"] = None
        __props__.__dict__["sso_client_id"] = None
        __props__.__dict__["sso_client_secret_key_vault_path"] = None
        __props__.__dict__["sso_context"] = None
        __props__.__dict__["sso_secret_type"] = None
        __props__.__dict__["ssoadfs_authority"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["type"] = None
        __props__.__dict__["validation_environment"] = None
        __props__.__dict__["vm_template"] = None
        return HostPool(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="applicationGroupReferences")
    def application_group_references(self) -> pulumi.Output[Sequence[str]]:
        """
        List of applicationGroup links.
        """
        return pulumi.get(self, "application_group_references")

    @property
    @pulumi.getter(name="customRdpProperty")
    def custom_rdp_property(self) -> pulumi.Output[Optional[str]]:
        """
        Custom rdp property of HostPool.
        """
        return pulumi.get(self, "custom_rdp_property")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Description of HostPool.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="friendlyName")
    def friendly_name(self) -> pulumi.Output[Optional[str]]:
        """
        Friendly name of HostPool.
        """
        return pulumi.get(self, "friendly_name")

    @property
    @pulumi.getter(name="hostPoolType")
    def host_pool_type(self) -> pulumi.Output[str]:
        """
        HostPool type for desktop.
        """
        return pulumi.get(self, "host_pool_type")

    @property
    @pulumi.getter(name="loadBalancerType")
    def load_balancer_type(self) -> pulumi.Output[str]:
        """
        The type of the load balancer.
        """
        return pulumi.get(self, "load_balancer_type")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        The geo-location where the resource lives
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="maxSessionLimit")
    def max_session_limit(self) -> pulumi.Output[Optional[int]]:
        """
        The max session limit of HostPool.
        """
        return pulumi.get(self, "max_session_limit")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="personalDesktopAssignmentType")
    def personal_desktop_assignment_type(self) -> pulumi.Output[Optional[str]]:
        """
        PersonalDesktopAssignment type for HostPool.
        """
        return pulumi.get(self, "personal_desktop_assignment_type")

    @property
    @pulumi.getter(name="preferredAppGroupType")
    def preferred_app_group_type(self) -> pulumi.Output[str]:
        """
        The type of preferred application group type, default to Desktop Application Group
        """
        return pulumi.get(self, "preferred_app_group_type")

    @property
    @pulumi.getter(name="registrationInfo")
    def registration_info(self) -> pulumi.Output[Optional['outputs.RegistrationInfoResponse']]:
        """
        The registration info of HostPool.
        """
        return pulumi.get(self, "registration_info")

    @property
    @pulumi.getter
    def ring(self) -> pulumi.Output[Optional[int]]:
        """
        The ring number of HostPool.
        """
        return pulumi.get(self, "ring")

    @property
    @pulumi.getter(name="ssoClientId")
    def sso_client_id(self) -> pulumi.Output[Optional[str]]:
        """
        ClientId for the registered Relying Party used to issue WVD SSO certificates.
        """
        return pulumi.get(self, "sso_client_id")

    @property
    @pulumi.getter(name="ssoClientSecretKeyVaultPath")
    def sso_client_secret_key_vault_path(self) -> pulumi.Output[Optional[str]]:
        """
        Path to Azure KeyVault storing the secret used for communication to ADFS.
        """
        return pulumi.get(self, "sso_client_secret_key_vault_path")

    @property
    @pulumi.getter(name="ssoContext")
    def sso_context(self) -> pulumi.Output[Optional[str]]:
        """
        Path to keyvault containing ssoContext secret.
        """
        return pulumi.get(self, "sso_context")

    @property
    @pulumi.getter(name="ssoSecretType")
    def sso_secret_type(self) -> pulumi.Output[Optional[str]]:
        """
        The type of single sign on Secret Type.
        """
        return pulumi.get(self, "sso_secret_type")

    @property
    @pulumi.getter(name="ssoadfsAuthority")
    def ssoadfs_authority(self) -> pulumi.Output[Optional[str]]:
        """
        URL to customer ADFS server for signing WVD SSO certificates.
        """
        return pulumi.get(self, "ssoadfs_authority")

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
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="validationEnvironment")
    def validation_environment(self) -> pulumi.Output[Optional[bool]]:
        """
        Is validation environment.
        """
        return pulumi.get(self, "validation_environment")

    @property
    @pulumi.getter(name="vmTemplate")
    def vm_template(self) -> pulumi.Output[Optional[str]]:
        """
        VM template for sessionhosts configuration within hostpool.
        """
        return pulumi.get(self, "vm_template")

