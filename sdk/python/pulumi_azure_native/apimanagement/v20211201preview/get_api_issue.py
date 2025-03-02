# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'GetApiIssueResult',
    'AwaitableGetApiIssueResult',
    'get_api_issue',
    'get_api_issue_output',
]

@pulumi.output_type
class GetApiIssueResult:
    """
    Issue Contract details.
    """
    def __init__(__self__, api_id=None, created_date=None, description=None, id=None, name=None, state=None, title=None, type=None, user_id=None):
        if api_id and not isinstance(api_id, str):
            raise TypeError("Expected argument 'api_id' to be a str")
        pulumi.set(__self__, "api_id", api_id)
        if created_date and not isinstance(created_date, str):
            raise TypeError("Expected argument 'created_date' to be a str")
        pulumi.set(__self__, "created_date", created_date)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if state and not isinstance(state, str):
            raise TypeError("Expected argument 'state' to be a str")
        pulumi.set(__self__, "state", state)
        if title and not isinstance(title, str):
            raise TypeError("Expected argument 'title' to be a str")
        pulumi.set(__self__, "title", title)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if user_id and not isinstance(user_id, str):
            raise TypeError("Expected argument 'user_id' to be a str")
        pulumi.set(__self__, "user_id", user_id)

    @property
    @pulumi.getter(name="apiId")
    def api_id(self) -> Optional[str]:
        """
        A resource identifier for the API the issue was created for.
        """
        return pulumi.get(self, "api_id")

    @property
    @pulumi.getter(name="createdDate")
    def created_date(self) -> Optional[str]:
        """
        Date and time when the issue was created.
        """
        return pulumi.get(self, "created_date")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        Text describing the issue.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def state(self) -> Optional[str]:
        """
        Status of the issue.
        """
        return pulumi.get(self, "state")

    @property
    @pulumi.getter
    def title(self) -> str:
        """
        The issue title.
        """
        return pulumi.get(self, "title")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="userId")
    def user_id(self) -> str:
        """
        A resource identifier for the user created the issue.
        """
        return pulumi.get(self, "user_id")


class AwaitableGetApiIssueResult(GetApiIssueResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetApiIssueResult(
            api_id=self.api_id,
            created_date=self.created_date,
            description=self.description,
            id=self.id,
            name=self.name,
            state=self.state,
            title=self.title,
            type=self.type,
            user_id=self.user_id)


def get_api_issue(api_id: Optional[str] = None,
                  expand_comments_attachments: Optional[bool] = None,
                  issue_id: Optional[str] = None,
                  resource_group_name: Optional[str] = None,
                  service_name: Optional[str] = None,
                  opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetApiIssueResult:
    """
    Issue Contract details.


    :param str api_id: API identifier. Must be unique in the current API Management service instance.
    :param bool expand_comments_attachments: Expand the comment attachments. 
    :param str issue_id: Issue identifier. Must be unique in the current API Management service instance.
    :param str resource_group_name: The name of the resource group.
    :param str service_name: The name of the API Management service.
    """
    __args__ = dict()
    __args__['apiId'] = api_id
    __args__['expandCommentsAttachments'] = expand_comments_attachments
    __args__['issueId'] = issue_id
    __args__['resourceGroupName'] = resource_group_name
    __args__['serviceName'] = service_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:apimanagement/v20211201preview:getApiIssue', __args__, opts=opts, typ=GetApiIssueResult).value

    return AwaitableGetApiIssueResult(
        api_id=__ret__.api_id,
        created_date=__ret__.created_date,
        description=__ret__.description,
        id=__ret__.id,
        name=__ret__.name,
        state=__ret__.state,
        title=__ret__.title,
        type=__ret__.type,
        user_id=__ret__.user_id)


@_utilities.lift_output_func(get_api_issue)
def get_api_issue_output(api_id: Optional[pulumi.Input[str]] = None,
                         expand_comments_attachments: Optional[pulumi.Input[Optional[bool]]] = None,
                         issue_id: Optional[pulumi.Input[str]] = None,
                         resource_group_name: Optional[pulumi.Input[str]] = None,
                         service_name: Optional[pulumi.Input[str]] = None,
                         opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetApiIssueResult]:
    """
    Issue Contract details.


    :param str api_id: API identifier. Must be unique in the current API Management service instance.
    :param bool expand_comments_attachments: Expand the comment attachments. 
    :param str issue_id: Issue identifier. Must be unique in the current API Management service instance.
    :param str resource_group_name: The name of the resource group.
    :param str service_name: The name of the API Management service.
    """
    ...
