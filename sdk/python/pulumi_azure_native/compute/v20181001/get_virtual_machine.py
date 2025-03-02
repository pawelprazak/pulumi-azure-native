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
    'GetVirtualMachineResult',
    'AwaitableGetVirtualMachineResult',
    'get_virtual_machine',
    'get_virtual_machine_output',
]

warnings.warn("""Version 2018-10-01 will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetVirtualMachineResult:
    """
    Describes a Virtual Machine.
    """
    def __init__(__self__, additional_capabilities=None, availability_set=None, diagnostics_profile=None, hardware_profile=None, id=None, identity=None, instance_view=None, license_type=None, location=None, name=None, network_profile=None, os_profile=None, plan=None, provisioning_state=None, proximity_placement_group=None, resources=None, storage_profile=None, tags=None, type=None, vm_id=None, zones=None):
        if additional_capabilities and not isinstance(additional_capabilities, dict):
            raise TypeError("Expected argument 'additional_capabilities' to be a dict")
        pulumi.set(__self__, "additional_capabilities", additional_capabilities)
        if availability_set and not isinstance(availability_set, dict):
            raise TypeError("Expected argument 'availability_set' to be a dict")
        pulumi.set(__self__, "availability_set", availability_set)
        if diagnostics_profile and not isinstance(diagnostics_profile, dict):
            raise TypeError("Expected argument 'diagnostics_profile' to be a dict")
        pulumi.set(__self__, "diagnostics_profile", diagnostics_profile)
        if hardware_profile and not isinstance(hardware_profile, dict):
            raise TypeError("Expected argument 'hardware_profile' to be a dict")
        pulumi.set(__self__, "hardware_profile", hardware_profile)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if identity and not isinstance(identity, dict):
            raise TypeError("Expected argument 'identity' to be a dict")
        pulumi.set(__self__, "identity", identity)
        if instance_view and not isinstance(instance_view, dict):
            raise TypeError("Expected argument 'instance_view' to be a dict")
        pulumi.set(__self__, "instance_view", instance_view)
        if license_type and not isinstance(license_type, str):
            raise TypeError("Expected argument 'license_type' to be a str")
        pulumi.set(__self__, "license_type", license_type)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if network_profile and not isinstance(network_profile, dict):
            raise TypeError("Expected argument 'network_profile' to be a dict")
        pulumi.set(__self__, "network_profile", network_profile)
        if os_profile and not isinstance(os_profile, dict):
            raise TypeError("Expected argument 'os_profile' to be a dict")
        pulumi.set(__self__, "os_profile", os_profile)
        if plan and not isinstance(plan, dict):
            raise TypeError("Expected argument 'plan' to be a dict")
        pulumi.set(__self__, "plan", plan)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if proximity_placement_group and not isinstance(proximity_placement_group, dict):
            raise TypeError("Expected argument 'proximity_placement_group' to be a dict")
        pulumi.set(__self__, "proximity_placement_group", proximity_placement_group)
        if resources and not isinstance(resources, list):
            raise TypeError("Expected argument 'resources' to be a list")
        pulumi.set(__self__, "resources", resources)
        if storage_profile and not isinstance(storage_profile, dict):
            raise TypeError("Expected argument 'storage_profile' to be a dict")
        pulumi.set(__self__, "storage_profile", storage_profile)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if vm_id and not isinstance(vm_id, str):
            raise TypeError("Expected argument 'vm_id' to be a str")
        pulumi.set(__self__, "vm_id", vm_id)
        if zones and not isinstance(zones, list):
            raise TypeError("Expected argument 'zones' to be a list")
        pulumi.set(__self__, "zones", zones)

    @property
    @pulumi.getter(name="additionalCapabilities")
    def additional_capabilities(self) -> Optional['outputs.AdditionalCapabilitiesResponse']:
        """
        Specifies additional capabilities enabled or disabled on the virtual machine.
        """
        return pulumi.get(self, "additional_capabilities")

    @property
    @pulumi.getter(name="availabilitySet")
    def availability_set(self) -> Optional['outputs.SubResourceResponse']:
        """
        Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For more information about availability sets, see [Manage the availability of virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). <br><br> For more information on Azure planned maintenance, see [Planned maintenance for virtual machines in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> Currently, a VM can only be added to availability set at creation time. An existing VM cannot be added to an availability set.
        """
        return pulumi.get(self, "availability_set")

    @property
    @pulumi.getter(name="diagnosticsProfile")
    def diagnostics_profile(self) -> Optional['outputs.DiagnosticsProfileResponse']:
        """
        Specifies the boot diagnostic settings state. <br><br>Minimum api-version: 2015-06-15.
        """
        return pulumi.get(self, "diagnostics_profile")

    @property
    @pulumi.getter(name="hardwareProfile")
    def hardware_profile(self) -> Optional['outputs.HardwareProfileResponse']:
        """
        Specifies the hardware settings for the virtual machine.
        """
        return pulumi.get(self, "hardware_profile")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Resource Id
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def identity(self) -> Optional['outputs.VirtualMachineIdentityResponse']:
        """
        The identity of the virtual machine, if configured.
        """
        return pulumi.get(self, "identity")

    @property
    @pulumi.getter(name="instanceView")
    def instance_view(self) -> 'outputs.VirtualMachineInstanceViewResponse':
        """
        The virtual machine instance view.
        """
        return pulumi.get(self, "instance_view")

    @property
    @pulumi.getter(name="licenseType")
    def license_type(self) -> Optional[str]:
        """
        Specifies that the image or disk that is being used was licensed on-premises. This element is only used for images that contain the Windows Server operating system. <br><br> Possible values are: <br><br> Windows_Client <br><br> Windows_Server <br><br> If this element is included in a request for an update, the value must match the initial value. This value cannot be updated. <br><br> For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> Minimum api-version: 2015-06-15
        """
        return pulumi.get(self, "license_type")

    @property
    @pulumi.getter
    def location(self) -> str:
        """
        Resource location
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
    @pulumi.getter(name="networkProfile")
    def network_profile(self) -> Optional['outputs.NetworkProfileResponse']:
        """
        Specifies the network interfaces of the virtual machine.
        """
        return pulumi.get(self, "network_profile")

    @property
    @pulumi.getter(name="osProfile")
    def os_profile(self) -> Optional['outputs.OSProfileResponse']:
        """
        Specifies the operating system settings for the virtual machine.
        """
        return pulumi.get(self, "os_profile")

    @property
    @pulumi.getter
    def plan(self) -> Optional['outputs.PlanResponse']:
        """
        Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started ->**. Enter any required information and then click **Save**.
        """
        return pulumi.get(self, "plan")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        The provisioning state, which only appears in the response.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="proximityPlacementGroup")
    def proximity_placement_group(self) -> Optional['outputs.SubResourceResponse']:
        """
        Specifies information about the proximity placement group that the virtual machine should be assigned to. <br><br>Minimum api-version: 2018-04-01.
        """
        return pulumi.get(self, "proximity_placement_group")

    @property
    @pulumi.getter
    def resources(self) -> Sequence['outputs.VirtualMachineExtensionResponse']:
        """
        The virtual machine child extension resources.
        """
        return pulumi.get(self, "resources")

    @property
    @pulumi.getter(name="storageProfile")
    def storage_profile(self) -> Optional['outputs.StorageProfileResponse']:
        """
        Specifies the storage settings for the virtual machine disks.
        """
        return pulumi.get(self, "storage_profile")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="vmId")
    def vm_id(self) -> str:
        """
        Specifies the VM unique ID which is a 128-bits identifier that is encoded and stored in all Azure IaaS VMs SMBIOS and can be read using platform BIOS commands.
        """
        return pulumi.get(self, "vm_id")

    @property
    @pulumi.getter
    def zones(self) -> Optional[Sequence[str]]:
        """
        The virtual machine zones.
        """
        return pulumi.get(self, "zones")


class AwaitableGetVirtualMachineResult(GetVirtualMachineResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetVirtualMachineResult(
            additional_capabilities=self.additional_capabilities,
            availability_set=self.availability_set,
            diagnostics_profile=self.diagnostics_profile,
            hardware_profile=self.hardware_profile,
            id=self.id,
            identity=self.identity,
            instance_view=self.instance_view,
            license_type=self.license_type,
            location=self.location,
            name=self.name,
            network_profile=self.network_profile,
            os_profile=self.os_profile,
            plan=self.plan,
            provisioning_state=self.provisioning_state,
            proximity_placement_group=self.proximity_placement_group,
            resources=self.resources,
            storage_profile=self.storage_profile,
            tags=self.tags,
            type=self.type,
            vm_id=self.vm_id,
            zones=self.zones)


def get_virtual_machine(expand: Optional[str] = None,
                        resource_group_name: Optional[str] = None,
                        vm_name: Optional[str] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetVirtualMachineResult:
    """
    Describes a Virtual Machine.


    :param str expand: The expand expression to apply on the operation.
    :param str resource_group_name: The name of the resource group.
    :param str vm_name: The name of the virtual machine.
    """
    pulumi.log.warn("""get_virtual_machine is deprecated: Version 2018-10-01 will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['expand'] = expand
    __args__['resourceGroupName'] = resource_group_name
    __args__['vmName'] = vm_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:compute/v20181001:getVirtualMachine', __args__, opts=opts, typ=GetVirtualMachineResult).value

    return AwaitableGetVirtualMachineResult(
        additional_capabilities=__ret__.additional_capabilities,
        availability_set=__ret__.availability_set,
        diagnostics_profile=__ret__.diagnostics_profile,
        hardware_profile=__ret__.hardware_profile,
        id=__ret__.id,
        identity=__ret__.identity,
        instance_view=__ret__.instance_view,
        license_type=__ret__.license_type,
        location=__ret__.location,
        name=__ret__.name,
        network_profile=__ret__.network_profile,
        os_profile=__ret__.os_profile,
        plan=__ret__.plan,
        provisioning_state=__ret__.provisioning_state,
        proximity_placement_group=__ret__.proximity_placement_group,
        resources=__ret__.resources,
        storage_profile=__ret__.storage_profile,
        tags=__ret__.tags,
        type=__ret__.type,
        vm_id=__ret__.vm_id,
        zones=__ret__.zones)


@_utilities.lift_output_func(get_virtual_machine)
def get_virtual_machine_output(expand: Optional[pulumi.Input[Optional[str]]] = None,
                               resource_group_name: Optional[pulumi.Input[str]] = None,
                               vm_name: Optional[pulumi.Input[str]] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetVirtualMachineResult]:
    """
    Describes a Virtual Machine.


    :param str expand: The expand expression to apply on the operation.
    :param str resource_group_name: The name of the resource group.
    :param str vm_name: The name of the virtual machine.
    """
    pulumi.log.warn("""get_virtual_machine is deprecated: Version 2018-10-01 will be removed in v2 of the provider.""")
    ...
