// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Pageable list of products.
 * API Version: 2017-06-01.
 */
export function listProducts(args: ListProductsArgs, opts?: pulumi.InvokeOptions): Promise<ListProductsResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:azurestack:listProducts", {
        "productName": args.productName,
        "registrationName": args.registrationName,
        "resourceGroup": args.resourceGroup,
    }, opts);
}

export interface ListProductsArgs {
    /**
     * Name of the product.
     */
    productName: string;
    /**
     * Name of the Azure Stack registration.
     */
    registrationName: string;
    /**
     * Name of the resource group.
     */
    resourceGroup: string;
}

/**
 * Pageable list of products.
 */
export interface ListProductsResult {
    /**
     * URI to the next page.
     */
    readonly nextLink?: string;
    /**
     * List of products.
     */
    readonly value?: outputs.azurestack.ProductResponse[];
}

export function listProductsOutput(args: ListProductsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListProductsResult> {
    return pulumi.output(args).apply(a => listProducts(a, opts))
}

export interface ListProductsOutputArgs {
    /**
     * Name of the product.
     */
    productName: pulumi.Input<string>;
    /**
     * Name of the Azure Stack registration.
     */
    registrationName: pulumi.Input<string>;
    /**
     * Name of the resource group.
     */
    resourceGroup: pulumi.Input<string>;
}
