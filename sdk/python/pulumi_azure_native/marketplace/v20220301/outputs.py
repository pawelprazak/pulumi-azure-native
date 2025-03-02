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
    'NewNotificationsResponse',
    'PlanNotificationDetailsResponse',
    'PlanResponse',
    'StopSellOffersPlansNotificationsListPropertiesResponse',
    'SystemDataResponse',
]

@pulumi.output_type
class NewNotificationsResponse(dict):
    """
    New plans notification details
    """
    def __init__(__self__, *,
                 display_name: Optional[str] = None,
                 icon: Optional[str] = None,
                 is_future_plans_enabled: Optional[bool] = None,
                 message_code: Optional[float] = None,
                 offer_id: Optional[str] = None,
                 plans: Optional[Sequence['outputs.PlanNotificationDetailsResponse']] = None):
        """
        New plans notification details
        :param str display_name: Gets offer display name
        :param str icon: Gets or sets the icon url
        :param bool is_future_plans_enabled: Gets a value indicating whether future plans is enabled.
        :param float message_code: Gets or sets the notification message id
        :param str offer_id: Gets offer id
        :param Sequence['PlanNotificationDetailsResponse'] plans: Gets or sets removed plans notifications
        """
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if icon is not None:
            pulumi.set(__self__, "icon", icon)
        if is_future_plans_enabled is not None:
            pulumi.set(__self__, "is_future_plans_enabled", is_future_plans_enabled)
        if message_code is not None:
            pulumi.set(__self__, "message_code", message_code)
        if offer_id is not None:
            pulumi.set(__self__, "offer_id", offer_id)
        if plans is not None:
            pulumi.set(__self__, "plans", plans)

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[str]:
        """
        Gets offer display name
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def icon(self) -> Optional[str]:
        """
        Gets or sets the icon url
        """
        return pulumi.get(self, "icon")

    @property
    @pulumi.getter(name="isFuturePlansEnabled")
    def is_future_plans_enabled(self) -> Optional[bool]:
        """
        Gets a value indicating whether future plans is enabled.
        """
        return pulumi.get(self, "is_future_plans_enabled")

    @property
    @pulumi.getter(name="messageCode")
    def message_code(self) -> Optional[float]:
        """
        Gets or sets the notification message id
        """
        return pulumi.get(self, "message_code")

    @property
    @pulumi.getter(name="offerId")
    def offer_id(self) -> Optional[str]:
        """
        Gets offer id
        """
        return pulumi.get(self, "offer_id")

    @property
    @pulumi.getter
    def plans(self) -> Optional[Sequence['outputs.PlanNotificationDetailsResponse']]:
        """
        Gets or sets removed plans notifications
        """
        return pulumi.get(self, "plans")


@pulumi.output_type
class PlanNotificationDetailsResponse(dict):
    """
    Plan notification details
    """
    def __init__(__self__, *,
                 plan_display_name: Optional[str] = None,
                 plan_id: Optional[str] = None):
        """
        Plan notification details
        :param str plan_display_name: Gets or sets the plan display name
        :param str plan_id: Gets or sets the plan id
        """
        if plan_display_name is not None:
            pulumi.set(__self__, "plan_display_name", plan_display_name)
        if plan_id is not None:
            pulumi.set(__self__, "plan_id", plan_id)

    @property
    @pulumi.getter(name="planDisplayName")
    def plan_display_name(self) -> Optional[str]:
        """
        Gets or sets the plan display name
        """
        return pulumi.get(self, "plan_display_name")

    @property
    @pulumi.getter(name="planId")
    def plan_id(self) -> Optional[str]:
        """
        Gets or sets the plan id
        """
        return pulumi.get(self, "plan_id")


@pulumi.output_type
class PlanResponse(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "altStackReference":
            suggest = "alt_stack_reference"
        elif key == "planDisplayName":
            suggest = "plan_display_name"
        elif key == "planId":
            suggest = "plan_id"
        elif key == "skuId":
            suggest = "sku_id"
        elif key == "stackType":
            suggest = "stack_type"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in PlanResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        PlanResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        PlanResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 alt_stack_reference: str,
                 plan_display_name: str,
                 plan_id: str,
                 sku_id: str,
                 stack_type: str,
                 accessibility: Optional[str] = None):
        """
        :param str alt_stack_reference: Alternative stack type
        :param str plan_display_name: Friendly name for the plan for display in the marketplace
        :param str plan_id: Text identifier for this plan
        :param str sku_id: Identifier for this plan
        :param str stack_type: Stack type (classic or arm)
        :param str accessibility: Plan accessibility
        """
        pulumi.set(__self__, "alt_stack_reference", alt_stack_reference)
        pulumi.set(__self__, "plan_display_name", plan_display_name)
        pulumi.set(__self__, "plan_id", plan_id)
        pulumi.set(__self__, "sku_id", sku_id)
        pulumi.set(__self__, "stack_type", stack_type)
        if accessibility is not None:
            pulumi.set(__self__, "accessibility", accessibility)

    @property
    @pulumi.getter(name="altStackReference")
    def alt_stack_reference(self) -> str:
        """
        Alternative stack type
        """
        return pulumi.get(self, "alt_stack_reference")

    @property
    @pulumi.getter(name="planDisplayName")
    def plan_display_name(self) -> str:
        """
        Friendly name for the plan for display in the marketplace
        """
        return pulumi.get(self, "plan_display_name")

    @property
    @pulumi.getter(name="planId")
    def plan_id(self) -> str:
        """
        Text identifier for this plan
        """
        return pulumi.get(self, "plan_id")

    @property
    @pulumi.getter(name="skuId")
    def sku_id(self) -> str:
        """
        Identifier for this plan
        """
        return pulumi.get(self, "sku_id")

    @property
    @pulumi.getter(name="stackType")
    def stack_type(self) -> str:
        """
        Stack type (classic or arm)
        """
        return pulumi.get(self, "stack_type")

    @property
    @pulumi.getter
    def accessibility(self) -> Optional[str]:
        """
        Plan accessibility
        """
        return pulumi.get(self, "accessibility")


@pulumi.output_type
class StopSellOffersPlansNotificationsListPropertiesResponse(dict):
    """
    List of stop sell offers and plans notifications.
    """
    def __init__(__self__, *,
                 display_name: str,
                 icon: str,
                 is_entire: bool,
                 message_code: float,
                 offer_id: str,
                 plans: Sequence['outputs.PlanNotificationDetailsResponse'],
                 public_context: bool,
                 subscriptions_ids: Sequence[str]):
        """
        List of stop sell offers and plans notifications.
        :param str display_name: The offer display name
        :param str icon: The icon url
        :param bool is_entire: A value indicating whether entire offer is in stop sell or only few of its plans
        :param float message_code: The notification message code
        :param str offer_id: The offer id
        :param Sequence['PlanNotificationDetailsResponse'] plans: The list of removed plans notifications
        :param bool public_context: True if the offer has public plans
        :param Sequence[str] subscriptions_ids: The subscriptions related to private plans
        """
        pulumi.set(__self__, "display_name", display_name)
        pulumi.set(__self__, "icon", icon)
        pulumi.set(__self__, "is_entire", is_entire)
        pulumi.set(__self__, "message_code", message_code)
        pulumi.set(__self__, "offer_id", offer_id)
        pulumi.set(__self__, "plans", plans)
        pulumi.set(__self__, "public_context", public_context)
        pulumi.set(__self__, "subscriptions_ids", subscriptions_ids)

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> str:
        """
        The offer display name
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def icon(self) -> str:
        """
        The icon url
        """
        return pulumi.get(self, "icon")

    @property
    @pulumi.getter(name="isEntire")
    def is_entire(self) -> bool:
        """
        A value indicating whether entire offer is in stop sell or only few of its plans
        """
        return pulumi.get(self, "is_entire")

    @property
    @pulumi.getter(name="messageCode")
    def message_code(self) -> float:
        """
        The notification message code
        """
        return pulumi.get(self, "message_code")

    @property
    @pulumi.getter(name="offerId")
    def offer_id(self) -> str:
        """
        The offer id
        """
        return pulumi.get(self, "offer_id")

    @property
    @pulumi.getter
    def plans(self) -> Sequence['outputs.PlanNotificationDetailsResponse']:
        """
        The list of removed plans notifications
        """
        return pulumi.get(self, "plans")

    @property
    @pulumi.getter(name="publicContext")
    def public_context(self) -> bool:
        """
        True if the offer has public plans
        """
        return pulumi.get(self, "public_context")

    @property
    @pulumi.getter(name="subscriptionsIds")
    def subscriptions_ids(self) -> Sequence[str]:
        """
        The subscriptions related to private plans
        """
        return pulumi.get(self, "subscriptions_ids")


@pulumi.output_type
class SystemDataResponse(dict):
    """
    Read only system data
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "createdAt":
            suggest = "created_at"
        elif key == "createdBy":
            suggest = "created_by"
        elif key == "createdByType":
            suggest = "created_by_type"
        elif key == "lastModifiedAt":
            suggest = "last_modified_at"
        elif key == "lastModifiedBy":
            suggest = "last_modified_by"
        elif key == "lastModifiedByType":
            suggest = "last_modified_by_type"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in SystemDataResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        SystemDataResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        SystemDataResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 created_at: Optional[str] = None,
                 created_by: Optional[str] = None,
                 created_by_type: Optional[str] = None,
                 last_modified_at: Optional[str] = None,
                 last_modified_by: Optional[str] = None,
                 last_modified_by_type: Optional[str] = None):
        """
        Read only system data
        :param str created_at: The timestamp of resource creation (UTC)
        :param str created_by: The identity that created the resource.
        :param str created_by_type: The type of identity that created the resource
        :param str last_modified_at: The timestamp of resource last modification (UTC)
        :param str last_modified_by: The identity that last modified the resource.
        :param str last_modified_by_type: The type of identity that last modified the resource
        """
        if created_at is not None:
            pulumi.set(__self__, "created_at", created_at)
        if created_by is not None:
            pulumi.set(__self__, "created_by", created_by)
        if created_by_type is not None:
            pulumi.set(__self__, "created_by_type", created_by_type)
        if last_modified_at is not None:
            pulumi.set(__self__, "last_modified_at", last_modified_at)
        if last_modified_by is not None:
            pulumi.set(__self__, "last_modified_by", last_modified_by)
        if last_modified_by_type is not None:
            pulumi.set(__self__, "last_modified_by_type", last_modified_by_type)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> Optional[str]:
        """
        The timestamp of resource creation (UTC)
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter(name="createdBy")
    def created_by(self) -> Optional[str]:
        """
        The identity that created the resource.
        """
        return pulumi.get(self, "created_by")

    @property
    @pulumi.getter(name="createdByType")
    def created_by_type(self) -> Optional[str]:
        """
        The type of identity that created the resource
        """
        return pulumi.get(self, "created_by_type")

    @property
    @pulumi.getter(name="lastModifiedAt")
    def last_modified_at(self) -> Optional[str]:
        """
        The timestamp of resource last modification (UTC)
        """
        return pulumi.get(self, "last_modified_at")

    @property
    @pulumi.getter(name="lastModifiedBy")
    def last_modified_by(self) -> Optional[str]:
        """
        The identity that last modified the resource.
        """
        return pulumi.get(self, "last_modified_by")

    @property
    @pulumi.getter(name="lastModifiedByType")
    def last_modified_by_type(self) -> Optional[str]:
        """
        The type of identity that last modified the resource
        """
        return pulumi.get(self, "last_modified_by_type")


