// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Service End point policy resource.
 */
export function getServiceEndpointPolicy(args: GetServiceEndpointPolicyArgs, opts?: pulumi.InvokeOptions): Promise<GetServiceEndpointPolicyResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:network/v20200301:getServiceEndpointPolicy", {
        "expand": args.expand,
        "resourceGroupName": args.resourceGroupName,
        "serviceEndpointPolicyName": args.serviceEndpointPolicyName,
    }, opts);
}

export interface GetServiceEndpointPolicyArgs {
    /**
     * Expands referenced resources.
     */
    expand?: string;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
    /**
     * The name of the service endpoint policy.
     */
    serviceEndpointPolicyName: string;
}

/**
 * Service End point policy resource.
 */
export interface GetServiceEndpointPolicyResult {
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * Resource ID.
     */
    readonly id?: string;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The provisioning state of the service endpoint policy resource.
     */
    readonly provisioningState: string;
    /**
     * The resource GUID property of the service endpoint policy resource.
     */
    readonly resourceGuid: string;
    /**
     * A collection of service endpoint policy definitions of the service endpoint policy.
     */
    readonly serviceEndpointPolicyDefinitions?: outputs.network.v20200301.ServiceEndpointPolicyDefinitionResponse[];
    /**
     * A collection of references to subnets.
     */
    readonly subnets: outputs.network.v20200301.SubnetResponse[];
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
}

export function getServiceEndpointPolicyOutput(args: GetServiceEndpointPolicyOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetServiceEndpointPolicyResult> {
    return pulumi.output(args).apply(a => getServiceEndpointPolicy(a, opts))
}

export interface GetServiceEndpointPolicyOutputArgs {
    /**
     * Expands referenced resources.
     */
    expand?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the service endpoint policy.
     */
    serviceEndpointPolicyName: pulumi.Input<string>;
}
