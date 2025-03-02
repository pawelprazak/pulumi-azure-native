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

__all__ = ['PhpWorkloadArgs', 'PhpWorkload']

@pulumi.input_type
class PhpWorkloadArgs:
    def __init__(__self__, *,
                 admin_user_profile: pulumi.Input['UserProfileArgs'],
                 app_location: pulumi.Input[str],
                 controller_profile: pulumi.Input['NodeProfileArgs'],
                 database_profile: pulumi.Input['DatabaseProfileArgs'],
                 kind: pulumi.Input[Union[str, 'WorkloadKind']],
                 resource_group_name: pulumi.Input[str],
                 web_nodes_profile: pulumi.Input['VmssNodesProfileArgs'],
                 backup_profile: Optional[pulumi.Input['BackupProfileArgs']] = None,
                 cache_profile: Optional[pulumi.Input['CacheProfileArgs']] = None,
                 fileshare_profile: Optional[pulumi.Input['FileshareProfileArgs']] = None,
                 identity: Optional[pulumi.Input['PhpWorkloadResourceIdentityArgs']] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 managed_resource_group_configuration: Optional[pulumi.Input['ManagedRGConfigurationArgs']] = None,
                 network_profile: Optional[pulumi.Input['NetworkProfileArgs']] = None,
                 php_profile: Optional[pulumi.Input['PhpProfileArgs']] = None,
                 php_workload_name: Optional[pulumi.Input[str]] = None,
                 search_profile: Optional[pulumi.Input['SearchProfileArgs']] = None,
                 site_profile: Optional[pulumi.Input['SiteProfileArgs']] = None,
                 sku: Optional[pulumi.Input['SkuArgs']] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None):
        """
        The set of arguments for constructing a PhpWorkload resource.
        :param pulumi.Input['UserProfileArgs'] admin_user_profile: Admin user profile used for VM and VMSS
        :param pulumi.Input[str] app_location: The infra resources for PHP workload will be created in this location
        :param pulumi.Input['NodeProfileArgs'] controller_profile: Controller VM profile
        :param pulumi.Input['DatabaseProfileArgs'] database_profile: Database profile
        :param pulumi.Input[Union[str, 'WorkloadKind']] kind: Indicates which kind of php workload this resource represent e.g WordPress
        :param pulumi.Input[str] resource_group_name: The name of the resource group. The name is case insensitive.
        :param pulumi.Input['VmssNodesProfileArgs'] web_nodes_profile: VMSS web nodes profile
        :param pulumi.Input['BackupProfileArgs'] backup_profile: Backup profile
        :param pulumi.Input['CacheProfileArgs'] cache_profile: Cache profile
        :param pulumi.Input['FileshareProfileArgs'] fileshare_profile: File share profile
        :param pulumi.Input['PhpWorkloadResourceIdentityArgs'] identity: Identity for the resource. Currently not supported
        :param pulumi.Input[str] location: The geo-location where the resource lives
        :param pulumi.Input['ManagedRGConfigurationArgs'] managed_resource_group_configuration: Managed resource group configuration of the workload
        :param pulumi.Input['NetworkProfileArgs'] network_profile: Network profile
        :param pulumi.Input['PhpProfileArgs'] php_profile: PHP profile
        :param pulumi.Input[str] php_workload_name: Php workload name
        :param pulumi.Input['SearchProfileArgs'] search_profile: Search profile
        :param pulumi.Input['SiteProfileArgs'] site_profile: Site profile
        :param pulumi.Input['SkuArgs'] sku: Php workloads SKU
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        """
        pulumi.set(__self__, "admin_user_profile", admin_user_profile)
        pulumi.set(__self__, "app_location", app_location)
        pulumi.set(__self__, "controller_profile", controller_profile)
        pulumi.set(__self__, "database_profile", database_profile)
        pulumi.set(__self__, "kind", kind)
        pulumi.set(__self__, "resource_group_name", resource_group_name)
        pulumi.set(__self__, "web_nodes_profile", web_nodes_profile)
        if backup_profile is not None:
            pulumi.set(__self__, "backup_profile", backup_profile)
        if cache_profile is not None:
            pulumi.set(__self__, "cache_profile", cache_profile)
        if fileshare_profile is not None:
            pulumi.set(__self__, "fileshare_profile", fileshare_profile)
        if identity is not None:
            pulumi.set(__self__, "identity", identity)
        if location is not None:
            pulumi.set(__self__, "location", location)
        if managed_resource_group_configuration is not None:
            pulumi.set(__self__, "managed_resource_group_configuration", managed_resource_group_configuration)
        if network_profile is not None:
            pulumi.set(__self__, "network_profile", network_profile)
        if php_profile is not None:
            pulumi.set(__self__, "php_profile", php_profile)
        if php_workload_name is not None:
            pulumi.set(__self__, "php_workload_name", php_workload_name)
        if search_profile is not None:
            pulumi.set(__self__, "search_profile", search_profile)
        if site_profile is not None:
            pulumi.set(__self__, "site_profile", site_profile)
        if sku is not None:
            pulumi.set(__self__, "sku", sku)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="adminUserProfile")
    def admin_user_profile(self) -> pulumi.Input['UserProfileArgs']:
        """
        Admin user profile used for VM and VMSS
        """
        return pulumi.get(self, "admin_user_profile")

    @admin_user_profile.setter
    def admin_user_profile(self, value: pulumi.Input['UserProfileArgs']):
        pulumi.set(self, "admin_user_profile", value)

    @property
    @pulumi.getter(name="appLocation")
    def app_location(self) -> pulumi.Input[str]:
        """
        The infra resources for PHP workload will be created in this location
        """
        return pulumi.get(self, "app_location")

    @app_location.setter
    def app_location(self, value: pulumi.Input[str]):
        pulumi.set(self, "app_location", value)

    @property
    @pulumi.getter(name="controllerProfile")
    def controller_profile(self) -> pulumi.Input['NodeProfileArgs']:
        """
        Controller VM profile
        """
        return pulumi.get(self, "controller_profile")

    @controller_profile.setter
    def controller_profile(self, value: pulumi.Input['NodeProfileArgs']):
        pulumi.set(self, "controller_profile", value)

    @property
    @pulumi.getter(name="databaseProfile")
    def database_profile(self) -> pulumi.Input['DatabaseProfileArgs']:
        """
        Database profile
        """
        return pulumi.get(self, "database_profile")

    @database_profile.setter
    def database_profile(self, value: pulumi.Input['DatabaseProfileArgs']):
        pulumi.set(self, "database_profile", value)

    @property
    @pulumi.getter
    def kind(self) -> pulumi.Input[Union[str, 'WorkloadKind']]:
        """
        Indicates which kind of php workload this resource represent e.g WordPress
        """
        return pulumi.get(self, "kind")

    @kind.setter
    def kind(self, value: pulumi.Input[Union[str, 'WorkloadKind']]):
        pulumi.set(self, "kind", value)

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
    @pulumi.getter(name="webNodesProfile")
    def web_nodes_profile(self) -> pulumi.Input['VmssNodesProfileArgs']:
        """
        VMSS web nodes profile
        """
        return pulumi.get(self, "web_nodes_profile")

    @web_nodes_profile.setter
    def web_nodes_profile(self, value: pulumi.Input['VmssNodesProfileArgs']):
        pulumi.set(self, "web_nodes_profile", value)

    @property
    @pulumi.getter(name="backupProfile")
    def backup_profile(self) -> Optional[pulumi.Input['BackupProfileArgs']]:
        """
        Backup profile
        """
        return pulumi.get(self, "backup_profile")

    @backup_profile.setter
    def backup_profile(self, value: Optional[pulumi.Input['BackupProfileArgs']]):
        pulumi.set(self, "backup_profile", value)

    @property
    @pulumi.getter(name="cacheProfile")
    def cache_profile(self) -> Optional[pulumi.Input['CacheProfileArgs']]:
        """
        Cache profile
        """
        return pulumi.get(self, "cache_profile")

    @cache_profile.setter
    def cache_profile(self, value: Optional[pulumi.Input['CacheProfileArgs']]):
        pulumi.set(self, "cache_profile", value)

    @property
    @pulumi.getter(name="fileshareProfile")
    def fileshare_profile(self) -> Optional[pulumi.Input['FileshareProfileArgs']]:
        """
        File share profile
        """
        return pulumi.get(self, "fileshare_profile")

    @fileshare_profile.setter
    def fileshare_profile(self, value: Optional[pulumi.Input['FileshareProfileArgs']]):
        pulumi.set(self, "fileshare_profile", value)

    @property
    @pulumi.getter
    def identity(self) -> Optional[pulumi.Input['PhpWorkloadResourceIdentityArgs']]:
        """
        Identity for the resource. Currently not supported
        """
        return pulumi.get(self, "identity")

    @identity.setter
    def identity(self, value: Optional[pulumi.Input['PhpWorkloadResourceIdentityArgs']]):
        pulumi.set(self, "identity", value)

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
    @pulumi.getter(name="managedResourceGroupConfiguration")
    def managed_resource_group_configuration(self) -> Optional[pulumi.Input['ManagedRGConfigurationArgs']]:
        """
        Managed resource group configuration of the workload
        """
        return pulumi.get(self, "managed_resource_group_configuration")

    @managed_resource_group_configuration.setter
    def managed_resource_group_configuration(self, value: Optional[pulumi.Input['ManagedRGConfigurationArgs']]):
        pulumi.set(self, "managed_resource_group_configuration", value)

    @property
    @pulumi.getter(name="networkProfile")
    def network_profile(self) -> Optional[pulumi.Input['NetworkProfileArgs']]:
        """
        Network profile
        """
        return pulumi.get(self, "network_profile")

    @network_profile.setter
    def network_profile(self, value: Optional[pulumi.Input['NetworkProfileArgs']]):
        pulumi.set(self, "network_profile", value)

    @property
    @pulumi.getter(name="phpProfile")
    def php_profile(self) -> Optional[pulumi.Input['PhpProfileArgs']]:
        """
        PHP profile
        """
        return pulumi.get(self, "php_profile")

    @php_profile.setter
    def php_profile(self, value: Optional[pulumi.Input['PhpProfileArgs']]):
        pulumi.set(self, "php_profile", value)

    @property
    @pulumi.getter(name="phpWorkloadName")
    def php_workload_name(self) -> Optional[pulumi.Input[str]]:
        """
        Php workload name
        """
        return pulumi.get(self, "php_workload_name")

    @php_workload_name.setter
    def php_workload_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "php_workload_name", value)

    @property
    @pulumi.getter(name="searchProfile")
    def search_profile(self) -> Optional[pulumi.Input['SearchProfileArgs']]:
        """
        Search profile
        """
        return pulumi.get(self, "search_profile")

    @search_profile.setter
    def search_profile(self, value: Optional[pulumi.Input['SearchProfileArgs']]):
        pulumi.set(self, "search_profile", value)

    @property
    @pulumi.getter(name="siteProfile")
    def site_profile(self) -> Optional[pulumi.Input['SiteProfileArgs']]:
        """
        Site profile
        """
        return pulumi.get(self, "site_profile")

    @site_profile.setter
    def site_profile(self, value: Optional[pulumi.Input['SiteProfileArgs']]):
        pulumi.set(self, "site_profile", value)

    @property
    @pulumi.getter
    def sku(self) -> Optional[pulumi.Input['SkuArgs']]:
        """
        Php workloads SKU
        """
        return pulumi.get(self, "sku")

    @sku.setter
    def sku(self, value: Optional[pulumi.Input['SkuArgs']]):
        pulumi.set(self, "sku", value)

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


class PhpWorkload(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 admin_user_profile: Optional[pulumi.Input[pulumi.InputType['UserProfileArgs']]] = None,
                 app_location: Optional[pulumi.Input[str]] = None,
                 backup_profile: Optional[pulumi.Input[pulumi.InputType['BackupProfileArgs']]] = None,
                 cache_profile: Optional[pulumi.Input[pulumi.InputType['CacheProfileArgs']]] = None,
                 controller_profile: Optional[pulumi.Input[pulumi.InputType['NodeProfileArgs']]] = None,
                 database_profile: Optional[pulumi.Input[pulumi.InputType['DatabaseProfileArgs']]] = None,
                 fileshare_profile: Optional[pulumi.Input[pulumi.InputType['FileshareProfileArgs']]] = None,
                 identity: Optional[pulumi.Input[pulumi.InputType['PhpWorkloadResourceIdentityArgs']]] = None,
                 kind: Optional[pulumi.Input[Union[str, 'WorkloadKind']]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 managed_resource_group_configuration: Optional[pulumi.Input[pulumi.InputType['ManagedRGConfigurationArgs']]] = None,
                 network_profile: Optional[pulumi.Input[pulumi.InputType['NetworkProfileArgs']]] = None,
                 php_profile: Optional[pulumi.Input[pulumi.InputType['PhpProfileArgs']]] = None,
                 php_workload_name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 search_profile: Optional[pulumi.Input[pulumi.InputType['SearchProfileArgs']]] = None,
                 site_profile: Optional[pulumi.Input[pulumi.InputType['SiteProfileArgs']]] = None,
                 sku: Optional[pulumi.Input[pulumi.InputType['SkuArgs']]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 web_nodes_profile: Optional[pulumi.Input[pulumi.InputType['VmssNodesProfileArgs']]] = None,
                 __props__=None):
        """
        Php workload resource

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['UserProfileArgs']] admin_user_profile: Admin user profile used for VM and VMSS
        :param pulumi.Input[str] app_location: The infra resources for PHP workload will be created in this location
        :param pulumi.Input[pulumi.InputType['BackupProfileArgs']] backup_profile: Backup profile
        :param pulumi.Input[pulumi.InputType['CacheProfileArgs']] cache_profile: Cache profile
        :param pulumi.Input[pulumi.InputType['NodeProfileArgs']] controller_profile: Controller VM profile
        :param pulumi.Input[pulumi.InputType['DatabaseProfileArgs']] database_profile: Database profile
        :param pulumi.Input[pulumi.InputType['FileshareProfileArgs']] fileshare_profile: File share profile
        :param pulumi.Input[pulumi.InputType['PhpWorkloadResourceIdentityArgs']] identity: Identity for the resource. Currently not supported
        :param pulumi.Input[Union[str, 'WorkloadKind']] kind: Indicates which kind of php workload this resource represent e.g WordPress
        :param pulumi.Input[str] location: The geo-location where the resource lives
        :param pulumi.Input[pulumi.InputType['ManagedRGConfigurationArgs']] managed_resource_group_configuration: Managed resource group configuration of the workload
        :param pulumi.Input[pulumi.InputType['NetworkProfileArgs']] network_profile: Network profile
        :param pulumi.Input[pulumi.InputType['PhpProfileArgs']] php_profile: PHP profile
        :param pulumi.Input[str] php_workload_name: Php workload name
        :param pulumi.Input[str] resource_group_name: The name of the resource group. The name is case insensitive.
        :param pulumi.Input[pulumi.InputType['SearchProfileArgs']] search_profile: Search profile
        :param pulumi.Input[pulumi.InputType['SiteProfileArgs']] site_profile: Site profile
        :param pulumi.Input[pulumi.InputType['SkuArgs']] sku: Php workloads SKU
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[pulumi.InputType['VmssNodesProfileArgs']] web_nodes_profile: VMSS web nodes profile
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: PhpWorkloadArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Php workload resource

        :param str resource_name: The name of the resource.
        :param PhpWorkloadArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(PhpWorkloadArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 admin_user_profile: Optional[pulumi.Input[pulumi.InputType['UserProfileArgs']]] = None,
                 app_location: Optional[pulumi.Input[str]] = None,
                 backup_profile: Optional[pulumi.Input[pulumi.InputType['BackupProfileArgs']]] = None,
                 cache_profile: Optional[pulumi.Input[pulumi.InputType['CacheProfileArgs']]] = None,
                 controller_profile: Optional[pulumi.Input[pulumi.InputType['NodeProfileArgs']]] = None,
                 database_profile: Optional[pulumi.Input[pulumi.InputType['DatabaseProfileArgs']]] = None,
                 fileshare_profile: Optional[pulumi.Input[pulumi.InputType['FileshareProfileArgs']]] = None,
                 identity: Optional[pulumi.Input[pulumi.InputType['PhpWorkloadResourceIdentityArgs']]] = None,
                 kind: Optional[pulumi.Input[Union[str, 'WorkloadKind']]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 managed_resource_group_configuration: Optional[pulumi.Input[pulumi.InputType['ManagedRGConfigurationArgs']]] = None,
                 network_profile: Optional[pulumi.Input[pulumi.InputType['NetworkProfileArgs']]] = None,
                 php_profile: Optional[pulumi.Input[pulumi.InputType['PhpProfileArgs']]] = None,
                 php_workload_name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 search_profile: Optional[pulumi.Input[pulumi.InputType['SearchProfileArgs']]] = None,
                 site_profile: Optional[pulumi.Input[pulumi.InputType['SiteProfileArgs']]] = None,
                 sku: Optional[pulumi.Input[pulumi.InputType['SkuArgs']]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 web_nodes_profile: Optional[pulumi.Input[pulumi.InputType['VmssNodesProfileArgs']]] = None,
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
            __props__ = PhpWorkloadArgs.__new__(PhpWorkloadArgs)

            if admin_user_profile is None and not opts.urn:
                raise TypeError("Missing required property 'admin_user_profile'")
            __props__.__dict__["admin_user_profile"] = admin_user_profile
            if app_location is None and not opts.urn:
                raise TypeError("Missing required property 'app_location'")
            __props__.__dict__["app_location"] = app_location
            __props__.__dict__["backup_profile"] = backup_profile
            __props__.__dict__["cache_profile"] = cache_profile
            if controller_profile is None and not opts.urn:
                raise TypeError("Missing required property 'controller_profile'")
            __props__.__dict__["controller_profile"] = controller_profile
            if database_profile is None and not opts.urn:
                raise TypeError("Missing required property 'database_profile'")
            __props__.__dict__["database_profile"] = database_profile
            __props__.__dict__["fileshare_profile"] = fileshare_profile
            __props__.__dict__["identity"] = identity
            if kind is None and not opts.urn:
                raise TypeError("Missing required property 'kind'")
            __props__.__dict__["kind"] = kind
            __props__.__dict__["location"] = location
            __props__.__dict__["managed_resource_group_configuration"] = managed_resource_group_configuration
            __props__.__dict__["network_profile"] = network_profile
            __props__.__dict__["php_profile"] = php_profile
            __props__.__dict__["php_workload_name"] = php_workload_name
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__.__dict__["resource_group_name"] = resource_group_name
            __props__.__dict__["search_profile"] = search_profile
            __props__.__dict__["site_profile"] = site_profile
            __props__.__dict__["sku"] = sku
            __props__.__dict__["tags"] = tags
            if web_nodes_profile is None and not opts.urn:
                raise TypeError("Missing required property 'web_nodes_profile'")
            __props__.__dict__["web_nodes_profile"] = web_nodes_profile
            __props__.__dict__["name"] = None
            __props__.__dict__["provisioning_state"] = None
            __props__.__dict__["system_data"] = None
            __props__.__dict__["type"] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-native:workloads:PhpWorkload")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(PhpWorkload, __self__).__init__(
            'azure-native:workloads/v20211201preview:PhpWorkload',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'PhpWorkload':
        """
        Get an existing PhpWorkload resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = PhpWorkloadArgs.__new__(PhpWorkloadArgs)

        __props__.__dict__["admin_user_profile"] = None
        __props__.__dict__["app_location"] = None
        __props__.__dict__["backup_profile"] = None
        __props__.__dict__["cache_profile"] = None
        __props__.__dict__["controller_profile"] = None
        __props__.__dict__["database_profile"] = None
        __props__.__dict__["fileshare_profile"] = None
        __props__.__dict__["identity"] = None
        __props__.__dict__["kind"] = None
        __props__.__dict__["location"] = None
        __props__.__dict__["managed_resource_group_configuration"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["network_profile"] = None
        __props__.__dict__["php_profile"] = None
        __props__.__dict__["provisioning_state"] = None
        __props__.__dict__["search_profile"] = None
        __props__.__dict__["site_profile"] = None
        __props__.__dict__["sku"] = None
        __props__.__dict__["system_data"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["type"] = None
        __props__.__dict__["web_nodes_profile"] = None
        return PhpWorkload(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="adminUserProfile")
    def admin_user_profile(self) -> pulumi.Output['outputs.UserProfileResponse']:
        """
        Admin user profile used for VM and VMSS
        """
        return pulumi.get(self, "admin_user_profile")

    @property
    @pulumi.getter(name="appLocation")
    def app_location(self) -> pulumi.Output[str]:
        """
        The infra resources for PHP workload will be created in this location
        """
        return pulumi.get(self, "app_location")

    @property
    @pulumi.getter(name="backupProfile")
    def backup_profile(self) -> pulumi.Output[Optional['outputs.BackupProfileResponse']]:
        """
        Backup profile
        """
        return pulumi.get(self, "backup_profile")

    @property
    @pulumi.getter(name="cacheProfile")
    def cache_profile(self) -> pulumi.Output[Optional['outputs.CacheProfileResponse']]:
        """
        Cache profile
        """
        return pulumi.get(self, "cache_profile")

    @property
    @pulumi.getter(name="controllerProfile")
    def controller_profile(self) -> pulumi.Output['outputs.NodeProfileResponse']:
        """
        Controller VM profile
        """
        return pulumi.get(self, "controller_profile")

    @property
    @pulumi.getter(name="databaseProfile")
    def database_profile(self) -> pulumi.Output['outputs.DatabaseProfileResponse']:
        """
        Database profile
        """
        return pulumi.get(self, "database_profile")

    @property
    @pulumi.getter(name="fileshareProfile")
    def fileshare_profile(self) -> pulumi.Output[Optional['outputs.FileshareProfileResponse']]:
        """
        File share profile
        """
        return pulumi.get(self, "fileshare_profile")

    @property
    @pulumi.getter
    def identity(self) -> pulumi.Output[Optional['outputs.PhpWorkloadResourceResponseIdentity']]:
        """
        Identity for the resource. Currently not supported
        """
        return pulumi.get(self, "identity")

    @property
    @pulumi.getter
    def kind(self) -> pulumi.Output[str]:
        """
        Indicates which kind of php workload this resource represent e.g WordPress
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        The geo-location where the resource lives
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="managedResourceGroupConfiguration")
    def managed_resource_group_configuration(self) -> pulumi.Output[Optional['outputs.ManagedRGConfigurationResponse']]:
        """
        Managed resource group configuration of the workload
        """
        return pulumi.get(self, "managed_resource_group_configuration")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkProfile")
    def network_profile(self) -> pulumi.Output[Optional['outputs.NetworkProfileResponse']]:
        """
        Network profile
        """
        return pulumi.get(self, "network_profile")

    @property
    @pulumi.getter(name="phpProfile")
    def php_profile(self) -> pulumi.Output[Optional['outputs.PhpProfileResponse']]:
        """
        PHP profile
        """
        return pulumi.get(self, "php_profile")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        Php workload resource provisioning state
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="searchProfile")
    def search_profile(self) -> pulumi.Output[Optional['outputs.SearchProfileResponse']]:
        """
        Search profile
        """
        return pulumi.get(self, "search_profile")

    @property
    @pulumi.getter(name="siteProfile")
    def site_profile(self) -> pulumi.Output[Optional['outputs.SiteProfileResponse']]:
        """
        Site profile
        """
        return pulumi.get(self, "site_profile")

    @property
    @pulumi.getter
    def sku(self) -> pulumi.Output[Optional['outputs.SkuResponse']]:
        """
        Php workloads SKU
        """
        return pulumi.get(self, "sku")

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
    def type(self) -> pulumi.Output[str]:
        """
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="webNodesProfile")
    def web_nodes_profile(self) -> pulumi.Output['outputs.VmssNodesProfileResponse']:
        """
        VMSS web nodes profile
        """
        return pulumi.get(self, "web_nodes_profile")

