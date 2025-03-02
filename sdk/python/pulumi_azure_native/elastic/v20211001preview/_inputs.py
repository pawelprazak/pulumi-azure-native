# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from ._enums import *

__all__ = [
    'CompanyInfoArgs',
    'FilteringTagArgs',
    'IdentityPropertiesArgs',
    'LogRulesArgs',
    'MonitorPropertiesArgs',
    'MonitoringTagRulesPropertiesArgs',
    'ResourceSkuArgs',
    'UserInfoArgs',
]

@pulumi.input_type
class CompanyInfoArgs:
    def __init__(__self__, *,
                 business: Optional[pulumi.Input[str]] = None,
                 country: Optional[pulumi.Input[str]] = None,
                 domain: Optional[pulumi.Input[str]] = None,
                 employees_number: Optional[pulumi.Input[str]] = None,
                 state: Optional[pulumi.Input[str]] = None):
        """
        Company information of the user to be passed to partners.
        :param pulumi.Input[str] business: Business of the company
        :param pulumi.Input[str] country: Country of the company location.
        :param pulumi.Input[str] domain: Domain of the company
        :param pulumi.Input[str] employees_number: Number of employees in the company
        :param pulumi.Input[str] state: State of the company location.
        """
        if business is not None:
            pulumi.set(__self__, "business", business)
        if country is not None:
            pulumi.set(__self__, "country", country)
        if domain is not None:
            pulumi.set(__self__, "domain", domain)
        if employees_number is not None:
            pulumi.set(__self__, "employees_number", employees_number)
        if state is not None:
            pulumi.set(__self__, "state", state)

    @property
    @pulumi.getter
    def business(self) -> Optional[pulumi.Input[str]]:
        """
        Business of the company
        """
        return pulumi.get(self, "business")

    @business.setter
    def business(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "business", value)

    @property
    @pulumi.getter
    def country(self) -> Optional[pulumi.Input[str]]:
        """
        Country of the company location.
        """
        return pulumi.get(self, "country")

    @country.setter
    def country(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "country", value)

    @property
    @pulumi.getter
    def domain(self) -> Optional[pulumi.Input[str]]:
        """
        Domain of the company
        """
        return pulumi.get(self, "domain")

    @domain.setter
    def domain(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "domain", value)

    @property
    @pulumi.getter(name="employeesNumber")
    def employees_number(self) -> Optional[pulumi.Input[str]]:
        """
        Number of employees in the company
        """
        return pulumi.get(self, "employees_number")

    @employees_number.setter
    def employees_number(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "employees_number", value)

    @property
    @pulumi.getter
    def state(self) -> Optional[pulumi.Input[str]]:
        """
        State of the company location.
        """
        return pulumi.get(self, "state")

    @state.setter
    def state(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "state", value)


@pulumi.input_type
class FilteringTagArgs:
    def __init__(__self__, *,
                 action: Optional[pulumi.Input[Union[str, 'TagAction']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 value: Optional[pulumi.Input[str]] = None):
        """
        The definition of a filtering tag. Filtering tags are used for capturing resources and include/exclude them from being monitored.
        :param pulumi.Input[Union[str, 'TagAction']] action: Valid actions for a filtering tag.
        :param pulumi.Input[str] name: The name (also known as the key) of the tag.
        :param pulumi.Input[str] value: The value of the tag.
        """
        if action is not None:
            pulumi.set(__self__, "action", action)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def action(self) -> Optional[pulumi.Input[Union[str, 'TagAction']]]:
        """
        Valid actions for a filtering tag.
        """
        return pulumi.get(self, "action")

    @action.setter
    def action(self, value: Optional[pulumi.Input[Union[str, 'TagAction']]]):
        pulumi.set(self, "action", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name (also known as the key) of the tag.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def value(self) -> Optional[pulumi.Input[str]]:
        """
        The value of the tag.
        """
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "value", value)


@pulumi.input_type
class IdentityPropertiesArgs:
    def __init__(__self__, *,
                 type: Optional[pulumi.Input[Union[str, 'ManagedIdentityTypes']]] = None):
        """
        Identity properties.
        :param pulumi.Input[Union[str, 'ManagedIdentityTypes']] type: Managed identity type.
        """
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[Union[str, 'ManagedIdentityTypes']]]:
        """
        Managed identity type.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[Union[str, 'ManagedIdentityTypes']]]):
        pulumi.set(self, "type", value)


@pulumi.input_type
class LogRulesArgs:
    def __init__(__self__, *,
                 filtering_tags: Optional[pulumi.Input[Sequence[pulumi.Input['FilteringTagArgs']]]] = None,
                 send_aad_logs: Optional[pulumi.Input[bool]] = None,
                 send_activity_logs: Optional[pulumi.Input[bool]] = None,
                 send_subscription_logs: Optional[pulumi.Input[bool]] = None):
        """
        Set of rules for sending logs for the Monitor resource.
        :param pulumi.Input[Sequence[pulumi.Input['FilteringTagArgs']]] filtering_tags: List of filtering tags to be used for capturing logs. This only takes effect if SendActivityLogs flag is enabled. If empty, all resources will be captured. If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are specified, the rules will only include resources with the associated tags.
        :param pulumi.Input[bool] send_aad_logs: Flag specifying if AAD logs should be sent for the Monitor resource.
        :param pulumi.Input[bool] send_activity_logs: Flag specifying if activity logs from Azure resources should be sent for the Monitor resource.
        :param pulumi.Input[bool] send_subscription_logs: Flag specifying if subscription logs should be sent for the Monitor resource.
        """
        if filtering_tags is not None:
            pulumi.set(__self__, "filtering_tags", filtering_tags)
        if send_aad_logs is not None:
            pulumi.set(__self__, "send_aad_logs", send_aad_logs)
        if send_activity_logs is not None:
            pulumi.set(__self__, "send_activity_logs", send_activity_logs)
        if send_subscription_logs is not None:
            pulumi.set(__self__, "send_subscription_logs", send_subscription_logs)

    @property
    @pulumi.getter(name="filteringTags")
    def filtering_tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['FilteringTagArgs']]]]:
        """
        List of filtering tags to be used for capturing logs. This only takes effect if SendActivityLogs flag is enabled. If empty, all resources will be captured. If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are specified, the rules will only include resources with the associated tags.
        """
        return pulumi.get(self, "filtering_tags")

    @filtering_tags.setter
    def filtering_tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['FilteringTagArgs']]]]):
        pulumi.set(self, "filtering_tags", value)

    @property
    @pulumi.getter(name="sendAadLogs")
    def send_aad_logs(self) -> Optional[pulumi.Input[bool]]:
        """
        Flag specifying if AAD logs should be sent for the Monitor resource.
        """
        return pulumi.get(self, "send_aad_logs")

    @send_aad_logs.setter
    def send_aad_logs(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "send_aad_logs", value)

    @property
    @pulumi.getter(name="sendActivityLogs")
    def send_activity_logs(self) -> Optional[pulumi.Input[bool]]:
        """
        Flag specifying if activity logs from Azure resources should be sent for the Monitor resource.
        """
        return pulumi.get(self, "send_activity_logs")

    @send_activity_logs.setter
    def send_activity_logs(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "send_activity_logs", value)

    @property
    @pulumi.getter(name="sendSubscriptionLogs")
    def send_subscription_logs(self) -> Optional[pulumi.Input[bool]]:
        """
        Flag specifying if subscription logs should be sent for the Monitor resource.
        """
        return pulumi.get(self, "send_subscription_logs")

    @send_subscription_logs.setter
    def send_subscription_logs(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "send_subscription_logs", value)


@pulumi.input_type
class MonitorPropertiesArgs:
    def __init__(__self__, *,
                 monitoring_status: Optional[pulumi.Input[Union[str, 'MonitoringStatus']]] = None,
                 provisioning_state: Optional[pulumi.Input[Union[str, 'ProvisioningState']]] = None,
                 user_info: Optional[pulumi.Input['UserInfoArgs']] = None,
                 version: Optional[pulumi.Input[str]] = None):
        """
        Properties specific to the monitor resource.
        :param pulumi.Input[Union[str, 'MonitoringStatus']] monitoring_status: Flag specifying if the resource monitoring is enabled or disabled.
        :param pulumi.Input[Union[str, 'ProvisioningState']] provisioning_state: Provisioning state of the monitor resource.
        :param pulumi.Input['UserInfoArgs'] user_info: User information.
        :param pulumi.Input[str] version: Version of elastic of the monitor resource
        """
        if monitoring_status is not None:
            pulumi.set(__self__, "monitoring_status", monitoring_status)
        if provisioning_state is not None:
            pulumi.set(__self__, "provisioning_state", provisioning_state)
        if user_info is not None:
            pulumi.set(__self__, "user_info", user_info)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter(name="monitoringStatus")
    def monitoring_status(self) -> Optional[pulumi.Input[Union[str, 'MonitoringStatus']]]:
        """
        Flag specifying if the resource monitoring is enabled or disabled.
        """
        return pulumi.get(self, "monitoring_status")

    @monitoring_status.setter
    def monitoring_status(self, value: Optional[pulumi.Input[Union[str, 'MonitoringStatus']]]):
        pulumi.set(self, "monitoring_status", value)

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> Optional[pulumi.Input[Union[str, 'ProvisioningState']]]:
        """
        Provisioning state of the monitor resource.
        """
        return pulumi.get(self, "provisioning_state")

    @provisioning_state.setter
    def provisioning_state(self, value: Optional[pulumi.Input[Union[str, 'ProvisioningState']]]):
        pulumi.set(self, "provisioning_state", value)

    @property
    @pulumi.getter(name="userInfo")
    def user_info(self) -> Optional[pulumi.Input['UserInfoArgs']]:
        """
        User information.
        """
        return pulumi.get(self, "user_info")

    @user_info.setter
    def user_info(self, value: Optional[pulumi.Input['UserInfoArgs']]):
        pulumi.set(self, "user_info", value)

    @property
    @pulumi.getter
    def version(self) -> Optional[pulumi.Input[str]]:
        """
        Version of elastic of the monitor resource
        """
        return pulumi.get(self, "version")

    @version.setter
    def version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "version", value)


@pulumi.input_type
class MonitoringTagRulesPropertiesArgs:
    def __init__(__self__, *,
                 log_rules: Optional[pulumi.Input['LogRulesArgs']] = None,
                 provisioning_state: Optional[pulumi.Input[Union[str, 'ProvisioningState']]] = None):
        """
        Definition of the properties for a TagRules resource.
        :param pulumi.Input['LogRulesArgs'] log_rules: Rules for sending logs.
        :param pulumi.Input[Union[str, 'ProvisioningState']] provisioning_state: Provisioning state of the monitoring tag rules.
        """
        if log_rules is not None:
            pulumi.set(__self__, "log_rules", log_rules)
        if provisioning_state is not None:
            pulumi.set(__self__, "provisioning_state", provisioning_state)

    @property
    @pulumi.getter(name="logRules")
    def log_rules(self) -> Optional[pulumi.Input['LogRulesArgs']]:
        """
        Rules for sending logs.
        """
        return pulumi.get(self, "log_rules")

    @log_rules.setter
    def log_rules(self, value: Optional[pulumi.Input['LogRulesArgs']]):
        pulumi.set(self, "log_rules", value)

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> Optional[pulumi.Input[Union[str, 'ProvisioningState']]]:
        """
        Provisioning state of the monitoring tag rules.
        """
        return pulumi.get(self, "provisioning_state")

    @provisioning_state.setter
    def provisioning_state(self, value: Optional[pulumi.Input[Union[str, 'ProvisioningState']]]):
        pulumi.set(self, "provisioning_state", value)


@pulumi.input_type
class ResourceSkuArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str]):
        """
        Microsoft.Elastic SKU.
        :param pulumi.Input[str] name: Name of the SKU.
        """
        pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        Name of the SKU.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class UserInfoArgs:
    def __init__(__self__, *,
                 company_info: Optional[pulumi.Input['CompanyInfoArgs']] = None,
                 company_name: Optional[pulumi.Input[str]] = None,
                 email_address: Optional[pulumi.Input[str]] = None,
                 first_name: Optional[pulumi.Input[str]] = None,
                 last_name: Optional[pulumi.Input[str]] = None):
        """
        User Information to be passed to partners.
        :param pulumi.Input['CompanyInfoArgs'] company_info: Company information of the user to be passed to partners.
        :param pulumi.Input[str] company_name: Company name of the user
        :param pulumi.Input[str] email_address: Email of the user used by Elastic for contacting them if needed
        :param pulumi.Input[str] first_name: First name of the user
        :param pulumi.Input[str] last_name: Last name of the user
        """
        if company_info is not None:
            pulumi.set(__self__, "company_info", company_info)
        if company_name is not None:
            pulumi.set(__self__, "company_name", company_name)
        if email_address is not None:
            pulumi.set(__self__, "email_address", email_address)
        if first_name is not None:
            pulumi.set(__self__, "first_name", first_name)
        if last_name is not None:
            pulumi.set(__self__, "last_name", last_name)

    @property
    @pulumi.getter(name="companyInfo")
    def company_info(self) -> Optional[pulumi.Input['CompanyInfoArgs']]:
        """
        Company information of the user to be passed to partners.
        """
        return pulumi.get(self, "company_info")

    @company_info.setter
    def company_info(self, value: Optional[pulumi.Input['CompanyInfoArgs']]):
        pulumi.set(self, "company_info", value)

    @property
    @pulumi.getter(name="companyName")
    def company_name(self) -> Optional[pulumi.Input[str]]:
        """
        Company name of the user
        """
        return pulumi.get(self, "company_name")

    @company_name.setter
    def company_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "company_name", value)

    @property
    @pulumi.getter(name="emailAddress")
    def email_address(self) -> Optional[pulumi.Input[str]]:
        """
        Email of the user used by Elastic for contacting them if needed
        """
        return pulumi.get(self, "email_address")

    @email_address.setter
    def email_address(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "email_address", value)

    @property
    @pulumi.getter(name="firstName")
    def first_name(self) -> Optional[pulumi.Input[str]]:
        """
        First name of the user
        """
        return pulumi.get(self, "first_name")

    @first_name.setter
    def first_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "first_name", value)

    @property
    @pulumi.getter(name="lastName")
    def last_name(self) -> Optional[pulumi.Input[str]]:
        """
        Last name of the user
        """
        return pulumi.get(self, "last_name")

    @last_name.setter
    def last_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "last_name", value)


