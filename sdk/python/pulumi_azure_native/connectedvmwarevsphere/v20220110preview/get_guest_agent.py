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
    'GetGuestAgentResult',
    'AwaitableGetGuestAgentResult',
    'get_guest_agent',
    'get_guest_agent_output',
]

@pulumi.output_type
class GetGuestAgentResult:
    """
    Defines the GuestAgent.
    """
    def __init__(__self__, credentials=None, custom_resource_name=None, http_proxy_config=None, id=None, name=None, provisioning_action=None, provisioning_state=None, status=None, statuses=None, system_data=None, type=None, uuid=None):
        if credentials and not isinstance(credentials, dict):
            raise TypeError("Expected argument 'credentials' to be a dict")
        pulumi.set(__self__, "credentials", credentials)
        if custom_resource_name and not isinstance(custom_resource_name, str):
            raise TypeError("Expected argument 'custom_resource_name' to be a str")
        pulumi.set(__self__, "custom_resource_name", custom_resource_name)
        if http_proxy_config and not isinstance(http_proxy_config, dict):
            raise TypeError("Expected argument 'http_proxy_config' to be a dict")
        pulumi.set(__self__, "http_proxy_config", http_proxy_config)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if provisioning_action and not isinstance(provisioning_action, str):
            raise TypeError("Expected argument 'provisioning_action' to be a str")
        pulumi.set(__self__, "provisioning_action", provisioning_action)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)
        if statuses and not isinstance(statuses, list):
            raise TypeError("Expected argument 'statuses' to be a list")
        pulumi.set(__self__, "statuses", statuses)
        if system_data and not isinstance(system_data, dict):
            raise TypeError("Expected argument 'system_data' to be a dict")
        pulumi.set(__self__, "system_data", system_data)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if uuid and not isinstance(uuid, str):
            raise TypeError("Expected argument 'uuid' to be a str")
        pulumi.set(__self__, "uuid", uuid)

    @property
    @pulumi.getter
    def credentials(self) -> Optional['outputs.GuestCredentialResponse']:
        """
        Username / Password Credentials to provision guest agent.
        """
        return pulumi.get(self, "credentials")

    @property
    @pulumi.getter(name="customResourceName")
    def custom_resource_name(self) -> str:
        """
        Gets the name of the corresponding resource in Kubernetes.
        """
        return pulumi.get(self, "custom_resource_name")

    @property
    @pulumi.getter(name="httpProxyConfig")
    def http_proxy_config(self) -> Optional['outputs.HttpProxyConfigurationResponse']:
        """
        HTTP Proxy configuration for the VM.
        """
        return pulumi.get(self, "http_proxy_config")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningAction")
    def provisioning_action(self) -> Optional[str]:
        """
        Gets or sets the guest agent provisioning action.
        """
        return pulumi.get(self, "provisioning_action")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        Gets or sets the provisioning state.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        Gets or sets the guest agent status.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def statuses(self) -> Sequence['outputs.ResourceStatusResponse']:
        """
        The resource status information.
        """
        return pulumi.get(self, "statuses")

    @property
    @pulumi.getter(name="systemData")
    def system_data(self) -> 'outputs.SystemDataResponse':
        """
        The system data.
        """
        return pulumi.get(self, "system_data")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def uuid(self) -> str:
        """
        Gets or sets a unique identifier for this resource.
        """
        return pulumi.get(self, "uuid")


class AwaitableGetGuestAgentResult(GetGuestAgentResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetGuestAgentResult(
            credentials=self.credentials,
            custom_resource_name=self.custom_resource_name,
            http_proxy_config=self.http_proxy_config,
            id=self.id,
            name=self.name,
            provisioning_action=self.provisioning_action,
            provisioning_state=self.provisioning_state,
            status=self.status,
            statuses=self.statuses,
            system_data=self.system_data,
            type=self.type,
            uuid=self.uuid)


def get_guest_agent(name: Optional[str] = None,
                    resource_group_name: Optional[str] = None,
                    virtual_machine_name: Optional[str] = None,
                    opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetGuestAgentResult:
    """
    Defines the GuestAgent.


    :param str name: Name of the GuestAgent.
    :param str resource_group_name: The Resource Group Name.
    :param str virtual_machine_name: Name of the vm.
    """
    __args__ = dict()
    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    __args__['virtualMachineName'] = virtual_machine_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:connectedvmwarevsphere/v20220110preview:getGuestAgent', __args__, opts=opts, typ=GetGuestAgentResult).value

    return AwaitableGetGuestAgentResult(
        credentials=__ret__.credentials,
        custom_resource_name=__ret__.custom_resource_name,
        http_proxy_config=__ret__.http_proxy_config,
        id=__ret__.id,
        name=__ret__.name,
        provisioning_action=__ret__.provisioning_action,
        provisioning_state=__ret__.provisioning_state,
        status=__ret__.status,
        statuses=__ret__.statuses,
        system_data=__ret__.system_data,
        type=__ret__.type,
        uuid=__ret__.uuid)


@_utilities.lift_output_func(get_guest_agent)
def get_guest_agent_output(name: Optional[pulumi.Input[str]] = None,
                           resource_group_name: Optional[pulumi.Input[str]] = None,
                           virtual_machine_name: Optional[pulumi.Input[str]] = None,
                           opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetGuestAgentResult]:
    """
    Defines the GuestAgent.


    :param str name: Name of the GuestAgent.
    :param str resource_group_name: The Resource Group Name.
    :param str virtual_machine_name: Name of the vm.
    """
    ...
