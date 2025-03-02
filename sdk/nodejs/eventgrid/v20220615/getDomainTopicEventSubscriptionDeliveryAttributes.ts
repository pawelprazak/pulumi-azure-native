// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Result of the Get delivery attributes operation.
 */
export function getDomainTopicEventSubscriptionDeliveryAttributes(args: GetDomainTopicEventSubscriptionDeliveryAttributesArgs, opts?: pulumi.InvokeOptions): Promise<GetDomainTopicEventSubscriptionDeliveryAttributesResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:eventgrid/v20220615:getDomainTopicEventSubscriptionDeliveryAttributes", {
        "domainName": args.domainName,
        "eventSubscriptionName": args.eventSubscriptionName,
        "resourceGroupName": args.resourceGroupName,
        "topicName": args.topicName,
    }, opts);
}

export interface GetDomainTopicEventSubscriptionDeliveryAttributesArgs {
    /**
     * Name of the top level domain.
     */
    domainName: string;
    /**
     * Name of the event subscription.
     */
    eventSubscriptionName: string;
    /**
     * The name of the resource group within the user's subscription.
     */
    resourceGroupName: string;
    /**
     * Name of the domain topic.
     */
    topicName: string;
}

/**
 * Result of the Get delivery attributes operation.
 */
export interface GetDomainTopicEventSubscriptionDeliveryAttributesResult {
    /**
     * A collection of DeliveryAttributeMapping
     */
    readonly value?: (outputs.eventgrid.v20220615.DynamicDeliveryAttributeMappingResponse | outputs.eventgrid.v20220615.StaticDeliveryAttributeMappingResponse)[];
}

export function getDomainTopicEventSubscriptionDeliveryAttributesOutput(args: GetDomainTopicEventSubscriptionDeliveryAttributesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDomainTopicEventSubscriptionDeliveryAttributesResult> {
    return pulumi.output(args).apply(a => getDomainTopicEventSubscriptionDeliveryAttributes(a, opts))
}

export interface GetDomainTopicEventSubscriptionDeliveryAttributesOutputArgs {
    /**
     * Name of the top level domain.
     */
    domainName: pulumi.Input<string>;
    /**
     * Name of the event subscription.
     */
    eventSubscriptionName: pulumi.Input<string>;
    /**
     * The name of the resource group within the user's subscription.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Name of the domain topic.
     */
    topicName: pulumi.Input<string>;
}
