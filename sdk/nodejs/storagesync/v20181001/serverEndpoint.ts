// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Server Endpoint object.
 *
 * @deprecated Version 2018-10-01 will be removed in v2 of the provider.
 */
export class ServerEndpoint extends pulumi.CustomResource {
    /**
     * Get an existing ServerEndpoint resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ServerEndpoint {
        pulumi.log.warn("ServerEndpoint is deprecated: Version 2018-10-01 will be removed in v2 of the provider.")
        return new ServerEndpoint(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:storagesync/v20181001:ServerEndpoint';

    /**
     * Returns true if the given object is an instance of ServerEndpoint.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ServerEndpoint {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ServerEndpoint.__pulumiType;
    }

    /**
     * Cloud Tiering.
     */
    public readonly cloudTiering!: pulumi.Output<string | undefined>;
    /**
     * Friendly Name
     */
    public readonly friendlyName!: pulumi.Output<string | undefined>;
    /**
     * Resource Last Operation Name
     */
    public /*out*/ readonly lastOperationName!: pulumi.Output<string | undefined>;
    /**
     * ServerEndpoint lastWorkflowId
     */
    public /*out*/ readonly lastWorkflowId!: pulumi.Output<string | undefined>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Offline data transfer
     */
    public readonly offlineDataTransfer!: pulumi.Output<string | undefined>;
    /**
     * Offline data transfer share name
     */
    public readonly offlineDataTransferShareName!: pulumi.Output<string | undefined>;
    /**
     * Offline data transfer storage account resource ID
     */
    public /*out*/ readonly offlineDataTransferStorageAccountResourceId!: pulumi.Output<string>;
    /**
     * Offline data transfer storage account tenant ID
     */
    public /*out*/ readonly offlineDataTransferStorageAccountTenantId!: pulumi.Output<string>;
    /**
     * ServerEndpoint Provisioning State
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string | undefined>;
    /**
     * Server Local path.
     */
    public readonly serverLocalPath!: pulumi.Output<string | undefined>;
    /**
     * Server Resource Id.
     */
    public readonly serverResourceId!: pulumi.Output<string | undefined>;
    /**
     * Server Endpoint properties.
     */
    public /*out*/ readonly syncStatus!: pulumi.Output<outputs.storagesync.v20181001.ServerEndpointHealthResponse | undefined>;
    /**
     * Tier files older than days.
     */
    public readonly tierFilesOlderThanDays!: pulumi.Output<number | undefined>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Level of free space to be maintained by Cloud Tiering if it is enabled.
     */
    public readonly volumeFreeSpacePercent!: pulumi.Output<number | undefined>;

    /**
     * Create a ServerEndpoint resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Version 2018-10-01 will be removed in v2 of the provider. */
    constructor(name: string, args: ServerEndpointArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("ServerEndpoint is deprecated: Version 2018-10-01 will be removed in v2 of the provider.")
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.storageSyncServiceName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'storageSyncServiceName'");
            }
            if ((!args || args.syncGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'syncGroupName'");
            }
            resourceInputs["cloudTiering"] = args ? args.cloudTiering : undefined;
            resourceInputs["friendlyName"] = args ? args.friendlyName : undefined;
            resourceInputs["offlineDataTransfer"] = args ? args.offlineDataTransfer : undefined;
            resourceInputs["offlineDataTransferShareName"] = args ? args.offlineDataTransferShareName : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["serverEndpointName"] = args ? args.serverEndpointName : undefined;
            resourceInputs["serverLocalPath"] = args ? args.serverLocalPath : undefined;
            resourceInputs["serverResourceId"] = args ? args.serverResourceId : undefined;
            resourceInputs["storageSyncServiceName"] = args ? args.storageSyncServiceName : undefined;
            resourceInputs["syncGroupName"] = args ? args.syncGroupName : undefined;
            resourceInputs["tierFilesOlderThanDays"] = args ? args.tierFilesOlderThanDays : undefined;
            resourceInputs["volumeFreeSpacePercent"] = args ? args.volumeFreeSpacePercent : undefined;
            resourceInputs["lastOperationName"] = undefined /*out*/;
            resourceInputs["lastWorkflowId"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["offlineDataTransferStorageAccountResourceId"] = undefined /*out*/;
            resourceInputs["offlineDataTransferStorageAccountTenantId"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["syncStatus"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["cloudTiering"] = undefined /*out*/;
            resourceInputs["friendlyName"] = undefined /*out*/;
            resourceInputs["lastOperationName"] = undefined /*out*/;
            resourceInputs["lastWorkflowId"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["offlineDataTransfer"] = undefined /*out*/;
            resourceInputs["offlineDataTransferShareName"] = undefined /*out*/;
            resourceInputs["offlineDataTransferStorageAccountResourceId"] = undefined /*out*/;
            resourceInputs["offlineDataTransferStorageAccountTenantId"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["serverLocalPath"] = undefined /*out*/;
            resourceInputs["serverResourceId"] = undefined /*out*/;
            resourceInputs["syncStatus"] = undefined /*out*/;
            resourceInputs["tierFilesOlderThanDays"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
            resourceInputs["volumeFreeSpacePercent"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:storagesync:ServerEndpoint" }, { type: "azure-native:storagesync/v20170605preview:ServerEndpoint" }, { type: "azure-native:storagesync/v20180402:ServerEndpoint" }, { type: "azure-native:storagesync/v20180701:ServerEndpoint" }, { type: "azure-native:storagesync/v20190201:ServerEndpoint" }, { type: "azure-native:storagesync/v20190301:ServerEndpoint" }, { type: "azure-native:storagesync/v20190601:ServerEndpoint" }, { type: "azure-native:storagesync/v20191001:ServerEndpoint" }, { type: "azure-native:storagesync/v20200301:ServerEndpoint" }, { type: "azure-native:storagesync/v20200901:ServerEndpoint" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(ServerEndpoint.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a ServerEndpoint resource.
 */
export interface ServerEndpointArgs {
    /**
     * Cloud Tiering.
     */
    cloudTiering?: pulumi.Input<string>;
    /**
     * Friendly Name
     */
    friendlyName?: pulumi.Input<string>;
    /**
     * Offline data transfer
     */
    offlineDataTransfer?: pulumi.Input<string>;
    /**
     * Offline data transfer share name
     */
    offlineDataTransferShareName?: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Name of Server Endpoint object.
     */
    serverEndpointName?: pulumi.Input<string>;
    /**
     * Server Local path.
     */
    serverLocalPath?: pulumi.Input<string>;
    /**
     * Server Resource Id.
     */
    serverResourceId?: pulumi.Input<string>;
    /**
     * Name of Storage Sync Service resource.
     */
    storageSyncServiceName: pulumi.Input<string>;
    /**
     * Name of Sync Group resource.
     */
    syncGroupName: pulumi.Input<string>;
    /**
     * Tier files older than days.
     */
    tierFilesOlderThanDays?: pulumi.Input<number>;
    /**
     * Level of free space to be maintained by Cloud Tiering if it is enabled.
     */
    volumeFreeSpacePercent?: pulumi.Input<number>;
}
