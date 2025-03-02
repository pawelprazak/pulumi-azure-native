# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'GetKeyValueResult',
    'AwaitableGetKeyValueResult',
    'get_key_value',
    'get_key_value_output',
]

@pulumi.output_type
class GetKeyValueResult:
    """
    The key-value resource along with all resource properties.
    """
    def __init__(__self__, content_type=None, e_tag=None, id=None, key=None, label=None, last_modified=None, locked=None, name=None, tags=None, type=None, value=None):
        if content_type and not isinstance(content_type, str):
            raise TypeError("Expected argument 'content_type' to be a str")
        pulumi.set(__self__, "content_type", content_type)
        if e_tag and not isinstance(e_tag, str):
            raise TypeError("Expected argument 'e_tag' to be a str")
        pulumi.set(__self__, "e_tag", e_tag)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if key and not isinstance(key, str):
            raise TypeError("Expected argument 'key' to be a str")
        pulumi.set(__self__, "key", key)
        if label and not isinstance(label, str):
            raise TypeError("Expected argument 'label' to be a str")
        pulumi.set(__self__, "label", label)
        if last_modified and not isinstance(last_modified, str):
            raise TypeError("Expected argument 'last_modified' to be a str")
        pulumi.set(__self__, "last_modified", last_modified)
        if locked and not isinstance(locked, bool):
            raise TypeError("Expected argument 'locked' to be a bool")
        pulumi.set(__self__, "locked", locked)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if value and not isinstance(value, str):
            raise TypeError("Expected argument 'value' to be a str")
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter(name="contentType")
    def content_type(self) -> Optional[str]:
        """
        The content type of the key-value's value.
        Providing a proper content-type can enable transformations of values when they are retrieved by applications.
        """
        return pulumi.get(self, "content_type")

    @property
    @pulumi.getter(name="eTag")
    def e_tag(self) -> str:
        """
        An ETag indicating the state of a key-value within a configuration store.
        """
        return pulumi.get(self, "e_tag")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The resource ID.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def key(self) -> str:
        """
        The primary identifier of a key-value.
        The key is used in unison with the label to uniquely identify a key-value.
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def label(self) -> str:
        """
        A value used to group key-values.
        The label is used in unison with the key to uniquely identify a key-value.
        """
        return pulumi.get(self, "label")

    @property
    @pulumi.getter(name="lastModified")
    def last_modified(self) -> str:
        """
        The last time a modifying operation was performed on the given key-value.
        """
        return pulumi.get(self, "last_modified")

    @property
    @pulumi.getter
    def locked(self) -> bool:
        """
        A value indicating whether the key-value is locked.
        A locked key-value may not be modified until it is unlocked.
        """
        return pulumi.get(self, "locked")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the resource.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        A dictionary of tags that can help identify what a key-value may be applicable for.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def value(self) -> Optional[str]:
        """
        The value of the key-value.
        """
        return pulumi.get(self, "value")


class AwaitableGetKeyValueResult(GetKeyValueResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetKeyValueResult(
            content_type=self.content_type,
            e_tag=self.e_tag,
            id=self.id,
            key=self.key,
            label=self.label,
            last_modified=self.last_modified,
            locked=self.locked,
            name=self.name,
            tags=self.tags,
            type=self.type,
            value=self.value)


def get_key_value(config_store_name: Optional[str] = None,
                  key_value_name: Optional[str] = None,
                  resource_group_name: Optional[str] = None,
                  opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetKeyValueResult:
    """
    The key-value resource along with all resource properties.


    :param str config_store_name: The name of the configuration store.
    :param str key_value_name: Identifier of key and label combination. Key and label are joined by $ character. Label is optional.
    :param str resource_group_name: The name of the resource group to which the container registry belongs.
    """
    __args__ = dict()
    __args__['configStoreName'] = config_store_name
    __args__['keyValueName'] = key_value_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:appconfiguration/v20211001preview:getKeyValue', __args__, opts=opts, typ=GetKeyValueResult).value

    return AwaitableGetKeyValueResult(
        content_type=__ret__.content_type,
        e_tag=__ret__.e_tag,
        id=__ret__.id,
        key=__ret__.key,
        label=__ret__.label,
        last_modified=__ret__.last_modified,
        locked=__ret__.locked,
        name=__ret__.name,
        tags=__ret__.tags,
        type=__ret__.type,
        value=__ret__.value)


@_utilities.lift_output_func(get_key_value)
def get_key_value_output(config_store_name: Optional[pulumi.Input[str]] = None,
                         key_value_name: Optional[pulumi.Input[str]] = None,
                         resource_group_name: Optional[pulumi.Input[str]] = None,
                         opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetKeyValueResult]:
    """
    The key-value resource along with all resource properties.


    :param str config_store_name: The name of the configuration store.
    :param str key_value_name: Identifier of key and label combination. Key and label are joined by $ character. Label is optional.
    :param str resource_group_name: The name of the resource group to which the container registry belongs.
    """
    ...
