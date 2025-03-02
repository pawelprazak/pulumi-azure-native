// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Volume resource
 */
/** @deprecated Version 2020-02-01 will be removed in v2 of the provider. */
export function getVolume(args: GetVolumeArgs, opts?: pulumi.InvokeOptions): Promise<GetVolumeResult> {
    pulumi.log.warn("getVolume is deprecated: Version 2020-02-01 will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:netapp/v20200201:getVolume", {
        "accountName": args.accountName,
        "poolName": args.poolName,
        "resourceGroupName": args.resourceGroupName,
        "volumeName": args.volumeName,
    }, opts);
}

export interface GetVolumeArgs {
    /**
     * The name of the NetApp account
     */
    accountName: string;
    /**
     * The name of the capacity pool
     */
    poolName: string;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
    /**
     * The name of the volume
     */
    volumeName: string;
}

/**
 * Volume resource
 */
export interface GetVolumeResult {
    /**
     * Unique Baremetal Tenant Identifier.
     */
    readonly baremetalTenantId: string;
    /**
     * A unique file path for the volume. Used when creating mount targets
     */
    readonly creationToken: string;
    /**
     * DataProtection type volumes include an object containing details of the replication
     */
    readonly dataProtection?: outputs.netapp.v20200201.VolumePropertiesResponseDataProtection;
    /**
     * Set of export policy rules
     */
    readonly exportPolicy?: outputs.netapp.v20200201.VolumePropertiesResponseExportPolicy;
    /**
     * Unique FileSystem Identifier.
     */
    readonly fileSystemId: string;
    /**
     * Resource Id
     */
    readonly id: string;
    /**
     * Restoring
     */
    readonly isRestoring?: boolean;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * List of mount targets
     */
    readonly mountTargets: outputs.netapp.v20200201.MountTargetPropertiesResponse[];
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Set of protocol types, default NFSv3, CIFS for SMB protocol
     */
    readonly protocolTypes?: string[];
    /**
     * Azure lifecycle management
     */
    readonly provisioningState: string;
    /**
     * The service level of the file system
     */
    readonly serviceLevel?: string;
    /**
     * If enabled (true) the volume will contain a read-only .snapshot directory which provides access to each of the volume's snapshots (default to true).
     */
    readonly snapshotDirectoryVisible?: boolean;
    /**
     * UUID v4 or resource identifier used to identify the Snapshot.
     */
    readonly snapshotId?: string;
    /**
     * The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes
     */
    readonly subnetId: string;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type: string;
    /**
     * Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. Minimum size is 100 GiB. Upper limit is 100TiB. Specified in bytes.
     */
    readonly usageThreshold: number;
    /**
     * Resource size in bytes, current storage usage for the volume in bytes
     */
    readonly usedBytes: number;
    /**
     * What type of volume is this
     */
    readonly volumeType?: string;
}

export function getVolumeOutput(args: GetVolumeOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetVolumeResult> {
    return pulumi.output(args).apply(a => getVolume(a, opts))
}

export interface GetVolumeOutputArgs {
    /**
     * The name of the NetApp account
     */
    accountName: pulumi.Input<string>;
    /**
     * The name of the capacity pool
     */
    poolName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the volume
     */
    volumeName: pulumi.Input<string>;
}
