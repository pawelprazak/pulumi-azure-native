// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Collection of domain name identifiers.
 */
export function listDomainRecommendations(args?: ListDomainRecommendationsArgs, opts?: pulumi.InvokeOptions): Promise<ListDomainRecommendationsResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:domainregistration/v20220301:listDomainRecommendations", {
        "keywords": args.keywords,
        "maxDomainRecommendations": args.maxDomainRecommendations,
    }, opts);
}

export interface ListDomainRecommendationsArgs {
    /**
     * Keywords to be used for generating domain recommendations.
     */
    keywords?: string;
    /**
     * Maximum number of recommendations.
     */
    maxDomainRecommendations?: number;
}

/**
 * Collection of domain name identifiers.
 */
export interface ListDomainRecommendationsResult {
    /**
     * Link to next page of resources.
     */
    readonly nextLink: string;
    /**
     * Collection of resources.
     */
    readonly value: outputs.domainregistration.v20220301.NameIdentifierResponse[];
}

export function listDomainRecommendationsOutput(args?: ListDomainRecommendationsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListDomainRecommendationsResult> {
    return pulumi.output(args).apply(a => listDomainRecommendations(a, opts))
}

export interface ListDomainRecommendationsOutputArgs {
    /**
     * Keywords to be used for generating domain recommendations.
     */
    keywords?: pulumi.Input<string>;
    /**
     * Maximum number of recommendations.
     */
    maxDomainRecommendations?: pulumi.Input<number>;
}
