# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from ._enums import *

__all__ = [
    'AADBasedSecurityPrincipalArgs',
    'CertBasedSecurityPrincipalArgs',
    'LedgerPropertiesArgs',
]

@pulumi.input_type
class AADBasedSecurityPrincipalArgs:
    def __init__(__self__, *,
                 ledger_role_name: Optional[pulumi.Input[Union[str, 'LedgerRoleName']]] = None,
                 principal_id: Optional[pulumi.Input[str]] = None,
                 tenant_id: Optional[pulumi.Input[str]] = None):
        """
        AAD based security principal with associated Ledger RoleName
        :param pulumi.Input[Union[str, 'LedgerRoleName']] ledger_role_name: LedgerRole associated with the Security Principal of Ledger
        :param pulumi.Input[str] principal_id: UUID/GUID based Principal Id of the Security Principal
        :param pulumi.Input[str] tenant_id: UUID/GUID based Tenant Id of the Security Principal
        """
        if ledger_role_name is not None:
            pulumi.set(__self__, "ledger_role_name", ledger_role_name)
        if principal_id is not None:
            pulumi.set(__self__, "principal_id", principal_id)
        if tenant_id is not None:
            pulumi.set(__self__, "tenant_id", tenant_id)

    @property
    @pulumi.getter(name="ledgerRoleName")
    def ledger_role_name(self) -> Optional[pulumi.Input[Union[str, 'LedgerRoleName']]]:
        """
        LedgerRole associated with the Security Principal of Ledger
        """
        return pulumi.get(self, "ledger_role_name")

    @ledger_role_name.setter
    def ledger_role_name(self, value: Optional[pulumi.Input[Union[str, 'LedgerRoleName']]]):
        pulumi.set(self, "ledger_role_name", value)

    @property
    @pulumi.getter(name="principalId")
    def principal_id(self) -> Optional[pulumi.Input[str]]:
        """
        UUID/GUID based Principal Id of the Security Principal
        """
        return pulumi.get(self, "principal_id")

    @principal_id.setter
    def principal_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "principal_id", value)

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> Optional[pulumi.Input[str]]:
        """
        UUID/GUID based Tenant Id of the Security Principal
        """
        return pulumi.get(self, "tenant_id")

    @tenant_id.setter
    def tenant_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "tenant_id", value)


@pulumi.input_type
class CertBasedSecurityPrincipalArgs:
    def __init__(__self__, *,
                 cert: Optional[pulumi.Input[str]] = None,
                 ledger_role_name: Optional[pulumi.Input[Union[str, 'LedgerRoleName']]] = None):
        """
        Cert based security principal with Ledger RoleName
        :param pulumi.Input[str] cert: Public key of the user cert (.pem or .cer)
        :param pulumi.Input[Union[str, 'LedgerRoleName']] ledger_role_name: LedgerRole associated with the Security Principal of Ledger
        """
        if cert is not None:
            pulumi.set(__self__, "cert", cert)
        if ledger_role_name is not None:
            pulumi.set(__self__, "ledger_role_name", ledger_role_name)

    @property
    @pulumi.getter
    def cert(self) -> Optional[pulumi.Input[str]]:
        """
        Public key of the user cert (.pem or .cer)
        """
        return pulumi.get(self, "cert")

    @cert.setter
    def cert(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cert", value)

    @property
    @pulumi.getter(name="ledgerRoleName")
    def ledger_role_name(self) -> Optional[pulumi.Input[Union[str, 'LedgerRoleName']]]:
        """
        LedgerRole associated with the Security Principal of Ledger
        """
        return pulumi.get(self, "ledger_role_name")

    @ledger_role_name.setter
    def ledger_role_name(self, value: Optional[pulumi.Input[Union[str, 'LedgerRoleName']]]):
        pulumi.set(self, "ledger_role_name", value)


@pulumi.input_type
class LedgerPropertiesArgs:
    def __init__(__self__, *,
                 aad_based_security_principals: Optional[pulumi.Input[Sequence[pulumi.Input['AADBasedSecurityPrincipalArgs']]]] = None,
                 cert_based_security_principals: Optional[pulumi.Input[Sequence[pulumi.Input['CertBasedSecurityPrincipalArgs']]]] = None,
                 ledger_storage_account: Optional[pulumi.Input[str]] = None,
                 ledger_type: Optional[pulumi.Input[Union[str, 'LedgerType']]] = None):
        """
        Additional Confidential Ledger properties.
        :param pulumi.Input[Sequence[pulumi.Input['AADBasedSecurityPrincipalArgs']]] aad_based_security_principals: Array of all AAD based Security Principals.
        :param pulumi.Input[Sequence[pulumi.Input['CertBasedSecurityPrincipalArgs']]] cert_based_security_principals: Array of all cert based Security Principals.
        :param pulumi.Input[str] ledger_storage_account: Name of the Blob Storage Account for saving ledger files
        :param pulumi.Input[Union[str, 'LedgerType']] ledger_type: Type of Confidential Ledger
        """
        if aad_based_security_principals is not None:
            pulumi.set(__self__, "aad_based_security_principals", aad_based_security_principals)
        if cert_based_security_principals is not None:
            pulumi.set(__self__, "cert_based_security_principals", cert_based_security_principals)
        if ledger_storage_account is not None:
            pulumi.set(__self__, "ledger_storage_account", ledger_storage_account)
        if ledger_type is not None:
            pulumi.set(__self__, "ledger_type", ledger_type)

    @property
    @pulumi.getter(name="aadBasedSecurityPrincipals")
    def aad_based_security_principals(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['AADBasedSecurityPrincipalArgs']]]]:
        """
        Array of all AAD based Security Principals.
        """
        return pulumi.get(self, "aad_based_security_principals")

    @aad_based_security_principals.setter
    def aad_based_security_principals(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['AADBasedSecurityPrincipalArgs']]]]):
        pulumi.set(self, "aad_based_security_principals", value)

    @property
    @pulumi.getter(name="certBasedSecurityPrincipals")
    def cert_based_security_principals(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['CertBasedSecurityPrincipalArgs']]]]:
        """
        Array of all cert based Security Principals.
        """
        return pulumi.get(self, "cert_based_security_principals")

    @cert_based_security_principals.setter
    def cert_based_security_principals(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['CertBasedSecurityPrincipalArgs']]]]):
        pulumi.set(self, "cert_based_security_principals", value)

    @property
    @pulumi.getter(name="ledgerStorageAccount")
    def ledger_storage_account(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the Blob Storage Account for saving ledger files
        """
        return pulumi.get(self, "ledger_storage_account")

    @ledger_storage_account.setter
    def ledger_storage_account(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ledger_storage_account", value)

    @property
    @pulumi.getter(name="ledgerType")
    def ledger_type(self) -> Optional[pulumi.Input[Union[str, 'LedgerType']]]:
        """
        Type of Confidential Ledger
        """
        return pulumi.get(self, "ledger_type")

    @ledger_type.setter
    def ledger_type(self, value: Optional[pulumi.Input[Union[str, 'LedgerType']]]):
        pulumi.set(self, "ledger_type", value)


