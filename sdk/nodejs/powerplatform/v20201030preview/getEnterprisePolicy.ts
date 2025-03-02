// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Definition of the EnterprisePolicy.
 */
export function getEnterprisePolicy(args: GetEnterprisePolicyArgs, opts?: pulumi.InvokeOptions): Promise<GetEnterprisePolicyResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:powerplatform/v20201030preview:getEnterprisePolicy", {
        "enterprisePolicyName": args.enterprisePolicyName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetEnterprisePolicyArgs {
    /**
     * The EnterprisePolicy name.
     */
    enterprisePolicyName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
}

/**
 * Definition of the EnterprisePolicy.
 */
export interface GetEnterprisePolicyResult {
    /**
     * The encryption settings for a configuration store.
     */
    readonly encryption?: outputs.powerplatform.v20201030preview.PropertiesResponseEncryption;
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * The identity of the EnterprisePolicy.
     */
    readonly identity?: outputs.powerplatform.v20201030preview.EnterprisePolicyIdentityResponse;
    /**
     * The kind (type) of Enterprise Policy.
     */
    readonly kind: string;
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * Settings concerning lockbox.
     */
    readonly lockbox?: outputs.powerplatform.v20201030preview.PropertiesResponseLockbox;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Settings concerning network injection.
     */
    readonly networkInjection?: outputs.powerplatform.v20201030preview.PropertiesResponseNetworkInjection;
    /**
     * Metadata pertaining to creation and last modification of the resource.
     */
    readonly systemData: outputs.powerplatform.v20201030preview.SystemDataResponse;
    /**
     * The internally assigned unique identifier of the resource.
     */
    readonly systemId: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}

export function getEnterprisePolicyOutput(args: GetEnterprisePolicyOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetEnterprisePolicyResult> {
    return pulumi.output(args).apply(a => getEnterprisePolicy(a, opts))
}

export interface GetEnterprisePolicyOutputArgs {
    /**
     * The EnterprisePolicy name.
     */
    enterprisePolicyName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
}
