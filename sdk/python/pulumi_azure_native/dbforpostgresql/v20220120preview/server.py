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

__all__ = ['ServerArgs', 'Server']

@pulumi.input_type
class ServerArgs:
    def __init__(__self__, *,
                 resource_group_name: pulumi.Input[str],
                 administrator_login: Optional[pulumi.Input[str]] = None,
                 administrator_login_password: Optional[pulumi.Input[str]] = None,
                 availability_zone: Optional[pulumi.Input[str]] = None,
                 backup: Optional[pulumi.Input['BackupArgs']] = None,
                 create_mode: Optional[pulumi.Input[Union[str, 'CreateMode']]] = None,
                 high_availability: Optional[pulumi.Input['HighAvailabilityArgs']] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 maintenance_window: Optional[pulumi.Input['MaintenanceWindowArgs']] = None,
                 network: Optional[pulumi.Input['NetworkArgs']] = None,
                 point_in_time_utc: Optional[pulumi.Input[str]] = None,
                 server_name: Optional[pulumi.Input[str]] = None,
                 sku: Optional[pulumi.Input['SkuArgs']] = None,
                 source_server_resource_id: Optional[pulumi.Input[str]] = None,
                 storage: Optional[pulumi.Input['StorageArgs']] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 version: Optional[pulumi.Input[Union[str, 'ServerVersion']]] = None):
        """
        The set of arguments for constructing a Server resource.
        :param pulumi.Input[str] resource_group_name: The name of the resource group. The name is case insensitive.
        :param pulumi.Input[str] administrator_login: The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation).
        :param pulumi.Input[str] administrator_login_password: The administrator login password (required for server creation).
        :param pulumi.Input[str] availability_zone: availability zone information of the server.
        :param pulumi.Input['BackupArgs'] backup: Backup properties of a server.
        :param pulumi.Input[Union[str, 'CreateMode']] create_mode: The mode to create a new PostgreSQL server.
        :param pulumi.Input['HighAvailabilityArgs'] high_availability: High availability properties of a server.
        :param pulumi.Input[str] location: The geo-location where the resource lives
        :param pulumi.Input['MaintenanceWindowArgs'] maintenance_window: Maintenance window properties of a server.
        :param pulumi.Input['NetworkArgs'] network: Network properties of a server.
        :param pulumi.Input[str] point_in_time_utc: Restore point creation time (ISO8601 format), specifying the time to restore from. It's required when 'createMode' is 'PointInTimeRestore'.
        :param pulumi.Input[str] server_name: The name of the server.
        :param pulumi.Input['SkuArgs'] sku: The SKU (pricing tier) of the server.
        :param pulumi.Input[str] source_server_resource_id: The source server resource ID to restore from. It's required when 'createMode' is 'PointInTimeRestore'.
        :param pulumi.Input['StorageArgs'] storage: Storage properties of a server.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[Union[str, 'ServerVersion']] version: PostgreSQL Server version.
        """
        pulumi.set(__self__, "resource_group_name", resource_group_name)
        if administrator_login is not None:
            pulumi.set(__self__, "administrator_login", administrator_login)
        if administrator_login_password is not None:
            pulumi.set(__self__, "administrator_login_password", administrator_login_password)
        if availability_zone is None:
            availability_zone = ''
        if availability_zone is not None:
            pulumi.set(__self__, "availability_zone", availability_zone)
        if backup is not None:
            pulumi.set(__self__, "backup", backup)
        if create_mode is not None:
            pulumi.set(__self__, "create_mode", create_mode)
        if high_availability is not None:
            pulumi.set(__self__, "high_availability", high_availability)
        if location is not None:
            pulumi.set(__self__, "location", location)
        if maintenance_window is not None:
            pulumi.set(__self__, "maintenance_window", maintenance_window)
        if network is not None:
            pulumi.set(__self__, "network", network)
        if point_in_time_utc is not None:
            pulumi.set(__self__, "point_in_time_utc", point_in_time_utc)
        if server_name is not None:
            pulumi.set(__self__, "server_name", server_name)
        if sku is not None:
            pulumi.set(__self__, "sku", sku)
        if source_server_resource_id is not None:
            pulumi.set(__self__, "source_server_resource_id", source_server_resource_id)
        if storage is not None:
            pulumi.set(__self__, "storage", storage)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if version is not None:
            pulumi.set(__self__, "version", version)

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
    @pulumi.getter(name="administratorLogin")
    def administrator_login(self) -> Optional[pulumi.Input[str]]:
        """
        The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation).
        """
        return pulumi.get(self, "administrator_login")

    @administrator_login.setter
    def administrator_login(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "administrator_login", value)

    @property
    @pulumi.getter(name="administratorLoginPassword")
    def administrator_login_password(self) -> Optional[pulumi.Input[str]]:
        """
        The administrator login password (required for server creation).
        """
        return pulumi.get(self, "administrator_login_password")

    @administrator_login_password.setter
    def administrator_login_password(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "administrator_login_password", value)

    @property
    @pulumi.getter(name="availabilityZone")
    def availability_zone(self) -> Optional[pulumi.Input[str]]:
        """
        availability zone information of the server.
        """
        return pulumi.get(self, "availability_zone")

    @availability_zone.setter
    def availability_zone(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "availability_zone", value)

    @property
    @pulumi.getter
    def backup(self) -> Optional[pulumi.Input['BackupArgs']]:
        """
        Backup properties of a server.
        """
        return pulumi.get(self, "backup")

    @backup.setter
    def backup(self, value: Optional[pulumi.Input['BackupArgs']]):
        pulumi.set(self, "backup", value)

    @property
    @pulumi.getter(name="createMode")
    def create_mode(self) -> Optional[pulumi.Input[Union[str, 'CreateMode']]]:
        """
        The mode to create a new PostgreSQL server.
        """
        return pulumi.get(self, "create_mode")

    @create_mode.setter
    def create_mode(self, value: Optional[pulumi.Input[Union[str, 'CreateMode']]]):
        pulumi.set(self, "create_mode", value)

    @property
    @pulumi.getter(name="highAvailability")
    def high_availability(self) -> Optional[pulumi.Input['HighAvailabilityArgs']]:
        """
        High availability properties of a server.
        """
        return pulumi.get(self, "high_availability")

    @high_availability.setter
    def high_availability(self, value: Optional[pulumi.Input['HighAvailabilityArgs']]):
        pulumi.set(self, "high_availability", value)

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
    @pulumi.getter(name="maintenanceWindow")
    def maintenance_window(self) -> Optional[pulumi.Input['MaintenanceWindowArgs']]:
        """
        Maintenance window properties of a server.
        """
        return pulumi.get(self, "maintenance_window")

    @maintenance_window.setter
    def maintenance_window(self, value: Optional[pulumi.Input['MaintenanceWindowArgs']]):
        pulumi.set(self, "maintenance_window", value)

    @property
    @pulumi.getter
    def network(self) -> Optional[pulumi.Input['NetworkArgs']]:
        """
        Network properties of a server.
        """
        return pulumi.get(self, "network")

    @network.setter
    def network(self, value: Optional[pulumi.Input['NetworkArgs']]):
        pulumi.set(self, "network", value)

    @property
    @pulumi.getter(name="pointInTimeUTC")
    def point_in_time_utc(self) -> Optional[pulumi.Input[str]]:
        """
        Restore point creation time (ISO8601 format), specifying the time to restore from. It's required when 'createMode' is 'PointInTimeRestore'.
        """
        return pulumi.get(self, "point_in_time_utc")

    @point_in_time_utc.setter
    def point_in_time_utc(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "point_in_time_utc", value)

    @property
    @pulumi.getter(name="serverName")
    def server_name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the server.
        """
        return pulumi.get(self, "server_name")

    @server_name.setter
    def server_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "server_name", value)

    @property
    @pulumi.getter
    def sku(self) -> Optional[pulumi.Input['SkuArgs']]:
        """
        The SKU (pricing tier) of the server.
        """
        return pulumi.get(self, "sku")

    @sku.setter
    def sku(self, value: Optional[pulumi.Input['SkuArgs']]):
        pulumi.set(self, "sku", value)

    @property
    @pulumi.getter(name="sourceServerResourceId")
    def source_server_resource_id(self) -> Optional[pulumi.Input[str]]:
        """
        The source server resource ID to restore from. It's required when 'createMode' is 'PointInTimeRestore'.
        """
        return pulumi.get(self, "source_server_resource_id")

    @source_server_resource_id.setter
    def source_server_resource_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "source_server_resource_id", value)

    @property
    @pulumi.getter
    def storage(self) -> Optional[pulumi.Input['StorageArgs']]:
        """
        Storage properties of a server.
        """
        return pulumi.get(self, "storage")

    @storage.setter
    def storage(self, value: Optional[pulumi.Input['StorageArgs']]):
        pulumi.set(self, "storage", value)

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
    def version(self) -> Optional[pulumi.Input[Union[str, 'ServerVersion']]]:
        """
        PostgreSQL Server version.
        """
        return pulumi.get(self, "version")

    @version.setter
    def version(self, value: Optional[pulumi.Input[Union[str, 'ServerVersion']]]):
        pulumi.set(self, "version", value)


class Server(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 administrator_login: Optional[pulumi.Input[str]] = None,
                 administrator_login_password: Optional[pulumi.Input[str]] = None,
                 availability_zone: Optional[pulumi.Input[str]] = None,
                 backup: Optional[pulumi.Input[pulumi.InputType['BackupArgs']]] = None,
                 create_mode: Optional[pulumi.Input[Union[str, 'CreateMode']]] = None,
                 high_availability: Optional[pulumi.Input[pulumi.InputType['HighAvailabilityArgs']]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 maintenance_window: Optional[pulumi.Input[pulumi.InputType['MaintenanceWindowArgs']]] = None,
                 network: Optional[pulumi.Input[pulumi.InputType['NetworkArgs']]] = None,
                 point_in_time_utc: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 server_name: Optional[pulumi.Input[str]] = None,
                 sku: Optional[pulumi.Input[pulumi.InputType['SkuArgs']]] = None,
                 source_server_resource_id: Optional[pulumi.Input[str]] = None,
                 storage: Optional[pulumi.Input[pulumi.InputType['StorageArgs']]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 version: Optional[pulumi.Input[Union[str, 'ServerVersion']]] = None,
                 __props__=None):
        """
        Represents a server.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] administrator_login: The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation).
        :param pulumi.Input[str] administrator_login_password: The administrator login password (required for server creation).
        :param pulumi.Input[str] availability_zone: availability zone information of the server.
        :param pulumi.Input[pulumi.InputType['BackupArgs']] backup: Backup properties of a server.
        :param pulumi.Input[Union[str, 'CreateMode']] create_mode: The mode to create a new PostgreSQL server.
        :param pulumi.Input[pulumi.InputType['HighAvailabilityArgs']] high_availability: High availability properties of a server.
        :param pulumi.Input[str] location: The geo-location where the resource lives
        :param pulumi.Input[pulumi.InputType['MaintenanceWindowArgs']] maintenance_window: Maintenance window properties of a server.
        :param pulumi.Input[pulumi.InputType['NetworkArgs']] network: Network properties of a server.
        :param pulumi.Input[str] point_in_time_utc: Restore point creation time (ISO8601 format), specifying the time to restore from. It's required when 'createMode' is 'PointInTimeRestore'.
        :param pulumi.Input[str] resource_group_name: The name of the resource group. The name is case insensitive.
        :param pulumi.Input[str] server_name: The name of the server.
        :param pulumi.Input[pulumi.InputType['SkuArgs']] sku: The SKU (pricing tier) of the server.
        :param pulumi.Input[str] source_server_resource_id: The source server resource ID to restore from. It's required when 'createMode' is 'PointInTimeRestore'.
        :param pulumi.Input[pulumi.InputType['StorageArgs']] storage: Storage properties of a server.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
        :param pulumi.Input[Union[str, 'ServerVersion']] version: PostgreSQL Server version.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ServerArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Represents a server.

        :param str resource_name: The name of the resource.
        :param ServerArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ServerArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 administrator_login: Optional[pulumi.Input[str]] = None,
                 administrator_login_password: Optional[pulumi.Input[str]] = None,
                 availability_zone: Optional[pulumi.Input[str]] = None,
                 backup: Optional[pulumi.Input[pulumi.InputType['BackupArgs']]] = None,
                 create_mode: Optional[pulumi.Input[Union[str, 'CreateMode']]] = None,
                 high_availability: Optional[pulumi.Input[pulumi.InputType['HighAvailabilityArgs']]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 maintenance_window: Optional[pulumi.Input[pulumi.InputType['MaintenanceWindowArgs']]] = None,
                 network: Optional[pulumi.Input[pulumi.InputType['NetworkArgs']]] = None,
                 point_in_time_utc: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 server_name: Optional[pulumi.Input[str]] = None,
                 sku: Optional[pulumi.Input[pulumi.InputType['SkuArgs']]] = None,
                 source_server_resource_id: Optional[pulumi.Input[str]] = None,
                 storage: Optional[pulumi.Input[pulumi.InputType['StorageArgs']]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 version: Optional[pulumi.Input[Union[str, 'ServerVersion']]] = None,
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
            __props__ = ServerArgs.__new__(ServerArgs)

            __props__.__dict__["administrator_login"] = administrator_login
            __props__.__dict__["administrator_login_password"] = administrator_login_password
            if availability_zone is None:
                availability_zone = ''
            __props__.__dict__["availability_zone"] = availability_zone
            __props__.__dict__["backup"] = backup
            __props__.__dict__["create_mode"] = create_mode
            __props__.__dict__["high_availability"] = high_availability
            __props__.__dict__["location"] = location
            __props__.__dict__["maintenance_window"] = maintenance_window
            __props__.__dict__["network"] = network
            __props__.__dict__["point_in_time_utc"] = point_in_time_utc
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__.__dict__["resource_group_name"] = resource_group_name
            __props__.__dict__["server_name"] = server_name
            __props__.__dict__["sku"] = sku
            __props__.__dict__["source_server_resource_id"] = source_server_resource_id
            __props__.__dict__["storage"] = storage
            __props__.__dict__["tags"] = tags
            __props__.__dict__["version"] = version
            __props__.__dict__["fully_qualified_domain_name"] = None
            __props__.__dict__["minor_version"] = None
            __props__.__dict__["name"] = None
            __props__.__dict__["state"] = None
            __props__.__dict__["system_data"] = None
            __props__.__dict__["type"] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-native:dbforpostgresql/v20200214preview:Server"), pulumi.Alias(type_="azure-native:dbforpostgresql/v20200214privatepreview:Server"), pulumi.Alias(type_="azure-native:dbforpostgresql/v20210410privatepreview:Server"), pulumi.Alias(type_="azure-native:dbforpostgresql/v20210601:Server"), pulumi.Alias(type_="azure-native:dbforpostgresql/v20210601preview:Server"), pulumi.Alias(type_="azure-native:dbforpostgresql/v20210615privatepreview:Server")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Server, __self__).__init__(
            'azure-native:dbforpostgresql/v20220120preview:Server',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Server':
        """
        Get an existing Server resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = ServerArgs.__new__(ServerArgs)

        __props__.__dict__["administrator_login"] = None
        __props__.__dict__["availability_zone"] = None
        __props__.__dict__["backup"] = None
        __props__.__dict__["fully_qualified_domain_name"] = None
        __props__.__dict__["high_availability"] = None
        __props__.__dict__["location"] = None
        __props__.__dict__["maintenance_window"] = None
        __props__.__dict__["minor_version"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["network"] = None
        __props__.__dict__["sku"] = None
        __props__.__dict__["state"] = None
        __props__.__dict__["storage"] = None
        __props__.__dict__["system_data"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["type"] = None
        __props__.__dict__["version"] = None
        return Server(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="administratorLogin")
    def administrator_login(self) -> pulumi.Output[Optional[str]]:
        """
        The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation).
        """
        return pulumi.get(self, "administrator_login")

    @property
    @pulumi.getter(name="availabilityZone")
    def availability_zone(self) -> pulumi.Output[Optional[str]]:
        """
        availability zone information of the server.
        """
        return pulumi.get(self, "availability_zone")

    @property
    @pulumi.getter
    def backup(self) -> pulumi.Output[Optional['outputs.BackupResponse']]:
        """
        Backup properties of a server.
        """
        return pulumi.get(self, "backup")

    @property
    @pulumi.getter(name="fullyQualifiedDomainName")
    def fully_qualified_domain_name(self) -> pulumi.Output[str]:
        """
        The fully qualified domain name of a server.
        """
        return pulumi.get(self, "fully_qualified_domain_name")

    @property
    @pulumi.getter(name="highAvailability")
    def high_availability(self) -> pulumi.Output[Optional['outputs.HighAvailabilityResponse']]:
        """
        High availability properties of a server.
        """
        return pulumi.get(self, "high_availability")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        The geo-location where the resource lives
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="maintenanceWindow")
    def maintenance_window(self) -> pulumi.Output[Optional['outputs.MaintenanceWindowResponse']]:
        """
        Maintenance window properties of a server.
        """
        return pulumi.get(self, "maintenance_window")

    @property
    @pulumi.getter(name="minorVersion")
    def minor_version(self) -> pulumi.Output[str]:
        """
        The minor version of the server.
        """
        return pulumi.get(self, "minor_version")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def network(self) -> pulumi.Output[Optional['outputs.NetworkResponse']]:
        """
        Network properties of a server.
        """
        return pulumi.get(self, "network")

    @property
    @pulumi.getter
    def sku(self) -> pulumi.Output[Optional['outputs.SkuResponse']]:
        """
        The SKU (pricing tier) of the server.
        """
        return pulumi.get(self, "sku")

    @property
    @pulumi.getter
    def state(self) -> pulumi.Output[str]:
        """
        A state of a server that is visible to user.
        """
        return pulumi.get(self, "state")

    @property
    @pulumi.getter
    def storage(self) -> pulumi.Output[Optional['outputs.StorageResponse']]:
        """
        Storage properties of a server.
        """
        return pulumi.get(self, "storage")

    @property
    @pulumi.getter(name="systemData")
    def system_data(self) -> pulumi.Output['outputs.SystemDataResponse']:
        """
        The system metadata relating to this resource.
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
    @pulumi.getter
    def version(self) -> pulumi.Output[Optional[str]]:
        """
        PostgreSQL Server version.
        """
        return pulumi.get(self, "version")

