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
    'GetElasticSanResult',
    'AwaitableGetElasticSanResult',
    'get_elastic_san',
    'get_elastic_san_output',
]

@pulumi.output_type
class GetElasticSanResult:
    """
    Response for ElasticSan request.
    """
    def __init__(__self__, availability_zones=None, base_size_ti_b=None, extended_capacity_size_ti_b=None, id=None, location=None, name=None, provisioning_state=None, sku=None, system_data=None, tags=None, total_iops=None, total_m_bps=None, total_size_ti_b=None, total_volume_size_gi_b=None, type=None, volume_group_count=None):
        if availability_zones and not isinstance(availability_zones, list):
            raise TypeError("Expected argument 'availability_zones' to be a list")
        pulumi.set(__self__, "availability_zones", availability_zones)
        if base_size_ti_b and not isinstance(base_size_ti_b, float):
            raise TypeError("Expected argument 'base_size_ti_b' to be a float")
        pulumi.set(__self__, "base_size_ti_b", base_size_ti_b)
        if extended_capacity_size_ti_b and not isinstance(extended_capacity_size_ti_b, float):
            raise TypeError("Expected argument 'extended_capacity_size_ti_b' to be a float")
        pulumi.set(__self__, "extended_capacity_size_ti_b", extended_capacity_size_ti_b)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if sku and not isinstance(sku, dict):
            raise TypeError("Expected argument 'sku' to be a dict")
        pulumi.set(__self__, "sku", sku)
        if system_data and not isinstance(system_data, dict):
            raise TypeError("Expected argument 'system_data' to be a dict")
        pulumi.set(__self__, "system_data", system_data)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if total_iops and not isinstance(total_iops, float):
            raise TypeError("Expected argument 'total_iops' to be a float")
        pulumi.set(__self__, "total_iops", total_iops)
        if total_m_bps and not isinstance(total_m_bps, float):
            raise TypeError("Expected argument 'total_m_bps' to be a float")
        pulumi.set(__self__, "total_m_bps", total_m_bps)
        if total_size_ti_b and not isinstance(total_size_ti_b, float):
            raise TypeError("Expected argument 'total_size_ti_b' to be a float")
        pulumi.set(__self__, "total_size_ti_b", total_size_ti_b)
        if total_volume_size_gi_b and not isinstance(total_volume_size_gi_b, float):
            raise TypeError("Expected argument 'total_volume_size_gi_b' to be a float")
        pulumi.set(__self__, "total_volume_size_gi_b", total_volume_size_gi_b)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if volume_group_count and not isinstance(volume_group_count, float):
            raise TypeError("Expected argument 'volume_group_count' to be a float")
        pulumi.set(__self__, "volume_group_count", volume_group_count)

    @property
    @pulumi.getter(name="availabilityZones")
    def availability_zones(self) -> Sequence[str]:
        """
        Logical zone for Elastic San resource; example: ["1"].
        """
        return pulumi.get(self, "availability_zones")

    @property
    @pulumi.getter(name="baseSizeTiB")
    def base_size_ti_b(self) -> float:
        """
        Base size of the Elastic San appliance in TiB.
        """
        return pulumi.get(self, "base_size_ti_b")

    @property
    @pulumi.getter(name="extendedCapacitySizeTiB")
    def extended_capacity_size_ti_b(self) -> float:
        """
        Extended size of the Elastic San appliance in TiB.
        """
        return pulumi.get(self, "extended_capacity_size_ti_b")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Azure resource identifier.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        The geo-location where the resource lives.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Azure resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        State of the operation on the resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def sku(self) -> Optional['outputs.SkuResponse']:
        """
        resource sku
        """
        return pulumi.get(self, "sku")

    @property
    @pulumi.getter(name="systemData")
    def system_data(self) -> 'outputs.SystemDataResponse':
        """
        Resource metadata required by ARM RPC
        """
        return pulumi.get(self, "system_data")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Azure resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="totalIops")
    def total_iops(self) -> float:
        """
        Total Provisioned IOPS of the Elastic San appliance.
        """
        return pulumi.get(self, "total_iops")

    @property
    @pulumi.getter(name="totalMBps")
    def total_m_bps(self) -> float:
        """
        Total Provisioned MBps Elastic San appliance.
        """
        return pulumi.get(self, "total_m_bps")

    @property
    @pulumi.getter(name="totalSizeTiB")
    def total_size_ti_b(self) -> float:
        """
        Total size of the Elastic San appliance in TB.
        """
        return pulumi.get(self, "total_size_ti_b")

    @property
    @pulumi.getter(name="totalVolumeSizeGiB")
    def total_volume_size_gi_b(self) -> float:
        """
        Total size of the provisioned Volumes in GiB.
        """
        return pulumi.get(self, "total_volume_size_gi_b")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Azure resource type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="volumeGroupCount")
    def volume_group_count(self) -> float:
        """
        Total number of volume groups in this Elastic San appliance.
        """
        return pulumi.get(self, "volume_group_count")


class AwaitableGetElasticSanResult(GetElasticSanResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetElasticSanResult(
            availability_zones=self.availability_zones,
            base_size_ti_b=self.base_size_ti_b,
            extended_capacity_size_ti_b=self.extended_capacity_size_ti_b,
            id=self.id,
            location=self.location,
            name=self.name,
            provisioning_state=self.provisioning_state,
            sku=self.sku,
            system_data=self.system_data,
            tags=self.tags,
            total_iops=self.total_iops,
            total_m_bps=self.total_m_bps,
            total_size_ti_b=self.total_size_ti_b,
            total_volume_size_gi_b=self.total_volume_size_gi_b,
            type=self.type,
            volume_group_count=self.volume_group_count)


def get_elastic_san(elastic_san_name: Optional[str] = None,
                    resource_group_name: Optional[str] = None,
                    opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetElasticSanResult:
    """
    Response for ElasticSan request.


    :param str elastic_san_name: The name of the ElasticSan.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    """
    __args__ = dict()
    __args__['elasticSanName'] = elastic_san_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:elasticsan/v20211120preview:getElasticSan', __args__, opts=opts, typ=GetElasticSanResult).value

    return AwaitableGetElasticSanResult(
        availability_zones=__ret__.availability_zones,
        base_size_ti_b=__ret__.base_size_ti_b,
        extended_capacity_size_ti_b=__ret__.extended_capacity_size_ti_b,
        id=__ret__.id,
        location=__ret__.location,
        name=__ret__.name,
        provisioning_state=__ret__.provisioning_state,
        sku=__ret__.sku,
        system_data=__ret__.system_data,
        tags=__ret__.tags,
        total_iops=__ret__.total_iops,
        total_m_bps=__ret__.total_m_bps,
        total_size_ti_b=__ret__.total_size_ti_b,
        total_volume_size_gi_b=__ret__.total_volume_size_gi_b,
        type=__ret__.type,
        volume_group_count=__ret__.volume_group_count)


@_utilities.lift_output_func(get_elastic_san)
def get_elastic_san_output(elastic_san_name: Optional[pulumi.Input[str]] = None,
                           resource_group_name: Optional[pulumi.Input[str]] = None,
                           opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetElasticSanResult]:
    """
    Response for ElasticSan request.


    :param str elastic_san_name: The name of the ElasticSan.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    """
    ...
