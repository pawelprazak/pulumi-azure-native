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
    'GetFluxConfigurationResult',
    'AwaitableGetFluxConfigurationResult',
    'get_flux_configuration',
    'get_flux_configuration_output',
]

@pulumi.output_type
class GetFluxConfigurationResult:
    """
    The Flux Configuration object returned in Get & Put response.
    """
    def __init__(__self__, bucket=None, compliance_state=None, configuration_protected_settings=None, error_message=None, git_repository=None, id=None, kustomizations=None, name=None, namespace=None, provisioning_state=None, repository_public_key=None, scope=None, source_kind=None, source_synced_commit_id=None, source_updated_at=None, status_updated_at=None, statuses=None, suspend=None, system_data=None, type=None):
        if bucket and not isinstance(bucket, dict):
            raise TypeError("Expected argument 'bucket' to be a dict")
        pulumi.set(__self__, "bucket", bucket)
        if compliance_state and not isinstance(compliance_state, str):
            raise TypeError("Expected argument 'compliance_state' to be a str")
        pulumi.set(__self__, "compliance_state", compliance_state)
        if configuration_protected_settings and not isinstance(configuration_protected_settings, dict):
            raise TypeError("Expected argument 'configuration_protected_settings' to be a dict")
        pulumi.set(__self__, "configuration_protected_settings", configuration_protected_settings)
        if error_message and not isinstance(error_message, str):
            raise TypeError("Expected argument 'error_message' to be a str")
        pulumi.set(__self__, "error_message", error_message)
        if git_repository and not isinstance(git_repository, dict):
            raise TypeError("Expected argument 'git_repository' to be a dict")
        pulumi.set(__self__, "git_repository", git_repository)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if kustomizations and not isinstance(kustomizations, dict):
            raise TypeError("Expected argument 'kustomizations' to be a dict")
        pulumi.set(__self__, "kustomizations", kustomizations)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if namespace and not isinstance(namespace, str):
            raise TypeError("Expected argument 'namespace' to be a str")
        pulumi.set(__self__, "namespace", namespace)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if repository_public_key and not isinstance(repository_public_key, str):
            raise TypeError("Expected argument 'repository_public_key' to be a str")
        pulumi.set(__self__, "repository_public_key", repository_public_key)
        if scope and not isinstance(scope, str):
            raise TypeError("Expected argument 'scope' to be a str")
        pulumi.set(__self__, "scope", scope)
        if source_kind and not isinstance(source_kind, str):
            raise TypeError("Expected argument 'source_kind' to be a str")
        pulumi.set(__self__, "source_kind", source_kind)
        if source_synced_commit_id and not isinstance(source_synced_commit_id, str):
            raise TypeError("Expected argument 'source_synced_commit_id' to be a str")
        pulumi.set(__self__, "source_synced_commit_id", source_synced_commit_id)
        if source_updated_at and not isinstance(source_updated_at, str):
            raise TypeError("Expected argument 'source_updated_at' to be a str")
        pulumi.set(__self__, "source_updated_at", source_updated_at)
        if status_updated_at and not isinstance(status_updated_at, str):
            raise TypeError("Expected argument 'status_updated_at' to be a str")
        pulumi.set(__self__, "status_updated_at", status_updated_at)
        if statuses and not isinstance(statuses, list):
            raise TypeError("Expected argument 'statuses' to be a list")
        pulumi.set(__self__, "statuses", statuses)
        if suspend and not isinstance(suspend, bool):
            raise TypeError("Expected argument 'suspend' to be a bool")
        pulumi.set(__self__, "suspend", suspend)
        if system_data and not isinstance(system_data, dict):
            raise TypeError("Expected argument 'system_data' to be a dict")
        pulumi.set(__self__, "system_data", system_data)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def bucket(self) -> Optional['outputs.BucketDefinitionResponse']:
        """
        Parameters to reconcile to the Bucket source kind type.
        """
        return pulumi.get(self, "bucket")

    @property
    @pulumi.getter(name="complianceState")
    def compliance_state(self) -> str:
        """
        Combined status of the Flux Kubernetes resources created by the fluxConfiguration or created by the managed objects.
        """
        return pulumi.get(self, "compliance_state")

    @property
    @pulumi.getter(name="configurationProtectedSettings")
    def configuration_protected_settings(self) -> Optional[Mapping[str, str]]:
        """
        Key-value pairs of protected configuration settings for the configuration
        """
        return pulumi.get(self, "configuration_protected_settings")

    @property
    @pulumi.getter(name="errorMessage")
    def error_message(self) -> str:
        """
        Error message returned to the user in the case of provisioning failure.
        """
        return pulumi.get(self, "error_message")

    @property
    @pulumi.getter(name="gitRepository")
    def git_repository(self) -> Optional['outputs.GitRepositoryDefinitionResponse']:
        """
        Parameters to reconcile to the GitRepository source kind type.
        """
        return pulumi.get(self, "git_repository")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def kustomizations(self) -> Optional[Mapping[str, 'outputs.KustomizationDefinitionResponse']]:
        """
        Array of kustomizations used to reconcile the artifact pulled by the source type on the cluster.
        """
        return pulumi.get(self, "kustomizations")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def namespace(self) -> Optional[str]:
        """
        The namespace to which this configuration is installed to. Maximum of 253 lower case alphanumeric characters, hyphen and period only.
        """
        return pulumi.get(self, "namespace")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        Status of the creation of the fluxConfiguration.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="repositoryPublicKey")
    def repository_public_key(self) -> str:
        """
        Public Key associated with this fluxConfiguration (either generated within the cluster or provided by the user).
        """
        return pulumi.get(self, "repository_public_key")

    @property
    @pulumi.getter
    def scope(self) -> Optional[str]:
        """
        Scope at which the operator will be installed.
        """
        return pulumi.get(self, "scope")

    @property
    @pulumi.getter(name="sourceKind")
    def source_kind(self) -> Optional[str]:
        """
        Source Kind to pull the configuration data from.
        """
        return pulumi.get(self, "source_kind")

    @property
    @pulumi.getter(name="sourceSyncedCommitId")
    def source_synced_commit_id(self) -> str:
        """
        Branch and/or SHA of the source commit synced with the cluster.
        """
        return pulumi.get(self, "source_synced_commit_id")

    @property
    @pulumi.getter(name="sourceUpdatedAt")
    def source_updated_at(self) -> str:
        """
        Datetime the fluxConfiguration synced its source on the cluster.
        """
        return pulumi.get(self, "source_updated_at")

    @property
    @pulumi.getter(name="statusUpdatedAt")
    def status_updated_at(self) -> str:
        """
        Datetime the fluxConfiguration synced its status on the cluster with Azure.
        """
        return pulumi.get(self, "status_updated_at")

    @property
    @pulumi.getter
    def statuses(self) -> Sequence['outputs.ObjectStatusDefinitionResponse']:
        """
        Statuses of the Flux Kubernetes resources created by the fluxConfiguration or created by the managed objects provisioned by the fluxConfiguration.
        """
        return pulumi.get(self, "statuses")

    @property
    @pulumi.getter
    def suspend(self) -> Optional[bool]:
        """
        Whether this configuration should suspend its reconciliation of its kustomizations and sources.
        """
        return pulumi.get(self, "suspend")

    @property
    @pulumi.getter(name="systemData")
    def system_data(self) -> 'outputs.SystemDataResponse':
        """
        Top level metadata https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/common-api-contracts.md#system-metadata-for-all-azure-resources
        """
        return pulumi.get(self, "system_data")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")


class AwaitableGetFluxConfigurationResult(GetFluxConfigurationResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetFluxConfigurationResult(
            bucket=self.bucket,
            compliance_state=self.compliance_state,
            configuration_protected_settings=self.configuration_protected_settings,
            error_message=self.error_message,
            git_repository=self.git_repository,
            id=self.id,
            kustomizations=self.kustomizations,
            name=self.name,
            namespace=self.namespace,
            provisioning_state=self.provisioning_state,
            repository_public_key=self.repository_public_key,
            scope=self.scope,
            source_kind=self.source_kind,
            source_synced_commit_id=self.source_synced_commit_id,
            source_updated_at=self.source_updated_at,
            status_updated_at=self.status_updated_at,
            statuses=self.statuses,
            suspend=self.suspend,
            system_data=self.system_data,
            type=self.type)


def get_flux_configuration(cluster_name: Optional[str] = None,
                           cluster_resource_name: Optional[str] = None,
                           cluster_rp: Optional[str] = None,
                           flux_configuration_name: Optional[str] = None,
                           resource_group_name: Optional[str] = None,
                           opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetFluxConfigurationResult:
    """
    The Flux Configuration object returned in Get & Put response.


    :param str cluster_name: The name of the kubernetes cluster.
    :param str cluster_resource_name: The Kubernetes cluster resource name - i.e. managedClusters, connectedClusters, provisionedClusters.
    :param str cluster_rp: The Kubernetes cluster RP - i.e. Microsoft.ContainerService, Microsoft.Kubernetes, Microsoft.HybridContainerService.
    :param str flux_configuration_name: Name of the Flux Configuration.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    """
    __args__ = dict()
    __args__['clusterName'] = cluster_name
    __args__['clusterResourceName'] = cluster_resource_name
    __args__['clusterRp'] = cluster_rp
    __args__['fluxConfigurationName'] = flux_configuration_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:kubernetesconfiguration/v20220301:getFluxConfiguration', __args__, opts=opts, typ=GetFluxConfigurationResult).value

    return AwaitableGetFluxConfigurationResult(
        bucket=__ret__.bucket,
        compliance_state=__ret__.compliance_state,
        configuration_protected_settings=__ret__.configuration_protected_settings,
        error_message=__ret__.error_message,
        git_repository=__ret__.git_repository,
        id=__ret__.id,
        kustomizations=__ret__.kustomizations,
        name=__ret__.name,
        namespace=__ret__.namespace,
        provisioning_state=__ret__.provisioning_state,
        repository_public_key=__ret__.repository_public_key,
        scope=__ret__.scope,
        source_kind=__ret__.source_kind,
        source_synced_commit_id=__ret__.source_synced_commit_id,
        source_updated_at=__ret__.source_updated_at,
        status_updated_at=__ret__.status_updated_at,
        statuses=__ret__.statuses,
        suspend=__ret__.suspend,
        system_data=__ret__.system_data,
        type=__ret__.type)


@_utilities.lift_output_func(get_flux_configuration)
def get_flux_configuration_output(cluster_name: Optional[pulumi.Input[str]] = None,
                                  cluster_resource_name: Optional[pulumi.Input[str]] = None,
                                  cluster_rp: Optional[pulumi.Input[str]] = None,
                                  flux_configuration_name: Optional[pulumi.Input[str]] = None,
                                  resource_group_name: Optional[pulumi.Input[str]] = None,
                                  opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetFluxConfigurationResult]:
    """
    The Flux Configuration object returned in Get & Put response.


    :param str cluster_name: The name of the kubernetes cluster.
    :param str cluster_resource_name: The Kubernetes cluster resource name - i.e. managedClusters, connectedClusters, provisionedClusters.
    :param str cluster_rp: The Kubernetes cluster RP - i.e. Microsoft.ContainerService, Microsoft.Kubernetes, Microsoft.HybridContainerService.
    :param str flux_configuration_name: Name of the Flux Configuration.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    """
    ...
