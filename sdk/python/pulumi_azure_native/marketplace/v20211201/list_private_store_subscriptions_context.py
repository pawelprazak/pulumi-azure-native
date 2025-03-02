# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'ListPrivateStoreSubscriptionsContextResult',
    'AwaitableListPrivateStoreSubscriptionsContextResult',
    'list_private_store_subscriptions_context',
    'list_private_store_subscriptions_context_output',
]

@pulumi.output_type
class ListPrivateStoreSubscriptionsContextResult:
    """
    List of subscription Ids in the private store
    """
    def __init__(__self__, subscriptions_ids=None):
        if subscriptions_ids and not isinstance(subscriptions_ids, list):
            raise TypeError("Expected argument 'subscriptions_ids' to be a list")
        pulumi.set(__self__, "subscriptions_ids", subscriptions_ids)

    @property
    @pulumi.getter(name="subscriptionsIds")
    def subscriptions_ids(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "subscriptions_ids")


class AwaitableListPrivateStoreSubscriptionsContextResult(ListPrivateStoreSubscriptionsContextResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return ListPrivateStoreSubscriptionsContextResult(
            subscriptions_ids=self.subscriptions_ids)


def list_private_store_subscriptions_context(private_store_id: Optional[str] = None,
                                             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableListPrivateStoreSubscriptionsContextResult:
    """
    List of subscription Ids in the private store


    :param str private_store_id: The store ID - must use the tenant ID
    """
    __args__ = dict()
    __args__['privateStoreId'] = private_store_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:marketplace/v20211201:listPrivateStoreSubscriptionsContext', __args__, opts=opts, typ=ListPrivateStoreSubscriptionsContextResult).value

    return AwaitableListPrivateStoreSubscriptionsContextResult(
        subscriptions_ids=__ret__.subscriptions_ids)


@_utilities.lift_output_func(list_private_store_subscriptions_context)
def list_private_store_subscriptions_context_output(private_store_id: Optional[pulumi.Input[str]] = None,
                                                    opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[ListPrivateStoreSubscriptionsContextResult]:
    """
    List of subscription Ids in the private store


    :param str private_store_id: The store ID - must use the tenant ID
    """
    ...
