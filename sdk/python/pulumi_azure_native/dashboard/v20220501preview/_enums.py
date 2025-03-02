# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'ApiKey',
    'AutoGeneratedDomainNameLabelScope',
    'DeterministicOutboundIP',
    'ManagedServiceIdentityType',
    'PrivateEndpointServiceConnectionStatus',
    'PublicNetworkAccess',
    'ZoneRedundancy',
]


class ApiKey(str, Enum):
    """
    The api key setting of the Grafana instance.
    """
    DISABLED = "Disabled"
    ENABLED = "Enabled"


class AutoGeneratedDomainNameLabelScope(str, Enum):
    """
    Scope for dns deterministic name hash calculation.
    """
    TENANT_REUSE = "TenantReuse"


class DeterministicOutboundIP(str, Enum):
    """
    Whether a Grafana instance uses deterministic outbound IPs.
    """
    DISABLED = "Disabled"
    ENABLED = "Enabled"


class ManagedServiceIdentityType(str, Enum):
    """
    Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
    """
    NONE = "None"
    SYSTEM_ASSIGNED = "SystemAssigned"
    USER_ASSIGNED = "UserAssigned"
    SYSTEM_ASSIGNED_USER_ASSIGNED = "SystemAssigned,UserAssigned"


class PrivateEndpointServiceConnectionStatus(str, Enum):
    """
    Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
    """
    PENDING = "Pending"
    APPROVED = "Approved"
    REJECTED = "Rejected"


class PublicNetworkAccess(str, Enum):
    """
    Indicate the state for enable or disable traffic over the public interface.
    """
    ENABLED = "Enabled"
    DISABLED = "Disabled"


class ZoneRedundancy(str, Enum):
    """
    The zone redundancy setting of the Grafana instance.
    """
    DISABLED = "Disabled"
    ENABLED = "Enabled"
