# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'GetVirtualMachineScaleSetExtensionResult',
    'AwaitableGetVirtualMachineScaleSetExtensionResult',
    'get_virtual_machine_scale_set_extension',
    'get_virtual_machine_scale_set_extension_output',
]

warnings.warn("""Version 2019-12-01 will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetVirtualMachineScaleSetExtensionResult:
    """
    Describes a Virtual Machine Scale Set Extension.
    """
    def __init__(__self__, auto_upgrade_minor_version=None, force_update_tag=None, id=None, name=None, protected_settings=None, provision_after_extensions=None, provisioning_state=None, publisher=None, settings=None, type=None, type_handler_version=None):
        if auto_upgrade_minor_version and not isinstance(auto_upgrade_minor_version, bool):
            raise TypeError("Expected argument 'auto_upgrade_minor_version' to be a bool")
        pulumi.set(__self__, "auto_upgrade_minor_version", auto_upgrade_minor_version)
        if force_update_tag and not isinstance(force_update_tag, str):
            raise TypeError("Expected argument 'force_update_tag' to be a str")
        pulumi.set(__self__, "force_update_tag", force_update_tag)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if protected_settings and not isinstance(protected_settings, dict):
            raise TypeError("Expected argument 'protected_settings' to be a dict")
        pulumi.set(__self__, "protected_settings", protected_settings)
        if provision_after_extensions and not isinstance(provision_after_extensions, list):
            raise TypeError("Expected argument 'provision_after_extensions' to be a list")
        pulumi.set(__self__, "provision_after_extensions", provision_after_extensions)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if publisher and not isinstance(publisher, str):
            raise TypeError("Expected argument 'publisher' to be a str")
        pulumi.set(__self__, "publisher", publisher)
        if settings and not isinstance(settings, dict):
            raise TypeError("Expected argument 'settings' to be a dict")
        pulumi.set(__self__, "settings", settings)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if type_handler_version and not isinstance(type_handler_version, str):
            raise TypeError("Expected argument 'type_handler_version' to be a str")
        pulumi.set(__self__, "type_handler_version", type_handler_version)

    @property
    @pulumi.getter(name="autoUpgradeMinorVersion")
    def auto_upgrade_minor_version(self) -> Optional[bool]:
        """
        Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
        """
        return pulumi.get(self, "auto_upgrade_minor_version")

    @property
    @pulumi.getter(name="forceUpdateTag")
    def force_update_tag(self) -> Optional[str]:
        """
        If a value is provided and is different from the previous value, the extension handler will be forced to update even if the extension configuration has not changed.
        """
        return pulumi.get(self, "force_update_tag")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Resource Id
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        The name of the extension.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="protectedSettings")
    def protected_settings(self) -> Optional[Any]:
        """
        The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
        """
        return pulumi.get(self, "protected_settings")

    @property
    @pulumi.getter(name="provisionAfterExtensions")
    def provision_after_extensions(self) -> Optional[Sequence[str]]:
        """
        Collection of extension names after which this extension needs to be provisioned.
        """
        return pulumi.get(self, "provision_after_extensions")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        The provisioning state, which only appears in the response.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def publisher(self) -> Optional[str]:
        """
        The name of the extension handler publisher.
        """
        return pulumi.get(self, "publisher")

    @property
    @pulumi.getter
    def settings(self) -> Optional[Any]:
        """
        Json formatted public settings for the extension.
        """
        return pulumi.get(self, "settings")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="typeHandlerVersion")
    def type_handler_version(self) -> Optional[str]:
        """
        Specifies the version of the script handler.
        """
        return pulumi.get(self, "type_handler_version")


class AwaitableGetVirtualMachineScaleSetExtensionResult(GetVirtualMachineScaleSetExtensionResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetVirtualMachineScaleSetExtensionResult(
            auto_upgrade_minor_version=self.auto_upgrade_minor_version,
            force_update_tag=self.force_update_tag,
            id=self.id,
            name=self.name,
            protected_settings=self.protected_settings,
            provision_after_extensions=self.provision_after_extensions,
            provisioning_state=self.provisioning_state,
            publisher=self.publisher,
            settings=self.settings,
            type=self.type,
            type_handler_version=self.type_handler_version)


def get_virtual_machine_scale_set_extension(expand: Optional[str] = None,
                                            resource_group_name: Optional[str] = None,
                                            vm_scale_set_name: Optional[str] = None,
                                            vmss_extension_name: Optional[str] = None,
                                            opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetVirtualMachineScaleSetExtensionResult:
    """
    Describes a Virtual Machine Scale Set Extension.


    :param str expand: The expand expression to apply on the operation.
    :param str resource_group_name: The name of the resource group.
    :param str vm_scale_set_name: The name of the VM scale set containing the extension.
    :param str vmss_extension_name: The name of the VM scale set extension.
    """
    pulumi.log.warn("""get_virtual_machine_scale_set_extension is deprecated: Version 2019-12-01 will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['expand'] = expand
    __args__['resourceGroupName'] = resource_group_name
    __args__['vmScaleSetName'] = vm_scale_set_name
    __args__['vmssExtensionName'] = vmss_extension_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:compute/v20191201:getVirtualMachineScaleSetExtension', __args__, opts=opts, typ=GetVirtualMachineScaleSetExtensionResult).value

    return AwaitableGetVirtualMachineScaleSetExtensionResult(
        auto_upgrade_minor_version=__ret__.auto_upgrade_minor_version,
        force_update_tag=__ret__.force_update_tag,
        id=__ret__.id,
        name=__ret__.name,
        protected_settings=__ret__.protected_settings,
        provision_after_extensions=__ret__.provision_after_extensions,
        provisioning_state=__ret__.provisioning_state,
        publisher=__ret__.publisher,
        settings=__ret__.settings,
        type=__ret__.type,
        type_handler_version=__ret__.type_handler_version)


@_utilities.lift_output_func(get_virtual_machine_scale_set_extension)
def get_virtual_machine_scale_set_extension_output(expand: Optional[pulumi.Input[Optional[str]]] = None,
                                                   resource_group_name: Optional[pulumi.Input[str]] = None,
                                                   vm_scale_set_name: Optional[pulumi.Input[str]] = None,
                                                   vmss_extension_name: Optional[pulumi.Input[str]] = None,
                                                   opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetVirtualMachineScaleSetExtensionResult]:
    """
    Describes a Virtual Machine Scale Set Extension.


    :param str expand: The expand expression to apply on the operation.
    :param str resource_group_name: The name of the resource group.
    :param str vm_scale_set_name: The name of the VM scale set containing the extension.
    :param str vmss_extension_name: The name of the VM scale set extension.
    """
    pulumi.log.warn("""get_virtual_machine_scale_set_extension is deprecated: Version 2019-12-01 will be removed in v2 of the provider.""")
    ...
