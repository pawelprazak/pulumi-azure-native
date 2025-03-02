# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'GetAppResourceUploadUrlResult',
    'AwaitableGetAppResourceUploadUrlResult',
    'get_app_resource_upload_url',
    'get_app_resource_upload_url_output',
]

@pulumi.output_type
class GetAppResourceUploadUrlResult:
    """
    Resource upload definition payload
    """
    def __init__(__self__, relative_path=None, upload_url=None):
        if relative_path and not isinstance(relative_path, str):
            raise TypeError("Expected argument 'relative_path' to be a str")
        pulumi.set(__self__, "relative_path", relative_path)
        if upload_url and not isinstance(upload_url, str):
            raise TypeError("Expected argument 'upload_url' to be a str")
        pulumi.set(__self__, "upload_url", upload_url)

    @property
    @pulumi.getter(name="relativePath")
    def relative_path(self) -> Optional[str]:
        """
        Source relative path
        """
        return pulumi.get(self, "relative_path")

    @property
    @pulumi.getter(name="uploadUrl")
    def upload_url(self) -> Optional[str]:
        """
        Upload URL
        """
        return pulumi.get(self, "upload_url")


class AwaitableGetAppResourceUploadUrlResult(GetAppResourceUploadUrlResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetAppResourceUploadUrlResult(
            relative_path=self.relative_path,
            upload_url=self.upload_url)


def get_app_resource_upload_url(app_name: Optional[str] = None,
                                resource_group_name: Optional[str] = None,
                                service_name: Optional[str] = None,
                                opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetAppResourceUploadUrlResult:
    """
    Resource upload definition payload


    :param str app_name: The name of the App resource.
    :param str resource_group_name: The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
    :param str service_name: The name of the Service resource.
    """
    __args__ = dict()
    __args__['appName'] = app_name
    __args__['resourceGroupName'] = resource_group_name
    __args__['serviceName'] = service_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:appplatform/v20220301preview:getAppResourceUploadUrl', __args__, opts=opts, typ=GetAppResourceUploadUrlResult).value

    return AwaitableGetAppResourceUploadUrlResult(
        relative_path=__ret__.relative_path,
        upload_url=__ret__.upload_url)


@_utilities.lift_output_func(get_app_resource_upload_url)
def get_app_resource_upload_url_output(app_name: Optional[pulumi.Input[str]] = None,
                                       resource_group_name: Optional[pulumi.Input[str]] = None,
                                       service_name: Optional[pulumi.Input[str]] = None,
                                       opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetAppResourceUploadUrlResult]:
    """
    Resource upload definition payload


    :param str app_name: The name of the App resource.
    :param str resource_group_name: The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
    :param str service_name: The name of the Service resource.
    """
    ...
