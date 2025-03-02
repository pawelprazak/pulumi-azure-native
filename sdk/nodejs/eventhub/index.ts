// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./applicationGroup";
export * from "./cluster";
export * from "./consumerGroup";
export * from "./disasterRecoveryConfig";
export * from "./eventHub";
export * from "./eventHubAuthorizationRule";
export * from "./getApplicationGroup";
export * from "./getCluster";
export * from "./getConsumerGroup";
export * from "./getDisasterRecoveryConfig";
export * from "./getEventHub";
export * from "./getEventHubAuthorizationRule";
export * from "./getNamespace";
export * from "./getNamespaceAuthorizationRule";
export * from "./getNamespaceIpFilterRule";
export * from "./getNamespaceNetworkRuleSet";
export * from "./getNamespaceVirtualNetworkRule";
export * from "./getPrivateEndpointConnection";
export * from "./getSchemaRegistry";
export * from "./listDisasterRecoveryConfigKeys";
export * from "./listEventHubKeys";
export * from "./listNamespaceKeys";
export * from "./namespace";
export * from "./namespaceAuthorizationRule";
export * from "./namespaceIpFilterRule";
export * from "./namespaceNetworkRuleSet";
export * from "./namespaceVirtualNetworkRule";
export * from "./privateEndpointConnection";
export * from "./schemaRegistry";

// Export enums:
export * from "../types/enums/eventhub";

// Export sub-modules:
import * as v20140901 from "./v20140901";
import * as v20150801 from "./v20150801";
import * as v20170401 from "./v20170401";
import * as v20180101preview from "./v20180101preview";
import * as v20210101preview from "./v20210101preview";
import * as v20210601preview from "./v20210601preview";
import * as v20211101 from "./v20211101";
import * as v20220101preview from "./v20220101preview";

export {
    v20140901,
    v20150801,
    v20170401,
    v20180101preview,
    v20210101preview,
    v20210601preview,
    v20211101,
    v20220101preview,
};

// Import resources to register:
import { ApplicationGroup } from "./applicationGroup";
import { Cluster } from "./cluster";
import { ConsumerGroup } from "./consumerGroup";
import { DisasterRecoveryConfig } from "./disasterRecoveryConfig";
import { EventHub } from "./eventHub";
import { EventHubAuthorizationRule } from "./eventHubAuthorizationRule";
import { Namespace } from "./namespace";
import { NamespaceAuthorizationRule } from "./namespaceAuthorizationRule";
import { NamespaceIpFilterRule } from "./namespaceIpFilterRule";
import { NamespaceNetworkRuleSet } from "./namespaceNetworkRuleSet";
import { NamespaceVirtualNetworkRule } from "./namespaceVirtualNetworkRule";
import { PrivateEndpointConnection } from "./privateEndpointConnection";
import { SchemaRegistry } from "./schemaRegistry";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:eventhub:ApplicationGroup":
                return new ApplicationGroup(name, <any>undefined, { urn })
            case "azure-native:eventhub:Cluster":
                return new Cluster(name, <any>undefined, { urn })
            case "azure-native:eventhub:ConsumerGroup":
                return new ConsumerGroup(name, <any>undefined, { urn })
            case "azure-native:eventhub:DisasterRecoveryConfig":
                return new DisasterRecoveryConfig(name, <any>undefined, { urn })
            case "azure-native:eventhub:EventHub":
                return new EventHub(name, <any>undefined, { urn })
            case "azure-native:eventhub:EventHubAuthorizationRule":
                return new EventHubAuthorizationRule(name, <any>undefined, { urn })
            case "azure-native:eventhub:Namespace":
                return new Namespace(name, <any>undefined, { urn })
            case "azure-native:eventhub:NamespaceAuthorizationRule":
                return new NamespaceAuthorizationRule(name, <any>undefined, { urn })
            case "azure-native:eventhub:NamespaceIpFilterRule":
                return new NamespaceIpFilterRule(name, <any>undefined, { urn })
            case "azure-native:eventhub:NamespaceNetworkRuleSet":
                return new NamespaceNetworkRuleSet(name, <any>undefined, { urn })
            case "azure-native:eventhub:NamespaceVirtualNetworkRule":
                return new NamespaceVirtualNetworkRule(name, <any>undefined, { urn })
            case "azure-native:eventhub:PrivateEndpointConnection":
                return new PrivateEndpointConnection(name, <any>undefined, { urn })
            case "azure-native:eventhub:SchemaRegistry":
                return new SchemaRegistry(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "eventhub", _module)
