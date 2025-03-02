# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from ._enums import *

__all__ = ['WCFRelayArgs', 'WCFRelay']

@pulumi.input_type
class WCFRelayArgs:
    def __init__(__self__, *,
                 namespace_name: pulumi.Input[str],
                 resource_group_name: pulumi.Input[str],
                 relay_name: Optional[pulumi.Input[str]] = None,
                 relay_type: Optional[pulumi.Input[Union[str, 'Relaytype']]] = None,
                 requires_client_authorization: Optional[pulumi.Input[bool]] = None,
                 requires_transport_security: Optional[pulumi.Input[bool]] = None,
                 user_metadata: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a WCFRelay resource.
        :param pulumi.Input[str] namespace_name: The Namespace Name
        :param pulumi.Input[str] resource_group_name: Name of the Resource group within the Azure subscription.
        :param pulumi.Input[str] relay_name: The relay name
        :param pulumi.Input[Union[str, 'Relaytype']] relay_type: WCFRelay Type.
        :param pulumi.Input[bool] requires_client_authorization: true if client authorization is needed for this relay; otherwise, false.
        :param pulumi.Input[bool] requires_transport_security: true if transport security is needed for this relay; otherwise, false.
        :param pulumi.Input[str] user_metadata: usermetadata is a placeholder to store user-defined string data for the HybridConnection endpoint.e.g. it can be used to store  descriptive data, such as list of teams and their contact information also user-defined configuration settings can be stored.
        """
        pulumi.set(__self__, "namespace_name", namespace_name)
        pulumi.set(__self__, "resource_group_name", resource_group_name)
        if relay_name is not None:
            pulumi.set(__self__, "relay_name", relay_name)
        if relay_type is not None:
            pulumi.set(__self__, "relay_type", relay_type)
        if requires_client_authorization is not None:
            pulumi.set(__self__, "requires_client_authorization", requires_client_authorization)
        if requires_transport_security is not None:
            pulumi.set(__self__, "requires_transport_security", requires_transport_security)
        if user_metadata is not None:
            pulumi.set(__self__, "user_metadata", user_metadata)

    @property
    @pulumi.getter(name="namespaceName")
    def namespace_name(self) -> pulumi.Input[str]:
        """
        The Namespace Name
        """
        return pulumi.get(self, "namespace_name")

    @namespace_name.setter
    def namespace_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "namespace_name", value)

    @property
    @pulumi.getter(name="resourceGroupName")
    def resource_group_name(self) -> pulumi.Input[str]:
        """
        Name of the Resource group within the Azure subscription.
        """
        return pulumi.get(self, "resource_group_name")

    @resource_group_name.setter
    def resource_group_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "resource_group_name", value)

    @property
    @pulumi.getter(name="relayName")
    def relay_name(self) -> Optional[pulumi.Input[str]]:
        """
        The relay name
        """
        return pulumi.get(self, "relay_name")

    @relay_name.setter
    def relay_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "relay_name", value)

    @property
    @pulumi.getter(name="relayType")
    def relay_type(self) -> Optional[pulumi.Input[Union[str, 'Relaytype']]]:
        """
        WCFRelay Type.
        """
        return pulumi.get(self, "relay_type")

    @relay_type.setter
    def relay_type(self, value: Optional[pulumi.Input[Union[str, 'Relaytype']]]):
        pulumi.set(self, "relay_type", value)

    @property
    @pulumi.getter(name="requiresClientAuthorization")
    def requires_client_authorization(self) -> Optional[pulumi.Input[bool]]:
        """
        true if client authorization is needed for this relay; otherwise, false.
        """
        return pulumi.get(self, "requires_client_authorization")

    @requires_client_authorization.setter
    def requires_client_authorization(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "requires_client_authorization", value)

    @property
    @pulumi.getter(name="requiresTransportSecurity")
    def requires_transport_security(self) -> Optional[pulumi.Input[bool]]:
        """
        true if transport security is needed for this relay; otherwise, false.
        """
        return pulumi.get(self, "requires_transport_security")

    @requires_transport_security.setter
    def requires_transport_security(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "requires_transport_security", value)

    @property
    @pulumi.getter(name="userMetadata")
    def user_metadata(self) -> Optional[pulumi.Input[str]]:
        """
        usermetadata is a placeholder to store user-defined string data for the HybridConnection endpoint.e.g. it can be used to store  descriptive data, such as list of teams and their contact information also user-defined configuration settings can be stored.
        """
        return pulumi.get(self, "user_metadata")

    @user_metadata.setter
    def user_metadata(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "user_metadata", value)


warnings.warn("""Version 2016-07-01 will be removed in v2 of the provider.""", DeprecationWarning)


class WCFRelay(pulumi.CustomResource):
    warnings.warn("""Version 2016-07-01 will be removed in v2 of the provider.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 namespace_name: Optional[pulumi.Input[str]] = None,
                 relay_name: Optional[pulumi.Input[str]] = None,
                 relay_type: Optional[pulumi.Input[Union[str, 'Relaytype']]] = None,
                 requires_client_authorization: Optional[pulumi.Input[bool]] = None,
                 requires_transport_security: Optional[pulumi.Input[bool]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 user_metadata: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Description of WcfRelays Resource.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] namespace_name: The Namespace Name
        :param pulumi.Input[str] relay_name: The relay name
        :param pulumi.Input[Union[str, 'Relaytype']] relay_type: WCFRelay Type.
        :param pulumi.Input[bool] requires_client_authorization: true if client authorization is needed for this relay; otherwise, false.
        :param pulumi.Input[bool] requires_transport_security: true if transport security is needed for this relay; otherwise, false.
        :param pulumi.Input[str] resource_group_name: Name of the Resource group within the Azure subscription.
        :param pulumi.Input[str] user_metadata: usermetadata is a placeholder to store user-defined string data for the HybridConnection endpoint.e.g. it can be used to store  descriptive data, such as list of teams and their contact information also user-defined configuration settings can be stored.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: WCFRelayArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Description of WcfRelays Resource.

        :param str resource_name: The name of the resource.
        :param WCFRelayArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(WCFRelayArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 namespace_name: Optional[pulumi.Input[str]] = None,
                 relay_name: Optional[pulumi.Input[str]] = None,
                 relay_type: Optional[pulumi.Input[Union[str, 'Relaytype']]] = None,
                 requires_client_authorization: Optional[pulumi.Input[bool]] = None,
                 requires_transport_security: Optional[pulumi.Input[bool]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 user_metadata: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        pulumi.log.warn("""WCFRelay is deprecated: Version 2016-07-01 will be removed in v2 of the provider.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = WCFRelayArgs.__new__(WCFRelayArgs)

            if namespace_name is None and not opts.urn:
                raise TypeError("Missing required property 'namespace_name'")
            __props__.__dict__["namespace_name"] = namespace_name
            __props__.__dict__["relay_name"] = relay_name
            __props__.__dict__["relay_type"] = relay_type
            __props__.__dict__["requires_client_authorization"] = requires_client_authorization
            __props__.__dict__["requires_transport_security"] = requires_transport_security
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__.__dict__["resource_group_name"] = resource_group_name
            __props__.__dict__["user_metadata"] = user_metadata
            __props__.__dict__["created_at"] = None
            __props__.__dict__["is_dynamic"] = None
            __props__.__dict__["listener_count"] = None
            __props__.__dict__["name"] = None
            __props__.__dict__["type"] = None
            __props__.__dict__["updated_at"] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-native:relay:WCFRelay"), pulumi.Alias(type_="azure-native:relay/v20170401:WCFRelay"), pulumi.Alias(type_="azure-native:relay/v20211101:WCFRelay")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(WCFRelay, __self__).__init__(
            'azure-native:relay/v20160701:WCFRelay',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'WCFRelay':
        """
        Get an existing WCFRelay resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = WCFRelayArgs.__new__(WCFRelayArgs)

        __props__.__dict__["created_at"] = None
        __props__.__dict__["is_dynamic"] = None
        __props__.__dict__["listener_count"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["relay_type"] = None
        __props__.__dict__["requires_client_authorization"] = None
        __props__.__dict__["requires_transport_security"] = None
        __props__.__dict__["type"] = None
        __props__.__dict__["updated_at"] = None
        __props__.__dict__["user_metadata"] = None
        return WCFRelay(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> pulumi.Output[str]:
        """
        The time the WCFRelay was created.
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter(name="isDynamic")
    def is_dynamic(self) -> pulumi.Output[bool]:
        """
        true if the relay is dynamic; otherwise, false.
        """
        return pulumi.get(self, "is_dynamic")

    @property
    @pulumi.getter(name="listenerCount")
    def listener_count(self) -> pulumi.Output[int]:
        """
        The number of listeners for this relay. min : 1 and max:25 supported
        """
        return pulumi.get(self, "listener_count")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="relayType")
    def relay_type(self) -> pulumi.Output[Optional[str]]:
        """
        WCFRelay Type.
        """
        return pulumi.get(self, "relay_type")

    @property
    @pulumi.getter(name="requiresClientAuthorization")
    def requires_client_authorization(self) -> pulumi.Output[Optional[bool]]:
        """
        true if client authorization is needed for this relay; otherwise, false.
        """
        return pulumi.get(self, "requires_client_authorization")

    @property
    @pulumi.getter(name="requiresTransportSecurity")
    def requires_transport_security(self) -> pulumi.Output[Optional[bool]]:
        """
        true if transport security is needed for this relay; otherwise, false.
        """
        return pulumi.get(self, "requires_transport_security")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="updatedAt")
    def updated_at(self) -> pulumi.Output[str]:
        """
        The time the namespace was updated.
        """
        return pulumi.get(self, "updated_at")

    @property
    @pulumi.getter(name="userMetadata")
    def user_metadata(self) -> pulumi.Output[Optional[str]]:
        """
        usermetadata is a placeholder to store user-defined string data for the HybridConnection endpoint.e.g. it can be used to store  descriptive data, such as list of teams and their contact information also user-defined configuration settings can be stored.
        """
        return pulumi.get(self, "user_metadata")

