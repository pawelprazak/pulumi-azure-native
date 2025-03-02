# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from . import outputs

__all__ = [
    'GetReadOnlyFollowingDatabaseResult',
    'AwaitableGetReadOnlyFollowingDatabaseResult',
    'get_read_only_following_database',
    'get_read_only_following_database_output',
]

@pulumi.output_type
class GetReadOnlyFollowingDatabaseResult:
    """
    Class representing a read only following database.
    """
    def __init__(__self__, attached_database_configuration_name=None, hot_cache_period=None, id=None, kind=None, leader_cluster_resource_id=None, location=None, name=None, principals_modification_kind=None, provisioning_state=None, soft_delete_period=None, statistics=None, type=None):
        if attached_database_configuration_name and not isinstance(attached_database_configuration_name, str):
            raise TypeError("Expected argument 'attached_database_configuration_name' to be a str")
        pulumi.set(__self__, "attached_database_configuration_name", attached_database_configuration_name)
        if hot_cache_period and not isinstance(hot_cache_period, str):
            raise TypeError("Expected argument 'hot_cache_period' to be a str")
        pulumi.set(__self__, "hot_cache_period", hot_cache_period)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if kind and not isinstance(kind, str):
            raise TypeError("Expected argument 'kind' to be a str")
        pulumi.set(__self__, "kind", kind)
        if leader_cluster_resource_id and not isinstance(leader_cluster_resource_id, str):
            raise TypeError("Expected argument 'leader_cluster_resource_id' to be a str")
        pulumi.set(__self__, "leader_cluster_resource_id", leader_cluster_resource_id)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if principals_modification_kind and not isinstance(principals_modification_kind, str):
            raise TypeError("Expected argument 'principals_modification_kind' to be a str")
        pulumi.set(__self__, "principals_modification_kind", principals_modification_kind)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if soft_delete_period and not isinstance(soft_delete_period, str):
            raise TypeError("Expected argument 'soft_delete_period' to be a str")
        pulumi.set(__self__, "soft_delete_period", soft_delete_period)
        if statistics and not isinstance(statistics, dict):
            raise TypeError("Expected argument 'statistics' to be a dict")
        pulumi.set(__self__, "statistics", statistics)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="attachedDatabaseConfigurationName")
    def attached_database_configuration_name(self) -> str:
        """
        The name of the attached database configuration cluster
        """
        return pulumi.get(self, "attached_database_configuration_name")

    @property
    @pulumi.getter(name="hotCachePeriod")
    def hot_cache_period(self) -> Optional[str]:
        """
        The time the data should be kept in cache for fast queries in TimeSpan.
        """
        return pulumi.get(self, "hot_cache_period")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def kind(self) -> str:
        """
        Kind of the database
        Expected value is 'ReadOnlyFollowing'.
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter(name="leaderClusterResourceId")
    def leader_cluster_resource_id(self) -> str:
        """
        The name of the leader cluster
        """
        return pulumi.get(self, "leader_cluster_resource_id")

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        Resource location.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="principalsModificationKind")
    def principals_modification_kind(self) -> str:
        """
        The principals modification kind of the database
        """
        return pulumi.get(self, "principals_modification_kind")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        The provisioned state of the resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="softDeletePeriod")
    def soft_delete_period(self) -> str:
        """
        The time the data should be kept before it stops being accessible to queries in TimeSpan.
        """
        return pulumi.get(self, "soft_delete_period")

    @property
    @pulumi.getter
    def statistics(self) -> 'outputs.DatabaseStatisticsResponse':
        """
        The statistics of the database.
        """
        return pulumi.get(self, "statistics")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")


class AwaitableGetReadOnlyFollowingDatabaseResult(GetReadOnlyFollowingDatabaseResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetReadOnlyFollowingDatabaseResult(
            attached_database_configuration_name=self.attached_database_configuration_name,
            hot_cache_period=self.hot_cache_period,
            id=self.id,
            kind=self.kind,
            leader_cluster_resource_id=self.leader_cluster_resource_id,
            location=self.location,
            name=self.name,
            principals_modification_kind=self.principals_modification_kind,
            provisioning_state=self.provisioning_state,
            soft_delete_period=self.soft_delete_period,
            statistics=self.statistics,
            type=self.type)


def get_read_only_following_database(cluster_name: Optional[str] = None,
                                     database_name: Optional[str] = None,
                                     resource_group_name: Optional[str] = None,
                                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetReadOnlyFollowingDatabaseResult:
    """
    Class representing a read only following database.


    :param str cluster_name: The name of the Kusto cluster.
    :param str database_name: The name of the database in the Kusto cluster.
    :param str resource_group_name: The name of the resource group containing the Kusto cluster.
    """
    __args__ = dict()
    __args__['clusterName'] = cluster_name
    __args__['databaseName'] = database_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:kusto/v20220201:getReadOnlyFollowingDatabase', __args__, opts=opts, typ=GetReadOnlyFollowingDatabaseResult).value

    return AwaitableGetReadOnlyFollowingDatabaseResult(
        attached_database_configuration_name=__ret__.attached_database_configuration_name,
        hot_cache_period=__ret__.hot_cache_period,
        id=__ret__.id,
        kind=__ret__.kind,
        leader_cluster_resource_id=__ret__.leader_cluster_resource_id,
        location=__ret__.location,
        name=__ret__.name,
        principals_modification_kind=__ret__.principals_modification_kind,
        provisioning_state=__ret__.provisioning_state,
        soft_delete_period=__ret__.soft_delete_period,
        statistics=__ret__.statistics,
        type=__ret__.type)


@_utilities.lift_output_func(get_read_only_following_database)
def get_read_only_following_database_output(cluster_name: Optional[pulumi.Input[str]] = None,
                                            database_name: Optional[pulumi.Input[str]] = None,
                                            resource_group_name: Optional[pulumi.Input[str]] = None,
                                            opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetReadOnlyFollowingDatabaseResult]:
    """
    Class representing a read only following database.


    :param str cluster_name: The name of the Kusto cluster.
    :param str database_name: The name of the database in the Kusto cluster.
    :param str resource_group_name: The name of the resource group containing the Kusto cluster.
    """
    ...
