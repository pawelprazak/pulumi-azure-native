// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Represents a share on the  Data Box Edge/Gateway device.
 */
/** @deprecated Version 2019-07-01 will be removed in v2 of the provider. */
export function getShare(args: GetShareArgs, opts?: pulumi.InvokeOptions): Promise<GetShareResult> {
    pulumi.log.warn("getShare is deprecated: Version 2019-07-01 will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:databoxedge/v20190701:getShare", {
        "deviceName": args.deviceName,
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetShareArgs {
    /**
     * The device name.
     */
    deviceName: string;
    /**
     * The share name.
     */
    name: string;
    /**
     * The resource group name.
     */
    resourceGroupName: string;
}

/**
 * Represents a share on the  Data Box Edge/Gateway device.
 */
export interface GetShareResult {
    /**
     * Access protocol to be used by the share.
     */
    readonly accessProtocol: string;
    /**
     * Azure container mapping for the share.
     */
    readonly azureContainerInfo?: outputs.databoxedge.v20190701.AzureContainerInfoResponse;
    /**
     * List of IP addresses and corresponding access rights on the share(required for NFS protocol).
     */
    readonly clientAccessRights?: outputs.databoxedge.v20190701.ClientAccessRightResponse[];
    /**
     * Data policy of the share.
     */
    readonly dataPolicy?: string;
    /**
     * Description for the share.
     */
    readonly description?: string;
    /**
     * The path ID that uniquely identifies the object.
     */
    readonly id: string;
    /**
     * Current monitoring status of the share.
     */
    readonly monitoringStatus: string;
    /**
     * The object name.
     */
    readonly name: string;
    /**
     * Details of the refresh job on this share.
     */
    readonly refreshDetails?: outputs.databoxedge.v20190701.RefreshDetailsResponse;
    /**
     * Share mount point to the role.
     */
    readonly shareMappings: outputs.databoxedge.v20190701.MountPointMapResponse[];
    /**
     * Current status of the share.
     */
    readonly shareStatus: string;
    /**
     * The hierarchical type of the object.
     */
    readonly type: string;
    /**
     * Mapping of users and corresponding access rights on the share (required for SMB protocol).
     */
    readonly userAccessRights?: outputs.databoxedge.v20190701.UserAccessRightResponse[];
}

export function getShareOutput(args: GetShareOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetShareResult> {
    return pulumi.output(args).apply(a => getShare(a, opts))
}

export interface GetShareOutputArgs {
    /**
     * The device name.
     */
    deviceName: pulumi.Input<string>;
    /**
     * The share name.
     */
    name: pulumi.Input<string>;
    /**
     * The resource group name.
     */
    resourceGroupName: pulumi.Input<string>;
}
