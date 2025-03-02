// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * The list of configurations.
 */
export function listConfigurations(args: ListConfigurationsArgs, opts?: pulumi.InvokeOptions): Promise<ListConfigurationsResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:edgeorder/v20211201:listConfigurations", {
        "configurationFilters": args.configurationFilters,
        "customerSubscriptionDetails": args.customerSubscriptionDetails,
        "skipToken": args.skipToken,
    }, opts);
}

export interface ListConfigurationsArgs {
    /**
     * Holds details about product hierarchy information and filterable property.
     */
    configurationFilters: inputs.edgeorder.v20211201.ConfigurationFilters[];
    /**
     * Customer subscription properties. Clients can display available products to unregistered customers by explicitly passing subscription details
     */
    customerSubscriptionDetails?: inputs.edgeorder.v20211201.CustomerSubscriptionDetails;
    /**
     * $skipToken is supported on list of configurations, which provides the next page in the list of configurations.
     */
    skipToken?: string;
}

/**
 * The list of configurations.
 */
export interface ListConfigurationsResult {
    /**
     * Link for the next set of configurations.
     */
    readonly nextLink?: string;
    /**
     * List of configurations.
     */
    readonly value: outputs.edgeorder.v20211201.ConfigurationResponse[];
}

export function listConfigurationsOutput(args: ListConfigurationsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListConfigurationsResult> {
    return pulumi.output(args).apply(a => listConfigurations(a, opts))
}

export interface ListConfigurationsOutputArgs {
    /**
     * Holds details about product hierarchy information and filterable property.
     */
    configurationFilters: pulumi.Input<pulumi.Input<inputs.edgeorder.v20211201.ConfigurationFiltersArgs>[]>;
    /**
     * Customer subscription properties. Clients can display available products to unregistered customers by explicitly passing subscription details
     */
    customerSubscriptionDetails?: pulumi.Input<inputs.edgeorder.v20211201.CustomerSubscriptionDetailsArgs>;
    /**
     * $skipToken is supported on list of configurations, which provides the next page in the list of configurations.
     */
    skipToken?: pulumi.Input<string>;
}
