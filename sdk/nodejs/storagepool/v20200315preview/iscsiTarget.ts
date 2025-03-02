// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Response for iSCSI target requests.
 */
export class IscsiTarget extends pulumi.CustomResource {
    /**
     * Get an existing IscsiTarget resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): IscsiTarget {
        return new IscsiTarget(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:storagepool/v20200315preview:IscsiTarget';

    /**
     * Returns true if the given object is an instance of IscsiTarget.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is IscsiTarget {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === IscsiTarget.__pulumiType;
    }

    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * State of the operation on the resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Operational status of the iSCSI target.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * iSCSI target IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:server".
     */
    public readonly targetIqn!: pulumi.Output<string>;
    /**
     * List of iSCSI target portal groups. Can have 1 portal group at most.
     */
    public readonly tpgs!: pulumi.Output<outputs.storagepool.v20200315preview.TargetPortalGroupResponse[]>;
    /**
     * The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a IscsiTarget resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: IscsiTargetArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.diskPoolName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'diskPoolName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.tpgs === undefined) && !opts.urn) {
                throw new Error("Missing required property 'tpgs'");
            }
            resourceInputs["diskPoolName"] = args ? args.diskPoolName : undefined;
            resourceInputs["iscsiTargetName"] = args ? args.iscsiTargetName : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["targetIqn"] = args ? args.targetIqn : undefined;
            resourceInputs["tpgs"] = args ? args.tpgs : undefined;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["status"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["status"] = undefined /*out*/;
            resourceInputs["targetIqn"] = undefined /*out*/;
            resourceInputs["tpgs"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:storagepool:IscsiTarget" }, { type: "azure-native:storagepool/v20210401preview:IscsiTarget" }, { type: "azure-native:storagepool/v20210801:IscsiTarget" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(IscsiTarget.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a IscsiTarget resource.
 */
export interface IscsiTargetArgs {
    /**
     * The name of the Disk pool.
     */
    diskPoolName: pulumi.Input<string>;
    /**
     * The name of the iSCSI target.
     */
    iscsiTargetName?: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * iSCSI target IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:server".
     */
    targetIqn?: pulumi.Input<string>;
    /**
     * List of iSCSI target portal groups. Can have 1 portal group at most.
     */
    tpgs: pulumi.Input<pulumi.Input<inputs.storagepool.v20200315preview.TargetPortalGroupCreateArgs>[]>;
}
