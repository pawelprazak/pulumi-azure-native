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
    'GetEntityInsightsResult',
    'AwaitableGetEntityInsightsResult',
    'get_entity_insights',
    'get_entity_insights_output',
]

@pulumi.output_type
class GetEntityInsightsResult:
    """
    The Get Insights result operation response.
    """
    def __init__(__self__, meta_data=None, value=None):
        if meta_data and not isinstance(meta_data, dict):
            raise TypeError("Expected argument 'meta_data' to be a dict")
        pulumi.set(__self__, "meta_data", meta_data)
        if value and not isinstance(value, list):
            raise TypeError("Expected argument 'value' to be a list")
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter(name="metaData")
    def meta_data(self) -> Optional['outputs.GetInsightsResultsMetadataResponse']:
        """
        The metadata from the get insights operation results.
        """
        return pulumi.get(self, "meta_data")

    @property
    @pulumi.getter
    def value(self) -> Optional[Sequence['outputs.EntityInsightItemResponse']]:
        """
        The insights result values.
        """
        return pulumi.get(self, "value")


class AwaitableGetEntityInsightsResult(GetEntityInsightsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetEntityInsightsResult(
            meta_data=self.meta_data,
            value=self.value)


def get_entity_insights(add_default_extended_time_range: Optional[bool] = None,
                        end_time: Optional[str] = None,
                        entity_id: Optional[str] = None,
                        insight_query_ids: Optional[Sequence[str]] = None,
                        resource_group_name: Optional[str] = None,
                        start_time: Optional[str] = None,
                        workspace_name: Optional[str] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetEntityInsightsResult:
    """
    The Get Insights result operation response.


    :param bool add_default_extended_time_range: Indicates if query time range should be extended with default time range of the query. Default value is false
    :param str end_time: The end timeline date, so the results returned are before this date.
    :param str entity_id: entity ID
    :param Sequence[str] insight_query_ids: List of Insights Query Id. If empty, default value is all insights of this entity
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    :param str start_time: The start timeline date, so the results returned are after this date.
    :param str workspace_name: The name of the workspace.
    """
    __args__ = dict()
    __args__['addDefaultExtendedTimeRange'] = add_default_extended_time_range
    __args__['endTime'] = end_time
    __args__['entityId'] = entity_id
    __args__['insightQueryIds'] = insight_query_ids
    __args__['resourceGroupName'] = resource_group_name
    __args__['startTime'] = start_time
    __args__['workspaceName'] = workspace_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:securityinsights/v20220701preview:getEntityInsights', __args__, opts=opts, typ=GetEntityInsightsResult).value

    return AwaitableGetEntityInsightsResult(
        meta_data=__ret__.meta_data,
        value=__ret__.value)


@_utilities.lift_output_func(get_entity_insights)
def get_entity_insights_output(add_default_extended_time_range: Optional[pulumi.Input[Optional[bool]]] = None,
                               end_time: Optional[pulumi.Input[str]] = None,
                               entity_id: Optional[pulumi.Input[str]] = None,
                               insight_query_ids: Optional[pulumi.Input[Optional[Sequence[str]]]] = None,
                               resource_group_name: Optional[pulumi.Input[str]] = None,
                               start_time: Optional[pulumi.Input[str]] = None,
                               workspace_name: Optional[pulumi.Input[str]] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetEntityInsightsResult]:
    """
    The Get Insights result operation response.


    :param bool add_default_extended_time_range: Indicates if query time range should be extended with default time range of the query. Default value is false
    :param str end_time: The end timeline date, so the results returned are before this date.
    :param str entity_id: entity ID
    :param Sequence[str] insight_query_ids: List of Insights Query Id. If empty, default value is all insights of this entity
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    :param str start_time: The start timeline date, so the results returned are after this date.
    :param str workspace_name: The name of the workspace.
    """
    ...
