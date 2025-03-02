// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Represents an image from the Azure Marketplace
 * API Version: 2018-10-15.
 */
export function getGalleryImage(args: GetGalleryImageArgs, opts?: pulumi.InvokeOptions): Promise<GetGalleryImageResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:labservices:getGalleryImage", {
        "expand": args.expand,
        "galleryImageName": args.galleryImageName,
        "labAccountName": args.labAccountName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetGalleryImageArgs {
    /**
     * Specify the $expand query. Example: 'properties($select=author)'
     */
    expand?: string;
    /**
     * The name of the gallery Image.
     */
    galleryImageName: string;
    /**
     * The name of the lab Account.
     */
    labAccountName: string;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
}

/**
 * Represents an image from the Azure Marketplace
 */
export interface GetGalleryImageResult {
    /**
     * The author of the gallery image.
     */
    readonly author: string;
    /**
     * The creation date of the gallery image.
     */
    readonly createdDate: string;
    /**
     * The description of the gallery image.
     */
    readonly description: string;
    /**
     * The icon of the gallery image.
     */
    readonly icon: string;
    /**
     * The identifier of the resource.
     */
    readonly id: string;
    /**
     * The image reference of the gallery image.
     */
    readonly imageReference: outputs.labservices.GalleryImageReferenceResponse;
    /**
     * Indicates whether this gallery image is enabled.
     */
    readonly isEnabled?: boolean;
    /**
     * Indicates whether this gallery has been overridden for this lab account
     */
    readonly isOverride?: boolean;
    /**
     * Indicates if the plan has been authorized for programmatic deployment.
     */
    readonly isPlanAuthorized?: boolean;
    /**
     * The details of the latest operation. ex: status, error
     */
    readonly latestOperationResult: outputs.labservices.LatestOperationResultResponse;
    /**
     * The location of the resource.
     */
    readonly location?: string;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * The third party plan that applies to this image
     */
    readonly planId: string;
    /**
     * The provisioning status of the resource.
     */
    readonly provisioningState?: string;
    /**
     * The tags of the resource.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource.
     */
    readonly type: string;
    /**
     * The unique immutable identifier of a resource (Guid).
     */
    readonly uniqueIdentifier?: string;
}

export function getGalleryImageOutput(args: GetGalleryImageOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetGalleryImageResult> {
    return pulumi.output(args).apply(a => getGalleryImage(a, opts))
}

export interface GetGalleryImageOutputArgs {
    /**
     * Specify the $expand query. Example: 'properties($select=author)'
     */
    expand?: pulumi.Input<string>;
    /**
     * The name of the gallery Image.
     */
    galleryImageName: pulumi.Input<string>;
    /**
     * The name of the lab Account.
     */
    labAccountName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
}
