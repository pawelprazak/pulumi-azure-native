// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * A DDoS custom policy in a resource group.
 */
export function getDdosCustomPolicy(args: GetDdosCustomPolicyArgs, opts?: pulumi.InvokeOptions): Promise<GetDdosCustomPolicyResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:network/v20181101:getDdosCustomPolicy", {
        "ddosCustomPolicyName": args.ddosCustomPolicyName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetDdosCustomPolicyArgs {
    /**
     * The name of the DDoS custom policy.
     */
    ddosCustomPolicyName: string;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
}

/**
 * A DDoS custom policy in a resource group.
 */
export interface GetDdosCustomPolicyResult {
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
     * The protocol-specific DDoS policy customization parameters.
     */
    readonly protocolCustomSettings?: outputs.network.v20181101.ProtocolCustomSettingsFormatResponse[];
    /**
     * The provisioning state of the DDoS custom policy resource. Possible values are: 'Succeeded', 'Updating', 'Deleting', and 'Failed'.
     */
    readonly provisioningState: string;
    /**
     * The list of public IPs associated with the DDoS custom policy resource. This list is read-only.
     */
    readonly publicIPAddresses: outputs.network.v20181101.SubResourceResponse[];
    /**
     * The resource GUID property of the DDoS custom policy resource. It uniquely identifies the resource, even if the user changes its name or migrate the resource across subscriptions or resource groups.
     */
    readonly resourceGuid: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
}

export function getDdosCustomPolicyOutput(args: GetDdosCustomPolicyOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDdosCustomPolicyResult> {
    return pulumi.output(args).apply(a => getDdosCustomPolicy(a, opts))
}

export interface GetDdosCustomPolicyOutputArgs {
    /**
     * The name of the DDoS custom policy.
     */
    ddosCustomPolicyName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
}
