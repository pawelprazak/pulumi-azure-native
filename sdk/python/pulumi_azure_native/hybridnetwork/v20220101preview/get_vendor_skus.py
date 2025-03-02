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
    'GetVendorSkusResult',
    'AwaitableGetVendorSkusResult',
    'get_vendor_skus',
    'get_vendor_skus_output',
]

@pulumi.output_type
class GetVendorSkusResult:
    """
    Sku sub resource.
    """
    def __init__(__self__, deployment_mode=None, id=None, managed_application_parameters=None, managed_application_template=None, name=None, network_function_template=None, network_function_type=None, preview=None, provisioning_state=None, sku_type=None, system_data=None, type=None):
        if deployment_mode and not isinstance(deployment_mode, str):
            raise TypeError("Expected argument 'deployment_mode' to be a str")
        pulumi.set(__self__, "deployment_mode", deployment_mode)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if managed_application_parameters and not isinstance(managed_application_parameters, dict):
            raise TypeError("Expected argument 'managed_application_parameters' to be a dict")
        pulumi.set(__self__, "managed_application_parameters", managed_application_parameters)
        if managed_application_template and not isinstance(managed_application_template, dict):
            raise TypeError("Expected argument 'managed_application_template' to be a dict")
        pulumi.set(__self__, "managed_application_template", managed_application_template)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if network_function_template and not isinstance(network_function_template, dict):
            raise TypeError("Expected argument 'network_function_template' to be a dict")
        pulumi.set(__self__, "network_function_template", network_function_template)
        if network_function_type and not isinstance(network_function_type, str):
            raise TypeError("Expected argument 'network_function_type' to be a str")
        pulumi.set(__self__, "network_function_type", network_function_type)
        if preview and not isinstance(preview, bool):
            raise TypeError("Expected argument 'preview' to be a bool")
        pulumi.set(__self__, "preview", preview)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if sku_type and not isinstance(sku_type, str):
            raise TypeError("Expected argument 'sku_type' to be a str")
        pulumi.set(__self__, "sku_type", sku_type)
        if system_data and not isinstance(system_data, dict):
            raise TypeError("Expected argument 'system_data' to be a dict")
        pulumi.set(__self__, "system_data", system_data)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="deploymentMode")
    def deployment_mode(self) -> Optional[str]:
        """
        The sku deployment mode.
        """
        return pulumi.get(self, "deployment_mode")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="managedApplicationParameters")
    def managed_application_parameters(self) -> Optional[Any]:
        """
        The parameters for the managed application to be supplied by the vendor.
        """
        return pulumi.get(self, "managed_application_parameters")

    @property
    @pulumi.getter(name="managedApplicationTemplate")
    def managed_application_template(self) -> Optional[Any]:
        """
        The template for the managed application deployment.
        """
        return pulumi.get(self, "managed_application_template")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkFunctionTemplate")
    def network_function_template(self) -> Optional['outputs.NetworkFunctionTemplateResponse']:
        """
        The template definition of the network function.
        """
        return pulumi.get(self, "network_function_template")

    @property
    @pulumi.getter(name="networkFunctionType")
    def network_function_type(self) -> Optional[str]:
        """
        The network function type.
        """
        return pulumi.get(self, "network_function_type")

    @property
    @pulumi.getter
    def preview(self) -> Optional[bool]:
        """
        Indicates if the vendor sku is in preview mode.
        """
        return pulumi.get(self, "preview")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        The provisioning state of the vendor sku sub resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="skuType")
    def sku_type(self) -> Optional[str]:
        """
        The sku type.
        """
        return pulumi.get(self, "sku_type")

    @property
    @pulumi.getter(name="systemData")
    def system_data(self) -> 'outputs.SystemDataResponse':
        """
        The system meta data relating to this resource.
        """
        return pulumi.get(self, "system_data")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")


class AwaitableGetVendorSkusResult(GetVendorSkusResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetVendorSkusResult(
            deployment_mode=self.deployment_mode,
            id=self.id,
            managed_application_parameters=self.managed_application_parameters,
            managed_application_template=self.managed_application_template,
            name=self.name,
            network_function_template=self.network_function_template,
            network_function_type=self.network_function_type,
            preview=self.preview,
            provisioning_state=self.provisioning_state,
            sku_type=self.sku_type,
            system_data=self.system_data,
            type=self.type)


def get_vendor_skus(sku_name: Optional[str] = None,
                    vendor_name: Optional[str] = None,
                    opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetVendorSkusResult:
    """
    Sku sub resource.


    :param str sku_name: The name of the sku.
    :param str vendor_name: The name of the vendor.
    """
    __args__ = dict()
    __args__['skuName'] = sku_name
    __args__['vendorName'] = vendor_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:hybridnetwork/v20220101preview:getVendorSkus', __args__, opts=opts, typ=GetVendorSkusResult).value

    return AwaitableGetVendorSkusResult(
        deployment_mode=__ret__.deployment_mode,
        id=__ret__.id,
        managed_application_parameters=__ret__.managed_application_parameters,
        managed_application_template=__ret__.managed_application_template,
        name=__ret__.name,
        network_function_template=__ret__.network_function_template,
        network_function_type=__ret__.network_function_type,
        preview=__ret__.preview,
        provisioning_state=__ret__.provisioning_state,
        sku_type=__ret__.sku_type,
        system_data=__ret__.system_data,
        type=__ret__.type)


@_utilities.lift_output_func(get_vendor_skus)
def get_vendor_skus_output(sku_name: Optional[pulumi.Input[str]] = None,
                           vendor_name: Optional[pulumi.Input[str]] = None,
                           opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetVendorSkusResult]:
    """
    Sku sub resource.


    :param str sku_name: The name of the sku.
    :param str vendor_name: The name of the vendor.
    """
    ...
