// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Describes a DNS forwarding ruleset.
 */
export function getDnsForwardingRuleset(args: GetDnsForwardingRulesetArgs, opts?: pulumi.InvokeOptions): Promise<GetDnsForwardingRulesetResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:network/v20200401preview:getDnsForwardingRuleset", {
        "dnsForwardingRulesetName": args.dnsForwardingRulesetName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetDnsForwardingRulesetArgs {
    /**
     * The name of the DNS forwarding ruleset.
     */
    dnsForwardingRulesetName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
}

/**
 * Describes a DNS forwarding ruleset.
 */
export interface GetDnsForwardingRulesetResult {
    /**
     * The reference to the DNS resolver outbound endpoints that are used to route DNS queries matching the forwarding rules in the ruleset to the target DNS servers.
     */
    readonly dnsResolverOutboundEndpoints?: outputs.network.v20200401preview.SubResourceResponse[];
    /**
     * ETag of the DNS forwarding ruleset.
     */
    readonly etag: string;
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The current provisioning state of the DNS forwarding ruleset. This is a read-only property and any attempt to set this value will be ignored.
     */
    readonly provisioningState: string;
    /**
     * The resourceGuid for the DNS forwarding ruleset.
     */
    readonly resourceGuid: string;
    /**
     * Metadata pertaining to creation and last modification of the resource.
     */
    readonly systemData: outputs.network.v20200401preview.SystemDataResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}

export function getDnsForwardingRulesetOutput(args: GetDnsForwardingRulesetOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDnsForwardingRulesetResult> {
    return pulumi.output(args).apply(a => getDnsForwardingRuleset(a, opts))
}

export interface GetDnsForwardingRulesetOutputArgs {
    /**
     * The name of the DNS forwarding ruleset.
     */
    dnsForwardingRulesetName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
}
