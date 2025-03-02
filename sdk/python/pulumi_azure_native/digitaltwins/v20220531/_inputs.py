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
    'AzureDataExplorerConnectionPropertiesArgs',
    'ConnectionPropertiesPrivateLinkServiceConnectionStateArgs',
    'ConnectionPropertiesArgs',
    'DigitalTwinsIdentityArgs',
    'EventGridArgs',
    'EventHubArgs',
    'PrivateEndpointConnectionArgs',
    'ServiceBusArgs',
]

@pulumi.input_type
class AzureDataExplorerConnectionPropertiesArgs:
    def __init__(__self__, *,
                 adx_database_name: pulumi.Input[str],
                 adx_endpoint_uri: pulumi.Input[str],
                 adx_resource_id: pulumi.Input[str],
                 connection_type: pulumi.Input[str],
                 event_hub_endpoint_uri: pulumi.Input[str],
                 event_hub_entity_path: pulumi.Input[str],
                 event_hub_namespace_resource_id: pulumi.Input[str],
                 adx_table_name: Optional[pulumi.Input[str]] = None,
                 event_hub_consumer_group: Optional[pulumi.Input[str]] = None):
        """
        Properties of a time series database connection to Azure Data Explorer with data being sent via an EventHub.
        :param pulumi.Input[str] adx_database_name: The name of the Azure Data Explorer database.
        :param pulumi.Input[str] adx_endpoint_uri: The URI of the Azure Data Explorer endpoint.
        :param pulumi.Input[str] adx_resource_id: The resource ID of the Azure Data Explorer cluster.
        :param pulumi.Input[str] connection_type: The type of time series connection resource.
               Expected value is 'AzureDataExplorer'.
        :param pulumi.Input[str] event_hub_endpoint_uri: The URL of the EventHub namespace for identity-based authentication. It must include the protocol sb://
        :param pulumi.Input[str] event_hub_entity_path: The EventHub name in the EventHub namespace for identity-based authentication.
        :param pulumi.Input[str] event_hub_namespace_resource_id: The resource ID of the EventHub namespace.
        :param pulumi.Input[str] adx_table_name: The name of the Azure Data Explorer table.
        :param pulumi.Input[str] event_hub_consumer_group: The EventHub consumer group to use when ADX reads from EventHub. Defaults to $Default.
        """
        pulumi.set(__self__, "adx_database_name", adx_database_name)
        pulumi.set(__self__, "adx_endpoint_uri", adx_endpoint_uri)
        pulumi.set(__self__, "adx_resource_id", adx_resource_id)
        pulumi.set(__self__, "connection_type", 'AzureDataExplorer')
        pulumi.set(__self__, "event_hub_endpoint_uri", event_hub_endpoint_uri)
        pulumi.set(__self__, "event_hub_entity_path", event_hub_entity_path)
        pulumi.set(__self__, "event_hub_namespace_resource_id", event_hub_namespace_resource_id)
        if adx_table_name is not None:
            pulumi.set(__self__, "adx_table_name", adx_table_name)
        if event_hub_consumer_group is not None:
            pulumi.set(__self__, "event_hub_consumer_group", event_hub_consumer_group)

    @property
    @pulumi.getter(name="adxDatabaseName")
    def adx_database_name(self) -> pulumi.Input[str]:
        """
        The name of the Azure Data Explorer database.
        """
        return pulumi.get(self, "adx_database_name")

    @adx_database_name.setter
    def adx_database_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "adx_database_name", value)

    @property
    @pulumi.getter(name="adxEndpointUri")
    def adx_endpoint_uri(self) -> pulumi.Input[str]:
        """
        The URI of the Azure Data Explorer endpoint.
        """
        return pulumi.get(self, "adx_endpoint_uri")

    @adx_endpoint_uri.setter
    def adx_endpoint_uri(self, value: pulumi.Input[str]):
        pulumi.set(self, "adx_endpoint_uri", value)

    @property
    @pulumi.getter(name="adxResourceId")
    def adx_resource_id(self) -> pulumi.Input[str]:
        """
        The resource ID of the Azure Data Explorer cluster.
        """
        return pulumi.get(self, "adx_resource_id")

    @adx_resource_id.setter
    def adx_resource_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "adx_resource_id", value)

    @property
    @pulumi.getter(name="connectionType")
    def connection_type(self) -> pulumi.Input[str]:
        """
        The type of time series connection resource.
        Expected value is 'AzureDataExplorer'.
        """
        return pulumi.get(self, "connection_type")

    @connection_type.setter
    def connection_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "connection_type", value)

    @property
    @pulumi.getter(name="eventHubEndpointUri")
    def event_hub_endpoint_uri(self) -> pulumi.Input[str]:
        """
        The URL of the EventHub namespace for identity-based authentication. It must include the protocol sb://
        """
        return pulumi.get(self, "event_hub_endpoint_uri")

    @event_hub_endpoint_uri.setter
    def event_hub_endpoint_uri(self, value: pulumi.Input[str]):
        pulumi.set(self, "event_hub_endpoint_uri", value)

    @property
    @pulumi.getter(name="eventHubEntityPath")
    def event_hub_entity_path(self) -> pulumi.Input[str]:
        """
        The EventHub name in the EventHub namespace for identity-based authentication.
        """
        return pulumi.get(self, "event_hub_entity_path")

    @event_hub_entity_path.setter
    def event_hub_entity_path(self, value: pulumi.Input[str]):
        pulumi.set(self, "event_hub_entity_path", value)

    @property
    @pulumi.getter(name="eventHubNamespaceResourceId")
    def event_hub_namespace_resource_id(self) -> pulumi.Input[str]:
        """
        The resource ID of the EventHub namespace.
        """
        return pulumi.get(self, "event_hub_namespace_resource_id")

    @event_hub_namespace_resource_id.setter
    def event_hub_namespace_resource_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "event_hub_namespace_resource_id", value)

    @property
    @pulumi.getter(name="adxTableName")
    def adx_table_name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the Azure Data Explorer table.
        """
        return pulumi.get(self, "adx_table_name")

    @adx_table_name.setter
    def adx_table_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "adx_table_name", value)

    @property
    @pulumi.getter(name="eventHubConsumerGroup")
    def event_hub_consumer_group(self) -> Optional[pulumi.Input[str]]:
        """
        The EventHub consumer group to use when ADX reads from EventHub. Defaults to $Default.
        """
        return pulumi.get(self, "event_hub_consumer_group")

    @event_hub_consumer_group.setter
    def event_hub_consumer_group(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "event_hub_consumer_group", value)


@pulumi.input_type
class ConnectionPropertiesPrivateLinkServiceConnectionStateArgs:
    def __init__(__self__, *,
                 description: pulumi.Input[str],
                 status: pulumi.Input[Union[str, 'PrivateLinkServiceConnectionStatus']],
                 actions_required: Optional[pulumi.Input[str]] = None):
        """
        The connection state.
        :param pulumi.Input[str] description: The description for the current state of a private endpoint connection.
        :param pulumi.Input[Union[str, 'PrivateLinkServiceConnectionStatus']] status: The status of a private endpoint connection.
        :param pulumi.Input[str] actions_required: Actions required for a private endpoint connection.
        """
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "status", status)
        if actions_required is not None:
            pulumi.set(__self__, "actions_required", actions_required)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Input[str]:
        """
        The description for the current state of a private endpoint connection.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: pulumi.Input[str]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def status(self) -> pulumi.Input[Union[str, 'PrivateLinkServiceConnectionStatus']]:
        """
        The status of a private endpoint connection.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: pulumi.Input[Union[str, 'PrivateLinkServiceConnectionStatus']]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter(name="actionsRequired")
    def actions_required(self) -> Optional[pulumi.Input[str]]:
        """
        Actions required for a private endpoint connection.
        """
        return pulumi.get(self, "actions_required")

    @actions_required.setter
    def actions_required(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "actions_required", value)


@pulumi.input_type
class ConnectionPropertiesArgs:
    def __init__(__self__, *,
                 group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 private_link_service_connection_state: Optional[pulumi.Input['ConnectionPropertiesPrivateLinkServiceConnectionStateArgs']] = None):
        """
        The properties of a private endpoint connection.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] group_ids: The list of group ids for the private endpoint connection.
        :param pulumi.Input['ConnectionPropertiesPrivateLinkServiceConnectionStateArgs'] private_link_service_connection_state: The connection state.
        """
        if group_ids is not None:
            pulumi.set(__self__, "group_ids", group_ids)
        if private_link_service_connection_state is not None:
            pulumi.set(__self__, "private_link_service_connection_state", private_link_service_connection_state)

    @property
    @pulumi.getter(name="groupIds")
    def group_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        The list of group ids for the private endpoint connection.
        """
        return pulumi.get(self, "group_ids")

    @group_ids.setter
    def group_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "group_ids", value)

    @property
    @pulumi.getter(name="privateLinkServiceConnectionState")
    def private_link_service_connection_state(self) -> Optional[pulumi.Input['ConnectionPropertiesPrivateLinkServiceConnectionStateArgs']]:
        """
        The connection state.
        """
        return pulumi.get(self, "private_link_service_connection_state")

    @private_link_service_connection_state.setter
    def private_link_service_connection_state(self, value: Optional[pulumi.Input['ConnectionPropertiesPrivateLinkServiceConnectionStateArgs']]):
        pulumi.set(self, "private_link_service_connection_state", value)


@pulumi.input_type
class DigitalTwinsIdentityArgs:
    def __init__(__self__, *,
                 type: Optional[pulumi.Input[Union[str, 'DigitalTwinsIdentityType']]] = None):
        """
        The managed identity for the DigitalTwinsInstance.
        :param pulumi.Input[Union[str, 'DigitalTwinsIdentityType']] type: The type of Managed Identity used by the DigitalTwinsInstance. Only SystemAssigned is supported.
        """
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[Union[str, 'DigitalTwinsIdentityType']]]:
        """
        The type of Managed Identity used by the DigitalTwinsInstance. Only SystemAssigned is supported.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[Union[str, 'DigitalTwinsIdentityType']]]):
        pulumi.set(self, "type", value)


@pulumi.input_type
class EventGridArgs:
    def __init__(__self__, *,
                 access_key1: pulumi.Input[str],
                 endpoint_type: pulumi.Input[str],
                 topic_endpoint: pulumi.Input[str],
                 access_key2: Optional[pulumi.Input[str]] = None,
                 authentication_type: Optional[pulumi.Input[Union[str, 'AuthenticationType']]] = None,
                 dead_letter_secret: Optional[pulumi.Input[str]] = None,
                 dead_letter_uri: Optional[pulumi.Input[str]] = None):
        """
        Properties related to EventGrid.
        :param pulumi.Input[str] access_key1: EventGrid secondary accesskey. Will be obfuscated during read.
        :param pulumi.Input[str] endpoint_type: The type of Digital Twins endpoint
               Expected value is 'EventGrid'.
        :param pulumi.Input[str] topic_endpoint: EventGrid Topic Endpoint.
        :param pulumi.Input[str] access_key2: EventGrid secondary accesskey. Will be obfuscated during read.
        :param pulumi.Input[Union[str, 'AuthenticationType']] authentication_type: Specifies the authentication type being used for connecting to the endpoint. Defaults to 'KeyBased'. If 'KeyBased' is selected, a connection string must be specified (at least the primary connection string). If 'IdentityBased' is select, the endpointUri and entityPath properties must be specified.
        :param pulumi.Input[str] dead_letter_secret: Dead letter storage secret for key-based authentication. Will be obfuscated during read.
        :param pulumi.Input[str] dead_letter_uri: Dead letter storage URL for identity-based authentication.
        """
        pulumi.set(__self__, "access_key1", access_key1)
        pulumi.set(__self__, "endpoint_type", 'EventGrid')
        pulumi.set(__self__, "topic_endpoint", topic_endpoint)
        if access_key2 is not None:
            pulumi.set(__self__, "access_key2", access_key2)
        if authentication_type is not None:
            pulumi.set(__self__, "authentication_type", authentication_type)
        if dead_letter_secret is not None:
            pulumi.set(__self__, "dead_letter_secret", dead_letter_secret)
        if dead_letter_uri is not None:
            pulumi.set(__self__, "dead_letter_uri", dead_letter_uri)

    @property
    @pulumi.getter(name="accessKey1")
    def access_key1(self) -> pulumi.Input[str]:
        """
        EventGrid secondary accesskey. Will be obfuscated during read.
        """
        return pulumi.get(self, "access_key1")

    @access_key1.setter
    def access_key1(self, value: pulumi.Input[str]):
        pulumi.set(self, "access_key1", value)

    @property
    @pulumi.getter(name="endpointType")
    def endpoint_type(self) -> pulumi.Input[str]:
        """
        The type of Digital Twins endpoint
        Expected value is 'EventGrid'.
        """
        return pulumi.get(self, "endpoint_type")

    @endpoint_type.setter
    def endpoint_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "endpoint_type", value)

    @property
    @pulumi.getter(name="topicEndpoint")
    def topic_endpoint(self) -> pulumi.Input[str]:
        """
        EventGrid Topic Endpoint.
        """
        return pulumi.get(self, "topic_endpoint")

    @topic_endpoint.setter
    def topic_endpoint(self, value: pulumi.Input[str]):
        pulumi.set(self, "topic_endpoint", value)

    @property
    @pulumi.getter(name="accessKey2")
    def access_key2(self) -> Optional[pulumi.Input[str]]:
        """
        EventGrid secondary accesskey. Will be obfuscated during read.
        """
        return pulumi.get(self, "access_key2")

    @access_key2.setter
    def access_key2(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "access_key2", value)

    @property
    @pulumi.getter(name="authenticationType")
    def authentication_type(self) -> Optional[pulumi.Input[Union[str, 'AuthenticationType']]]:
        """
        Specifies the authentication type being used for connecting to the endpoint. Defaults to 'KeyBased'. If 'KeyBased' is selected, a connection string must be specified (at least the primary connection string). If 'IdentityBased' is select, the endpointUri and entityPath properties must be specified.
        """
        return pulumi.get(self, "authentication_type")

    @authentication_type.setter
    def authentication_type(self, value: Optional[pulumi.Input[Union[str, 'AuthenticationType']]]):
        pulumi.set(self, "authentication_type", value)

    @property
    @pulumi.getter(name="deadLetterSecret")
    def dead_letter_secret(self) -> Optional[pulumi.Input[str]]:
        """
        Dead letter storage secret for key-based authentication. Will be obfuscated during read.
        """
        return pulumi.get(self, "dead_letter_secret")

    @dead_letter_secret.setter
    def dead_letter_secret(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "dead_letter_secret", value)

    @property
    @pulumi.getter(name="deadLetterUri")
    def dead_letter_uri(self) -> Optional[pulumi.Input[str]]:
        """
        Dead letter storage URL for identity-based authentication.
        """
        return pulumi.get(self, "dead_letter_uri")

    @dead_letter_uri.setter
    def dead_letter_uri(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "dead_letter_uri", value)


@pulumi.input_type
class EventHubArgs:
    def __init__(__self__, *,
                 endpoint_type: pulumi.Input[str],
                 authentication_type: Optional[pulumi.Input[Union[str, 'AuthenticationType']]] = None,
                 connection_string_primary_key: Optional[pulumi.Input[str]] = None,
                 connection_string_secondary_key: Optional[pulumi.Input[str]] = None,
                 dead_letter_secret: Optional[pulumi.Input[str]] = None,
                 dead_letter_uri: Optional[pulumi.Input[str]] = None,
                 endpoint_uri: Optional[pulumi.Input[str]] = None,
                 entity_path: Optional[pulumi.Input[str]] = None):
        """
        Properties related to EventHub.
        :param pulumi.Input[str] endpoint_type: The type of Digital Twins endpoint
               Expected value is 'EventHub'.
        :param pulumi.Input[Union[str, 'AuthenticationType']] authentication_type: Specifies the authentication type being used for connecting to the endpoint. Defaults to 'KeyBased'. If 'KeyBased' is selected, a connection string must be specified (at least the primary connection string). If 'IdentityBased' is select, the endpointUri and entityPath properties must be specified.
        :param pulumi.Input[str] connection_string_primary_key: PrimaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read.
        :param pulumi.Input[str] connection_string_secondary_key: SecondaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read.
        :param pulumi.Input[str] dead_letter_secret: Dead letter storage secret for key-based authentication. Will be obfuscated during read.
        :param pulumi.Input[str] dead_letter_uri: Dead letter storage URL for identity-based authentication.
        :param pulumi.Input[str] endpoint_uri: The URL of the EventHub namespace for identity-based authentication. It must include the protocol 'sb://'.
        :param pulumi.Input[str] entity_path: The EventHub name in the EventHub namespace for identity-based authentication.
        """
        pulumi.set(__self__, "endpoint_type", 'EventHub')
        if authentication_type is not None:
            pulumi.set(__self__, "authentication_type", authentication_type)
        if connection_string_primary_key is not None:
            pulumi.set(__self__, "connection_string_primary_key", connection_string_primary_key)
        if connection_string_secondary_key is not None:
            pulumi.set(__self__, "connection_string_secondary_key", connection_string_secondary_key)
        if dead_letter_secret is not None:
            pulumi.set(__self__, "dead_letter_secret", dead_letter_secret)
        if dead_letter_uri is not None:
            pulumi.set(__self__, "dead_letter_uri", dead_letter_uri)
        if endpoint_uri is not None:
            pulumi.set(__self__, "endpoint_uri", endpoint_uri)
        if entity_path is not None:
            pulumi.set(__self__, "entity_path", entity_path)

    @property
    @pulumi.getter(name="endpointType")
    def endpoint_type(self) -> pulumi.Input[str]:
        """
        The type of Digital Twins endpoint
        Expected value is 'EventHub'.
        """
        return pulumi.get(self, "endpoint_type")

    @endpoint_type.setter
    def endpoint_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "endpoint_type", value)

    @property
    @pulumi.getter(name="authenticationType")
    def authentication_type(self) -> Optional[pulumi.Input[Union[str, 'AuthenticationType']]]:
        """
        Specifies the authentication type being used for connecting to the endpoint. Defaults to 'KeyBased'. If 'KeyBased' is selected, a connection string must be specified (at least the primary connection string). If 'IdentityBased' is select, the endpointUri and entityPath properties must be specified.
        """
        return pulumi.get(self, "authentication_type")

    @authentication_type.setter
    def authentication_type(self, value: Optional[pulumi.Input[Union[str, 'AuthenticationType']]]):
        pulumi.set(self, "authentication_type", value)

    @property
    @pulumi.getter(name="connectionStringPrimaryKey")
    def connection_string_primary_key(self) -> Optional[pulumi.Input[str]]:
        """
        PrimaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read.
        """
        return pulumi.get(self, "connection_string_primary_key")

    @connection_string_primary_key.setter
    def connection_string_primary_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "connection_string_primary_key", value)

    @property
    @pulumi.getter(name="connectionStringSecondaryKey")
    def connection_string_secondary_key(self) -> Optional[pulumi.Input[str]]:
        """
        SecondaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read.
        """
        return pulumi.get(self, "connection_string_secondary_key")

    @connection_string_secondary_key.setter
    def connection_string_secondary_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "connection_string_secondary_key", value)

    @property
    @pulumi.getter(name="deadLetterSecret")
    def dead_letter_secret(self) -> Optional[pulumi.Input[str]]:
        """
        Dead letter storage secret for key-based authentication. Will be obfuscated during read.
        """
        return pulumi.get(self, "dead_letter_secret")

    @dead_letter_secret.setter
    def dead_letter_secret(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "dead_letter_secret", value)

    @property
    @pulumi.getter(name="deadLetterUri")
    def dead_letter_uri(self) -> Optional[pulumi.Input[str]]:
        """
        Dead letter storage URL for identity-based authentication.
        """
        return pulumi.get(self, "dead_letter_uri")

    @dead_letter_uri.setter
    def dead_letter_uri(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "dead_letter_uri", value)

    @property
    @pulumi.getter(name="endpointUri")
    def endpoint_uri(self) -> Optional[pulumi.Input[str]]:
        """
        The URL of the EventHub namespace for identity-based authentication. It must include the protocol 'sb://'.
        """
        return pulumi.get(self, "endpoint_uri")

    @endpoint_uri.setter
    def endpoint_uri(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "endpoint_uri", value)

    @property
    @pulumi.getter(name="entityPath")
    def entity_path(self) -> Optional[pulumi.Input[str]]:
        """
        The EventHub name in the EventHub namespace for identity-based authentication.
        """
        return pulumi.get(self, "entity_path")

    @entity_path.setter
    def entity_path(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "entity_path", value)


@pulumi.input_type
class PrivateEndpointConnectionArgs:
    def __init__(__self__, *,
                 properties: pulumi.Input['ConnectionPropertiesArgs']):
        """
        The private endpoint connection of a Digital Twin.
        :param pulumi.Input['ConnectionPropertiesArgs'] properties: The connection properties.
        """
        pulumi.set(__self__, "properties", properties)

    @property
    @pulumi.getter
    def properties(self) -> pulumi.Input['ConnectionPropertiesArgs']:
        """
        The connection properties.
        """
        return pulumi.get(self, "properties")

    @properties.setter
    def properties(self, value: pulumi.Input['ConnectionPropertiesArgs']):
        pulumi.set(self, "properties", value)


@pulumi.input_type
class ServiceBusArgs:
    def __init__(__self__, *,
                 endpoint_type: pulumi.Input[str],
                 authentication_type: Optional[pulumi.Input[Union[str, 'AuthenticationType']]] = None,
                 dead_letter_secret: Optional[pulumi.Input[str]] = None,
                 dead_letter_uri: Optional[pulumi.Input[str]] = None,
                 endpoint_uri: Optional[pulumi.Input[str]] = None,
                 entity_path: Optional[pulumi.Input[str]] = None,
                 primary_connection_string: Optional[pulumi.Input[str]] = None,
                 secondary_connection_string: Optional[pulumi.Input[str]] = None):
        """
        Properties related to ServiceBus.
        :param pulumi.Input[str] endpoint_type: The type of Digital Twins endpoint
               Expected value is 'ServiceBus'.
        :param pulumi.Input[Union[str, 'AuthenticationType']] authentication_type: Specifies the authentication type being used for connecting to the endpoint. Defaults to 'KeyBased'. If 'KeyBased' is selected, a connection string must be specified (at least the primary connection string). If 'IdentityBased' is select, the endpointUri and entityPath properties must be specified.
        :param pulumi.Input[str] dead_letter_secret: Dead letter storage secret for key-based authentication. Will be obfuscated during read.
        :param pulumi.Input[str] dead_letter_uri: Dead letter storage URL for identity-based authentication.
        :param pulumi.Input[str] endpoint_uri: The URL of the ServiceBus namespace for identity-based authentication. It must include the protocol 'sb://'.
        :param pulumi.Input[str] entity_path: The ServiceBus Topic name for identity-based authentication.
        :param pulumi.Input[str] primary_connection_string: PrimaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read.
        :param pulumi.Input[str] secondary_connection_string: SecondaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read.
        """
        pulumi.set(__self__, "endpoint_type", 'ServiceBus')
        if authentication_type is not None:
            pulumi.set(__self__, "authentication_type", authentication_type)
        if dead_letter_secret is not None:
            pulumi.set(__self__, "dead_letter_secret", dead_letter_secret)
        if dead_letter_uri is not None:
            pulumi.set(__self__, "dead_letter_uri", dead_letter_uri)
        if endpoint_uri is not None:
            pulumi.set(__self__, "endpoint_uri", endpoint_uri)
        if entity_path is not None:
            pulumi.set(__self__, "entity_path", entity_path)
        if primary_connection_string is not None:
            pulumi.set(__self__, "primary_connection_string", primary_connection_string)
        if secondary_connection_string is not None:
            pulumi.set(__self__, "secondary_connection_string", secondary_connection_string)

    @property
    @pulumi.getter(name="endpointType")
    def endpoint_type(self) -> pulumi.Input[str]:
        """
        The type of Digital Twins endpoint
        Expected value is 'ServiceBus'.
        """
        return pulumi.get(self, "endpoint_type")

    @endpoint_type.setter
    def endpoint_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "endpoint_type", value)

    @property
    @pulumi.getter(name="authenticationType")
    def authentication_type(self) -> Optional[pulumi.Input[Union[str, 'AuthenticationType']]]:
        """
        Specifies the authentication type being used for connecting to the endpoint. Defaults to 'KeyBased'. If 'KeyBased' is selected, a connection string must be specified (at least the primary connection string). If 'IdentityBased' is select, the endpointUri and entityPath properties must be specified.
        """
        return pulumi.get(self, "authentication_type")

    @authentication_type.setter
    def authentication_type(self, value: Optional[pulumi.Input[Union[str, 'AuthenticationType']]]):
        pulumi.set(self, "authentication_type", value)

    @property
    @pulumi.getter(name="deadLetterSecret")
    def dead_letter_secret(self) -> Optional[pulumi.Input[str]]:
        """
        Dead letter storage secret for key-based authentication. Will be obfuscated during read.
        """
        return pulumi.get(self, "dead_letter_secret")

    @dead_letter_secret.setter
    def dead_letter_secret(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "dead_letter_secret", value)

    @property
    @pulumi.getter(name="deadLetterUri")
    def dead_letter_uri(self) -> Optional[pulumi.Input[str]]:
        """
        Dead letter storage URL for identity-based authentication.
        """
        return pulumi.get(self, "dead_letter_uri")

    @dead_letter_uri.setter
    def dead_letter_uri(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "dead_letter_uri", value)

    @property
    @pulumi.getter(name="endpointUri")
    def endpoint_uri(self) -> Optional[pulumi.Input[str]]:
        """
        The URL of the ServiceBus namespace for identity-based authentication. It must include the protocol 'sb://'.
        """
        return pulumi.get(self, "endpoint_uri")

    @endpoint_uri.setter
    def endpoint_uri(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "endpoint_uri", value)

    @property
    @pulumi.getter(name="entityPath")
    def entity_path(self) -> Optional[pulumi.Input[str]]:
        """
        The ServiceBus Topic name for identity-based authentication.
        """
        return pulumi.get(self, "entity_path")

    @entity_path.setter
    def entity_path(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "entity_path", value)

    @property
    @pulumi.getter(name="primaryConnectionString")
    def primary_connection_string(self) -> Optional[pulumi.Input[str]]:
        """
        PrimaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read.
        """
        return pulumi.get(self, "primary_connection_string")

    @primary_connection_string.setter
    def primary_connection_string(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "primary_connection_string", value)

    @property
    @pulumi.getter(name="secondaryConnectionString")
    def secondary_connection_string(self) -> Optional[pulumi.Input[str]]:
        """
        SecondaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read.
        """
        return pulumi.get(self, "secondary_connection_string")

    @secondary_connection_string.setter
    def secondary_connection_string(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "secondary_connection_string", value)


