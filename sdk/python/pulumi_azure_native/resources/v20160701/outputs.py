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

__all__ = [
    'AliasPathTypeResponse',
    'AliasTypeResponse',
    'BasicDependencyResponse',
    'DependencyResponse',
    'DeploymentPropertiesExtendedResponse',
    'ErrorAdditionalInfoResponse',
    'ErrorResponseResponse',
    'IdentityResponse',
    'ParametersLinkResponse',
    'PlanResponse',
    'ProviderResourceTypeResponse',
    'ProviderResponse',
    'ResourceGroupPropertiesResponse',
    'SkuResponse',
    'TemplateLinkResponse',
    'ZoneMappingResponse',
]

@pulumi.output_type
class AliasPathTypeResponse(dict):
    """
    The type of the paths for alias. 
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "apiVersions":
            suggest = "api_versions"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in AliasPathTypeResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        AliasPathTypeResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        AliasPathTypeResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 api_versions: Optional[Sequence[str]] = None,
                 path: Optional[str] = None):
        """
        The type of the paths for alias. 
        :param Sequence[str] api_versions: The api versions.
        :param str path: The path of an alias.
        """
        if api_versions is not None:
            pulumi.set(__self__, "api_versions", api_versions)
        if path is not None:
            pulumi.set(__self__, "path", path)

    @property
    @pulumi.getter(name="apiVersions")
    def api_versions(self) -> Optional[Sequence[str]]:
        """
        The api versions.
        """
        return pulumi.get(self, "api_versions")

    @property
    @pulumi.getter
    def path(self) -> Optional[str]:
        """
        The path of an alias.
        """
        return pulumi.get(self, "path")


@pulumi.output_type
class AliasTypeResponse(dict):
    """
    The alias type. 
    """
    def __init__(__self__, *,
                 name: Optional[str] = None,
                 paths: Optional[Sequence['outputs.AliasPathTypeResponse']] = None):
        """
        The alias type. 
        :param str name: The alias name.
        :param Sequence['AliasPathTypeResponse'] paths: The paths for an alias.
        """
        if name is not None:
            pulumi.set(__self__, "name", name)
        if paths is not None:
            pulumi.set(__self__, "paths", paths)

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        The alias name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def paths(self) -> Optional[Sequence['outputs.AliasPathTypeResponse']]:
        """
        The paths for an alias.
        """
        return pulumi.get(self, "paths")


@pulumi.output_type
class BasicDependencyResponse(dict):
    """
    Deployment dependency information.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "resourceName":
            suggest = "resource_name"
        elif key == "resourceType":
            suggest = "resource_type"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in BasicDependencyResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        BasicDependencyResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        BasicDependencyResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 id: Optional[str] = None,
                 resource_name: Optional[str] = None,
                 resource_type: Optional[str] = None):
        """
        Deployment dependency information.
        :param str id: The ID of the dependency.
        :param str resource_name: The dependency resource name.
        :param str resource_type: The dependency resource type.
        """
        if id is not None:
            pulumi.set(__self__, "id", id)
        if resource_name is not None:
            pulumi.set(__self__, "resource_name", resource_name)
        if resource_type is not None:
            pulumi.set(__self__, "resource_type", resource_type)

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        The ID of the dependency.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="resourceName")
    def resource_name(self) -> Optional[str]:
        """
        The dependency resource name.
        """
        return pulumi.get(self, "resource_name")

    @property
    @pulumi.getter(name="resourceType")
    def resource_type(self) -> Optional[str]:
        """
        The dependency resource type.
        """
        return pulumi.get(self, "resource_type")


@pulumi.output_type
class DependencyResponse(dict):
    """
    Deployment dependency information.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "dependsOn":
            suggest = "depends_on"
        elif key == "resourceName":
            suggest = "resource_name"
        elif key == "resourceType":
            suggest = "resource_type"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DependencyResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DependencyResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DependencyResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 depends_on: Optional[Sequence['outputs.BasicDependencyResponse']] = None,
                 id: Optional[str] = None,
                 resource_name: Optional[str] = None,
                 resource_type: Optional[str] = None):
        """
        Deployment dependency information.
        :param Sequence['BasicDependencyResponse'] depends_on: The list of dependencies.
        :param str id: The ID of the dependency.
        :param str resource_name: The dependency resource name.
        :param str resource_type: The dependency resource type.
        """
        if depends_on is not None:
            pulumi.set(__self__, "depends_on", depends_on)
        if id is not None:
            pulumi.set(__self__, "id", id)
        if resource_name is not None:
            pulumi.set(__self__, "resource_name", resource_name)
        if resource_type is not None:
            pulumi.set(__self__, "resource_type", resource_type)

    @property
    @pulumi.getter(name="dependsOn")
    def depends_on(self) -> Optional[Sequence['outputs.BasicDependencyResponse']]:
        """
        The list of dependencies.
        """
        return pulumi.get(self, "depends_on")

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        The ID of the dependency.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="resourceName")
    def resource_name(self) -> Optional[str]:
        """
        The dependency resource name.
        """
        return pulumi.get(self, "resource_name")

    @property
    @pulumi.getter(name="resourceType")
    def resource_type(self) -> Optional[str]:
        """
        The dependency resource type.
        """
        return pulumi.get(self, "resource_type")


@pulumi.output_type
class DeploymentPropertiesExtendedResponse(dict):
    """
    Deployment properties with additional details.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "correlationId":
            suggest = "correlation_id"
        elif key == "parametersLink":
            suggest = "parameters_link"
        elif key == "provisioningState":
            suggest = "provisioning_state"
        elif key == "templateLink":
            suggest = "template_link"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DeploymentPropertiesExtendedResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DeploymentPropertiesExtendedResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DeploymentPropertiesExtendedResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 error: 'outputs.ErrorResponseResponse',
                 correlation_id: Optional[str] = None,
                 dependencies: Optional[Sequence['outputs.DependencyResponse']] = None,
                 mode: Optional[str] = None,
                 outputs: Optional[Any] = None,
                 parameters: Optional[Any] = None,
                 parameters_link: Optional['outputs.ParametersLinkResponse'] = None,
                 providers: Optional[Sequence['outputs.ProviderResponse']] = None,
                 provisioning_state: Optional[str] = None,
                 template: Optional[Any] = None,
                 template_link: Optional['outputs.TemplateLinkResponse'] = None,
                 timestamp: Optional[str] = None):
        """
        Deployment properties with additional details.
        :param 'ErrorResponseResponse' error: The deployment error.
        :param str correlation_id: The correlation ID of the deployment.
        :param Sequence['DependencyResponse'] dependencies: The list of deployment dependencies.
        :param str mode: The deployment mode.
        :param Any outputs: Key/value pairs that represent deployment output.
        :param Any parameters: Deployment parameters. Use only one of Parameters or ParametersLink.
        :param 'ParametersLinkResponse' parameters_link: The URI referencing the parameters. Use only one of Parameters or ParametersLink.
        :param Sequence['ProviderResponse'] providers: The list of resource providers needed for the deployment.
        :param str provisioning_state: The state of the provisioning.
        :param Any template: The template content. Use only one of Template or TemplateLink.
        :param 'TemplateLinkResponse' template_link: The URI referencing the template. Use only one of Template or TemplateLink.
        :param str timestamp: The timestamp of the template deployment.
        """
        pulumi.set(__self__, "error", error)
        if correlation_id is not None:
            pulumi.set(__self__, "correlation_id", correlation_id)
        if dependencies is not None:
            pulumi.set(__self__, "dependencies", dependencies)
        if mode is not None:
            pulumi.set(__self__, "mode", mode)
        if outputs is not None:
            pulumi.set(__self__, "outputs", outputs)
        if parameters is not None:
            pulumi.set(__self__, "parameters", parameters)
        if parameters_link is not None:
            pulumi.set(__self__, "parameters_link", parameters_link)
        if providers is not None:
            pulumi.set(__self__, "providers", providers)
        if provisioning_state is not None:
            pulumi.set(__self__, "provisioning_state", provisioning_state)
        if template is not None:
            pulumi.set(__self__, "template", template)
        if template_link is not None:
            pulumi.set(__self__, "template_link", template_link)
        if timestamp is not None:
            pulumi.set(__self__, "timestamp", timestamp)

    @property
    @pulumi.getter
    def error(self) -> 'outputs.ErrorResponseResponse':
        """
        The deployment error.
        """
        return pulumi.get(self, "error")

    @property
    @pulumi.getter(name="correlationId")
    def correlation_id(self) -> Optional[str]:
        """
        The correlation ID of the deployment.
        """
        return pulumi.get(self, "correlation_id")

    @property
    @pulumi.getter
    def dependencies(self) -> Optional[Sequence['outputs.DependencyResponse']]:
        """
        The list of deployment dependencies.
        """
        return pulumi.get(self, "dependencies")

    @property
    @pulumi.getter
    def mode(self) -> Optional[str]:
        """
        The deployment mode.
        """
        return pulumi.get(self, "mode")

    @property
    @pulumi.getter
    def outputs(self) -> Optional[Any]:
        """
        Key/value pairs that represent deployment output.
        """
        return pulumi.get(self, "outputs")

    @property
    @pulumi.getter
    def parameters(self) -> Optional[Any]:
        """
        Deployment parameters. Use only one of Parameters or ParametersLink.
        """
        return pulumi.get(self, "parameters")

    @property
    @pulumi.getter(name="parametersLink")
    def parameters_link(self) -> Optional['outputs.ParametersLinkResponse']:
        """
        The URI referencing the parameters. Use only one of Parameters or ParametersLink.
        """
        return pulumi.get(self, "parameters_link")

    @property
    @pulumi.getter
    def providers(self) -> Optional[Sequence['outputs.ProviderResponse']]:
        """
        The list of resource providers needed for the deployment.
        """
        return pulumi.get(self, "providers")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> Optional[str]:
        """
        The state of the provisioning.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def template(self) -> Optional[Any]:
        """
        The template content. Use only one of Template or TemplateLink.
        """
        return pulumi.get(self, "template")

    @property
    @pulumi.getter(name="templateLink")
    def template_link(self) -> Optional['outputs.TemplateLinkResponse']:
        """
        The URI referencing the template. Use only one of Template or TemplateLink.
        """
        return pulumi.get(self, "template_link")

    @property
    @pulumi.getter
    def timestamp(self) -> Optional[str]:
        """
        The timestamp of the template deployment.
        """
        return pulumi.get(self, "timestamp")


@pulumi.output_type
class ErrorAdditionalInfoResponse(dict):
    """
    The resource management error additional info.
    """
    def __init__(__self__, *,
                 info: Any,
                 type: str):
        """
        The resource management error additional info.
        :param Any info: The additional info.
        :param str type: The additional info type.
        """
        pulumi.set(__self__, "info", info)
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def info(self) -> Any:
        """
        The additional info.
        """
        return pulumi.get(self, "info")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The additional info type.
        """
        return pulumi.get(self, "type")


@pulumi.output_type
class ErrorResponseResponse(dict):
    """
    Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.)
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "additionalInfo":
            suggest = "additional_info"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in ErrorResponseResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        ErrorResponseResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        ErrorResponseResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 additional_info: Sequence['outputs.ErrorAdditionalInfoResponse'],
                 code: str,
                 details: Sequence['outputs.ErrorResponseResponse'],
                 message: str,
                 target: str):
        """
        Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.)
        :param Sequence['ErrorAdditionalInfoResponse'] additional_info: The error additional info.
        :param str code: The error code.
        :param Sequence['ErrorResponseResponse'] details: The error details.
        :param str message: The error message.
        :param str target: The error target.
        """
        pulumi.set(__self__, "additional_info", additional_info)
        pulumi.set(__self__, "code", code)
        pulumi.set(__self__, "details", details)
        pulumi.set(__self__, "message", message)
        pulumi.set(__self__, "target", target)

    @property
    @pulumi.getter(name="additionalInfo")
    def additional_info(self) -> Sequence['outputs.ErrorAdditionalInfoResponse']:
        """
        The error additional info.
        """
        return pulumi.get(self, "additional_info")

    @property
    @pulumi.getter
    def code(self) -> str:
        """
        The error code.
        """
        return pulumi.get(self, "code")

    @property
    @pulumi.getter
    def details(self) -> Sequence['outputs.ErrorResponseResponse']:
        """
        The error details.
        """
        return pulumi.get(self, "details")

    @property
    @pulumi.getter
    def message(self) -> str:
        """
        The error message.
        """
        return pulumi.get(self, "message")

    @property
    @pulumi.getter
    def target(self) -> str:
        """
        The error target.
        """
        return pulumi.get(self, "target")


@pulumi.output_type
class IdentityResponse(dict):
    """
    Identity for the resource.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "principalId":
            suggest = "principal_id"
        elif key == "tenantId":
            suggest = "tenant_id"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in IdentityResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        IdentityResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        IdentityResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 principal_id: str,
                 tenant_id: str,
                 type: Optional[str] = None):
        """
        Identity for the resource.
        :param str principal_id: The principal id of resource identity.
        :param str tenant_id: The tenant id of resource.
        :param str type: The identity type.
        """
        pulumi.set(__self__, "principal_id", principal_id)
        pulumi.set(__self__, "tenant_id", tenant_id)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="principalId")
    def principal_id(self) -> str:
        """
        The principal id of resource identity.
        """
        return pulumi.get(self, "principal_id")

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> str:
        """
        The tenant id of resource.
        """
        return pulumi.get(self, "tenant_id")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        """
        The identity type.
        """
        return pulumi.get(self, "type")


@pulumi.output_type
class ParametersLinkResponse(dict):
    """
    Entity representing the reference to the deployment parameters.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "contentVersion":
            suggest = "content_version"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in ParametersLinkResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        ParametersLinkResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        ParametersLinkResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 uri: str,
                 content_version: Optional[str] = None):
        """
        Entity representing the reference to the deployment parameters.
        :param str uri: URI referencing the template.
        :param str content_version: If included it must match the ContentVersion in the template.
        """
        pulumi.set(__self__, "uri", uri)
        if content_version is not None:
            pulumi.set(__self__, "content_version", content_version)

    @property
    @pulumi.getter
    def uri(self) -> str:
        """
        URI referencing the template.
        """
        return pulumi.get(self, "uri")

    @property
    @pulumi.getter(name="contentVersion")
    def content_version(self) -> Optional[str]:
        """
        If included it must match the ContentVersion in the template.
        """
        return pulumi.get(self, "content_version")


@pulumi.output_type
class PlanResponse(dict):
    """
    Plan for the resource.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "promotionCode":
            suggest = "promotion_code"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in PlanResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        PlanResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        PlanResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 name: Optional[str] = None,
                 product: Optional[str] = None,
                 promotion_code: Optional[str] = None,
                 publisher: Optional[str] = None):
        """
        Plan for the resource.
        :param str name: The plan ID.
        :param str product: The offer ID.
        :param str promotion_code: The promotion code.
        :param str publisher: The publisher ID.
        """
        if name is not None:
            pulumi.set(__self__, "name", name)
        if product is not None:
            pulumi.set(__self__, "product", product)
        if promotion_code is not None:
            pulumi.set(__self__, "promotion_code", promotion_code)
        if publisher is not None:
            pulumi.set(__self__, "publisher", publisher)

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        The plan ID.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def product(self) -> Optional[str]:
        """
        The offer ID.
        """
        return pulumi.get(self, "product")

    @property
    @pulumi.getter(name="promotionCode")
    def promotion_code(self) -> Optional[str]:
        """
        The promotion code.
        """
        return pulumi.get(self, "promotion_code")

    @property
    @pulumi.getter
    def publisher(self) -> Optional[str]:
        """
        The publisher ID.
        """
        return pulumi.get(self, "publisher")


@pulumi.output_type
class ProviderResourceTypeResponse(dict):
    """
    Resource type managed by the resource provider.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "apiVersions":
            suggest = "api_versions"
        elif key == "resourceType":
            suggest = "resource_type"
        elif key == "zoneMappings":
            suggest = "zone_mappings"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in ProviderResourceTypeResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        ProviderResourceTypeResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        ProviderResourceTypeResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 aliases: Optional[Sequence['outputs.AliasTypeResponse']] = None,
                 api_versions: Optional[Sequence[str]] = None,
                 locations: Optional[Sequence[str]] = None,
                 properties: Optional[Mapping[str, str]] = None,
                 resource_type: Optional[str] = None,
                 zone_mappings: Optional[Sequence['outputs.ZoneMappingResponse']] = None):
        """
        Resource type managed by the resource provider.
        :param Sequence['AliasTypeResponse'] aliases: The aliases that are supported by this resource type.
        :param Sequence[str] api_versions: The api version.
        :param Sequence[str] locations: The collection of locations where this resource type can be created in.
        :param Mapping[str, str] properties: The properties.
        :param str resource_type: The resource type.
        """
        if aliases is not None:
            pulumi.set(__self__, "aliases", aliases)
        if api_versions is not None:
            pulumi.set(__self__, "api_versions", api_versions)
        if locations is not None:
            pulumi.set(__self__, "locations", locations)
        if properties is not None:
            pulumi.set(__self__, "properties", properties)
        if resource_type is not None:
            pulumi.set(__self__, "resource_type", resource_type)
        if zone_mappings is not None:
            pulumi.set(__self__, "zone_mappings", zone_mappings)

    @property
    @pulumi.getter
    def aliases(self) -> Optional[Sequence['outputs.AliasTypeResponse']]:
        """
        The aliases that are supported by this resource type.
        """
        return pulumi.get(self, "aliases")

    @property
    @pulumi.getter(name="apiVersions")
    def api_versions(self) -> Optional[Sequence[str]]:
        """
        The api version.
        """
        return pulumi.get(self, "api_versions")

    @property
    @pulumi.getter
    def locations(self) -> Optional[Sequence[str]]:
        """
        The collection of locations where this resource type can be created in.
        """
        return pulumi.get(self, "locations")

    @property
    @pulumi.getter
    def properties(self) -> Optional[Mapping[str, str]]:
        """
        The properties.
        """
        return pulumi.get(self, "properties")

    @property
    @pulumi.getter(name="resourceType")
    def resource_type(self) -> Optional[str]:
        """
        The resource type.
        """
        return pulumi.get(self, "resource_type")

    @property
    @pulumi.getter(name="zoneMappings")
    def zone_mappings(self) -> Optional[Sequence['outputs.ZoneMappingResponse']]:
        return pulumi.get(self, "zone_mappings")


@pulumi.output_type
class ProviderResponse(dict):
    """
    Resource provider information.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "registrationState":
            suggest = "registration_state"
        elif key == "resourceTypes":
            suggest = "resource_types"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in ProviderResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        ProviderResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        ProviderResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 id: Optional[str] = None,
                 namespace: Optional[str] = None,
                 registration_state: Optional[str] = None,
                 resource_types: Optional[Sequence['outputs.ProviderResourceTypeResponse']] = None):
        """
        Resource provider information.
        :param str id: The provider id.
        :param str namespace: The namespace of the provider.
        :param str registration_state: The registration state of the provider.
        :param Sequence['ProviderResourceTypeResponse'] resource_types: The collection of provider resource types.
        """
        if id is not None:
            pulumi.set(__self__, "id", id)
        if namespace is not None:
            pulumi.set(__self__, "namespace", namespace)
        if registration_state is not None:
            pulumi.set(__self__, "registration_state", registration_state)
        if resource_types is not None:
            pulumi.set(__self__, "resource_types", resource_types)

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        The provider id.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def namespace(self) -> Optional[str]:
        """
        The namespace of the provider.
        """
        return pulumi.get(self, "namespace")

    @property
    @pulumi.getter(name="registrationState")
    def registration_state(self) -> Optional[str]:
        """
        The registration state of the provider.
        """
        return pulumi.get(self, "registration_state")

    @property
    @pulumi.getter(name="resourceTypes")
    def resource_types(self) -> Optional[Sequence['outputs.ProviderResourceTypeResponse']]:
        """
        The collection of provider resource types.
        """
        return pulumi.get(self, "resource_types")


@pulumi.output_type
class ResourceGroupPropertiesResponse(dict):
    """
    The resource group properties.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "provisioningState":
            suggest = "provisioning_state"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in ResourceGroupPropertiesResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        ResourceGroupPropertiesResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        ResourceGroupPropertiesResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 provisioning_state: str):
        """
        The resource group properties.
        :param str provisioning_state: The provisioning state. 
        """
        pulumi.set(__self__, "provisioning_state", provisioning_state)

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        The provisioning state. 
        """
        return pulumi.get(self, "provisioning_state")


@pulumi.output_type
class SkuResponse(dict):
    """
    Sku for the resource.
    """
    def __init__(__self__, *,
                 capacity: Optional[int] = None,
                 family: Optional[str] = None,
                 model: Optional[str] = None,
                 name: Optional[str] = None,
                 size: Optional[str] = None,
                 tier: Optional[str] = None):
        """
        Sku for the resource.
        :param int capacity: The sku capacity.
        :param str family: The sku family.
        :param str model: The sku model.
        :param str name: The sku name.
        :param str size: The sku size.
        :param str tier: The sku tier.
        """
        if capacity is not None:
            pulumi.set(__self__, "capacity", capacity)
        if family is not None:
            pulumi.set(__self__, "family", family)
        if model is not None:
            pulumi.set(__self__, "model", model)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if size is not None:
            pulumi.set(__self__, "size", size)
        if tier is not None:
            pulumi.set(__self__, "tier", tier)

    @property
    @pulumi.getter
    def capacity(self) -> Optional[int]:
        """
        The sku capacity.
        """
        return pulumi.get(self, "capacity")

    @property
    @pulumi.getter
    def family(self) -> Optional[str]:
        """
        The sku family.
        """
        return pulumi.get(self, "family")

    @property
    @pulumi.getter
    def model(self) -> Optional[str]:
        """
        The sku model.
        """
        return pulumi.get(self, "model")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        The sku name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def size(self) -> Optional[str]:
        """
        The sku size.
        """
        return pulumi.get(self, "size")

    @property
    @pulumi.getter
    def tier(self) -> Optional[str]:
        """
        The sku tier.
        """
        return pulumi.get(self, "tier")


@pulumi.output_type
class TemplateLinkResponse(dict):
    """
    Entity representing the reference to the template.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "contentVersion":
            suggest = "content_version"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in TemplateLinkResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        TemplateLinkResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        TemplateLinkResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 uri: str,
                 content_version: Optional[str] = None):
        """
        Entity representing the reference to the template.
        :param str uri: URI referencing the template.
        :param str content_version: If included it must match the ContentVersion in the template.
        """
        pulumi.set(__self__, "uri", uri)
        if content_version is not None:
            pulumi.set(__self__, "content_version", content_version)

    @property
    @pulumi.getter
    def uri(self) -> str:
        """
        URI referencing the template.
        """
        return pulumi.get(self, "uri")

    @property
    @pulumi.getter(name="contentVersion")
    def content_version(self) -> Optional[str]:
        """
        If included it must match the ContentVersion in the template.
        """
        return pulumi.get(self, "content_version")


@pulumi.output_type
class ZoneMappingResponse(dict):
    def __init__(__self__, *,
                 location: Optional[str] = None,
                 zones: Optional[Sequence[str]] = None):
        """
        :param str location: The location of the zone mapping.
        """
        if location is not None:
            pulumi.set(__self__, "location", location)
        if zones is not None:
            pulumi.set(__self__, "zones", zones)

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        The location of the zone mapping.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def zones(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "zones")


