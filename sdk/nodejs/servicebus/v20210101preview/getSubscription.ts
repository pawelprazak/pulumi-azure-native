// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Description of subscription resource.
 */
export function getSubscription(args: GetSubscriptionArgs, opts?: pulumi.InvokeOptions): Promise<GetSubscriptionResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:servicebus/v20210101preview:getSubscription", {
        "namespaceName": args.namespaceName,
        "resourceGroupName": args.resourceGroupName,
        "subscriptionName": args.subscriptionName,
        "topicName": args.topicName,
    }, opts);
}

export interface GetSubscriptionArgs {
    /**
     * The namespace name
     */
    namespaceName: string;
    /**
     * Name of the Resource group within the Azure subscription.
     */
    resourceGroupName: string;
    /**
     * The subscription name.
     */
    subscriptionName: string;
    /**
     * The topic name.
     */
    topicName: string;
}

/**
 * Description of subscription resource.
 */
export interface GetSubscriptionResult {
    /**
     * Last time there was a receive request to this subscription.
     */
    readonly accessedAt: string;
    /**
     * ISO 8061 timeSpan idle interval after which the topic is automatically deleted. The minimum duration is 5 minutes.
     */
    readonly autoDeleteOnIdle?: string;
    /**
     * Message count details
     */
    readonly countDetails: outputs.servicebus.v20210101preview.MessageCountDetailsResponse;
    /**
     * Exact time the message was created.
     */
    readonly createdAt: string;
    /**
     * Value that indicates whether a subscription has dead letter support on filter evaluation exceptions.
     */
    readonly deadLetteringOnFilterEvaluationExceptions?: boolean;
    /**
     * Value that indicates whether a subscription has dead letter support when a message expires.
     */
    readonly deadLetteringOnMessageExpiration?: boolean;
    /**
     * ISO 8061 Default message timespan to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself.
     */
    readonly defaultMessageTimeToLive?: string;
    /**
     * ISO 8601 timeSpan structure that defines the duration of the duplicate detection history. The default value is 10 minutes.
     */
    readonly duplicateDetectionHistoryTimeWindow?: string;
    /**
     * Value that indicates whether server-side batched operations are enabled.
     */
    readonly enableBatchedOperations?: boolean;
    /**
     * Queue/Topic name to forward the Dead Letter message
     */
    readonly forwardDeadLetteredMessagesTo?: string;
    /**
     * Queue/Topic name to forward the messages
     */
    readonly forwardTo?: string;
    /**
     * Resource Id
     */
    readonly id: string;
    /**
     * ISO 8061 lock duration timespan for the subscription. The default value is 1 minute.
     */
    readonly lockDuration?: string;
    /**
     * Number of maximum deliveries.
     */
    readonly maxDeliveryCount?: number;
    /**
     * Number of messages.
     */
    readonly messageCount: number;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Value indicating if a subscription supports the concept of sessions.
     */
    readonly requiresSession?: boolean;
    /**
     * Enumerates the possible values for the status of a messaging entity.
     */
    readonly status?: string;
    /**
     * The system meta data relating to this resource.
     */
    readonly systemData: outputs.servicebus.v20210101preview.SystemDataResponse;
    /**
     * Resource type
     */
    readonly type: string;
    /**
     * The exact time the message was updated.
     */
    readonly updatedAt: string;
}

export function getSubscriptionOutput(args: GetSubscriptionOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSubscriptionResult> {
    return pulumi.output(args).apply(a => getSubscription(a, opts))
}

export interface GetSubscriptionOutputArgs {
    /**
     * The namespace name
     */
    namespaceName: pulumi.Input<string>;
    /**
     * Name of the Resource group within the Azure subscription.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The subscription name.
     */
    subscriptionName: pulumi.Input<string>;
    /**
     * The topic name.
     */
    topicName: pulumi.Input<string>;
}
