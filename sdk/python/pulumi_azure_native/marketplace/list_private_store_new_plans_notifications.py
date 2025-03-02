# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs

__all__ = [
    'ListPrivateStoreNewPlansNotificationsResult',
    'AwaitableListPrivateStoreNewPlansNotificationsResult',
    'list_private_store_new_plans_notifications',
    'list_private_store_new_plans_notifications_output',
]

@pulumi.output_type
class ListPrivateStoreNewPlansNotificationsResult:
    """
    List of all new plans notifications for public offers
    """
    def __init__(__self__, new_plans_notifications=None):
        if new_plans_notifications and not isinstance(new_plans_notifications, list):
            raise TypeError("Expected argument 'new_plans_notifications' to be a list")
        pulumi.set(__self__, "new_plans_notifications", new_plans_notifications)

    @property
    @pulumi.getter(name="newPlansNotifications")
    def new_plans_notifications(self) -> Optional[Sequence['outputs.NewNotificationsResponse']]:
        return pulumi.get(self, "new_plans_notifications")


class AwaitableListPrivateStoreNewPlansNotificationsResult(ListPrivateStoreNewPlansNotificationsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return ListPrivateStoreNewPlansNotificationsResult(
            new_plans_notifications=self.new_plans_notifications)


def list_private_store_new_plans_notifications(private_store_id: Optional[str] = None,
                                               opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableListPrivateStoreNewPlansNotificationsResult:
    """
    List of all new plans notifications for public offers
    API Version: 2021-12-01.


    :param str private_store_id: The store ID - must use the tenant ID
    """
    __args__ = dict()
    __args__['privateStoreId'] = private_store_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:marketplace:listPrivateStoreNewPlansNotifications', __args__, opts=opts, typ=ListPrivateStoreNewPlansNotificationsResult).value

    return AwaitableListPrivateStoreNewPlansNotificationsResult(
        new_plans_notifications=__ret__.new_plans_notifications)


@_utilities.lift_output_func(list_private_store_new_plans_notifications)
def list_private_store_new_plans_notifications_output(private_store_id: Optional[pulumi.Input[str]] = None,
                                                      opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[ListPrivateStoreNewPlansNotificationsResult]:
    """
    List of all new plans notifications for public offers
    API Version: 2021-12-01.


    :param str private_store_id: The store ID - must use the tenant ID
    """
    ...
