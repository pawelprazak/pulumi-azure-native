// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * NetworkSecurityGroup resource
 */
/** @deprecated Version 2015-05-01-preview will be removed in v2 of the provider. */
export function getNetworkSecurityGroup(args: GetNetworkSecurityGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetNetworkSecurityGroupResult> {
    pulumi.log.warn("getNetworkSecurityGroup is deprecated: Version 2015-05-01-preview will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:network/v20150501preview:getNetworkSecurityGroup", {
        "networkSecurityGroupName": args.networkSecurityGroupName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetNetworkSecurityGroupArgs {
    /**
     * The name of the network security group.
     */
    networkSecurityGroupName: string;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
}

/**
 * NetworkSecurityGroup resource
 */
export interface GetNetworkSecurityGroupResult {
    /**
     * Gets or sets Default security rules of network security group
     */
    readonly defaultSecurityRules?: outputs.network.v20150501preview.SecurityRuleResponse[];
    /**
     * Gets a unique read-only string that changes whenever the resource is updated
     */
    readonly etag?: string;
    /**
     * Resource Id
     */
    readonly id: string;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Gets collection of references to Network Interfaces
     */
    readonly networkInterfaces?: outputs.network.v20150501preview.SubResourceResponse[];
    /**
     * Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
     */
    readonly provisioningState?: string;
    /**
     * Gets or sets resource guid property of the network security group resource
     */
    readonly resourceGuid?: string;
    /**
     * Gets or sets Security rules of network security group
     */
    readonly securityRules?: outputs.network.v20150501preview.SecurityRuleResponse[];
    /**
     * Gets collection of references to subnets
     */
    readonly subnets?: outputs.network.v20150501preview.SubResourceResponse[];
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type: string;
}

export function getNetworkSecurityGroupOutput(args: GetNetworkSecurityGroupOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetNetworkSecurityGroupResult> {
    return pulumi.output(args).apply(a => getNetworkSecurityGroup(a, opts))
}

export interface GetNetworkSecurityGroupOutputArgs {
    /**
     * The name of the network security group.
     */
    networkSecurityGroupName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
}
