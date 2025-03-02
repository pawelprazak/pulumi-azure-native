# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'AuthType',
    'ClientType',
    'SecretType',
    'Type',
    'VNetSolutionType',
]


class AuthType(str, Enum):
    """
    The authentication type.
    """
    SYSTEM_ASSIGNED_IDENTITY = "systemAssignedIdentity"
    USER_ASSIGNED_IDENTITY = "userAssignedIdentity"
    SERVICE_PRINCIPAL_SECRET = "servicePrincipalSecret"
    SERVICE_PRINCIPAL_CERTIFICATE = "servicePrincipalCertificate"
    SECRET = "secret"


class ClientType(str, Enum):
    """
    The application client type
    """
    NONE = "none"
    DOTNET = "dotnet"
    JAVA = "java"
    PYTHON = "python"
    GO = "go"
    PHP = "php"
    RUBY = "ruby"
    DJANGO = "django"
    NODEJS = "nodejs"
    SPRING_BOOT = "springBoot"


class SecretType(str, Enum):
    """
    The secret type.
    """
    RAW_VALUE = "rawValue"
    KEY_VAULT_SECRET_URI = "keyVaultSecretUri"
    KEY_VAULT_SECRET_REFERENCE = "keyVaultSecretReference"


class Type(str, Enum):
    """
    The target service type.
    """
    AZURE_RESOURCE = "AzureResource"
    CONFLUENT_BOOTSTRAP_SERVER = "ConfluentBootstrapServer"
    CONFLUENT_SCHEMA_REGISTRY = "ConfluentSchemaRegistry"


class VNetSolutionType(str, Enum):
    """
    Type of VNet solution.
    """
    SERVICE_ENDPOINT = "serviceEndpoint"
    PRIVATE_LINK = "privateLink"
