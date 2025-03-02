# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from . import outputs

__all__ = [
    'GetDatabaseAccountResult',
    'AwaitableGetDatabaseAccountResult',
    'get_database_account',
    'get_database_account_output',
]

@pulumi.output_type
class GetDatabaseAccountResult:
    """
    An Azure Cosmos DB database account.
    """
    def __init__(__self__, analytical_storage_configuration=None, api_properties=None, backup_policy=None, capabilities=None, connector_offer=None, consistency_policy=None, cors=None, database_account_offer_type=None, default_identity=None, disable_key_based_metadata_write_access=None, document_endpoint=None, enable_analytical_storage=None, enable_automatic_failover=None, enable_cassandra_connector=None, enable_free_tier=None, enable_multiple_write_locations=None, failover_policies=None, id=None, identity=None, ip_rules=None, is_virtual_network_filter_enabled=None, key_vault_key_uri=None, kind=None, location=None, locations=None, name=None, network_acl_bypass=None, network_acl_bypass_resource_ids=None, private_endpoint_connections=None, provisioning_state=None, public_network_access=None, read_locations=None, tags=None, type=None, virtual_network_rules=None, write_locations=None):
        if analytical_storage_configuration and not isinstance(analytical_storage_configuration, dict):
            raise TypeError("Expected argument 'analytical_storage_configuration' to be a dict")
        pulumi.set(__self__, "analytical_storage_configuration", analytical_storage_configuration)
        if api_properties and not isinstance(api_properties, dict):
            raise TypeError("Expected argument 'api_properties' to be a dict")
        pulumi.set(__self__, "api_properties", api_properties)
        if backup_policy and not isinstance(backup_policy, dict):
            raise TypeError("Expected argument 'backup_policy' to be a dict")
        pulumi.set(__self__, "backup_policy", backup_policy)
        if capabilities and not isinstance(capabilities, list):
            raise TypeError("Expected argument 'capabilities' to be a list")
        pulumi.set(__self__, "capabilities", capabilities)
        if connector_offer and not isinstance(connector_offer, str):
            raise TypeError("Expected argument 'connector_offer' to be a str")
        pulumi.set(__self__, "connector_offer", connector_offer)
        if consistency_policy and not isinstance(consistency_policy, dict):
            raise TypeError("Expected argument 'consistency_policy' to be a dict")
        pulumi.set(__self__, "consistency_policy", consistency_policy)
        if cors and not isinstance(cors, list):
            raise TypeError("Expected argument 'cors' to be a list")
        pulumi.set(__self__, "cors", cors)
        if database_account_offer_type and not isinstance(database_account_offer_type, str):
            raise TypeError("Expected argument 'database_account_offer_type' to be a str")
        pulumi.set(__self__, "database_account_offer_type", database_account_offer_type)
        if default_identity and not isinstance(default_identity, str):
            raise TypeError("Expected argument 'default_identity' to be a str")
        pulumi.set(__self__, "default_identity", default_identity)
        if disable_key_based_metadata_write_access and not isinstance(disable_key_based_metadata_write_access, bool):
            raise TypeError("Expected argument 'disable_key_based_metadata_write_access' to be a bool")
        pulumi.set(__self__, "disable_key_based_metadata_write_access", disable_key_based_metadata_write_access)
        if document_endpoint and not isinstance(document_endpoint, str):
            raise TypeError("Expected argument 'document_endpoint' to be a str")
        pulumi.set(__self__, "document_endpoint", document_endpoint)
        if enable_analytical_storage and not isinstance(enable_analytical_storage, bool):
            raise TypeError("Expected argument 'enable_analytical_storage' to be a bool")
        pulumi.set(__self__, "enable_analytical_storage", enable_analytical_storage)
        if enable_automatic_failover and not isinstance(enable_automatic_failover, bool):
            raise TypeError("Expected argument 'enable_automatic_failover' to be a bool")
        pulumi.set(__self__, "enable_automatic_failover", enable_automatic_failover)
        if enable_cassandra_connector and not isinstance(enable_cassandra_connector, bool):
            raise TypeError("Expected argument 'enable_cassandra_connector' to be a bool")
        pulumi.set(__self__, "enable_cassandra_connector", enable_cassandra_connector)
        if enable_free_tier and not isinstance(enable_free_tier, bool):
            raise TypeError("Expected argument 'enable_free_tier' to be a bool")
        pulumi.set(__self__, "enable_free_tier", enable_free_tier)
        if enable_multiple_write_locations and not isinstance(enable_multiple_write_locations, bool):
            raise TypeError("Expected argument 'enable_multiple_write_locations' to be a bool")
        pulumi.set(__self__, "enable_multiple_write_locations", enable_multiple_write_locations)
        if failover_policies and not isinstance(failover_policies, list):
            raise TypeError("Expected argument 'failover_policies' to be a list")
        pulumi.set(__self__, "failover_policies", failover_policies)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if identity and not isinstance(identity, dict):
            raise TypeError("Expected argument 'identity' to be a dict")
        pulumi.set(__self__, "identity", identity)
        if ip_rules and not isinstance(ip_rules, list):
            raise TypeError("Expected argument 'ip_rules' to be a list")
        pulumi.set(__self__, "ip_rules", ip_rules)
        if is_virtual_network_filter_enabled and not isinstance(is_virtual_network_filter_enabled, bool):
            raise TypeError("Expected argument 'is_virtual_network_filter_enabled' to be a bool")
        pulumi.set(__self__, "is_virtual_network_filter_enabled", is_virtual_network_filter_enabled)
        if key_vault_key_uri and not isinstance(key_vault_key_uri, str):
            raise TypeError("Expected argument 'key_vault_key_uri' to be a str")
        pulumi.set(__self__, "key_vault_key_uri", key_vault_key_uri)
        if kind and not isinstance(kind, str):
            raise TypeError("Expected argument 'kind' to be a str")
        pulumi.set(__self__, "kind", kind)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if locations and not isinstance(locations, list):
            raise TypeError("Expected argument 'locations' to be a list")
        pulumi.set(__self__, "locations", locations)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if network_acl_bypass and not isinstance(network_acl_bypass, str):
            raise TypeError("Expected argument 'network_acl_bypass' to be a str")
        pulumi.set(__self__, "network_acl_bypass", network_acl_bypass)
        if network_acl_bypass_resource_ids and not isinstance(network_acl_bypass_resource_ids, list):
            raise TypeError("Expected argument 'network_acl_bypass_resource_ids' to be a list")
        pulumi.set(__self__, "network_acl_bypass_resource_ids", network_acl_bypass_resource_ids)
        if private_endpoint_connections and not isinstance(private_endpoint_connections, list):
            raise TypeError("Expected argument 'private_endpoint_connections' to be a list")
        pulumi.set(__self__, "private_endpoint_connections", private_endpoint_connections)
        if provisioning_state and not isinstance(provisioning_state, str):
            raise TypeError("Expected argument 'provisioning_state' to be a str")
        pulumi.set(__self__, "provisioning_state", provisioning_state)
        if public_network_access and not isinstance(public_network_access, str):
            raise TypeError("Expected argument 'public_network_access' to be a str")
        pulumi.set(__self__, "public_network_access", public_network_access)
        if read_locations and not isinstance(read_locations, list):
            raise TypeError("Expected argument 'read_locations' to be a list")
        pulumi.set(__self__, "read_locations", read_locations)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if virtual_network_rules and not isinstance(virtual_network_rules, list):
            raise TypeError("Expected argument 'virtual_network_rules' to be a list")
        pulumi.set(__self__, "virtual_network_rules", virtual_network_rules)
        if write_locations and not isinstance(write_locations, list):
            raise TypeError("Expected argument 'write_locations' to be a list")
        pulumi.set(__self__, "write_locations", write_locations)

    @property
    @pulumi.getter(name="analyticalStorageConfiguration")
    def analytical_storage_configuration(self) -> Optional['outputs.AnalyticalStorageConfigurationResponse']:
        """
        Analytical storage specific properties.
        """
        return pulumi.get(self, "analytical_storage_configuration")

    @property
    @pulumi.getter(name="apiProperties")
    def api_properties(self) -> Optional['outputs.ApiPropertiesResponse']:
        """
        API specific properties.
        """
        return pulumi.get(self, "api_properties")

    @property
    @pulumi.getter(name="backupPolicy")
    def backup_policy(self) -> Optional[Any]:
        """
        The object representing the policy for taking backups on an account.
        """
        return pulumi.get(self, "backup_policy")

    @property
    @pulumi.getter
    def capabilities(self) -> Optional[Sequence['outputs.CapabilityResponse']]:
        """
        List of Cosmos DB capabilities for the account
        """
        return pulumi.get(self, "capabilities")

    @property
    @pulumi.getter(name="connectorOffer")
    def connector_offer(self) -> Optional[str]:
        """
        The cassandra connector offer type for the Cosmos DB database C* account.
        """
        return pulumi.get(self, "connector_offer")

    @property
    @pulumi.getter(name="consistencyPolicy")
    def consistency_policy(self) -> Optional['outputs.ConsistencyPolicyResponse']:
        """
        The consistency policy for the Cosmos DB database account.
        """
        return pulumi.get(self, "consistency_policy")

    @property
    @pulumi.getter
    def cors(self) -> Optional[Sequence['outputs.CorsPolicyResponse']]:
        """
        The CORS policy for the Cosmos DB database account.
        """
        return pulumi.get(self, "cors")

    @property
    @pulumi.getter(name="databaseAccountOfferType")
    def database_account_offer_type(self) -> str:
        """
        The offer type for the Cosmos DB database account. Default value: Standard.
        """
        return pulumi.get(self, "database_account_offer_type")

    @property
    @pulumi.getter(name="defaultIdentity")
    def default_identity(self) -> Optional[str]:
        """
        The default identity for accessing key vault used in features like customer managed keys. The default identity needs to be explicitly set by the users. It can be "FirstPartyIdentity", "SystemAssignedIdentity" and more.
        """
        return pulumi.get(self, "default_identity")

    @property
    @pulumi.getter(name="disableKeyBasedMetadataWriteAccess")
    def disable_key_based_metadata_write_access(self) -> Optional[bool]:
        """
        Disable write operations on metadata resources (databases, containers, throughput) via account keys
        """
        return pulumi.get(self, "disable_key_based_metadata_write_access")

    @property
    @pulumi.getter(name="documentEndpoint")
    def document_endpoint(self) -> str:
        """
        The connection endpoint for the Cosmos DB database account.
        """
        return pulumi.get(self, "document_endpoint")

    @property
    @pulumi.getter(name="enableAnalyticalStorage")
    def enable_analytical_storage(self) -> Optional[bool]:
        """
        Flag to indicate whether to enable storage analytics.
        """
        return pulumi.get(self, "enable_analytical_storage")

    @property
    @pulumi.getter(name="enableAutomaticFailover")
    def enable_automatic_failover(self) -> Optional[bool]:
        """
        Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.
        """
        return pulumi.get(self, "enable_automatic_failover")

    @property
    @pulumi.getter(name="enableCassandraConnector")
    def enable_cassandra_connector(self) -> Optional[bool]:
        """
        Enables the cassandra connector on the Cosmos DB C* account
        """
        return pulumi.get(self, "enable_cassandra_connector")

    @property
    @pulumi.getter(name="enableFreeTier")
    def enable_free_tier(self) -> Optional[bool]:
        """
        Flag to indicate whether Free Tier is enabled.
        """
        return pulumi.get(self, "enable_free_tier")

    @property
    @pulumi.getter(name="enableMultipleWriteLocations")
    def enable_multiple_write_locations(self) -> Optional[bool]:
        """
        Enables the account to write in multiple locations
        """
        return pulumi.get(self, "enable_multiple_write_locations")

    @property
    @pulumi.getter(name="failoverPolicies")
    def failover_policies(self) -> Sequence['outputs.FailoverPolicyResponse']:
        """
        An array that contains the regions ordered by their failover priorities.
        """
        return pulumi.get(self, "failover_policies")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The unique resource identifier of the ARM resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def identity(self) -> Optional['outputs.ManagedServiceIdentityResponse']:
        """
        Identity for the resource.
        """
        return pulumi.get(self, "identity")

    @property
    @pulumi.getter(name="ipRules")
    def ip_rules(self) -> Optional[Sequence['outputs.IpAddressOrRangeResponse']]:
        """
        List of IpRules.
        """
        return pulumi.get(self, "ip_rules")

    @property
    @pulumi.getter(name="isVirtualNetworkFilterEnabled")
    def is_virtual_network_filter_enabled(self) -> Optional[bool]:
        """
        Flag to indicate whether to enable/disable Virtual Network ACL rules.
        """
        return pulumi.get(self, "is_virtual_network_filter_enabled")

    @property
    @pulumi.getter(name="keyVaultKeyUri")
    def key_vault_key_uri(self) -> Optional[str]:
        """
        The URI of the key vault
        """
        return pulumi.get(self, "key_vault_key_uri")

    @property
    @pulumi.getter
    def kind(self) -> Optional[str]:
        """
        Indicates the type of database account. This can only be set at database account creation.
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def location(self) -> Optional[str]:
        """
        The location of the resource group to which the resource belongs.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def locations(self) -> Sequence['outputs.LocationResponse']:
        """
        An array that contains all of the locations enabled for the Cosmos DB account.
        """
        return pulumi.get(self, "locations")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the ARM resource.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkAclBypass")
    def network_acl_bypass(self) -> Optional[str]:
        """
        Indicates what services are allowed to bypass firewall checks.
        """
        return pulumi.get(self, "network_acl_bypass")

    @property
    @pulumi.getter(name="networkAclBypassResourceIds")
    def network_acl_bypass_resource_ids(self) -> Optional[Sequence[str]]:
        """
        An array that contains the Resource Ids for Network Acl Bypass for the Cosmos DB account.
        """
        return pulumi.get(self, "network_acl_bypass_resource_ids")

    @property
    @pulumi.getter(name="privateEndpointConnections")
    def private_endpoint_connections(self) -> Sequence['outputs.PrivateEndpointConnectionResponse']:
        """
        List of Private Endpoint Connections configured for the Cosmos DB account.
        """
        return pulumi.get(self, "private_endpoint_connections")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> str:
        """
        The status of the Cosmos DB account at the time the operation was called. The status can be one of following. 'Creating' – the Cosmos DB account is being created. When an account is in Creating state, only properties that are specified as input for the Create Cosmos DB account operation are returned. 'Succeeded' – the Cosmos DB account is active for use. 'Updating' – the Cosmos DB account is being updated. 'Deleting' – the Cosmos DB account is being deleted. 'Failed' – the Cosmos DB account failed creation. 'DeletionFailed' – the Cosmos DB account deletion failed.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="publicNetworkAccess")
    def public_network_access(self) -> Optional[str]:
        """
        Whether requests from Public Network are allowed
        """
        return pulumi.get(self, "public_network_access")

    @property
    @pulumi.getter(name="readLocations")
    def read_locations(self) -> Sequence['outputs.LocationResponse']:
        """
        An array that contains of the read locations enabled for the Cosmos DB account.
        """
        return pulumi.get(self, "read_locations")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        """
        Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of Azure resource.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="virtualNetworkRules")
    def virtual_network_rules(self) -> Optional[Sequence['outputs.VirtualNetworkRuleResponse']]:
        """
        List of Virtual Network ACL rules configured for the Cosmos DB account.
        """
        return pulumi.get(self, "virtual_network_rules")

    @property
    @pulumi.getter(name="writeLocations")
    def write_locations(self) -> Sequence['outputs.LocationResponse']:
        """
        An array that contains the write location for the Cosmos DB account.
        """
        return pulumi.get(self, "write_locations")


class AwaitableGetDatabaseAccountResult(GetDatabaseAccountResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDatabaseAccountResult(
            analytical_storage_configuration=self.analytical_storage_configuration,
            api_properties=self.api_properties,
            backup_policy=self.backup_policy,
            capabilities=self.capabilities,
            connector_offer=self.connector_offer,
            consistency_policy=self.consistency_policy,
            cors=self.cors,
            database_account_offer_type=self.database_account_offer_type,
            default_identity=self.default_identity,
            disable_key_based_metadata_write_access=self.disable_key_based_metadata_write_access,
            document_endpoint=self.document_endpoint,
            enable_analytical_storage=self.enable_analytical_storage,
            enable_automatic_failover=self.enable_automatic_failover,
            enable_cassandra_connector=self.enable_cassandra_connector,
            enable_free_tier=self.enable_free_tier,
            enable_multiple_write_locations=self.enable_multiple_write_locations,
            failover_policies=self.failover_policies,
            id=self.id,
            identity=self.identity,
            ip_rules=self.ip_rules,
            is_virtual_network_filter_enabled=self.is_virtual_network_filter_enabled,
            key_vault_key_uri=self.key_vault_key_uri,
            kind=self.kind,
            location=self.location,
            locations=self.locations,
            name=self.name,
            network_acl_bypass=self.network_acl_bypass,
            network_acl_bypass_resource_ids=self.network_acl_bypass_resource_ids,
            private_endpoint_connections=self.private_endpoint_connections,
            provisioning_state=self.provisioning_state,
            public_network_access=self.public_network_access,
            read_locations=self.read_locations,
            tags=self.tags,
            type=self.type,
            virtual_network_rules=self.virtual_network_rules,
            write_locations=self.write_locations)


def get_database_account(account_name: Optional[str] = None,
                         resource_group_name: Optional[str] = None,
                         opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDatabaseAccountResult:
    """
    An Azure Cosmos DB database account.


    :param str account_name: Cosmos DB database account name.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    """
    __args__ = dict()
    __args__['accountName'] = account_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure-native:documentdb/v20210515:getDatabaseAccount', __args__, opts=opts, typ=GetDatabaseAccountResult).value

    return AwaitableGetDatabaseAccountResult(
        analytical_storage_configuration=__ret__.analytical_storage_configuration,
        api_properties=__ret__.api_properties,
        backup_policy=__ret__.backup_policy,
        capabilities=__ret__.capabilities,
        connector_offer=__ret__.connector_offer,
        consistency_policy=__ret__.consistency_policy,
        cors=__ret__.cors,
        database_account_offer_type=__ret__.database_account_offer_type,
        default_identity=__ret__.default_identity,
        disable_key_based_metadata_write_access=__ret__.disable_key_based_metadata_write_access,
        document_endpoint=__ret__.document_endpoint,
        enable_analytical_storage=__ret__.enable_analytical_storage,
        enable_automatic_failover=__ret__.enable_automatic_failover,
        enable_cassandra_connector=__ret__.enable_cassandra_connector,
        enable_free_tier=__ret__.enable_free_tier,
        enable_multiple_write_locations=__ret__.enable_multiple_write_locations,
        failover_policies=__ret__.failover_policies,
        id=__ret__.id,
        identity=__ret__.identity,
        ip_rules=__ret__.ip_rules,
        is_virtual_network_filter_enabled=__ret__.is_virtual_network_filter_enabled,
        key_vault_key_uri=__ret__.key_vault_key_uri,
        kind=__ret__.kind,
        location=__ret__.location,
        locations=__ret__.locations,
        name=__ret__.name,
        network_acl_bypass=__ret__.network_acl_bypass,
        network_acl_bypass_resource_ids=__ret__.network_acl_bypass_resource_ids,
        private_endpoint_connections=__ret__.private_endpoint_connections,
        provisioning_state=__ret__.provisioning_state,
        public_network_access=__ret__.public_network_access,
        read_locations=__ret__.read_locations,
        tags=__ret__.tags,
        type=__ret__.type,
        virtual_network_rules=__ret__.virtual_network_rules,
        write_locations=__ret__.write_locations)


@_utilities.lift_output_func(get_database_account)
def get_database_account_output(account_name: Optional[pulumi.Input[str]] = None,
                                resource_group_name: Optional[pulumi.Input[str]] = None,
                                opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetDatabaseAccountResult]:
    """
    An Azure Cosmos DB database account.


    :param str account_name: Cosmos DB database account name.
    :param str resource_group_name: The name of the resource group. The name is case insensitive.
    """
    ...
