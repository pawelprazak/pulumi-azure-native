// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * A class representing a CommunicationService resource.
 */
export function getCommunicationService(args: GetCommunicationServiceArgs, opts?: pulumi.InvokeOptions): Promise<GetCommunicationServiceResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:communication/v20200820preview:getCommunicationService", {
        "communicationServiceName": args.communicationServiceName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetCommunicationServiceArgs {
    /**
     * The name of the CommunicationService resource.
     */
    communicationServiceName: string;
    /**
     * The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    resourceGroupName: string;
}

/**
 * A class representing a CommunicationService resource.
 */
export interface GetCommunicationServiceResult {
    /**
     * The location where the communication service stores its data at rest.
     */
    readonly dataLocation: string;
    /**
     * FQDN of the CommunicationService instance.
     */
    readonly hostName: string;
    /**
     * Fully qualified resource ID for the resource.
     */
    readonly id: string;
    /**
     * The immutable resource Id of the communication service.
     */
    readonly immutableResourceId: string;
    /**
     * The Azure location where the CommunicationService is running.
     */
    readonly location?: string;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * Resource ID of an Azure Notification Hub linked to this resource.
     */
    readonly notificationHubId: string;
    /**
     * Provisioning state of the resource.
     */
    readonly provisioningState: string;
    /**
     * Tags of the service which is a list of key value pairs that describe the resource.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the service - e.g. "Microsoft.Communication/CommunicationServices"
     */
    readonly type: string;
    /**
     * Version of the CommunicationService resource. Probably you need the same or higher version of client SDKs.
     */
    readonly version: string;
}

export function getCommunicationServiceOutput(args: GetCommunicationServiceOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCommunicationServiceResult> {
    return pulumi.output(args).apply(a => getCommunicationService(a, opts))
}

export interface GetCommunicationServiceOutputArgs {
    /**
     * The name of the CommunicationService resource.
     */
    communicationServiceName: pulumi.Input<string>;
    /**
     * The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    resourceGroupName: pulumi.Input<string>;
}
