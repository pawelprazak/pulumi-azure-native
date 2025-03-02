// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Description of NetworkRuleSet resource.
 */
export function getNamespaceNetworkRuleSet(args: GetNamespaceNetworkRuleSetArgs, opts?: pulumi.InvokeOptions): Promise<GetNamespaceNetworkRuleSetResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:servicebus/v20180101preview:getNamespaceNetworkRuleSet", {
        "namespaceName": args.namespaceName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetNamespaceNetworkRuleSetArgs {
    /**
     * The namespace name
     */
    namespaceName: string;
    /**
     * Name of the Resource group within the Azure subscription.
     */
    resourceGroupName: string;
}

/**
 * Description of NetworkRuleSet resource.
 */
export interface GetNamespaceNetworkRuleSetResult {
    /**
     * Default Action for Network Rule Set
     */
    readonly defaultAction?: string;
    /**
     * Resource Id
     */
    readonly id: string;
    /**
     * List of IpRules
     */
    readonly ipRules?: outputs.servicebus.v20180101preview.NWRuleSetIpRulesResponse[];
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Resource type
     */
    readonly type: string;
    /**
     * List VirtualNetwork Rules
     */
    readonly virtualNetworkRules?: outputs.servicebus.v20180101preview.NWRuleSetVirtualNetworkRulesResponse[];
}

export function getNamespaceNetworkRuleSetOutput(args: GetNamespaceNetworkRuleSetOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetNamespaceNetworkRuleSetResult> {
    return pulumi.output(args).apply(a => getNamespaceNetworkRuleSet(a, opts))
}

export interface GetNamespaceNetworkRuleSetOutputArgs {
    /**
     * The namespace name
     */
    namespaceName: pulumi.Input<string>;
    /**
     * Name of the Resource group within the Azure subscription.
     */
    resourceGroupName: pulumi.Input<string>;
}
