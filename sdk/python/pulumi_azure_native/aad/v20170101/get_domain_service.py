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
    'GetDomainServiceResult',
    'AwaitableGetDomainServiceResult',
    'get_domain_service',
    'get_domain_service_output',
]

warnings.warn("""Version 2017-01-01 will be removed in v2 of the provider.""", DeprecationWarning)

@pulumi.output_type
class GetDomainServiceResult:
    """
    Domain service.
    """
    def __init__(__self__, deployment_id=None, domain_controller_ip_address=None, domain_name=None, domain_security_settings=None, etag=None, filtered_sync=None, health_alerts=None, health_last_evaluated=None, health_monitors=None, id=None, ldaps_settings=None, location=None, name=None, notification_settings=None, provisioning_state=None, service_status=None, subnet_id=None, tags=None, tenant_id=None, type=None, vnet_site_id=None):
        if deployment_id and not isinstance(deployment_id, str):
            raise TypeError("Expected argument 'deployment_id' to be a str")
        pulumi.set(__self__, "deployment_id", deployment_id)
        if domain_controller_ip_address and not isinstance(domain_controller_ip_address, list):
            raise TypeError("Expected argument 'domain_controller_ip_address' to be a list")
        pulumi.set(__self__, "domain_controller_ip_address", domain_controller_ip_address)
        if domain_name and not isinstance(domain_name, str):
            raise TypeError("Expected argument 'domain_name' to be a str")
        pulumi.set(__self__, "domain_name", domain_name)
        if domain_security_settings and not isinstance(domain_security_settings, dict):
            raise TypeError("Expected argument 'domain_security_settings' to be a dict")
        pulumi.set(__self__, "domain_security_settings", domain_security_settings)
        if etag and not isinstance(etag, str):
            raise TypeError("Expected argument 'etag' to be a str")
        pulumi.set(__self__, "etag", etag)
        if filtered_sync and not isinstance(filtered_sync, str):
            raise TypeError("Expected argument 'filtered_sync' to be a str")
        pulumi.set(__self__, "filtered_sync", filtered_sync)
        if health_alerts and not isinstance(health_alerts, list):
            raise TypeError("Expected argument 'health_alerts' to be a list")
        pulumi.set(__self__, "health_alerts", health_alerts)
        if health_last_evaluated and not isinstance(health_last_evaluated, str):
            raise TypeError("Expected argument 'health_last_evaluated' to be a str")
        pulumi.set(__self__, "health_last_evaluated", health_last_evaluated)
        if health_monitors and not isinstance(health_monitors, list):
            raise TypeError("Expected argument 'health_monitors' to be a list")
        pulumi.set(__self__, "health_monitors", health_monitors)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if ldaps_settings and not isinstance(ldaps_settings, dict):
            raise TypeError("Expected argument 'ldaps_settings' to be a dict")
        pulumi.set(__self__, "ldaps_settings", ldaps_settings)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if notification_settings and not isinstance(notification_settings, dict):
            raise TypeError("Expected argument 'notification_settings' to be a dict")
        pulumi.set(__self__, "notification_settings", notification_settings)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if service_status and not isinstance(service_status, str):
            raise TypeError("Expected argument 'service_status' to be a str")
        pulumi.set(__self__, "service_status", service_status)
        if subnet_id and not isinstance(subnet_id, str):
            raise TypeError("Expected argument 'subnet_id' to be a str")
        pulumi.set(__self__, "subnet_id", subnet_id)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if tenant_id and not isinstance(tenant_id, str):
            raise TypeError("Expected argument 'tenant_id' to be a str")
        pulumi.set(__self__, "tenant_id", tenant_id)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if vnet_site_id and not isinstance(vnet_site_id, str):
            raise TypeError("Expected argument 'vnet_site_id' to be a str")
        pulumi.set(__self__, "vnet_site_id", vnet_site_id)

    @property
    @pulumi.getter(name="deploymentId")
    def deployment_id(self) -> str:
        """
        Deployment Id
        """
        return pulumi.get(self, "deployment_id")

    @property
    @pulumi.getter(name="domainControllerIpAddress")
    def domain_controller_ip_address(self) -> Sequence[str]:
        """
        List of Domain Controller IP Address
        """
        return pulumi.get(self, "domain_controller_ip_address")

    @property
    @pulumi.getter(name="domainName")
    def domain_name(self) -> Optional[str]:
        """
        The name of the Azure domain that the user would like to deploy Domain Services to.
        """
        return pulumi.get(self, "domain_name")

    @property
    @pulumi.getter(name="domainSecuritySettings")
    def domain_security_settings(self) -> Optional['outputs.DomainSecuritySettingsResponse']:
        """
        DomainSecurity Settings
        """
        return pulumi.get(self, "domain_security_settings")

    @property
    @pulumi.getter
    def etag(self) -> Optional[str]:
        """
        Resource etag
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter(name="filteredSync")
    def filtered_sync(self) -> Optional[str]:
        """
        Enabled or Disabled flag to turn on Group-based filtered sync
        """
        return pulumi.get(self, "filtered_sync")

    @property
    @pulumi.getter(name="healthAlerts")
    def health_alerts(self) -> Sequence['outputs.HealthAlertResponse']:
        """
        List of Domain Health Alerts
        """
        return pulumi.get(self, "health_alerts")

    @property
    @pulumi.getter(name="healthLastEvaluated")
    def health_last_evaluated(self) -> str:
        """
        Last domain evaluation run DateTime
        """
        return pulumi.get(self, "health_last_evaluated")

    @property
    @pulumi.getter(name="healthMonitors")
    def health_monitors(self) -> Sequence['outputs.HealthMonitorResponse']:
        """
        List of Domain Health Monitors
        """
        return pulumi.get(self, "health_monitors")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Resource Id
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="ldapsSettings")
    def ldaps_settings(self) -> Optional['outputs.LdapsSettingsResponse']:
        """
        Secure LDAP Settings
        """
        return pulumi.get(self, "ldaps_settings")

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
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
    @pulumi.getter(name="notificationSettings")
    def notification_settings(self) -> Optional['outputs.NotificationSettingsResponse']:
        """
        Notification Settings
        """
        return pulumi.get(self, "notification_settings")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        the current deployment or provisioning state, which only appears in the response.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="serviceStatus")
    def service_status(self) -> str:
        """
        Status of Domain Service instance
        """
        return pulumi.get(self, "service_status")

    @property
    @pulumi.getter(name="subnetId")
    def subnet_id(self) -> Optional[str]:
        """
        The name of the virtual network that Domain Services will be deployed on. The id of the subnet that Domain Services will be deployed on. /virtualNetwork/vnetName/subnets/subnetName.
        """
        return pulumi.get(self, "subnet_id")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> str:
        """
        Azure Active Directory tenant id
        """
        return pulumi.get(self, "tenant_id")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="vnetSiteId")
    def vnet_site_id(self) -> str:
        """
        Virtual network site id
        """
        return pulumi.get(self, "vnet_site_id")


class AwaitableGetDomainServiceResult(GetDomainServiceResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDomainServiceResult(
            deployment_id=self.deployment_id,
            domain_controller_ip_address=self.domain_controller_ip_address,
            domain_name=self.domain_name,
            domain_security_settings=self.domain_security_settings,
            etag=self.etag,
            filtered_sync=self.filtered_sync,
            health_alerts=self.health_alerts,
            health_last_evaluated=self.health_last_evaluated,
            health_monitors=self.health_monitors,
            id=self.id,
            ldaps_settings=self.ldaps_settings,
            location=self.location,
            name=self.name,
            notification_settings=self.notification_settings,
            provisioning_state=self.provisioning_state,
            service_status=self.service_status,
            subnet_id=self.subnet_id,
            tags=self.tags,
            tenant_id=self.tenant_id,
            type=self.type,
            vnet_site_id=self.vnet_site_id)


def get_domain_service(domain_service_name: Optional[str] = None,
                       resource_group_name: Optional[str] = None,
                       opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDomainServiceResult:
    """
    Domain service.


    :param str domain_service_name: The name of the domain service.
    :param str resource_group_name: The name of the resource group within the user's subscription. The name is case insensitive.
    """
    pulumi.log.warn("""get_domain_service is deprecated: Version 2017-01-01 will be removed in v2 of the provider.""")
    __args__ = dict()
    __args__['domainServiceName'] = domain_service_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:aad/v20170101:getDomainService', __args__, opts=opts, typ=GetDomainServiceResult).value

    return AwaitableGetDomainServiceResult(
        deployment_id=__ret__.deployment_id,
        domain_controller_ip_address=__ret__.domain_controller_ip_address,
        domain_name=__ret__.domain_name,
        domain_security_settings=__ret__.domain_security_settings,
        etag=__ret__.etag,
        filtered_sync=__ret__.filtered_sync,
        health_alerts=__ret__.health_alerts,
        health_last_evaluated=__ret__.health_last_evaluated,
        health_monitors=__ret__.health_monitors,
        id=__ret__.id,
        ldaps_settings=__ret__.ldaps_settings,
        location=__ret__.location,
        name=__ret__.name,
        notification_settings=__ret__.notification_settings,
        provisioning_state=__ret__.provisioning_state,
        service_status=__ret__.service_status,
        subnet_id=__ret__.subnet_id,
        tags=__ret__.tags,
        tenant_id=__ret__.tenant_id,
        type=__ret__.type,
        vnet_site_id=__ret__.vnet_site_id)


@_utilities.lift_output_func(get_domain_service)
def get_domain_service_output(domain_service_name: Optional[pulumi.Input[str]] = None,
                              resource_group_name: Optional[pulumi.Input[str]] = None,
                              opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetDomainServiceResult]:
    """
    Domain service.


    :param str domain_service_name: The name of the domain service.
    :param str resource_group_name: The name of the resource group within the user's subscription. The name is case insensitive.
    """
    pulumi.log.warn("""get_domain_service is deprecated: Version 2017-01-01 will be removed in v2 of the provider.""")
    ...
