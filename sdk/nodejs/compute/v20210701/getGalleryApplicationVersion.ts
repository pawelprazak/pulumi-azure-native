// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Specifies information about the gallery Application Version that you want to create or update.
 */
export function getGalleryApplicationVersion(args: GetGalleryApplicationVersionArgs, opts?: pulumi.InvokeOptions): Promise<GetGalleryApplicationVersionResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:compute/v20210701:getGalleryApplicationVersion", {
        "expand": args.expand,
        "galleryApplicationName": args.galleryApplicationName,
        "galleryApplicationVersionName": args.galleryApplicationVersionName,
        "galleryName": args.galleryName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetGalleryApplicationVersionArgs {
    /**
     * The expand expression to apply on the operation.
     */
    expand?: string;
    /**
     * The name of the gallery Application Definition in which the Application Version resides.
     */
    galleryApplicationName: string;
    /**
     * The name of the gallery Application Version to be retrieved.
     */
    galleryApplicationVersionName: string;
    /**
     * The name of the Shared Application Gallery in which the Application Definition resides.
     */
    galleryName: string;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
}

/**
 * Specifies information about the gallery Application Version that you want to create or update.
 */
export interface GetGalleryApplicationVersionResult {
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
     * The provisioning state, which only appears in the response.
     */
    readonly provisioningState: string;
    /**
     * The publishing profile of a gallery image version.
     */
    readonly publishingProfile: outputs.compute.v20210701.GalleryApplicationVersionPublishingProfileResponse;
    /**
     * This is the replication status of the gallery image version.
     */
    readonly replicationStatus: outputs.compute.v20210701.ReplicationStatusResponse;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type: string;
}

export function getGalleryApplicationVersionOutput(args: GetGalleryApplicationVersionOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetGalleryApplicationVersionResult> {
    return pulumi.output(args).apply(a => getGalleryApplicationVersion(a, opts))
}

export interface GetGalleryApplicationVersionOutputArgs {
    /**
     * The expand expression to apply on the operation.
     */
    expand?: pulumi.Input<string>;
    /**
     * The name of the gallery Application Definition in which the Application Version resides.
     */
    galleryApplicationName: pulumi.Input<string>;
    /**
     * The name of the gallery Application Version to be retrieved.
     */
    galleryApplicationVersionName: pulumi.Input<string>;
    /**
     * The name of the Shared Application Gallery in which the Application Definition resides.
     */
    galleryName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
}
