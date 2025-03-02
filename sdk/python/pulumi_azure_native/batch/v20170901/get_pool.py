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
    'GetPoolResult',
    'AwaitableGetPoolResult',
    'get_pool',
    'get_pool_output',
]

warnings.warn("""Version 2017-09-01 will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetPoolResult:
    """
    Contains information about a pool.
    """
    def __init__(__self__, allocation_state=None, allocation_state_transition_time=None, application_licenses=None, application_packages=None, auto_scale_run=None, certificates=None, creation_time=None, current_dedicated_nodes=None, current_low_priority_nodes=None, deployment_configuration=None, display_name=None, etag=None, id=None, inter_node_communication=None, last_modified=None, max_tasks_per_node=None, metadata=None, name=None, network_configuration=None, provisioning_state=None, provisioning_state_transition_time=None, resize_operation_status=None, scale_settings=None, start_task=None, task_scheduling_policy=None, type=None, user_accounts=None, vm_size=None):
        if allocation_state and not isinstance(allocation_state, str):
            raise TypeError("Expected argument 'allocation_state' to be a str")
        pulumi.set(__self__, "allocation_state", allocation_state)
        if allocation_state_transition_time and not isinstance(allocation_state_transition_time, str):
            raise TypeError("Expected argument 'allocation_state_transition_time' to be a str")
        pulumi.set(__self__, "allocation_state_transition_time", allocation_state_transition_time)
        if application_licenses and not isinstance(application_licenses, list):
            raise TypeError("Expected argument 'application_licenses' to be a list")
        pulumi.set(__self__, "application_licenses", application_licenses)
        if application_packages and not isinstance(application_packages, list):
            raise TypeError("Expected argument 'application_packages' to be a list")
        pulumi.set(__self__, "application_packages", application_packages)
        if auto_scale_run and not isinstance(auto_scale_run, dict):
            raise TypeError("Expected argument 'auto_scale_run' to be a dict")
        pulumi.set(__self__, "auto_scale_run", auto_scale_run)
        if certificates and not isinstance(certificates, list):
            raise TypeError("Expected argument 'certificates' to be a list")
        pulumi.set(__self__, "certificates", certificates)
        if creation_time and not isinstance(creation_time, str):
            raise TypeError("Expected argument 'creation_time' to be a str")
        pulumi.set(__self__, "creation_time", creation_time)
        if current_dedicated_nodes and not isinstance(current_dedicated_nodes, int):
            raise TypeError("Expected argument 'current_dedicated_nodes' to be a int")
        pulumi.set(__self__, "current_dedicated_nodes", current_dedicated_nodes)
        if current_low_priority_nodes and not isinstance(current_low_priority_nodes, int):
            raise TypeError("Expected argument 'current_low_priority_nodes' to be a int")
        pulumi.set(__self__, "current_low_priority_nodes", current_low_priority_nodes)
        if deployment_configuration and not isinstance(deployment_configuration, dict):
            raise TypeError("Expected argument 'deployment_configuration' to be a dict")
        pulumi.set(__self__, "deployment_configuration", deployment_configuration)
        if display_name and not isinstance(display_name, str):
            raise TypeError("Expected argument 'display_name' to be a str")
        pulumi.set(__self__, "display_name", display_name)
        if etag and not isinstance(etag, str):
            raise TypeError("Expected argument 'etag' to be a str")
        pulumi.set(__self__, "etag", etag)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if inter_node_communication and not isinstance(inter_node_communication, str):
            raise TypeError("Expected argument 'inter_node_communication' to be a str")
        pulumi.set(__self__, "inter_node_communication", inter_node_communication)
        if last_modified and not isinstance(last_modified, str):
            raise TypeError("Expected argument 'last_modified' to be a str")
        pulumi.set(__self__, "last_modified", last_modified)
        if max_tasks_per_node and not isinstance(max_tasks_per_node, int):
            raise TypeError("Expected argument 'max_tasks_per_node' to be a int")
        pulumi.set(__self__, "max_tasks_per_node", max_tasks_per_node)
        if metadata and not isinstance(metadata, list):
            raise TypeError("Expected argument 'metadata' to be a list")
        pulumi.set(__self__, "metadata", metadata)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if network_configuration and not isinstance(network_configuration, dict):
            raise TypeError("Expected argument 'network_configuration' to be a dict")
        pulumi.set(__self__, "network_configuration", network_configuration)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if provisioning_state_transition_time and not isinstance(provisioning_state_transition_time, str):
            raise TypeError("Expected argument 'provisioning_state_transition_time' to be a str")
        pulumi.set(__self__, "provisioning_state_transition_time", provisioning_state_transition_time)
        if resize_operation_status and not isinstance(resize_operation_status, dict):
            raise TypeError("Expected argument 'resize_operation_status' to be a dict")
        pulumi.set(__self__, "resize_operation_status", resize_operation_status)
        if scale_settings and not isinstance(scale_settings, dict):
            raise TypeError("Expected argument 'scale_settings' to be a dict")
        pulumi.set(__self__, "scale_settings", scale_settings)
        if start_task and not isinstance(start_task, dict):
            raise TypeError("Expected argument 'start_task' to be a dict")
        pulumi.set(__self__, "start_task", start_task)
        if task_scheduling_policy and not isinstance(task_scheduling_policy, dict):
            raise TypeError("Expected argument 'task_scheduling_policy' to be a dict")
        pulumi.set(__self__, "task_scheduling_policy", task_scheduling_policy)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if user_accounts and not isinstance(user_accounts, list):
            raise TypeError("Expected argument 'user_accounts' to be a list")
        pulumi.set(__self__, "user_accounts", user_accounts)
        if vm_size and not isinstance(vm_size, str):
            raise TypeError("Expected argument 'vm_size' to be a str")
        pulumi.set(__self__, "vm_size", vm_size)

    @property
    @pulumi.getter(name="allocationState")
    def allocation_state(self) -> str:
        """
        Values are:

         Steady - The pool is not resizing. There are no changes to the number of nodes in the pool in progress. A pool enters this state when it is created and when no operations are being performed on the pool to change the number of dedicated nodes.
         Resizing - The pool is resizing; that is, compute nodes are being added to or removed from the pool.
         Stopping - The pool was resizing, but the user has requested that the resize be stopped, but the stop request has not yet been completed.
        """
        return pulumi.get(self, "allocation_state")

    @property
    @pulumi.getter(name="allocationStateTransitionTime")
    def allocation_state_transition_time(self) -> str:
        return pulumi.get(self, "allocation_state_transition_time")

    @property
    @pulumi.getter(name="applicationLicenses")
    def application_licenses(self) -> Optional[Sequence[str]]:
        """
        The list of application licenses must be a subset of available Batch service application licenses. If a license is requested which is not supported, pool creation will fail.
        """
        return pulumi.get(self, "application_licenses")

    @property
    @pulumi.getter(name="applicationPackages")
    def application_packages(self) -> Optional[Sequence['outputs.ApplicationPackageReferenceResponse']]:
        """
        Changes to application packages affect all new compute nodes joining the pool, but do not affect compute nodes that are already in the pool until they are rebooted or reimaged.
        """
        return pulumi.get(self, "application_packages")

    @property
    @pulumi.getter(name="autoScaleRun")
    def auto_scale_run(self) -> 'outputs.AutoScaleRunResponse':
        """
        This property is set only if the pool automatically scales, i.e. autoScaleSettings are used.
        """
        return pulumi.get(self, "auto_scale_run")

    @property
    @pulumi.getter
    def certificates(self) -> Optional[Sequence['outputs.CertificateReferenceResponse']]:
        """
        For Windows compute nodes, the Batch service installs the certificates to the specified certificate store and location. For Linux compute nodes, the certificates are stored in a directory inside the task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for this location. For certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and certificates are placed in that directory.
        """
        return pulumi.get(self, "certificates")

    @property
    @pulumi.getter(name="creationTime")
    def creation_time(self) -> str:
        return pulumi.get(self, "creation_time")

    @property
    @pulumi.getter(name="currentDedicatedNodes")
    def current_dedicated_nodes(self) -> int:
        return pulumi.get(self, "current_dedicated_nodes")

    @property
    @pulumi.getter(name="currentLowPriorityNodes")
    def current_low_priority_nodes(self) -> int:
        return pulumi.get(self, "current_low_priority_nodes")

    @property
    @pulumi.getter(name="deploymentConfiguration")
    def deployment_configuration(self) -> Optional['outputs.DeploymentConfigurationResponse']:
        """
        Using CloudServiceConfiguration specifies that the nodes should be creating using Azure Cloud Services (PaaS), while VirtualMachineConfiguration uses Azure Virtual Machines (IaaS).
        """
        return pulumi.get(self, "deployment_configuration")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[str]:
        """
        The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def etag(self) -> str:
        """
        The ETag of the resource, used for concurrency statements.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The ID of the resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="interNodeCommunication")
    def inter_node_communication(self) -> Optional[str]:
        """
        This imposes restrictions on which nodes can be assigned to the pool. Enabling this value can reduce the chance of the requested number of nodes to be allocated in the pool. If not specified, this value defaults to 'Disabled'.
        """
        return pulumi.get(self, "inter_node_communication")

    @property
    @pulumi.getter(name="lastModified")
    def last_modified(self) -> str:
        """
        This is the last time at which the pool level data, such as the targetDedicatedNodes or autoScaleSettings, changed. It does not factor in node-level changes such as a compute node changing state.
        """
        return pulumi.get(self, "last_modified")

    @property
    @pulumi.getter(name="maxTasksPerNode")
    def max_tasks_per_node(self) -> Optional[int]:
        return pulumi.get(self, "max_tasks_per_node")

    @property
    @pulumi.getter
    def metadata(self) -> Optional[Sequence['outputs.MetadataItemResponse']]:
        """
        The Batch service does not assign any meaning to metadata; it is solely for the use of user code.
        """
        return pulumi.get(self, "metadata")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the resource.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkConfiguration")
    def network_configuration(self) -> Optional['outputs.NetworkConfigurationResponse']:
        """
        The network configuration for a pool.
        """
        return pulumi.get(self, "network_configuration")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        Values are:

         Succeeded - The pool is available to run tasks subject to the availability of compute nodes.
         Deleting - The user has requested that the pool be deleted, but the delete operation has not yet completed.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="provisioningStateTransitionTime")
    def provisioning_state_transition_time(self) -> str:
        return pulumi.get(self, "provisioning_state_transition_time")

    @property
    @pulumi.getter(name="resizeOperationStatus")
    def resize_operation_status(self) -> 'outputs.ResizeOperationStatusResponse':
        """
        Describes either the current operation (if the pool AllocationState is Resizing) or the previously completed operation (if the AllocationState is Steady).
        """
        return pulumi.get(self, "resize_operation_status")

    @property
    @pulumi.getter(name="scaleSettings")
    def scale_settings(self) -> Optional['outputs.ScaleSettingsResponse']:
        """
        Defines the desired size of the pool. This can either be 'fixedScale' where the requested targetDedicatedNodes is specified, or 'autoScale' which defines a formula which is periodically reevaluated. If this property is not specified, the pool will have a fixed scale with 0 targetDedicatedNodes.
        """
        return pulumi.get(self, "scale_settings")

    @property
    @pulumi.getter(name="startTask")
    def start_task(self) -> Optional['outputs.StartTaskResponse']:
        """
        In an PATCH (update) operation, this property can be set to an empty object to remove the start task from the pool.
        """
        return pulumi.get(self, "start_task")

    @property
    @pulumi.getter(name="taskSchedulingPolicy")
    def task_scheduling_policy(self) -> Optional['outputs.TaskSchedulingPolicyResponse']:
        return pulumi.get(self, "task_scheduling_policy")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="userAccounts")
    def user_accounts(self) -> Optional[Sequence['outputs.UserAccountResponse']]:
        return pulumi.get(self, "user_accounts")

    @property
    @pulumi.getter(name="vmSize")
    def vm_size(self) -> Optional[str]:
        """
        For information about available sizes of virtual machines for Cloud Services pools (pools created with cloudServiceConfiguration), see Sizes for Cloud Services (https://azure.microsoft.com/documentation/articles/cloud-services-sizes-specs/). Batch supports all Cloud Services VM sizes except ExtraSmall. For information about available VM sizes for pools using images from the Virtual Machines Marketplace (pools created with virtualMachineConfiguration) see Sizes for Virtual Machines (Linux) (https://azure.microsoft.com/documentation/articles/virtual-machines-linux-sizes/) or Sizes for Virtual Machines (Windows) (https://azure.microsoft.com/documentation/articles/virtual-machines-windows-sizes/). Batch supports all Azure VM sizes except STANDARD_A0 and those with premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2 series).
        """
        return pulumi.get(self, "vm_size")


class AwaitableGetPoolResult(GetPoolResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetPoolResult(
            allocation_state=self.allocation_state,
            allocation_state_transition_time=self.allocation_state_transition_time,
            application_licenses=self.application_licenses,
            application_packages=self.application_packages,
            auto_scale_run=self.auto_scale_run,
            certificates=self.certificates,
            creation_time=self.creation_time,
            current_dedicated_nodes=self.current_dedicated_nodes,
            current_low_priority_nodes=self.current_low_priority_nodes,
            deployment_configuration=self.deployment_configuration,
            display_name=self.display_name,
            etag=self.etag,
            id=self.id,
            inter_node_communication=self.inter_node_communication,
            last_modified=self.last_modified,
            max_tasks_per_node=self.max_tasks_per_node,
            metadata=self.metadata,
            name=self.name,
            network_configuration=self.network_configuration,
            provisioning_state=self.provisioning_state,
            provisioning_state_transition_time=self.provisioning_state_transition_time,
            resize_operation_status=self.resize_operation_status,
            scale_settings=self.scale_settings,
            start_task=self.start_task,
            task_scheduling_policy=self.task_scheduling_policy,
            type=self.type,
            user_accounts=self.user_accounts,
            vm_size=self.vm_size)


def get_pool(account_name: Optional[str] = None,
             pool_name: Optional[str] = None,
             resource_group_name: Optional[str] = None,
             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetPoolResult:
    """
    Contains information about a pool.


    :param str account_name: The name of the Batch account.
    :param str pool_name: The pool name. This must be unique within the account.
    :param str resource_group_name: The name of the resource group that contains the Batch account.
    """
    pulumi.log.warn("""get_pool is deprecated: Version 2017-09-01 will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['accountName'] = account_name
    __args__['poolName'] = pool_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:batch/v20170901:getPool', __args__, opts=opts, typ=GetPoolResult).value

    return AwaitableGetPoolResult(
        allocation_state=__ret__.allocation_state,
        allocation_state_transition_time=__ret__.allocation_state_transition_time,
        application_licenses=__ret__.application_licenses,
        application_packages=__ret__.application_packages,
        auto_scale_run=__ret__.auto_scale_run,
        certificates=__ret__.certificates,
        creation_time=__ret__.creation_time,
        current_dedicated_nodes=__ret__.current_dedicated_nodes,
        current_low_priority_nodes=__ret__.current_low_priority_nodes,
        deployment_configuration=__ret__.deployment_configuration,
        display_name=__ret__.display_name,
        etag=__ret__.etag,
        id=__ret__.id,
        inter_node_communication=__ret__.inter_node_communication,
        last_modified=__ret__.last_modified,
        max_tasks_per_node=__ret__.max_tasks_per_node,
        metadata=__ret__.metadata,
        name=__ret__.name,
        network_configuration=__ret__.network_configuration,
        provisioning_state=__ret__.provisioning_state,
        provisioning_state_transition_time=__ret__.provisioning_state_transition_time,
        resize_operation_status=__ret__.resize_operation_status,
        scale_settings=__ret__.scale_settings,
        start_task=__ret__.start_task,
        task_scheduling_policy=__ret__.task_scheduling_policy,
        type=__ret__.type,
        user_accounts=__ret__.user_accounts,
        vm_size=__ret__.vm_size)


@_utilities.lift_output_func(get_pool)
def get_pool_output(account_name: Optional[pulumi.Input[str]] = None,
                    pool_name: Optional[pulumi.Input[str]] = None,
                    resource_group_name: Optional[pulumi.Input[str]] = None,
                    opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetPoolResult]:
    """
    Contains information about a pool.


    :param str account_name: The name of the Batch account.
    :param str pool_name: The pool name. This must be unique within the account.
    :param str resource_group_name: The name of the resource group that contains the Batch account.
    """
    pulumi.log.warn("""get_pool is deprecated: Version 2017-09-01 will be removed in v2 of the provider.""")
    ...
