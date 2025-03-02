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
    'ListManagedClusterAdminCredentialsResult',
    'AwaitableListManagedClusterAdminCredentialsResult',
    'list_managed_cluster_admin_credentials',
    'list_managed_cluster_admin_credentials_output',
]

@pulumi.output_type
class ListManagedClusterAdminCredentialsResult:
    """
    The list credential result response.
    """
    def __init__(__self__, kubeconfigs=None):
        if kubeconfigs and not isinstance(kubeconfigs, list):
            raise TypeError("Expected argument 'kubeconfigs' to be a list")
        pulumi.set(__self__, "kubeconfigs", kubeconfigs)

    @property
    @pulumi.getter
    def kubeconfigs(self) -> Sequence['outputs.CredentialResultResponse']:
        """
        Base64-encoded Kubernetes configuration file.
        """
        return pulumi.get(self, "kubeconfigs")


class AwaitableListManagedClusterAdminCredentialsResult(ListManagedClusterAdminCredentialsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return ListManagedClusterAdminCredentialsResult(
            kubeconfigs=self.kubeconfigs)


def list_managed_cluster_admin_credentials(resource_group_name: Optional[str] = None,
                                           resource_name: Optional[str] = None,
                                           server_fqdn: Optional[str] = None,
                                           opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableListManagedClusterAdminCredentialsResult:
    """
    The list credential result response.


    :param str resource_group_name: The name of the resource group.
    :param str resource_name: The name of the managed cluster resource.
    :param str server_fqdn: server fqdn type for credentials to be returned
    """
    __args__ = dict()
    __args__['resourceGroupName'] = resource_group_name
    __args__['resourceName'] = resource_name
    __args__['serverFqdn'] = server_fqdn
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:containerservice/v20211001:listManagedClusterAdminCredentials', __args__, opts=opts, typ=ListManagedClusterAdminCredentialsResult).value

    return AwaitableListManagedClusterAdminCredentialsResult(
        kubeconfigs=__ret__.kubeconfigs)


@_utilities.lift_output_func(list_managed_cluster_admin_credentials)
def list_managed_cluster_admin_credentials_output(resource_group_name: Optional[pulumi.Input[str]] = None,
                                                  resource_name: Optional[pulumi.Input[str]] = None,
                                                  server_fqdn: Optional[pulumi.Input[Optional[str]]] = None,
                                                  opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[ListManagedClusterAdminCredentialsResult]:
    """
    The list credential result response.


    :param str resource_group_name: The name of the resource group.
    :param str resource_name: The name of the managed cluster resource.
    :param str server_fqdn: server fqdn type for credentials to be returned
    """
    ...
