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
    'GetEventSubscriptionResult',
    'AwaitableGetEventSubscriptionResult',
    'get_event_subscription',
    'get_event_subscription_output',
]

warnings.warn("""Version 2020-01-01-preview will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetEventSubscriptionResult:
    """
    Event Subscription
    """
    def __init__(__self__, dead_letter_destination=None, destination=None, event_delivery_schema=None, expiration_time_utc=None, filter=None, id=None, labels=None, name=None, provisioning_state=None, retry_policy=None, topic=None, type=None):
        if dead_letter_destination and not isinstance(dead_letter_destination, dict):
            raise TypeError("Expected argument 'dead_letter_destination' to be a dict")
        pulumi.set(__self__, "dead_letter_destination", dead_letter_destination)
        if destination and not isinstance(destination, dict):
            raise TypeError("Expected argument 'destination' to be a dict")
        pulumi.set(__self__, "destination", destination)
        if event_delivery_schema and not isinstance(event_delivery_schema, str):
            raise TypeError("Expected argument 'event_delivery_schema' to be a str")
        pulumi.set(__self__, "event_delivery_schema", event_delivery_schema)
        if expiration_time_utc and not isinstance(expiration_time_utc, str):
            raise TypeError("Expected argument 'expiration_time_utc' to be a str")
        pulumi.set(__self__, "expiration_time_utc", expiration_time_utc)
        if filter and not isinstance(filter, dict):
            raise TypeError("Expected argument 'filter' to be a dict")
        pulumi.set(__self__, "filter", filter)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if labels and not isinstance(labels, list):
            raise TypeError("Expected argument 'labels' to be a list")
        pulumi.set(__self__, "labels", labels)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if retry_policy and not isinstance(retry_policy, dict):
            raise TypeError("Expected argument 'retry_policy' to be a dict")
        pulumi.set(__self__, "retry_policy", retry_policy)
        if topic and not isinstance(topic, str):
            raise TypeError("Expected argument 'topic' to be a str")
        pulumi.set(__self__, "topic", topic)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="deadLetterDestination")
    def dead_letter_destination(self) -> Optional['outputs.StorageBlobDeadLetterDestinationResponse']:
        """
        The DeadLetter destination of the event subscription.
        """
        return pulumi.get(self, "dead_letter_destination")

    @property
    @pulumi.getter
    def destination(self) -> Optional[Any]:
        """
        Information about the destination where events have to be delivered for the event subscription.
        """
        return pulumi.get(self, "destination")

    @property
    @pulumi.getter(name="eventDeliverySchema")
    def event_delivery_schema(self) -> Optional[str]:
        """
        The event delivery schema for the event subscription.
        """
        return pulumi.get(self, "event_delivery_schema")

    @property
    @pulumi.getter(name="expirationTimeUtc")
    def expiration_time_utc(self) -> Optional[str]:
        """
        Expiration time of the event subscription.
        """
        return pulumi.get(self, "expiration_time_utc")

    @property
    @pulumi.getter
    def filter(self) -> Optional['outputs.EventSubscriptionFilterResponse']:
        """
        Information about the filter for the event subscription.
        """
        return pulumi.get(self, "filter")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Fully qualified identifier of the resource
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def labels(self) -> Optional[Sequence[str]]:
        """
        List of user defined labels.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        Provisioning state of the event subscription.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="retryPolicy")
    def retry_policy(self) -> Optional['outputs.RetryPolicyResponse']:
        """
        The retry policy for events. This can be used to configure maximum number of delivery attempts and time to live for events.
        """
        return pulumi.get(self, "retry_policy")

    @property
    @pulumi.getter
    def topic(self) -> str:
        """
        Name of the topic of the event subscription.
        """
        return pulumi.get(self, "topic")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Type of the resource
        """
        return pulumi.get(self, "type")


class AwaitableGetEventSubscriptionResult(GetEventSubscriptionResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetEventSubscriptionResult(
            dead_letter_destination=self.dead_letter_destination,
            destination=self.destination,
            event_delivery_schema=self.event_delivery_schema,
            expiration_time_utc=self.expiration_time_utc,
            filter=self.filter,
            id=self.id,
            labels=self.labels,
            name=self.name,
            provisioning_state=self.provisioning_state,
            retry_policy=self.retry_policy,
            topic=self.topic,
            type=self.type)


def get_event_subscription(event_subscription_name: Optional[str] = None,
                           scope: Optional[str] = None,
                           opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetEventSubscriptionResult:
    """
    Event Subscription


    :param str event_subscription_name: Name of the event subscription
    :param str scope: The scope of the event subscription. The scope can be a subscription, or a resource group, or a top level resource belonging to a resource provider namespace, or an EventGrid topic. For example, use '/subscriptions/{subscriptionId}/' for a subscription, '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for a resource group, and '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}' for a resource, and '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}' for an EventGrid topic.
    """
    pulumi.log.warn("""get_event_subscription is deprecated: Version 2020-01-01-preview will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['eventSubscriptionName'] = event_subscription_name
    __args__['scope'] = scope
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:eventgrid/v20200101preview:getEventSubscription', __args__, opts=opts, typ=GetEventSubscriptionResult).value

    return AwaitableGetEventSubscriptionResult(
        dead_letter_destination=__ret__.dead_letter_destination,
        destination=__ret__.destination,
        event_delivery_schema=__ret__.event_delivery_schema,
        expiration_time_utc=__ret__.expiration_time_utc,
        filter=__ret__.filter,
        id=__ret__.id,
        labels=__ret__.labels,
        name=__ret__.name,
        provisioning_state=__ret__.provisioning_state,
        retry_policy=__ret__.retry_policy,
        topic=__ret__.topic,
        type=__ret__.type)


@_utilities.lift_output_func(get_event_subscription)
def get_event_subscription_output(event_subscription_name: Optional[pulumi.Input[str]] = None,
                                  scope: Optional[pulumi.Input[str]] = None,
                                  opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetEventSubscriptionResult]:
    """
    Event Subscription


    :param str event_subscription_name: Name of the event subscription
    :param str scope: The scope of the event subscription. The scope can be a subscription, or a resource group, or a top level resource belonging to a resource provider namespace, or an EventGrid topic. For example, use '/subscriptions/{subscriptionId}/' for a subscription, '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for a resource group, and '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}' for a resource, and '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}' for an EventGrid topic.
    """
    pulumi.log.warn("""get_event_subscription is deprecated: Version 2020-01-01-preview will be removed in v2 of the provider.""")
    ...
