# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from ._enums import *

__all__ = [
    'ExtendedLocationArgs',
    'GuestCredentialArgs',
    'HardwareProfileArgs',
    'HttpProxyConfigurationArgs',
    'IdentityArgs',
    'NetworkInterfaceArgs',
    'NetworkProfileArgs',
    'NicIPSettingsArgs',
    'OsProfileLinuxConfigurationArgs',
    'OsProfileWindowsConfigurationArgs',
    'OsProfileArgs',
    'PlacementProfileArgs',
    'SecurityProfileArgs',
    'StorageProfileArgs',
    'UefiSettingsArgs',
    'VICredentialArgs',
    'VirtualDiskArgs',
]

@pulumi.input_type
class ExtendedLocationArgs:
    def __init__(__self__, *,
                 name: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None):
        """
        The extended location.
        :param pulumi.Input[str] name: The extended location name.
        :param pulumi.Input[str] type: The extended location type.
        """
        if name is not None:
            pulumi.set(__self__, "name", name)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The extended location name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        """
        The extended location type.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)


@pulumi.input_type
class GuestCredentialArgs:
    def __init__(__self__, *,
                 password: Optional[pulumi.Input[str]] = None,
                 username: Optional[pulumi.Input[str]] = None):
        """
        Username / Password Credentials to connect to guest.
        :param pulumi.Input[str] password: Gets or sets the password to connect with the guest.
        :param pulumi.Input[str] username: Gets or sets username to connect with the guest.
        """
        if password is not None:
            pulumi.set(__self__, "password", password)
        if username is not None:
            pulumi.set(__self__, "username", username)

    @property
    @pulumi.getter
    def password(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the password to connect with the guest.
        """
        return pulumi.get(self, "password")

    @password.setter
    def password(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "password", value)

    @property
    @pulumi.getter
    def username(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets username to connect with the guest.
        """
        return pulumi.get(self, "username")

    @username.setter
    def username(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "username", value)


@pulumi.input_type
class HardwareProfileArgs:
    def __init__(__self__, *,
                 memory_size_mb: Optional[pulumi.Input[int]] = None,
                 num_cpus: Optional[pulumi.Input[int]] = None,
                 num_cores_per_socket: Optional[pulumi.Input[int]] = None):
        """
        Defines the resource properties.
        :param pulumi.Input[int] memory_size_mb: Gets or sets memory size in MBs for the vm.
        :param pulumi.Input[int] num_cpus: Gets or sets the number of vCPUs for the vm.
        :param pulumi.Input[int] num_cores_per_socket: Gets or sets the number of cores per socket for the vm. Defaults to 1 if unspecified.
        """
        if memory_size_mb is not None:
            pulumi.set(__self__, "memory_size_mb", memory_size_mb)
        if num_cpus is not None:
            pulumi.set(__self__, "num_cpus", num_cpus)
        if num_cores_per_socket is not None:
            pulumi.set(__self__, "num_cores_per_socket", num_cores_per_socket)

    @property
    @pulumi.getter(name="memorySizeMB")
    def memory_size_mb(self) -> Optional[pulumi.Input[int]]:
        """
        Gets or sets memory size in MBs for the vm.
        """
        return pulumi.get(self, "memory_size_mb")

    @memory_size_mb.setter
    def memory_size_mb(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "memory_size_mb", value)

    @property
    @pulumi.getter(name="numCPUs")
    def num_cpus(self) -> Optional[pulumi.Input[int]]:
        """
        Gets or sets the number of vCPUs for the vm.
        """
        return pulumi.get(self, "num_cpus")

    @num_cpus.setter
    def num_cpus(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "num_cpus", value)

    @property
    @pulumi.getter(name="numCoresPerSocket")
    def num_cores_per_socket(self) -> Optional[pulumi.Input[int]]:
        """
        Gets or sets the number of cores per socket for the vm. Defaults to 1 if unspecified.
        """
        return pulumi.get(self, "num_cores_per_socket")

    @num_cores_per_socket.setter
    def num_cores_per_socket(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "num_cores_per_socket", value)


@pulumi.input_type
class HttpProxyConfigurationArgs:
    def __init__(__self__, *,
                 https_proxy: Optional[pulumi.Input[str]] = None):
        """
        HTTP Proxy configuration for the VM.
        :param pulumi.Input[str] https_proxy: Gets or sets httpsProxy url.
        """
        if https_proxy is not None:
            pulumi.set(__self__, "https_proxy", https_proxy)

    @property
    @pulumi.getter(name="httpsProxy")
    def https_proxy(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets httpsProxy url.
        """
        return pulumi.get(self, "https_proxy")

    @https_proxy.setter
    def https_proxy(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "https_proxy", value)


@pulumi.input_type
class IdentityArgs:
    def __init__(__self__, *,
                 type: pulumi.Input[Union[str, 'IdentityType']]):
        """
        Managed service identity.
        :param pulumi.Input[Union[str, 'IdentityType']] type: The type of managed service identity.
        """
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[Union[str, 'IdentityType']]:
        """
        The type of managed service identity.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[Union[str, 'IdentityType']]):
        pulumi.set(self, "type", value)


@pulumi.input_type
class NetworkInterfaceArgs:
    def __init__(__self__, *,
                 device_key: Optional[pulumi.Input[int]] = None,
                 ip_settings: Optional[pulumi.Input['NicIPSettingsArgs']] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 network_id: Optional[pulumi.Input[str]] = None,
                 nic_type: Optional[pulumi.Input[Union[str, 'NICType']]] = None,
                 power_on_boot: Optional[pulumi.Input[Union[str, 'PowerOnBootOption']]] = None):
        """
        Network Interface model
        :param pulumi.Input[int] device_key: Gets or sets the device key value.
        :param pulumi.Input['NicIPSettingsArgs'] ip_settings: Gets or sets the ipsettings.
        :param pulumi.Input[str] name: Gets or sets the name of the network interface.
        :param pulumi.Input[str] network_id: Gets or sets the ARM Id of the network resource to connect the virtual machine.
        :param pulumi.Input[Union[str, 'NICType']] nic_type: NIC type
        :param pulumi.Input[Union[str, 'PowerOnBootOption']] power_on_boot: Gets or sets the power on boot.
        """
        if device_key is not None:
            pulumi.set(__self__, "device_key", device_key)
        if ip_settings is not None:
            pulumi.set(__self__, "ip_settings", ip_settings)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if network_id is not None:
            pulumi.set(__self__, "network_id", network_id)
        if nic_type is not None:
            pulumi.set(__self__, "nic_type", nic_type)
        if power_on_boot is not None:
            pulumi.set(__self__, "power_on_boot", power_on_boot)

    @property
    @pulumi.getter(name="deviceKey")
    def device_key(self) -> Optional[pulumi.Input[int]]:
        """
        Gets or sets the device key value.
        """
        return pulumi.get(self, "device_key")

    @device_key.setter
    def device_key(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "device_key", value)

    @property
    @pulumi.getter(name="ipSettings")
    def ip_settings(self) -> Optional[pulumi.Input['NicIPSettingsArgs']]:
        """
        Gets or sets the ipsettings.
        """
        return pulumi.get(self, "ip_settings")

    @ip_settings.setter
    def ip_settings(self, value: Optional[pulumi.Input['NicIPSettingsArgs']]):
        pulumi.set(self, "ip_settings", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the name of the network interface.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="networkId")
    def network_id(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the ARM Id of the network resource to connect the virtual machine.
        """
        return pulumi.get(self, "network_id")

    @network_id.setter
    def network_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "network_id", value)

    @property
    @pulumi.getter(name="nicType")
    def nic_type(self) -> Optional[pulumi.Input[Union[str, 'NICType']]]:
        """
        NIC type
        """
        return pulumi.get(self, "nic_type")

    @nic_type.setter
    def nic_type(self, value: Optional[pulumi.Input[Union[str, 'NICType']]]):
        pulumi.set(self, "nic_type", value)

    @property
    @pulumi.getter(name="powerOnBoot")
    def power_on_boot(self) -> Optional[pulumi.Input[Union[str, 'PowerOnBootOption']]]:
        """
        Gets or sets the power on boot.
        """
        return pulumi.get(self, "power_on_boot")

    @power_on_boot.setter
    def power_on_boot(self, value: Optional[pulumi.Input[Union[str, 'PowerOnBootOption']]]):
        pulumi.set(self, "power_on_boot", value)


@pulumi.input_type
class NetworkProfileArgs:
    def __init__(__self__, *,
                 network_interfaces: Optional[pulumi.Input[Sequence[pulumi.Input['NetworkInterfaceArgs']]]] = None):
        """
        Defines the resource properties.
        :param pulumi.Input[Sequence[pulumi.Input['NetworkInterfaceArgs']]] network_interfaces: Gets or sets the list of network interfaces associated with the virtual machine.
        """
        if network_interfaces is not None:
            pulumi.set(__self__, "network_interfaces", network_interfaces)

    @property
    @pulumi.getter(name="networkInterfaces")
    def network_interfaces(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NetworkInterfaceArgs']]]]:
        """
        Gets or sets the list of network interfaces associated with the virtual machine.
        """
        return pulumi.get(self, "network_interfaces")

    @network_interfaces.setter
    def network_interfaces(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NetworkInterfaceArgs']]]]):
        pulumi.set(self, "network_interfaces", value)


@pulumi.input_type
class NicIPSettingsArgs:
    def __init__(__self__, *,
                 allocation_method: Optional[pulumi.Input[Union[str, 'IPAddressAllocationMethod']]] = None,
                 dns_servers: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 gateway: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 ip_address: Optional[pulumi.Input[str]] = None,
                 subnet_mask: Optional[pulumi.Input[str]] = None):
        """
        Defines the network interface ip settings.
        :param pulumi.Input[Union[str, 'IPAddressAllocationMethod']] allocation_method: Gets or sets the nic allocation method.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] dns_servers: Gets or sets the dns servers.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] gateway: Gets or sets the gateway.
        :param pulumi.Input[str] ip_address: Gets or sets the ip address for the nic.
        :param pulumi.Input[str] subnet_mask: Gets or sets the mask.
        """
        if allocation_method is not None:
            pulumi.set(__self__, "allocation_method", allocation_method)
        if dns_servers is not None:
            pulumi.set(__self__, "dns_servers", dns_servers)
        if gateway is not None:
            pulumi.set(__self__, "gateway", gateway)
        if ip_address is not None:
            pulumi.set(__self__, "ip_address", ip_address)
        if subnet_mask is not None:
            pulumi.set(__self__, "subnet_mask", subnet_mask)

    @property
    @pulumi.getter(name="allocationMethod")
    def allocation_method(self) -> Optional[pulumi.Input[Union[str, 'IPAddressAllocationMethod']]]:
        """
        Gets or sets the nic allocation method.
        """
        return pulumi.get(self, "allocation_method")

    @allocation_method.setter
    def allocation_method(self, value: Optional[pulumi.Input[Union[str, 'IPAddressAllocationMethod']]]):
        pulumi.set(self, "allocation_method", value)

    @property
    @pulumi.getter(name="dnsServers")
    def dns_servers(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Gets or sets the dns servers.
        """
        return pulumi.get(self, "dns_servers")

    @dns_servers.setter
    def dns_servers(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "dns_servers", value)

    @property
    @pulumi.getter
    def gateway(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Gets or sets the gateway.
        """
        return pulumi.get(self, "gateway")

    @gateway.setter
    def gateway(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "gateway", value)

    @property
    @pulumi.getter(name="ipAddress")
    def ip_address(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the ip address for the nic.
        """
        return pulumi.get(self, "ip_address")

    @ip_address.setter
    def ip_address(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ip_address", value)

    @property
    @pulumi.getter(name="subnetMask")
    def subnet_mask(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the mask.
        """
        return pulumi.get(self, "subnet_mask")

    @subnet_mask.setter
    def subnet_mask(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "subnet_mask", value)


@pulumi.input_type
class OsProfileLinuxConfigurationArgs:
    def __init__(__self__, *,
                 assessment_mode: Optional[pulumi.Input[str]] = None,
                 patch_mode: Optional[pulumi.Input[str]] = None):
        """
        Specifies the linux configuration for update management.
        :param pulumi.Input[str] assessment_mode: Specifies the assessment mode.
        :param pulumi.Input[str] patch_mode: Specifies the patch mode.
        """
        if assessment_mode is not None:
            pulumi.set(__self__, "assessment_mode", assessment_mode)
        if patch_mode is not None:
            pulumi.set(__self__, "patch_mode", patch_mode)

    @property
    @pulumi.getter(name="assessmentMode")
    def assessment_mode(self) -> Optional[pulumi.Input[str]]:
        """
        Specifies the assessment mode.
        """
        return pulumi.get(self, "assessment_mode")

    @assessment_mode.setter
    def assessment_mode(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "assessment_mode", value)

    @property
    @pulumi.getter(name="patchMode")
    def patch_mode(self) -> Optional[pulumi.Input[str]]:
        """
        Specifies the patch mode.
        """
        return pulumi.get(self, "patch_mode")

    @patch_mode.setter
    def patch_mode(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "patch_mode", value)


@pulumi.input_type
class OsProfileWindowsConfigurationArgs:
    def __init__(__self__, *,
                 assessment_mode: Optional[pulumi.Input[str]] = None,
                 patch_mode: Optional[pulumi.Input[str]] = None):
        """
        Specifies the windows configuration for update management.
        :param pulumi.Input[str] assessment_mode: Specifies the assessment mode.
        :param pulumi.Input[str] patch_mode: Specifies the patch mode.
        """
        if assessment_mode is not None:
            pulumi.set(__self__, "assessment_mode", assessment_mode)
        if patch_mode is not None:
            pulumi.set(__self__, "patch_mode", patch_mode)

    @property
    @pulumi.getter(name="assessmentMode")
    def assessment_mode(self) -> Optional[pulumi.Input[str]]:
        """
        Specifies the assessment mode.
        """
        return pulumi.get(self, "assessment_mode")

    @assessment_mode.setter
    def assessment_mode(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "assessment_mode", value)

    @property
    @pulumi.getter(name="patchMode")
    def patch_mode(self) -> Optional[pulumi.Input[str]]:
        """
        Specifies the patch mode.
        """
        return pulumi.get(self, "patch_mode")

    @patch_mode.setter
    def patch_mode(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "patch_mode", value)


@pulumi.input_type
class OsProfileArgs:
    def __init__(__self__, *,
                 admin_password: Optional[pulumi.Input[str]] = None,
                 admin_username: Optional[pulumi.Input[str]] = None,
                 computer_name: Optional[pulumi.Input[str]] = None,
                 guest_id: Optional[pulumi.Input[str]] = None,
                 linux_configuration: Optional[pulumi.Input['OsProfileLinuxConfigurationArgs']] = None,
                 os_type: Optional[pulumi.Input[Union[str, 'OsType']]] = None,
                 windows_configuration: Optional[pulumi.Input['OsProfileWindowsConfigurationArgs']] = None):
        """
        Defines the resource properties.
        :param pulumi.Input[str] admin_password: Gets or sets administrator password.
        :param pulumi.Input[str] admin_username: Gets or sets administrator username.
        :param pulumi.Input[str] computer_name: Gets or sets computer name.
        :param pulumi.Input[str] guest_id: Gets or sets the guestId.
        :param pulumi.Input['OsProfileLinuxConfigurationArgs'] linux_configuration: Specifies the linux configuration for update management.
        :param pulumi.Input[Union[str, 'OsType']] os_type: Gets or sets the type of the os.
        :param pulumi.Input['OsProfileWindowsConfigurationArgs'] windows_configuration: Specifies the windows configuration for update management.
        """
        if admin_password is not None:
            pulumi.set(__self__, "admin_password", admin_password)
        if admin_username is not None:
            pulumi.set(__self__, "admin_username", admin_username)
        if computer_name is not None:
            pulumi.set(__self__, "computer_name", computer_name)
        if guest_id is not None:
            pulumi.set(__self__, "guest_id", guest_id)
        if linux_configuration is not None:
            pulumi.set(__self__, "linux_configuration", linux_configuration)
        if os_type is not None:
            pulumi.set(__self__, "os_type", os_type)
        if windows_configuration is not None:
            pulumi.set(__self__, "windows_configuration", windows_configuration)

    @property
    @pulumi.getter(name="adminPassword")
    def admin_password(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets administrator password.
        """
        return pulumi.get(self, "admin_password")

    @admin_password.setter
    def admin_password(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "admin_password", value)

    @property
    @pulumi.getter(name="adminUsername")
    def admin_username(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets administrator username.
        """
        return pulumi.get(self, "admin_username")

    @admin_username.setter
    def admin_username(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "admin_username", value)

    @property
    @pulumi.getter(name="computerName")
    def computer_name(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets computer name.
        """
        return pulumi.get(self, "computer_name")

    @computer_name.setter
    def computer_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "computer_name", value)

    @property
    @pulumi.getter(name="guestId")
    def guest_id(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the guestId.
        """
        return pulumi.get(self, "guest_id")

    @guest_id.setter
    def guest_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "guest_id", value)

    @property
    @pulumi.getter(name="linuxConfiguration")
    def linux_configuration(self) -> Optional[pulumi.Input['OsProfileLinuxConfigurationArgs']]:
        """
        Specifies the linux configuration for update management.
        """
        return pulumi.get(self, "linux_configuration")

    @linux_configuration.setter
    def linux_configuration(self, value: Optional[pulumi.Input['OsProfileLinuxConfigurationArgs']]):
        pulumi.set(self, "linux_configuration", value)

    @property
    @pulumi.getter(name="osType")
    def os_type(self) -> Optional[pulumi.Input[Union[str, 'OsType']]]:
        """
        Gets or sets the type of the os.
        """
        return pulumi.get(self, "os_type")

    @os_type.setter
    def os_type(self, value: Optional[pulumi.Input[Union[str, 'OsType']]]):
        pulumi.set(self, "os_type", value)

    @property
    @pulumi.getter(name="windowsConfiguration")
    def windows_configuration(self) -> Optional[pulumi.Input['OsProfileWindowsConfigurationArgs']]:
        """
        Specifies the windows configuration for update management.
        """
        return pulumi.get(self, "windows_configuration")

    @windows_configuration.setter
    def windows_configuration(self, value: Optional[pulumi.Input['OsProfileWindowsConfigurationArgs']]):
        pulumi.set(self, "windows_configuration", value)


@pulumi.input_type
class PlacementProfileArgs:
    def __init__(__self__, *,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 datastore_id: Optional[pulumi.Input[str]] = None,
                 host_id: Optional[pulumi.Input[str]] = None,
                 resource_pool_id: Optional[pulumi.Input[str]] = None):
        """
        Defines the resource properties.
        :param pulumi.Input[str] cluster_id: Gets or sets the ARM Id of the cluster resource on which this virtual machine will deploy.
        :param pulumi.Input[str] datastore_id: Gets or sets the ARM Id of the datastore resource on which the data for the virtual machine will be kept.
        :param pulumi.Input[str] host_id: Gets or sets the ARM Id of the host resource on which this virtual machine will deploy.
        :param pulumi.Input[str] resource_pool_id: Gets or sets the ARM Id of the resourcePool resource on which this virtual machine will deploy.
        """
        if cluster_id is not None:
            pulumi.set(__self__, "cluster_id", cluster_id)
        if datastore_id is not None:
            pulumi.set(__self__, "datastore_id", datastore_id)
        if host_id is not None:
            pulumi.set(__self__, "host_id", host_id)
        if resource_pool_id is not None:
            pulumi.set(__self__, "resource_pool_id", resource_pool_id)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the ARM Id of the cluster resource on which this virtual machine will deploy.
        """
        return pulumi.get(self, "cluster_id")

    @cluster_id.setter
    def cluster_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cluster_id", value)

    @property
    @pulumi.getter(name="datastoreId")
    def datastore_id(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the ARM Id of the datastore resource on which the data for the virtual machine will be kept.
        """
        return pulumi.get(self, "datastore_id")

    @datastore_id.setter
    def datastore_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "datastore_id", value)

    @property
    @pulumi.getter(name="hostId")
    def host_id(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the ARM Id of the host resource on which this virtual machine will deploy.
        """
        return pulumi.get(self, "host_id")

    @host_id.setter
    def host_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "host_id", value)

    @property
    @pulumi.getter(name="resourcePoolId")
    def resource_pool_id(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the ARM Id of the resourcePool resource on which this virtual machine will deploy.
        """
        return pulumi.get(self, "resource_pool_id")

    @resource_pool_id.setter
    def resource_pool_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "resource_pool_id", value)


@pulumi.input_type
class SecurityProfileArgs:
    def __init__(__self__, *,
                 uefi_settings: Optional[pulumi.Input['UefiSettingsArgs']] = None):
        """
        Specifies the Security profile settings for the virtual machine.
        :param pulumi.Input['UefiSettingsArgs'] uefi_settings: Specifies the security settings like secure boot used while creating the virtual machine.
        """
        if uefi_settings is not None:
            pulumi.set(__self__, "uefi_settings", uefi_settings)

    @property
    @pulumi.getter(name="uefiSettings")
    def uefi_settings(self) -> Optional[pulumi.Input['UefiSettingsArgs']]:
        """
        Specifies the security settings like secure boot used while creating the virtual machine.
        """
        return pulumi.get(self, "uefi_settings")

    @uefi_settings.setter
    def uefi_settings(self, value: Optional[pulumi.Input['UefiSettingsArgs']]):
        pulumi.set(self, "uefi_settings", value)


@pulumi.input_type
class StorageProfileArgs:
    def __init__(__self__, *,
                 disks: Optional[pulumi.Input[Sequence[pulumi.Input['VirtualDiskArgs']]]] = None):
        """
        Defines the resource properties.
        :param pulumi.Input[Sequence[pulumi.Input['VirtualDiskArgs']]] disks: Gets or sets the list of virtual disks associated with the virtual machine.
        """
        if disks is not None:
            pulumi.set(__self__, "disks", disks)

    @property
    @pulumi.getter
    def disks(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['VirtualDiskArgs']]]]:
        """
        Gets or sets the list of virtual disks associated with the virtual machine.
        """
        return pulumi.get(self, "disks")

    @disks.setter
    def disks(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['VirtualDiskArgs']]]]):
        pulumi.set(self, "disks", value)


@pulumi.input_type
class UefiSettingsArgs:
    def __init__(__self__, *,
                 secure_boot_enabled: Optional[pulumi.Input[bool]] = None):
        """
        Specifies the security settings like secure boot used while creating the virtual machine.
        :param pulumi.Input[bool] secure_boot_enabled: Specifies whether secure boot should be enabled on the virtual machine.
        """
        if secure_boot_enabled is not None:
            pulumi.set(__self__, "secure_boot_enabled", secure_boot_enabled)

    @property
    @pulumi.getter(name="secureBootEnabled")
    def secure_boot_enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        Specifies whether secure boot should be enabled on the virtual machine.
        """
        return pulumi.get(self, "secure_boot_enabled")

    @secure_boot_enabled.setter
    def secure_boot_enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "secure_boot_enabled", value)


@pulumi.input_type
class VICredentialArgs:
    def __init__(__self__, *,
                 password: Optional[pulumi.Input[str]] = None,
                 username: Optional[pulumi.Input[str]] = None):
        """
        Username / Password Credentials to connect to vcenter.
        :param pulumi.Input[str] password: Gets or sets the password to connect with the vCenter.
        :param pulumi.Input[str] username: Gets or sets username to connect with the vCenter.
        """
        if password is not None:
            pulumi.set(__self__, "password", password)
        if username is not None:
            pulumi.set(__self__, "username", username)

    @property
    @pulumi.getter
    def password(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the password to connect with the vCenter.
        """
        return pulumi.get(self, "password")

    @password.setter
    def password(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "password", value)

    @property
    @pulumi.getter
    def username(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets username to connect with the vCenter.
        """
        return pulumi.get(self, "username")

    @username.setter
    def username(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "username", value)


@pulumi.input_type
class VirtualDiskArgs:
    def __init__(__self__, *,
                 controller_key: Optional[pulumi.Input[int]] = None,
                 device_key: Optional[pulumi.Input[int]] = None,
                 device_name: Optional[pulumi.Input[str]] = None,
                 disk_mode: Optional[pulumi.Input[Union[str, 'DiskMode']]] = None,
                 disk_size_gb: Optional[pulumi.Input[int]] = None,
                 disk_type: Optional[pulumi.Input[Union[str, 'DiskType']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 unit_number: Optional[pulumi.Input[int]] = None):
        """
        Virtual disk model
        :param pulumi.Input[int] controller_key: Gets or sets the controller id.
        :param pulumi.Input[int] device_key: Gets or sets the device key value.
        :param pulumi.Input[str] device_name: Gets or sets the device name.
        :param pulumi.Input[Union[str, 'DiskMode']] disk_mode: Gets or sets the disk mode.
        :param pulumi.Input[int] disk_size_gb: Gets or sets the disk total size.
        :param pulumi.Input[Union[str, 'DiskType']] disk_type: Gets or sets the disk backing type.
        :param pulumi.Input[str] name: Gets or sets the name of the virtual disk.
        :param pulumi.Input[int] unit_number: Gets or sets the unit number of the disk on the controller.
        """
        if controller_key is not None:
            pulumi.set(__self__, "controller_key", controller_key)
        if device_key is not None:
            pulumi.set(__self__, "device_key", device_key)
        if device_name is not None:
            pulumi.set(__self__, "device_name", device_name)
        if disk_mode is not None:
            pulumi.set(__self__, "disk_mode", disk_mode)
        if disk_size_gb is not None:
            pulumi.set(__self__, "disk_size_gb", disk_size_gb)
        if disk_type is not None:
            pulumi.set(__self__, "disk_type", disk_type)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if unit_number is not None:
            pulumi.set(__self__, "unit_number", unit_number)

    @property
    @pulumi.getter(name="controllerKey")
    def controller_key(self) -> Optional[pulumi.Input[int]]:
        """
        Gets or sets the controller id.
        """
        return pulumi.get(self, "controller_key")

    @controller_key.setter
    def controller_key(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "controller_key", value)

    @property
    @pulumi.getter(name="deviceKey")
    def device_key(self) -> Optional[pulumi.Input[int]]:
        """
        Gets or sets the device key value.
        """
        return pulumi.get(self, "device_key")

    @device_key.setter
    def device_key(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "device_key", value)

    @property
    @pulumi.getter(name="deviceName")
    def device_name(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the device name.
        """
        return pulumi.get(self, "device_name")

    @device_name.setter
    def device_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "device_name", value)

    @property
    @pulumi.getter(name="diskMode")
    def disk_mode(self) -> Optional[pulumi.Input[Union[str, 'DiskMode']]]:
        """
        Gets or sets the disk mode.
        """
        return pulumi.get(self, "disk_mode")

    @disk_mode.setter
    def disk_mode(self, value: Optional[pulumi.Input[Union[str, 'DiskMode']]]):
        pulumi.set(self, "disk_mode", value)

    @property
    @pulumi.getter(name="diskSizeGB")
    def disk_size_gb(self) -> Optional[pulumi.Input[int]]:
        """
        Gets or sets the disk total size.
        """
        return pulumi.get(self, "disk_size_gb")

    @disk_size_gb.setter
    def disk_size_gb(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "disk_size_gb", value)

    @property
    @pulumi.getter(name="diskType")
    def disk_type(self) -> Optional[pulumi.Input[Union[str, 'DiskType']]]:
        """
        Gets or sets the disk backing type.
        """
        return pulumi.get(self, "disk_type")

    @disk_type.setter
    def disk_type(self, value: Optional[pulumi.Input[Union[str, 'DiskType']]]):
        pulumi.set(self, "disk_type", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the name of the virtual disk.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="unitNumber")
    def unit_number(self) -> Optional[pulumi.Input[int]]:
        """
        Gets or sets the unit number of the disk on the controller.
        """
        return pulumi.get(self, "unit_number")

    @unit_number.setter
    def unit_number(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "unit_number", value)


