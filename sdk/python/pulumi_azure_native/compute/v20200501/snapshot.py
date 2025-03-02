# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from . import outputs
from ._enums import *
from ._inputs import *

__all__ = ['SnapshotArgs', 'Snapshot']

@pulumi.input_type
class SnapshotArgs:
    def __init__(__self__, *,
                 creation_data: pulumi.Input['CreationDataArgs'],
                 resource_group_name: pulumi.Input[str],
                 disk_access_id: Optional[pulumi.Input[str]] = None,
                 disk_size_gb: Optional[pulumi.Input[int]] = None,
                 encryption: Optional[pulumi.Input['EncryptionArgs']] = None,
                 encryption_settings_collection: Optional[pulumi.Input['EncryptionSettingsCollectionArgs']] = None,
                 hyper_v_generation: Optional[pulumi.Input[Union[str, 'HyperVGeneration']]] = None,
                 incremental: Optional[pulumi.Input[bool]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 network_access_policy: Optional[pulumi.Input[Union[str, 'NetworkAccessPolicy']]] = None,
                 os_type: Optional[pulumi.Input['OperatingSystemTypes']] = None,
                 sku: Optional[pulumi.Input['SnapshotSkuArgs']] = None,
                 snapshot_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None):
        """
        The set of arguments for constructing a Snapshot resource.
        :param pulumi.Input['CreationDataArgs'] creation_data: Disk source information. CreationData information cannot be changed after the disk has been created.
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[str] disk_access_id: ARM id of the DiskAccess resource for using private endpoints on disks.
        :param pulumi.Input[int] disk_size_gb: If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk's size.
        :param pulumi.Input['EncryptionArgs'] encryption: Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys.
        :param pulumi.Input['EncryptionSettingsCollectionArgs'] encryption_settings_collection: Encryption settings collection used be Azure Disk Encryption, can contain multiple encryption settings per disk or snapshot.
        :param pulumi.Input[Union[str, 'HyperVGeneration']] hyper_v_generation: The hypervisor generation of the Virtual Machine. Applicable to OS disks only.
        :param pulumi.Input[bool] incremental: Whether a snapshot is incremental. Incremental snapshots on the same disk occupy less space than full snapshots and can be diffed.
        :param pulumi.Input[str] location: Resource location
        :param pulumi.Input[Union[str, 'NetworkAccessPolicy']] network_access_policy: Policy for accessing the disk via network.
        :param pulumi.Input['OperatingSystemTypes'] os_type: The Operating System type.
        :param pulumi.Input['SnapshotSkuArgs'] sku: The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS.
        :param pulumi.Input[str] snapshot_name: The name of the snapshot that is being created. The name can't be changed after the snapshot is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The max name length is 80 characters.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags
        """
        pulumi.set(__self__, "creation_data", creation_data)
        pulumi.set(__self__, "resource_group_name", resource_group_name)
        if disk_access_id is not None:
            pulumi.set(__self__, "disk_access_id", disk_access_id)
        if disk_size_gb is not None:
            pulumi.set(__self__, "disk_size_gb", disk_size_gb)
        if encryption is not None:
            pulumi.set(__self__, "encryption", encryption)
        if encryption_settings_collection is not None:
            pulumi.set(__self__, "encryption_settings_collection", encryption_settings_collection)
        if hyper_v_generation is not None:
            pulumi.set(__self__, "hyper_v_generation", hyper_v_generation)
        if incremental is not None:
            pulumi.set(__self__, "incremental", incremental)
        if location is not None:
            pulumi.set(__self__, "location", location)
        if network_access_policy is not None:
            pulumi.set(__self__, "network_access_policy", network_access_policy)
        if os_type is not None:
            pulumi.set(__self__, "os_type", os_type)
        if sku is not None:
            pulumi.set(__self__, "sku", sku)
        if snapshot_name is not None:
            pulumi.set(__self__, "snapshot_name", snapshot_name)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="creationData")
    def creation_data(self) -> pulumi.Input['CreationDataArgs']:
        """
        Disk source information. CreationData information cannot be changed after the disk has been created.
        """
        return pulumi.get(self, "creation_data")

    @creation_data.setter
    def creation_data(self, value: pulumi.Input['CreationDataArgs']):
        pulumi.set(self, "creation_data", value)

    @property
    @pulumi.getter(name="resourceGroupName")
    def resource_group_name(self) -> pulumi.Input[str]:
        """
        The name of the resource group.
        """
        return pulumi.get(self, "resource_group_name")

    @resource_group_name.setter
    def resource_group_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "resource_group_name", value)

    @property
    @pulumi.getter(name="diskAccessId")
    def disk_access_id(self) -> Optional[pulumi.Input[str]]:
        """
        ARM id of the DiskAccess resource for using private endpoints on disks.
        """
        return pulumi.get(self, "disk_access_id")

    @disk_access_id.setter
    def disk_access_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "disk_access_id", value)

    @property
    @pulumi.getter(name="diskSizeGB")
    def disk_size_gb(self) -> Optional[pulumi.Input[int]]:
        """
        If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk's size.
        """
        return pulumi.get(self, "disk_size_gb")

    @disk_size_gb.setter
    def disk_size_gb(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "disk_size_gb", value)

    @property
    @pulumi.getter
    def encryption(self) -> Optional[pulumi.Input['EncryptionArgs']]:
        """
        Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys.
        """
        return pulumi.get(self, "encryption")

    @encryption.setter
    def encryption(self, value: Optional[pulumi.Input['EncryptionArgs']]):
        pulumi.set(self, "encryption", value)

    @property
    @pulumi.getter(name="encryptionSettingsCollection")
    def encryption_settings_collection(self) -> Optional[pulumi.Input['EncryptionSettingsCollectionArgs']]:
        """
        Encryption settings collection used be Azure Disk Encryption, can contain multiple encryption settings per disk or snapshot.
        """
        return pulumi.get(self, "encryption_settings_collection")

    @encryption_settings_collection.setter
    def encryption_settings_collection(self, value: Optional[pulumi.Input['EncryptionSettingsCollectionArgs']]):
        pulumi.set(self, "encryption_settings_collection", value)

    @property
    @pulumi.getter(name="hyperVGeneration")
    def hyper_v_generation(self) -> Optional[pulumi.Input[Union[str, 'HyperVGeneration']]]:
        """
        The hypervisor generation of the Virtual Machine. Applicable to OS disks only.
        """
        return pulumi.get(self, "hyper_v_generation")

    @hyper_v_generation.setter
    def hyper_v_generation(self, value: Optional[pulumi.Input[Union[str, 'HyperVGeneration']]]):
        pulumi.set(self, "hyper_v_generation", value)

    @property
    @pulumi.getter
    def incremental(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether a snapshot is incremental. Incremental snapshots on the same disk occupy less space than full snapshots and can be diffed.
        """
        return pulumi.get(self, "incremental")

    @incremental.setter
    def incremental(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "incremental", value)

    @property
    @pulumi.getter
    def location(self) -> Optional[pulumi.Input[str]]:
        """
        Resource location
        """
        return pulumi.get(self, "location")

    @location.setter
    def location(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "location", value)

    @property
    @pulumi.getter(name="networkAccessPolicy")
    def network_access_policy(self) -> Optional[pulumi.Input[Union[str, 'NetworkAccessPolicy']]]:
        """
        Policy for accessing the disk via network.
        """
        return pulumi.get(self, "network_access_policy")

    @network_access_policy.setter
    def network_access_policy(self, value: Optional[pulumi.Input[Union[str, 'NetworkAccessPolicy']]]):
        pulumi.set(self, "network_access_policy", value)

    @property
    @pulumi.getter(name="osType")
    def os_type(self) -> Optional[pulumi.Input['OperatingSystemTypes']]:
        """
        The Operating System type.
        """
        return pulumi.get(self, "os_type")

    @os_type.setter
    def os_type(self, value: Optional[pulumi.Input['OperatingSystemTypes']]):
        pulumi.set(self, "os_type", value)

    @property
    @pulumi.getter
    def sku(self) -> Optional[pulumi.Input['SnapshotSkuArgs']]:
        """
        The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS.
        """
        return pulumi.get(self, "sku")

    @sku.setter
    def sku(self, value: Optional[pulumi.Input['SnapshotSkuArgs']]):
        pulumi.set(self, "sku", value)

    @property
    @pulumi.getter(name="snapshotName")
    def snapshot_name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the snapshot that is being created. The name can't be changed after the snapshot is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The max name length is 80 characters.
        """
        return pulumi.get(self, "snapshot_name")

    @snapshot_name.setter
    def snapshot_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "snapshot_name", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "tags", value)


warnings.warn("""Version 2020-05-01 will be removed in v2 of the provider.""", DeprecationWarning)


class Snapshot(pulumi.CustomResource):
    warnings.warn("""Version 2020-05-01 will be removed in v2 of the provider.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 creation_data: Optional[pulumi.Input[pulumi.InputType['CreationDataArgs']]] = None,
                 disk_access_id: Optional[pulumi.Input[str]] = None,
                 disk_size_gb: Optional[pulumi.Input[int]] = None,
                 encryption: Optional[pulumi.Input[pulumi.InputType['EncryptionArgs']]] = None,
                 encryption_settings_collection: Optional[pulumi.Input[pulumi.InputType['EncryptionSettingsCollectionArgs']]] = None,
                 hyper_v_generation: Optional[pulumi.Input[Union[str, 'HyperVGeneration']]] = None,
                 incremental: Optional[pulumi.Input[bool]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 network_access_policy: Optional[pulumi.Input[Union[str, 'NetworkAccessPolicy']]] = None,
                 os_type: Optional[pulumi.Input['OperatingSystemTypes']] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 sku: Optional[pulumi.Input[pulumi.InputType['SnapshotSkuArgs']]] = None,
                 snapshot_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None):
        """
        Snapshot resource.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['CreationDataArgs']] creation_data: Disk source information. CreationData information cannot be changed after the disk has been created.
        :param pulumi.Input[str] disk_access_id: ARM id of the DiskAccess resource for using private endpoints on disks.
        :param pulumi.Input[int] disk_size_gb: If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk's size.
        :param pulumi.Input[pulumi.InputType['EncryptionArgs']] encryption: Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys.
        :param pulumi.Input[pulumi.InputType['EncryptionSettingsCollectionArgs']] encryption_settings_collection: Encryption settings collection used be Azure Disk Encryption, can contain multiple encryption settings per disk or snapshot.
        :param pulumi.Input[Union[str, 'HyperVGeneration']] hyper_v_generation: The hypervisor generation of the Virtual Machine. Applicable to OS disks only.
        :param pulumi.Input[bool] incremental: Whether a snapshot is incremental. Incremental snapshots on the same disk occupy less space than full snapshots and can be diffed.
        :param pulumi.Input[str] location: Resource location
        :param pulumi.Input[Union[str, 'NetworkAccessPolicy']] network_access_policy: Policy for accessing the disk via network.
        :param pulumi.Input['OperatingSystemTypes'] os_type: The Operating System type.
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[pulumi.InputType['SnapshotSkuArgs']] sku: The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS.
        :param pulumi.Input[str] snapshot_name: The name of the snapshot that is being created. The name can't be changed after the snapshot is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The max name length is 80 characters.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: SnapshotArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Snapshot resource.

        :param str resource_name: The name of the resource.
        :param SnapshotArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(SnapshotArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 creation_data: Optional[pulumi.Input[pulumi.InputType['CreationDataArgs']]] = None,
                 disk_access_id: Optional[pulumi.Input[str]] = None,
                 disk_size_gb: Optional[pulumi.Input[int]] = None,
                 encryption: Optional[pulumi.Input[pulumi.InputType['EncryptionArgs']]] = None,
                 encryption_settings_collection: Optional[pulumi.Input[pulumi.InputType['EncryptionSettingsCollectionArgs']]] = None,
                 hyper_v_generation: Optional[pulumi.Input[Union[str, 'HyperVGeneration']]] = None,
                 incremental: Optional[pulumi.Input[bool]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 network_access_policy: Optional[pulumi.Input[Union[str, 'NetworkAccessPolicy']]] = None,
                 os_type: Optional[pulumi.Input['OperatingSystemTypes']] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 sku: Optional[pulumi.Input[pulumi.InputType['SnapshotSkuArgs']]] = None,
                 snapshot_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None):
        pulumi.log.warn("""Snapshot is deprecated: Version 2020-05-01 will be removed in v2 of the provider.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = SnapshotArgs.__new__(SnapshotArgs)

            if creation_data is None and not opts.urn:
                raise TypeError("Missing required property 'creation_data'")
            __props__.__dict__["creation_data"] = creation_data
            __props__.__dict__["disk_access_id"] = disk_access_id
            __props__.__dict__["disk_size_gb"] = disk_size_gb
            __props__.__dict__["encryption"] = encryption
            __props__.__dict__["encryption_settings_collection"] = encryption_settings_collection
            __props__.__dict__["hyper_v_generation"] = hyper_v_generation
            __props__.__dict__["incremental"] = incremental
            __props__.__dict__["location"] = location
            __props__.__dict__["network_access_policy"] = network_access_policy
            __props__.__dict__["os_type"] = os_type
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__.__dict__["resource_group_name"] = resource_group_name
            __props__.__dict__["sku"] = sku
            __props__.__dict__["snapshot_name"] = snapshot_name
            __props__.__dict__["tags"] = tags
            __props__.__dict__["disk_size_bytes"] = None
            __props__.__dict__["managed_by"] = None
            __props__.__dict__["name"] = None
            __props__.__dict__["provisioning_state"] = None
            __props__.__dict__["time_created"] = None
            __props__.__dict__["type"] = None
            __props__.__dict__["unique_id"] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-native:compute:Snapshot"), pulumi.Alias(type_="azure-native:compute/v20160430preview:Snapshot"), pulumi.Alias(type_="azure-native:compute/v20170330:Snapshot"), pulumi.Alias(type_="azure-native:compute/v20180401:Snapshot"), pulumi.Alias(type_="azure-native:compute/v20180601:Snapshot"), pulumi.Alias(type_="azure-native:compute/v20180930:Snapshot"), pulumi.Alias(type_="azure-native:compute/v20190301:Snapshot"), pulumi.Alias(type_="azure-native:compute/v20190701:Snapshot"), pulumi.Alias(type_="azure-native:compute/v20191101:Snapshot"), pulumi.Alias(type_="azure-native:compute/v20200630:Snapshot"), pulumi.Alias(type_="azure-native:compute/v20200930:Snapshot"), pulumi.Alias(type_="azure-native:compute/v20201201:Snapshot"), pulumi.Alias(type_="azure-native:compute/v20210401:Snapshot"), pulumi.Alias(type_="azure-native:compute/v20210801:Snapshot"), pulumi.Alias(type_="azure-native:compute/v20211201:Snapshot")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Snapshot, __self__).__init__(
            'azure-native:compute/v20200501:Snapshot',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Snapshot':
        """
        Get an existing Snapshot resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = SnapshotArgs.__new__(SnapshotArgs)

        __props__.__dict__["creation_data"] = None
        __props__.__dict__["disk_access_id"] = None
        __props__.__dict__["disk_size_bytes"] = None
        __props__.__dict__["disk_size_gb"] = None
        __props__.__dict__["encryption"] = None
        __props__.__dict__["encryption_settings_collection"] = None
        __props__.__dict__["hyper_v_generation"] = None
        __props__.__dict__["incremental"] = None
        __props__.__dict__["location"] = None
        __props__.__dict__["managed_by"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["network_access_policy"] = None
        __props__.__dict__["os_type"] = None
        __props__.__dict__["provisioning_state"] = None
        __props__.__dict__["sku"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["time_created"] = None
        __props__.__dict__["type"] = None
        __props__.__dict__["unique_id"] = None
        return Snapshot(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="creationData")
    def creation_data(self) -> pulumi.Output['outputs.CreationDataResponse']:
        """
        Disk source information. CreationData information cannot be changed after the disk has been created.
        """
        return pulumi.get(self, "creation_data")

    @property
    @pulumi.getter(name="diskAccessId")
    def disk_access_id(self) -> pulumi.Output[Optional[str]]:
        """
        ARM id of the DiskAccess resource for using private endpoints on disks.
        """
        return pulumi.get(self, "disk_access_id")

    @property
    @pulumi.getter(name="diskSizeBytes")
    def disk_size_bytes(self) -> pulumi.Output[float]:
        """
        The size of the disk in bytes. This field is read only.
        """
        return pulumi.get(self, "disk_size_bytes")

    @property
    @pulumi.getter(name="diskSizeGB")
    def disk_size_gb(self) -> pulumi.Output[Optional[int]]:
        """
        If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk's size.
        """
        return pulumi.get(self, "disk_size_gb")

    @property
    @pulumi.getter
    def encryption(self) -> pulumi.Output[Optional['outputs.EncryptionResponse']]:
        """
        Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys.
        """
        return pulumi.get(self, "encryption")

    @property
    @pulumi.getter(name="encryptionSettingsCollection")
    def encryption_settings_collection(self) -> pulumi.Output[Optional['outputs.EncryptionSettingsCollectionResponse']]:
        """
        Encryption settings collection used be Azure Disk Encryption, can contain multiple encryption settings per disk or snapshot.
        """
        return pulumi.get(self, "encryption_settings_collection")

    @property
    @pulumi.getter(name="hyperVGeneration")
    def hyper_v_generation(self) -> pulumi.Output[Optional[str]]:
        """
        The hypervisor generation of the Virtual Machine. Applicable to OS disks only.
        """
        return pulumi.get(self, "hyper_v_generation")

    @property
    @pulumi.getter
    def incremental(self) -> pulumi.Output[Optional[bool]]:
        """
        Whether a snapshot is incremental. Incremental snapshots on the same disk occupy less space than full snapshots and can be diffed.
        """
        return pulumi.get(self, "incremental")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Resource location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="managedBy")
    def managed_by(self) -> pulumi.Output[str]:
        """
        Unused. Always Null.
        """
        return pulumi.get(self, "managed_by")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkAccessPolicy")
    def network_access_policy(self) -> pulumi.Output[Optional[str]]:
        """
        Policy for accessing the disk via network.
        """
        return pulumi.get(self, "network_access_policy")

    @property
    @pulumi.getter(name="osType")
    def os_type(self) -> pulumi.Output[Optional[str]]:
        """
        The Operating System type.
        """
        return pulumi.get(self, "os_type")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        The disk provisioning state.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def sku(self) -> pulumi.Output[Optional['outputs.SnapshotSkuResponse']]:
        """
        The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS.
        """
        return pulumi.get(self, "sku")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="timeCreated")
    def time_created(self) -> pulumi.Output[str]:
        """
        The time when the snapshot was created.
        """
        return pulumi.get(self, "time_created")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="uniqueId")
    def unique_id(self) -> pulumi.Output[str]:
        """
        Unique Guid identifying the resource.
        """
        return pulumi.get(self, "unique_id")

