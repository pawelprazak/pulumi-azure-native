// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * VpnServerConfigurationPolicyGroup Resource.
 */
export function getConfigurationPolicyGroup(args: GetConfigurationPolicyGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetConfigurationPolicyGroupResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:network/v20210801:getConfigurationPolicyGroup", {
        "configurationPolicyGroupName": args.configurationPolicyGroupName,
        "resourceGroupName": args.resourceGroupName,
        "vpnServerConfigurationName": args.vpnServerConfigurationName,
    }, opts);
}

export interface GetConfigurationPolicyGroupArgs {
    /**
     * The name of the ConfigurationPolicyGroup being retrieved.
     */
    configurationPolicyGroupName: string;
    /**
     * The resource group name of the VpnServerConfiguration.
     */
    resourceGroupName: string;
    /**
     * The name of the VpnServerConfiguration.
     */
    vpnServerConfigurationName: string;
}

/**
 * VpnServerConfigurationPolicyGroup Resource.
 */
export interface GetConfigurationPolicyGroupResult {
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * Resource ID.
     */
    readonly id?: string;
    /**
     * Shows if this is a Default VpnServerConfigurationPolicyGroup or not.
     */
    readonly isDefault?: boolean;
    /**
     * The name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    readonly name?: string;
    /**
     * List of references to P2SConnectionConfigurations.
     */
    readonly p2SConnectionConfigurations: outputs.network.v20210801.SubResourceResponse[];
    /**
     * Multiple PolicyMembers for VpnServerConfigurationPolicyGroup.
     */
    readonly policyMembers?: outputs.network.v20210801.VpnServerConfigurationPolicyGroupMemberResponse[];
    /**
     * Priority for VpnServerConfigurationPolicyGroup.
     */
    readonly priority?: number;
    /**
     * The provisioning state of the VpnServerConfigurationPolicyGroup resource.
     */
    readonly provisioningState: string;
    /**
     * Resource type.
     */
    readonly type: string;
}

export function getConfigurationPolicyGroupOutput(args: GetConfigurationPolicyGroupOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetConfigurationPolicyGroupResult> {
    return pulumi.output(args).apply(a => getConfigurationPolicyGroup(a, opts))
}

export interface GetConfigurationPolicyGroupOutputArgs {
    /**
     * The name of the ConfigurationPolicyGroup being retrieved.
     */
    configurationPolicyGroupName: pulumi.Input<string>;
    /**
     * The resource group name of the VpnServerConfiguration.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the VpnServerConfiguration.
     */
    vpnServerConfigurationName: pulumi.Input<string>;
}
