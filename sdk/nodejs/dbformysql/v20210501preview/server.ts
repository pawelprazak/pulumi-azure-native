// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Represents a server.
 */
export class Server extends pulumi.CustomResource {
    /**
     * Get an existing Server resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Server {
        return new Server(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:dbformysql/v20210501preview:Server';

    /**
     * Returns true if the given object is an instance of Server.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Server {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Server.__pulumiType;
    }

    /**
     * The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation).
     */
    public readonly administratorLogin!: pulumi.Output<string | undefined>;
    /**
     * availability Zone information of the server.
     */
    public readonly availabilityZone!: pulumi.Output<string | undefined>;
    /**
     * Backup related properties of a server.
     */
    public readonly backup!: pulumi.Output<outputs.dbformysql.v20210501preview.BackupResponse | undefined>;
    /**
     * The fully qualified domain name of a server.
     */
    public /*out*/ readonly fullyQualifiedDomainName!: pulumi.Output<string>;
    /**
     * High availability related properties of a server.
     */
    public readonly highAvailability!: pulumi.Output<outputs.dbformysql.v20210501preview.HighAvailabilityResponse | undefined>;
    /**
     * The Azure Active Directory identity of the server.
     */
    public readonly identity!: pulumi.Output<outputs.dbformysql.v20210501preview.IdentityResponse | undefined>;
    /**
     * The geo-location where the resource lives
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Maintenance window of a server.
     */
    public readonly maintenanceWindow!: pulumi.Output<outputs.dbformysql.v20210501preview.MaintenanceWindowResponse | undefined>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Network related properties of a server.
     */
    public readonly network!: pulumi.Output<outputs.dbformysql.v20210501preview.NetworkResponse | undefined>;
    /**
     * The maximum number of replicas that a primary server can have.
     */
    public /*out*/ readonly replicaCapacity!: pulumi.Output<number>;
    /**
     * The replication role.
     */
    public readonly replicationRole!: pulumi.Output<string | undefined>;
    /**
     * The SKU (pricing tier) of the server.
     */
    public readonly sku!: pulumi.Output<outputs.dbformysql.v20210501preview.SkuResponse | undefined>;
    /**
     * The source MySQL server id.
     */
    public readonly sourceServerResourceId!: pulumi.Output<string | undefined>;
    /**
     * The state of a server.
     */
    public /*out*/ readonly state!: pulumi.Output<string>;
    /**
     * Storage related properties of a server.
     */
    public readonly storage!: pulumi.Output<outputs.dbformysql.v20210501preview.StorageResponse | undefined>;
    /**
     * The system metadata relating to this resource.
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.dbformysql.v20210501preview.SystemDataResponse>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Server version.
     */
    public readonly version!: pulumi.Output<string | undefined>;

    /**
     * Create a Server resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ServerArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            resourceInputs["administratorLogin"] = args ? args.administratorLogin : undefined;
            resourceInputs["administratorLoginPassword"] = args ? args.administratorLoginPassword : undefined;
            resourceInputs["availabilityZone"] = args ? args.availabilityZone : undefined;
            resourceInputs["backup"] = args ? args.backup : undefined;
            resourceInputs["createMode"] = args ? args.createMode : undefined;
            resourceInputs["highAvailability"] = args ? args.highAvailability : undefined;
            resourceInputs["identity"] = args ? args.identity : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["maintenanceWindow"] = args ? args.maintenanceWindow : undefined;
            resourceInputs["network"] = args ? args.network : undefined;
            resourceInputs["replicationRole"] = args ? args.replicationRole : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["restorePointInTime"] = args ? args.restorePointInTime : undefined;
            resourceInputs["serverName"] = args ? args.serverName : undefined;
            resourceInputs["sku"] = args ? args.sku : undefined;
            resourceInputs["sourceServerResourceId"] = args ? args.sourceServerResourceId : undefined;
            resourceInputs["storage"] = args ? args.storage : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["version"] = args ? args.version : undefined;
            resourceInputs["fullyQualifiedDomainName"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["replicaCapacity"] = undefined /*out*/;
            resourceInputs["state"] = undefined /*out*/;
            resourceInputs["systemData"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["administratorLogin"] = undefined /*out*/;
            resourceInputs["availabilityZone"] = undefined /*out*/;
            resourceInputs["backup"] = undefined /*out*/;
            resourceInputs["fullyQualifiedDomainName"] = undefined /*out*/;
            resourceInputs["highAvailability"] = undefined /*out*/;
            resourceInputs["identity"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["maintenanceWindow"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["network"] = undefined /*out*/;
            resourceInputs["replicaCapacity"] = undefined /*out*/;
            resourceInputs["replicationRole"] = undefined /*out*/;
            resourceInputs["sku"] = undefined /*out*/;
            resourceInputs["sourceServerResourceId"] = undefined /*out*/;
            resourceInputs["state"] = undefined /*out*/;
            resourceInputs["storage"] = undefined /*out*/;
            resourceInputs["systemData"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
            resourceInputs["version"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:dbformysql/v20200701preview:Server" }, { type: "azure-native:dbformysql/v20200701privatepreview:Server" }, { type: "azure-native:dbformysql/v20210501:Server" }, { type: "azure-native:dbformysql/v20211201preview:Server" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(Server.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a Server resource.
 */
export interface ServerArgs {
    /**
     * The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation).
     */
    administratorLogin?: pulumi.Input<string>;
    /**
     * The password of the administrator login (required for server creation).
     */
    administratorLoginPassword?: pulumi.Input<string>;
    /**
     * availability Zone information of the server.
     */
    availabilityZone?: pulumi.Input<string>;
    /**
     * Backup related properties of a server.
     */
    backup?: pulumi.Input<inputs.dbformysql.v20210501preview.BackupArgs>;
    /**
     * The mode to create a new MySQL server.
     */
    createMode?: pulumi.Input<string | enums.dbformysql.v20210501preview.CreateMode>;
    /**
     * High availability related properties of a server.
     */
    highAvailability?: pulumi.Input<inputs.dbformysql.v20210501preview.HighAvailabilityArgs>;
    /**
     * The Azure Active Directory identity of the server.
     */
    identity?: pulumi.Input<inputs.dbformysql.v20210501preview.IdentityArgs>;
    /**
     * The geo-location where the resource lives
     */
    location?: pulumi.Input<string>;
    /**
     * Maintenance window of a server.
     */
    maintenanceWindow?: pulumi.Input<inputs.dbformysql.v20210501preview.MaintenanceWindowArgs>;
    /**
     * Network related properties of a server.
     */
    network?: pulumi.Input<inputs.dbformysql.v20210501preview.NetworkArgs>;
    /**
     * The replication role.
     */
    replicationRole?: pulumi.Input<string | enums.dbformysql.v20210501preview.ReplicationRole>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Restore point creation time (ISO8601 format), specifying the time to restore from.
     */
    restorePointInTime?: pulumi.Input<string>;
    /**
     * The name of the server.
     */
    serverName?: pulumi.Input<string>;
    /**
     * The SKU (pricing tier) of the server.
     */
    sku?: pulumi.Input<inputs.dbformysql.v20210501preview.SkuArgs>;
    /**
     * The source MySQL server id.
     */
    sourceServerResourceId?: pulumi.Input<string>;
    /**
     * Storage related properties of a server.
     */
    storage?: pulumi.Input<inputs.dbformysql.v20210501preview.StorageArgs>;
    /**
     * Resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Server version.
     */
    version?: pulumi.Input<string | enums.dbformysql.v20210501preview.ServerVersion>;
}
