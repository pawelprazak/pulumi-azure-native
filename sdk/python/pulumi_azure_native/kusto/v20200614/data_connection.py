# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from ._enums import *

__all__ = ['DataConnectionArgs', 'DataConnection']

@pulumi.input_type
class DataConnectionArgs:
    def __init__(__self__, *,
                 cluster_name: pulumi.Input[str],
                 database_name: pulumi.Input[str],
                 kind: pulumi.Input[Union[str, 'DataConnectionKind']],
                 resource_group_name: pulumi.Input[str],
                 data_connection_name: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a DataConnection resource.
        :param pulumi.Input[str] cluster_name: The name of the Kusto cluster.
        :param pulumi.Input[str] database_name: The name of the database in the Kusto cluster.
        :param pulumi.Input[Union[str, 'DataConnectionKind']] kind: Kind of the endpoint for the data connection
        :param pulumi.Input[str] resource_group_name: The name of the resource group containing the Kusto cluster.
        :param pulumi.Input[str] data_connection_name: The name of the data connection.
        :param pulumi.Input[str] location: Resource location.
        """
        pulumi.set(__self__, "cluster_name", cluster_name)
        pulumi.set(__self__, "database_name", database_name)
        pulumi.set(__self__, "kind", kind)
        pulumi.set(__self__, "resource_group_name", resource_group_name)
        if data_connection_name is not None:
            pulumi.set(__self__, "data_connection_name", data_connection_name)
        if location is not None:
            pulumi.set(__self__, "location", location)

    @property
    @pulumi.getter(name="clusterName")
    def cluster_name(self) -> pulumi.Input[str]:
        """
        The name of the Kusto cluster.
        """
        return pulumi.get(self, "cluster_name")

    @cluster_name.setter
    def cluster_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "cluster_name", value)

    @property
    @pulumi.getter(name="databaseName")
    def database_name(self) -> pulumi.Input[str]:
        """
        The name of the database in the Kusto cluster.
        """
        return pulumi.get(self, "database_name")

    @database_name.setter
    def database_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "database_name", value)

    @property
    @pulumi.getter
    def kind(self) -> pulumi.Input[Union[str, 'DataConnectionKind']]:
        """
        Kind of the endpoint for the data connection
        """
        return pulumi.get(self, "kind")

    @kind.setter
    def kind(self, value: pulumi.Input[Union[str, 'DataConnectionKind']]):
        pulumi.set(self, "kind", value)

    @property
    @pulumi.getter(name="resourceGroupName")
    def resource_group_name(self) -> pulumi.Input[str]:
        """
        The name of the resource group containing the Kusto cluster.
        """
        return pulumi.get(self, "resource_group_name")

    @resource_group_name.setter
    def resource_group_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "resource_group_name", value)

    @property
    @pulumi.getter(name="dataConnectionName")
    def data_connection_name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the data connection.
        """
        return pulumi.get(self, "data_connection_name")

    @data_connection_name.setter
    def data_connection_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "data_connection_name", value)

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


warnings.warn("""Please use one of the variants: EventGridDataConnection, EventHubDataConnection, IotHubDataConnection.""", DeprecationWarning)


class DataConnection(pulumi.CustomResource):
    warnings.warn("""Please use one of the variants: EventGridDataConnection, EventHubDataConnection, IotHubDataConnection.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cluster_name: Optional[pulumi.Input[str]] = None,
                 data_connection_name: Optional[pulumi.Input[str]] = None,
                 database_name: Optional[pulumi.Input[str]] = None,
                 kind: Optional[pulumi.Input[Union[str, 'DataConnectionKind']]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Class representing an data connection.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cluster_name: The name of the Kusto cluster.
        :param pulumi.Input[str] data_connection_name: The name of the data connection.
        :param pulumi.Input[str] database_name: The name of the database in the Kusto cluster.
        :param pulumi.Input[Union[str, 'DataConnectionKind']] kind: Kind of the endpoint for the data connection
        :param pulumi.Input[str] location: Resource location.
        :param pulumi.Input[str] resource_group_name: The name of the resource group containing the Kusto cluster.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DataConnectionArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Class representing an data connection.

        :param str resource_name: The name of the resource.
        :param DataConnectionArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DataConnectionArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cluster_name: Optional[pulumi.Input[str]] = None,
                 data_connection_name: Optional[pulumi.Input[str]] = None,
                 database_name: Optional[pulumi.Input[str]] = None,
                 kind: Optional[pulumi.Input[Union[str, 'DataConnectionKind']]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        pulumi.log.warn("""DataConnection is deprecated: Please use one of the variants: EventGridDataConnection, EventHubDataConnection, IotHubDataConnection.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DataConnectionArgs.__new__(DataConnectionArgs)

            if cluster_name is None and not opts.urn:
                raise TypeError("Missing required property 'cluster_name'")
            __props__.__dict__["cluster_name"] = cluster_name
            __props__.__dict__["data_connection_name"] = data_connection_name
            if database_name is None and not opts.urn:
                raise TypeError("Missing required property 'database_name'")
            __props__.__dict__["database_name"] = database_name
            if kind is None and not opts.urn:
                raise TypeError("Missing required property 'kind'")
            __props__.__dict__["kind"] = kind
            __props__.__dict__["location"] = location
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__.__dict__["resource_group_name"] = resource_group_name
            __props__.__dict__["name"] = None
            __props__.__dict__["type"] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-native:kusto:DataConnection"), pulumi.Alias(type_="azure-native:kusto/v20190121:DataConnection"), pulumi.Alias(type_="azure-native:kusto/v20190515:DataConnection"), pulumi.Alias(type_="azure-native:kusto/v20190907:DataConnection"), pulumi.Alias(type_="azure-native:kusto/v20191109:DataConnection"), pulumi.Alias(type_="azure-native:kusto/v20200215:DataConnection"), pulumi.Alias(type_="azure-native:kusto/v20200918:DataConnection"), pulumi.Alias(type_="azure-native:kusto/v20210101:DataConnection"), pulumi.Alias(type_="azure-native:kusto/v20210827:DataConnection"), pulumi.Alias(type_="azure-native:kusto/v20220201:DataConnection")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(DataConnection, __self__).__init__(
            'azure-native:kusto/v20200614:DataConnection',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'DataConnection':
        """
        Get an existing DataConnection resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = DataConnectionArgs.__new__(DataConnectionArgs)

        __props__.__dict__["kind"] = None
        __props__.__dict__["location"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["type"] = None
        return DataConnection(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def kind(self) -> pulumi.Output[str]:
        """
        Kind of the endpoint for the data connection
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[Optional[str]]:
        """
        Resource location.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")

