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
    'GetSubscriptionResult',
    'AwaitableGetSubscriptionResult',
    'get_subscription',
    'get_subscription_output',
]

warnings.warn("""Version 2014-09-01 will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetSubscriptionResult:
    """
    Description of subscription resource.
    """
    def __init__(__self__, accessed_at=None, auto_delete_on_idle=None, count_details=None, created_at=None, dead_lettering_on_filter_evaluation_exceptions=None, dead_lettering_on_message_expiration=None, default_message_time_to_live=None, enable_batched_operations=None, entity_availability_status=None, id=None, is_read_only=None, location=None, lock_duration=None, max_delivery_count=None, message_count=None, name=None, requires_session=None, status=None, type=None, updated_at=None):
        if accessed_at and not isinstance(accessed_at, str):
            raise TypeError("Expected argument 'accessed_at' to be a str")
        pulumi.set(__self__, "accessed_at", accessed_at)
        if auto_delete_on_idle and not isinstance(auto_delete_on_idle, str):
            raise TypeError("Expected argument 'auto_delete_on_idle' to be a str")
        pulumi.set(__self__, "auto_delete_on_idle", auto_delete_on_idle)
        if count_details and not isinstance(count_details, dict):
            raise TypeError("Expected argument 'count_details' to be a dict")
        pulumi.set(__self__, "count_details", count_details)
        if created_at and not isinstance(created_at, str):
            raise TypeError("Expected argument 'created_at' to be a str")
        pulumi.set(__self__, "created_at", created_at)
        if dead_lettering_on_filter_evaluation_exceptions and not isinstance(dead_lettering_on_filter_evaluation_exceptions, bool):
            raise TypeError("Expected argument 'dead_lettering_on_filter_evaluation_exceptions' to be a bool")
        pulumi.set(__self__, "dead_lettering_on_filter_evaluation_exceptions", dead_lettering_on_filter_evaluation_exceptions)
        if dead_lettering_on_message_expiration and not isinstance(dead_lettering_on_message_expiration, bool):
            raise TypeError("Expected argument 'dead_lettering_on_message_expiration' to be a bool")
        pulumi.set(__self__, "dead_lettering_on_message_expiration", dead_lettering_on_message_expiration)
        if default_message_time_to_live and not isinstance(default_message_time_to_live, str):
            raise TypeError("Expected argument 'default_message_time_to_live' to be a str")
        pulumi.set(__self__, "default_message_time_to_live", default_message_time_to_live)
        if enable_batched_operations and not isinstance(enable_batched_operations, bool):
            raise TypeError("Expected argument 'enable_batched_operations' to be a bool")
        pulumi.set(__self__, "enable_batched_operations", enable_batched_operations)
        if entity_availability_status and not isinstance(entity_availability_status, str):
            raise TypeError("Expected argument 'entity_availability_status' to be a str")
        pulumi.set(__self__, "entity_availability_status", entity_availability_status)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if is_read_only and not isinstance(is_read_only, bool):
            raise TypeError("Expected argument 'is_read_only' to be a bool")
        pulumi.set(__self__, "is_read_only", is_read_only)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if lock_duration and not isinstance(lock_duration, str):
            raise TypeError("Expected argument 'lock_duration' to be a str")
        pulumi.set(__self__, "lock_duration", lock_duration)
        if max_delivery_count and not isinstance(max_delivery_count, int):
            raise TypeError("Expected argument 'max_delivery_count' to be a int")
        pulumi.set(__self__, "max_delivery_count", max_delivery_count)
        if message_count and not isinstance(message_count, float):
            raise TypeError("Expected argument 'message_count' to be a float")
        pulumi.set(__self__, "message_count", message_count)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if requires_session and not isinstance(requires_session, bool):
            raise TypeError("Expected argument 'requires_session' to be a bool")
        pulumi.set(__self__, "requires_session", requires_session)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if updated_at and not isinstance(updated_at, str):
            raise TypeError("Expected argument 'updated_at' to be a str")
        pulumi.set(__self__, "updated_at", updated_at)

    @property
    @pulumi.getter(name="accessedAt")
    def accessed_at(self) -> str:
        """
        Last time there was a receive request to this subscription.
        """
        return pulumi.get(self, "accessed_at")

    @property
    @pulumi.getter(name="autoDeleteOnIdle")
    def auto_delete_on_idle(self) -> Optional[str]:
        """
        TimeSpan idle interval after which the topic is automatically deleted. The minimum duration is 5 minutes.
        """
        return pulumi.get(self, "auto_delete_on_idle")

    @property
    @pulumi.getter(name="countDetails")
    def count_details(self) -> 'outputs.MessageCountDetailsResponse':
        """
        Message Count Details.
        """
        return pulumi.get(self, "count_details")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> str:
        """
        Exact time the message was created.
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter(name="deadLetteringOnFilterEvaluationExceptions")
    def dead_lettering_on_filter_evaluation_exceptions(self) -> Optional[bool]:
        """
        Value that indicates whether a subscription has dead letter support on filter evaluation exceptions.
        """
        return pulumi.get(self, "dead_lettering_on_filter_evaluation_exceptions")

    @property
    @pulumi.getter(name="deadLetteringOnMessageExpiration")
    def dead_lettering_on_message_expiration(self) -> Optional[bool]:
        """
        Value that indicates whether a subscription has dead letter support when a message expires.
        """
        return pulumi.get(self, "dead_lettering_on_message_expiration")

    @property
    @pulumi.getter(name="defaultMessageTimeToLive")
    def default_message_time_to_live(self) -> Optional[str]:
        """
        Default message time to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself.
        """
        return pulumi.get(self, "default_message_time_to_live")

    @property
    @pulumi.getter(name="enableBatchedOperations")
    def enable_batched_operations(self) -> Optional[bool]:
        """
        Value that indicates whether server-side batched operations are enabled.
        """
        return pulumi.get(self, "enable_batched_operations")

    @property
    @pulumi.getter(name="entityAvailabilityStatus")
    def entity_availability_status(self) -> Optional[str]:
        """
        Entity availability status for the topic.
        """
        return pulumi.get(self, "entity_availability_status")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Resource Id
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="isReadOnly")
    def is_read_only(self) -> Optional[bool]:
        """
        Value that indicates whether the entity description is read-only.
        """
        return pulumi.get(self, "is_read_only")

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        Resource location.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="lockDuration")
    def lock_duration(self) -> Optional[str]:
        """
        The lock duration time span for the subscription.
        """
        return pulumi.get(self, "lock_duration")

    @property
    @pulumi.getter(name="maxDeliveryCount")
    def max_delivery_count(self) -> Optional[int]:
        """
        Number of maximum deliveries.
        """
        return pulumi.get(self, "max_delivery_count")

    @property
    @pulumi.getter(name="messageCount")
    def message_count(self) -> float:
        """
        Number of messages.
        """
        return pulumi.get(self, "message_count")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="requiresSession")
    def requires_session(self) -> Optional[bool]:
        """
        Value indicating if a subscription supports the concept of sessions.
        """
        return pulumi.get(self, "requires_session")

    @property
    @pulumi.getter
    def status(self) -> Optional[str]:
        """
        Enumerates the possible values for the status of a messaging entity.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="updatedAt")
    def updated_at(self) -> str:
        """
        The exact time the message was updated.
        """
        return pulumi.get(self, "updated_at")


class AwaitableGetSubscriptionResult(GetSubscriptionResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSubscriptionResult(
            accessed_at=self.accessed_at,
            auto_delete_on_idle=self.auto_delete_on_idle,
            count_details=self.count_details,
            created_at=self.created_at,
            dead_lettering_on_filter_evaluation_exceptions=self.dead_lettering_on_filter_evaluation_exceptions,
            dead_lettering_on_message_expiration=self.dead_lettering_on_message_expiration,
            default_message_time_to_live=self.default_message_time_to_live,
            enable_batched_operations=self.enable_batched_operations,
            entity_availability_status=self.entity_availability_status,
            id=self.id,
            is_read_only=self.is_read_only,
            location=self.location,
            lock_duration=self.lock_duration,
            max_delivery_count=self.max_delivery_count,
            message_count=self.message_count,
            name=self.name,
            requires_session=self.requires_session,
            status=self.status,
            type=self.type,
            updated_at=self.updated_at)


def get_subscription(namespace_name: Optional[str] = None,
                     resource_group_name: Optional[str] = None,
                     subscription_name: Optional[str] = None,
                     topic_name: Optional[str] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetSubscriptionResult:
    """
    Description of subscription resource.


    :param str namespace_name: The namespace name
    :param str resource_group_name: Name of the Resource group within the Azure subscription.
    :param str subscription_name: The subscription name.
    :param str topic_name: The topic name.
    """
    pulumi.log.warn("""get_subscription is deprecated: Version 2014-09-01 will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['namespaceName'] = namespace_name
    __args__['resourceGroupName'] = resource_group_name
    __args__['subscriptionName'] = subscription_name
    __args__['topicName'] = topic_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:servicebus/v20140901:getSubscription', __args__, opts=opts, typ=GetSubscriptionResult).value

    return AwaitableGetSubscriptionResult(
        accessed_at=__ret__.accessed_at,
        auto_delete_on_idle=__ret__.auto_delete_on_idle,
        count_details=__ret__.count_details,
        created_at=__ret__.created_at,
        dead_lettering_on_filter_evaluation_exceptions=__ret__.dead_lettering_on_filter_evaluation_exceptions,
        dead_lettering_on_message_expiration=__ret__.dead_lettering_on_message_expiration,
        default_message_time_to_live=__ret__.default_message_time_to_live,
        enable_batched_operations=__ret__.enable_batched_operations,
        entity_availability_status=__ret__.entity_availability_status,
        id=__ret__.id,
        is_read_only=__ret__.is_read_only,
        location=__ret__.location,
        lock_duration=__ret__.lock_duration,
        max_delivery_count=__ret__.max_delivery_count,
        message_count=__ret__.message_count,
        name=__ret__.name,
        requires_session=__ret__.requires_session,
        status=__ret__.status,
        type=__ret__.type,
        updated_at=__ret__.updated_at)


@_utilities.lift_output_func(get_subscription)
def get_subscription_output(namespace_name: Optional[pulumi.Input[str]] = None,
                            resource_group_name: Optional[pulumi.Input[str]] = None,
                            subscription_name: Optional[pulumi.Input[str]] = None,
                            topic_name: Optional[pulumi.Input[str]] = None,
                            opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetSubscriptionResult]:
    """
    Description of subscription resource.


    :param str namespace_name: The namespace name
    :param str resource_group_name: Name of the Resource group within the Azure subscription.
    :param str subscription_name: The subscription name.
    :param str topic_name: The topic name.
    """
    pulumi.log.warn("""get_subscription is deprecated: Version 2014-09-01 will be removed in v2 of the provider.""")
    ...
