# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'GetServerEndpointResult',
    'AwaitableGetServerEndpointResult',
    'get_server_endpoint',
    'get_server_endpoint_output',
]

warnings.warn("""Version 2018-04-02 will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetServerEndpointResult:
    """
    Server Endpoint object.
    """
    def __init__(__self__, cloud_tiering=None, friendly_name=None, id=None, last_operation_name=None, last_workflow_id=None, name=None, provisioning_state=None, server_local_path=None, server_resource_id=None, sync_status=None, type=None, volume_free_space_percent=None):
        if cloud_tiering and not isinstance(cloud_tiering, str):
            raise TypeError("Expected argument 'cloud_tiering' to be a str")
        pulumi.set(__self__, "cloud_tiering", cloud_tiering)
        if friendly_name and not isinstance(friendly_name, str):
            raise TypeError("Expected argument 'friendly_name' to be a str")
        pulumi.set(__self__, "friendly_name", friendly_name)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if last_operation_name and not isinstance(last_operation_name, str):
            raise TypeError("Expected argument 'last_operation_name' to be a str")
        pulumi.set(__self__, "last_operation_name", last_operation_name)
        if last_workflow_id and not isinstance(last_workflow_id, str):
            raise TypeError("Expected argument 'last_workflow_id' to be a str")
        pulumi.set(__self__, "last_workflow_id", last_workflow_id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if server_local_path and not isinstance(server_local_path, str):
            raise TypeError("Expected argument 'server_local_path' to be a str")
        pulumi.set(__self__, "server_local_path", server_local_path)
        if server_resource_id and not isinstance(server_resource_id, str):
            raise TypeError("Expected argument 'server_resource_id' to be a str")
        pulumi.set(__self__, "server_resource_id", server_resource_id)
        if sync_status and not isinstance(sync_status, dict):
            raise TypeError("Expected argument 'sync_status' to be a dict")
        pulumi.set(__self__, "sync_status", sync_status)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if volume_free_space_percent and not isinstance(volume_free_space_percent, int):
            raise TypeError("Expected argument 'volume_free_space_percent' to be a int")
        pulumi.set(__self__, "volume_free_space_percent", volume_free_space_percent)

    @property
    @pulumi.getter(name="cloudTiering")
    def cloud_tiering(self) -> Optional[str]:
        """
        Cloud Tiering.
        """
        return pulumi.get(self, "cloud_tiering")

    @property
    @pulumi.getter(name="friendlyName")
    def friendly_name(self) -> Optional[str]:
        """
        Friendly Name
        """
        return pulumi.get(self, "friendly_name")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="lastOperationName")
    def last_operation_name(self) -> Optional[str]:
        """
        Resource Last Operation Name
        """
        return pulumi.get(self, "last_operation_name")

    @property
    @pulumi.getter(name="lastWorkflowId")
    def last_workflow_id(self) -> Optional[str]:
        """
        ServerEndpoint lastWorkflowId
        """
        return pulumi.get(self, "last_workflow_id")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> Optional[str]:
        """
        ServerEndpoint Provisioning State
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="serverLocalPath")
    def server_local_path(self) -> Optional[str]:
        """
        Server Local path.
        """
        return pulumi.get(self, "server_local_path")

    @property
    @pulumi.getter(name="serverResourceId")
    def server_resource_id(self) -> Optional[str]:
        """
        Server Resource Id.
        """
        return pulumi.get(self, "server_resource_id")

    @property
    @pulumi.getter(name="syncStatus")
    def sync_status(self) -> Optional[Any]:
        """
        Sync Health Status
        """
        return pulumi.get(self, "sync_status")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="volumeFreeSpacePercent")
    def volume_free_space_percent(self) -> Optional[int]:
        """
        Level of free space to be maintained by Cloud Tiering if it is enabled.
        """
        return pulumi.get(self, "volume_free_space_percent")


class AwaitableGetServerEndpointResult(GetServerEndpointResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetServerEndpointResult(
            cloud_tiering=self.cloud_tiering,
            friendly_name=self.friendly_name,
            id=self.id,
            last_operation_name=self.last_operation_name,
            last_workflow_id=self.last_workflow_id,
            name=self.name,
            provisioning_state=self.provisioning_state,
            server_local_path=self.server_local_path,
            server_resource_id=self.server_resource_id,
            sync_status=self.sync_status,
            type=self.type,
            volume_free_space_percent=self.volume_free_space_percent)


def get_server_endpoint(resource_group_name: Optional[str] = None,
                        server_endpoint_name: Optional[str] = None,
                        storage_sync_service_name: Optional[str] = None,
                        sync_group_name: Optional[str] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetServerEndpointResult:
    """
    Server Endpoint object.


    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    :param str server_endpoint_name: Name of Server Endpoint object.
    :param str storage_sync_service_name: Name of Storage Sync Service resource.
    :param str sync_group_name: Name of Sync Group resource.
    """
    pulumi.log.warn("""get_server_endpoint is deprecated: Version 2018-04-02 will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['resourceGroupName'] = resource_group_name
    __args__['serverEndpointName'] = server_endpoint_name
    __args__['storageSyncServiceName'] = storage_sync_service_name
    __args__['syncGroupName'] = sync_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:storagesync/v20180402:getServerEndpoint', __args__, opts=opts, typ=GetServerEndpointResult).value

    return AwaitableGetServerEndpointResult(
        cloud_tiering=__ret__.cloud_tiering,
        friendly_name=__ret__.friendly_name,
        id=__ret__.id,
        last_operation_name=__ret__.last_operation_name,
        last_workflow_id=__ret__.last_workflow_id,
        name=__ret__.name,
        provisioning_state=__ret__.provisioning_state,
        server_local_path=__ret__.server_local_path,
        server_resource_id=__ret__.server_resource_id,
        sync_status=__ret__.sync_status,
        type=__ret__.type,
        volume_free_space_percent=__ret__.volume_free_space_percent)


@_utilities.lift_output_func(get_server_endpoint)
def get_server_endpoint_output(resource_group_name: Optional[pulumi.Input[str]] = None,
                               server_endpoint_name: Optional[pulumi.Input[str]] = None,
                               storage_sync_service_name: Optional[pulumi.Input[str]] = None,
                               sync_group_name: Optional[pulumi.Input[str]] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetServerEndpointResult]:
    """
    Server Endpoint object.


    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    :param str server_endpoint_name: Name of Server Endpoint object.
    :param str storage_sync_service_name: Name of Storage Sync Service resource.
    :param str sync_group_name: Name of Sync Group resource.
    """
    pulumi.log.warn("""get_server_endpoint is deprecated: Version 2018-04-02 will be removed in v2 of the provider.""")
    ...
