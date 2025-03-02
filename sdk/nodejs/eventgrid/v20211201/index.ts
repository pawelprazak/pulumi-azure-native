// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./domain";
export * from "./domainTopic";
export * from "./eventSubscription";
export * from "./getDomain";
export * from "./getDomainTopic";
export * from "./getEventSubscription";
export * from "./getEventSubscriptionDeliveryAttributes";
export * from "./getEventSubscriptionFullUrl";
export * from "./getPrivateEndpointConnection";
export * from "./getSystemTopic";
export * from "./getSystemTopicEventSubscription";
export * from "./getSystemTopicEventSubscriptionDeliveryAttributes";
export * from "./getSystemTopicEventSubscriptionFullUrl";
export * from "./getTopic";
export * from "./listDomainSharedAccessKeys";
export * from "./listTopicSharedAccessKeys";
export * from "./privateEndpointConnection";
export * from "./systemTopic";
export * from "./systemTopicEventSubscription";
export * from "./topic";

// Export enums:
export * from "../../types/enums/eventgrid/v20211201";

// Import resources to register:
import { Domain } from "./domain";
import { DomainTopic } from "./domainTopic";
import { EventSubscription } from "./eventSubscription";
import { PrivateEndpointConnection } from "./privateEndpointConnection";
import { SystemTopic } from "./systemTopic";
import { SystemTopicEventSubscription } from "./systemTopicEventSubscription";
import { Topic } from "./topic";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:eventgrid/v20211201:Domain":
                return new Domain(name, <any>undefined, { urn })
            case "azure-native:eventgrid/v20211201:DomainTopic":
                return new DomainTopic(name, <any>undefined, { urn })
            case "azure-native:eventgrid/v20211201:EventSubscription":
                return new EventSubscription(name, <any>undefined, { urn })
            case "azure-native:eventgrid/v20211201:PrivateEndpointConnection":
                return new PrivateEndpointConnection(name, <any>undefined, { urn })
            case "azure-native:eventgrid/v20211201:SystemTopic":
                return new SystemTopic(name, <any>undefined, { urn })
            case "azure-native:eventgrid/v20211201:SystemTopicEventSubscription":
                return new SystemTopicEventSubscription(name, <any>undefined, { urn })
            case "azure-native:eventgrid/v20211201:Topic":
                return new Topic(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "eventgrid/v20211201", _module)
