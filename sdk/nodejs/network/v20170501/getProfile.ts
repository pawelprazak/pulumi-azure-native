// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Class representing a Traffic Manager profile.
 */
/** @deprecated Version 2017-05-01 will be removed in v2 of the provider. */
export function getProfile(args: GetProfileArgs, opts?: pulumi.InvokeOptions): Promise<GetProfileResult> {
    pulumi.log.warn("getProfile is deprecated: Version 2017-05-01 will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:network/v20170501:getProfile", {
        "profileName": args.profileName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetProfileArgs {
    /**
     * The name of the Traffic Manager profile.
     */
    profileName: string;
    /**
     * The name of the resource group containing the Traffic Manager profile.
     */
    resourceGroupName: string;
}

/**
 * Class representing a Traffic Manager profile.
 */
export interface GetProfileResult {
    /**
     * The DNS settings of the Traffic Manager profile.
     */
    readonly dnsConfig?: outputs.network.v20170501.DnsConfigResponse;
    /**
     * The list of endpoints in the Traffic Manager profile.
     */
    readonly endpoints?: outputs.network.v20170501.EndpointResponse[];
    /**
     * Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{resourceName}
     */
    readonly id: string;
    /**
     * The Azure Region where the resource lives
     */
    readonly location?: string;
    /**
     * The endpoint monitoring settings of the Traffic Manager profile.
     */
    readonly monitorConfig?: outputs.network.v20170501.MonitorConfigResponse;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The status of the Traffic Manager profile.
     */
    readonly profileStatus?: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The traffic routing method of the Traffic Manager profile.
     */
    readonly trafficRoutingMethod?: string;
    /**
     * The type of the resource. Ex- Microsoft.Network/trafficManagerProfiles.
     */
    readonly type: string;
}

export function getProfileOutput(args: GetProfileOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetProfileResult> {
    return pulumi.output(args).apply(a => getProfile(a, opts))
}

export interface GetProfileOutputArgs {
    /**
     * The name of the Traffic Manager profile.
     */
    profileName: pulumi.Input<string>;
    /**
     * The name of the resource group containing the Traffic Manager profile.
     */
    resourceGroupName: pulumi.Input<string>;
}
