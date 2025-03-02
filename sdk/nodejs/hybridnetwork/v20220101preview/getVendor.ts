// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Vendor resource.
 */
export function getVendor(args: GetVendorArgs, opts?: pulumi.InvokeOptions): Promise<GetVendorResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:hybridnetwork/v20220101preview:getVendor", {
        "vendorName": args.vendorName,
    }, opts);
}

export interface GetVendorArgs {
    /**
     * The name of the vendor.
     */
    vendorName: string;
}

/**
 * Vendor resource.
 */
export interface GetVendorResult {
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The provisioning state of the vendor resource.
     */
    readonly provisioningState: string;
    /**
     * A list of IDs of the vendor skus offered by the vendor.
     */
    readonly skus: outputs.hybridnetwork.v20220101preview.SubResourceResponse[];
    /**
     * The system meta data relating to this resource.
     */
    readonly systemData: outputs.hybridnetwork.v20220101preview.SystemDataResponse;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}

export function getVendorOutput(args: GetVendorOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetVendorResult> {
    return pulumi.output(args).apply(a => getVendor(a, opts))
}

export interface GetVendorOutputArgs {
    /**
     * The name of the vendor.
     */
    vendorName: pulumi.Input<string>;
}
