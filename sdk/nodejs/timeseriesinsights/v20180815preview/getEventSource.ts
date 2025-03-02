// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * An environment receives data from one or more event sources. Each event source has associated connection info that allows the Time Series Insights ingress pipeline to connect to and pull data from the event source
 */
/** @deprecated Version 2018-08-15-preview will be removed in v2 of the provider. */
export function getEventSource(args: GetEventSourceArgs, opts?: pulumi.InvokeOptions): Promise<GetEventSourceResult> {
    pulumi.log.warn("getEventSource is deprecated: Version 2018-08-15-preview will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:timeseriesinsights/v20180815preview:getEventSource", {
        "environmentName": args.environmentName,
        "eventSourceName": args.eventSourceName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetEventSourceArgs {
    /**
     * The name of the Time Series Insights environment associated with the specified resource group.
     */
    environmentName: string;
    /**
     * The name of the Time Series Insights event source associated with the specified environment.
     */
    eventSourceName: string;
    /**
     * Name of an Azure Resource group.
     */
    resourceGroupName: string;
}

/**
 * An environment receives data from one or more event sources. Each event source has associated connection info that allows the Time Series Insights ingress pipeline to connect to and pull data from the event source
 */
export interface GetEventSourceResult {
    /**
     * Resource Id
     */
    readonly id: string;
    /**
     * The kind of the event source.
     */
    readonly kind: string;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type: string;
}

export function getEventSourceOutput(args: GetEventSourceOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetEventSourceResult> {
    return pulumi.output(args).apply(a => getEventSource(a, opts))
}

export interface GetEventSourceOutputArgs {
    /**
     * The name of the Time Series Insights environment associated with the specified resource group.
     */
    environmentName: pulumi.Input<string>;
    /**
     * The name of the Time Series Insights event source associated with the specified environment.
     */
    eventSourceName: pulumi.Input<string>;
    /**
     * Name of an Azure Resource group.
     */
    resourceGroupName: pulumi.Input<string>;
}
