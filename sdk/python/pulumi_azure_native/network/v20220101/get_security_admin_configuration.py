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
    'GetSecurityAdminConfigurationResult',
    'AwaitableGetSecurityAdminConfigurationResult',
    'get_security_admin_configuration',
    'get_security_admin_configuration_output',
]

@pulumi.output_type
class GetSecurityAdminConfigurationResult:
    """
    Defines the security admin configuration
    """
    def __init__(__self__, apply_on_network_intent_policy_based_services=None, description=None, etag=None, id=None, name=None, provisioning_state=None, system_data=None, type=None):
        if apply_on_network_intent_policy_based_services and not isinstance(apply_on_network_intent_policy_based_services, list):
            raise TypeError("Expected argument 'apply_on_network_intent_policy_based_services' to be a list")
        pulumi.set(__self__, "apply_on_network_intent_policy_based_services", apply_on_network_intent_policy_based_services)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if etag and not isinstance(etag, str):
            raise TypeError("Expected argument 'etag' to be a str")
        pulumi.set(__self__, "etag", etag)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if system_data and not isinstance(system_data, dict):
            raise TypeError("Expected argument 'system_data' to be a dict")
        pulumi.set(__self__, "system_data", system_data)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="applyOnNetworkIntentPolicyBasedServices")
    def apply_on_network_intent_policy_based_services(self) -> Optional[Sequence[str]]:
        """
        Enum list of network intent policy based services.
        """
        return pulumi.get(self, "apply_on_network_intent_policy_based_services")

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        """
        A description of the security configuration.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def etag(self) -> str:
        """
        A unique read-only string that changes whenever the resource is updated.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Resource ID.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        The provisioning state of the resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="systemData")
    def system_data(self) -> 'outputs.SystemDataResponse':
        """
        The system metadata related to this resource.
        """
        return pulumi.get(self, "system_data")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type.
        """
        return pulumi.get(self, "type")


class AwaitableGetSecurityAdminConfigurationResult(GetSecurityAdminConfigurationResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSecurityAdminConfigurationResult(
            apply_on_network_intent_policy_based_services=self.apply_on_network_intent_policy_based_services,
            description=self.description,
            etag=self.etag,
            id=self.id,
            name=self.name,
            provisioning_state=self.provisioning_state,
            system_data=self.system_data,
            type=self.type)


def get_security_admin_configuration(configuration_name: Optional[str] = None,
                                     network_manager_name: Optional[str] = None,
                                     resource_group_name: Optional[str] = None,
                                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetSecurityAdminConfigurationResult:
    """
    Defines the security admin configuration


    :param str configuration_name: The name of the network manager Security Configuration.
    :param str network_manager_name: The name of the network manager.
    :param str resource_group_name: The name of the resource group.
    """
    __args__ = dict()
    __args__['configurationName'] = configuration_name
    __args__['networkManagerName'] = network_manager_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:network/v20220101:getSecurityAdminConfiguration', __args__, opts=opts, typ=GetSecurityAdminConfigurationResult).value

    return AwaitableGetSecurityAdminConfigurationResult(
        apply_on_network_intent_policy_based_services=__ret__.apply_on_network_intent_policy_based_services,
        description=__ret__.description,
        etag=__ret__.etag,
        id=__ret__.id,
        name=__ret__.name,
        provisioning_state=__ret__.provisioning_state,
        system_data=__ret__.system_data,
        type=__ret__.type)


@_utilities.lift_output_func(get_security_admin_configuration)
def get_security_admin_configuration_output(configuration_name: Optional[pulumi.Input[str]] = None,
                                            network_manager_name: Optional[pulumi.Input[str]] = None,
                                            resource_group_name: Optional[pulumi.Input[str]] = None,
                                            opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetSecurityAdminConfigurationResult]:
    """
    Defines the security admin configuration


    :param str configuration_name: The name of the network manager Security Configuration.
    :param str network_manager_name: The name of the network manager.
    :param str resource_group_name: The name of the resource group.
    """
    ...
