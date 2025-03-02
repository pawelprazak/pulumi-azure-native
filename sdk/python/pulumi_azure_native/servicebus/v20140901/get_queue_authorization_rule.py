# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'GetQueueAuthorizationRuleResult',
    'AwaitableGetQueueAuthorizationRuleResult',
    'get_queue_authorization_rule',
    'get_queue_authorization_rule_output',
]

warnings.warn("""Version 2014-09-01 will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetQueueAuthorizationRuleResult:
    """
    Description of a namespace authorization rule.
    """
    def __init__(__self__, id=None, location=None, name=None, rights=None, type=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if rights and not isinstance(rights, list):
            raise TypeError("Expected argument 'rights' to be a list")
        pulumi.set(__self__, "rights", rights)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Resource Id
        """
        return pulumi.get(self, "id")

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
        Resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def rights(self) -> Sequence[str]:
        """
        The rights associated with the rule.
        """
        return pulumi.get(self, "rights")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type
        """
        return pulumi.get(self, "type")


class AwaitableGetQueueAuthorizationRuleResult(GetQueueAuthorizationRuleResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetQueueAuthorizationRuleResult(
            id=self.id,
            location=self.location,
            name=self.name,
            rights=self.rights,
            type=self.type)


def get_queue_authorization_rule(authorization_rule_name: Optional[str] = None,
                                 namespace_name: Optional[str] = None,
                                 queue_name: Optional[str] = None,
                                 resource_group_name: Optional[str] = None,
                                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetQueueAuthorizationRuleResult:
    """
    Description of a namespace authorization rule.


    :param str authorization_rule_name: The authorization rule name.
    :param str namespace_name: The namespace name
    :param str queue_name: The queue name.
    :param str resource_group_name: Name of the Resource group within the Azure subscription.
    """
    pulumi.log.warn("""get_queue_authorization_rule is deprecated: Version 2014-09-01 will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['authorizationRuleName'] = authorization_rule_name
    __args__['namespaceName'] = namespace_name
    __args__['queueName'] = queue_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:servicebus/v20140901:getQueueAuthorizationRule', __args__, opts=opts, typ=GetQueueAuthorizationRuleResult).value

    return AwaitableGetQueueAuthorizationRuleResult(
        id=__ret__.id,
        location=__ret__.location,
        name=__ret__.name,
        rights=__ret__.rights,
        type=__ret__.type)


@_utilities.lift_output_func(get_queue_authorization_rule)
def get_queue_authorization_rule_output(authorization_rule_name: Optional[pulumi.Input[str]] = None,
                                        namespace_name: Optional[pulumi.Input[str]] = None,
                                        queue_name: Optional[pulumi.Input[str]] = None,
                                        resource_group_name: Optional[pulumi.Input[str]] = None,
                                        opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetQueueAuthorizationRuleResult]:
    """
    Description of a namespace authorization rule.


    :param str authorization_rule_name: The authorization rule name.
    :param str namespace_name: The namespace name
    :param str queue_name: The queue name.
    :param str resource_group_name: Name of the Resource group within the Azure subscription.
    """
    pulumi.log.warn("""get_queue_authorization_rule is deprecated: Version 2014-09-01 will be removed in v2 of the provider.""")
    ...
