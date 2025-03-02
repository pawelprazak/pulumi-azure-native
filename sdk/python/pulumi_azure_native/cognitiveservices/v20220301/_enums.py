# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'DeploymentScaleType',
    'HostingModel',
    'KeySource',
    'NetworkRuleAction',
    'PrivateEndpointServiceConnectionStatus',
    'PublicNetworkAccess',
    'ResourceIdentityType',
    'SkuTier',
]


class DeploymentScaleType(str, Enum):
    """
    Deployment scale type.
    """
    STANDARD = "Standard"
    MANUAL = "Manual"


class HostingModel(str, Enum):
    """
    Account hosting model.
    """
    WEB = "Web"
    CONNECTED_CONTAINER = "ConnectedContainer"
    DISCONNECTED_CONTAINER = "DisconnectedContainer"


class KeySource(str, Enum):
    """
    Enumerates the possible value of keySource for Encryption
    """
    MICROSOFT_COGNITIVE_SERVICES = "Microsoft.CognitiveServices"
    MICROSOFT_KEY_VAULT = "Microsoft.KeyVault"


class NetworkRuleAction(str, Enum):
    """
    The default action when no rule from ipRules and from virtualNetworkRules match. This is only used after the bypass property has been evaluated.
    """
    ALLOW = "Allow"
    DENY = "Deny"


class PrivateEndpointServiceConnectionStatus(str, Enum):
    """
    Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
    """
    PENDING = "Pending"
    APPROVED = "Approved"
    REJECTED = "Rejected"


class PublicNetworkAccess(str, Enum):
    """
    Whether or not public endpoint access is allowed for this account.
    """
    ENABLED = "Enabled"
    DISABLED = "Disabled"


class ResourceIdentityType(str, Enum):
    """
    The identity type.
    """
    NONE = "None"
    SYSTEM_ASSIGNED = "SystemAssigned"
    USER_ASSIGNED = "UserAssigned"
    SYSTEM_ASSIGNED_USER_ASSIGNED = "SystemAssigned, UserAssigned"


class SkuTier(str, Enum):
    """
    This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT.
    """
    FREE = "Free"
    BASIC = "Basic"
    STANDARD = "Standard"
    PREMIUM = "Premium"
    ENTERPRISE = "Enterprise"
