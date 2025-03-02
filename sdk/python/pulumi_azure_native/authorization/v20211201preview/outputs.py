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
    'AccessReviewHistoryInstanceResponse',
    'AccessReviewInstanceResponse',
    'AccessReviewReviewerResponse',
    'AccessReviewScopeResponse',
]

@pulumi.output_type
class AccessReviewHistoryInstanceResponse(dict):
    """
    Access Review History Definition Instance.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "downloadUri":
            suggest = "download_uri"
        elif key == "displayName":
            suggest = "display_name"
        elif key == "fulfilledDateTime":
            suggest = "fulfilled_date_time"
        elif key == "reviewHistoryPeriodEndDateTime":
            suggest = "review_history_period_end_date_time"
        elif key == "reviewHistoryPeriodStartDateTime":
            suggest = "review_history_period_start_date_time"
        elif key == "runDateTime":
            suggest = "run_date_time"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in AccessReviewHistoryInstanceResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        AccessReviewHistoryInstanceResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        AccessReviewHistoryInstanceResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 download_uri: str,
                 id: str,
                 name: str,
                 status: str,
                 type: str,
                 display_name: Optional[str] = None,
                 expiration: Optional[str] = None,
                 fulfilled_date_time: Optional[str] = None,
                 review_history_period_end_date_time: Optional[str] = None,
                 review_history_period_start_date_time: Optional[str] = None,
                 run_date_time: Optional[str] = None):
        """
        Access Review History Definition Instance.
        :param str download_uri: Uri which can be used to retrieve review history data. To generate this Uri, generateDownloadUri() must be called for a specific accessReviewHistoryDefinitionInstance. The link expires after a 24 hour period. Callers can see the expiration date time by looking at the 'se' parameter in the generated uri.
        :param str id: The access review history definition instance id.
        :param str name: The access review history definition instance unique id.
        :param str status: Status of the requested review history instance data. This is either requested, in-progress, done or error. The state transitions are as follows - Requested -> InProgress -> Done -> Expired
        :param str type: The resource type.
        :param str display_name: The display name for the parent history definition.
        :param str expiration: Date time when history data report expires and the associated data is deleted.
        :param str fulfilled_date_time: Date time when the history data report is scheduled to be generated.
        :param str review_history_period_end_date_time: Date time used when selecting review data, all reviews included in data end on or before this date. For use only with one-time/non-recurring reports.
        :param str review_history_period_start_date_time: Date time used when selecting review data, all reviews included in data start on or after this date. For use only with one-time/non-recurring reports.
        :param str run_date_time: Date time when the history data report is scheduled to be generated.
        """
        pulumi.set(__self__, "download_uri", download_uri)
        pulumi.set(__self__, "id", id)
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "status", status)
        pulumi.set(__self__, "type", type)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if expiration is not None:
            pulumi.set(__self__, "expiration", expiration)
        if fulfilled_date_time is not None:
            pulumi.set(__self__, "fulfilled_date_time", fulfilled_date_time)
        if review_history_period_end_date_time is not None:
            pulumi.set(__self__, "review_history_period_end_date_time", review_history_period_end_date_time)
        if review_history_period_start_date_time is not None:
            pulumi.set(__self__, "review_history_period_start_date_time", review_history_period_start_date_time)
        if run_date_time is not None:
            pulumi.set(__self__, "run_date_time", run_date_time)

    @property
    @pulumi.getter(name="downloadUri")
    def download_uri(self) -> str:
        """
        Uri which can be used to retrieve review history data. To generate this Uri, generateDownloadUri() must be called for a specific accessReviewHistoryDefinitionInstance. The link expires after a 24 hour period. Callers can see the expiration date time by looking at the 'se' parameter in the generated uri.
        """
        return pulumi.get(self, "download_uri")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The access review history definition instance id.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The access review history definition instance unique id.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        Status of the requested review history instance data. This is either requested, in-progress, done or error. The state transitions are as follows - Requested -> InProgress -> Done -> Expired
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The resource type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[str]:
        """
        The display name for the parent history definition.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def expiration(self) -> Optional[str]:
        """
        Date time when history data report expires and the associated data is deleted.
        """
        return pulumi.get(self, "expiration")

    @property
    @pulumi.getter(name="fulfilledDateTime")
    def fulfilled_date_time(self) -> Optional[str]:
        """
        Date time when the history data report is scheduled to be generated.
        """
        return pulumi.get(self, "fulfilled_date_time")

    @property
    @pulumi.getter(name="reviewHistoryPeriodEndDateTime")
    def review_history_period_end_date_time(self) -> Optional[str]:
        """
        Date time used when selecting review data, all reviews included in data end on or before this date. For use only with one-time/non-recurring reports.
        """
        return pulumi.get(self, "review_history_period_end_date_time")

    @property
    @pulumi.getter(name="reviewHistoryPeriodStartDateTime")
    def review_history_period_start_date_time(self) -> Optional[str]:
        """
        Date time used when selecting review data, all reviews included in data start on or after this date. For use only with one-time/non-recurring reports.
        """
        return pulumi.get(self, "review_history_period_start_date_time")

    @property
    @pulumi.getter(name="runDateTime")
    def run_date_time(self) -> Optional[str]:
        """
        Date time when the history data report is scheduled to be generated.
        """
        return pulumi.get(self, "run_date_time")


@pulumi.output_type
class AccessReviewInstanceResponse(dict):
    """
    Access Review Instance.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "reviewersType":
            suggest = "reviewers_type"
        elif key == "backupReviewers":
            suggest = "backup_reviewers"
        elif key == "endDateTime":
            suggest = "end_date_time"
        elif key == "startDateTime":
            suggest = "start_date_time"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in AccessReviewInstanceResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        AccessReviewInstanceResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        AccessReviewInstanceResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 id: str,
                 name: str,
                 reviewers_type: str,
                 status: str,
                 type: str,
                 backup_reviewers: Optional[Sequence['outputs.AccessReviewReviewerResponse']] = None,
                 end_date_time: Optional[str] = None,
                 reviewers: Optional[Sequence['outputs.AccessReviewReviewerResponse']] = None,
                 start_date_time: Optional[str] = None):
        """
        Access Review Instance.
        :param str id: The access review instance id.
        :param str name: The access review instance name.
        :param str reviewers_type: This field specifies the type of reviewers for a review. Usually for a review, reviewers are explicitly assigned. However, in some cases, the reviewers may not be assigned and instead be chosen dynamically. For example managers review or self review.
        :param str status: This read-only field specifies the status of an access review instance.
        :param str type: The resource type.
        :param Sequence['AccessReviewReviewerResponse'] backup_reviewers: This is the collection of backup reviewers.
        :param str end_date_time: The DateTime when the review instance is scheduled to end.
        :param Sequence['AccessReviewReviewerResponse'] reviewers: This is the collection of reviewers.
        :param str start_date_time: The DateTime when the review instance is scheduled to be start.
        """
        pulumi.set(__self__, "id", id)
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "reviewers_type", reviewers_type)
        pulumi.set(__self__, "status", status)
        pulumi.set(__self__, "type", type)
        if backup_reviewers is not None:
            pulumi.set(__self__, "backup_reviewers", backup_reviewers)
        if end_date_time is not None:
            pulumi.set(__self__, "end_date_time", end_date_time)
        if reviewers is not None:
            pulumi.set(__self__, "reviewers", reviewers)
        if start_date_time is not None:
            pulumi.set(__self__, "start_date_time", start_date_time)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The access review instance id.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The access review instance name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="reviewersType")
    def reviewers_type(self) -> str:
        """
        This field specifies the type of reviewers for a review. Usually for a review, reviewers are explicitly assigned. However, in some cases, the reviewers may not be assigned and instead be chosen dynamically. For example managers review or self review.
        """
        return pulumi.get(self, "reviewers_type")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        This read-only field specifies the status of an access review instance.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The resource type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="backupReviewers")
    def backup_reviewers(self) -> Optional[Sequence['outputs.AccessReviewReviewerResponse']]:
        """
        This is the collection of backup reviewers.
        """
        return pulumi.get(self, "backup_reviewers")

    @property
    @pulumi.getter(name="endDateTime")
    def end_date_time(self) -> Optional[str]:
        """
        The DateTime when the review instance is scheduled to end.
        """
        return pulumi.get(self, "end_date_time")

    @property
    @pulumi.getter
    def reviewers(self) -> Optional[Sequence['outputs.AccessReviewReviewerResponse']]:
        """
        This is the collection of reviewers.
        """
        return pulumi.get(self, "reviewers")

    @property
    @pulumi.getter(name="startDateTime")
    def start_date_time(self) -> Optional[str]:
        """
        The DateTime when the review instance is scheduled to be start.
        """
        return pulumi.get(self, "start_date_time")


@pulumi.output_type
class AccessReviewReviewerResponse(dict):
    """
    Descriptor for what needs to be reviewed
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "principalType":
            suggest = "principal_type"
        elif key == "principalId":
            suggest = "principal_id"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in AccessReviewReviewerResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        AccessReviewReviewerResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        AccessReviewReviewerResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 principal_type: str,
                 principal_id: Optional[str] = None):
        """
        Descriptor for what needs to be reviewed
        :param str principal_type: The identity type : user/servicePrincipal
        :param str principal_id: The id of the reviewer(user/servicePrincipal)
        """
        pulumi.set(__self__, "principal_type", principal_type)
        if principal_id is not None:
            pulumi.set(__self__, "principal_id", principal_id)

    @property
    @pulumi.getter(name="principalType")
    def principal_type(self) -> str:
        """
        The identity type : user/servicePrincipal
        """
        return pulumi.get(self, "principal_type")

    @property
    @pulumi.getter(name="principalId")
    def principal_id(self) -> Optional[str]:
        """
        The id of the reviewer(user/servicePrincipal)
        """
        return pulumi.get(self, "principal_id")


@pulumi.output_type
class AccessReviewScopeResponse(dict):
    """
    Descriptor for what needs to be reviewed
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "assignmentState":
            suggest = "assignment_state"
        elif key == "principalType":
            suggest = "principal_type"
        elif key == "resourceId":
            suggest = "resource_id"
        elif key == "roleDefinitionId":
            suggest = "role_definition_id"
        elif key == "excludeResourceId":
            suggest = "exclude_resource_id"
        elif key == "excludeRoleDefinitionId":
            suggest = "exclude_role_definition_id"
        elif key == "expandNestedMemberships":
            suggest = "expand_nested_memberships"
        elif key == "inactiveDuration":
            suggest = "inactive_duration"
        elif key == "includeAccessBelowResource":
            suggest = "include_access_below_resource"
        elif key == "includeInheritedAccess":
            suggest = "include_inherited_access"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in AccessReviewScopeResponse. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        AccessReviewScopeResponse.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        AccessReviewScopeResponse.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 assignment_state: str,
                 principal_type: str,
                 resource_id: str,
                 role_definition_id: str,
                 exclude_resource_id: Optional[str] = None,
                 exclude_role_definition_id: Optional[str] = None,
                 expand_nested_memberships: Optional[bool] = None,
                 inactive_duration: Optional[str] = None,
                 include_access_below_resource: Optional[bool] = None,
                 include_inherited_access: Optional[bool] = None):
        """
        Descriptor for what needs to be reviewed
        :param str assignment_state: The role assignment state eligible/active to review
        :param str principal_type: The identity type user/servicePrincipal to review
        :param str resource_id: ResourceId in which this review is getting created
        :param str role_definition_id: This is used to indicate the role being reviewed
        :param str exclude_resource_id: This is used to indicate the resource id(s) to exclude
        :param str exclude_role_definition_id: This is used to indicate the role definition id(s) to exclude
        :param bool expand_nested_memberships: Flag to indicate whether to expand nested memberships or not.
        :param str inactive_duration: Duration users are inactive for. The value should be in ISO  8601 format (http://en.wikipedia.org/wiki/ISO_8601#Durations).This code can be used to convert TimeSpan to a valid interval string: XmlConvert.ToString(new TimeSpan(hours, minutes, seconds))
        :param bool include_access_below_resource: Flag to indicate whether to expand nested memberships or not.
        :param bool include_inherited_access: Flag to indicate whether to expand nested memberships or not.
        """
        pulumi.set(__self__, "assignment_state", assignment_state)
        pulumi.set(__self__, "principal_type", principal_type)
        pulumi.set(__self__, "resource_id", resource_id)
        pulumi.set(__self__, "role_definition_id", role_definition_id)
        if exclude_resource_id is not None:
            pulumi.set(__self__, "exclude_resource_id", exclude_resource_id)
        if exclude_role_definition_id is not None:
            pulumi.set(__self__, "exclude_role_definition_id", exclude_role_definition_id)
        if expand_nested_memberships is not None:
            pulumi.set(__self__, "expand_nested_memberships", expand_nested_memberships)
        if inactive_duration is not None:
            pulumi.set(__self__, "inactive_duration", inactive_duration)
        if include_access_below_resource is not None:
            pulumi.set(__self__, "include_access_below_resource", include_access_below_resource)
        if include_inherited_access is not None:
            pulumi.set(__self__, "include_inherited_access", include_inherited_access)

    @property
    @pulumi.getter(name="assignmentState")
    def assignment_state(self) -> str:
        """
        The role assignment state eligible/active to review
        """
        return pulumi.get(self, "assignment_state")

    @property
    @pulumi.getter(name="principalType")
    def principal_type(self) -> str:
        """
        The identity type user/servicePrincipal to review
        """
        return pulumi.get(self, "principal_type")

    @property
    @pulumi.getter(name="resourceId")
    def resource_id(self) -> str:
        """
        ResourceId in which this review is getting created
        """
        return pulumi.get(self, "resource_id")

    @property
    @pulumi.getter(name="roleDefinitionId")
    def role_definition_id(self) -> str:
        """
        This is used to indicate the role being reviewed
        """
        return pulumi.get(self, "role_definition_id")

    @property
    @pulumi.getter(name="excludeResourceId")
    def exclude_resource_id(self) -> Optional[str]:
        """
        This is used to indicate the resource id(s) to exclude
        """
        return pulumi.get(self, "exclude_resource_id")

    @property
    @pulumi.getter(name="excludeRoleDefinitionId")
    def exclude_role_definition_id(self) -> Optional[str]:
        """
        This is used to indicate the role definition id(s) to exclude
        """
        return pulumi.get(self, "exclude_role_definition_id")

    @property
    @pulumi.getter(name="expandNestedMemberships")
    def expand_nested_memberships(self) -> Optional[bool]:
        """
        Flag to indicate whether to expand nested memberships or not.
        """
        return pulumi.get(self, "expand_nested_memberships")

    @property
    @pulumi.getter(name="inactiveDuration")
    def inactive_duration(self) -> Optional[str]:
        """
        Duration users are inactive for. The value should be in ISO  8601 format (http://en.wikipedia.org/wiki/ISO_8601#Durations).This code can be used to convert TimeSpan to a valid interval string: XmlConvert.ToString(new TimeSpan(hours, minutes, seconds))
        """
        return pulumi.get(self, "inactive_duration")

    @property
    @pulumi.getter(name="includeAccessBelowResource")
    def include_access_below_resource(self) -> Optional[bool]:
        """
        Flag to indicate whether to expand nested memberships or not.
        """
        return pulumi.get(self, "include_access_below_resource")

    @property
    @pulumi.getter(name="includeInheritedAccess")
    def include_inherited_access(self) -> Optional[bool]:
        """
        Flag to indicate whether to expand nested memberships or not.
        """
        return pulumi.get(self, "include_inherited_access")


