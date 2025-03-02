// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function getSkusNestedResourceTypeFirst(args: GetSkusNestedResourceTypeFirstArgs, opts?: pulumi.InvokeOptions): Promise<GetSkusNestedResourceTypeFirstResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:providerhub/v20201120:getSkusNestedResourceTypeFirst", {
        "nestedResourceTypeFirst": args.nestedResourceTypeFirst,
        "providerNamespace": args.providerNamespace,
        "resourceType": args.resourceType,
        "sku": args.sku,
    }, opts);
}

export interface GetSkusNestedResourceTypeFirstArgs {
    /**
     * The first child resource type.
     */
    nestedResourceTypeFirst: string;
    /**
     * The name of the resource provider hosted within ProviderHub.
     */
    providerNamespace: string;
    /**
     * The resource type.
     */
    resourceType: string;
    /**
     * The SKU.
     */
    sku: string;
}

export interface GetSkusNestedResourceTypeFirstResult {
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    readonly properties: outputs.providerhub.v20201120.SkuResourceResponseProperties;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}

export function getSkusNestedResourceTypeFirstOutput(args: GetSkusNestedResourceTypeFirstOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSkusNestedResourceTypeFirstResult> {
    return pulumi.output(args).apply(a => getSkusNestedResourceTypeFirst(a, opts))
}

export interface GetSkusNestedResourceTypeFirstOutputArgs {
    /**
     * The first child resource type.
     */
    nestedResourceTypeFirst: pulumi.Input<string>;
    /**
     * The name of the resource provider hosted within ProviderHub.
     */
    providerNamespace: pulumi.Input<string>;
    /**
     * The resource type.
     */
    resourceType: pulumi.Input<string>;
    /**
     * The SKU.
     */
    sku: pulumi.Input<string>;
}
