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
    'GetChannelResult',
    'AwaitableGetChannelResult',
    'get_channel',
    'get_channel_output',
]

@pulumi.output_type
class GetChannelResult:
    """
    Channel info.
    """
    def __init__(__self__, channel_type=None, expiration_time_if_not_activated_utc=None, id=None, message_for_activation=None, name=None, partner_topic_info=None, provisioning_state=None, readiness_state=None, system_data=None, type=None):
        if channel_type and not isinstance(channel_type, str):
            raise TypeError("Expected argument 'channel_type' to be a str")
        pulumi.set(__self__, "channel_type", channel_type)
        if expiration_time_if_not_activated_utc and not isinstance(expiration_time_if_not_activated_utc, str):
            raise TypeError("Expected argument 'expiration_time_if_not_activated_utc' to be a str")
        pulumi.set(__self__, "expiration_time_if_not_activated_utc", expiration_time_if_not_activated_utc)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if message_for_activation and not isinstance(message_for_activation, str):
            raise TypeError("Expected argument 'message_for_activation' to be a str")
        pulumi.set(__self__, "message_for_activation", message_for_activation)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if partner_topic_info and not isinstance(partner_topic_info, dict):
            raise TypeError("Expected argument 'partner_topic_info' to be a dict")
        pulumi.set(__self__, "partner_topic_info", partner_topic_info)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if readiness_state and not isinstance(readiness_state, str):
            raise TypeError("Expected argument 'readiness_state' to be a str")
        pulumi.set(__self__, "readiness_state", readiness_state)
        if system_data and not isinstance(system_data, dict):
            raise TypeError("Expected argument 'system_data' to be a dict")
        pulumi.set(__self__, "system_data", system_data)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="channelType")
    def channel_type(self) -> Optional[str]:
        """
        The type of the event channel which represents the direction flow of events.
        """
        return pulumi.get(self, "channel_type")

    @property
    @pulumi.getter(name="expirationTimeIfNotActivatedUtc")
    def expiration_time_if_not_activated_utc(self) -> Optional[str]:
        """
        Expiration time of the channel. If this timer expires while the corresponding partner topic is never activated,
        the channel and corresponding partner topic are deleted.
        """
        return pulumi.get(self, "expiration_time_if_not_activated_utc")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Fully qualified identifier of the resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="messageForActivation")
    def message_for_activation(self) -> Optional[str]:
        """
        Context or helpful message that can be used during the approval process by the subscriber.
        """
        return pulumi.get(self, "message_for_activation")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of the resource.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="partnerTopicInfo")
    def partner_topic_info(self) -> Optional['outputs.PartnerTopicInfoResponse']:
        """
        This property should be populated when channelType is PartnerTopic and represents information about the partner topic resource corresponding to the channel.
        """
        return pulumi.get(self, "partner_topic_info")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> Optional[str]:
        """
        Provisioning state of the channel.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="readinessState")
    def readiness_state(self) -> Optional[str]:
        """
        The readiness state of the corresponding partner topic.
        """
        return pulumi.get(self, "readiness_state")

    @property
    @pulumi.getter(name="systemData")
    def system_data(self) -> 'outputs.SystemDataResponse':
        """
        The system metadata relating to Channel resource.
        """
        return pulumi.get(self, "system_data")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Type of the resource.
        """
        return pulumi.get(self, "type")


class AwaitableGetChannelResult(GetChannelResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetChannelResult(
            channel_type=self.channel_type,
            expiration_time_if_not_activated_utc=self.expiration_time_if_not_activated_utc,
            id=self.id,
            message_for_activation=self.message_for_activation,
            name=self.name,
            partner_topic_info=self.partner_topic_info,
            provisioning_state=self.provisioning_state,
            readiness_state=self.readiness_state,
            system_data=self.system_data,
            type=self.type)


def get_channel(channel_name: Optional[str] = None,
                partner_namespace_name: Optional[str] = None,
                resource_group_name: Optional[str] = None,
                opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetChannelResult:
    """
    Channel info.


    :param str channel_name: Name of the channel.
    :param str partner_namespace_name: Name of the partner namespace.
    :param str resource_group_name: The name of the resource group within the partners subscription.
    """
    __args__ = dict()
    __args__['channelName'] = channel_name
    __args__['partnerNamespaceName'] = partner_namespace_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:eventgrid/v20220615:getChannel', __args__, opts=opts, typ=GetChannelResult).value

    return AwaitableGetChannelResult(
        channel_type=__ret__.channel_type,
        expiration_time_if_not_activated_utc=__ret__.expiration_time_if_not_activated_utc,
        id=__ret__.id,
        message_for_activation=__ret__.message_for_activation,
        name=__ret__.name,
        partner_topic_info=__ret__.partner_topic_info,
        provisioning_state=__ret__.provisioning_state,
        readiness_state=__ret__.readiness_state,
        system_data=__ret__.system_data,
        type=__ret__.type)


@_utilities.lift_output_func(get_channel)
def get_channel_output(channel_name: Optional[pulumi.Input[str]] = None,
                       partner_namespace_name: Optional[pulumi.Input[str]] = None,
                       resource_group_name: Optional[pulumi.Input[str]] = None,
                       opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetChannelResult]:
    """
    Channel info.


    :param str channel_name: Name of the channel.
    :param str partner_namespace_name: Name of the partner namespace.
    :param str resource_group_name: The name of the resource group within the partners subscription.
    """
    ...
