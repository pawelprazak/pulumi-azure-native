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
    'GetHybridIdentityMetadatumResult',
    'AwaitableGetHybridIdentityMetadatumResult',
    'get_hybrid_identity_metadatum',
    'get_hybrid_identity_metadatum_output',
]

@pulumi.output_type
class GetHybridIdentityMetadatumResult:
    """
    Defines the HybridIdentityMetadata.
    """
    def __init__(__self__, id=None, identity=None, name=None, provisioning_state=None, public_key=None, system_data=None, type=None, vm_id=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if identity and not isinstance(identity, dict):
            raise TypeError("Expected argument 'identity' to be a dict")
        pulumi.set(__self__, "identity", identity)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if public_key and not isinstance(public_key, str):
            raise TypeError("Expected argument 'public_key' to be a str")
        pulumi.set(__self__, "public_key", public_key)
        if system_data and not isinstance(system_data, dict):
            raise TypeError("Expected argument 'system_data' to be a dict")
        pulumi.set(__self__, "system_data", system_data)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if vm_id and not isinstance(vm_id, str):
            raise TypeError("Expected argument 'vm_id' to be a str")
        pulumi.set(__self__, "vm_id", vm_id)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def identity(self) -> 'outputs.IdentityResponse':
        """
        The identity of the resource.
        """
        return pulumi.get(self, "identity")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        Gets or sets the provisioning state.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="publicKey")
    def public_key(self) -> Optional[str]:
        """
        Gets or sets the Public Key.
        """
        return pulumi.get(self, "public_key")

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
    @pulumi.getter(name="vmId")
    def vm_id(self) -> Optional[str]:
        """
        Gets or sets the Vm Id.
        """
        return pulumi.get(self, "vm_id")


class AwaitableGetHybridIdentityMetadatumResult(GetHybridIdentityMetadatumResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetHybridIdentityMetadatumResult(
            id=self.id,
            identity=self.identity,
            name=self.name,
            provisioning_state=self.provisioning_state,
            public_key=self.public_key,
            system_data=self.system_data,
            type=self.type,
            vm_id=self.vm_id)


def get_hybrid_identity_metadatum(metadata_name: Optional[str] = None,
                                  resource_group_name: Optional[str] = None,
                                  virtual_machine_name: Optional[str] = None,
                                  opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetHybridIdentityMetadatumResult:
    """
    Defines the HybridIdentityMetadata.


    :param str metadata_name: Name of the HybridIdentityMetadata.
    :param str resource_group_name: The Resource Group Name.
    :param str virtual_machine_name: Name of the vm.
    """
    __args__ = dict()
    __args__['metadataName'] = metadata_name
    __args__['resourceGroupName'] = resource_group_name
    __args__['virtualMachineName'] = virtual_machine_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:connectedvmwarevsphere/v20220110preview:getHybridIdentityMetadatum', __args__, opts=opts, typ=GetHybridIdentityMetadatumResult).value

    return AwaitableGetHybridIdentityMetadatumResult(
        id=__ret__.id,
        identity=__ret__.identity,
        name=__ret__.name,
        provisioning_state=__ret__.provisioning_state,
        public_key=__ret__.public_key,
        system_data=__ret__.system_data,
        type=__ret__.type,
        vm_id=__ret__.vm_id)


@_utilities.lift_output_func(get_hybrid_identity_metadatum)
def get_hybrid_identity_metadatum_output(metadata_name: Optional[pulumi.Input[str]] = None,
                                         resource_group_name: Optional[pulumi.Input[str]] = None,
                                         virtual_machine_name: Optional[pulumi.Input[str]] = None,
                                         opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetHybridIdentityMetadatumResult]:
    """
    Defines the HybridIdentityMetadata.


    :param str metadata_name: Name of the HybridIdentityMetadata.
    :param str resource_group_name: The Resource Group Name.
    :param str virtual_machine_name: Name of the vm.
    """
    ...
